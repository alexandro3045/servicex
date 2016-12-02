using AutoMapper;
using Contracts;
using Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Mapping
{
    public class EntityMapper<TDomainModel, TDataModel , TId> : IEntityMapper<TDomainModel, TDataModel, TId>
        where TDomainModel : Entity
         where TDataModel : EntityContracts
        where TId : struct
    {
        private readonly IServiceLocator _serviceLocator;

        public EntityMapper(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;

            //Domain To Entity
            Mapper.CreateMap<TDomainModel, TDataModel>()
                .IgnoreDataObjects<TDomainModel, TDataModel, TId>()
                .AfterMap((source, destination) =>
                {
                    var destinationType = typeof(TDataModel);
                    var sourceType = typeof(TDomainModel);

                    foreach (var property in sourceType.GetProperties())
                    {
                        var sourcePropertyType = property.PropertyType;
                        if (sourcePropertyType.IsSubclassOf(typeof(BaseDomainModel<TId>)) && !property.HasAttribute<MapperIgnoreAttribute>())
                        {
                            dynamic sourcePropertyValue = property.GetValue(source);
                            var destinationProperty = destinationType.GetProperty(sourcePropertyType.Name);
                            var destinationPropertyType = destinationProperty.PropertyType;

                            if (!destinationProperty.HasAttribute<MapperIgnoreAttribute>() && sourcePropertyValue != null)
                            {
                                if (sourcePropertyValue.ModelState == BaseDomainModelState.New)
                                {
                                    var destinationObject = Activator.CreateInstance(destinationPropertyType);

                                    Mapper.Map(sourcePropertyValue, destinationObject);

                                    destinationType.GetProperty(sourcePropertyType.Name).SetValue(destination, destinationObject);
                                }
                                else if (sourcePropertyValue.ModelState == BaseDomainModelState.Modified)
                                {
                                    dynamic destinationPropertyValue = destinationProperty.GetValue(destination);

                                    Mapper.Map(sourcePropertyValue, destinationPropertyValue, sourcePropertyType, destinationPropertyType);

                                    var context = _serviceLocator.GetInstance<IDbContext>();
                                    context.SetModified(destinationPropertyValue);
                                }
                            }
                        }
                        else if (sourcePropertyType.IsGenericType && sourcePropertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                        {
                            var sourceEnumerationType = sourcePropertyType.GetGenericArguments()[0];

                            if (sourceEnumerationType != null && sourceEnumerationType.IsSubclassOf(typeof(BaseDomainModel<TId>)) && !property.HasAttribute<MapperIgnoreAttribute>())
                            {
                                dynamic sourceEnumeration = sourceType.GetProperty(property.Name).GetValue(source);
                                var destinationProperty = destinationType.GetProperty(property.Name);
                                var destinationCollectionType = destinationProperty.PropertyType.GetGenericArguments()[0];
                                dynamic destinationCollection = destinationProperty.GetValue(destination);

                                if (!destinationProperty.HasAttribute<MapperIgnoreAttribute>() && sourceEnumeration != null)
                                {
                                    dynamic sourceEnumerationObjects = sourceEnumeration.ToArray();
                                    dynamic destinationCollectionList = ((IEnumerable)destinationCollection).Cast<dynamic>().ToList();

                                    Update
                                    foreach (dynamic sourceEnumerationObject in sourceEnumerationObjects)
                                    {
                                        if (sourceEnumerationObject.ModelState == BaseDomainModelState.Modified)
                                        {
                                            dynamic destinationCollectionObject = ((IEnumerable)destinationCollection).Cast<dynamic>().Single(dest => dest.Id.Equals(sourceEnumerationObject.Id));

                                            Mapper.Map(sourceEnumerationObject, destinationCollectionObject, sourceEnumerationType, destinationCollectionType);

                                            var context = _serviceLocator.GetInstance<IDbContext>();
                                            context.SetModified(destinationCollectionObject);
                                        }
                                    }

                                   
                                    foreach (dynamic sourceEnumerationObject in sourceEnumerationObjects)
                                    {
                                        if (!((IEnumerable)destinationCollection).Cast<dynamic>().Any(destinationObject => destinationObject.Id.Equals(sourceEnumerationObject.Id)))
                                        {
                                            dynamic destinationCollectionObject = Activator.CreateInstance(destinationCollectionType);
                                            Mapper.Map(sourceEnumerationObject, destinationCollectionObject);

                                            //If Not A New Item Get Existing One
                                            if (sourceEnumerationObject.ModelState != BaseDomainModelState.New)
                                            {
                                                var context = _serviceLocator.GetInstance<IDbContext>();
                                                destinationCollectionObject = context.RetrieveObject(destinationCollectionObject);
                                            }

                                            destinationProperty.PropertyType.GetMethod("Add").Invoke(destinationCollection, new[] { destinationCollectionObject });
                                        }
                                    }

                                    //Delete
                                    foreach (dynamic destinationCollectionObject in destinationCollectionList)
                                    {
                                        if (!((IEnumerable)sourceEnumerationObjects).Cast<dynamic>().Any(sourceObject => sourceObject.Id.Equals(destinationCollectionObject.Id)))
                                        {
                                            if (!destinationProperty.HasAttribute<ManyToManyAttribute>())
                                            {
                                                var context = _serviceLocator.GetInstance<IDbContext>();
                                                context.SetDeleted(destinationCollectionObject);
                                            }
                                            else
                                            {
                                                destinationProperty.PropertyType.GetMethod("Remove").Invoke(destinationCollection, new[] { destinationCollectionObject });
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                });

            //Entity To Domain
            Mapper.Instance.Map<TDataModel, TDomainModel>()
                .IgnoreMappingObjects()
                .ConstructUsingServiceLocator()
                .AfterMap((source, destination) => destination.SetAsUnchanged());
        }

        public TDataModel Map(TDomainModel source)
        {
            return Mapper.Map<TDataModel>(source);
        }

        public TDataModel Map(TDomainModel source, TDataModel destination)
        {
            Mapper.Map(source, destination);

            return destination;
        }

        public TDomainModel Map(TDataModel source)
        {
            return Mapper.Map<TDomainModel>(source, opts => opts.ConstructServicesUsing(FormatterServices.GetUninitializedObject));
        }

        public TDomainModel Map(TDataModel source, TDomainModel destination)
        {
            Mapper.Map(source, destination);

            return destination;
        }
    }

    public static class AutoMapperExtensions
    {
        public static IMappingExpression<TSource, TDestination> IgnoreDataObjects<TSource, TDestination, TId>(this IMappingExpression<TSource, TDestination> expression)
        {
            var sourceType = typeof(TSource);
            var destinationType = typeof(TDestination);

            foreach (var property in sourceType.GetProperties())
            {
                var propertyType = property.PropertyType;

                if (propertyType.IsSubclassOf(typeof(BaseDomainModel<TId>)))
                {
                    expression.ForMember(property.Name, opt => opt.Ignore());
                }
                if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                {
                    var enumerationType = propertyType.GetGenericArguments()[0];

                    if (enumerationType != null && enumerationType.IsSubclassOf(typeof(BaseDomainModel<TId>)) && destinationType.GetProperty(property.Name) != null)
                    {
                        expression.ForMember(property.Name, opt => opt.Ignore());
                    }
                }
            }

            return expression;
        }

        public static IMappingExpression<TSource, TDestination> IgnoreMappingObjects<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
        {
            var sourceType = typeof(TSource);
            var destinationType = typeof(TDestination);

            foreach (var property in destinationType.GetProperties())
            {
                var propertyType = property.PropertyType;

                if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                {
                    if (property.HasAttribute<MapperIgnoreAttribute>() && sourceType.GetProperty(property.Name) != null)
                    {
                        expression.ForMember(property.Name, opt => opt.Ignore());
                    }
                }
            }

            return expression;
        }
    }
}
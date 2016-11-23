using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Model;
//using Repositorio;
using System.Dynamic;
using System.Collections.Generic;
using Model;
using AutoMapper;
using System;

namespace ServiceX
{
    [TestClass]
    public class UnitTestRepository
    {
        // private ServiceX.ServicexRef.Entity expando;

        [TestMethod]
        public void Repository_Add_AddsItem()
        {
            Model.TipoTelefone tipoTelefone = new Model.TipoTelefone() { desc_tipo_telefone = "ss" };

            var rep = Repositorio.TipoTelefoneRepository.Instance;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Model.TipoTelefone, Infraestrutura.Entity>();
            });
           
            config.AssertConfigurationIsValid();

            var add = config.CreateMapper().Map<Model.TipoTelefone, Infraestrutura.Entity>(tipoTelefone);
            rep.InitializeRepository();
            rep.Adicionar(tipoTelefone);
            rep.Commit();
            rep.Dispose();

            

        }

        [TestMethod]
        public void Repository_Add_AddsTipoTelefoneService()
        {

            try
            {

                Model.TipoTelefone tp = new Model.TipoTelefone() { desc_tipo_telefone = "ss8" };
                Model.TipoTelefone tp1 = new Model.TipoTelefone() { desc_tipo_telefone = "ss9" };
                Model.TipoTelefone tp2 = new Model.TipoTelefone() { desc_tipo_telefone = "ss10" };
                
                using (var service = new SvcTipoTelefone.SvcTipoTelefoneClient())
                {
                    service.SetAddEntity(tp);
                    service.SetAddEntity(tp1);
                    service.SetAddEntity(tp2);
                    service.Complete();
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
            }

        }

        [TestMethod]
        public void Repository_Add_AddsUsuarioService()
        {
            //TipoTelefone tipoTelefone = new TipoTelefone() { desc_tipo_telefone = "service" };

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<TipoTelefone, TipoTelefoneServiceRef.Entity>();
            //});

            //config.AssertConfigurationIsValid();

            //TipoTelefoneServiceRef.Entity entity = config.CreateMapper().Map<Model.TipoTelefone, TipoTelefoneServiceRef.Entity>(tipoTelefone);

            //try
            //{
            //    using (var service = new TipoTelefoneServiceRef.TipoTelefoneService())
            //    {
            //        service.Adicionar(entity);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    string msg = ex.Message.ToString();
            //}

            //TipoTelefoneServiceRef.TipoTelefoneService.

            //


            ////var add = (ServiceXReference.EntityContracts)tipoTelefone;
            ////dynamic dinamicClass = new ExpandoObject();
            ////var y = (ServiceXReference.Entity)dinamicClass;


        }

        //using (var helper = new ServiceXHost<ServiceX.ServicexRef.ServiceXYClient, ServiceX.ServicexRef.IServiceXY>())
        //{
        //    helper.OpenWcfService();
        //    var client = helper.GetClient();
        //    client.SetRepositoryType(ServicexRef.RepositoryType.TipoTelefoneRepository);
        //    //object obj = new object() { name = "ss" };
        //    dynamic expando = new ExpandoObject();
        //    var x = (Entity)expando;
        //    //expando.desc_tipo_telefone = "sss";
        //    //TipoTelefone tpTel = new TipoTelefone() { desc_tipo_telefone = "ss" };
        //    client.Adicionar(x); 
        //    //client.c
        //    //serviceHost.Should().NotBeNull();
        //    //serviceHost.Description.ServiceType.Should().Be(typeof(HelloWorldService));

        //    // NOTE: This will fail. Compare and contrast with the similar line above
        //    //serviceHost.Description.ServiceType.Should().BeOfType<HelloWorldService>();
        //}



        //using (var service = Repository<Tipo_Telefone>.Instance)
        //{

        //try
        //{

        //service.Tipo_Telefone..Add((Tipo_Telefone)entidade);
        //service.Entry((Tipo_Telefone)entidade).State = EntityState.Added;
        // var service = Repository.Instance;
        //var expected = new TipoTelefone() { desc_tipo_telefone = "Nextel-Radio" };
        //service.Tipo_Telefone.Add(expected);
        //service.SaveChanges();
        //context.Configuration.AutoDetectChangesEnabled = true;
        //context.Entry(entidade).State = EntityState.Added;
        //context.SaveChanges();

        //var instance = ;
        //TipoTelefoneRepository.Instance.InsertPersistente(expected);

        //}
        //catch (DbEntityValidationException ex)
        //{
        //    foreach (var entityValidationErrors in ex.EntityValidationErrors)
        //    {
        //        foreach (var validationError in entityValidationErrors.ValidationErrors)
        //        {
        //            var a = "Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage;
        //        }
        //    }
        //}

        //}

        //context = new SERVICEXEntities();
        //uow = new EFUnitOfWork(context);
        //repo = new EFRepository<Tipo_Telefone>(uow);
        //var expected = new Tipo_Telefone() { desc_tipo_telefone = "Nextel-Radio" };
        //Tipo_TelefoneRepository rep = new Tipo_TelefoneRepository(new UnitOfWork());
        //rep.AddPersistente(expected);
        //repo.Add(expected);
        //uow.Commit();
        //var actual = ((IQueryable)rep.Query()).GetEnumerator();// .FirstOrDefault(e => e.desc_tipo_telefone == "Nextel - Radio");
        //NUnit.Framework.Assert.IsNotNull(actual);


        public static void AddProperty(ExpandoObject expando, string propertyName, object propertyValue)
        {
            // ExpandoObject supports IDictionary so we can extend it like this
            var expandoDict = expando as IDictionary<string, object>;
            if (expandoDict.ContainsKey(propertyName))
                expandoDict[propertyName] = propertyValue;
            else
                expandoDict.Add(propertyName, propertyValue);
        }

        //private EFUnitOfWork uow;
        //private EFRepository<Tipo_Telefone> repo;
        //private SERVICEXEntities context = new SERVICEXEntities();

        //[TestMethod]
        //public void Repository_Add_AddsItem()
        //{
        //    //context = new SERVICEXEntities();
        //    uow = new EFUnitOfWork(context);
        //    repo = new EFRepository<Tipo_Telefone>(uow);

        //    var expected = new Tipo_Telefone() { desc_tipo_telefone = "Nextel - Radio" };
        //    repo.Add(expected);
        //    uow.Commit();
        //    var actual = repo.Query().FirstOrDefault(e => e.desc_tipo_telefone == "Nextel - Radio");
        //    NUnit.Framework.Assert.IsNotNull(actual);
        //}

        //[TestMethod]
        //public void Repository_Remove_RemovesItem()
        //{
        //    context = new SERVICEXEntities();
        //    uow = new EFUnitOfWork(context);
        //    repo = new EFRepository<Tipo_Telefone>(uow);

        //    var expected = new Tipo_Telefone() { desc_tipo_telefone = "Nextel - Radio" };
        //    repo.Add(expected);
        //    uow.Commit();
        //    repo.Remove(expected);
        //    uow.Commit();
        //    NUnit.Framework.Assert.AreEqual(0, repo.Query().Count());
        //}
    }
}

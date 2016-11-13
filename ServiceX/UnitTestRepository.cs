using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity.Validation;
using Model;
using Repositorio;

namespace ServiceX
{
    [TestClass]
    public class UnitTestRepository
    {

        [TestMethod]
        public void Repository_Add_AddsItem()
        {
            //using (var service = Repository<Tipo_Telefone>.Instance)
            //{

                try
                {

                    //service.Tipo_Telefone..Add((Tipo_Telefone)entidade);
                    //service.Entry((Tipo_Telefone)entidade).State = EntityState.Added;
                   // var service = Repository.Instance;
                    var expected = new Tipo_Telefone() { desc_tipo_telefone = "Nextel-Radio" };
                //service.Tipo_Telefone.Add(expected);
                //service.SaveChanges();
                //context.Configuration.AutoDetectChangesEnabled = true;
                //context.Entry(entidade).State = EntityState.Added;
                //context.SaveChanges();

                //var instance = ;
                Repositorio.Tipo_TelefoneRepository<Tipo_Telefone>.Instance.InsertPersistente(expected);

                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            var a = "Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage;
                        }
                    }
                }

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

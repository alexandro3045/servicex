using System;
using Infraestrutura;
using Model;
using Repositorio.Generic.Utils;
using Wcf_ServiceX.Interface;
using Repositorio;
using Wcf_ServiceX.Generic;

namespace Wcf_ServiceX.Services
{
    public class SvcTela : GenericService<TelaRepository>, ISvcTela
    {
        public SvcTela(TelaRepository repository)
        {
            Initialize(repository);
            //_repo = repository;
        }

        public void SetAddEntity(Tela param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(Tela param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(Tela param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }

        
    }
}

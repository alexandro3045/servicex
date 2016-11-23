using System;
using Model;
using Repositorio;
using Wcf_ServiceX.Generic;
using Wcf_ServiceX.Interface;

namespace Wcf_ServiceX.Services
{
   public class SvcTelefonesCli : GenericService<TelefonesCliRepository>, ISvcTelefonesCli
    {
        public SvcTelefonesCli(TelefonesCliRepository repository)
        {
            Initialize(repository);
            //_repo = repository;
        }

        public void SetAddEntity(TelsClients param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(TelsClients param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(TelsClients param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }

    }
}

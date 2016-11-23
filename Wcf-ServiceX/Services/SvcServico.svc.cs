using System;
using Infraestrutura;
using Model;
using Repositorio.Generic.Utils;
using Wcf_ServiceX.Interface;
using Repositorio;
using Wcf_ServiceX.Generic;

namespace Wcf_ServiceX.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SvcServico" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SvcServico.svc or SvcServico.svc.cs at the Solution Explorer and start debugging.
    public class SvcServico : GenericService<ServicoRepository>, ISvcServico
    {
        public SvcServico(ServicoRepository repository)
        {
            Initialize(repository);
            //_repo = repository;
        }

        public void SetAddEntity(Servico param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(Servico param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(Servico param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }
    }
}

﻿using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_ServiceX.Decorator;
using Wcf_ServiceX.Generic;

namespace Wcf_ServiceX.Services
{
    // NOTE: You can use the "Rename" cosmmand on the "Refactor" menu to change the interface name "ISvcProfissional" in both code and config file together.
    [ServiceContract]
    public interface ISvcProfissional : IGenericService<ProfissionalRepository>
    {
        [OperationContract]
        [EfDataContractSerializer]
        void SetAddEntity(Profissional param);

        [OperationContract]
        [EfDataContractSerializer]
        void SetAddUpdateEntity(Profissional param);

        [OperationContract]
        [EfDataContractSerializer]
        void SetAddRemoveEntity(Profissional param);
    }
}

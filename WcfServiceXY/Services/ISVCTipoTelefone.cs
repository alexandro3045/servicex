﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceXY.Generic;

namespace WcfServiceXY.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISVCTipoTelefone" in both code and config file together.
    [ServiceContract]
    public interface ISVCTipoTelefone : IServiceX
    {
        [OperationContract]
        void doWork();
    }
}

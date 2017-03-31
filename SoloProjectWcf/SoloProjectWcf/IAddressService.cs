﻿using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectWcf
{
    [ServiceContract]
    interface IAddressService
    {
        [OperationContract]
        void AddAddressToUser(int userId, Address address);
    }
}

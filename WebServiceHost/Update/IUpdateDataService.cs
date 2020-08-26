﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceHost.Update
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUpdateDataService" in both code and config file together.
    [ServiceContract]
    public interface IUpdateDataService
    {
        [OperationContract]
        string UpdateComputer(int _id, string _computerName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _firstName, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime purchaseDate, DateTime warrantyDate);

        [OperationContract]
        string UpdateNotebooks(int id, string _notebooksName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _firstName, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime purchaseDate,
            DateTime warrantyDate);

        [OperationContract]
        string UpdateMonitors(int _id, string _companyFixedAsset, string _tagService, string _location,
            string _firstName, string _model, string _coments, DateTime purchaseDate, DateTime warrantyDate);
    }
}
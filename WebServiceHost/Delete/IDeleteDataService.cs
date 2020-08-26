﻿using System.ServiceModel;

namespace WebServiceHost.Delete
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDeleteDataService" in both code and config file together.
    [ServiceContract]
    public interface IDeleteDataService
    {
        [OperationContract]
        string DeleteComputer(int id);

        [OperationContract]
        string DeleteNotebook(int id);

        [OperationContract]
        string DeleteMonitor(int id);
    }
}

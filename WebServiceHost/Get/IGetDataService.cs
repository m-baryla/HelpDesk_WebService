﻿using System.Collections.Generic;
using System.ServiceModel;
using WebServiceHost.Model;

namespace WebServiceHost.Get
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetDataService" in both code and config file together.
    [ServiceContract]
    public interface IGetDataService
    {
        [OperationContract]
        List<ComputersDataView> GetAllComputerses();

        [OperationContract]
        List<NotebooksDataView> GetAllNotebookses();

        [OperationContract]
        List<MonitorsDataView> GetAllMonitors();
    }
}

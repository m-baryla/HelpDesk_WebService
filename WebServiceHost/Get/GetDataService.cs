using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using WebServiceHost.Model;

namespace WebServiceHost.Get
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetDataService" in both code and config file together.
    public class GetDataService : IGetDataService
    {
        private readonly string ConnString = "HelpDeskDB_Conn_TEST";

        public List<ComputersDataView> GetAllComputerses()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<ComputersDataView>("select * from vwAll_Computers").ToList();
            }
        }

        public List<NotebooksDataView> GetAllNotebookses()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<NotebooksDataView>("select * from vwAll_Notebooks").ToList();
            }
        }

        public List<MonitorsDataView> GetAllMonitors()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<MonitorsDataView>("select * from vwAll_Monitors").ToList();
            }
        }
    }
}

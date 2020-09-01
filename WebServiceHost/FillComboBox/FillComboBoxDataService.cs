using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using WebServiceHost.Model;

namespace WebServiceHost.FillComboBox
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FillComboBoxDataService" in both code and config file together.
    public class FillComboBoxDataService : IFillComboBoxDataService
    {
        private readonly string ConnString = "HelpDeskDB_Conn_TEST";

        public List<string> FillComboBoxLocation()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from vwFillComboBoxLocation").ToList();
            }
        }
        public List<string> FillComboBoxOffice()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from vwFillComboBoxOffice").ToList();
            }
        }
        public List<string> FillComboBoxOperatingSystem()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from vwFillComboBoxOperatingSystem").ToList();
            }
        }
        public List<string> FillComboBoxCPU()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from wvFillComboBoxCPU").ToList();
            }
        }
        public List<string> FillComboBoxHardDrive()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from wvFillComboBoxHardDrive").ToList();
            }
        }
        public List<string> FillComboBoxRAM()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from wvFillComboBoxRAM").ToList();
            }
        }
        public List<string> FillComboBoxModelComputer()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from wvFillComboBoxModelComputer").ToList();
            }
        }
        public List<string> FillComboBoxModelMonitors()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from wvFillComboBoxModelMonitors").ToList();
            }
        }
        public List<string> FillComboBoxModelNotebooks()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from wvFillComboBoxModelNotebooks").ToList();
            }
        }
        public List<string> vwFillComboBoxUsers()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from vwFillComboBoxUsers").ToList();
            }
        }
    }
}

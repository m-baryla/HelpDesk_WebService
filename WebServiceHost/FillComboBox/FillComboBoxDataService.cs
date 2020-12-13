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
        private readonly string ConnString = "HelpDesk_DataBase";

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
                return connection.Query<string>("select * from vwFillComboBoxCPU").ToList();
            }
        }
        public List<string> FillComboBoxHardDrive()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from vwFillComboBoxHardDrive").ToList();
            }
        }
        public List<string> FillComboBoxRAM()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from vwFillComboBoxRAM").ToList();
            }
        }
        public List<string> FillComboBoxModelComputer()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from vwFillComboBoxModelComputer").ToList();
            }
        }
        public List<string> FillComboBoxModelMonitors()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from vwFillComboBoxModelMonitors").ToList();
            }
        }
        public List<string> FillComboBoxModelNotebooks()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from vwFillComboBoxModelNotebooks").ToList();
            }
        }
        public List<string> FillComboBoxUsers()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from vwFillComboBoxUsers").ToList();
            }
        }
        public List<string> FillComboBoxEquipmentStatus()
        {
            using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(ConnString)))
            {
                return connection.Query<string>("select * from vwFillComboBoxEquipmentStatus").ToList();
            }
        }
    }
}

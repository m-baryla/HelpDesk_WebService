using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using LoggerLibrary.Logger;
using WebServiceHost.Model;

namespace WebServiceHost.Delete
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DeleteDataService" in both code and config file together.
    public class DeleteDataService : IDeleteDataService
    {
        private readonly string _connString = "HelpDeskDB_Conn_TEST";

        readonly LoggerUseTools _loggerUse = new LoggerUseTools("DeleteSourceWebService");

        public string DeleteComputer(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Query<Computers>("spDelete_Computers @Id", new { Id = id });

                    _loggerUse.InfoLog("DeleteComputer -> Successful ID:" + id);

                    return "Delete Computer -> Successful ID:" + id;
                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Delete Computer ID:" + " " + id + " " + e.Message);

                return "Delete Computer ID:" + " " + id + " " + e.Message;
            }
        }
        public string DeleteNotebook(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Query<Notebooks>("spDelete_Notebooks @Id", new { Id = id });

                    _loggerUse.InfoLog("Delete Notebook -> Successful ID:" + id);

                    return "Delete Notebook -> Successful ID:" + id;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Delete Notebook ID:" + " " + id + " " + e.Message);

                return "Delete Notebook ID:" + " " + id + " " + e.Message;
            }
        }
        public string DeleteMonitor(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Query<Monitors>("spDelete_Monitors @Id", new { Id = id });

                    _loggerUse.InfoLog("Delete Monitor -> Successful ID:" + id);

                    return "Delete Monitor -> Successful ID:" + id;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Delete Monitor ID:" + " " + id + " " + e.Message);

                return "Delete Monitor ID:" + " " + id + " " + e.Message;
            }
        }
    }
}


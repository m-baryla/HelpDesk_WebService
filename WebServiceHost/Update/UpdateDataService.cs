using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using LoggerLibrary.Logger;
using WebServiceHost.Model;

namespace WebServiceHost.Update
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UpdateDataService" in both code and config file together.
    public class UpdateDataService : IUpdateDataService
    {
        private readonly string _connString = "HelpDeskDB_Conn_TEST";

        readonly LoggerUseTools _loggerUse = new LoggerUseTools("UpdateSourceWebService");

        public string UpdateComputer(int _id, string _computerName, string _operatingSystem, string _companyFixedAsset,
           string _tagService, string _location, string _user, string _office, string _ip, string _model,
           string _cpu, string _ram, string _hardDrive, string _coments, DateTime purchaseDate, DateTime warrantyDate, byte[] _barcode, byte[] _qrCode)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    var computers = new List<Computers>();

                    computers.Add(new Computers
                    {
                        Id = _id,
                        CompterName = _computerName,
                        OperatingSystem = _operatingSystem,
                        CompanyFixedAsset = _companyFixedAsset,
                        TagService = _tagService,
                        Location = _location,
                        User = _user,
                        Office = _office,
                        IP = _ip,
                        ModelComputer = _model,
                        CPU = _cpu,
                        RAM = _ram,
                        HardDrive = _hardDrive,
                        Coments = _coments,
                        PurchaseDate = purchaseDate,
                        WarrantyDate = warrantyDate,
                        Barcode = _barcode,
                        QRCode = _qrCode
                    });

                    connection.Execute("spUpdate_Computers @Id,@CompterName,@OperatingSystem,@CompanyFixedAsset," +
                                       "@TagService,@Location,@User,@Office,@IP,@ModelComputer,@CPU,@RAM,@HardDrive," +
                                       "@Coments,@PurchaseDate,@WarrantyDate,@Barcode,@QRCode", computers);

                    _loggerUse.InfoLog("Update Computer -> Successful : " + _computerName);

                    return "Update Computer -> Successful : " + _computerName;
                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Update Computer" + " " + _computerName + " " + e.Message);

                return "Update Computer" + " " + _computerName + " " + e.Message;
            }

        }
        public string UpdateNotebooks(int id, string _notebooksName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime purchaseDate, DateTime warrantyDate)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    var notebooks = new List<Notebooks>();

                    notebooks.Add(new Notebooks
                    {
                        Id = id,
                        NotebooksName = _notebooksName,
                        OperatingSystem = _operatingSystem,
                        CompanyFixedAsset = _companyFixedAsset,
                        TagService = _tagService,
                        Location = _location,
                        User = _user,
                        Office = _office,
                        IP = _ip,
                        ModelNotebooks = _model,
                        CPU = _cpu,
                        RAM = _ram,
                        HardDrive = _hardDrive,
                        Coments = _coments,
                        PurchaseDate = purchaseDate,
                        WarrantyDate = warrantyDate,
                        Barcode = "test barcode"
                    });

                    connection.Execute("spUpdate_Notebooks @Id, @NotebooksName,@OperatingSystem,@CompanyFixedAsset," +
                                       "@TagService,@Location,@User,@Office,@IP,@ModelNotebooks,@CPU,@RAM,@HardDrive," +
                                       "@Coments,@PurchaseDate,@WarrantyDate,@Barcode", notebooks);

                    _loggerUse.InfoLog("Update Notebooks -> Successful : " + _notebooksName);

                    return "Update Notebooks -> Successful : " + _notebooksName;
                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Update Notebooks" + " " + _notebooksName + " " + e.Message);

                return "Update Notebooks" + " " + _notebooksName + " " + e.Message;
            }
        }

        public string UpdateMonitors(int _id, string _companyFixedAsset, string _tagService, string _location,
            string _user, string _model, string _coments, DateTime purchaseDate, DateTime warrantyDate)
        {
            try
            {
                using (IDbConnection connection =
                    new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    var monitors = new List<Monitors>();

                    monitors.Add(new Monitors
                    {
                        Id = _id,
                        CompanyFixedAsset = _companyFixedAsset,
                        TagService = _tagService,
                        Location = _location,
                        User = _user,
                        ModelMonitors = _model,
                        Coments = _coments,
                        PurchaseDate = purchaseDate,
                        WarrantyDate = warrantyDate,
                        Barcode = "test barcode"
                    });

                    connection.Execute("spUpdate_Monitors @Id, @CompanyFixedAsset," +
                                       "@TagService,@Location,@User,@ModelMonitors,@Coments," +
                                       "@PurchaseDate,@WarrantyDate,@Barcode", monitors);

                    _loggerUse.InfoLog("Update Monitors -> Successful : " + _model);

                    return "Update Monitors -> Successful : " + _model;
                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Update Monitors" + " " + _model + " " + e.Message);

                return "Update Monitors" + " " + _model + " " + e.Message;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dapper;
using LoggerLibrary.Logger;
using WebServiceHost.Model;

namespace WebServiceHost.Insert
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IInsertDataService" in both code and config file together.
    public class InsertDataService : IInsertDataService
    {
        private readonly string _connString = "HelpDesk_DataBase";

        readonly LoggerUseTools _loggerUse = new LoggerUseTools("InsertSourceWebService");

        public string InsertComputer(string _computerName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime warrantyDate, DateTime purchaseDate, 
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    var computers = new List<Computers>();

                    computers.Add(new Computers
                    {
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
                        QRCode = _qrCode,
                        EquipmentStatus = _equipmentStatus

                    });

                    connection.Execute("spAdd_New_Computer @CompterName,@OperatingSystem,@CompanyFixedAsset," +
                                       "@TagService,@Location,@User,@Office,@IP,@ModelComputer,@CPU,@RAM,@HardDrive," +
                                       "@Coments,@WarrantyDate,@PurchaseDate,@Barcode,@QRCode,@EquipmentStatus", computers);

                    _loggerUse.InfoLog("Insert Computer -> Successful : " + _computerName);

                    return "Insert Computer -> Successful : " + _computerName;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert Computer" + " " + _computerName + " " + e.Message);

                return "Insert Computer" + " " + _computerName + " " + e.Message;
            }
        }
        public string InsertNotebooks(string _notebooksName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime warrantyDate, DateTime purchaseDate,
            byte[] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    var notebooks = new List<Notebooks>();

                    notebooks.Add(new Notebooks
                    {
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
                        Barcode = _barcode,
                        QRCode = _qrCode,
                        EquipmentStatus = _equipmentStatus

                    });

                    connection.Execute("spAdd_New_Notebooks @NotebooksName,@OperatingSystem,@CompanyFixedAsset," +
                                       "@TagService,@Location,@User,@Office,@IP,@ModelNotebooks,@CPU,@RAM,@HardDrive," +
                                       "@Coments,@WarrantyDate,@PurchaseDate,@Barcode,@QRCode,@EquipmentStatus", notebooks);


                    _loggerUse.InfoLog("Insert Notebooks -> Successful : " + _notebooksName);

                    return "Insert Notebooks -> Successful : " + _notebooksName;
                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert Notebooks" + " " + _notebooksName + " " + e.Message);

                return "Insert Notebooks" + " " + _notebooksName + " " + e.Message;
            }
        }
        public string InsertMonitors(string _companyFixedAsset, string _tagService, string _location,
           string _user, string _model, string _coments, DateTime warrantyDate, DateTime purchaseDate,
           byte[] _barcode, byte[] _qrCode, string _equipmentStatus)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    var monitors = new List<Monitors>();

                    monitors.Add(new Monitors
                    {
                        CompanyFixedAsset = _companyFixedAsset,
                        TagService = _tagService,
                        Location = _location,
                        User = _user,
                        ModelMonitors = _model,
                        Coments = _coments,
                        PurchaseDate = purchaseDate,
                        WarrantyDate = warrantyDate,
                        Barcode = _barcode,
                        QRCode = _qrCode,
                        EquipmentStatus = _equipmentStatus
                    });

                    connection.Execute("spAdd_New_Monitors @CompanyFixedAsset," +
                                       "@TagService,@Location,@User,@ModelMonitors,@Coments," +
                                       "@WarrantyDate,@PurchaseDate,@Barcode,@QRCode,@EquipmentStatus", monitors);

                    _loggerUse.InfoLog("Insert Monitors -> Successful : " + _model);

                    return "Insert Monitors -> Successful : " + _model;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert Monitors" + " " + _model + " " + e.Message);

                return "Insert Monitors" + " " + _model + " " + e.Message;

            }

        }
        public string InsertComboBoxCPU(string _value)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Execute($"spAdd_New_ComboBox_CPU @CPUVersion = '{_value}'");

                    _loggerUse.InfoLog("Insert ComboBox CPU -> Successful :" + _value);

                    return "Insert CPU -> Successful :" + _value;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert ComboBox CPU" + " " + _value + " " + e.Message);

                return "Insert CPU" + " " + _value + " " + e.Message;

            }

        }
        public string InsertComboBoxHardDrive(string _value)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Execute($"spAdd_New_ComboBox_HardDrive @HardDriveVersion = '{_value}'");

                    _loggerUse.InfoLog("Insert ComboBox HardDrive -> Successful :" + _value);

                    return "Insert HardDrive -> Successful :" + _value;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert ComboBox HardDrive" + " " + _value + " " + e.Message);

                return "Insert HardDrive" + " " + _value + " " + e.Message;

            }

        }
        public string InsertComboBoxLocation(string _value)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Execute($"spAdd_New_ComboBox_Location @LocationName = '{_value}'");

                    _loggerUse.InfoLog("Insert ComboBox Location -> Successful :" + _value);

                    return "Insert Location -> Successful :" + _value;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert ComboBox Location" + " " + _value + " " + e.Message);

                return "Insert Location" + " " + _value + " " + e.Message;

            }

        }
        public string InsertComboBoxMicrosoftOffice(string _value)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Execute($"spAdd_New_ComboBox_MicrosoftOffice @MicrosoftOfficeVersion = '{_value}'");

                    _loggerUse.InfoLog("Insert ComboBox Microsoft Office -> Successful :" + _value);

                    return "Insert MicrosoftOffice -> Successful :" + _value;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert ComboBox Microsoft Office" + " " + _value + " " + e.Message);

                return "Insert MicrosoftOffice" + " " + _value + " " + e.Message;

            }

        }
        public string InsertComboBoxModelComputer(string _value)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Execute($"spAdd_New_ComboBox_ModelComputer @ModelVersionComputer = '{_value}'");

                    _loggerUse.InfoLog("Insert ComboBox Model Computer -> Successful :" + _value);

                    return "Insert Model Computer -> Successful :" + _value;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert ComboBox Model Computer" + " " + _value + " " + e.Message);

                return "Insert Model Computer" + " " + _value + " " + e.Message;

            }

        }
        public string InsertComboBoxModelMonitor(string _value)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Execute($"spAdd_New_ComboBox_ModelMonitor @ModelVersionMonitors = '{_value}'");

                    _loggerUse.InfoLog("Insert ComboBox Model Monitor -> Successful :" + _value);

                    return "Insert Model Monitor -> Successful :" + _value;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert ComboBox Model Monitor" + " " + _value + " " + e.Message);

                return "Insert Model Monitor" + " " + _value + " " + e.Message;

            }

        }
        public string InsertComboBoxModelNotebook(string _value)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Execute($"spAdd_New_ComboBox_ModelNotebook @ModelVersionNotebooks = '{_value}'");

                    _loggerUse.InfoLog("Insert ComboBox Model Notebook -> Successful :" + _value);

                    return "Insert Model Notebook -> Successful :" + _value;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert ComboBox Model Notebook" + " " + _value + " " + e.Message);

                return "Insert Model Notebook" + " " + _value + " " + e.Message;

            }

        }
        public string InsertComboBoxOperatingSystem(string _value)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Execute($"spAdd_New_ComboBox_OperatingSystem @OperatingSystemVersion = '{_value}'");

                    _loggerUse.InfoLog("Insert Operating System -> Successful :" + _value);

                    return "Insert Operating System -> Successful :" + _value;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert ComboBox Operating System" + " " + _value + " " + e.Message);

                return "Insert Operating System" + " " + _value + " " + e.Message;

            }

        }
        public string InsertComboBoxRAM(string _value)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Execute($"spAdd_New_ComboBox_RAM @RAMVersion = '{_value}'");

                    _loggerUse.InfoLog("Insert ComboBox RAM -> Successful :" + _value);

                    return "Insert RAM -> Successful :" + _value;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert ComboBox RAM" + " " + _value + " " + e.Message);

                return "Insert RAM" + " " + _value + " " + e.Message;

            }

        }
        public string InsertComboBoxUser(string _firstName, string _lastName, string _job)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Execute($"spAdd_New_ComboBox_User @FirstName = '{_firstName}', @LastName = '{_lastName}', @Job = '{_job}'");

                    _loggerUse.InfoLog("Insert ComboBox User -> Successful :" + _firstName + " " + _lastName + " " + _job);

                    return "Insert User -> Successful :" + _firstName + " " + _lastName + " " + _job;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert ComboBox User" + " " + _firstName + " " + _lastName + " " + _job + " " + e.Message);

                return "Insert User" + " " + _firstName + " " + _lastName + " " + _job + " " + e.Message;

            }
        }
        public string InsertComboEquipmentStatus(string _value)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(HelperConnection.ConnectionStringValue(_connString)))
                {
                    connection.Execute($"spAdd_New_ComboBox_EquipmentStatus @EquipmentStatus = '{_value}'");

                    _loggerUse.InfoLog("Insert ComboBox EquipmentStatus -> Successful :" + _value);

                    return "Insert EquipmentStatus -> Successful :" + _value;

                }
            }
            catch (Exception e)
            {
                _loggerUse.ErrorLog("Insert ComboBox EquipmentStatus" + " " + _value + " " + e.Message);

                return "Insert EquipmentStatus" + " " + _value + " " + e.Message;

            }

        }
    }
}

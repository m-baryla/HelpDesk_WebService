using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceHost.Insert
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIInsertDataService" in both code and config file together.
    [ServiceContract]
    public interface IInsertDataService
    {
        [OperationContract]
        string InsertComputer(string _computerName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime purchaseDate, DateTime warrantyDate, byte[] _barcode, byte[] _qrCode);

        [OperationContract]
        string InsertNotebooks(string _notebooksName, string _operatingSystem, string _companyFixedAsset,
            string _tagService, string _location, string _user, string _office, string _ip, string _model,
            string _cpu, string _ram, string _hardDrive, string _coments, DateTime purchaseDate, DateTime warrantyDate);

        [OperationContract]
        string InsertMonitors(string _companyFixedAsset, string _tagService, string _location,
            string _user, string _model, string _coments, DateTime purchaseDate, DateTime warrantyDate);

        [OperationContract]
        string InsertComboBoxCPU(string _value);

        [OperationContract]
        string InsertComboBoxHardDrive(string _value);

        [OperationContract]
        string InsertComboBoxLocation(string _value);

        [OperationContract]
        string InsertComboBoxMicrosoftOffice(string _value);

        [OperationContract]
        string InsertComboBoxModelComputer(string _value);

        [OperationContract]
        string InsertComboBoxModelMonitor(string _value);

        [OperationContract]
        string InsertComboBoxModelNotebook(string _value);

        [OperationContract]
        string InsertComboBoxOperatingSystem(string _value);

        [OperationContract]
        string InsertComboBoxRAM(string _value);

        [OperationContract]
        string InsertComboBoxUser(string _firstName, string _lastName, string _job);
    }
}

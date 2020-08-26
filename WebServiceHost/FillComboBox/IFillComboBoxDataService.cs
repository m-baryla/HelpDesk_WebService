using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceHost.FillComboBox
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFillComboBoxDataService" in both code and config file together.
    [ServiceContract]
    public interface IFillComboBoxDataService
    {
        [OperationContract]
        List<string> FillComboBoxLocation();

        [OperationContract]
        List<string> FillComboBoxOffice();

        [OperationContract]
        List<string> FillComboBoxOperatingSystem();

        [OperationContract]
        List<string> FillComboBoxCPU();

        [OperationContract]
        List<string> FillComboBoxHardDrive();

        [OperationContract]
        List<string> FillComboBoxRAM();

        [OperationContract]
        List<string> FillComboBoxModelComputer();

        [OperationContract]
        List<string> FillComboBoxModelMonitors();

        [OperationContract]
        List<string> FillComboBoxModelNotebooks();
    }
}

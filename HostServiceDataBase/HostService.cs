using System;
using System.ServiceModel;
using System.Windows.Forms;
using LoggerLibrary.Logger;

namespace HostServiceDataBase
{
    public partial class HostService : Form
    {
        private readonly LoggerUseTools _log = new LoggerUseTools("RunServiceLog");
        private ServiceHost _hostDelete;
        private ServiceHost _hostFillComboBox;
        private ServiceHost _hostGetData;
        private ServiceHost _hostInsert;
        private ServiceHost _hostUpdate;

        
        public HostService()
        {
            InitializeComponent();
            buttonStopDeleteDataService.Enabled = true;
            buttonStopFillComboBoxDataService.Enabled = true;
            buttonStopGetDataService.Enabled = true;
            buttonStartInsertDataService.Enabled = true;
            buttonStopUpdateDataService.Enabled = true;
        }


        #region DeleteDataService
        private void buttonStartDeleteDataService_Click(object sender, EventArgs e)
        {
            buttonStartDeleteDataService.Enabled = false;
            buttonStopDeleteDataService.Enabled = true;

            _hostDelete = new ServiceHost(typeof(WebServiceHost.Delete.DeleteDataService));

            try
            {
                _hostDelete.Open();
                _log.InfoLog("DeleteDataService host started");
                richTextBoxDeleteDataService.Text = "DeleteDataService host started";
            }
            catch (TimeoutException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxDeleteDataService.Text = ex.Message;
            }
            catch (CommunicationException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxDeleteDataService.Text = ex.Message;
            }
        }
        private void buttonStopDeleteDataService_Click(object sender, EventArgs e)
        {
            buttonStartDeleteDataService.Enabled = true;
            buttonStopDeleteDataService.Enabled = false;

            _hostDelete = new ServiceHost(typeof(WebServiceHost.Delete.DeleteDataService));

            try
            {
                _hostDelete.Close();
                _log.InfoLog("DeleteDataService host stoped");
                richTextBoxDeleteDataService.Text = "DeleteDataService host stoped";
            }
            catch (TimeoutException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxDeleteDataService.Text = ex.Message;
            }
            catch (CommunicationException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxDeleteDataService.Text = ex.Message;
            }

        }
        #endregion

        #region FillComboBoxDataService
        private void buttonStartFillComboBoxDataService_Click(object sender, EventArgs e)
        {
            buttonStartFillComboBoxDataService.Enabled = false;
            buttonStopFillComboBoxDataService.Enabled = true;
            _hostFillComboBox = new ServiceHost(typeof(WebServiceHost.FillComboBox.FillComboBoxDataService));
            try
            {
                _hostFillComboBox.Open();
                _log.InfoLog("FillComboBoxDataService host started");
                richTextBoxFillComboBoxDataService.Text = "FillComboBoxDataService host started";
            }
            catch (TimeoutException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxFillComboBoxDataService.Text = ex.Message;
            }
            catch (CommunicationException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxFillComboBoxDataService.Text = ex.Message;
            }
        }

        private void buttonStopFillComboBoxDataService_Click(object sender, EventArgs e)
        {
            buttonStartFillComboBoxDataService.Enabled = true;
            buttonStopFillComboBoxDataService.Enabled = false;
            _hostFillComboBox = new ServiceHost(typeof(WebServiceHost.FillComboBox.FillComboBoxDataService));
            try
            {
                _hostFillComboBox.Close();
                _log.InfoLog("FillComboBoxDataService host stoped");
                richTextBoxFillComboBoxDataService.Text = "FillComboBoxDataService host stoped";
            }
            catch (TimeoutException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxFillComboBoxDataService.Text = ex.Message;
            }
            catch (CommunicationException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxFillComboBoxDataService.Text = ex.Message;
            }

        }
        #endregion

        #region GetDataService
        private void buttonStartGetDataService_Click(object sender, EventArgs e)
        {
            buttonStartGetDataService.Enabled = false;
            buttonStopGetDataService.Enabled = true;
            _hostGetData = new ServiceHost(typeof(WebServiceHost.Get.GetDataService));
            try
            {
                _hostGetData.Open();
                _log.InfoLog("GetDataService host started");
                richTextBoxGetDataService.Text = "GetDataService host started";
            }
            catch (TimeoutException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxGetDataService.Text = ex.Message;
            }
            catch (CommunicationException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxGetDataService.Text = ex.Message;
            }
        }

        private void buttonStopGetDataService_Click(object sender, EventArgs e)
        {
            buttonStartGetDataService.Enabled = true;
            buttonStopGetDataService.Enabled = false;
            _hostGetData = new ServiceHost(typeof(WebServiceHost.Get.GetDataService));
            try
            {
                _hostGetData.Close();
                _log.InfoLog("GetDataService host stoped");
                richTextBoxGetDataService.Text = "GetDataService host stoped";
            }
            catch (TimeoutException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxGetDataService.Text = ex.Message;
            }
            catch (CommunicationException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxGetDataService.Text = ex.Message;
            }

        }

        #endregion

        #region InsertDataService
        private void buttonStartInsertDataService_Click(object sender, EventArgs e)
        {
            buttonStartInsertDataService.Enabled = false;
            buttonStartInsertDataService.Enabled = true;
            _hostInsert = new ServiceHost(typeof(WebServiceHost.Insert.InsertDataService));
            try
            {
                _hostInsert.Open();
                _log.InfoLog("InsertDataService host started");
                richTextBoxInsertDataService.Text = "InsertDataService host started";
            }
            catch (TimeoutException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxInsertDataService.Text = ex.Message;
            }
            catch (CommunicationException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxInsertDataService.Text = ex.Message;
            }
        }

        private void buttonStopInsertDataService_Click(object sender, EventArgs e)
        {
            buttonStartInsertDataService.Enabled = true;
            buttonStopInsertDataService.Enabled = false;
            _hostInsert = new ServiceHost(typeof(WebServiceHost.Insert.InsertDataService));
            try
            {
                _hostInsert.Close();
                _log.InfoLog("InsertDataService host stoped");
                richTextBoxInsertDataService.Text = "InsertDataService host stoped";
            }
            catch (TimeoutException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxInsertDataService.Text = ex.Message;
            }
            catch (CommunicationException ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxInsertDataService.Text = ex.Message;
            }
        }

        #endregion

        #region UpdateDataService
        private void buttonStartUpdateDataService_Click(object sender, EventArgs e)
        {
            buttonStartUpdateDataService.Enabled = false;
            buttonStopUpdateDataService.Enabled = true;
            _hostUpdate = new ServiceHost(typeof(WebServiceHost.Update.UpdateDataService));
            try
            {
                _hostUpdate.Open();
                _log.InfoLog("UpdateDataService host started");
                richTextBoxUpdateDataService.Text = "UpdateDataService host started";
            }
            catch (Exception ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxUpdateDataService.Text = ex.Message;
            }
        }

        private void buttonStopUpdateDataService_Click(object sender, EventArgs e)
        {
            buttonStartUpdateDataService.Enabled = true;
            buttonStopUpdateDataService.Enabled = false;
            _hostUpdate = new ServiceHost(typeof(WebServiceHost.Update.UpdateDataService));
            try
            {
                _hostUpdate.Close();
                _log.InfoLog("UpdateDataService host stoped");
                richTextBoxUpdateDataService.Text = "UpdateDataService host stoped";
            }
            catch (Exception ex)
            {
                _log.ErrorLog(ex.Message);
                richTextBoxUpdateDataService.Text = ex.Message;
            }
        }

        #endregion

        private void HostService_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //_hostUpdate.Close();
                //_hostInsert.Close();
                //_hostGetData.Close();
                //_hostFillComboBox.Close();
                //_hostDelete.Close();
            }
            catch (TimeoutException ex)
            {
                _log.ErrorLog(ex.Message);
            }
            catch (CommunicationException ex)
            {
                _log.ErrorLog(ex.Message);
            }
        }
    }

}

using Microsoft.Practices.Unity;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouCNC.Config;
using YouCNC.Messages;
using YouCNC.Serial;
using YouCNC.Serial.Interfaces;
using YouCNC.Service;
using YouCNC.Service.Interfaces;
using YouCNC.Words;

namespace YouCNC
{
    public partial class YouCNC : Form
    {
        private ICncService _service = DIContainer.GetServiceInstance();
        MessageInterpreter interpeter;
        public YouCNC()
        {
            InitializeComponent();
            interpeter = new MessageInterpreter();
            initilaizeYouCncComponents();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            //make sure that port is opened
            if (!RunMakingProcessWorker.IsBusy)
            {
                RunMakingProcessWorker.RunWorkerAsync();
            }
            if (RunMakingProcessWorker.IsBusy)
            {
                MessageBox.Show("Process Started!");
            }
        }
        void initilaizeYouCncComponents()
        {
            SerialPortNameComboBox.Items.AddRange(_service.GetPortNames());
            portOpened = false;
            xAxisTxtBox.Text = "0.0000";
            yAxisTxtBox.Text = "0.0000";
            zAxisTxtBox.Text = "0.0000";
        }
        bool portOpened;
        private void ConnectToSerialBtn_Click(object sender, EventArgs e)
        {
            if (_service.OpenPort(SerialPortNameComboBox.Text, int.Parse(BaudRateComboBox.Text)))
            {
                MessageBox.Show("Port is Open!");
                portOpened = true;
            }
            else if (!_service.OpenPort(SerialPortNameComboBox.Text, int.Parse(BaudRateComboBox.Text)))
            {
                MessageBox.Show("Port Error");
            }
        }
        private void DisconnectFromSerialBtn_Click(object sender, EventArgs e)
        {
            if (_service.ClosePort())
            {
                MessageBox.Show("Port is Closed!");
                portOpened = false; 
            }
            else if (!_service.ClosePort())
            {
                MessageBox.Show("Port Error");
            }
        }
        int i;
        private void RunMakingProcessWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (;;)
            {
                i++;
                RunMakingProcessWorker.ReportProgress(i);
                _service.PositionsRequest();
                Thread.Sleep(100);
                if (RunMakingProcessWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
        private void RunMakingProcessWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            yAxisTxtBox.Text = e.ProgressPercentage.ToString();
            GCodeProgressBar.Value = e.ProgressPercentage;//exception
        }
        private void RunMakingProcessWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Process has been Canceled");
            }
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            if (RunMakingProcessWorker.IsBusy)
            {
                RunMakingProcessWorker.CancelAsync();
            }
        }
        private void OneLineBtn_Click(object sender, EventArgs e)
        {
            _service.SendMessage(OneLineTxtBox.Text);
        }
        public void OnPositionsReceived(object source, PositionData positions)
        {
            xAxisTxtBox.Text = "received";
        }
    }
}

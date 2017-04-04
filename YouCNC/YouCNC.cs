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
using System.IO;
using System.IO.Ports;

namespace YouCNC
{
    public partial class YouCncForm : MetroFramework.Forms.MetroForm
    {       
        private ICncService _service = DIContainer.GetServiceInstance();
        Thread GetPositionsThread;
        public YouCncForm()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
            GetPositionsThread = new Thread(PositionDemander);
            initilaizeYouCncComponents();
            OnDisconnectedYouCncInitilaizer();
        }
        
        void initilaizeYouCncComponents()
        {
            SerialPortNameComboBox.Items.AddRange(_service.GetPortNames());           
            portOpened = false;
            xAxisTxtBox.Text = "0.000";
            yAxisTxtBox.Text = "0.000";
            zAxisTxtBox.Text = "0.000";
        }
        void OnConnectedYouCncInitilaizer()
        {
            trackBarLabel.Text = "Move 5 Revolutions";
            ConnectToSerialBtn.Enabled = false;
            UnlockGrblBtn.Enabled = true;
            DisconnectFromSerialBtn.Enabled = true;
            MoveXAxisPlus.Enabled = true;
            MoveYAxisPlus.Enabled = true;
            MoveZAxisPlus.Enabled = true;
            MoveXAxisMinus.Enabled = true;
            MoveYAxisMinus.Enabled = true;
            MoveZAxisMinus.Enabled = true;
            OneLineBtn.Enabled = true;
            StartProcessTile.Enabled = true;
            ResetGrblAndYouCnc.Enabled = true;
            xSetTo0Btn.Enabled = true;
            ySetTo0Btn.Enabled = true;
            zSetTo0Btn.Enabled = true;
            xGoTo0Btn.Enabled = true;
            yGoTo0Btn.Enabled = true;
            zGoTo0Btn.Enabled = true;
            configGrblBtn.Enabled = true;
        }
        void OnDisconnectedYouCncInitilaizer()
        {
            UnlockGrblBtn.Enabled = false;
            DisconnectFromSerialBtn.Enabled = false;
            ConnectToSerialBtn.Enabled = true;
            MoveXAxisPlus.Enabled = false;
            MoveYAxisPlus.Enabled = false;
            MoveZAxisPlus.Enabled = false;
            MoveXAxisMinus.Enabled = false;
            MoveYAxisMinus.Enabled = false;
            MoveZAxisMinus.Enabled = false;
            OneLineBtn.Enabled = false;
            StartProcessTile.Enabled = false;
            PauseTile.Enabled = false;
            StopTile.Enabled = false;
            ResetGrblAndYouCnc.Enabled = false;
            xSetTo0Btn.Enabled = false;
            ySetTo0Btn.Enabled = false;
            zSetTo0Btn.Enabled = false;
            xGoTo0Btn.Enabled = false;
            yGoTo0Btn.Enabled = false;
            zGoTo0Btn.Enabled = false;
            configGrblBtn.Enabled = false;
        }

        #region EventsAndThreads
        void PositionDemander()
        {
            for (;;)
            {
                _service.PositionsRequest(serialPort);
                Thread.Sleep(50);
            }
        }
        bool GrblisIdle;
        private void OnDataReceived(object source, EventArgs args)
        {      
            // method to large
            string indata = serialPort.ReadExisting();
            if (indata.Contains(WordsContainer.IsIdle))
            {
                GrblisIdle = true;
            }
            else if (indata.Contains(WordsContainer.Run))
            {
                GrblisIdle = false;
            }
            if (string.Equals(WordsContainer.ReceivedPositions, _service.MessageInterpreter(indata)))
            {
                AppendPositionTextBoxes(_service.GetPositionData(indata));
            }
            else if (string.Equals(WordsContainer.Error, _service.MessageInterpreter(indata)))
            {
                AppendErrorTextBox(indata);
            }
        }
        #endregion
        #region TextBoxes
        public void AppendPositionTextBoxes(PositionData positions)
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action<PositionData>(AppendPositionTextBoxes), new object[] { positions });
                    return;
                }
                xAxisTxtBox.Text = positions.xPosition;
                yAxisTxtBox.Text = positions.yPosition;
                zAxisTxtBox.Text = positions.zPosition;
            }
            catch (Exception) { }
        }
        public void AppendErrorTextBox(string error)
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action<string>(AppendErrorTextBox), new object[] { error });
                    return;
                }
                receivedErrorTxtBox.Text += error;
            }
            catch (Exception) { }
        }
        private void PopulateListBox(List<string> lines)
        {
            int lineIndex = 0;
            foreach (var line in lines)
            {
                lineIndex++;
                ListViewItem commands = new ListViewItem(lineIndex.ToString());
                commands.SubItems.Add(line);
                gCodeListView.Items.Add(commands);
            }
        }
        #endregion
        #region RunWorkProcess
        int percentage = 0;
        int currentLine = 0;
        private void RunMakingProcessWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            percentage = 0;
            currentLine = 0;
            while (currentLine < linesInListBox-1)
            {
                if (GrblisIdle)
                {
                    currentLine++;
                    _service.SendMessage(serialPort, gCodeText.ElementAt(currentLine));
                }
                percentage = (int)Math.Round((double)(100 * currentLine) / linesInListBox);
                RunMakingProcessWorker.ReportProgress(percentage);             
                Thread.Sleep(80);
                if (RunMakingProcessWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
        private void RunMakingProcessWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(currentLine>0)
            gCodeListView.Items[currentLine-1].BackColor = Color.Gray;
            gCodeListView.Items[currentLine].BackColor = Color.LightGray;
            gCodeListView.EnsureVisible(currentLine);
            ProgessPercentegeLabel.Text = e.ProgressPercentage.ToString() + "%";
            GCodeProgressBar.Value = e.ProgressPercentage;
        }
        private void RunMakingProcessWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                StartProcessTile.Text = "Start";
                ProgessPercentegeLabel.Text = "100%";
                GCodeProgressBar.Value = 100;
                MessageBox.Show("Process has been Canceled");
                return;
            }
            StartProcessTile.Text = "Start";
            MessageBox.Show("Process has Completed");
        }
        #endregion
        #region Buttons
        bool portOpened;
        SerialPort serialPort = new SerialPort();
      
        int linesInListBox;
        List<string> gCodeText;
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                gCodeText = File.ReadAllLines(openFileDialog.FileName).ToList();
                PopulateListBox(gCodeText);
                linesInListBox = gCodeListView.Items.Count;
            }
            catch (Exception) { }
        }
        private void StartProcessTile_Click(object sender, EventArgs e)
        {
            //make sure that port is opened
            if (!RunMakingProcessWorker.IsBusy)
            {
                StartProcessTile.Text = "Running";
                StartProcessTile.Enabled = false;
                StopTile.Enabled = true;
                PauseTile.Enabled = true;
                RunMakingProcessWorker.RunWorkerAsync();
            }
        }
        private void StopTile_Click(object sender, EventArgs e)
        {
            if (RunMakingProcessWorker.IsBusy)
            {
                StartProcessTile.Enabled = true;
                StopTile.Enabled = false;
                PauseTile.Enabled = false;
                StartProcessTile.Text = "Start";
                _service.SendMessage(serialPort, WordsContainer.PauseStop);
                RunMakingProcessWorker.CancelAsync();
                // send message to arduino to stop
            }
        }
        bool paused = false;
        private void PauseTile_Click(object sender, EventArgs e)
        {
            if (paused)
            {
                _service.SendMessage(serialPort, WordsContainer.StartContinue);
                PauseTile.Text = "Pause";
                paused = false;
            }
            else if (!paused)
            {
                _service.SendMessage(serialPort, WordsContainer.PauseStop);
                PauseTile.Text = "Continue";
                paused = true;
            }
            // when pressed change name 
            
        }
        private void ConnectToSerialBtn_Click(object sender, EventArgs e)
        {
            serialPort.PortName = SerialPortNameComboBox.Text;
            serialPort.BaudRate = int.Parse(BaudRateComboBox.Text);
            if (_service.OpenPort(serialPort))
            {
                OnConnectedYouCncInitilaizer();
                MessageBox.Show("Port is Open!");
                try
                {
                    if (!GetPositionsThread.IsAlive)
                    {
                        GetPositionsThread.Start();
                    }
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(OnDataReceived);
                    portOpened = true;
                }
                catch (Exception) { }
            }
            else if (!_service.OpenPort(serialPort))
            {
                MessageBox.Show("Port cannot be Opened", "Port Error");
            }
        }
        private void DisconnectFromSerialBtn_Click(object sender, EventArgs e)
        {
            if (GetPositionsThread.IsAlive)
            {
                GetPositionsThread.Abort();
            }
            if (_service.ClosePort(serialPort))
            {
                OnDisconnectedYouCncInitilaizer();
                MessageBox.Show("Port is Closed!");
                portOpened = false;
            }
            else if (!_service.ClosePort(serialPort))
            {
                MessageBox.Show("Port Error");
            }
        }
        private void OneLineBtn_Click(object sender, EventArgs e)
        {
            PreviousLineTxtBox.Text = OneLineTxtBox.Text;
            _service.SendMessage(serialPort, OneLineTxtBox.Text);
            OneLineTxtBox.Text = "";
        }

        private void xSetTo0Btn_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.SetXToZero);
        }
        private void ySetTo0Btn_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.SetYToZero);
        }
        private void zSetTo0Btn_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.SetZToZero);
        }
        private void xGoTo0Btn_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.XGoToZero);
        }
        private void yGoTo0Btn_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.YGoToZero);
        }
        private void zGoTo0Btn_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.ZGoToZero);
        }


        int trackBarValue = 5;// modify
        private void StepsTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            trackBarValue = StepsTrackBar.Value / 10;

            trackBarLabel.Text = "Move " + trackBarValue + " Revolutions";
        }
        private void MoveXAxisPlus_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.RelativeCoordinates);
            _service.SendMessage(serialPort, WordsContainer.MoveXValue + trackBarValue);
            _service.SendMessage(serialPort, WordsContainer.AbsoluteCoordinates);
        }
        private void MoveXAxisMinus_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.RelativeCoordinates);
            _service.SendMessage(serialPort, WordsContainer.MoveXValue + trackBarValue * (-1));
            _service.SendMessage(serialPort, WordsContainer.AbsoluteCoordinates);
        }
        private void MoveYAxisPlus_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.RelativeCoordinates);
            _service.SendMessage(serialPort, WordsContainer.MoveYValue + trackBarValue);
            _service.SendMessage(serialPort, WordsContainer.AbsoluteCoordinates);
        }
        private void MoveYAxisMinus_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.RelativeCoordinates);
            _service.SendMessage(serialPort, WordsContainer.MoveYValue + trackBarValue * (-1));
            _service.SendMessage(serialPort, WordsContainer.AbsoluteCoordinates);
        }
        private void MoveZAxisPlus_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.RelativeCoordinates);
            _service.SendMessage(serialPort, WordsContainer.MoveZValue + trackBarValue);
            _service.SendMessage(serialPort, WordsContainer.AbsoluteCoordinates);
        }
        private void MoveZAxisMinus_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.RelativeCoordinates);
            _service.SendMessage(serialPort, WordsContainer.MoveZValue + trackBarValue * (-1));
            _service.SendMessage(serialPort, WordsContainer.AbsoluteCoordinates);
        }
        private void UnlockGrblBtn_Click(object sender, EventArgs e)
        {
            _service.SendMessage(serialPort, WordsContainer.Unlock);
        }
        private void YouCncForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (GetPositionsThread.IsAlive)
                {
                    GetPositionsThread.Abort();
                }
            }
            catch (Exception) { }
        }
        #endregion



        private void ResetGrblAndYouCnc_Click(object sender, EventArgs e)
        {
            // reset something
        }

        private void editViewToolBtn_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.ShowDialog();

            StyleData styleData = new StyleData();

            styleData = view.GetStyleData;
            if (styleData.applyed)
            {
                if (string.Equals(styleData.Theme, "Light"))
                {
                    msmMain.Theme = MetroFramework.MetroThemeStyle.Light;
                }
                if (string.Equals(styleData.Theme, "Dark"))
                {
                    msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
                }
                msmMain.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(styleData.Style);
            }
        }

        private void configGrblBtn_Click(object sender, EventArgs e)
        {
            GRBLConfiguration grblConfig = new GRBLConfiguration();
            grblConfig.ShowDialog();
        }
    }
}

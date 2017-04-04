namespace YouCNC
{
    partial class YouCncForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouCncForm));
            this.GCodeProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressBarLabel = new System.Windows.Forms.Label();
            this.xAxisTxtBox = new System.Windows.Forms.TextBox();
            this.yAxisTxtBox = new System.Windows.Forms.TextBox();
            this.zAxisTxtBox = new System.Windows.Forms.TextBox();
            this.receivedErrorTxtBox = new System.Windows.Forms.TextBox();
            this.RunMakingProcessWorker = new System.ComponentModel.BackgroundWorker();
            this.ProgessPercentegeLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fileDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.configGrblBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.editViewToolBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.StartProcessTile = new MetroFramework.Controls.MetroTile();
            this.StopTile = new MetroFramework.Controls.MetroTile();
            this.PauseTile = new MetroFramework.Controls.MetroTile();
            this.SerialPortNameComboBox = new MetroFramework.Controls.MetroComboBox();
            this.BaudRateComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ConnectToSerialBtn = new MetroFramework.Controls.MetroButton();
            this.DisconnectFromSerialBtn = new MetroFramework.Controls.MetroButton();
            this.OneLineBtn = new MetroFramework.Controls.MetroButton();
            this.ConnectionPannel = new System.Windows.Forms.Panel();
            this.SerialCommLabel = new MetroFramework.Controls.MetroLabel();
            this.gCodeLabel = new MetroFramework.Controls.MetroLabel();
            this.oneLineLabel = new MetroFramework.Controls.MetroLabel();
            this.PreviousLineTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PreviousLineLabel = new MetroFramework.Controls.MetroLabel();
            this.OneLineTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.gCodeListView = new System.Windows.Forms.ListView();
            this.LineNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xAxisLabel = new MetroFramework.Controls.MetroLabel();
            this.yAxisLabel = new MetroFramework.Controls.MetroLabel();
            this.zAxisLabel = new MetroFramework.Controls.MetroLabel();
            this.xSetTo0Btn = new MetroFramework.Controls.MetroButton();
            this.xGoTo0Btn = new MetroFramework.Controls.MetroButton();
            this.ySetTo0Btn = new MetroFramework.Controls.MetroButton();
            this.yGoTo0Btn = new MetroFramework.Controls.MetroButton();
            this.zSetTo0Btn = new MetroFramework.Controls.MetroButton();
            this.zGoTo0Btn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MoveXAxisPlus = new MetroFramework.Controls.MetroTile();
            this.MoveXAxisMinus = new MetroFramework.Controls.MetroTile();
            this.MoveYAxisPlus = new MetroFramework.Controls.MetroTile();
            this.MoveYAxisMinus = new MetroFramework.Controls.MetroTile();
            this.MoveZAxisPlus = new MetroFramework.Controls.MetroTile();
            this.MoveZAxisMinus = new MetroFramework.Controls.MetroTile();
            this.ResetGrblAndYouCnc = new MetroFramework.Controls.MetroTile();
            this.StepsTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.trackBarLabel = new System.Windows.Forms.Label();
            this.UnlockGrblBtn = new MetroFramework.Controls.MetroButton();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.ConnectionPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GCodeProgressBar
            // 
            this.GCodeProgressBar.Location = new System.Drawing.Point(24, 682);
            this.GCodeProgressBar.Name = "GCodeProgressBar";
            this.GCodeProgressBar.Size = new System.Drawing.Size(474, 23);
            this.GCodeProgressBar.TabIndex = 2;
            // 
            // ProgressBarLabel
            // 
            this.ProgressBarLabel.AutoSize = true;
            this.ProgressBarLabel.ForeColor = System.Drawing.Color.Black;
            this.ProgressBarLabel.Location = new System.Drawing.Point(23, 666);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(51, 13);
            this.ProgressBarLabel.TabIndex = 3;
            this.ProgressBarLabel.Text = "Progress:";
            // 
            // xAxisTxtBox
            // 
            this.xAxisTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAxisTxtBox.Location = new System.Drawing.Point(599, 127);
            this.xAxisTxtBox.Multiline = true;
            this.xAxisTxtBox.Name = "xAxisTxtBox";
            this.xAxisTxtBox.ReadOnly = true;
            this.xAxisTxtBox.Size = new System.Drawing.Size(249, 52);
            this.xAxisTxtBox.TabIndex = 4;
            this.xAxisTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yAxisTxtBox
            // 
            this.yAxisTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxisTxtBox.Location = new System.Drawing.Point(599, 215);
            this.yAxisTxtBox.Multiline = true;
            this.yAxisTxtBox.Name = "yAxisTxtBox";
            this.yAxisTxtBox.ReadOnly = true;
            this.yAxisTxtBox.Size = new System.Drawing.Size(249, 56);
            this.yAxisTxtBox.TabIndex = 5;
            this.yAxisTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zAxisTxtBox
            // 
            this.zAxisTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zAxisTxtBox.Location = new System.Drawing.Point(599, 308);
            this.zAxisTxtBox.Multiline = true;
            this.zAxisTxtBox.Name = "zAxisTxtBox";
            this.zAxisTxtBox.ReadOnly = true;
            this.zAxisTxtBox.Size = new System.Drawing.Size(249, 52);
            this.zAxisTxtBox.TabIndex = 6;
            this.zAxisTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // receivedErrorTxtBox
            // 
            this.receivedErrorTxtBox.Location = new System.Drawing.Point(11, 117);
            this.receivedErrorTxtBox.Multiline = true;
            this.receivedErrorTxtBox.Name = "receivedErrorTxtBox";
            this.receivedErrorTxtBox.ReadOnly = true;
            this.receivedErrorTxtBox.Size = new System.Drawing.Size(212, 67);
            this.receivedErrorTxtBox.TabIndex = 17;
            // 
            // RunMakingProcessWorker
            // 
            this.RunMakingProcessWorker.WorkerReportsProgress = true;
            this.RunMakingProcessWorker.WorkerSupportsCancellation = true;
            this.RunMakingProcessWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RunMakingProcessWorker_DoWork);
            this.RunMakingProcessWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.RunMakingProcessWorker_ProgressChanged);
            this.RunMakingProcessWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RunMakingProcessWorker_RunWorkerCompleted);
            // 
            // ProgessPercentegeLabel
            // 
            this.ProgessPercentegeLabel.AutoSize = true;
            this.ProgessPercentegeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProgessPercentegeLabel.Location = new System.Drawing.Point(74, 666);
            this.ProgessPercentegeLabel.Name = "ProgessPercentegeLabel";
            this.ProgessPercentegeLabel.Size = new System.Drawing.Size(24, 13);
            this.ProgessPercentegeLabel.TabIndex = 18;
            this.ProgessPercentegeLabel.Text = "Idle";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // fileDropDown
            // 
            this.fileDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileBtn});
            this.fileDropDown.Image = ((System.Drawing.Image)(resources.GetObject("fileDropDown.Image")));
            this.fileDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileDropDown.Name = "fileDropDown";
            this.fileDropDown.Size = new System.Drawing.Size(38, 22);
            this.fileDropDown.Text = "File";
            // 
            // openFileBtn
            // 
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(103, 22);
            this.openFileBtn.Text = "Open";
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // configToolBtn
            // 
            this.configToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.configToolBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configGrblBtn,
            this.editViewToolBtn});
            this.configToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("configToolBtn.Image")));
            this.configToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.configToolBtn.Name = "configToolBtn";
            this.configToolBtn.Size = new System.Drawing.Size(56, 22);
            this.configToolBtn.Text = "Config";
            // 
            // configGrblBtn
            // 
            this.configGrblBtn.Name = "configGrblBtn";
            this.configGrblBtn.Size = new System.Drawing.Size(152, 22);
            this.configGrblBtn.Text = "GRBL";
            this.configGrblBtn.Click += new System.EventHandler(this.configGrblBtn_Click);
            // 
            // editViewToolBtn
            // 
            this.editViewToolBtn.Name = "editViewToolBtn";
            this.editViewToolBtn.Size = new System.Drawing.Size(152, 22);
            this.editViewToolBtn.Text = "View";
            this.editViewToolBtn.Click += new System.EventHandler(this.editViewToolBtn_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropDown,
            this.configToolBtn});
            this.toolStrip.Location = new System.Drawing.Point(20, 60);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1323, 25);
            this.toolStrip.TabIndex = 22;
            this.toolStrip.Text = "toolStrip";
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // StartProcessTile
            // 
            this.StartProcessTile.ActiveControl = null;
            this.StartProcessTile.Location = new System.Drawing.Point(510, 536);
            this.StartProcessTile.Name = "StartProcessTile";
            this.StartProcessTile.Size = new System.Drawing.Size(101, 65);
            this.StartProcessTile.TabIndex = 32;
            this.StartProcessTile.Text = "Start ";
            this.StartProcessTile.UseSelectable = true;
            this.StartProcessTile.Click += new System.EventHandler(this.StartProcessTile_Click);
            // 
            // StopTile
            // 
            this.StopTile.ActiveControl = null;
            this.StopTile.Location = new System.Drawing.Point(617, 536);
            this.StopTile.Name = "StopTile";
            this.StopTile.Size = new System.Drawing.Size(102, 65);
            this.StopTile.TabIndex = 33;
            this.StopTile.Text = "Stop";
            this.StopTile.UseSelectable = true;
            this.StopTile.Click += new System.EventHandler(this.StopTile_Click);
            // 
            // PauseTile
            // 
            this.PauseTile.ActiveControl = null;
            this.PauseTile.Location = new System.Drawing.Point(728, 536);
            this.PauseTile.Name = "PauseTile";
            this.PauseTile.Size = new System.Drawing.Size(108, 65);
            this.PauseTile.TabIndex = 34;
            this.PauseTile.Text = "Pause";
            this.PauseTile.UseSelectable = true;
            this.PauseTile.Click += new System.EventHandler(this.PauseTile_Click);
            // 
            // SerialPortNameComboBox
            // 
            this.SerialPortNameComboBox.FormattingEnabled = true;
            this.SerialPortNameComboBox.ItemHeight = 23;
            this.SerialPortNameComboBox.Location = new System.Drawing.Point(102, 9);
            this.SerialPortNameComboBox.Name = "SerialPortNameComboBox";
            this.SerialPortNameComboBox.Size = new System.Drawing.Size(121, 29);
            this.SerialPortNameComboBox.TabIndex = 35;
            this.SerialPortNameComboBox.UseSelectable = true;
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.ItemHeight = 23;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "250000"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(102, 44);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(121, 29);
            this.BaudRateComboBox.TabIndex = 36;
            this.BaudRateComboBox.UseSelectable = true;
            // 
            // ConnectToSerialBtn
            // 
            this.ConnectToSerialBtn.Location = new System.Drawing.Point(11, 9);
            this.ConnectToSerialBtn.Name = "ConnectToSerialBtn";
            this.ConnectToSerialBtn.Size = new System.Drawing.Size(75, 28);
            this.ConnectToSerialBtn.TabIndex = 37;
            this.ConnectToSerialBtn.Text = "Connect";
            this.ConnectToSerialBtn.UseSelectable = true;
            this.ConnectToSerialBtn.Click += new System.EventHandler(this.ConnectToSerialBtn_Click);
            // 
            // DisconnectFromSerialBtn
            // 
            this.DisconnectFromSerialBtn.Location = new System.Drawing.Point(11, 43);
            this.DisconnectFromSerialBtn.Name = "DisconnectFromSerialBtn";
            this.DisconnectFromSerialBtn.Size = new System.Drawing.Size(75, 30);
            this.DisconnectFromSerialBtn.TabIndex = 38;
            this.DisconnectFromSerialBtn.Text = "Disconnect";
            this.DisconnectFromSerialBtn.UseSelectable = true;
            this.DisconnectFromSerialBtn.Click += new System.EventHandler(this.DisconnectFromSerialBtn_Click);
            // 
            // OneLineBtn
            // 
            this.OneLineBtn.Location = new System.Drawing.Point(764, 481);
            this.OneLineBtn.Name = "OneLineBtn";
            this.OneLineBtn.Size = new System.Drawing.Size(72, 20);
            this.OneLineBtn.TabIndex = 39;
            this.OneLineBtn.Text = "Go";
            this.OneLineBtn.UseSelectable = true;
            this.OneLineBtn.Click += new System.EventHandler(this.OneLineBtn_Click);
            // 
            // ConnectionPannel
            // 
            this.ConnectionPannel.AutoSize = true;
            this.ConnectionPannel.Controls.Add(this.UnlockGrblBtn);
            this.ConnectionPannel.Controls.Add(this.DisconnectFromSerialBtn);
            this.ConnectionPannel.Controls.Add(this.receivedErrorTxtBox);
            this.ConnectionPannel.Controls.Add(this.SerialPortNameComboBox);
            this.ConnectionPannel.Controls.Add(this.BaudRateComboBox);
            this.ConnectionPannel.Controls.Add(this.ConnectToSerialBtn);
            this.ConnectionPannel.Location = new System.Drawing.Point(1101, 127);
            this.ConnectionPannel.Name = "ConnectionPannel";
            this.ConnectionPannel.Size = new System.Drawing.Size(239, 204);
            this.ConnectionPannel.TabIndex = 40;
            // 
            // SerialCommLabel
            // 
            this.SerialCommLabel.AutoSize = true;
            this.SerialCommLabel.Location = new System.Drawing.Point(1101, 105);
            this.SerialCommLabel.Name = "SerialCommLabel";
            this.SerialCommLabel.Size = new System.Drawing.Size(138, 19);
            this.SerialCommLabel.TabIndex = 41;
            this.SerialCommLabel.Text = "Serial Communication";
            // 
            // gCodeLabel
            // 
            this.gCodeLabel.AutoSize = true;
            this.gCodeLabel.Location = new System.Drawing.Point(20, 83);
            this.gCodeLabel.Name = "gCodeLabel";
            this.gCodeLabel.Size = new System.Drawing.Size(54, 19);
            this.gCodeLabel.TabIndex = 42;
            this.gCodeLabel.Text = "G Code";
            // 
            // oneLineLabel
            // 
            this.oneLineLabel.AutoSize = true;
            this.oneLineLabel.Location = new System.Drawing.Point(510, 459);
            this.oneLineLabel.Name = "oneLineLabel";
            this.oneLineLabel.Size = new System.Drawing.Size(106, 19);
            this.oneLineLabel.TabIndex = 43;
            this.oneLineLabel.Text = "One Line Sender";
            // 
            // PreviousLineTxtBox
            // 
            // 
            // 
            // 
            this.PreviousLineTxtBox.CustomButton.Image = null;
            this.PreviousLineTxtBox.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.PreviousLineTxtBox.CustomButton.Name = "";
            this.PreviousLineTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PreviousLineTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PreviousLineTxtBox.CustomButton.TabIndex = 1;
            this.PreviousLineTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PreviousLineTxtBox.CustomButton.UseSelectable = true;
            this.PreviousLineTxtBox.CustomButton.Visible = false;
            this.PreviousLineTxtBox.Enabled = false;
            this.PreviousLineTxtBox.Lines = new string[0];
            this.PreviousLineTxtBox.Location = new System.Drawing.Point(510, 433);
            this.PreviousLineTxtBox.MaxLength = 32767;
            this.PreviousLineTxtBox.Name = "PreviousLineTxtBox";
            this.PreviousLineTxtBox.PasswordChar = '\0';
            this.PreviousLineTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PreviousLineTxtBox.SelectedText = "";
            this.PreviousLineTxtBox.SelectionLength = 0;
            this.PreviousLineTxtBox.SelectionStart = 0;
            this.PreviousLineTxtBox.ShortcutsEnabled = true;
            this.PreviousLineTxtBox.Size = new System.Drawing.Size(248, 23);
            this.PreviousLineTxtBox.TabIndex = 44;
            this.PreviousLineTxtBox.UseSelectable = true;
            this.PreviousLineTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PreviousLineTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PreviousLineLabel
            // 
            this.PreviousLineLabel.AutoSize = true;
            this.PreviousLineLabel.Location = new System.Drawing.Point(510, 411);
            this.PreviousLineLabel.Name = "PreviousLineLabel";
            this.PreviousLineLabel.Size = new System.Drawing.Size(113, 19);
            this.PreviousLineLabel.TabIndex = 45;
            this.PreviousLineLabel.Text = "Previous Message";
            // 
            // OneLineTxtBox
            // 
            // 
            // 
            // 
            this.OneLineTxtBox.CustomButton.Image = null;
            this.OneLineTxtBox.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.OneLineTxtBox.CustomButton.Name = "";
            this.OneLineTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.OneLineTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OneLineTxtBox.CustomButton.TabIndex = 1;
            this.OneLineTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OneLineTxtBox.CustomButton.UseSelectable = true;
            this.OneLineTxtBox.CustomButton.Visible = false;
            this.OneLineTxtBox.Lines = new string[0];
            this.OneLineTxtBox.Location = new System.Drawing.Point(510, 481);
            this.OneLineTxtBox.MaxLength = 32767;
            this.OneLineTxtBox.Name = "OneLineTxtBox";
            this.OneLineTxtBox.PasswordChar = '\0';
            this.OneLineTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OneLineTxtBox.SelectedText = "";
            this.OneLineTxtBox.SelectionLength = 0;
            this.OneLineTxtBox.SelectionStart = 0;
            this.OneLineTxtBox.ShortcutsEnabled = true;
            this.OneLineTxtBox.Size = new System.Drawing.Size(248, 23);
            this.OneLineTxtBox.TabIndex = 46;
            this.OneLineTxtBox.UseSelectable = true;
            this.OneLineTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OneLineTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gCodeListView
            // 
            this.gCodeListView.BackColor = System.Drawing.Color.Gray;
            this.gCodeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LineNumber,
            this.Command});
            this.gCodeListView.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gCodeListView.Location = new System.Drawing.Point(24, 105);
            this.gCodeListView.Name = "gCodeListView";
            this.gCodeListView.Size = new System.Drawing.Size(474, 549);
            this.gCodeListView.TabIndex = 47;
            this.gCodeListView.UseCompatibleStateImageBehavior = false;
            this.gCodeListView.View = System.Windows.Forms.View.Details;
            // 
            // LineNumber
            // 
            this.LineNumber.Text = "Line";
            // 
            // Command
            // 
            this.Command.Text = "Command";
            this.Command.Width = 422;
            // 
            // xAxisLabel
            // 
            this.xAxisLabel.AutoSize = true;
            this.xAxisLabel.Location = new System.Drawing.Point(599, 105);
            this.xAxisLabel.Name = "xAxisLabel";
            this.xAxisLabel.Size = new System.Drawing.Size(44, 19);
            this.xAxisLabel.TabIndex = 48;
            this.xAxisLabel.Text = "X Axis";
            // 
            // yAxisLabel
            // 
            this.yAxisLabel.AutoSize = true;
            this.yAxisLabel.Location = new System.Drawing.Point(599, 193);
            this.yAxisLabel.Name = "yAxisLabel";
            this.yAxisLabel.Size = new System.Drawing.Size(44, 19);
            this.yAxisLabel.TabIndex = 49;
            this.yAxisLabel.Text = "Y Axis";
            // 
            // zAxisLabel
            // 
            this.zAxisLabel.AutoSize = true;
            this.zAxisLabel.Location = new System.Drawing.Point(599, 286);
            this.zAxisLabel.Name = "zAxisLabel";
            this.zAxisLabel.Size = new System.Drawing.Size(44, 19);
            this.zAxisLabel.TabIndex = 50;
            this.zAxisLabel.Text = "Z Axis";
            // 
            // xSetTo0Btn
            // 
            this.xSetTo0Btn.Location = new System.Drawing.Point(510, 127);
            this.xSetTo0Btn.Name = "xSetTo0Btn";
            this.xSetTo0Btn.Size = new System.Drawing.Size(75, 23);
            this.xSetTo0Btn.TabIndex = 51;
            this.xSetTo0Btn.Text = "Set To 0";
            this.xSetTo0Btn.UseSelectable = true;
            this.xSetTo0Btn.Click += new System.EventHandler(this.xSetTo0Btn_Click);
            // 
            // xGoTo0Btn
            // 
            this.xGoTo0Btn.Location = new System.Drawing.Point(510, 156);
            this.xGoTo0Btn.Name = "xGoTo0Btn";
            this.xGoTo0Btn.Size = new System.Drawing.Size(75, 23);
            this.xGoTo0Btn.TabIndex = 52;
            this.xGoTo0Btn.Text = "Go To 0";
            this.xGoTo0Btn.UseSelectable = true;
            this.xGoTo0Btn.Click += new System.EventHandler(this.xGoTo0Btn_Click);
            // 
            // ySetTo0Btn
            // 
            this.ySetTo0Btn.Location = new System.Drawing.Point(510, 215);
            this.ySetTo0Btn.Name = "ySetTo0Btn";
            this.ySetTo0Btn.Size = new System.Drawing.Size(75, 23);
            this.ySetTo0Btn.TabIndex = 53;
            this.ySetTo0Btn.Text = "Set To 0";
            this.ySetTo0Btn.UseSelectable = true;
            this.ySetTo0Btn.Click += new System.EventHandler(this.ySetTo0Btn_Click);
            // 
            // yGoTo0Btn
            // 
            this.yGoTo0Btn.Location = new System.Drawing.Point(510, 244);
            this.yGoTo0Btn.Name = "yGoTo0Btn";
            this.yGoTo0Btn.Size = new System.Drawing.Size(75, 23);
            this.yGoTo0Btn.TabIndex = 54;
            this.yGoTo0Btn.Text = "Go To 0";
            this.yGoTo0Btn.UseSelectable = true;
            this.yGoTo0Btn.Click += new System.EventHandler(this.yGoTo0Btn_Click);
            // 
            // zSetTo0Btn
            // 
            this.zSetTo0Btn.Location = new System.Drawing.Point(510, 308);
            this.zSetTo0Btn.Name = "zSetTo0Btn";
            this.zSetTo0Btn.Size = new System.Drawing.Size(75, 23);
            this.zSetTo0Btn.TabIndex = 55;
            this.zSetTo0Btn.Text = "Set To 0";
            this.zSetTo0Btn.UseSelectable = true;
            this.zSetTo0Btn.Click += new System.EventHandler(this.zSetTo0Btn_Click);
            // 
            // zGoTo0Btn
            // 
            this.zGoTo0Btn.Location = new System.Drawing.Point(510, 337);
            this.zGoTo0Btn.Name = "zGoTo0Btn";
            this.zGoTo0Btn.Size = new System.Drawing.Size(75, 23);
            this.zGoTo0Btn.TabIndex = 56;
            this.zGoTo0Btn.Text = "Go To 0";
            this.zGoTo0Btn.UseSelectable = true;
            this.zGoTo0Btn.Click += new System.EventHandler(this.zGoTo0Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(857, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 380);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // MoveXAxisPlus
            // 
            this.MoveXAxisPlus.ActiveControl = null;
            this.MoveXAxisPlus.Location = new System.Drawing.Point(870, 127);
            this.MoveXAxisPlus.Name = "MoveXAxisPlus";
            this.MoveXAxisPlus.Size = new System.Drawing.Size(90, 49);
            this.MoveXAxisPlus.TabIndex = 58;
            this.MoveXAxisPlus.Text = "Move X+";
            this.MoveXAxisPlus.UseSelectable = true;
            this.MoveXAxisPlus.Click += new System.EventHandler(this.MoveXAxisPlus_Click);
            // 
            // MoveXAxisMinus
            // 
            this.MoveXAxisMinus.ActiveControl = null;
            this.MoveXAxisMinus.Location = new System.Drawing.Point(992, 127);
            this.MoveXAxisMinus.Name = "MoveXAxisMinus";
            this.MoveXAxisMinus.Size = new System.Drawing.Size(90, 49);
            this.MoveXAxisMinus.TabIndex = 59;
            this.MoveXAxisMinus.Text = "Move X-";
            this.MoveXAxisMinus.UseSelectable = true;
            this.MoveXAxisMinus.Click += new System.EventHandler(this.MoveXAxisMinus_Click);
            // 
            // MoveYAxisPlus
            // 
            this.MoveYAxisPlus.ActiveControl = null;
            this.MoveYAxisPlus.Location = new System.Drawing.Point(870, 182);
            this.MoveYAxisPlus.Name = "MoveYAxisPlus";
            this.MoveYAxisPlus.Size = new System.Drawing.Size(90, 49);
            this.MoveYAxisPlus.TabIndex = 60;
            this.MoveYAxisPlus.Text = "Move Y+";
            this.MoveYAxisPlus.UseSelectable = true;
            this.MoveYAxisPlus.Click += new System.EventHandler(this.MoveYAxisPlus_Click);
            // 
            // MoveYAxisMinus
            // 
            this.MoveYAxisMinus.ActiveControl = null;
            this.MoveYAxisMinus.Location = new System.Drawing.Point(992, 182);
            this.MoveYAxisMinus.Name = "MoveYAxisMinus";
            this.MoveYAxisMinus.Size = new System.Drawing.Size(90, 49);
            this.MoveYAxisMinus.TabIndex = 61;
            this.MoveYAxisMinus.Text = "Move Y-";
            this.MoveYAxisMinus.UseSelectable = true;
            this.MoveYAxisMinus.Click += new System.EventHandler(this.MoveYAxisMinus_Click);
            // 
            // MoveZAxisPlus
            // 
            this.MoveZAxisPlus.ActiveControl = null;
            this.MoveZAxisPlus.Location = new System.Drawing.Point(870, 237);
            this.MoveZAxisPlus.Name = "MoveZAxisPlus";
            this.MoveZAxisPlus.Size = new System.Drawing.Size(90, 49);
            this.MoveZAxisPlus.TabIndex = 62;
            this.MoveZAxisPlus.Text = "Move Z+";
            this.MoveZAxisPlus.UseSelectable = true;
            this.MoveZAxisPlus.Click += new System.EventHandler(this.MoveZAxisPlus_Click);
            // 
            // MoveZAxisMinus
            // 
            this.MoveZAxisMinus.ActiveControl = null;
            this.MoveZAxisMinus.Location = new System.Drawing.Point(992, 237);
            this.MoveZAxisMinus.Name = "MoveZAxisMinus";
            this.MoveZAxisMinus.Size = new System.Drawing.Size(90, 49);
            this.MoveZAxisMinus.TabIndex = 63;
            this.MoveZAxisMinus.Text = "Move Z-";
            this.MoveZAxisMinus.UseSelectable = true;
            this.MoveZAxisMinus.Click += new System.EventHandler(this.MoveZAxisMinus_Click);
            // 
            // ResetGrblAndYouCnc
            // 
            this.ResetGrblAndYouCnc.ActiveControl = null;
            this.ResetGrblAndYouCnc.Location = new System.Drawing.Point(510, 607);
            this.ResetGrblAndYouCnc.Name = "ResetGrblAndYouCnc";
            this.ResetGrblAndYouCnc.Size = new System.Drawing.Size(326, 47);
            this.ResetGrblAndYouCnc.TabIndex = 64;
            this.ResetGrblAndYouCnc.Text = "Reset";
            this.ResetGrblAndYouCnc.UseSelectable = true;
            this.ResetGrblAndYouCnc.Click += new System.EventHandler(this.ResetGrblAndYouCnc_Click);
            // 
            // StepsTrackBar
            // 
            this.StepsTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.StepsTrackBar.Location = new System.Drawing.Point(870, 308);
            this.StepsTrackBar.Name = "StepsTrackBar";
            this.StepsTrackBar.Size = new System.Drawing.Size(212, 23);
            this.StepsTrackBar.TabIndex = 65;
            this.StepsTrackBar.Text = "stepsTrackBar";
            this.StepsTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.StepsTrackBar_Scroll);
            // 
            // trackBarLabel
            // 
            this.trackBarLabel.AutoSize = true;
            this.trackBarLabel.Location = new System.Drawing.Point(870, 291);
            this.trackBarLabel.Name = "trackBarLabel";
            this.trackBarLabel.Size = new System.Drawing.Size(64, 13);
            this.trackBarLabel.TabIndex = 66;
            this.trackBarLabel.Text = "Move Steps";
            // 
            // UnlockGrblBtn
            // 
            this.UnlockGrblBtn.Location = new System.Drawing.Point(11, 80);
            this.UnlockGrblBtn.Name = "UnlockGrblBtn";
            this.UnlockGrblBtn.Size = new System.Drawing.Size(212, 23);
            this.UnlockGrblBtn.TabIndex = 39;
            this.UnlockGrblBtn.Text = "Unlock";
            this.UnlockGrblBtn.UseSelectable = true;
            this.UnlockGrblBtn.Click += new System.EventHandler(this.UnlockGrblBtn_Click);
            // 
            // YouCncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 738);
            this.Controls.Add(this.trackBarLabel);
            this.Controls.Add(this.StepsTrackBar);
            this.Controls.Add(this.ResetGrblAndYouCnc);
            this.Controls.Add(this.MoveZAxisMinus);
            this.Controls.Add(this.MoveZAxisPlus);
            this.Controls.Add(this.MoveYAxisMinus);
            this.Controls.Add(this.MoveYAxisPlus);
            this.Controls.Add(this.MoveXAxisMinus);
            this.Controls.Add(this.MoveXAxisPlus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zGoTo0Btn);
            this.Controls.Add(this.zSetTo0Btn);
            this.Controls.Add(this.yGoTo0Btn);
            this.Controls.Add(this.ySetTo0Btn);
            this.Controls.Add(this.xGoTo0Btn);
            this.Controls.Add(this.xSetTo0Btn);
            this.Controls.Add(this.zAxisLabel);
            this.Controls.Add(this.yAxisLabel);
            this.Controls.Add(this.xAxisLabel);
            this.Controls.Add(this.gCodeListView);
            this.Controls.Add(this.OneLineTxtBox);
            this.Controls.Add(this.PreviousLineLabel);
            this.Controls.Add(this.PreviousLineTxtBox);
            this.Controls.Add(this.oneLineLabel);
            this.Controls.Add(this.gCodeLabel);
            this.Controls.Add(this.SerialCommLabel);
            this.Controls.Add(this.ConnectionPannel);
            this.Controls.Add(this.OneLineBtn);
            this.Controls.Add(this.PauseTile);
            this.Controls.Add(this.StopTile);
            this.Controls.Add(this.StartProcessTile);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.ProgessPercentegeLabel);
            this.Controls.Add(this.zAxisTxtBox);
            this.Controls.Add(this.yAxisTxtBox);
            this.Controls.Add(this.xAxisTxtBox);
            this.Controls.Add(this.ProgressBarLabel);
            this.Controls.Add(this.GCodeProgressBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "YouCncForm";
            this.Text = "YouCNC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YouCncForm_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ConnectionPannel.ResumeLayout(false);
            this.ConnectionPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar GCodeProgressBar;
        private System.Windows.Forms.Label ProgressBarLabel;
        private System.Windows.Forms.TextBox xAxisTxtBox;
        private System.Windows.Forms.TextBox yAxisTxtBox;
        private System.Windows.Forms.TextBox zAxisTxtBox;
        private System.Windows.Forms.TextBox receivedErrorTxtBox;
        private System.ComponentModel.BackgroundWorker RunMakingProcessWorker;
        private System.Windows.Forms.Label ProgessPercentegeLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripDropDownButton fileDropDown;
        private System.Windows.Forms.ToolStripMenuItem openFileBtn;
        private System.Windows.Forms.ToolStripDropDownButton configToolBtn;
        private System.Windows.Forms.ToolStripMenuItem configGrblBtn;
        private System.Windows.Forms.ToolStripMenuItem editViewToolBtn;
        private System.Windows.Forms.ToolStrip toolStrip;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroTile StartProcessTile;
        private MetroFramework.Controls.MetroTile PauseTile;
        private MetroFramework.Controls.MetroTile StopTile;
        private MetroFramework.Controls.MetroComboBox SerialPortNameComboBox;
        private MetroFramework.Controls.MetroButton OneLineBtn;
        private MetroFramework.Controls.MetroButton DisconnectFromSerialBtn;
        private MetroFramework.Controls.MetroButton ConnectToSerialBtn;
        private MetroFramework.Controls.MetroComboBox BaudRateComboBox;
        private System.Windows.Forms.Panel ConnectionPannel;
        private MetroFramework.Controls.MetroTextBox OneLineTxtBox;
        private MetroFramework.Controls.MetroLabel PreviousLineLabel;
        private MetroFramework.Controls.MetroTextBox PreviousLineTxtBox;
        private MetroFramework.Controls.MetroLabel oneLineLabel;
        private MetroFramework.Controls.MetroLabel gCodeLabel;
        private MetroFramework.Controls.MetroLabel SerialCommLabel;
        private System.Windows.Forms.ListView gCodeListView;
        private System.Windows.Forms.ColumnHeader LineNumber;
        private System.Windows.Forms.ColumnHeader Command;
        private MetroFramework.Controls.MetroButton zGoTo0Btn;
        private MetroFramework.Controls.MetroButton zSetTo0Btn;
        private MetroFramework.Controls.MetroButton yGoTo0Btn;
        private MetroFramework.Controls.MetroButton ySetTo0Btn;
        private MetroFramework.Controls.MetroButton xGoTo0Btn;
        private MetroFramework.Controls.MetroButton xSetTo0Btn;
        private MetroFramework.Controls.MetroLabel zAxisLabel;
        private MetroFramework.Controls.MetroLabel yAxisLabel;
        private MetroFramework.Controls.MetroLabel xAxisLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile MoveZAxisMinus;
        private MetroFramework.Controls.MetroTile MoveZAxisPlus;
        private MetroFramework.Controls.MetroTile MoveYAxisMinus;
        private MetroFramework.Controls.MetroTile MoveYAxisPlus;
        private MetroFramework.Controls.MetroTile MoveXAxisMinus;
        private MetroFramework.Controls.MetroTile MoveXAxisPlus;
        private MetroFramework.Controls.MetroTrackBar StepsTrackBar;
        private MetroFramework.Controls.MetroTile ResetGrblAndYouCnc;
        private System.Windows.Forms.Label trackBarLabel;
        private MetroFramework.Controls.MetroButton UnlockGrblBtn;
    }
}
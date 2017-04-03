namespace YouCNC
{
    partial class YouCNC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouCNC));
            this.GCodeLabel = new System.Windows.Forms.Label();
            this.GCodeProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressBarLabel = new System.Windows.Forms.Label();
            this.xAxisTxtBox = new System.Windows.Forms.TextBox();
            this.yAxisTxtBox = new System.Windows.Forms.TextBox();
            this.zAxisTxtBox = new System.Windows.Forms.TextBox();
            this.xAxisLabel = new System.Windows.Forms.Label();
            this.yAxisLabel = new System.Windows.Forms.Label();
            this.zAxisLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ConnectToSerialBtn = new System.Windows.Forms.Button();
            this.SerialPortNameComboBox = new System.Windows.Forms.ComboBox();
            this.DisconnectFromSerialBtn = new System.Windows.Forms.Button();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.SerialCommunicationGroupBox = new System.Windows.Forms.GroupBox();
            this.receivedErrorTxtBox = new System.Windows.Forms.TextBox();
            this.RunMakingProcessWorker = new System.ComponentModel.BackgroundWorker();
            this.ProgessPercentegeLabel = new System.Windows.Forms.Label();
            this.OneLineBtn = new System.Windows.Forms.Button();
            this.OneLineTxtBox = new System.Windows.Forms.TextBox();
            this.gCodeListBox = new System.Windows.Forms.ListBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.fileDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.xSetTo0Btn = new System.Windows.Forms.Button();
            this.ySetTo0Btn = new System.Windows.Forms.Button();
            this.zSetTo0Btn = new System.Windows.Forms.Button();
            this.xGoTo0Btn = new System.Windows.Forms.Button();
            this.yGoTo0Btn = new System.Windows.Forms.Button();
            this.zGoTo0Btn = new System.Windows.Forms.Button();
            this.SerialCommunicationGroupBox.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GCodeLabel
            // 
            this.GCodeLabel.AutoSize = true;
            this.GCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GCodeLabel.Location = new System.Drawing.Point(12, 35);
            this.GCodeLabel.Name = "GCodeLabel";
            this.GCodeLabel.Size = new System.Drawing.Size(40, 13);
            this.GCodeLabel.TabIndex = 1;
            this.GCodeLabel.Text = "GCode";
            // 
            // GCodeProgressBar
            // 
            this.GCodeProgressBar.Location = new System.Drawing.Point(12, 711);
            this.GCodeProgressBar.Name = "GCodeProgressBar";
            this.GCodeProgressBar.Size = new System.Drawing.Size(478, 23);
            this.GCodeProgressBar.TabIndex = 2;
            // 
            // ProgressBarLabel
            // 
            this.ProgressBarLabel.AutoSize = true;
            this.ProgressBarLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProgressBarLabel.Location = new System.Drawing.Point(12, 695);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(51, 13);
            this.ProgressBarLabel.TabIndex = 3;
            this.ProgressBarLabel.Text = "Progress:";
            // 
            // xAxisTxtBox
            // 
            this.xAxisTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAxisTxtBox.Location = new System.Drawing.Point(575, 66);
            this.xAxisTxtBox.Multiline = true;
            this.xAxisTxtBox.Name = "xAxisTxtBox";
            this.xAxisTxtBox.ReadOnly = true;
            this.xAxisTxtBox.Size = new System.Drawing.Size(249, 49);
            this.xAxisTxtBox.TabIndex = 4;
            this.xAxisTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yAxisTxtBox
            // 
            this.yAxisTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxisTxtBox.Location = new System.Drawing.Point(575, 134);
            this.yAxisTxtBox.Multiline = true;
            this.yAxisTxtBox.Name = "yAxisTxtBox";
            this.yAxisTxtBox.ReadOnly = true;
            this.yAxisTxtBox.Size = new System.Drawing.Size(249, 49);
            this.yAxisTxtBox.TabIndex = 5;
            this.yAxisTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zAxisTxtBox
            // 
            this.zAxisTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zAxisTxtBox.Location = new System.Drawing.Point(575, 210);
            this.zAxisTxtBox.Multiline = true;
            this.zAxisTxtBox.Name = "zAxisTxtBox";
            this.zAxisTxtBox.ReadOnly = true;
            this.zAxisTxtBox.Size = new System.Drawing.Size(249, 49);
            this.zAxisTxtBox.TabIndex = 6;
            this.zAxisTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xAxisLabel
            // 
            this.xAxisLabel.AutoSize = true;
            this.xAxisLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xAxisLabel.Location = new System.Drawing.Point(572, 44);
            this.xAxisLabel.Name = "xAxisLabel";
            this.xAxisLabel.Size = new System.Drawing.Size(36, 13);
            this.xAxisLabel.TabIndex = 7;
            this.xAxisLabel.Text = "X Axis";
            // 
            // yAxisLabel
            // 
            this.yAxisLabel.AutoSize = true;
            this.yAxisLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yAxisLabel.Location = new System.Drawing.Point(572, 118);
            this.yAxisLabel.Name = "yAxisLabel";
            this.yAxisLabel.Size = new System.Drawing.Size(36, 13);
            this.yAxisLabel.TabIndex = 8;
            this.yAxisLabel.Text = "Y Axis";
            // 
            // zAxisLabel
            // 
            this.zAxisLabel.AutoSize = true;
            this.zAxisLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zAxisLabel.Location = new System.Drawing.Point(572, 194);
            this.zAxisLabel.Name = "zAxisLabel";
            this.zAxisLabel.Size = new System.Drawing.Size(36, 13);
            this.zAxisLabel.TabIndex = 9;
            this.zAxisLabel.Text = "Z Axis";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(497, 610);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(105, 65);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(608, 610);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(105, 65);
            this.StopButton.TabIndex = 11;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(719, 610);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(105, 65);
            this.PauseButton.TabIndex = 12;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // ConnectToSerialBtn
            // 
            this.ConnectToSerialBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ConnectToSerialBtn.Location = new System.Drawing.Point(16, 19);
            this.ConnectToSerialBtn.Name = "ConnectToSerialBtn";
            this.ConnectToSerialBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectToSerialBtn.TabIndex = 13;
            this.ConnectToSerialBtn.Text = "Connect";
            this.ConnectToSerialBtn.UseVisualStyleBackColor = false;
            this.ConnectToSerialBtn.Click += new System.EventHandler(this.ConnectToSerialBtn_Click);
            // 
            // SerialPortNameComboBox
            // 
            this.SerialPortNameComboBox.FormattingEnabled = true;
            this.SerialPortNameComboBox.Location = new System.Drawing.Point(115, 21);
            this.SerialPortNameComboBox.Name = "SerialPortNameComboBox";
            this.SerialPortNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.SerialPortNameComboBox.TabIndex = 14;
            // 
            // DisconnectFromSerialBtn
            // 
            this.DisconnectFromSerialBtn.Location = new System.Drawing.Point(16, 48);
            this.DisconnectFromSerialBtn.Name = "DisconnectFromSerialBtn";
            this.DisconnectFromSerialBtn.Size = new System.Drawing.Size(75, 23);
            this.DisconnectFromSerialBtn.TabIndex = 15;
            this.DisconnectFromSerialBtn.Text = "Disconnect";
            this.DisconnectFromSerialBtn.UseVisualStyleBackColor = true;
            this.DisconnectFromSerialBtn.Click += new System.EventHandler(this.DisconnectFromSerialBtn_Click);
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "115200",
            "230400"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(115, 50);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.BaudRateComboBox.TabIndex = 16;
            // 
            // SerialCommunicationGroupBox
            // 
            this.SerialCommunicationGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SerialCommunicationGroupBox.Controls.Add(this.receivedErrorTxtBox);
            this.SerialCommunicationGroupBox.Controls.Add(this.ConnectToSerialBtn);
            this.SerialCommunicationGroupBox.Controls.Add(this.DisconnectFromSerialBtn);
            this.SerialCommunicationGroupBox.Controls.Add(this.BaudRateComboBox);
            this.SerialCommunicationGroupBox.Controls.Add(this.SerialPortNameComboBox);
            this.SerialCommunicationGroupBox.ForeColor = System.Drawing.Color.Gray;
            this.SerialCommunicationGroupBox.Location = new System.Drawing.Point(1102, 35);
            this.SerialCommunicationGroupBox.Name = "SerialCommunicationGroupBox";
            this.SerialCommunicationGroupBox.Size = new System.Drawing.Size(249, 152);
            this.SerialCommunicationGroupBox.TabIndex = 17;
            this.SerialCommunicationGroupBox.TabStop = false;
            this.SerialCommunicationGroupBox.Text = "Serial Communication";
            // 
            // receivedErrorTxtBox
            // 
            this.receivedErrorTxtBox.Location = new System.Drawing.Point(16, 79);
            this.receivedErrorTxtBox.Multiline = true;
            this.receivedErrorTxtBox.Name = "receivedErrorTxtBox";
            this.receivedErrorTxtBox.ReadOnly = true;
            this.receivedErrorTxtBox.Size = new System.Drawing.Size(220, 67);
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
            this.ProgessPercentegeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProgessPercentegeLabel.Location = new System.Drawing.Point(69, 695);
            this.ProgessPercentegeLabel.Name = "ProgessPercentegeLabel";
            this.ProgessPercentegeLabel.Size = new System.Drawing.Size(24, 13);
            this.ProgessPercentegeLabel.TabIndex = 18;
            this.ProgessPercentegeLabel.Text = "Idle";
            // 
            // OneLineBtn
            // 
            this.OneLineBtn.Location = new System.Drawing.Point(751, 558);
            this.OneLineBtn.Name = "OneLineBtn";
            this.OneLineBtn.Size = new System.Drawing.Size(73, 23);
            this.OneLineBtn.TabIndex = 19;
            this.OneLineBtn.Text = "Go";
            this.OneLineBtn.UseVisualStyleBackColor = true;
            this.OneLineBtn.Click += new System.EventHandler(this.OneLineBtn_Click);
            // 
            // OneLineTxtBox
            // 
            this.OneLineTxtBox.Location = new System.Drawing.Point(497, 560);
            this.OneLineTxtBox.Name = "OneLineTxtBox";
            this.OneLineTxtBox.Size = new System.Drawing.Size(248, 20);
            this.OneLineTxtBox.TabIndex = 20;
            // 
            // gCodeListBox
            // 
            this.gCodeListBox.BackColor = System.Drawing.Color.Gray;
            this.gCodeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gCodeListBox.FormattingEnabled = true;
            this.gCodeListBox.ItemHeight = 31;
            this.gCodeListBox.Location = new System.Drawing.Point(15, 51);
            this.gCodeListBox.Name = "gCodeListBox";
            this.gCodeListBox.ScrollAlwaysVisible = true;
            this.gCodeListBox.Size = new System.Drawing.Size(475, 624);
            this.gCodeListBox.TabIndex = 21;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropDown,
            this.configToolBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1363, 25);
            this.toolStrip.TabIndex = 22;
            this.toolStrip.Text = "toolStrip";
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
            this.toolStripMenuItem1});
            this.configToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("configToolBtn.Image")));
            this.configToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.configToolBtn.Name = "configToolBtn";
            this.configToolBtn.Size = new System.Drawing.Size(56, 22);
            this.configToolBtn.Text = "Config";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem1.Text = "GRBL";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // xSetTo0Btn
            // 
            this.xSetTo0Btn.Location = new System.Drawing.Point(497, 66);
            this.xSetTo0Btn.Name = "xSetTo0Btn";
            this.xSetTo0Btn.Size = new System.Drawing.Size(73, 23);
            this.xSetTo0Btn.TabIndex = 23;
            this.xSetTo0Btn.Text = "Set to 0";
            this.xSetTo0Btn.UseVisualStyleBackColor = true;
            // 
            // ySetTo0Btn
            // 
            this.ySetTo0Btn.Location = new System.Drawing.Point(497, 134);
            this.ySetTo0Btn.Name = "ySetTo0Btn";
            this.ySetTo0Btn.Size = new System.Drawing.Size(73, 23);
            this.ySetTo0Btn.TabIndex = 24;
            this.ySetTo0Btn.Text = "Set to 0";
            this.ySetTo0Btn.UseVisualStyleBackColor = true;
            // 
            // zSetTo0Btn
            // 
            this.zSetTo0Btn.Location = new System.Drawing.Point(497, 210);
            this.zSetTo0Btn.Name = "zSetTo0Btn";
            this.zSetTo0Btn.Size = new System.Drawing.Size(73, 23);
            this.zSetTo0Btn.TabIndex = 25;
            this.zSetTo0Btn.Text = "Set to 0";
            this.zSetTo0Btn.UseVisualStyleBackColor = true;
            // 
            // xGoTo0Btn
            // 
            this.xGoTo0Btn.Location = new System.Drawing.Point(497, 92);
            this.xGoTo0Btn.Name = "xGoTo0Btn";
            this.xGoTo0Btn.Size = new System.Drawing.Size(73, 23);
            this.xGoTo0Btn.TabIndex = 26;
            this.xGoTo0Btn.Text = "Go to 0";
            this.xGoTo0Btn.UseVisualStyleBackColor = true;
            // 
            // yGoTo0Btn
            // 
            this.yGoTo0Btn.Location = new System.Drawing.Point(497, 160);
            this.yGoTo0Btn.Name = "yGoTo0Btn";
            this.yGoTo0Btn.Size = new System.Drawing.Size(73, 23);
            this.yGoTo0Btn.TabIndex = 27;
            this.yGoTo0Btn.Text = "Go to 0";
            this.yGoTo0Btn.UseVisualStyleBackColor = true;
            // 
            // zGoTo0Btn
            // 
            this.zGoTo0Btn.Location = new System.Drawing.Point(497, 236);
            this.zGoTo0Btn.Name = "zGoTo0Btn";
            this.zGoTo0Btn.Size = new System.Drawing.Size(73, 23);
            this.zGoTo0Btn.TabIndex = 28;
            this.zGoTo0Btn.Text = "Go to 0";
            this.zGoTo0Btn.UseVisualStyleBackColor = true;
            // 
            // YouCNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1363, 738);
            this.Controls.Add(this.zGoTo0Btn);
            this.Controls.Add(this.yGoTo0Btn);
            this.Controls.Add(this.xGoTo0Btn);
            this.Controls.Add(this.zSetTo0Btn);
            this.Controls.Add(this.ySetTo0Btn);
            this.Controls.Add(this.xSetTo0Btn);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.gCodeListBox);
            this.Controls.Add(this.OneLineTxtBox);
            this.Controls.Add(this.OneLineBtn);
            this.Controls.Add(this.ProgessPercentegeLabel);
            this.Controls.Add(this.SerialCommunicationGroupBox);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.zAxisLabel);
            this.Controls.Add(this.yAxisLabel);
            this.Controls.Add(this.xAxisLabel);
            this.Controls.Add(this.zAxisTxtBox);
            this.Controls.Add(this.yAxisTxtBox);
            this.Controls.Add(this.xAxisTxtBox);
            this.Controls.Add(this.ProgressBarLabel);
            this.Controls.Add(this.GCodeProgressBar);
            this.Controls.Add(this.GCodeLabel);
            this.Name = "YouCNC";
            this.Text = "YouCNC";
            this.SerialCommunicationGroupBox.ResumeLayout(false);
            this.SerialCommunicationGroupBox.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GCodeLabel;
        private System.Windows.Forms.ProgressBar GCodeProgressBar;
        private System.Windows.Forms.Label ProgressBarLabel;
        private System.Windows.Forms.TextBox xAxisTxtBox;
        private System.Windows.Forms.TextBox yAxisTxtBox;
        private System.Windows.Forms.TextBox zAxisTxtBox;
        private System.Windows.Forms.Label xAxisLabel;
        private System.Windows.Forms.Label yAxisLabel;
        private System.Windows.Forms.Label zAxisLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ConnectToSerialBtn;
        private System.Windows.Forms.ComboBox SerialPortNameComboBox;
        private System.Windows.Forms.Button DisconnectFromSerialBtn;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.GroupBox SerialCommunicationGroupBox;
        private System.Windows.Forms.TextBox receivedErrorTxtBox;
        private System.ComponentModel.BackgroundWorker RunMakingProcessWorker;
        private System.Windows.Forms.Label ProgessPercentegeLabel;
        private System.Windows.Forms.Button OneLineBtn;
        private System.Windows.Forms.TextBox OneLineTxtBox;
        private System.Windows.Forms.ListBox gCodeListBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton fileDropDown;
        private System.Windows.Forms.ToolStripMenuItem openFileBtn;
        private System.Windows.Forms.ToolStripDropDownButton configToolBtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button xSetTo0Btn;
        private System.Windows.Forms.Button ySetTo0Btn;
        private System.Windows.Forms.Button zSetTo0Btn;
        private System.Windows.Forms.Button xGoTo0Btn;
        private System.Windows.Forms.Button yGoTo0Btn;
        private System.Windows.Forms.Button zGoTo0Btn;
    }
}
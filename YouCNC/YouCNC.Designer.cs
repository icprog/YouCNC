﻿namespace YouCNC
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
            this.GCodeListBox = new System.Windows.Forms.ListBox();
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
            this.SuspendLayout();
            // 
            // GCodeListBox
            // 
            this.GCodeListBox.FormattingEnabled = true;
            this.GCodeListBox.Location = new System.Drawing.Point(12, 25);
            this.GCodeListBox.Name = "GCodeListBox";
            this.GCodeListBox.Size = new System.Drawing.Size(478, 667);
            this.GCodeListBox.TabIndex = 0;
            // 
            // GCodeLabel
            // 
            this.GCodeLabel.AutoSize = true;
            this.GCodeLabel.Location = new System.Drawing.Point(12, 9);
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
            this.ProgressBarLabel.Location = new System.Drawing.Point(12, 695);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(48, 13);
            this.ProgressBarLabel.TabIndex = 3;
            this.ProgressBarLabel.Text = "Progress";
            // 
            // xAxisTxtBox
            // 
            this.xAxisTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAxisTxtBox.Location = new System.Drawing.Point(566, 55);
            this.xAxisTxtBox.Multiline = true;
            this.xAxisTxtBox.Name = "xAxisTxtBox";
            this.xAxisTxtBox.Size = new System.Drawing.Size(249, 49);
            this.xAxisTxtBox.TabIndex = 4;
            this.xAxisTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yAxisTxtBox
            // 
            this.yAxisTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxisTxtBox.Location = new System.Drawing.Point(566, 134);
            this.yAxisTxtBox.Multiline = true;
            this.yAxisTxtBox.Name = "yAxisTxtBox";
            this.yAxisTxtBox.Size = new System.Drawing.Size(249, 49);
            this.yAxisTxtBox.TabIndex = 5;
            this.yAxisTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zAxisTxtBox
            // 
            this.zAxisTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zAxisTxtBox.Location = new System.Drawing.Point(566, 210);
            this.zAxisTxtBox.Multiline = true;
            this.zAxisTxtBox.Name = "zAxisTxtBox";
            this.zAxisTxtBox.Size = new System.Drawing.Size(249, 49);
            this.zAxisTxtBox.TabIndex = 6;
            this.zAxisTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xAxisLabel
            // 
            this.xAxisLabel.AutoSize = true;
            this.xAxisLabel.Location = new System.Drawing.Point(566, 36);
            this.xAxisLabel.Name = "xAxisLabel";
            this.xAxisLabel.Size = new System.Drawing.Size(36, 13);
            this.xAxisLabel.TabIndex = 7;
            this.xAxisLabel.Text = "X Axis";
            // 
            // yAxisLabel
            // 
            this.yAxisLabel.AutoSize = true;
            this.yAxisLabel.Location = new System.Drawing.Point(566, 118);
            this.yAxisLabel.Name = "yAxisLabel";
            this.yAxisLabel.Size = new System.Drawing.Size(36, 13);
            this.yAxisLabel.TabIndex = 8;
            this.yAxisLabel.Text = "Y Axis";
            // 
            // zAxisLabel
            // 
            this.zAxisLabel.AutoSize = true;
            this.zAxisLabel.Location = new System.Drawing.Point(566, 194);
            this.zAxisLabel.Name = "zAxisLabel";
            this.zAxisLabel.Size = new System.Drawing.Size(36, 13);
            this.zAxisLabel.TabIndex = 9;
            this.zAxisLabel.Text = "Z Axis";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(497, 627);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(105, 65);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(608, 627);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(105, 65);
            this.StopButton.TabIndex = 11;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(719, 627);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(105, 65);
            this.PauseButton.TabIndex = 12;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // YouCNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 738);
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
            this.Controls.Add(this.GCodeListBox);
            this.Name = "YouCNC";
            this.Text = "YouCNC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GCodeListBox;
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
    }
}
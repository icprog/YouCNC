namespace YouCNC
{
    partial class View
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
            this.ViewStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ThemeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.changeStyleLabel = new MetroFramework.Controls.MetroLabel();
            this.changeThemeLabel = new MetroFramework.Controls.MetroLabel();
            this.LightThemeTile = new MetroFramework.Controls.MetroTile();
            this.DarkThemeTile = new MetroFramework.Controls.MetroTile();
            this.ApplyTile = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewStyleManager
            // 
            this.ViewStyleManager.Owner = this;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.ItemHeight = 23;
            this.ThemeComboBox.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Ping",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.ThemeComboBox.Location = new System.Drawing.Point(60, 212);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(121, 29);
            this.ThemeComboBox.TabIndex = 0;
            this.ThemeComboBox.UseSelectable = true;
            this.ThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeComboBox_SelectedIndexChanged);
            // 
            // changeStyleLabel
            // 
            this.changeStyleLabel.AutoSize = true;
            this.changeStyleLabel.Location = new System.Drawing.Point(60, 190);
            this.changeStyleLabel.Name = "changeStyleLabel";
            this.changeStyleLabel.Size = new System.Drawing.Size(85, 19);
            this.changeStyleLabel.TabIndex = 2;
            this.changeStyleLabel.Text = "Change Style";
            // 
            // changeThemeLabel
            // 
            this.changeThemeLabel.AutoSize = true;
            this.changeThemeLabel.Location = new System.Drawing.Point(60, 103);
            this.changeThemeLabel.Name = "changeThemeLabel";
            this.changeThemeLabel.Size = new System.Drawing.Size(98, 19);
            this.changeThemeLabel.TabIndex = 5;
            this.changeThemeLabel.Text = "Change Theme";
            // 
            // LightThemeTile
            // 
            this.LightThemeTile.ActiveControl = null;
            this.LightThemeTile.Location = new System.Drawing.Point(60, 125);
            this.LightThemeTile.Name = "LightThemeTile";
            this.LightThemeTile.Size = new System.Drawing.Size(114, 53);
            this.LightThemeTile.TabIndex = 6;
            this.LightThemeTile.Text = "Light";
            this.LightThemeTile.UseSelectable = true;
            this.LightThemeTile.Click += new System.EventHandler(this.LightThemeTile_Click);
            // 
            // DarkThemeTile
            // 
            this.DarkThemeTile.ActiveControl = null;
            this.DarkThemeTile.Location = new System.Drawing.Point(276, 125);
            this.DarkThemeTile.Name = "DarkThemeTile";
            this.DarkThemeTile.Size = new System.Drawing.Size(114, 53);
            this.DarkThemeTile.TabIndex = 7;
            this.DarkThemeTile.Text = "Dark";
            this.DarkThemeTile.UseSelectable = true;
            this.DarkThemeTile.Click += new System.EventHandler(this.DarkThemeTile_Click);
            // 
            // ApplyTile
            // 
            this.ApplyTile.ActiveControl = null;
            this.ApplyTile.Location = new System.Drawing.Point(276, 212);
            this.ApplyTile.Name = "ApplyTile";
            this.ApplyTile.Size = new System.Drawing.Size(114, 58);
            this.ApplyTile.TabIndex = 8;
            this.ApplyTile.Text = "Apply";
            this.ApplyTile.UseSelectable = true;
            this.ApplyTile.Click += new System.EventHandler(this.ApplyTile_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 408);
            this.Controls.Add(this.ApplyTile);
            this.Controls.Add(this.DarkThemeTile);
            this.Controls.Add(this.LightThemeTile);
            this.Controls.Add(this.changeThemeLabel);
            this.Controls.Add(this.changeStyleLabel);
            this.Controls.Add(this.ThemeComboBox);
            this.Name = "View";
            this.Text = "View";
            ((System.ComponentModel.ISupportInitialize)(this.ViewStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager ViewStyleManager;
        private MetroFramework.Controls.MetroComboBox ThemeComboBox;
        private MetroFramework.Controls.MetroLabel changeStyleLabel;
        private MetroFramework.Controls.MetroLabel changeThemeLabel;
        private MetroFramework.Controls.MetroTile LightThemeTile;
        private MetroFramework.Controls.MetroTile DarkThemeTile;
        private MetroFramework.Controls.MetroTile ApplyTile;
    }
}
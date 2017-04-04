using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouCNC.Words;

namespace YouCNC
{
    public partial class View : MetroFramework.Forms.MetroForm
    {
        StyleData styleData = new StyleData();
        
        public View()
        {
            InitializeComponent();
            this.StyleManager = ViewStyleManager;
            styleData.Theme = "Light";
            styleData.Style = 0;
            styleData.applyed = false;
        }
        private void LightThemeTile_Click(object sender, EventArgs e)
        {
            ViewStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            styleData.Theme = "Light";
        }
        private void DarkThemeTile_Click(object sender, EventArgs e)
        {
            ViewStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            styleData.Theme = "Dark";
        }
        private void ThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ThemeComboBox.Text)
             {
                case "Default":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Default;
                        styleData.Style = 0;
                        break;
                    }
                case "Black":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Black;
                        styleData.Style = 1;
                        break;
                    }

                case "White":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.White;
                        styleData.Style = 2;
                        break;
                    }
                case "Silver":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Silver;
                        styleData.Style = 3;
                        break;
                    }

                case "Blue":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Blue;
                        styleData.Style = 4;
                        break;
                    }
                case "Green":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Green;
                        styleData.Style = 5;
                        break;
                    }

                case "Lime":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Lime;
                        styleData.Style = 6;
                        break;
                    }
                case "Teal":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Teal;
                        styleData.Style = 7;
                        break;
                    }

                case "Orange":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
                        styleData.Style = 8;
                        break;
                    }
                case "Brown":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Brown;
                        styleData.Style = 9;
                        break;
                    }

                case "Pink":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Pink;
                        styleData.Style = 10;
                        break;
                    }
                case "Magenta":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Magenta;
                        styleData.Style = 11;
                        break;
                    }

                case "Purple":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Purple;
                        styleData.Style = 12;
                        break;
                    }
                case "Red":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Red;
                        styleData.Style = 13;
                        break;
                    }

                case "Yellow":
                    {
                        ViewStyleManager.Style = MetroFramework.MetroColorStyle.Yellow;
                        styleData.Style = 14;
                        break;
                    }
            }
        }
        public StyleData GetStyleData
        {
            get { return styleData; }
        }
        private void ApplyTile_Click(object sender, EventArgs e)
        {
            styleData.applyed = true;
            this.Close();   
        }
    }
}

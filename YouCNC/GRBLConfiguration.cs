using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouCNC.Service;
using YouCNC.Service.Interfaces;
using YouCNC.Words;

namespace YouCNC
{
    public partial class GRBLConfiguration : MetroFramework.Forms.MetroForm
    {
        public GRBLConfiguration()
        {
            InitializeComponent();
            DefaultConfiguration();
        }

        void DefaultConfiguration()
        {
            xAxisStepMM.Text = "400.000";
            yAxisStepMM.Text = "400.000";
            zAxisStepMM.Text = "400.000";
            xMaxRate.Text = "800.000";
            yMaxRate.Text = "800.000";
            zMaxRate.Text = "800.000";
            xAccel.Text = "10.000";
            yAccel.Text = "10.000";
            zAccel.Text = "10.000";
            xMaxTravel.Text = "200.000";
            yMaxTravel.Text = "200.000";
            zMaxTravel.Text = "200.000";
            homingPullOff.Text = "1.000";
            homingDebounce.Text = "30";
            homingSeek.Text = "1.000";
            homingFeed.Text = "10.000";
            arcTolerance.Text = "0.002";
            stepIdleDelay.Text = "5";
            stepPulseuSec.Text = "10";
            stepEnableInvertToggle.Checked = true;
            limitPinsInvertToggle.Checked = true;
        }

        // DO NOTHING
        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void stepEnableInvertToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (stepEnableInvertToggle.Checked)
            {
               
            }
            else if (!stepEnableInvertToggle.Checked)
            {
               
            }
        }
    }
}

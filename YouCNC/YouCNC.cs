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
using YouCNC.Serial;
using YouCNC.Serial.Interfaces;
using YouCNC.Service;
using YouCNC.Service.Interfaces;

namespace YouCNC
{
    public partial class YouCNC : Form
    {
        private ISerialMessager _messager = DIContainer.GetServiceInstance();
        public YouCNC()
        {
            InitializeComponent();
            xAxisTxtBox.Text = "0.0000";
            yAxisTxtBox.Text = "0.0000";
            zAxisTxtBox.Text = "0.0000";
            positionRequestThread = new Thread(PositionDemand);
        }

        void PositionDemand()
        {
            //call apropriate method
        }
        Thread positionRequestThread;
        private void StartButton_Click(object sender, EventArgs e)
        {
            //make sure that port is opened
            positionRequestThread.Start();
        }
    }
}

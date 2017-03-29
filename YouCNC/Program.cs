using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouCNC.Config;
using YouCNC.Messages.Config;
using YouCNC.Serial.Interfaces;
using YouCNC.Service.Interfaces;

namespace YouCNC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AutomapperConfig config = new AutomapperConfig();
            config.CreateMappings();
            Application.Run(new YouCNC());
        }
    }
}

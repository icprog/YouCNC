using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouCNC.Serial.Config
{
    public static class DIContainer
    {
        private static SerialManager serial = null;
        public static SerialManager GetSerialManagerInstance()
        {      
            if (serial == null)
            {
                return new SerialManager();
            }
            return serial;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouCNC.Serial.Config
{
    public static class DIContainer
    {
        public static SerialManager GetSerialManagerInstance()
        {
            SerialManager serial = null;
            if (serial == null)
            {
                return new SerialManager();
            }
            return serial;
        }
    }
}

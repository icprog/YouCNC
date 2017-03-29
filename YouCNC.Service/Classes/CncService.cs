using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouCNC.Serial;
using YouCNC.Serial.Config;
using YouCNC.Serial.Interfaces;
using YouCNC.Service.Interfaces;

namespace YouCNC.Service
{
    public class CncService : ICncService
    {
       ISerialManager _serial = DIContainer.GetSerialManagerInstance();
       public void PositionsRequest()
        {
            _serial.SendPositionsRequest();
        }

        public void SendMessage(string message)
        {
            _serial.SendMessage(message);
        }

        public string[] GetPortNames()
        {
            return _serial.GetPortNames();
        }

        bool ICncService.OpenPort(string portname, int baudrate)
        {
            return _serial.OpenSerialPort(portname,baudrate);
        }

        bool ICncService.ClosePort()
        {
            return _serial.CloseSerialPort();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouCNC.Serial.Interfaces
{
    public interface ISerialManager
    {
        void SendPositionsRequest();
        void SendMessage(string message);
        bool OpenSerialPort(string portname, int baudrate);
        bool CloseSerialPort();
        string[] GetPortNames();
    }
}

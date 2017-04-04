using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouCNC.Serial.Interfaces
{
    public interface ISerialManager
    {
        void SendPositionsRequest(SerialPort serialPort);
        void SendMessage(SerialPort serialPort, string message);
        bool OpenSerialPort(SerialPort serialPort);
        bool CloseSerialPort(SerialPort serialPort);
        string[] GetPortNames();
    }
}

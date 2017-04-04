using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouCNC.Words;

namespace YouCNC.Service.Interfaces
{
    public interface ICncService
    {
        void SendMessage(SerialPort serialPort, string message);
        void PositionsRequest(SerialPort serialPort);
        string[] GetPortNames();
        bool OpenPort(SerialPort serialPort);
        bool ClosePort(SerialPort serialPort);
        PositionData GetPositionData(string positions);
        string MessageInterpreter(string data);
    }

}

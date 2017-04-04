using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouCNC.Messages;
using YouCNC.Serial;
using YouCNC.Serial.Config;
using YouCNC.Serial.Interfaces;
using YouCNC.Service.Interfaces;
using YouCNC.Words;

namespace YouCNC.Service
{
    public class CncService : ICncService
    {
        ISerialManager _serial = DIContainer.GetSerialManagerInstance();
        IMessageInterpreter message = Messages.Config.DIContainer.GetMessageInterpreterInstance();
       public void PositionsRequest(SerialPort serialPort)
        {
            _serial.SendPositionsRequest(serialPort);
        }
        public void SendMessage(SerialPort serialPort, string message)
        {
            _serial.SendMessage(serialPort, message);
        }
        public string[] GetPortNames()
        {
            return _serial.GetPortNames();
        }
        bool ICncService.OpenPort(SerialPort serialPort)
        {
            return _serial.OpenSerialPort(serialPort);
        }
        bool ICncService.ClosePort(SerialPort serialPort)
        {
            return _serial.CloseSerialPort(serialPort);
        }
        public PositionData GetPositionData(string positions)
        {
            return message.ReturnPositions(positions);
        }
        public string MessageInterpreter(string data)
        {
           return message.ContentResolver(data);
        }
    }
}

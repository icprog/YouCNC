using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouCNC.Messages;
using YouCNC.Messages.Config;
using YouCNC.Serial.Interfaces;
using YouCNC.Words;

namespace YouCNC.Serial
{
    public class SerialManager : ISerialManager
    {
        SerialPort _serialPort;
        public bool OpenSerialPort(SerialPort serialPort)
        {
            try
            {
                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    this._serialPort = serialPort;
                    return serialPort.IsOpen;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CloseSerialPort(SerialPort serialPort)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    return !serialPort.IsOpen;
                }
                else if (!serialPort.IsOpen)
                {
                    return !serialPort.IsOpen;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }
        public void SendPositionsRequest(SerialPort serialPort)
        {
            if (serialPort.IsOpen)
            {
                SendMessage(serialPort, WordsContainer.GetPositions);
            }
        }
        MessageInterpreter interpreter = DIContainer.GetMessageInterpreterInstance();
        public void SendMessage(SerialPort serialPort, string message)
        {
            if (serialPort.IsOpen)
            {
                _serialPort.WriteLine(message);
            }
        }
    }
}

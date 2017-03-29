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
        SerialPort serialPort = new SerialPort();
        public bool OpenSerialPort(string portname, int baudrate)
        {
            try
            {
                serialPort.PortName = portname;
                serialPort.BaudRate = baudrate;
                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEvent);
                    return serialPort.IsOpen;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool CloseSerialPort()
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
        public void SendPositionsRequest()
        {
            SendMessage(WordsContainer.GetPositions);
        }
        IMessageInterpreter interpreter = DIContainer.GetMessageInterpreterInstance();
        public void DataReceivedEvent(object sender, SerialDataReceivedEventArgs e)
        {
            serialPort = (SerialPort)sender;
            string indata = serialPort.ReadExisting();
            interpreter.ContentResolver(indata);
            indata = null;
        }
        public void SendMessage(string message)
        {
            serialPort.WriteLine(message);
        }
    }
}

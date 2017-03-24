using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    return true;
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
                    return true;
                }
                else if (!serialPort.IsOpen)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public void SendPositionsRequest()
        {
            SendMessage(WordsContainer.GetPositions);
        }
        public static void DataReceivedEvent(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            string indata = port.ReadExisting();
        }

        public void SendMessage(string message)
        {
            serialPort.Write(message);
        }

    }
}

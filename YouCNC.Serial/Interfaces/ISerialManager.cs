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
    }
}

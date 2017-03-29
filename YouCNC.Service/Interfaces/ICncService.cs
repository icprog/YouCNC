﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouCNC.Service.Interfaces
{
    public interface ICncService
    {
        void SendMessage(string message);
        void PositionsRequest();
        string[] GetPortNames();
        bool OpenPort(string portname, int baudrate);
        bool ClosePort();
    }

}
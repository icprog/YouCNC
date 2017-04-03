using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouCNC.Words;
using System.Diagnostics;
using YouCNC.Messages.Config;
using YouCNC.Words.Config;

namespace YouCNC.Messages
{
    public class MessageInterpreter : IMessageInterpreter
    {
        PositionData receivedPositionData = CommonDataDIContainer.GetPositionDataInstance();
        IMessageFilter filter = DIContainer.GetMessageFilterInstance();

        public delegate void positionsreceivedeventhandler(object source, EventArgs args);
        public event positionsreceivedeventhandler PositionsReceived;

        private string receivedData;
        private List<string> positions = new List<string>();
        public void ContentResolver(string message)
        {
            receivedData = message;
            if (message.Contains("WPos"))
            {
                OnPositionsReceived();
            }
        }
        protected virtual void OnPositionsReceived()
        {
            if(PositionsReceived != null)
            {
                PositionsReceived(this, EventArgs.Empty);
            }
        }

        public List<String> ReturnPositions()
        {
            return positions;
        }

    }
}

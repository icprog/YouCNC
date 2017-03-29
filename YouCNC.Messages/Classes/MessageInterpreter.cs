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
        public delegate void PositionsReceivedEventHandler(object source, PositionData positions);
        public event PositionsReceivedEventHandler PositionsReceived;
        protected string receivedData;

        public void ContentResolver(string message)
        {
            receivedData = message;
            if (receivedData.Contains("WPos"))
            {
                OnPositionsReceived();
            }
        }
        public PositionData ReturnPositions()
        {
          return filter.GetPositions(receivedData);
        }

        protected virtual void OnPositionsReceived()
        {
            if (PositionsReceived != null)
            {
                PositionsReceived(this, ReturnPositions());
            }
        }
    }
}

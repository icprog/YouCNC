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
        protected string receivedData;
        public void ContentResolver(string message)
        {
            receivedData = message;
            if (receivedData.Contains("WPos"))
            {
                ReturnPositions();
            }
        }
        public PositionData ReturnPositions()
        {
          return filter.GetPositions(receivedData);
        }
    }
}

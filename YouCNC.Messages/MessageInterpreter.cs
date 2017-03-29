using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouCNC.Words;
using System.Diagnostics;

namespace YouCNC.Messages
{
    public class MessageInterpreter
    {
        PositionData receivedPositionData = new PositionData();
        MessageFilter filter = new MessageFilter();
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

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

       
        private List<string> positions = new List<string>();
        public string ContentResolver(string message)
        {
            if (message.Contains("WPos"))
            {
                return WordsContainer.ReceivedPositions;
            }
            if (message.Contains("Idle"))
            {
                return WordsContainer.IsIdle;
            }
            else if (message.Contains("error"))
            {
                return WordsContainer.Error;
            }
            return "";
        }
      
        public PositionData ReturnPositions(string positions)
        {
            return filter.GetPositions(positions);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouCNC.Messages.Config;
using YouCNC.Words;
using YouCNC.Words.Config;

namespace YouCNC.Messages
{
    public class MessageFilter : IMessageFilter
    {
        enum constants
        {
            NUMBER_SEVEN = 7,
            NUMBER_TWO = 2,
            NUMBER_ONE = 1,
            COLON = ':',
            ARROW_RIGHT = '>',
            ARROW_LEFT = '<',
            ZERO = 0,
            END_OF_MESSAGE = '\0',
            COMMA = ','
        };

        IPositionData receivedPositionData = CommonDataDIContainer.GetPositionDataInstance();
        public List<string> GetPositions(string receivedData)
        {
            if(!string.IsNullOrEmpty(receivedData))
            {
                try
                {
                    string cutMessage = receivedData.Substring(receivedData.IndexOf((char)constants.COLON) + (int)constants.NUMBER_ONE);
                    string[] positions = cutMessage.Split((char)constants.COMMA);
                    //receivedPositionData.limit = positions[3].Substring((int)constants.ZERO, positions[3].IndexOf((char)constants.ARROW_RIGHT)-(int)constants.NUMBER_ONE);
                    return positions.ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return null;
        }
    }
}


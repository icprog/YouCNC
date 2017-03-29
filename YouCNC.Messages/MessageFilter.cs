using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouCNC.Words;

namespace YouCNC.Messages
{
    public class MessageFilter
    {
        enum constants
        {
            NUMBER_ONE = 1,
            COLON = ':',
            ARROW_RIGHT = '>',
            ARROW_LEFT = '<',
            ZERO = 0,
            END_OF_MESSAGE = '\0'
        };
        PositionData receivedPositionData = new PositionData();
        public PositionData GetPositions(string receivedData)
        {
            if (receivedData != null)
            {
                int firstIndex = (int)constants.ZERO, secondIndex = (int)constants.ZERO;
                if (receivedData[0] == (char)constants.ARROW_LEFT)
                {
                    try
                    {
                        firstIndex = receivedData.IndexOf((char)constants.COLON);
                        secondIndex = receivedData.IndexOf((char)constants.ARROW_RIGHT);
                        string onlyPositions = (char)constants.ARROW_LEFT + receivedData.Substring(firstIndex + (int)constants.NUMBER_ONE, secondIndex - (firstIndex + (int)constants.NUMBER_ONE));
                        firstIndex = (int)constants.ZERO; secondIndex = (int)constants.ZERO;
                        string xPosition, yPosition, zPosition, pieceOfString;
                        firstIndex = receivedData.IndexOf((char)constants.COLON) + (int)constants.NUMBER_ONE;
                        secondIndex = receivedData.IndexOf((char)constants.ARROW_RIGHT);
                        pieceOfString = receivedData.Substring(firstIndex, (secondIndex + 1) - firstIndex);
                        firstIndex = (int)constants.ZERO;
                        secondIndex = pieceOfString.IndexOf(',');
                        xPosition = pieceOfString.Substring(firstIndex, secondIndex);
                        firstIndex = pieceOfString.IndexOf(',');
                        secondIndex = pieceOfString.IndexOf((char)constants.ARROW_RIGHT);
                        pieceOfString = pieceOfString.Substring((firstIndex + 1), ((secondIndex) - firstIndex));
                        firstIndex = (int)constants.ZERO;
                        secondIndex = pieceOfString.IndexOf(',');
                        yPosition = pieceOfString.Substring(firstIndex, secondIndex);
                        firstIndex = pieceOfString.IndexOf(',');
                        secondIndex = pieceOfString.IndexOf((char)constants.ARROW_RIGHT);
                        pieceOfString = pieceOfString.Substring((firstIndex + 1), ((secondIndex) - firstIndex));
                        firstIndex = (int)constants.ZERO;
                        secondIndex = pieceOfString.IndexOf((char)constants.ARROW_RIGHT);
                        zPosition = pieceOfString.Substring(firstIndex, secondIndex);
                        receivedPositionData.xPopsition = xPosition;
                        receivedPositionData.yPosition = yPosition;
                        receivedPositionData.zPosition = zPosition;
                        return receivedPositionData;
                    }
                    catch (Exception)
                    {

                    }
                }
                
            }
            return null;
    }
}
}

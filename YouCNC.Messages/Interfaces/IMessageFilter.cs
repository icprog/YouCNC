using System.Collections.Generic;
using YouCNC.Words;

namespace YouCNC.Messages
{
    public interface IMessageFilter
    {
        PositionData GetPositions(string receivedData);
    }
}
using System.Collections.Generic;
using YouCNC.Words;

namespace YouCNC.Messages
{
    public interface IMessageFilter
    {
        List<string> GetPositions(string receivedData);
    }
}
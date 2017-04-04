using System.Collections.Generic;
using YouCNC.Words;

namespace YouCNC.Messages
{
    public interface IMessageInterpreter
    {
        string ContentResolver(string message);
        PositionData ReturnPositions(string positions);
    }
}
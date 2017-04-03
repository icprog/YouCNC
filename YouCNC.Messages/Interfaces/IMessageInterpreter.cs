using System.Collections.Generic;
using YouCNC.Words;

namespace YouCNC.Messages
{
    public interface IMessageInterpreter
    {
        void ContentResolver(string message);
        List<string> ReturnPositions();
    }
}
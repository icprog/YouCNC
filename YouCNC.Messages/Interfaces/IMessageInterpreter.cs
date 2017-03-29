using YouCNC.Words;

namespace YouCNC.Messages
{
    public interface IMessageInterpreter
    {
        void ContentResolver(string message);
        PositionData ReturnPositions();
    }
}
namespace YouCNC.Words
{
    public interface IPositionData
    {
        string xPosition { get; set; }
        string yPosition { get; set; }
        string zPosition { get; set; }
        string limit { get; set; }
    }
}
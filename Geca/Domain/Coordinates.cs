namespace Geca.Domain;

public class Coordinates
{
    public Coordinates(int y, int x)
    {
        Y = y;
        X = x;
    }
    public int X { get; set; }
    public int Y { get; set; }
}
namespace Geca.Domain;

public class Entity 
{
    public Entity(int y, int x, string legend) 
    {
        Coordinates = new Coordinates(y, x);
        Legend = legend;
    }

    public Coordinates Coordinates { get; set; }
    public string Legend { get; set; }
}
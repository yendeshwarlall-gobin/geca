namespace Geca.Domain;

public class Row0 : Row
{
    private StartPosition StartPosition { get; set; }
    public Spice Spice { get; set; }
    public Obstacle Obstacle { get; set; }
    public Booster Booster { get; set; }

    //s**********$*********#*B******
    public Row0(int y = 0)
    {
        StartPosition = new StartPosition(y, 0);
        Spice = new Spice(y, 11);
        Obstacle = new Obstacle(y, 21);
        Booster = new Booster(y, 23);
        Entities[StartPosition.Coordinates.X] = StartPosition;
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Obstacle.Coordinates.X] = Obstacle;
        Entities[Booster.Coordinates.X] = Booster;
        AddLands(0);
    }
    
}
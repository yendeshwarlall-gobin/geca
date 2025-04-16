namespace Geca.Domain;

public class Row28 : Row
{
    //***$*******B*************#****

    public Row28()
    {
        Spice = new Spice(28, 3);
        Booster = new Booster(28, 11);
        Obstacle = new Obstacle(28, 25);
        Entities[Obstacle.Coordinates.X] = Obstacle;
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Booster.Coordinates.X] = Booster;
        AddLands(28);
    }
    
    public Spice Spice { get; set; }
    public Booster Booster { get; set; }
    public Obstacle Obstacle { get; set; }
}
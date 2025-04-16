namespace Geca.Domain;

public class Row20 : Row
{
    //*********#****$***************

    public Row20()
    {
        Obstacle = new Obstacle(20, 9);
        Spice = new Spice(20, 14);
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Obstacle.Coordinates.X] = Obstacle;
        AddLands(20);
    }
    
    public Obstacle Obstacle { get; set; }
    public Spice Spice { get; set; }
}
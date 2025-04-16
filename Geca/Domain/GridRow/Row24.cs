namespace Geca.Domain;

public class Row24 : Row
{
    //$$***#************************

    public Row24()
    {
        Spice = new Spice(24, 0);
        Spice2 = new Spice(24, 1);
        Obstacle = new Obstacle(24, 5);
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Spice2.Coordinates.X] = Spice2;
        Entities[Obstacle.Coordinates.X] = Obstacle;
        AddLands(24);
    }
    
    public Spice Spice { get; set; }
    public Spice Spice2 { get; set; }
    public Obstacle Obstacle { get; set; }
    
}
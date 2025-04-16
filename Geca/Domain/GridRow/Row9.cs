namespace Geca.Domain;

public class Row9 : Row
{
    //*#***$****************#*******

    public Row9()
    {
        Obstacle = new Obstacle(9, 1);
        Spice = new Spice(9, 5);
        Obstacle2 = new Obstacle(9, 22);
        Entities[Obstacle.Coordinates.X] = Obstacle;
        Entities[Obstacle2.Coordinates.X] = Obstacle2;
        Entities[Spice.Coordinates.X] = Spice;
        AddLands(9);
    }
    
    public Obstacle Obstacle { get; set; }
    public Spice Spice { get; set; }
    public Obstacle Obstacle2 { get; set; }
}
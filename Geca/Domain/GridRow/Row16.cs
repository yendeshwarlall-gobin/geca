namespace Geca.Domain;

public class Row16 : Row
{
    //**********************#*******
    public Row16()
    {
        Obstacle = new Obstacle(16, 22);
        Entities[Obstacle.Coordinates.X] = Obstacle;
        AddLands(16);
    }
    public Obstacle Obstacle { get; set; }
}
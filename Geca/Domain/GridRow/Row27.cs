namespace Geca.Domain;

public class Row27 : Row
{
    //************************#*****

    public Row27()
    {
        Obstacle = new Obstacle(27, 24);
        Entities[Obstacle.Coordinates.X] = Obstacle;
        AddLands(27);
    }
    
    public Obstacle Obstacle { get; set; }
}
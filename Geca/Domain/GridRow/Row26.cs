namespace Geca.Domain;

public class Row26 : Row
{
    //***#**************************

    public Row26()
    {
        Obstacle = new Obstacle(26, 3);
        Entities[Obstacle.Coordinates.X] = Obstacle;
        AddLands(26);
    }
    
    public Obstacle Obstacle { get; set; }
}
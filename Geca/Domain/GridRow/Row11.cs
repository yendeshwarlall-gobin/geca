namespace Geca.Domain;

public class Row11 : Row
{
    //*********************#********

    public Row11()
    {
        Obstacle = new Obstacle(11, 21);
        Entities[Obstacle.Coordinates.X] = Obstacle;
        AddLands(11);
    }
    public Obstacle Obstacle { get; set; }
}
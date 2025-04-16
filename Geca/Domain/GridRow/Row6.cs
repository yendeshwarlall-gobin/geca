namespace Geca.Domain;

public class Row6 : Row
{
    //***************#**************

    public Row6()
    {
        Obstacle = new Obstacle(6, 15);
        Entities[Obstacle.Coordinates.X] = Obstacle;
        AddLands(6);
    }
    
    public Obstacle Obstacle { get; set; }
}
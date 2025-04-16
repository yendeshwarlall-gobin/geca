namespace Geca.Domain;

public class Row1 : Row
{
    //**************#********B******
    public Row1()
    {
        Obstacle = new Obstacle(1, 14);
        Booster = new Booster(1, 23);
        Entities[Obstacle.Coordinates.X] = Obstacle;
        Entities[Booster.Coordinates.X] = Booster;
        AddLands(1);
    }
    public Obstacle Obstacle {get; set;}
    public Booster Booster {get; set;}
}
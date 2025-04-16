namespace Geca.Domain;

public class Row4: Row
{
    //****B****#******B*************

    public Row4()
    {
        Booster = new Booster(4, 4);
        Obstacle = new Obstacle(4, 9);
        Booster2 = new Booster(4, 16);
        Entities[Booster.Coordinates.X] = Booster;
        Entities[Booster2.Coordinates.X] = Booster2;
        Entities[Obstacle.Coordinates.X] = Obstacle;
        AddLands(4);
    }
    
    public Booster Booster { get; set; }
    public Obstacle Obstacle { get; set; }
    public Booster Booster2 { get; set; }
}
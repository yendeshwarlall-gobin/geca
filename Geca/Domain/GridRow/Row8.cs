namespace Geca.Domain;

public class Row8 : Row
{
    //****#****$****$********B******

    public Row8()
    {
        Obstacle = new Obstacle(8, 4);
        Spice = new Spice(8, 9);
        Spice2 = new Spice(8, 14);
        Booster = new Booster(8, 23);
        
        Entities[Obstacle.Coordinates.X] = Obstacle;
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Spice2.Coordinates.X] = Spice2;
        Entities[Booster.Coordinates.X] = Booster;
        AddLands(8);
        
    }
    
    public Obstacle Obstacle { get; set; }
    public Spice Spice { get; set; }
    public Spice Spice2 { get; set; }
    public Booster Booster { get; set; }
}
namespace Geca.Domain;

public class Row2 : Row
{
    //**********$*********#*$*******
    public Row2()
    {
        Spice1 = new Spice(2, 10);
        Obstacle = new Obstacle(2, 20);
        Spice2 = new Spice(3, 22);
        Entities[Spice1.Coordinates.X] = Spice1;
        Entities[Obstacle.Coordinates.X] = Obstacle;
        Entities[Spice2.Coordinates.X] = Spice2;
        AddLands(3);
    }
    
    public Spice Spice1 { get; set; }
    public Obstacle Obstacle { get; set; }
    public Spice Spice2 { get; set; }
    
    
}
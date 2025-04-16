namespace Geca.Domain;

public class Row22 : Row
{
    //**********$*********$*****#***

    public Row22()
    {
        Spice = new Spice(22, 10);
        Spice2 = new Spice(22, 20);
        Obstacle = new Obstacle(22, 26);
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Spice2.Coordinates.X] = Spice2;
        Entities[Obstacle.Coordinates.X] = Obstacle;
        AddLands(22);
    }
    
    public Spice Spice { get; set; }
    public Spice Spice2 { get; set; }
    public Obstacle Obstacle { get; set; }
}
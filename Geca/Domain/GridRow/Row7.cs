namespace Geca.Domain;

public class Row7 : Row
{
    //***#**$********************$**

    public Row7()
    {
        Obstacle = new Obstacle(7, 3);
        Spice = new Spice(7, 6);
        Spice2 = new Spice(7, 27);
        
        Entities[Obstacle.Coordinates.X] = Obstacle;
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Spice2.Coordinates.X] = Spice2;
        AddLands(7);
    }
    
    public Obstacle Obstacle { get; set; }
    public Spice Spice { get; set; }
    public Spice Spice2 { get; set; }
}
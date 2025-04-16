namespace Geca.Domain;

public class Row25 : Row
{
    //**$*************************#*

    public Row25()
    {
        Spice = new Spice(25, 2);
        Obstacle = new Obstacle(25, 28);
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Obstacle.Coordinates.X] = Obstacle;
        AddLands(25);
    }
    
    public Spice Spice { get; set; }
    public Obstacle Obstacle { get; set; }
}
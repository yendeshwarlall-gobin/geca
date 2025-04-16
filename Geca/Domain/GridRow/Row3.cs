namespace Geca.Domain;

public class Row3 : Row
{
    //***$***************$*****B****

    public Row3()
    {
        Spice1 = new Spice(3, 3);
        Spice2 = new Spice(3, 19);
        Booster = new Booster(3, 25);
        Entities[Spice1.Coordinates.X] = Spice1;
        Entities[Spice2.Coordinates.X] = Spice2;
        Entities[Booster.Coordinates.X] = Booster;
        AddLands(3);
    }
    
    public Spice Spice1 { get; set; }
    public Spice Spice2 { get; set; }
    public Booster Booster { get; set; }
}
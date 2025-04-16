namespace Geca.Domain;

public class Row21 : Row
{
    //********************$*******$*

    public Row21()
    {
        Spice = new Spice(21, 20);
        Spice2 = new Spice(21, 28);
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Spice2.Coordinates.X] = Spice2;
        AddLands(21);
    }
    
    public Spice Spice { get; set; }
    public Spice Spice2 { get; set; }
}
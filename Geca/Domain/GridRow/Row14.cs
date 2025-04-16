namespace Geca.Domain;

public class Row14 : Row
{
    //********$***$*****************

    public Row14()
    {
        Spice = new Spice(14, 8);
        Spice2 = new Spice(14, 12);
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Spice2.Coordinates.X] = Spice2;
        AddLands(14);
    }
    
    public Spice Spice { get; set; }
    public Spice Spice2 { get; set; }
}
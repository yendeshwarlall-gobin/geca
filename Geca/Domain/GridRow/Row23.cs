namespace Geca.Domain;

public class Row23 : Row
{
    //**************$***************

    public Row23()
    {
        Spice = new Spice(23, 14);
        Entities[Spice.Coordinates.X] = Spice;
        AddLands(23);
    }
    
    public Spice Spice { get; set; }
    
}
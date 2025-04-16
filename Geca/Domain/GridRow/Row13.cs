namespace Geca.Domain;

public class Row13 : Row
{
    //************$*****************

    public Row13()
    {
        Spice = new Spice(13, 12);
        Entities[Spice.Coordinates.X] = Spice;
        AddLands(13);
    }
    public Spice Spice { get; set; }
}
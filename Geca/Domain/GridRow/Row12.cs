namespace Geca.Domain;

public class Row12 : Row
{
    //*********$********************

    public Row12()
    {
        Spice = new Spice(12, 9);
        Entities[Spice.Coordinates.X] = Spice;
        AddLands(12);
    }
    public Spice Spice { get; set; }
}
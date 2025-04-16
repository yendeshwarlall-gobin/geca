namespace Geca.Domain;

public class Row10 : Row
{
    //*******$**********************
    public Row10()
    {
        Spice = new Spice(10,7);
        Entities[Spice.Coordinates.X] = Spice;
        AddLands(10);
    }
    
    public Spice Spice { get; set; }
}

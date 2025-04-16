namespace Geca.Domain;

public class Row5 : Row
{
    //***********$******************

    public Row5()
    {
        Spice = new Spice(5, 11);
        Entities[Spice.Coordinates.X] = Spice;
        AddLands(5);
    }
    
    public Spice Spice { get; set; }
    
}
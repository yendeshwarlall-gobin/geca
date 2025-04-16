namespace Geca.Domain;

public class Row29 : Row
{
    //$*********$**********$********

    public Row29()
    {
        Spice = new Spice(29, 0);
        Spice2 = new Spice(29, 10);
        Spice3 = new Spice(29, 21);
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Spice2.Coordinates.X] = Spice2;
        Entities[Spice3.Coordinates.X] = Spice3;
        AddLands(29);
    }
    
    public Spice Spice { get; set; }
    public Spice Spice2 { get; set; }
    public Spice Spice3 { get; set; }
}
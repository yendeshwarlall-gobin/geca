namespace Geca.Domain;

public class Row19 : Row
{
    //**B*********$*****************

    public Row19()
    {
        Booster = new Booster(19, 2);
        Spice = new Spice(19, 12);
        Entities[Booster.Coordinates.X] = Booster;
        Entities[Spice.Coordinates.X] = Spice;
        AddLands(19);
    }
    public Spice Spice { get; set; }
    public Booster Booster { get; set; }
}
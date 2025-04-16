namespace Geca.Domain;

public class Row15 : Row
{
    //***********************$***B**
    public Row15()
    {
        Spice = new Spice(15, 23);
        Booster = new Booster(15, 27);
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Booster.Coordinates.X] = Booster;
        AddLands(15);
    }
    public Spice Spice { get; set; }
    public Booster Booster { get; set; }
}
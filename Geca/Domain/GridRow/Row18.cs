namespace Geca.Domain;

public class Row18 : Row
{
    //*************$$****B**********

    public Row18()
    {
        Spice = new Spice(18, 13);
        Spice2 = new Spice(18, 14);
        Booster = new Booster(17, 19);
        Entities[Booster.Coordinates.X] = Booster;
        Entities[Spice.Coordinates.X] = Spice;
        Entities[Spice2.Coordinates.X] = Spice2;
        AddLands(18);
    }
    
    public Spice Spice { get; set; }
    public Spice Spice2 { get; set; }
    public Booster Booster { get; set; }
}
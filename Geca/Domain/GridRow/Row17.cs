namespace Geca.Domain;

public class Row17 : Row
{
    //****$************************B

    public Row17()
    {
        Spice = new Spice(17, 4);
        Booster = new Booster(17, 29);
        Entities[Booster.Coordinates.X] = Booster;
        Entities[Spice.Coordinates.X] = Spice;
        AddLands(17);
    }
    
    public Spice Spice { get; set; }
    public Booster Booster { get; set; }
}
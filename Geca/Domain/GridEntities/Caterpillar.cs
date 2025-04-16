namespace Geca.Domain;

public class Caterpillar
{
    public Caterpillar()
    {
        Head = new Head(0, 0);
        Tail = new Tail(0, 0);
        Segments = new List<IntermediateSegment>(3);
    }
    public Head Head { get; set; }
    public Tail Tail { get; set; }
    
    public List<IntermediateSegment> Segments { get; set; }
    
    //TODO: Need to cater for 3 segments
}
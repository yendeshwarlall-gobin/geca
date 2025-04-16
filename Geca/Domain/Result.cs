using Geca.Domain;
using Geca.Domain.Grids;

namespace Geca;

public class Result
{
    public Grid Grid { get; set; }
    public Caterpillar Caterpillar { get; set; }
    public StartPosition StartPosition { get; set; }
}
using Geca.Domain.Grids;

namespace Geca.Domain;

public class Request
{
    public string Command { get; set; }
    public Grid Grid { get; set; }
    public Caterpillar Caterpillar { get; set; }
    public StartPosition GridStartPosition { get; set; }
}
using Geca.Domain;
using Geca.Domain.Grids;

namespace Geca.Services;

public interface IRadarService
{
    Grid GetRadarGridFromCurrentGrid(Caterpillar caterpillar, Grid currentGrid);
}
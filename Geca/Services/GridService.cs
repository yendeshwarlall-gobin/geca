using Geca.Domain;
using Geca.Domain.Grids;

namespace Geca.Services;

public class GridService
{
    public (Grid, StartPosition) GetNextGrid(StartPosition startPosition, Direction direction)
    {
        var grid = new StartingGrid();
        if (direction == Direction.Up || direction == Direction.Down)
        {
            if (startPosition.Coordinates.X == 0 && startPosition.Coordinates.Y == 0)
            {
                grid.ReverseYAxis();
                return (grid, new StartPosition(29, 0));
            }

            if (startPosition.Coordinates.X == 0 && startPosition.Coordinates.Y == 29)
            {
                return (grid, new StartPosition(0, 0));
            }

            if (startPosition.Coordinates.X == 29 && startPosition.Coordinates.Y == 0)
            {
                grid.ReverseXAndYAxis();
                return (grid, new StartPosition(29, 29));
            }

            if (startPosition.Coordinates.X == 29 && startPosition.Coordinates.Y == 29)
            {
                grid.ReverseXAxis();
                return (grid, new StartPosition(0, 29));
            }
        }

        if (direction == Direction.Left|| direction == Direction.Right)
        {
            if (startPosition.Coordinates.X == 0 && startPosition.Coordinates.Y == 0)
            {
                grid.ReverseXAxis();
                return (grid, new StartPosition(0, 29));
            }

            if (startPosition.Coordinates.X == 0 && startPosition.Coordinates.Y == 29)
            {
                grid.ReverseXAndYAxis();
                return (grid, new StartPosition(29, 29));
            }

            if (startPosition.Coordinates.X == 29 && startPosition.Coordinates.Y == 0)
            {
                return (grid, new StartPosition(0, 0));
            }

            if (startPosition.Coordinates.X == 29 && startPosition.Coordinates.Y == 29)
            {
                grid.ReverseYAxis();
                return (grid, new StartPosition(29, 0));
            }

        }


        throw new ArgumentException("Invalid direction");
    }

}
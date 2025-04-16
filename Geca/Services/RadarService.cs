using Geca.Domain;
using Geca.Domain.Grids;

namespace Geca.Services;

public class RadarService : IRadarService
{
    private const int RadarRadius = 5;
//Todo remove un-used methods
    private string GetSurrounding(Caterpillar caterpillar, Grid currentGrid)
    {
        var caterpillarCoordinates = caterpillar.Head.Coordinates;

        if (IsRadarWithinGrid(caterpillarCoordinates))
        {

        }

        return string.Empty;
    }

    private bool IsRadarWithinGrid(Coordinates caterpillarCoordinates)
    {
        return caterpillarCoordinates.X + RadarRadius <= 29
               && caterpillarCoordinates.Y + RadarRadius <= 29
               && caterpillarCoordinates.X - RadarRadius <= 29
               && caterpillarCoordinates.Y - RadarRadius <= 29;
    }

    public Grid GetRadarGridFromCurrentGrid(Caterpillar caterpillar, Grid currentGrid)
    {
        var upperY = caterpillar.Head.Coordinates.Y + RadarRadius;
        var lowerY = caterpillar.Head.Coordinates.Y - RadarRadius;
        var leftX = caterpillar.Head.Coordinates.X - RadarRadius;
        var rightX = caterpillar.Head.Coordinates.X + RadarRadius;

        upperY = upperY > 29 ? 29 : upperY;
        lowerY = lowerY < 0 ? 0 : lowerY;
        leftX = leftX < 0 ? 0 : leftX;
        rightX = rightX > 29 ? 29 : rightX;

        var lengthXAxis = (rightX - leftX) + 1;
        var lengthYAxis = (upperY - lowerY) + 1;

        var radarGrid = new Grid(lengthYAxis);
        var radarGridY = 0;
        for (int y = lowerY; y <= upperY; y++)
        {
            var currentRow = currentGrid.Rows[y];
            var newRow = new Row(lengthXAxis);
            var radarGridX = 0;
            for (int x = leftX; x <= rightX; x++)
            {
                newRow.Entities[radarGridX] = currentRow.Entities[x];
     
                if (caterpillar.Tail.Coordinates.X == x && caterpillar.Tail.Coordinates.Y == y &&
                    caterpillar.Head.Coordinates != caterpillar.Tail.Coordinates)
                {
                    newRow.Entities[radarGridX] = caterpillar.Tail;
                }
                
                if (caterpillar.Head.Coordinates.X == x && caterpillar.Head.Coordinates.Y == y)
                {
                    newRow.Entities[radarGridX] = caterpillar.Head;
                }

                radarGridX++;
            }

            radarGrid.AddRow(newRow, radarGridY);
            radarGridY++;
        }

        return radarGrid;
    }
}
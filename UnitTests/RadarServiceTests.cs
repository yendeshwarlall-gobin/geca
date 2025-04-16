using Geca.Domain;
using Geca.Domain.Grids;
using Geca.Services;
using Xunit;

namespace UnitTests;

public class RadarServiceTests
{
    private RadarService _radarService;
    
    public RadarServiceTests()
    {
        _radarService = new RadarService();
    }

    //Need to check the result in the debug console
    [Fact]
    public void GetRadar_FromCurrentGrid_Works_As_Expected()
    {
        //Arrange
        var carterpillar = new Caterpillar
        {
            Head = new Head(5,5), Tail = new Tail(0,0)
        };

        var grid = new StartingGrid();
        grid.Rows[0].Entities[0] = carterpillar.Tail;
        grid.Rows[5].Entities[5] = carterpillar.Head;
        //Act
        
        var result = _radarService.GetRadarGridFromCurrentGrid(carterpillar, grid);
        //Assert
        result.PrintGrid();
    }
}
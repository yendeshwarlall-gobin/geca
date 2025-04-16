using Geca.Domain.Grids;
using Xunit;
using Xunit.Abstractions;

namespace UnitTests;

public class TestGrids
{
    private readonly ITestOutputHelper _testOutputHelper;

    public TestGrids(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    private const string Row29 = "$*********$**********$********";
    private const string Row28 = "***$*******B*************#****";
    private const string Row27 = "************************#*****";
    private const string Row26 = "***#**************************";
    private const string Row25 = "**$*************************#*";
    private const string Row24 = "$$***#************************";
    private const string Row23 = "**************$***************";
    private const string Row22 = "**********$*********$*****#***";
    private const string Row21 = "********************$*******$*";
    private const string Row20 = "*********#****$***************";
    private const string Row19 = "**B*********$*****************";
    private const string Row18 = "*************$$****B**********";
    private const string Row17 = "****$************************B";
    private const string Row16 = "**********************#*******";
    private const string Row15 = "***********************$***B**";
    private const string Row14 = "********$***$*****************";
    private const string Row13 = "************$*****************";
    private const string Row12 = "*********$********************";
    private const string Row11 = "*********************#********";
    private const string Row10 = "*******$**********************";
    private const string Row9 = "*#***$****************#*******";
    private const string Row8 = "****#****$****$********B******";
    private const string Row7 = "***#**$********************$**";
    private const string Row6 = "***************#**************";
    private const string Row5 = "***********$******************";
    private const string Row4 = "****B****#******B*************";
    private const string Row3 = "***$***************$*****B****";
    private const string Row2 = "**********$*********#*$*******";
    private const string Row1 = "**************#********B******";
    private const string Row0 = "s**********$*********#*B******";

    [Fact]
    public void Starting_Grid_Should_Be_As_Expected()
    {
        //Arrange
        //Act
        var grid = new StartingGrid();
        Console.WriteLine("Starting_Grid_Should_Be_As_Expected");
        WriteGridToConsole(grid);
        //Assert
        Assert.NotNull(grid);
        Assert.Equal(Row0, grid.Rows[0].GetRowRepresentation());
        Assert.Equal(Row1, grid.Rows[1].GetRowRepresentation());
        Assert.Equal(Row2, grid.Rows[2].GetRowRepresentation());
        Assert.Equal(Row3, grid.Rows[3].GetRowRepresentation());
        Assert.Equal(Row4, grid.Rows[4].GetRowRepresentation());
        Assert.Equal(Row5, grid.Rows[5].GetRowRepresentation());
        Assert.Equal(Row6, grid.Rows[6].GetRowRepresentation());
        Assert.Equal(Row7, grid.Rows[7].GetRowRepresentation());
        Assert.Equal(Row8, grid.Rows[8].GetRowRepresentation());
        Assert.Equal(Row9, grid.Rows[9].GetRowRepresentation());
        Assert.Equal(Row10, grid.Rows[10].GetRowRepresentation());
        Assert.Equal(Row11, grid.Rows[11].GetRowRepresentation());
        Assert.Equal(Row12, grid.Rows[12].GetRowRepresentation());
        Assert.Equal(Row13, grid.Rows[13].GetRowRepresentation());
        Assert.Equal(Row14, grid.Rows[14].GetRowRepresentation());
        Assert.Equal(Row15, grid.Rows[15].GetRowRepresentation());
        Assert.Equal(Row16, grid.Rows[16].GetRowRepresentation());
        Assert.Equal(Row17, grid.Rows[17].GetRowRepresentation());
        Assert.Equal(Row18, grid.Rows[18].GetRowRepresentation());
        Assert.Equal(Row19, grid.Rows[19].GetRowRepresentation());
        Assert.Equal(Row20, grid.Rows[20].GetRowRepresentation());
        Assert.Equal(Row21, grid.Rows[21].GetRowRepresentation());
        Assert.Equal(Row22, grid.Rows[22].GetRowRepresentation());
        Assert.Equal(Row23, grid.Rows[23].GetRowRepresentation());
        Assert.Equal(Row24, grid.Rows[24].GetRowRepresentation());
        Assert.Equal(Row25, grid.Rows[25].GetRowRepresentation());
        Assert.Equal(Row26, grid.Rows[26].GetRowRepresentation());
        Assert.Equal(Row27, grid.Rows[27].GetRowRepresentation());
        Assert.Equal(Row28, grid.Rows[28].GetRowRepresentation());
        Assert.Equal(Row29, grid.Rows[29].GetRowRepresentation());
    }
    
    [Fact]
    public void Grid_Reverse_Y_Axis_Should_Be_As_Expected()
    {
        //Arrange
        var grid = new StartingGrid(); 
        //Act
        grid.ReverseYAxis();
        Console.WriteLine("Grid_Reverse_Y_Axis_Should_Be_As_Expected");
        WriteGridToConsole(grid);
        //Assert
        Assert.NotNull(grid);
        Assert.Equal(Row29, grid.Rows[0].GetRowRepresentation());
        Assert.Equal(Row28, grid.Rows[1].GetRowRepresentation());
        Assert.Equal(Row27, grid.Rows[2].GetRowRepresentation());
        Assert.Equal(Row26, grid.Rows[3].GetRowRepresentation());
        Assert.Equal(Row25, grid.Rows[4].GetRowRepresentation());
        Assert.Equal(Row24, grid.Rows[5].GetRowRepresentation());
        Assert.Equal(Row23, grid.Rows[6].GetRowRepresentation());
        Assert.Equal(Row22, grid.Rows[7].GetRowRepresentation());
        Assert.Equal(Row21, grid.Rows[8].GetRowRepresentation());
        Assert.Equal(Row20, grid.Rows[9].GetRowRepresentation());
        Assert.Equal(Row19, grid.Rows[10].GetRowRepresentation());
        Assert.Equal(Row18, grid.Rows[11].GetRowRepresentation());
        Assert.Equal(Row17, grid.Rows[12].GetRowRepresentation());
        Assert.Equal(Row16, grid.Rows[13].GetRowRepresentation());
        Assert.Equal(Row15, grid.Rows[14].GetRowRepresentation());
        Assert.Equal(Row14, grid.Rows[15].GetRowRepresentation());
        Assert.Equal(Row13, grid.Rows[16].GetRowRepresentation());
        Assert.Equal(Row12, grid.Rows[17].GetRowRepresentation());
        Assert.Equal(Row11, grid.Rows[18].GetRowRepresentation());
        Assert.Equal(Row10, grid.Rows[19].GetRowRepresentation());
        Assert.Equal(Row9, grid.Rows[20].GetRowRepresentation());
        Assert.Equal(Row8, grid.Rows[21].GetRowRepresentation());
        Assert.Equal(Row7, grid.Rows[22].GetRowRepresentation());
        Assert.Equal(Row6, grid.Rows[23].GetRowRepresentation());
        Assert.Equal(Row5, grid.Rows[24].GetRowRepresentation());
        Assert.Equal(Row4, grid.Rows[25].GetRowRepresentation());
        Assert.Equal(Row3, grid.Rows[26].GetRowRepresentation());
        Assert.Equal(Row2, grid.Rows[27].GetRowRepresentation());
        Assert.Equal(Row1, grid.Rows[28].GetRowRepresentation());
        Assert.Equal(Row0, grid.Rows[29].GetRowRepresentation());
    }
    
    [Fact]
    public void Grid_Reverse_X_Axis_Should_Be_As_Expected()
    {
        //Arrange
        var grid = new StartingGrid();
        //Act
        grid.ReverseXAxis();
        Console.WriteLine("Grid_Reverse_X_Axis_Should_Be_As_Expected");
        WriteGridToConsole(grid);
        //Assert
        Assert.NotNull(grid);
        Assert.Equal(Row0.Reverse(), grid.Rows[0].GetRowRepresentation());
        Assert.Equal(Row1.Reverse(), grid.Rows[1].GetRowRepresentation());
        Assert.Equal(Row2.Reverse(), grid.Rows[2].GetRowRepresentation());
        Assert.Equal(Row3.Reverse(), grid.Rows[3].GetRowRepresentation());
        Assert.Equal(Row4.Reverse(), grid.Rows[4].GetRowRepresentation());
        Assert.Equal(Row5.Reverse(), grid.Rows[5].GetRowRepresentation());
        Assert.Equal(Row6.Reverse(), grid.Rows[6].GetRowRepresentation());
        Assert.Equal(Row7.Reverse(), grid.Rows[7].GetRowRepresentation());
        Assert.Equal(Row8.Reverse(), grid.Rows[8].GetRowRepresentation());
        Assert.Equal(Row9.Reverse(), grid.Rows[9].GetRowRepresentation());
        Assert.Equal(Row10.Reverse(), grid.Rows[10].GetRowRepresentation());
        Assert.Equal(Row11.Reverse(), grid.Rows[11].GetRowRepresentation());
        Assert.Equal(Row12.Reverse(), grid.Rows[12].GetRowRepresentation());
        Assert.Equal(Row13.Reverse(), grid.Rows[13].GetRowRepresentation());
        Assert.Equal(Row14.Reverse(), grid.Rows[14].GetRowRepresentation());
        Assert.Equal(Row15.Reverse(), grid.Rows[15].GetRowRepresentation());
        Assert.Equal(Row16.Reverse(), grid.Rows[16].GetRowRepresentation());
        Assert.Equal(Row17.Reverse(), grid.Rows[17].GetRowRepresentation());
        Assert.Equal(Row18.Reverse(), grid.Rows[18].GetRowRepresentation());
        Assert.Equal(Row19.Reverse(), grid.Rows[19].GetRowRepresentation());
        Assert.Equal(Row20.Reverse(), grid.Rows[20].GetRowRepresentation());
        Assert.Equal(Row21.Reverse(), grid.Rows[21].GetRowRepresentation());
        Assert.Equal(Row22.Reverse(), grid.Rows[22].GetRowRepresentation());
        Assert.Equal(Row23.Reverse(), grid.Rows[23].GetRowRepresentation());
        Assert.Equal(Row24.Reverse(), grid.Rows[24].GetRowRepresentation());
        Assert.Equal(Row25.Reverse(), grid.Rows[25].GetRowRepresentation());
        Assert.Equal(Row26.Reverse(), grid.Rows[26].GetRowRepresentation());
        Assert.Equal(Row27.Reverse(), grid.Rows[27].GetRowRepresentation());
        Assert.Equal(Row28.Reverse(), grid.Rows[28].GetRowRepresentation());
        Assert.Equal(Row29.Reverse(), grid.Rows[29].GetRowRepresentation());
    }
    
    [Fact]
    public void Grid_Reverse_XY_Axis_Should_Be_As_Expected()
    {
        //Arrange
        var grid = new StartingGrid(); 
        //Act
        grid.ReverseXAndYAxis();
        Console.WriteLine("Grid_Reverse_XY_Axis_Should_Be_As_Expected");
        WriteGridToConsole(grid);
        //Assert
        Assert.NotNull(grid);
        Assert.Equal(Row29.Reverse(), grid.Rows[0].GetRowRepresentation());
        Assert.Equal(Row28.Reverse(), grid.Rows[1].GetRowRepresentation());
        Assert.Equal(Row27.Reverse(), grid.Rows[2].GetRowRepresentation());
        Assert.Equal(Row26.Reverse(), grid.Rows[3].GetRowRepresentation());
        Assert.Equal(Row25.Reverse(), grid.Rows[4].GetRowRepresentation());
        Assert.Equal(Row24.Reverse(), grid.Rows[5].GetRowRepresentation());
        Assert.Equal(Row23.Reverse(), grid.Rows[6].GetRowRepresentation());
        Assert.Equal(Row22.Reverse(), grid.Rows[7].GetRowRepresentation());
        Assert.Equal(Row21.Reverse(), grid.Rows[8].GetRowRepresentation());
        Assert.Equal(Row20.Reverse(), grid.Rows[9].GetRowRepresentation());
        Assert.Equal(Row19.Reverse(), grid.Rows[10].GetRowRepresentation());
        Assert.Equal(Row18.Reverse(), grid.Rows[11].GetRowRepresentation());
        Assert.Equal(Row17.Reverse(), grid.Rows[12].GetRowRepresentation());
        Assert.Equal(Row16.Reverse(), grid.Rows[13].GetRowRepresentation());
        Assert.Equal(Row15.Reverse(), grid.Rows[14].GetRowRepresentation());
        Assert.Equal(Row14.Reverse(), grid.Rows[15].GetRowRepresentation());
        Assert.Equal(Row13.Reverse(), grid.Rows[16].GetRowRepresentation());
        Assert.Equal(Row12.Reverse(), grid.Rows[17].GetRowRepresentation());
        Assert.Equal(Row11.Reverse(), grid.Rows[18].GetRowRepresentation());
        Assert.Equal(Row10.Reverse(), grid.Rows[19].GetRowRepresentation());
        Assert.Equal(Row9.Reverse(), grid.Rows[20].GetRowRepresentation());
        Assert.Equal(Row8.Reverse(), grid.Rows[21].GetRowRepresentation());
        Assert.Equal(Row7.Reverse(), grid.Rows[22].GetRowRepresentation());
        Assert.Equal(Row6.Reverse(), grid.Rows[23].GetRowRepresentation());
        Assert.Equal(Row5.Reverse(), grid.Rows[24].GetRowRepresentation());
        Assert.Equal(Row4.Reverse(), grid.Rows[25].GetRowRepresentation());
        Assert.Equal(Row3.Reverse(), grid.Rows[26].GetRowRepresentation());
        Assert.Equal(Row2.Reverse(), grid.Rows[27].GetRowRepresentation());
        Assert.Equal(Row1.Reverse(), grid.Rows[28].GetRowRepresentation());
        Assert.Equal(Row0.Reverse(), grid.Rows[29].GetRowRepresentation());
    }

    private void WriteGridToConsole(Grid grid)
    {
        for (int i = 29; i >= 0; i--)
        {
            Console.WriteLine(grid.Rows[i].GetRowRepresentation());
        }
    }
}
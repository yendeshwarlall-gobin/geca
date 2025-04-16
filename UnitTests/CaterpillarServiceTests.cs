using Geca.Domain;
using Geca.Domain.Grids;
using Geca.Services;
using Xunit;

namespace UnitTests;

public class CaterpillarServiceTests
{
    private readonly CaterpillarService _caterpillarService;
    
    public CaterpillarServiceTests()
    {
        _caterpillarService = new CaterpillarService();
    }
    
    [Theory]
    [InlineData("U 4", 4)]
    [InlineData("U 29", 29)]
    [InlineData("U 10", 10)]
    public void ProcessCommand_Works_As_Expected_When_Moving_Up(string command, int expectedYCoordinate)
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(0, 0),
            Tail = new Tail(0, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = command,
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(expectedYCoordinate,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(expectedYCoordinate - 1,result.Caterpillar.Tail.Coordinates.Y);
    }
    
    [Theory]
    [InlineData("D 4", 25)]
    [InlineData("D 29", 0)]
    [InlineData("D 10", 19)]
    public void ProcessCommand_Works_As_Expected_When_Moving_Down(string command, int expectedYCoordinate)
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(29, 0),
            Tail = new Tail(29, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = command,
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(expectedYCoordinate,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(expectedYCoordinate + 1,result.Caterpillar.Tail.Coordinates.Y);
    }
    
    [Theory]
    [InlineData("L 4", 25)]
    [InlineData("L 29", 0)]
    [InlineData("L 10", 19)]
    public void ProcessCommand_Works_As_Expected_When_Moving_Left(string command, int expectedYCoordinate)
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(29, 29),
            Tail = new Tail(29, 29),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = command,
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(expectedYCoordinate,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(expectedYCoordinate + 1,result.Caterpillar.Tail.Coordinates.X);
    }
    
    [Theory]
    [InlineData("R 4", 4)]
    [InlineData("R 29", 29)]
    [InlineData("R 10", 10)]
    public void ProcessCommand_Works_As_Expected_When_Moving_Right(string command, int expectedYCoordinate)
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(29, 0),
            Tail = new Tail(29, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = command,
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(expectedYCoordinate,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(expectedYCoordinate - 1,result.Caterpillar.Tail.Coordinates.X);
    }

    
    [Fact]
    public void ProcessCommand_Works_As_Expected_When_Moving_Up_And_Passing_The_Boundary()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(0, 0),
            Tail = new Tail(0, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "U 30",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(29,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(0,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(0,result.Caterpillar.Tail.Coordinates.X);
        Assert.Equal(29,result.Caterpillar.Tail.Coordinates.Y);
    }
    
    [Fact]
    public void ProcessCommand_Works_As_Expected_When_Moving_Down_And_Passing_The_Boundary()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(0, 0),
            Tail = new Tail(0, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "D 1",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(29,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(0,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(0,result.Caterpillar.Tail.Coordinates.X);
        Assert.Equal(29,result.Caterpillar.Tail.Coordinates.Y);
    }
    
    [Fact]
    public void ProcessCommand_Works_As_Expected_When_Moving_Left_And_Passing_The_Boundary()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(0, 0),
            Tail = new Tail(0, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "L 1",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(0,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(29,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(29,result.Caterpillar.Tail.Coordinates.X);
        Assert.Equal(0,result.Caterpillar.Tail.Coordinates.Y);
    }
    
    [Fact]
    public void ProcessCommand_Works_As_Expected_When_Moving_Right_And_Passing_The_Boundary()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(0, 25),
            Tail = new Tail(0, 29),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "R 20",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(0,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(29,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(29,result.Caterpillar.Tail.Coordinates.X);
        Assert.Equal(0,result.Caterpillar.Tail.Coordinates.Y);
    }

    
    [Fact]
    public void ProcessCommand_Tail_Follows_Head_As_Expected_When_Head_Moves_Up()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(0, 0),
            Tail = new Tail(0, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "U 9",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(9,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(0,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(8,result.Caterpillar.Tail.Coordinates.Y);
        Assert.Equal(0,result.Caterpillar.Tail.Coordinates.X);
    }
    
    [Fact]
    public void ProcessCommand_Tail_Follows_Head_As_Expected_When_Head_Moves_Down()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(5, 0),
            Tail = new Tail(5, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "D 3",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(2,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(0,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(3,result.Caterpillar.Tail.Coordinates.Y);
        Assert.Equal(0,result.Caterpillar.Tail.Coordinates.X);
    }
    
    [Fact]
    public void ProcessCommand_Tail_Follows_Head_As_Expected_When_Head_Moves_Up_Diagonally_By_1()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(0, 1),
            Tail = new Tail(0, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "U 1",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(1,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(1,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(0,result.Caterpillar.Tail.Coordinates.Y);
        Assert.Equal(0,result.Caterpillar.Tail.Coordinates.X);
    }
    
    [Fact]
    public void ProcessCommand_Tail_Follows_Head_As_Expected_When_Head_Down_Diagonally_By_1()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(5, 1),
            Tail = new Tail(5, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "D 1",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(4,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(1,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(5,result.Caterpillar.Tail.Coordinates.Y);
        Assert.Equal(0,result.Caterpillar.Tail.Coordinates.X);
    }
    
    [Fact]
    public void ProcessCommand_Tail_Follows_Head_As_Expected_When_Head_Moves_Up_Diagonally_By_2()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(0, 1),
            Tail = new Tail(0, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "U 2",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(2,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(1,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(1,result.Caterpillar.Tail.Coordinates.Y);
        Assert.Equal(1,result.Caterpillar.Tail.Coordinates.X);
    }
    
    [Fact]
    public void ProcessCommand_Tail_Follows_Head_As_Expected_When_Head_Moves_Down_Diagonally_By_2()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(5, 1),
            Tail = new Tail(5, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "D 2",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(3,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(1,result.Caterpillar.Head.Coordinates.X);
        Assert.Equal(4,result.Caterpillar.Tail.Coordinates.Y);
        Assert.Equal(1,result.Caterpillar.Tail.Coordinates.X);
    }
    
    [Fact]
    public void ProcessCommand_Works_As_Expected_When_Obstacle_Is_Encountered()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(0, 1),
            Tail = new Tail(0, 0),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "U 9",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.Equal(0,result.Caterpillar.Head.Coordinates.Y);
        Assert.Equal(0,result.Caterpillar.Head.Coordinates.X);
    }

    //This test requires manual input from user.
    //If dependency injection was being used, then this action would have mocked.
    // [Fact]
    public void ProcessCommand_Works_As_Expected_When_Booster_Is_Encountered()
    {
        //Arrange
        var caterpillar = new Caterpillar
        {
            Head = new Head(3, 4),
            Tail = new Tail(3, 3),
        };

        var startingPosition = new StartPosition(0, 0);
        var currentGrid = new StartingGrid();

        var request = new Request
        {
            Caterpillar = caterpillar,
            Command = "U 1",
            Grid = currentGrid,
            GridStartPosition = startingPosition,
        };
        
        //Act
        var result = _caterpillarService.ProcessCommand(request);
        result.Grid.PrintGrid();
        //Assert
        Assert.True(result.Caterpillar.Segments.Any());
    }
    
    
}
using Geca.Domain;
using Xunit;

namespace UnitTests;

public class CommandValidatorTests
{
    [Theory]
    [InlineData(null,false )]
    [InlineData("",false )]
    [InlineData(" ",false )]
    [InlineData("NoCommand",false )]
    [InlineData("D -1",false )]
    [InlineData("D 4",true )]
    [InlineData("U 1",true )]
    [InlineData("L 1",true )]
    [InlineData("R 1",true )]
    [InlineData("d 4",true )]
    [InlineData("u 1",true )]
    [InlineData("l 1",true )]
    [InlineData("r 1",true )]
    [InlineData("L 10",false )]
    [InlineData("L U",false )]
    public void IsValidMovementCommand_return_expected_result(string command, bool expectedResult)
    {
        //Arrange
        var commandValidator = new CommandValidator();
        //Act
        var result = commandValidator.IsValidMovementCommand(command);
        //Assert
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData("Grows",false )]
    [InlineData("Grow",true )]
    [InlineData("grow",true )]
    [InlineData("shrink",true )]
    [InlineData("Shrink",true )]
    public void IsValidLinearGrowthCommand_return_expected_result(string command, bool expectedResult)
    {
        //Arrange
        var commandValidator = new CommandValidator();
        //Act
        var result = commandValidator.IsValidLinearGrowthCommand(command);
        //Assert
        Assert.Equal(expectedResult, result);
    }
}
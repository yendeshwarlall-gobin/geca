using Geca.Domain;
using Xunit;

public class TestRows()
{
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
    public void Row0_Should_Be_As_Expected()
    {
        //Arrange
        var row = new Row0();

        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row0, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row0.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row1_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row1();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row1, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row1.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row2_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row2();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row2, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row2.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row3_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row3();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row3, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row3.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row4_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row4();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row4, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row4.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row5_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row5();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row5, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row5.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row6_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row6();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row6, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row6.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row7_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row7();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row7, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row7.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row8_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row8();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row8, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row8.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row9_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row9();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row9, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row9.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row10_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row10();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row10, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row10.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row11_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row11();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row11, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row11.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row12_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row12();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row12, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row12.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row13_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row13();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row13, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row13.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row14_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row14();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row14, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row14.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row15_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row15();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row15, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row15.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row16_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row16();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row16, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row16.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row17_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row17();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row17, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row17.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row18_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row18();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row18, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row18.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row19_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row19();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row19, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row19.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row20_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row20();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row20, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row20.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row21_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row21();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row21, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row21.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row22_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row22();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row22, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row22.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row23_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row23();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row23, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row23.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row24_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row24();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row24, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row24.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row25_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row25();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row25, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row25.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row26_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row26();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row26, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row26.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row27_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row27();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row27, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row27.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row28_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row28();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row28, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row28.Reverse(), reversedRepresentation);
    }

    [Fact]
    public void Row29_Should_Be_As_Expected()
    {
        //Arrange

        var row = new Row29();
        // Act
        var representation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row29, representation);

        //Act
        row.Reverse();
        var reversedRepresentation = row.GetRowRepresentation();

        //Assert
        Assert.Equal(Row29.Reverse(), reversedRepresentation);
    }

}
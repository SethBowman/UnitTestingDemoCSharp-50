using MainProject;

namespace UnitTests;

public class HelperTests
{
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(5, 5, 10)]
    public void AddTest(int a, int b, int expected)
    {
        //Arrange
        var helper = new Helper();
        
        //Act
        var actual = helper.Add(a, b);
        
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Seth", "Hello, Seth!")]
    [InlineData("Miah", "Hello, Miah!")]
    [InlineData("", "Hello!")]
    [InlineData(null, "Hello!")]
    public void GreetTest(string name, string expected)
    {
        //Arrange
        var helper = new Helper();
        
        //Act
        var actual = helper.Greet(name);
        
        //Assert
        Assert.Equal(expected, actual);
    }
}
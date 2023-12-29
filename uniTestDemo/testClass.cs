using Xunit;
public class testClass
{
    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void MyThoery(int number)
    {
        Assert.True(Program.isOdd(number));
    }
    [Fact]    
    public void AddTest()
    {
        Assert.Equal(4,Program.Add(2,2));
    }
    [Fact]
    public void FailingTest()
    {
        Assert.NotEqual(5,Program.Add(2,2));
    }
    
   
}
namespace App.Tests;
using Xunit;
public class UnitTest1
{
    public class Tests()
    {
        [Fact]
        public void SayHello_ReturnsExpectedString()
        {
            var result = Greeter.SayHello("Test");
            Assert.Equal("Hello, Test!", result);
        }
    }
}

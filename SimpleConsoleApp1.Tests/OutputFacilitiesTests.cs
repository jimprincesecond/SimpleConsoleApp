using Xunit;

namespace SimpleConsoleApp1.Tests
{
    public class OutputFacilitiesTests
    {
        [Fact]
        public void Test1()
        {
            var o = new OutputFacilities();

            var output = o.print("Hello world");
            
            Assert.True(output);
        }
    }
}
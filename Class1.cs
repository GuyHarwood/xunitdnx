using Xunit;

namespace dnxDemo
{
    public class Tests
    {
        [Fact]
        public void Passing()
        {
            Assert.Equal(1,1);
        }
        
        [Fact]
        public void Failing()
        {
            Assert.Equal(1,2);
        }
    }
}

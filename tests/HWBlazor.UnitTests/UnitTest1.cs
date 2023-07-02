using HWBlazor.Services;

namespace HWBlazor.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void GetSum()
        {
            var zero = new Calculate().Getzero();
            Assert.Equal(0, zero);
        }
    }
}
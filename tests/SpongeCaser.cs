using System;
using Xunit;
using SpongeCase;

namespace tests
{
    public class SpongeCaserTest
    {
        [Fact]
        public void SpongeCaseTransformTest()
        {
            Assert.Equal("hElLo WoRlD", SpongeCaser.ConvertToSpongeCase("Hello World"));
            Assert.Equal("hElLoWoRlD", SpongeCaser.ConvertToSpongeCase("HelloWorld"));
            Assert.Equal(" hElLo WoRlD ", SpongeCaser.ConvertToSpongeCase(" Hello World "));
        }
    }
}

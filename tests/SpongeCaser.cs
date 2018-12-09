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
            const string input = "Hello world";
            const string expectedOutputFromInput = "hElLo WoRlD";
            var actualOutputFromInput = SpongeCaser.ConvertToSpongeCase(input);

            Assert.Equal(expectedOutputFromInput, actualOutputFromInput);
        }
    }
}

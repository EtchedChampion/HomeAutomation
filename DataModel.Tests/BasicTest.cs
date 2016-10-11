using Xunit;
using FluentAssertions;

namespace DataModel.Tests
{
    public class BasicTest
    {
        [Fact]
        public void TestAreRunningCorrect()
        {
            var correct = 4;
            correct.Should().Be(4);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(3, 2, 6)]
        [InlineData(5, 6, 30)]
        public void BasicTheorysAreRunningCorrect(int value1, int value2, int shouldBe)
        {
            var answer = value1*value2;

            answer.Should().Be(shouldBe);
        }

    }
}

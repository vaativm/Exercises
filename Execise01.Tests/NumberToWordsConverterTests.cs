using Exercise01;

namespace Execise01.Tests
{
    public class NumberToWordsConverterTests
    {
        [Theory]
        [InlineData(10, "ten")]
        [InlineData(1000, "one thousand")]
        public void ToWordsShouldReturnIntegerInWordsGivenValidInput(int number, string expected)
        {
            var result = number.ToWords();

            Assert.Equal(expected.Trim().ToLower(), result.Trim().ToLower());
        }
    }
}
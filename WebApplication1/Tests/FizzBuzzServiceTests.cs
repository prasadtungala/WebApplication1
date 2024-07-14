using WebApplication1.Services;
using Xunit; // Ensure this using directive is present


namespace WebApplication1.Tests
{
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService _service;

        public FizzBuzzServiceTests()
        {
            _service = new FizzBuzzService();
        }

        [Fact]
        public void ProcessValues_Returns_Fizz_For_Multiples_Of_3()
        {
            // Arrange
            var values = new List<string> { "3" };

            // Act
            var results = _service.ProcessValues(values);

            // Assert
            Assert.Single(results);
            Assert.Equal("Fizz", results[0].Result);
        }

        [Fact]
        public void ProcessValues_Returns_Buzz_For_Multiples_Of_5()
        {
            // Arrange
            var values = new List<string> { "5" };

            // Act
            var results = _service.ProcessValues(values);

            // Assert
            Assert.Single(results);
            Assert.Equal("Buzz", results[0].Result);
        }

        [Fact]
        public void ProcessValues_Returns_FizzBuzz_For_Multiples_Of_3_And_5()
        {
            // Arrange
            var values = new List<string> { "15" };

            // Act
            var results = _service.ProcessValues(values);

            // Assert
            Assert.Single(results);
            Assert.Equal("FizzBuzz", results[0].Result);
        }

        [Fact]
        public void ProcessValues_Returns_Invalid_Item_For_Non_Integer_Values()
        {
            // Arrange
            var values = new List<string> { "A" };

            // Act
            var results = _service.ProcessValues(values);

            // Assert
            Assert.Single(results);
            Assert.Equal("Invalid Item", results[0].Result);
        }

        [Fact]
        public void ProcessValues_Logs_Division_For_Non_Multiples()
        {
            // Arrange
            var values = new List<string> { "23" };

            // Act
            var results = _service.ProcessValues(values);

            // Assert
            Assert.Single(results);
            Assert.Equal("Divided 23 by 3 Divided 23 by 5", results[0].Result);
        }
    }

}

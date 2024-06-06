using Xunit;
using ParallelSumApp;

namespace ParallelSumTests
{
    public class ParallelSumCalculatorTests
    {
        [Fact]
        public void CalculateSum_WithEmptyArray_ReturnsZero()
        {
            // Arrange
            int[] numbers = new int[0];
            ParallelSumCalculator calculator = new ParallelSumCalculator();

            // Act
            long result = calculator.CalculateSum(numbers);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateSum_WithSingleElement_ReturnsElementValue()
        {
            // Arrange
            int[] numbers = new int[] { 42 };
            ParallelSumCalculator calculator = new ParallelSumCalculator();

            // Act
            long result = calculator.CalculateSum(numbers);

            // Assert
            Assert.Equal(42, result);
        }

        [Fact]
        public void CalculateSum_WithMultipleElements_ReturnsCorrectSum()
        {
            // Arrange
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            ParallelSumCalculator calculator = new ParallelSumCalculator();

            // Act
            long result = calculator.CalculateSum(numbers);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void CalculateSum_WithLargeArray_ReturnsCorrectSum()
        {
            // Arrange
            int[] numbers = new int[1000000];
            Random rand = new Random();
            long expectedSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 1001);
                expectedSum += numbers[i];
            }
            ParallelSumCalculator calculator = new ParallelSumCalculator();

            // Act
            long result = calculator.CalculateSum(numbers);

            // Assert
            Assert.Equal(expectedSum, result);
        }
    }
}

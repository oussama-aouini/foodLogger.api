using AutoFixture;
using FluentAssertions;

namespace FoodLogger.Domain.Tests
{
    public class FoodTests
    {
        private readonly Fixture _fixture;

        public FoodTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void UpdateCalories_WithValidCalories_ShouldUpdateCalories()
        {
            // Arrange
            var food = _fixture.Create<Food>();
            var newCalories = 10;

            // Act 
            food.UpdateCalories(newCalories);

            // Assert
            food.Calories.Should().Be(newCalories);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-100)]
        public void UpdateCalories_WithInvalidCalories_ShouldThrowException(int invalidCalories)
        {
            // Arrange
            var food = _fixture.Create<Food>();

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => food.UpdateCalories(invalidCalories));
            exception.Message.Should().Be("Calories must be greater than zero");
        }
    }
}

using AutoFixture;
using FluentAssertions;
using FoodLogger.Application.Foods.Commands.CreateFoodCommand;
using FoodLogger.Application.Interfaces;
using FoodLogger.Application.Mappers;
using FoodLogger.Domain.Entities;
using Moq;

namespace FoodLogger.Application.Tests
{
    public class AddFoodCommandHandlerTests
    {
        private readonly Mock<IFoodRepository> _mockRepository;
        private readonly CreateFoodCommandHandler _handler;
        private readonly Fixture _fixture;

        public AddFoodCommandHandlerTests()
        {
            _mockRepository = new Mock<IFoodRepository>();
            _handler = new AddFoodHandler(_mockRepository.Object);
            _fixture = new Fixture();
        }

        [Fact]
        public async Task Handle_ValidCommand_ShouldAddFood()
        {
            // Arrange
            var command = _fixture.Create<CreateFoodCommand>();
            var food = command.ToFood();

            _mockRepository
                .Setup(x => x.AddFood(It.IsAny<Food>()))
                .Returns(food);

            // Act 
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert 
            result.Should().BeEquivalentTo(food);
            _mockRepository.Verify(x => x.AddFood(It.Is<Food>(f => 
                f.Calories == command.Calories &&
                f.Fats == command.Fats &&
                f.Name == command.Name &&
                f.Protein == command.Protein
            )), Times.Once);
        }
    }
}

using FoodLogger.Application.common;
using FoodLogger.Application.common.Interfaces;
using FoodLogger.Application.Mappers;
using FoosdLogger.Application.Foods.Commands.CreateFoodCommand;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FoodLogger.Application.Foods.Commands.CreateFoodCommand
{
    public class CreateFoodCommandHandler : IRequestHandler<CreateFoodCommand, Result<CreateFoodCommandResult>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ILogger<CreateFoodCommandHandler> _logger;

        public CreateFoodCommandHandler(IFoodRepository foodRepository, ILogger<CreateFoodCommandHandler> logger)
        {
            _foodRepository = foodRepository;
            _logger = logger;
        }

        public async Task<Result<CreateFoodCommandResult>> Handle(CreateFoodCommand request, CancellationToken cancellationToken)
        {

            var food = request.ToFood();
            var result = await _foodRepository.CreateAsync(food);

            if (!result.IsSuccess)
            {
                _logger.LogError("Failed to create food: {ErrorMessage}", result.ErrorMessage);
                return Result<CreateFoodCommandResult>.Failure(result.ErrorMessage);
            }

            var foodResult = result.Data!;
            return Result<CreateFoodCommandResult>.Success(foodResult);
        }
    }
}

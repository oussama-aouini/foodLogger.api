using FoodLogger.Application.common;
using FoodLogger.Application.Interfaces;
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
        //private readonly IValidator<CreateFoodCommand> _validator;

        public CreateFoodCommandHandler(IFoodRepository foodRepository, ILogger<CreateFoodCommandHandler> logger
            //, IValidator<CreateFoodCommand> validator
            )
        {
            _foodRepository = foodRepository;
            _logger = logger;
            //_validator = validator;
        }

        public async Task<Result<CreateFoodCommandResult>> Handle(CreateFoodCommand request, CancellationToken cancellationToken)
        {
            //var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            //if (validationResult.IsValid)
            //{
            //    var errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            //    return Result<CreateFoodCommandResult>.Failure(errors);
            //}

            var food = request.ToFood();
            var result = await _foodRepository.CreateAsync(food);

            if (!result.IsSuccess)
            {
                _logger.LogError("Failed to create food: {ErrorMessage}", result.ErrorMessage);
                return Result<CreateFoodCommandResult>.Failure(result.ErrorMessage);
            }

            var foodResult = result.Data!.ToCreateFoodCommandResult();
            return Result<CreateFoodCommandResult>.Success(foodResult);
        }
    }
}

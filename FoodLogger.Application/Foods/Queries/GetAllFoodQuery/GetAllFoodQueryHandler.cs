using FoodLogger.Application.common;
using FoodLogger.Application.Foods.Commands.CreateFoodCommand;
using FoodLogger.Application.Interfaces;
using FoodLogger.Application.Mappers;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FoodLogger.Application.Foods.Queries.GetAllFoodQuery
{
    internal class GetAllFoodQueryHandler : IRequestHandler<GetAllFoodQuery, Result<IEnumerable<GetAllFoodQueryResult>>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ILogger<CreateFoodCommandHandler> _logger;

        public GetAllFoodQueryHandler(IFoodRepository foodRepository, ILogger<CreateFoodCommandHandler> logger)
        {
            _foodRepository = foodRepository;
            _logger = logger;
        }

        public async Task<Result<IEnumerable<GetAllFoodQueryResult>>> Handle(GetAllFoodQuery request, CancellationToken cancellationToken)
        {
            var result = await _foodRepository.GetAllAsync();

            if (!result.IsSuccess)
            {
                _logger.LogError("Failed to retrive foods: {ErrorMessage}", result.ErrorMessage);
                return Result<IEnumerable<GetAllFoodQueryResult>>.Failure(result.ErrorMessage);
            }

            var foodResults = result.Data!.ToGetAllFoodQueryResult();

            return Result<IEnumerable<GetAllFoodQueryResult>>.Success(foodResults);
        }
    }
}

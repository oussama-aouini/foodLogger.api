using FoodLogger.Application.Interfaces;
using FoodLogger.Domain;
using MediatR;

namespace FoodLogger.Application.Foods.Queries.GetAllFoodQuery
{
    internal class GetAllFoodHandler : IRequestHandler<GetAllFoodQuery, List<Food>>
    {
        private readonly IFoodRepository _foodRepository;

        public GetAllFoodHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public Task<List<Food>> Handle(GetAllFoodQuery request, CancellationToken cancellationToken)
        {
            var foods = _foodRepository.GetAllFoods();
            return Task.FromResult(foods);
        }
    }
}

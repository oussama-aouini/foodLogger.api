using FoodLogger.Application.Interfaces;
using FoodLogger.Application.Mappers;
using FoodLogger.Domain;
using MediatR;

namespace FoodLogger.Application.Foods.Commands.AddFoodCommand
{
    public class AddFoodHandler : IRequestHandler<AddFoodCommand, Food>
    {
        private readonly IFoodRepository _foodRepository;

        public AddFoodHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public Task<Food> Handle(AddFoodCommand request, CancellationToken cancellationToken)
        {
            // TODO: add exception handeling 
            var food = request.ToFood();
            _foodRepository.AddFood(food);

            return Task.FromResult(food);
        }
    }
}

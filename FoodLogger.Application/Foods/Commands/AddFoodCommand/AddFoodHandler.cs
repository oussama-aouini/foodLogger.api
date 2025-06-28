using FoodLogger.Application.Interfaces;
using FoodLogger.Application.Mappers;
using FoodLogger.Domain;
using MediatR;

namespace FoodLogger.Application.Foods.Commands.AddFoodCommand
{
    internal class AddFoodHandler : IRequestHandler<AddFoodCommand, Food>
    {
        private readonly IFoodRepository _foodRepository;

        public AddFoodHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public Task<Food> Handle(AddFoodCommand request, CancellationToken cancellationToken)
        {
            // TODO: add exception handeling 
            _foodRepository.AddFood(request.ToFood());

            return Task.FromResult(request.ToFood());
        }
    }
}

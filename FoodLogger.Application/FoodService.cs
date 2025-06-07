using FoodLogger.Domain;

namespace FoodLogger.Application
{
    public class FoodService : IFoodService
    {
        public readonly IFoodRepository _foodRepository;

        public FoodService(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public List<Food> GetAllFood()
        {
            var foods = _foodRepository.GetAllFoods();
            return foods;
        }

        public Food AddFood(Food food)
        {
            _foodRepository.AddFood(food);

            return food;
        }
    }
}

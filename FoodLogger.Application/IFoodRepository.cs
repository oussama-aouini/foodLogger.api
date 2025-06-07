using FoodLogger.Domain;

namespace FoodLogger.Application
{
    public interface IFoodRepository
    {
        List<Food> GetAllFoods();
        Food AddFood(Food food);
    }
}

using FoodLogger.Domain;

namespace FoodLogger.Application
{
    public interface IFoodService
    {
        List<Food> GetAllFood();
        Food AddFood(Food food);
    }
}

using FoodLogger.Domain;

namespace FoodLogger.Application.Interfaces
{
    public interface IFoodRepository
    {
        List<Food> GetAllFoods();
        Food AddFood(Food food);
    }
}

using FoodLogger.Application;
using FoodLogger.Domain;

namespace FoodLogger.Infrastrcuture
{
    public class FoodRepository : IFoodRepository
    {
        public static List<Food> foods = new List<Food>()
        {
            new Food() { Id = 1, Name = "Apple", Calories = 95, Protein = 0, Carbs = 25, Fats = 0 },
            new Food() { Id = 2, Name = "Banana", Calories = 105, Protein = 1, Carbs = 27, Fats = 0 },
        };

        public List<Food> GetAllFoods()
        {
            return foods;
        }
    }
}

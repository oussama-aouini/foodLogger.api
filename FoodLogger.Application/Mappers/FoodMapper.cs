using FoodLogger.Application.Foods.Commands.AddFoodCommand;
using FoodLogger.Domain;

namespace FoodLogger.Application.Mappers
{
    public static class FoodMapper
    {
        public static Food ToFood(this AddFoodCommand command)
        {
            return new Food
            {
                Name = command.Name,
                Calories = command.Calories,
                Carbs = command.Carbs,
                Fats = command.Fats,
                Protein = command.Protein,
            };
        }
    }
}

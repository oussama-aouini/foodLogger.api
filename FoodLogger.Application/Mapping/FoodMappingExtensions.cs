using FoodLogger.Application.Foods.Commands.CreateFoodCommand;
using FoodLogger.Application.Foods.Queries.GetAllFoodQuery;
using FoodLogger.Domain.Entities;
using FoosdLogger.Application.Foods.Commands.CreateFoodCommand;

namespace FoodLogger.Application.Mappers
{
    public static class FoodMappingExtensions
    {
        public static Food ToFood(this CreateFoodCommand command)
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

        public static IEnumerable<GetAllFoodQueryResult> ToGetAllFoodQueryResult(this IEnumerable<Food> foods)
        {
            return foods.Select(food => new GetAllFoodQueryResult
            {
                Name = food.Name,
                Calories = food.Calories,
                Carbs = food.Carbs,
                Fats = food.Fats,
                Protein = food.Protein
            });
        }

        public static CreateFoodCommandResult ToCreateFoodCommandResult(this Food command)
        {
            return new CreateFoodCommandResult
            {
                Calories = command.Calories,
                Carbs = command.Carbs,
                Fats = command.Fats,
                Protein = command.Protein,
                Id = command.Id,
                Name = command.Name,
                
            };
        }
    }
}

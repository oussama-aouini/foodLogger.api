using FoodLogger.Domain.Entities;

namespace FoosdLogger.Application.Foods.Commands.CreateFoodCommand
{
    public record CreateFoodCommandResult
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fats { get; set; }

        public static implicit operator CreateFoodCommandResult(Food food)
        {
            return new CreateFoodCommandResult
            {
                Calories = food.Calories,
                Protein = food.Protein,
                Carbs = food.Carbs,
                Fats = food.Fats,
                Id = food.Id,
                Name = food.Name
            };
        }
    }
}

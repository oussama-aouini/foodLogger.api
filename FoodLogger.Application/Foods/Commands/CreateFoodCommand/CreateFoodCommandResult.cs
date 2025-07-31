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
    }
}

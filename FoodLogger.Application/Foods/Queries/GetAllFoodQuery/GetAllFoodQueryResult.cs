namespace FoodLogger.Application.Foods.Queries.GetAllFoodQuery
{
    public record GetAllFoodQueryResult
    {
        public string Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fats { get; set; }
    }
}

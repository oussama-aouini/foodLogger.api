namespace FoodLogger.Domain
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fats { get; set; }
    }
}

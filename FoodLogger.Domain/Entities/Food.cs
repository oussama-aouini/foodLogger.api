namespace FoodLogger.Domain.Entities
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fats { get; set; }

        public void UpdateCalories(int newCalories)
        {
            if (newCalories < 0)
            {
                throw new ArgumentException("Calories must be greater than zero");
            }

            Calories = newCalories;
        }
    }
}

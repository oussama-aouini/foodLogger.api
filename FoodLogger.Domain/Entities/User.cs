namespace FoodLogger.Domain.Entities
{
    internal class User
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal BMR { get; set; }
        public DateTime BirthDate { get; set; }
        public int Streak { get; set; }
    }
}

namespace FoodLogger.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string Auth0Id { get; set; } = string.Empty; // maps to auth0's sub (subject) claim
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal BMR { get; set; }
        public DateTime BirthDate { get; set; }
        public int Streak { get; set; }
        public Sex Sex { get; set; }
    }

    public enum Sex
    {
        Male = 0,
        Female = 1,
    }
}

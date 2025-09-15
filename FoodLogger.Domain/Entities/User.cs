namespace FoodLogger.Domain.Entities
{

    // DDD 
    // 1 - Entity: has an id, id doesn't change when attributes change
    // 2 - value object: immutable, equality based on values, no id
    // 3 - aggregate: a cluster of related objects reated as a single unit
    // 4 - Aggregate root: the entry point of an aggregate, ensures invariants

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

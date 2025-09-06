using FoodLogger.Domain.Entities;

namespace FoodLogger.Application.Users.Queries.GetUserProfile
{
    public class GetUserProfileQueryResult
    {
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal BMR { get; set; }
        public DateTime BirthDate { get; set; }
        public int Streak { get; set; }
        public Sex Sex { get; set; }
    }
}

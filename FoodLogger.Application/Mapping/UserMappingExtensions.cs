using FoodLogger.Application.Users.Queries.GetUserProfile;
using FoodLogger.Domain.Entities;

namespace FoodLogger.Application.Mapping
{
    public static class UserMappingExtensions
    {
        public static GetUserProfileQueryResult ToGetUserProfileQueryResult(this User user)
        {
            return new GetUserProfileQueryResult
            {
                BirthDate = user.BirthDate,
                BMR = user.BMR,
                Height = user.Height,
                Sex = user.Sex,
                Streak = user.Streak,
                Weight = user.Weight
            };
        }
    }
}

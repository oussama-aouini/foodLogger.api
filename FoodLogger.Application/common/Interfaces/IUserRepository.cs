using FoodLogger.Domain.Entities;

namespace FoodLogger.Application.common.Interfaces
{
    public interface IUserRepository
    {
        Task<Result<User>> GetByAuth0IdAsync(string auth0Id);
    }
}

using FoodLogger.Application.common;
using FoodLogger.Domain.Entities;

namespace FoodLogger.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<Result<User>> GetByAuth0IdAsync(string auth0Id);
    }
}

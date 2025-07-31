using FoodLogger.Application.common;
using FoodLogger.Domain.Entities;

namespace FoodLogger.Application.Interfaces
{
    public interface IFoodRepository
    {
        Task<Result<IEnumerable<Food>>> GetAllAsync();
        Task<Result<Food>> GetByIdAsync(int id);
        Task<Result<Food>> CreateAsync(Food food);
        Task<Result<Food>> UpdateAsync(Food food);
        Task<Result> DeleteAsync(int id);
        Task<Result<bool>> ExistsAsync();
    }
}

using FoodLogger.Application.common;
using FoodLogger.Application.Interfaces;
using FoodLogger.Domain.Entities;
using FoodLogger.Infrastrcuture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FoodLogger.Infrastructure.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        private readonly AppDbContext _context;
        private readonly ILogger<FoodRepository> _logger;

        public FoodRepository(AppDbContext appDbContext, ILogger<FoodRepository> logger)
        {
            _context = appDbContext;
            _logger = logger;
        }

        public async Task<Result<IEnumerable<Food>>> GetAllAsync()
        {
            try
            {
                var foods = await _context.Foods.ToListAsync();

                return Result<IEnumerable<Food>>.Success(foods);
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, "Error occurred while retrieving all foods");
                return Result<IEnumerable<Food>>.Failure("An error occurred while retrieving foods");
            }
        }

        public async Task<Result<Food>> CreateAsync(Food food)
        {
            try
            {
                _context.Foods.Add(food);
                await _context.SaveChangesAsync();

                return Result<Food>.Success(food);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating food");
                return Result<Food>.Failure("An error occurred while creating the food");
            }
        }

        public Task<Result> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<bool>> ExistsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<Food>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Food>> UpdateAsync(Food food)
        {
            throw new NotImplementedException();
        }

    }
}

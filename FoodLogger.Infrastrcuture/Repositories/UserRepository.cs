using FoodLogger.Application.common;
using FoodLogger.Application.Interfaces;
using FoodLogger.Domain.Entities;
using FoodLogger.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FoodLogger.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result<User>> GetByAuth0IdAsync(string auth0Id)
        {
            if (string.IsNullOrWhiteSpace(auth0Id))
            {
                return Result<User>.Failure("Auth0Id must have a value");
            }

            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Auth0Id == auth0Id);

            if (existingUser == null) 
            {
                var newUser = new User() { Auth0Id = auth0Id};

                _context.Users.Add(newUser);

                await _context.SaveChangesAsync();

                return Result<User>.Success(newUser);
            }

            return Result<User>.Success(existingUser);
        }
    }
}

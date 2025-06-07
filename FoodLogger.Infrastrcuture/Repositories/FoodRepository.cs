﻿using FoodLogger.Application;
using FoodLogger.Domain;
using FoodLogger.Infrastrcuture.Data;

namespace FoodLogger.Infrastructure.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        private readonly AppDbContext _appDbContext;

        public FoodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Food AddFood(Food food)
        {
            _appDbContext.Foods.Add(food);
            _appDbContext.SaveChanges();

            return food;
        }

        public List<Food> GetAllFoods()
        {
            return _appDbContext.Foods.ToList();
        }
    }
}

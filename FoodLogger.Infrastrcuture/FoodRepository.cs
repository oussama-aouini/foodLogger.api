using FoodLogger.Application;
using FoodLogger.Domain;

namespace FoodLogger.Infrastrcuture
{
    public class FoodRepository : IFoodRepository
    {
        private AppDbContext _appDbContext;

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

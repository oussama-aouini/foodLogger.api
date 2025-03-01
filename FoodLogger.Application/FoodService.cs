using FoodLogger.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLogger.Application
{
    class FoodService : IFoodService
    {
        public IFoodRepository _foodRepository { get; set; }
        public FoodService(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public List<Food> GetAllFood()
        {
            var foods = _foodRepository.GetAllFoods();
            return foods;
        }
    }
}

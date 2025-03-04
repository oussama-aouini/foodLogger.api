using FoodLogger.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLogger.Application
{
    public interface IFoodService
    {
        List<Food> GetAllFood();
        Food AddFood(Food food);
    }
}

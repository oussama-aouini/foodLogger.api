using FoodLogger.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLogger.Application
{
    interface IFoodService
    {
        List<Food> GetAllFood();
    }
}

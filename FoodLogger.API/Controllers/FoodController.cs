using FoodLogger.Application;
using FoodLogger.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FoodLogger.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        public readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet]
        public ActionResult<List<Food>> Get()
        {
            var foods = _foodService.GetAllFood();
            return Ok(foods);
        }

        [HttpPost]
        public ActionResult<Food> Post([FromBody] Food food)
        {
            var newFood = _foodService.AddFood(food);
            return Ok(newFood);
        }
    }
}

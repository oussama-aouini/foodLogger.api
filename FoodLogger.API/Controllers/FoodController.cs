using FoodLogger.Application.Foods.Commands.AddFoodCommand;
using FoodLogger.Application.Foods.Queries.GetAllFoodQuery;
using FoodLogger.Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace FoodLogger.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class FoodController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FoodController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<ActionResult<List<Food>>> Get()
        {
            var query = new GetAllFoodQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Food>> Post(AddFoodCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        //[HttpDelete]
        //public async Task<ActionResult<Food>> DeleteFood()
        //{
        //    var response = await _mediator.Send(command);

        //    return;
        //}
    }
}

using FoodLogger.Application.Foods.Commands.CreateFoodCommand;
using FoodLogger.Application.Foods.Queries.GetAllFoodQuery;
using FoodLogger.Domain.Entities;
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
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllFoodQuery();
            var result = await _mediator.Send(query);

            if (!result.IsSuccess) 
            {
                return StatusCode(500, new {message = result.ErrorMessage});
            }

            return Ok(result.Data);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    if (id <= 0)
        //    {
        //        return BadRequest(new { message = "Invalid food ID" });
        //    }


        //}

        [HttpPost]
        public async Task<ActionResult<Food>> Post(CreateFoodCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result.IsSuccess) 
            {
                if (result.Errors.Any()) 
                { 
                    return BadRequest(new { errors = result.Errors});
                }
                return StatusCode(500, new { message = result.ErrorMessage});
            }

            //return CreatedAtAction(nameof(GetById), new {id = result.Data!.Id}, result.Data);
            return Ok(result.Data);
        }
    }
}

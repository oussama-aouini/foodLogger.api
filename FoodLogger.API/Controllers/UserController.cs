using FoodLogger.Application.Users.Queries.GetUserProfile;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FoodLogger.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UserController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpGet]
        public async Task<IActionResult> GetUserProfile()
        {
            var auth0Id = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var query = new GetUserProfileQuery(auth0Id ?? throw new ArgumentNullException(nameof(auth0Id)));

            var result = await _mediator.Send(query);

            if (!result.IsSuccess)
            {
                return StatusCode(500, new { message = result.ErrorMessage });
            }

            return Ok(result.Data);
        }
    }
}

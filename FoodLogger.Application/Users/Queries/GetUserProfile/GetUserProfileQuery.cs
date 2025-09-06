using FoodLogger.Application.common;
using MediatR;

namespace FoodLogger.Application.Users.Queries.GetUserProfile
{
    public record GetUserProfileQuery(string Auth0Id) : IRequest<Result<GetUserProfileQueryResult>>;
}

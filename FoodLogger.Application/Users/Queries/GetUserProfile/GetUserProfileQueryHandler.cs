using FoodLogger.Application.common;
using FoodLogger.Application.common.Interfaces;
using FoodLogger.Application.Mapping;
using MediatR;

namespace FoodLogger.Application.Users.Queries.GetUserProfile
{
    internal class GetUserProfileQueryHandler : IRequestHandler<GetUserProfileQuery, Result<GetUserProfileQueryResult>>
    {
        private readonly IUserRepository _userRepository;

        public GetUserProfileQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result<GetUserProfileQueryResult>> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
        {
            var result = await _userRepository.GetByAuth0IdAsync(request.Auth0Id);

            var user = result.Data;

            if (user != null)
            {
                return Result<GetUserProfileQueryResult>.Success(user.ToGetUserProfileQueryResult());
            }

            return Result<GetUserProfileQueryResult>.Failure("No user found");
        }
    }
}

using FoodLogger.Application.common;
using MediatR;

namespace FoodLogger.Application.Foods.Queries.GetAllFoodQuery
{
    public record GetAllFoodQuery : IRequest<Result<IEnumerable<GetAllFoodQueryResult>>>;
}

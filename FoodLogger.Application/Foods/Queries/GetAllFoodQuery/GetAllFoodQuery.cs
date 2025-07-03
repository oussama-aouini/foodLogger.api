using FoodLogger.Domain;
using MediatR;

namespace FoodLogger.Application.Foods.Queries.GetAllFoodQuery
{
    public record GetAllFoodQuery : IRequest<List<Food>>;
}

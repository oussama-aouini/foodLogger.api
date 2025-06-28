using FoodLogger.Domain;
using MediatR;

namespace FoodLogger.Application.Foods.Commands.AddFoodCommand
{
    public record AddFoodCommand(string Name,
        int Calories,
        int Protein,
        int Carbs,
        int Fats) : IRequest<Food> 
    {}
}

using FoodLogger.Application.common;
using FoosdLogger.Application.Foods.Commands.CreateFoodCommand;
using MediatR;

namespace FoodLogger.Application.Foods.Commands.CreateFoodCommand
{
    public record CreateFoodCommand(string Name,
        int Calories,
        int Protein,
        int Carbs,
        int Fats) : IRequest<Result<CreateFoodCommandResult>>;
}

// TODO Add validators in same file as commands and queries simpler 

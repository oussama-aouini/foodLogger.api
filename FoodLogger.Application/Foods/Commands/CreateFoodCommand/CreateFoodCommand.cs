using FluentValidation;
using FoodLogger.Application.common;
using FoosdLogger.Application.Foods.Commands.CreateFoodCommand;
using MediatR;

namespace FoodLogger.Application.Foods.Commands.CreateFoodCommand
{
    public record CreateFoodCommand(string Name,
        int Calories,
        int Protein,
        int Carbs,
        int Fats
    ) : IRequest<Result<CreateFoodCommandResult>>;

    public class CreateFoodCommandValidator : AbstractValidator<CreateFoodCommand>
    {
        public CreateFoodCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Food name is required")
                .MaximumLength(100).WithMessage("Food name cannot exceed 100 characters.");

            RuleFor(x => x.Calories)
                .GreaterThanOrEqualTo(0).WithMessage("Calories must be non-negative.");

            RuleFor(x => x.Protein)
                .GreaterThanOrEqualTo(0).WithMessage("Protein must be non-negative.");

            RuleFor(x => x.Carbs)
                .GreaterThanOrEqualTo(0).WithMessage("Carbs must be non-negative.");

            RuleFor(x => x.Fats)
                .GreaterThanOrEqualTo(0).WithMessage("Fats must be non-negative.");
        }
    }
}

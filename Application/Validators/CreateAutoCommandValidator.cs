using Application.Commands;
using FluentValidation;

namespace Application.Validators
{
    public class CreateAutoCommandValidator : AbstractValidator<CreateAutoCommand>
    {
        public CreateAutoCommandValidator()
        {
            RuleFor(x => x.Marca).NotEmpty();
            RuleFor(x => x.Modelo).NotEmpty();
            RuleFor(x => x.Tipo).NotEmpty();
            RuleFor(x => x.CantidadAsientos).GreaterThan(0);
            RuleFor(x => x.AñoFabricacion).GreaterThan(0);
        }
    }
}

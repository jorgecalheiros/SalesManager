using FluentValidation;

namespace SalesManager.Application.Commands.Product
{
    public class CreateProductValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("O nome do produto é obrigatório.")
                .MinimumLength(2).WithMessage("O nome do produto deve ter pelo menos 2 caracteres.")
                .MaximumLength(100).WithMessage("O nome do produto não pode exceder 100 caracteres.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("A descrição não pode exceder 500 caracteres.");

            RuleFor(x => x.Price)
                .GreaterThan(0m).WithMessage("O preço deve ser maior que zero.");

            RuleFor(x => x.Stock)
                .GreaterThanOrEqualTo(0).WithMessage("O estoque deve ser zero ou maior.");
        }
    }
}

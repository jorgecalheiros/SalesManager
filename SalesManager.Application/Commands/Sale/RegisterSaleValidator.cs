using FluentValidation;

namespace SalesManager.Application.Commands.Sale
{
    public class RegisterSaleValidator : AbstractValidator<RegisterSaleCommand>
    {
        public RegisterSaleValidator()
        {
            RuleFor(x => x.ClientId)
                .NotEqual(Guid.Empty).WithMessage("O id do cliente é obrigatório.");

            RuleFor(x => x.Items)
                .NotNull().WithMessage("Itens da venda são obrigatórios.")
                .NotEmpty().WithMessage("A venda deve conter ao menos um item.");

            RuleForEach(x => x.Items).ChildRules(item =>
            {
                item.RuleFor(i => i.ProductId)
                    .NotEqual(Guid.Empty)
                    .WithMessage("O id do produto é obrigatório.");

                item.RuleFor(i => i.Quantity)
                    .GreaterThan(0)
                    .WithMessage("A quantidade deve ser maior que zero.");

                item.RuleFor(i => i.UnitPrice)
                    .GreaterThan(0m)
                    .WithMessage("O preço unitário deve ser maior que zero.");
            });
        }
    }
}

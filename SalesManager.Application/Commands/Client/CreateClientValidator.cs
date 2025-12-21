using FluentValidation;

namespace SalesManager.Application.Commands.Client
{
    public class CreateClientValidator : AbstractValidator<CreateClientCommand>
    {
        public CreateClientValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("O nome do cliente é obrigatório.")
                .MaximumLength(100).WithMessage("O nome do cliente não pode exceder 100 caracteres.")
                .MinimumLength(2).WithMessage("O nome do cliente deve ter pelo menos 2 caracteres.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O e-mail é obrigatório.")
                .EmailAddress().WithMessage("É necessário um endereço de e-mail válido.")
                .MaximumLength(100).WithMessage("O e-mail não pode exceder 100 caracteres.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("O telefone é obrigatório.")
                .Matches(@"^55\d{10,11}$")
                .WithMessage("O telefone deve estar no formato 55 + DDD + Número (ex: 5511988887777).")
                .Length(12, 13).WithMessage("O telefone deve ter entre 12 e 13 dígitos (incluindo o 55).");
        }
    }
}

using FluentValidation;

namespace SalesManager.Application.Commands.Client
{
    public class UpdateClientValidator : AbstractValidator<UpdateClientCommand>
    {
        public UpdateClientValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Client ID é obrigatório.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Nome é obrigatório.")
                .MinimumLength(2).WithMessage("Nome deve ter ao menos 2 caracteres.")
                .MaximumLength(100).WithMessage("Nome não pode exceder 100 caracteres.")
                .When(x => x.Name != null);

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email é obrigatório.")
                .EmailAddress().WithMessage("Email inválido.")
                .MaximumLength(100).WithMessage("Email não pode exceder 100 caracteres.")
                .When(x => x.Email != null);

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Telefone é obrigatório.")
                .Matches(@"^55\d{9,10}$")
                .WithMessage("O telefone deve estar no formato 55 + DDD + Número (ex: 55119888877).")
                .Length(11, 12).WithMessage("O telefone deve ter entre 11 e 12 dígitos (incluindo o 55).")
                .When(x => x.PhoneNumber != null);
        }
    }
}

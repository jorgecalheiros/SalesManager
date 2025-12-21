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
                .Matches(@"^55\d{2}9\d{8}$")
                    .WithMessage("Telefone deve seguir o formato 5512997311640 (código do país 55, DDD de 2 dígitos, 9XXXXXXXX).")
                .Length(13).WithMessage("Telefone deve conter exatamente 13 dígitos (ex.: 5512997311640).")
                .When(x => x.PhoneNumber != null);
        }
    }
}

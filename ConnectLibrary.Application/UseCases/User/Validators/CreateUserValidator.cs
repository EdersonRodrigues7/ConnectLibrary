using ConnectLibrary.Application.UseCases.User.Requests;
using FluentValidation;

namespace ConnectLibrary.Application.UseCases.User.Validators;

public class CreateUserValidator : AbstractValidator<CreateUserRequest>
{
    public CreateUserValidator()
    {
        RuleFor(u => u.Username)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(50).
            WithMessage("O nome de usuário deve ter entre 3 e 50 caracteres.");
        
        RuleFor(u => u.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("Endereço de e-mail inválido.");
        
        RuleFor(u => u.Password)
            .NotEmpty()
            .WithMessage("O campo 'senha' é obrigatório");
        
        When(request => string.IsNullOrEmpty(request.Password) == false, ValidatePasswordLength);
    }

    private void ValidatePasswordLength()
    {
        RuleFor(request => request.Password.Length).GreaterThanOrEqualTo(6).WithMessage("A senha deve ter no mínimo 6 caracteres.");
    }
}
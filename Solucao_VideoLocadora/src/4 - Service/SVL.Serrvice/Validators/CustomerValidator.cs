using FluentValidation;
using SVL.AplicationCore.Domain;
using System;

namespace Modelo.Service.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Objeto Cliente não pode ser nulo.");
                });

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("CPF é Obrigatório.")
                .NotNull().WithMessage("CPF é Obrigatório.");

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome do Cliente é Obrigatório.")
                .NotNull().WithMessage("Nome do Cliente é Obrigatório.");

            RuleFor(c => c.Sexo)
                .NotEmpty().WithMessage("Sexo do Cliente é obrigatório")
                .NotNull().WithMessage("Sexo do Cliente é obrigatório");


        }
    }
}
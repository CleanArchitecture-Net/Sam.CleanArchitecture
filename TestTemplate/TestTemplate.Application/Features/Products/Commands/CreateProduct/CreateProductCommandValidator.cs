﻿using FluentValidation;
using TestTemplate.Application.Interfaces;

namespace TestTemplate.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator(ITranslator translator)
        {

            RuleFor(p => p.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100)
                .WithName(p => translator[nameof(p.Name)]);

            RuleFor(x => x.BarCode)
                .MaximumLength(50)
                .WithName(p => translator[nameof(p.BarCode)]);
        }
    }
}

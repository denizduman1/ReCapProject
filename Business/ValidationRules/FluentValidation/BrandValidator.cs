using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
            RuleFor(b => b.Id).GreaterThan(0);
            RuleFor(b => b.Name).NotEmpty();
        }
    }
}

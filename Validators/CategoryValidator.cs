using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name could not be null!")
                .Length(4, 450).WithMessage("Length must be from 4 to 450!");
            RuleFor(x => x.ParentId)
                .GreaterThanOrEqualTo(0).WithMessage("Parent id should be greater or equal to zero!");
        }
    }
}

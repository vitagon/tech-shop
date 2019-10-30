using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Data;
using TechShop.Models;

namespace TechShop.Utilities.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class CategoryExistsAttribute : ValidationAttribute
    {
        public CategoryExistsAttribute()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var context = (TechDbContext)validationContext.GetService(typeof(TechDbContext));
            var result = from i in context.Category
                         where i.Id == (int)value
                         select i;
            Category category = result.SingleOrDefault();
            if (category == null)
            {
                return new ValidationResult("Entity with such Id was not found!");
            }

            return ValidationResult.Success;
        }

        public override string FormatErrorMessage(string name)
        {
            return base.FormatErrorMessage(name);
        }
    }
}

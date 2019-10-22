using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Utilities.Attributes
{
    public class MinAttribute : ValidationAttribute
    {
        private int _minVal;

        public MinAttribute(int minVal)
        {
            _minVal = minVal;
        }

        public override bool IsValid(object value)
        {
            if ((int)value >= _minVal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

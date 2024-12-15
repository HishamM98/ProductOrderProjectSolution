using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.Validators
{
    public class PriceRangeValidatorAttribute : ValidationAttribute
    {
        public string OtherPropertyName;
        public PriceRangeValidatorAttribute(string otherPropertyName)
        {
            OtherPropertyName = otherPropertyName;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var maxPrice = Convert.ToInt32(value);

                PropertyInfo? otherProperty = validationContext.ObjectType.GetProperty(OtherPropertyName);

                if (otherProperty != null)
                {
                    var minPrice = Convert.ToInt32(otherProperty.GetValue(validationContext.ObjectInstance));

                    if (minPrice > maxPrice)
                    {
                        return new ValidationResult(ErrorMessage, new string[]
                        {
                        OtherPropertyName, validationContext.MemberName ?? ""
                        });
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                }
                return null;
            }
            return null;

        }
    }
}

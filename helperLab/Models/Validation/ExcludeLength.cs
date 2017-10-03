using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace helperLab.Models.Validation
{
    public class ExcludeLength : ValidationAttribute
    {
        private readonly int _len;

        public ExcludeLength(int length) : base("{0} has invalid length.")
        {
            _len = length;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string val = value.ToString();
                if (val.Length > _len)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}
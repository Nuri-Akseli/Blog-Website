using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidationTool
    {
        IValidator _validator;
        public ValidationTool(IValidator validator)
        {
            _validator = validator;
        }
        public ValidationResult Validate(object entity)
        {
            var context = new ValidationContext<object>(entity);
            return _validator.Validate(context);
        }
    }
}

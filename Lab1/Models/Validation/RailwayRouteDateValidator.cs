using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Lab1.Models.Validation
{
    public class RailwayRouteDateValidator : IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            if (context.Model is DateTime model && model.Date > DateTime.Now.Date)
                return Enumerable.Empty<ModelValidationResult>();
            return new List<ModelValidationResult>
            {
                new("", "The date should be in future")
            };
        }
    }
}
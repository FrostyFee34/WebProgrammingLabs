using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Lab1.Models.Validation
{
    public class RailwayRouteValidatorProvider : IModelValidatorProvider
    {
        public void CreateValidators(ModelValidatorProviderContext context)
        {
            if (context.ModelMetadata.ContainerType == typeof(RailwayRoute))
            {
                context.Results.Add(new ValidatorItem
                {
                    Validator = new RailwayRouteDateValidator(),
                    IsReusable = true
                });
            }
        }
    }
}
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomValidation
{
    public class ValidationFilterAttribute : ActionFilterAttribute, IOrderedFilter
    {
      public int Order { get; } = int.MinValue;

      override public void OnActionExecuting(ActionExecutingContext context)
      {
        if (!context.ModelState.IsValid)
        {
          ModelStateEntry entry = context.ModelState.ElementAt(0).Value;
          var attemptedVal = entry.AttemptedValue;
          var rawVal = entry.RawValue;
          context.Result = new OkObjectResult(rawVal);
        }
      }
    }
}

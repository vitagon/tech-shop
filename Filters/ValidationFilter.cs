using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Contracts.V1.Responses;

namespace TechShop.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(x => x.ErrorMessage)).ToArray();
                
                var errorsDictionary = new Dictionary<string, List<string>>();
                foreach (var error in errors)
                {
                    foreach (var subError in error.Value)
                    {
                        if (errorsDictionary.ContainsKey(error.Key))
                        {
                            List<string> errorsList = errorsDictionary.Where(x => x.Key == error.Key).First().Value;
                            errorsList.Add(subError);
                        }
                        else
                        {
                            List<string> errorsList = new List<string>();
                            errorsList.Add(subError);
                            errorsDictionary.Add(error.Key, errorsList);
                        }
                    }
                }

                var errorResponse = new ErrorResponse();
                foreach (var error in errorsDictionary)
                {
                    var errorModel = new ErrorModel
                    {
                        FieldName = error.Key,
                        Messages = error.Value
                    };
                    errorResponse.Errors.Add(errorModel);
                }
                errorResponse.Type = "Validation error";
                errorResponse.Status = StatusCodes.Status400BadRequest;

                context.Result = new BadRequestObjectResult(errorResponse);
                return;
            }

            await next();
        }
    }
}

namespace BuiltinFilters.Filters
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System;

    public class MyExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            string message = string.Empty;
            if (exception.InnerException != null)
            {
                message = exception.InnerException.Message;
            }
            else
            {
                message = exception.Message;
            }
            // log exception here....
            var result = new ViewResult { ViewName = "Error" };
            var modelMetadata = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(modelMetadata, context.ModelState);
            result.ViewData.Add("Exception", message);
            context.Result = result;
            context.ExceptionHandled = true;
        }
    }

    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            string message = string.Empty;
            if (exception.InnerException != null)
            {
                message = exception.InnerException.Message;
            }
            else
            {
                message = exception.Message;
            }
            // log exception here....
            var result = new ViewResult { ViewName = "Error" };
            var modelMetadata = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(modelMetadata, context.ModelState);
            result.ViewData.Add("Exception", message);
            context.Result = result;
            context.ExceptionHandled = true;
        }
    }
}

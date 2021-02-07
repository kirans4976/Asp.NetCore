namespace BuiltinFilters.Filters
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using System;
    using System.Threading.Tasks;

    public class ResourceFilterExampleAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            context.Result = new ContentResult()
            {
                Content = "Resources are not available"
            };
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            
        }
    }

    public class ResourceFilterAsyncAttribute : Attribute, IAsyncResourceFilter
    {
        public Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            //To do : before the action executes  
            return next();
            //To do : after the action executes 
        }
    }
}

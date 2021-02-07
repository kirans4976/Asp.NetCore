namespace BuiltinFilters.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using System;
    public class SetAuthorAttribute : Attribute, IResultFilter
    {
        string _value;
        public SetAuthorAttribute(string value)
        {
            _value = value;
        }
        public void OnResultExecuted(ResultExecutedContext context)
        {

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("Author", new string[] { _value });
        }
    }
}

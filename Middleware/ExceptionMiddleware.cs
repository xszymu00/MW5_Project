using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace MW5_Project.Middleware;

public class ExceptionMiddleware
{
    public class MyLoggingMiddleware
    {
        private readonly RequestDelegate requestDelegate;

        public MyLoggingMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {

            try
            {
                await requestDelegate(httpContext);
            }
            catch (Exception e)
            {
                httpContext.Response.Clear();
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await httpContext.Response.WriteAsync("");
            }


        }
    }
}
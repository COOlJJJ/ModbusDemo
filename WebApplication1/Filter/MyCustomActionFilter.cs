using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace WebApplication1.Filter
{
    /// <summary>
    /// 自定义过滤器
    /// </summary>
    public class MyCustomActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("MyCustomActionFilterAttribute--------OnActionExecuting");
            // Do something before the action executes.
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("MyCustomActionFilterAttribute-------OnActionExecuted");
            // Do something after the action executes.
        }
    }
}

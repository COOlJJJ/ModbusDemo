﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Filter
{
    /// <summary>
    /// 全局异常过滤器
    /// </summary>
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        private readonly ILogger<ExceptionFilter> _logger;

        public ExceptionFilter(ILogger<ExceptionFilter> logger)
        {
            _logger = logger;
        }

        public override Task OnExceptionAsync(ExceptionContext context)
        {
            var ex = context.Exception;

            _logger.LogError("Path {Path} message {Exception}", context.HttpContext.Request.Path, ex);

            context.ExceptionHandled = true;

            return Task.CompletedTask;
        }
    }
}

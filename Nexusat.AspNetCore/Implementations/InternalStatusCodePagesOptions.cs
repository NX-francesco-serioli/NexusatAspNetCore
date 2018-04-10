﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Nexusat.AspNetCore.Mvc.Formatters;

namespace Nexusat.AspNetCore.Implementations
{
    /// <summary>
    /// Manage all the status code pages generated by the MVC framework
    /// </summary>
    internal class InternalStatusCodePagesOptions: StatusCodePagesOptions
    {
        public InternalStatusCodePagesOptions()
        {
            HandleAsync = (ctx) =>
            {
                if (ctx.HttpContext.Response.StatusCode == 404)
                {
                    var services = ctx.HttpContext.RequestServices;
                    var executor = services.GetRequiredService<ApiResponseExecutor>();
                    executor.RenderResponse(ctx.HttpContext, new NotFoundResponse());
                }

                return Task.FromResult(0);
            };
        }
    }
}

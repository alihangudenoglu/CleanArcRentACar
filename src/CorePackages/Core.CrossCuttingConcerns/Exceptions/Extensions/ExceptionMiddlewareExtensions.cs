using Core.CrossCuttingConcerns.Exceptions.Middlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.Extensions;

public static class ExceptionMiddlewareExtensions
{
    public static void ConfigureCustomeExceptionMiddleware(this IApplicationBuilder app) 
        => app.UseMiddleware<ExceptionMiddleware>();
}

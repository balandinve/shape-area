using Microsoft.Extensions.DependencyInjection;
using ShapeArea.Lib.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea.Lib.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAreaDI(this IServiceCollection services)
        {
            services.AddScoped<IAreaService, AreaService>();
        }
    }
}

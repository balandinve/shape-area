using Microsoft.Extensions.DependencyInjection;
using ShapeArea.Lib.Extensions;
using ShapeArea.Lib.Services;
using System;

namespace shape_area
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddAreaDI();
            var provider = services.BuildServiceProvider();
            var areaService = provider.GetService<IAreaService>();
            try
            {
                Console.WriteLine(areaService.GetCircleeArea(-5));
                Console.WriteLine(areaService.GetTriangleArea(1,2,3));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}

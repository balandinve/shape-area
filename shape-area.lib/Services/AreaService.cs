using ShapeArea.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea.Lib.Services
{
    public class AreaService : IAreaService
    {
        /// <summary>
        /// Get area value of circle by radius
        /// </summary>
        /// <param name="r">Radius of circle</param>
        /// <returns></returns>
        public double GetCircleeArea(double r)
        {
            return GetShapeArea(new Circle(r));
        }
        /// <summary>
        /// Get area of triange by its sides
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        /// <param name="c">Third side</param>
        /// <returns></returns>
        public double GetTriangleArea(double a, double b, double c)
        {
            return GetShapeArea(new Triangle(a, b, c));
        }

        private double GetShapeArea(IShape shape)
        {
            try
            {
                return shape.Area();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

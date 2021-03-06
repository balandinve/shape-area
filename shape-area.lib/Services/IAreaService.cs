using ShapeArea.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea.Lib.Services
{
    public interface IAreaService
    {
        /// <summary>
        /// Get area of triange by its sides
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        /// <param name="c">Third side</param>
        /// <returns>Area value</returns>
        double GetTriangleArea(double a, double b, double c);
        /// <summary>
        /// Get area value of circle by radius
        /// </summary>
        /// <param name="r">Radius of circle</param>
        /// <returns>Area value</returns>
        double GetCircleeArea(double r);
    }
}

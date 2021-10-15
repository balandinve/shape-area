using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeArea.Lib.Models
{
    public class Triangle: IShape
    {
        private readonly double A;
        private readonly double B;
        private readonly double C;
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsValid() {
            var isPositive = A > 0 && B > 0 && C > 0;
            var isCorrect = A + B > C && A + C > B && B + C > A;
            if (isPositive && isCorrect)
                return true;
            return false;
        }

        private bool IsRectangular()
        {
            if (!IsValid())
                throw new ArithmeticException("Invalid triangle");
            var ordered = new List<double> { A, B, C }.OrderByDescending(o => o).ToArray();
            if (Math.Pow(ordered[0], 2) == Math.Pow(ordered[1], 2) + Math.Pow(ordered[2], 2))
                return true;
            return false;

        }

        public double Area()
        {
            try
            {
                if (IsValid())
                {
                    if (IsRectangular())
                    {
                        var ordered = new List<double> { A, B, C }.OrderByDescending(o => o).ToArray();
                        return (ordered[1] * ordered[2]) / 2;
                    }
                    var halfPerimeter = (A + B + C) / 2;
                    return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
                }
                else throw new ArithmeticException("Invalid triangle");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea.Lib.Models
{
    public class Circle: IShape
    {
        private readonly double R;
        public Circle(double r)
        {
            R = r;
        }
        public bool IsValid()
        {
            return R > 0;
        }
        public double Area()
        {
            if (IsValid())
                return Math.PI * Math.Pow(R, 2)/2;
            throw new ArithmeticException("Incorrect circle.");
        }
    }
}

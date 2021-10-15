using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea.Lib.Models
{
    public interface IShape
    {
        double Area();
        bool IsValid();
    }
}

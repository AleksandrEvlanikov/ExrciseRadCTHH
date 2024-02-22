using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusCircleAndTriangle
{
    public class Circle : Shape
    {

        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalculateArea()
        {
            if (_radius < 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}

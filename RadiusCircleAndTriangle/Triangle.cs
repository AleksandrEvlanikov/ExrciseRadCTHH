using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusCircleAndTriangle
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public bool IsRightAngled(double sideA, double sideB, double sideC)
        {
            double maxLengthSide = Math.Max(Math.Max(sideA, sideB), sideC);
            double minLengthSide = Math.Min(Math.Min(sideA, sideB), sideC);
            double midLengthSide = sideA + sideB + sideC - maxLengthSide - minLengthSide;

            return ((minLengthSide * minLengthSide + midLengthSide * midLengthSide) == maxLengthSide * maxLengthSide);
        }

        public override double CalculateArea()
        {
            if (_sideA <= 0 || _sideB <= 0 || _sideC <= 0)
            {
                throw new ArgumentException("Длины сторон треугольника должны быть положительными числами.");
            }
            double s = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
        }
    }
}

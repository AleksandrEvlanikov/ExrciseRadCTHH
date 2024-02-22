using RadiusCircleAndTriangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExrciseRadCTTest
{
    public class SquareTriangleTest
    {
        [Fact]
        public void TriangleAreaCalculation()
        {
            // Arrange
            double sideA = 6;
            double sideB = 9;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(14.142135623730951, area, 5);
        }

        [Fact]
        public void RightAngledTriangleCheck()
        {
            // Arrange
            int sideA = 3;
            int sideB = 4;
            int sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightAngled = triangle.IsRightAngled(sideA, sideB, sideC);

            // Assert
            Assert.True(isRightAngled);
        }
    }
}

using RadiusCircleAndTriangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExrciseRadCTTest
{
    public class RadiustCritleTest
    {
        [Fact]
        public void CircleArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.Equal(78.53981633974483, area, 5);
        }
    }
}

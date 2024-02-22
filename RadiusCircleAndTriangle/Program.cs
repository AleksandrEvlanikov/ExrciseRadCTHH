namespace RadiusCircleAndTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double _circleRadius = 5;
                Circle circle = new Circle(_circleRadius);
                double _circleArea = circle.CalculateArea();
                Console.WriteLine($"Площадь круга с радиусом => {_circleRadius} равна => {_circleArea}");


                double _sideA = 6;
                double _sideB = 9;
                double _sideC = 5;
                Triangle triangle = new Triangle(_sideA, _sideB, _sideC);
                double _triangleArea = triangle.CalculateArea();
                Console.WriteLine($"Площадь треугольника со сторонами A => {_sideA}, B => {_sideB}, C => {_sideC} равна => {_triangleArea}");

                bool _isRightAngled = triangle.IsRightAngled(_sideA, _sideB, _sideC);
                if (_isRightAngled)
                {
                    Console.WriteLine("Треугольник является прямоугольным.");
                }
                else
                {
                    Console.WriteLine("Треугольник не является прямоугольным.");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Ошибка => {e.Message}");
            }
        }
    }
}

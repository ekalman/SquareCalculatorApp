
//  Circle class that inherits from Rigure
namespace SquareCalculatorApp
{
    class Circle : Figure
    {
        int radius;

        public Circle(int a) => radius = a;

        // Override GetSquare method for Circle
        public override float GetSquare() => (float) 3.14 * radius * radius;
        
        // Override GetResultInfo method for Circle
        public override string GetResultInfo()
        {
            return "Circle has a square equal to " + GetSquare();
        }
    }
}

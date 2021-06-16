
//  Rectangle class that inherits from Rigure
namespace SquareCalculatorApp
{
    class Rectangle : Figure
    {
        int A;
        int B;

        public Rectangle(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        // Override GetSquare method for Rectangle
        public override float GetSquare() => (float) A * B;

        // Override GetResultInfo method for Rectangle
        public override string GetResultInfo()
        {
            return "Rectangle has a square equal to " + GetSquare();
        }
    }
}

//  Triangle class that inherits from Rigure
namespace SquareCalculatorApp
{
    class Triangle : Figure
    {
        int A;
        int B;

        public Triangle(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        // Override GetSquare method for Triangle
        public override float GetSquare() => (float) A * B / 2;

        // Override GetResultInfo method for Triangle
        public override string GetResultInfo()
        {
            return "Triangle has a square equal to " + GetSquare();
        }
    }
}
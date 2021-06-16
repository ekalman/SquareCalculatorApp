
using System;

namespace SquareCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[3];
            figures[0] = new Triangle(3, 5);
            figures[1] = new Rectangle(4, 8);
            figures[2] = new Circle(6);

            float sumSquare = 0;
            foreach (Figure figure in figures)
            {
                Console.WriteLine(figure.GetResultInfo());
                sumSquare += figure.GetSquare();
            }

            Console.WriteLine("================================================");
            Console.WriteLine("The sum square of the three figures is " + sumSquare);
        }
    }
}

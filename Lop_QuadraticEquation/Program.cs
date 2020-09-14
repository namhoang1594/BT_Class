using System;

namespace Lop_QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            double c = double.Parse(Console.ReadLine());
            QuadraticEquation qe = new QuadraticEquation(a, b, c);

            if (qe.GetDiscriminant() > 0)
            {
                Console.WriteLine("PT co 2 nghiem la: ");
                Console.WriteLine("X1 = " + qe.GetRoot2x1());
                Console.WriteLine("X2 = " + qe.GetRoot2x2());
            }
            else if (qe.GetDiscriminant() == 0)
            {
                Console.WriteLine("PT co 1 nghiem duy nhat la: " + qe.GetRoot1());
            }
            else
                Console.WriteLine("PT vo nghiem");
        }
    }
}

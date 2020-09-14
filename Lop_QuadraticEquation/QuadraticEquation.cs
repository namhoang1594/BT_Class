using System;
using System.Collections.Generic;
using System.Text;

namespace Lop_QuadraticEquation
{
    class QuadraticEquation
    {
        private double a { set; get; }
        private double b { set; get; }
        private double c { set; get; }

        public QuadraticEquation()
        {

        }
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetDiscriminant()
        {
            double delta;
            return delta =  b * b - (4 * a * c);
        }
        public double GetRoot1()
        {
            return -b / (2.0 * a);
        }
        public double GetRoot2x1()
        {
            return (-b + Math.Sqrt(GetDiscriminant())) / (2 * a);
        }

        public double GetRoot2x2()
        {
            return (-b - Math.Sqrt(GetDiscriminant())) / (2 * a);
        }
    }
}

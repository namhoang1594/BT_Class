using System;

namespace Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fan 1: Gia tri speed lon nhat, radius 10, color yellow va fan ON");
            Fan fan_1 = new Fan();
            fan_1.setSpeed(3);
            fan_1.setRadius(10);
            fan_1.setColor("Yellow");
            Console.WriteLine(fan_1.ToString());
            Console.WriteLine("\n\n");
            Console.WriteLine("Fan 2: Gia tri speed trung binh, radius 5, color blue va fan OFF");
            Fan fan_2 = new Fan();
            fan_2.setSpeed(2);
            fan_2.seton(false);
            Console.WriteLine(fan_2.ToString());

            Console.ReadKey();
        }
    }
}

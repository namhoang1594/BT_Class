using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            int d=0;
            Animal a = new Animal();
            while (d >= 0) 
            {
                d++;
                Console.WriteLine("Nhap ten dong vat: ");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap tieng keu dong vat: ");
                string sound = Console.ReadLine();
                Console.WriteLine(a.idNum);
                Console.WriteLine(name + " se keu " + sound);
            }
        }
    }
}

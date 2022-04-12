using System;

namespace TrojkaPitagorejska
{
    class Program
    {
              
        static void Main(string[] args)
        {
            Console.WriteLine("Mozna wprowadzic tylko dodatnia liczbe:\nWprowadz a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz c: ");
            double c = Convert.ToDouble(Console.ReadLine());


            if (a * a + b * b == c * c)
            {
                Console.WriteLine("Wprowadzone liczby sa trojka pitagoryjska");
            }
            else
            {
                Console.WriteLine("Wprowadzone liczby nie sa trojka pitagoryjska");
            }
            Console.ReadKey();
        }
    }
}

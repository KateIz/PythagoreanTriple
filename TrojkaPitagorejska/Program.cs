using System;

namespace TrojkaPitagorejska
{
    class Program
    {
              
        public double NumberCheck()
        {
            //bool isNumber;
            double a1;
            double n;
            do
            {
                Console.WriteLine("Wprowadz a: ");
                string a2 = (Console.ReadLine());
                
                double.TryParse(a2, out n);  
                Console.WriteLine(n);
                if ( n== 1)
                {
                   a1 = Convert.ToDouble(a2);
                    return a1;
                }
                Console.WriteLine("Mozna wprowadzic tylko liczby: ");
                           
            }
            while (n == 0);
            Console.WriteLine("ok");            
            return n;


        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.NumberCheck();

            //do
            //{
            //    Console.WriteLine("Wprowadz a: ");
            //    string a1 = (Console.ReadLine());
            //    double.TryParse(a1, out double n);
            //    if (n == 1)
            //    {

            //        double a = Convert.ToDouble(a1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mozna wprowadzic tylko liczby: ");
            //    }
            //}
            //while (n != 1);

            
            
            
            //do
            //{
            //    if (a <= 0)
            //    {
            //        Console.WriteLine("Mozna wprowadzic tylko dodatnia liczbe: ");
            //        double a = Convert.ToDouble(Console.ReadLine())
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //while (a <= 0);


            //Console.WriteLine("Wprowadz b: ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Wprowadz c: ");
            //double c = Convert.ToDouble(Console.ReadLine());


            //if (a * a + b * b == c * c)
            //{
            //    Console.WriteLine("Wprowadzone liczby sa trojka pitagoryjska");
            //}
            //else
            //{
            //    Console.WriteLine("Wprowadzone liczby nie sa trojka pitagoryjska");
            //}

        }
    }
}

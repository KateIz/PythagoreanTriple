using System;

namespace TrojkaPitagorejska
{
    class Program
    {
              
        public double NumberCheck()
        {
            
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
           

        }
    }
}

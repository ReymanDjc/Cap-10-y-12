using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea_15.Cap_12
{
    class Factorial
    {
        public static void Main(string[] args)
        {
            factorial(5);
        }

        public static void factorial(int n)
        {
            int fac = 1;
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
                Console.WriteLine(fac);
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fac);
            Console.ReadKey();

        }
    }
}

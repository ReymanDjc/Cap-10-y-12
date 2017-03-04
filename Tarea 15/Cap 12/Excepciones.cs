using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea_15.Cap_12
{
    class Excepciones
    {
            // El control de excepciones utiliza las palabras clave try, catch y finally para intentar realizar acciones que podrían plantear problemas.

            static double Divisiónsegura(double x, double y)
            {
                if (y == 0)
                    throw new System.DivideByZeroException();
                return x / y;
            }
            static void Main()
            {

                double a = 98, b = 0;
                double result = 0;

                try
                {
                    result = Divisiónsegura(a, b);
                    Console.WriteLine("{0} Dividido por {1} = {2}", a, b, result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Se intentó dividir por cero.");
                }
            } 
    }
}

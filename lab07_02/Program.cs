using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int resultado = 0; 

            for(i = 1; i <= 1000; i++)
            {
                resultado = 3 * i;
                Console.WriteLine("Divisor de Rodrigo Mendoza " + i + ": " + resultado);
            }
            Console.ReadKey();
        }
    }
}

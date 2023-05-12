using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGEscalonachaCambioLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string y;
            string x;
            string resultado;
            public static string Palindromo()
            {
                Console.WriteLine("Hola ingrese una palabra");
                string palabra = Console.ReadLine();

                palabra = palabra.ToLower();
                string palindromo = palabra.Reverse().ToString();

                return "";
            }
        }
    }
    }
}

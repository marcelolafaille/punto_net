using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribir un int
            int numero = 5;
            Console.WriteLine(numero);

            // Escribir un string
            string frase = "Hola, como estás?";
            Console.WriteLine(frase);

            // Escribir un bool
            bool estado = true;
            Console.WriteLine(estado);


            switch (8) {
                case 1:
                    Console.WriteLine("El número es : " + numero);
                    break;
                case 5:
                    Console.WriteLine("El número es : " + numero);
                    break;
                    
            }

            TryCatch tryCatch = new TryCatch();
            tryCatch.eskeler();
            
            Console.ReadKey();
        }
    }
}

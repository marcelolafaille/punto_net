using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja = new Caja();
            caja.Abrir();
            caja.Cerrar();

            Console.ReadKey();


            caja.Color = "Negra";
            caja.ColorDeLaCaja();

            Console.ReadKey();


            string eskeler = "ESKELER";
            string dou = "DOU";
            string frase = string.Format("eskeler {0}, {1} dou", dou, eskeler);
            Console.WriteLine(frase);
            Console.ReadKey();


        }
    }
}

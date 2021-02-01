using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Caja
    {
        public string Color { get; set; }

        public void Abrir()
        {
            Console.WriteLine("Caja abierta");
        }

        public void Cerrar() {
            Console.WriteLine("Caja cerrada");
        }

        public void ColorDeLaCaja() {
            Console.WriteLine("El color de la caja es : "+Color);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class UsandoUsing
    {
        public void MetodoUsandoUsing() {
            using (DataTable tabla = new DataTable())
            {
                tabla.Columns.Add("Nombre", typeof(string));
                tabla.Columns.Add("Apellido", typeof(string));
                tabla.Columns.Add("Numero", typeof(string));

                tabla.Rows.Add("Nombre 01", "Apellido 01", "5");      // 0
                tabla.Rows.Add("Nombre 02", "Apellido 02", "15");     // 1 
                tabla.Rows.Add("Nombre 03", "Apellido 03", "52");     // 2
                tabla.Rows.Add("Nombre 04", "Apellido 04", "54");     // 3
                tabla.Rows.Add("Nombre 05", "Apellido 05", "555");    // 4
                tabla.Rows.Add("Nombre 06", "Apellido 06", "50000");  // 5

                Console.WriteLine(tabla.TableName);
                Console.WriteLine(tabla.Rows[0]);
                Console.WriteLine(tabla.Rows[0].Field<string>(0));
                Console.WriteLine(tabla.Rows[5].Field<string>(2));
                Console.WriteLine(tabla.Rows[4].Field<string>(1));
                Console.WriteLine(tabla.Rows[2].Field<string>(2));

                foreach (DataRow row in tabla.Rows) {
                    Console.Write("Nombre: " + row["Nombre"] + "  ");
                    Console.Write("Apellido: " + row["Apellido"] + "  ");
                    Console.Write("Numero: " + row["Numero"] + "  ");
                    Console.WriteLine();
                }

            }
        }
        
    }
}

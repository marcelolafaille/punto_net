using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase03
{
    class Program
    {
        private static DataTable tabla;

        static void Main(string[] args)
        {
            DataTable data = GetTable();

            foreach (DataRow row in data.Rows)
            {
                // ... Mostramos el primer valor

                // Console.WriteLine(row.Field<int>(0));
                // Console.WriteLine(row[0]);
                Console.WriteLine("DNI : " + row["DNI"]);
                Console.WriteLine("Nombre : " + row["Nombre"]);
                Console.WriteLine("Apellido : " + row["Apellido"]);
                Console.WriteLine("FechaNacimiento : " + row["FechaNacimiento"]);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Generamos la tabla
        /// </summary>
        static DataTable GetTable()
        {
            // Seteamos las columnas 
            DataTable table = new DataTable();
            table.Columns.Add("DNI", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Apellido", typeof(string));
            table.Columns.Add("FechaNacimiento", typeof(DateTime));

            // Insertamos las filas
            table.Rows.Add(25001002, "Cosme", "Fulanito", DateTime.Now);
            table.Rows.Add(50222333, "Cosme", "Fulanito", DateTime.Now);
            table.Rows.Add(10444333, "Cosme", "Fulanito", DateTime.Now);
            table.Rows.Add(21888999, "Cosme", "Fulanito", DateTime.Now);
            return table;
        }
    }
}
using System;
using System.Data;

// Clase 3 - System.Data

namespace Clase03
{
    class Program
    {
        private static DataTable tabla;

        static void Main(string[] args)
        {
            //DataTable table = GetTable();
            tabla = GetTable();

            Console.WriteLine(tabla.Rows[0]);

            foreach (DataRow row in tabla.Rows)
            {
                // ... Mostramos el primer valor
                // Console.WriteLine(row.Field<int>(0));
                // Console.WriteLine(row[0]);
                Console.WriteLine("Nombre : " + row["Nombre"]);
                Console.WriteLine("Apellido : " + row["Apellido"]);
                Console.WriteLine("DNI : " + row["DNI"]);
                Console.WriteLine("FechaNacimiento : " + row["FechaNacimiento"]);
            }

            Console.WriteLine("----------------------------------------");



            UsandoUsing usandoUsing = new UsandoUsing();
            usandoUsing.MetodoUsandoUsing();

            Console.WriteLine("----------------------------------------");

            
            
            UsandoDataSet unDataSet = new UsandoDataSet();
            unDataSet.MetodoUsandoDataSet();

            Console.WriteLine("----------------------------------------");


            Console.ReadKey();
        }

        static DataTable GetTable()
        {
            // Seteamos las columnas 
            DataTable tabla = new DataTable();
            tabla.Columns.Add("DNI", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));
            tabla.Columns.Add("FechaNacimiento", typeof(DateTime));

            // Insertamos las filas
            tabla.Rows.Add(25001002, "Nombre 01", "Apellido 01", DateTime.Now);
            tabla.Rows.Add(50222333, "Nombre 02", "Apellido 02", DateTime.Now);
            tabla.Rows.Add(10444333, "Nombre 03", "Apellido 03", DateTime.Now);
            tabla.Rows.Add(21888999, "Nombre 04", "Apellido 04", DateTime.Now);
            return tabla;
        }      
    }
}
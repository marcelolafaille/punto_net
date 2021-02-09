using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class UsandoDataSet
    {
        public void MetodoUsandoDataSet()
        {
            // Creamos 2 tablas
            DataTable pacientes = new DataTable("pacientes");
            pacientes.Columns.Add("id");
            pacientes.Columns.Add("nombre");
            pacientes.Rows.Add(1, "Marcelo");
            pacientes.Rows.Add(2, "Cecilia");

            DataTable remedios = new DataTable("remedios");
            remedios.Columns.Add("id");
            remedios.Columns.Add("nombre");
            remedios.Rows.Add(1, "ibuprofeno");
            remedios.Rows.Add(2, "morfina");

            // Creamos un DataSet
            DataSet consultorio = new DataSet();
            consultorio.Tables.Add(pacientes);
            consultorio.Tables.Add(remedios);

            // Obtenemos los datos completos
            Console.WriteLine(consultorio.GetXml());



        }
    }
}

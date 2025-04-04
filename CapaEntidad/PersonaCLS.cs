using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PersonaCLS
    {
        //Listado

        public int iidpersona { get; set; }
        public string nombrecompleto { get; set; }
        public string correo { get; set; }
        public string fechanacimientocadena { get; set; }

        //Recuperar
        public string nombre { get; set; }
        public string appaterno { get; set; }
        public string apmaterno { get; set; }
        public DateTime fechanacimiento { get; set; }
        public int Iidsexo { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDesarrollo.Models
{
    public class ListEmpleado
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Posicion { get; set; }

    }
}

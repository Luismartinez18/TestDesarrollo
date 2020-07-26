using System;
using System.Collections.Generic;

namespace TestDesarrollo.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? IdPosicion { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public virtual Posicion IdPosicionNavigation { get; set; }
    }
}

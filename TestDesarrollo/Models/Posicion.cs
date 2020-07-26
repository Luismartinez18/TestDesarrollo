using System;
using System.Collections.Generic;

namespace TestDesarrollo.Models
{
    public partial class Posicion
    {
        public Posicion()
        {
            Empleado = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public string Descrpcion { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}

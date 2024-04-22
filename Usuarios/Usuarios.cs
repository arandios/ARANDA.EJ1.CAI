using System;
using System.Collections.Generic;
using System.Text;

namespace ARANDA.EJ1.CAI
{
    class Usuarios
    {
        List<Usuarios> listaUser = new List<Usuarios>();
        public string Apellido { get; internal set; }
        public string Nombre { get; internal set; }
        public DateTime Nacimiento { get; internal set; }
        public int DNI { get; internal set; }
    }
}

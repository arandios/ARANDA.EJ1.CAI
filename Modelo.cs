using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARANDA.EJ1.CAI
{
    class Modelo
    {
        public void Agregado(Usuarios a)
        {
            List<Usuarios> listaUsarios = new List<Usuarios>();
            listaUsarios.Add(a);
            MessageBox.Show("Usuario agregado exitosamente");

        }

    }
}

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
        List<Usuarios> listaUsarios = new List<Usuarios>();
        public void Agregado(Usuarios a)
        {         
            listaUsarios.Add(a);
            MessageBox.Show("Usuario agregado exitosamente a la lista");
        }

       
    }
}

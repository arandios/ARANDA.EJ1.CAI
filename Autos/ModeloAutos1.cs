using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARANDA.EJ1.CAI
{

    
    internal class ModeloAutos
    {
        List<Auto> autosAgregados = new List<Auto>();  
        internal void Validar(Auto a)
        {
            autosAgregados.Add(a);
            MessageBox.Show("Se ha agregado exitosamente.");
        }
    }
}
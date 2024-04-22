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
    internal class Auto
    {
        public string Marca { get; internal set; }
        public string Modelo { get; internal set; }
        public DateTime Año { get; internal set; }
        public double Precio { get; internal set; }
    }
}
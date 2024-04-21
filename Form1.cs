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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtNacimiento.Text))
            {
                MessageBox.Show("No puede dejar campos sin completar");
                return;
            }

            if (txtNombre.Text.Length > 50)
            {
                MessageBox.Show("Se supero el maximo de 50 caractres por nombre");
                return;
            }

            if (txtApellido.Text.Length > 50)
            {
                MessageBox.Show("Se supero el maximo de 50 caractres por apellido");
                return;
            }

            if (!int.TryParse(txtDNI.Text, out int DNI))
            {
                MessageBox.Show("Debe ingresar un numero de DNI valido de tipo numerico");
                return;
            }

            if (DNI.ToString().Length > 8 || DNI.ToString().Length < 7)
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 digitos");
                return;
            }

            if (!DateTime.TryParse(txtNacimiento.Text, out DateTime fecha))
            {
                MessageBox.Show("La fecha ingresada es invalida");
                return;
            }

            if (fecha > DateTime.Now)
            {
                MessageBox.Show("La fecha debe ser menor a la actual");
                return;
            }

            
            Usuarios a = new Usuarios();
            a.Apellido = txtApellido.Text;
            a.Nombre = txtNombre.Text;
            a.DNI = DNI;
            a.Nacimiento = fecha;
         

            Modelo b = new Modelo();
            b.Agregado(a);


         
        }

       
    }
}

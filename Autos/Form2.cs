using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ARANDA.EJ1.CAI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //muestra la fecha actual cuando se inicia la aplicacion.
            lblFecha.Text = DateTime.Now.ToString();
            // muestra el nombre del usuario.
            lblUsuario.Text = Environment.UserName.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lstMarcas.SelectedItems.Count <= 0)
            {
                // Si no hay elementos seleccionados, mostrar un mensaje al usuario o realizar alguna otra acción
                MessageBox.Show("Por favor, seleccione al menos un elemento en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                MessageBox.Show("Por favor complete el campo del Modelo del auto");
                return;
            }

            if(txtModelo.Text.Length > 30)
            {
                MessageBox.Show("Debe ingresar un modelo con un maximo de 30 caracteres");
                return;
            }

            if (!DateTime.TryParse(txtAño.Text, out DateTime año))
            {
                MessageBox.Show("Por favor ingrese una fecha valida"); return;
            }

            if (año.Year > 2021 || año.Year < 2001)
            {
                MessageBox.Show("El año del auto debe ser entre el 2001 y el 2021"); return;
            }

            if(!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Ingresó un precio invalido."); return;
            }

            ModeloAutos b = new ModeloAutos();
          
            Auto a = new Auto();
           
            a.Marca = lstMarcas.SelectedItem.ToString();
            a.Modelo = txtModelo.Text;
            a.Año = año;
            a.Precio = precio;
           
            b.Validar(a);
            
        }
    }
}

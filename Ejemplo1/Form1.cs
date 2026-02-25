using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            LwElementos.Items.Add(elem);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Amarillo");
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Fucsia");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            DateTime fecha = dtpFechaNacimiento.Value;

            //operador ternario if de una sola linea
            string chocolate = chbTeGusta.Checked == true ? "Le gusta el chocolate. " : "Odia el chocolate. ";

            string tipo;
            if (rbChocolate.Checked)
            {
                tipo = "El helado de chocolate es su preferido ";
                }
            else if (rbDulceDeLeche.Checked)
            {
                tipo = "El helado de dulce de leche es su preferido ";
            }
            else
            {
                tipo = "El helado de frutilla es su preferido ";
            }
            string colorFavorito = cboColorFavorito.SelectedItem.ToString();

            string numeroFavorito = nmrNumeroPreferido.Value.ToString();

            string mensaje = " ." + chocolate + tipo + " .Su color favorito es " + colorFavorito + " .Su número de la suerte es el " + numeroFavorito;

            MessageBox.Show("Nombre: " + nombre + ". Fecha de nacimiento: " + fecha + mensaje);

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //CAMBIO PARA VER
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_veterinaria
{
    public partial class agregar : Form
    {
        public agregar()
        {
            InitializeComponent();
        }

        private void Volvermenu_Click(object sender, EventArgs e)
        {
            menu menuFormulario = new menu();
            menuFormulario.Show();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ventas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClave.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioc.Text) ||
                string.IsNullOrWhiteSpace(txtPreciov.Text))
                {
                MessageBox.Show("Rellena todo");
                return;
            }
            try
            {
                InventarioCompartido.Inventario.Rows.Add(
                    txtClave.Text,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    txtCantidad.Text,
                    txtPrecioc.Text,
                    txtPreciov.Text
                    );

                MessageBox.Show("Producto agregado con exito");
                txtCantidad.Clear();
                txtClave.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtPrecioc.Clear();
                txtPreciov.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inventario inventarioFormulario = new inventario();
            inventarioFormulario.Show();
            this.Hide();
        }
    }
}

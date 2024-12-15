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
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void volvermenu_Click(object sender, EventArgs e)
        {
            menu menuFormulario = new menu();
            menuFormulario.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar extra1Formulario = new agregar();
            extra1Formulario.Show();
            this.Hide();
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            dataGridViewInve.DataSource = InventarioCompartido.Inventario;
            dataGridViewInve.Refresh();

        }

        private void dataGridViewInve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

                }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ventas ventasFormulario = new ventas();
            ventasFormulario.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            agregar agregarFormulario = new agregar();  
            agregarFormulario.Show();
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dataGridViewInve.Refresh();
        }

        private void dataGridViewInve_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inventario_Load_1(object sender, EventArgs e)
        {
            dataGridViewInve.DataSource = InventarioCompartido.Inventario;
        }

        private void volvermenu_Click_1(object sender, EventArgs e)
        {
            menu menuFormulario = new menu();
            menuFormulario.Show();
            this.Close();
        }
    }
}


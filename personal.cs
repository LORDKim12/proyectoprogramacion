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
    public partial class personal : Form
    {
        DataTable agendaTable = new DataTable();
        public personal()
        {
            InitializeComponent();
        }

        private void personal_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = DatosCompartidos.AgendaTable;
            dataGridView1.ReadOnly = true;
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            menu menuFormulario = new menu();
            menuFormulario.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar_Click(sender, e, dataGridView1);
        }

        private void btnEliminar_Click(object sender, EventArgs e, DataGridView dataGridView1)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("¡Estas seguro de borrar esta cita?", "Confirmar eliminacion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("¡Estas seguro de borrar esta cita?", "Confirmar eliminacion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("¡Estas seguro de borrar esta cita?", "Confirmar eliminacion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}

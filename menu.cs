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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agenda agendaFormulario = new agenda();
            agendaFormulario.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) //inventario
        {
            inventario inventarioFormulario = new inventario();
            inventarioFormulario.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm extra2Formulario = new LoginForm();
            extra2Formulario.Show();
            this.Hide();
        }

        private void Bextra1_Click(object sender, EventArgs e)
        {
            ventas ventasFormulario = new ventas();
            ventasFormulario.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

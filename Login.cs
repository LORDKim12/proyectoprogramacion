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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Volvermenu_Click(object sender, EventArgs e)
        {
            menu menuFormulario = new menu();
            menuFormulario.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuarioCorrecto = "A";
            string contraseñaCorrecta = "1";

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
            {
                MessageBox.Show("Bienvenido");
                this.Hide();
                personal personalFormulario = new personal();
                personalFormulario.Show();
            }
            else
            {
                lblMensaje.Text = "Usuario contraseñas incorrectas";
                lblMensaje.ForeColor = Color.Red;


            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class agenda : Form
    {
        public agenda()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Volvermenu_Click(object sender, EventArgs e)
        {
            menu menuFormulario = new menu();
            menuFormulario.Show();
            this.Close();
        }

        private void agenda_Load(object sender, EventArgs e)
        {
            if (DatosCompartidos.AgendaTable.Columns.Count == 0)
            {
                DatosCompartidos.AgendaTable.Columns.Add("Clave", typeof(string));
                DatosCompartidos.AgendaTable.Columns.Add("Dia", typeof(string));
                DatosCompartidos.AgendaTable.Columns.Add("Hora", typeof(string));
                DatosCompartidos.AgendaTable.Columns.Add("Nombre", typeof(string));
                DatosCompartidos.AgendaTable.Columns.Add("Raza", typeof(string));
                DatosCompartidos.AgendaTable.Columns.Add("Edad", typeof(string));
                DatosCompartidos.AgendaTable.Columns.Add("Peso", typeof(string));
                DatosCompartidos.AgendaTable.Columns.Add("Color", typeof(string));
                DatosCompartidos.AgendaTable.Columns.Add("Nombre del dueño", typeof(string));
                DatosCompartidos.AgendaTable.Columns.Add("Telefono", typeof(string));
                DatosCompartidos.AgendaTable.Columns.Add("Direccion", typeof(string));

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String dia = txtDia.Text;
            String hora = txtHora.Text;
            String nombrede = txtNombreDe.Text;
            String clave = txtClave.Text;
            String edad = textEdad.Text;
            String peso = textPeso.Text;
            String color = textColor.Text;
            String nombre = textMas.Text;
            String telefono = textTelefono.Text;
            String direccion = textDireccion.Text;
            String raza = textRaza.Text;


            if (String.IsNullOrWhiteSpace(clave) || String.IsNullOrWhiteSpace(dia) || String.IsNullOrWhiteSpace(hora) || String.IsNullOrWhiteSpace(nombre) || String.IsNullOrWhiteSpace(raza) || String.IsNullOrWhiteSpace(edad) || String.IsNullOrWhiteSpace(peso) || String.IsNullOrWhiteSpace(color) || String.IsNullOrWhiteSpace(nombrede) || String.IsNullOrWhiteSpace(telefono) || String.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Campos vacios detectados");
                return;
            }
            DatosCompartidos.AgendaTable.Rows.Add(dia, hora, nombre, clave, nombrede, edad, peso, color, telefono, direccion, raza);
            txtDia.Clear();
            txtHora.Clear();
            txtNombreDe.Clear();
            txtClave.Clear();
            textEdad.Clear();
            textColor.Clear();
            textMas.Clear();
            textTelefono.Clear();
            textDireccion.Clear();
            textRaza.Clear();
            textPeso.Clear();   

            MessageBox.Show("Cliente agendado con exito");


        }

     
    }
}

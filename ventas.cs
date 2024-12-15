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
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
        }
        private List<ProductoCompra> listaCompras = new List<ProductoCompra>();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string claveBuscada = txtClave.Text;

            if (string.IsNullOrWhiteSpace(claveBuscada))
            {
                MessageBox.Show("No se encontro el producto");
                return;

            }
            DataRow[] filas = InventarioCompartido.Inventario.Select($"Clave = '{claveBuscada}'");

            if (filas.Length > 0)
            {
                txtProducto.Text = filas[0]["Producto"].ToString();
                txtCantidad.Text = filas[0]["Cantidad"].ToString();
                txtPrecio.Text = filas[0]["Precio"].ToString();

            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtClave.Text) ||
                string.IsNullOrWhiteSpace(txtProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string claveBuscada = txtClave.Text;
            DataRow[] filas = InventarioCompartido.Inventario.Select($"Clave = '{claveBuscada}'");

            if (filas.Length == 0)
            {
                MessageBox.Show("El producto no se encuentra en el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow productoRow = filas[0];
            ProductoCompra producto = new ProductoCompra
            {
                Clave = productoRow["Clave"].ToString(),
                Producto = productoRow["Producto"].ToString(),
                Precio = Convert.ToDecimal(productoRow["Precio"]),
                Cantidad = int.Parse(txtCantidad.Text),
                Subtotal = int.Parse(txtCantidad.Text) * Convert.ToDecimal(productoRow["Precio"])
            };

            listaCompras.Add(producto);

            ActualizarListaCompras();

            MessageBox.Show("Producto agregado a la lista de compras.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtClave.Clear();
            txtProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarListaCompras()
        {
            if (listaCompras.Count > 0)
            {
                DataTable tablaCompras = new DataTable();

                tablaCompras.Columns.Add("Clave", typeof(string));
                tablaCompras.Columns.Add("Producto", typeof(string));
                tablaCompras.Columns.Add("Cantidad", typeof(int));
                tablaCompras.Columns.Add("Precio Venta", typeof(decimal));
                tablaCompras.Columns.Add("Subtotal", typeof(decimal));


                foreach (var producto in listaCompras)
                {
                    DataRow row = tablaCompras.NewRow();
                    row["Clave"] = producto.Clave;
                    row["Producto"] = producto.Producto;
                    row["Cantidad"] = producto.Cantidad;
                    row["Precio Venta"] = producto.Precio;
                    row["Subtotal"] = producto.Subtotal;



                    tablaCompras.Rows.Add(row);
                }

                dataGridViewCompras.DataSource = tablaCompras;
            }
            decimal subtotalTotal = listaCompras.Sum(p => p.Subtotal);
            txtTotal.Text = subtotalTotal.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaCompras.Count == 0)
            {
                MessageBox.Show("No hay productos en la lista de compras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var producto in listaCompras)
            {
                string clave = producto.Clave;
                int cantidadComprada = producto.Cantidad;

                DataRow[] filas = InventarioCompartido.Inventario.Select($"Clave = '{clave}'");
                if (filas.Length > 0)
                {
                    int cantidadActual = 0;
                    if (filas[0]["Cantidad"] != DBNull.Value)
                    {
                        cantidadActual = Convert.ToInt32(filas[0]["Cantidad"]);
                    }

                    filas[0]["Cantidad"] = cantidadActual - cantidadComprada;
                }
            }

            listaCompras.Clear();
            dataGridViewCompras.DataSource = null;

            MessageBox.Show($"Compra finalizada. \nSu total es: {txtTotal.Text}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTotal.Clear();
        }

        private void btnInve_Click(object sender, EventArgs e)
        {
            inventario inventarioFormulario = new inventario();
            inventarioFormulario.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menu menuFormulario = new menu();
            menuFormulario.Show();
            this.Hide();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_veterinaria
{
    public static class InventarioCompartido 
    {

        public static DataTable Inventario = new DataTable();
        
        static InventarioCompartido()
        {
            Inventario.Columns.Add("Clave", typeof(string));
            Inventario.Columns.Add("Producto", typeof(string));
            Inventario.Columns.Add("Descripcion", typeof(string));
            Inventario.Columns.Add("Cantidad", typeof(string));
            Inventario.Columns.Add("Precio de compra", typeof(string));
            Inventario.Columns.Add("Precio", typeof(string));

        }
    }
}

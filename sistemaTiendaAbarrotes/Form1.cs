using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaTiendaAbarrotes
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        Producto producto;
        Compra compra;
        DetalleCompra detalleCompra;

        public Form1()
        {
            InitializeComponent();
            conectar();

            producto = new Producto(conexion, tbNombreProducto, tbExistenciasProducto, tbCostoProvProducto, tbCostoVentaProducto, dtProducto);
            compra = new Compra(conexion, cbEmpleadoCompras, cbProveedorCompras, dateCompras, tbTotalCompras, dtCompras);
            detalleCompra = new DetalleCompra(conexion, cbCompraDetalleCom, cbProductoDetalleCom, tbCantidadDetalleCom, tbSubtotalDetalleCom, dtDetalleCom);
        }

        private void conectar()
        {
            string connectionString = null;
            //Cadena de conexión
            connectionString = "Server=LAPTOP-R32V8BCP\\SQLEXPRESS; Database = TiendaAbarrotes; Trusted_Connection = true;";

            conexion = new SqlConnection(connectionString);
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar");
            }
        }

        private void tabProducto_Click(object sender, EventArgs e)
        {
           
        }

        private void dtProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto.colocaProducto();
        }

        private void btInsertarProducto_Click(object sender, EventArgs e)
        {
            producto.insertarProducto();
        }

        private void btActualizarProducto_Click(object sender, EventArgs e)
        {
            producto.modificarProducto();
        }

        private void btEliminarProducto_Click(object sender, EventArgs e)
        {
            producto.eliminarProducto();
        }

        private void btInsertarCompras_Click(object sender, EventArgs e)
        {
            compra.insertarCompra();
        }

        private void btActualizarCompras_Click(object sender, EventArgs e)
        {
            compra.modificarCompra();
        }

        private void btEliminarCompras_Click(object sender, EventArgs e)
        {
            compra.eliminarCompra();
        }

        private void dtCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            compra.colocaCompra();
        }

        private void dtDetalleCom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detalleCompra.colocaDetalleCompra(dtDetalleCom.CurrentRow.Index);
        }

        private void btInsertarDetalleCom_Click(object sender, EventArgs e)
        {
            detalleCompra.insertarDetalleCompra();
        }

        private void btActualizarDetalleCom_Click(object sender, EventArgs e)
        {
            detalleCompra.modificarDetalleCompra();
        }
    }
}

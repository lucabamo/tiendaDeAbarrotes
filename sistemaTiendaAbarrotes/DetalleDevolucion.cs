using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaTiendaAbarrotes
{
    class DetalleDevolucion
    {
        SqlConnection conexion;
        DataTable tablaDevolucion;
        DataTable tablaDevolucionPura;
        string IdDevolucion;
        ComboBox cbIdDevolucionI = new ComboBox();
        ComboBox cbIdProductoI = new ComboBox();
        TextBox tbCantindadI = new TextBox();
        string IdDevolucionReal = "";


        public DetalleDevolucion (SqlConnection conexion, ComboBox cbIdDevolucion, ComboBox cbIdProducto, TextBox tbCantidad) {
            this.conexion = conexion;
            cbIdDevolucionI = cbIdDevolucion;
            cbIdProductoI = cbIdProducto;
            tbCantindadI = tbCantidad;
            tablaDevolucion = new DataTable();
            tablaDevolucionPura = new DataTable();
            IdDevolucion = "";
        }
        public void Consulta(DataGridView dGDetalleDevoluciones) {
            tablaDevolucion.Clear();
            tablaDevolucionPura.Clear();
            string consulta = "SELECT Devolucion.Motivo, Producto.Nombre, DetalleVenta.Cantidad " +
                "FROM Transaccion.DetalleDevolucion AS DetalleDevolucion " +
                "INNER JOIN Transaccion.Devolucion Devolucion ON Devolucion.IdDevolucion = DetalleDevolucion.IdDevolucion " +
                "INNER JOIN Transaccion.DetalleVenta AS DetalleVenta ON Devolucion.IdVenta = DetalleVenta.IdVenta " +
                "INNER JOIN Inventario.Producto AS Producto ON Producto.IdProducto = DetalleVenta.IdProducto";

            string consulta2 = "SELECT * FROM Transaccion.DetalleDevolucion";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlCommand comando2 = new SqlCommand(consulta2, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            // DataTable tabla = new DataTable();
            adaptador.Fill(tablaDevolucion);

            adaptador = new SqlDataAdapter(comando2);

            adaptador.Fill(tablaDevolucionPura); 

            dGDetalleDevoluciones.DataSource = tablaDevolucion;

            llenaMotivoDevoluciones(cbIdDevolucionI);
            llenaProductos(cbIdProductoI);
        }

        public string accesoIdDevolucion {
            get { return IdDevolucion; }
            set { IdDevolucion = value; }
        }


        /// <summary>
        /// Método para cargar los datos de un registro en el formulario,
        /// que ha sido seleccionado desde el DataGridView
        /// </summary>
        public void cargaRegistroSeleccionado()
        {
            string consulta = "SELECT detalle.IdDevolucion FROM Transaccion.DetalleDevolucion AS detalle " +
                "INNER JOIN Transaccion.Devolucion AS devolucion ON devolucion.IdDevolucion = detalle.IdDevolucion " +
                "WHERE devolucion.Motivo = " + "\'" + accesoIdDevolucion + "\' ";
            using (var command = new SqlCommand(consulta, conexion))
            {
                DataTable tablaAux = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaAux.Load(reader);
                    var am = tablaAux.Rows[0];
                    IdDevolucionReal = am.ItemArray[0].ToString();
                }
            }
            DataRow[] tuplaSeleccionada = tablaDevolucionPura.Select("[IdDevolucion] = " + IdDevolucionReal);

            //Una vez seleccionada la tupla buscamos cada uno de los atributos
            var Motivo = tuplaSeleccionada[0].ItemArray[0];
            var Producto = tuplaSeleccionada[0].ItemArray[1];
            var Cantidad = tuplaSeleccionada[0].ItemArray[2];

            cbIdDevolucionI.SelectedValue = Motivo;
            cbIdProductoI.SelectedValue = Producto;
            tbCantindadI.Text = Cantidad.ToString();
        }

        private void llenaMotivoDevoluciones(ComboBox cbMotivoDevolucion)
        {

            string consultaDevoluciones = "SELECT IdDevolucion,Motivo FROM Transaccion.Devolucion";

            using (var command = new SqlCommand(consultaDevoluciones, conexion))
            {
                DataTable tablaDevoluciones = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaDevoluciones.Load(reader);
                    cbMotivoDevolucion.ValueMember = "IdDevolucion";
                    cbMotivoDevolucion.DisplayMember = "Motivo";
                    cbMotivoDevolucion.DataSource = tablaDevoluciones;
                }
            }
            cbMotivoDevolucion.Text = "";
            cbMotivoDevolucion.SelectedIndex = -1;
        }

        private void llenaProductos(ComboBox cbProductos)
        {
            /*string consultaProductos = "SELECT producto.IdProducto, producto.Nombre FROM Inventario.Producto AS producto " +
               "INNER JOIN Transaccion.DetalleDevolucion AS detalle ON detalle.IdProducto = producto.IdProducto " +
               "INNER JOIN Transaccion.Devolucion AS devolucion ON devolucion.IdDevolucion = detalle.IdDevolucion " +
               "INNER JOIN Transaccion.DetalleVenta AS detalleVenta ON detalleVenta.IdVenta = devolucion.IdVenta" +
               "WHERE devolucion.IdDevolucion = " + IdDevolucionReal;*/
            string consultaProductos = "SELECT IdProducto, Nombre FROM Inventario.Producto";

            using (var command = new SqlCommand(consultaProductos, conexion))
            {
                DataTable tablaProductos = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaProductos.Load(reader);
                    cbProductos.ValueMember = "IdProducto";
                    cbProductos.DisplayMember = "Nombre";
                    cbProductos.DataSource = tablaProductos;
                }
            }
            cbProductos.Text = "";
            cbProductos.SelectedIndex = -1;
        }
    }
}

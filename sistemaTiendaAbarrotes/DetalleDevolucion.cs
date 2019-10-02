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
        string IdDevolucion;
        ComboBox cbIdDevolucionI = new ComboBox();
        ComboBox cbIdProductoI = new ComboBox();
        TextBox tbCantindadI = new TextBox();

        public DetalleDevolucion (SqlConnection conexion, ComboBox cbIdDevolucion, ComboBox cbIdProducto, TextBox tbCantidad) {
            this.conexion = conexion;
            cbIdDevolucionI = cbIdDevolucion;
            cbIdProductoI = cbIdProducto;
            tbCantindadI = tbCantidad;
            tablaDevolucion = new DataTable();
            IdDevolucion = "";
        }
        public void Consulta(DataGridView dGDetalleDevoluciones) {
            string consulta = "SELECT Devolucion.Motivo, Producto.Nombre, DetalleVenta.Cantidad " +
                "FROM Transaccion.DetalleDevolucion AS DetalleDevolucion " +
                "INNER JOIN Transaccion.Devolucion Devolucion ON Devolucion.IdDevolucion = DetalleDevolucion.IdDevolucion " +
                "INNER JOIN Transaccion.DetalleVenta AS DetalleVenta ON Devolucion.IdVenta = DetalleVenta.IdVenta " +
                "INNER JOIN Inventario.Producto AS Producto ON Producto.IdProducto = DetalleVenta.IdProducto";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
           // DataTable tabla = new DataTable();
            adaptador.Fill(tablaDevolucion);   
            dGDetalleDevoluciones.DataSource = tablaDevolucion;
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
            //Se toma la tupla seleccionada buscando dentro de la tablaEntrega con un Select buscando en el atributo
            //[IdEntrega]
            DataRow[] tuplaSeleccionada = tablaDevolucion.Select("[IdDevolucion] = " + accesoIdDevolucion);

            //Una vez seleccionada la tupla buscamos cada uno de los atributos
            var Motivo = tuplaSeleccionada[0].ItemArray[0];
            var Producto = tuplaSeleccionada[0].ItemArray[1];
            var Cantidad = tuplaSeleccionada[0].ItemArray[2];

            cbIdDevolucionI.SelectedValue = Motivo;
            cbIdProductoI.SelectedValue = Motivo;
            tbCantindadI.Text = Cantidad.ToString();
        }


    }
}

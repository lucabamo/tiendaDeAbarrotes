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
    // Clase para las operaciones de detalle devolucion
    class DetalleDevolucion
    {
        // Variables
        SqlConnection conexion;
        DataTable tablaDevolucion;
        DataTable tablaDevolucionPura;
        string IdDevolucion;
        ComboBox cbIdDevolucionI = new ComboBox();
        ComboBox cbIdProductoI = new ComboBox();
        TextBox tbCantindadI = new TextBox();
        string IdDevolucionReal = "";
        string IdDetalleDevolucionSeleccionada = "";
        string numeroMaximoDeProductosADevolver;

        // Constructor de la clase, recibe como parametro los controles y la conexion
        public DetalleDevolucion (SqlConnection conexion, ComboBox cbIdDevolucion, ComboBox cbIdProducto, TextBox tbCantidad) {
            this.conexion = conexion;
            cbIdDevolucionI = cbIdDevolucion;
            cbIdProductoI = cbIdProducto;
            tbCantindadI = tbCantidad;
            tablaDevolucion = new DataTable();
            tablaDevolucionPura = new DataTable();
            IdDevolucion = "";
            numeroMaximoDeProductosADevolver = "";
        }


        // Regresa el Id de el detalle devolucion que esta seleccionado 
        public string AccesoIdDetalleDevolucionSeleccionada
        {
            get { return IdDetalleDevolucionSeleccionada; }
            set { IdDetalleDevolucionSeleccionada = value; }
        }


        // Regresa el numero de productos que se pueden devolver
        public string accesoNumeroMaximoADevolver
        {
            get { return numeroMaximoDeProductosADevolver; }
            set { numeroMaximoDeProductosADevolver = value; }
        }

        // Metodo para llenar la tabla con los detalles de devolucion existentes
        public void Consulta(DataGridView dGDetalleDevoluciones) {
            // Limpia las tablas
            tablaDevolucion.Clear();
            tablaDevolucionPura.Clear();

            // Genera una consulta para combinar las tablas Detalle Devolucion, Devolucion y Producto
            string consulta = "SELECT DetalleDevolucion.IdDetalleDevolucion AS Id,Devolucion.Motivo, Producto.Nombre," +
                "DetalleDevolucion.Cantidad FROM Transaccion.DetalleDevolucion AS DetalleDevolucion " +
                "INNER JOIN Transaccion.Devolucion Devolucion ON Devolucion.IdDevolucion = DetalleDevolucion.IdDevolucion " +
                "INNER JOIN Inventario.Producto AS Producto ON Producto.IdProducto = DetalleDevolucion.IdProducto " +
                "ORDER BY DetalleDevolucion.IdDetalleDevolucion";

            // Consulta todos los detalles devolucion
            string consulta2 = "SELECT * FROM Transaccion.DetalleDevolucion";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlCommand comando2 = new SqlCommand(consulta2, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            // DataTable tabla = new DataTable();
            adaptador.Fill(tablaDevolucion);

            adaptador = new SqlDataAdapter(comando2);

            adaptador.Fill(tablaDevolucionPura); 

            dGDetalleDevoluciones.DataSource = tablaDevolucion;

            // Llena los motivos de la devolucion
            llenaMotivoDevoluciones(cbIdDevolucionI);
           // llenaProductos(cbIdProductoI);
        }

        // Regresa el Id de la devolucion a la que pertenece
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

            DataRow[] tuplaSeleccionada = tablaDevolucionPura.Select("[IdDetalleDevolucion] = " + IdDetalleDevolucionSeleccionada);

            //Una vez seleccionada la tupla buscamos cada uno de los atributos
            var Motivo = tuplaSeleccionada[0].ItemArray[1];
            var Producto = tuplaSeleccionada[0].ItemArray[2];
            var Cantidad = tuplaSeleccionada[0].ItemArray[3];

            cbIdDevolucionI.SelectedValue = Motivo;
            cbIdProductoI.SelectedValue = Producto;
            tbCantindadI.Text = Cantidad.ToString();
        }

        /// <summary>
        /// Método para insertar una tupla de la tabla Entrega
        /// </summary>
        public void Inserta()
        {
            try
            {
                //DataRowView es el tipo de dato para leer una tupla que se inserto en algún lugar con anterioridad
                DataRowView Devolucion = (DataRowView)cbIdDevolucionI.SelectedItem;
                DataRowView Producto = (DataRowView)cbIdProductoI.SelectedItem;
                Int64 IdDevolucion = (Int64)Devolucion.Row.ItemArray[0]; ;
                Int64 IdProducto = (Int64)Producto.Row.ItemArray[0]; ;
                var Cantidad = tbCantindadI.Text;
                string query = "";
                query = "INSERT INTO Transaccion.DetalleDevolucion (IdDevolucion, IdProducto, Cantidad) " +
                        "VALUES (@IdDevolucion, @IdProducto,@Cantidad)";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdDevolucion", IdDevolucion);
                comando.Parameters.AddWithValue("@IdProducto", IdProducto);
                comando.Parameters.AddWithValue("@Cantidad", Cantidad);
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Inserción correcta");
                    limpiaFormulario();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hubo un error en la inserción");
                }
                limpiaFormulario();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Todos los campos son necesarios");
            }
        }


        // Metodo para modificar una tupla de detalle devolucion
        public void Edita()
        {
            try
            {
                //DataRowView es el tipo de dato para leer una tupla que se inserto en algún lugar con anterioridad
                DataRowView Devolucion = (DataRowView)cbIdDevolucionI.SelectedItem;
                DataRowView Producto = (DataRowView)cbIdProductoI.SelectedItem;
                Int64 IdDevolucion = (Int64)Devolucion.Row.ItemArray[0]; 
                Int64 IdProducto = (Int64)Producto.Row.ItemArray[0]; 
                var Cantidad = tbCantindadI.Text;
                string queryEdita = "UPDATE Transaccion.DetalleDevolucion SET IdDevolucion = @IdDevolucion, " +
                    "IdProducto = @IdProducto, Cantidad = @Cantidad " +
                    "WHERE IdDetalleDevolucion = " + IdDetalleDevolucionSeleccionada;

                // Manda la instruccion a la base de datos
                SqlCommand comando = new SqlCommand(queryEdita, conexion);
                comando.Parameters.AddWithValue("@IdDevolucion", IdDevolucion);
                comando.Parameters.AddWithValue("@IdProducto", IdProducto);
                comando.Parameters.AddWithValue("@Cantidad", Cantidad);
                try
                {
                    // Ejecuta la sentencia SQL
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Edición correcta");
                    limpiaFormulario();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hubo un error en la edición");
                }
                limpiaFormulario();
            }
            catch (Exception exception)
            {
                // Manda mensaje si algun campo esta vacio
                MessageBox.Show("Todos los campos son necesarios");
            }
        }

        /// <summary>
        /// Método para la eliminación de un registro que ha sido seleccionado.
        /// </summary>
        public void eliminaRegistroSeleccionado()
        {
            if (IdDetalleDevolucionSeleccionada != "")
            {
                // Genera la consulta SQL
                string queryElimina = "DELETE FROM Transaccion.DetalleDevolucion WHERE IdDetalleDevolucion = " +
                    "" + IdDetalleDevolucionSeleccionada;
                SqlCommand comando = new SqlCommand(queryElimina, conexion);
                try
                {
                    // Ejecuta la instruccion
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Eliminación exitosa");
                    limpiaFormulario();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR" + e.Message);

                }
            }
            else
            {
                // Manda mensaje si ninguna tupla se ha seleccionado
                MessageBox.Show("Es necesario seleccionar un registro para eliminar");
            }

        }


        // Metodo para consultar la cantidad de productos que se hicieron en una compra
        // para saber la cantidad max a devolver
        public bool cantidadDeProductosComprados()
        {
            // Obtiene los datos seleccionados
            DataRowView Devolucion = (DataRowView)cbIdDevolucionI.SelectedItem;
            DataRowView Producto = (DataRowView)cbIdProductoI.SelectedItem;
            Int64 IdDevolucion = (Int64)Devolucion.Row.ItemArray[0];
            Int64 IdProducto = (Int64)Producto.Row.ItemArray[0];

            // Genera la consulta SQL
            string consulta = "SELECT DISTINCT detalleventa.Cantidad " +
                "FROM Inventario.Producto AS producto " +
                "INNER JOIN Transaccion.DetalleVenta AS detalleventa ON detalleventa.IdProducto = producto.IdProducto " +
                "INNER JOIN Transaccion.Devolucion AS devolucion ON devolucion.IdVenta = detalleventa.IdVenta " +
                "WHERE devolucion.IdDevolucion = " + IdDevolucion + " AND " + "producto.IdProducto = " + IdProducto;

            // Despliega los datos en una tabla auxiliar
            using (var command = new SqlCommand(consulta, conexion))
            {
                DataTable tablaAux = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaAux.Load(reader);
                    var cantidadDeProductos = tablaAux.Rows[0];
                    accesoNumeroMaximoADevolver = cantidadDeProductos.ItemArray[0].ToString();
                }
            }

            //Número menor a 0
            if (Convert.ToInt32(tbCantindadI.Text) < 0)
            {
                return false;
            }
            //Número a devolver mayor a los que se compraron, no es válido
            else if (Convert.ToInt32(tbCantindadI.Text) > Convert.ToInt32(accesoNumeroMaximoADevolver))
            {
                return false;
            }
            else if (Convert.ToInt32(tbCantindadI.Text) <= Convert.ToInt32(accesoNumeroMaximoADevolver))
            {
                return true;
            }
            else {
                return false;
            }
        }


        // Metodo que llena el combo box de los motivos de devolucion
        private void llenaMotivoDevoluciones(ComboBox cbMotivoDevolucion)
        {
            // Genera la consulta SQL
            string consultaDevoluciones = "SELECT IdDevolucion,Motivo FROM Transaccion.Devolucion";

            // Despliega el motivo de devolucion y guarda su Id para el manejo interno
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

            // Limpia el valor seleccionado
            cbMotivoDevolucion.Text = "";
            cbMotivoDevolucion.SelectedIndex = -1;
        }

        /// <summary>
        /// Método para que se muestren los productos de la venta con los que la devolución se relaciona
        /// </summary>
        /// <param name="cbProductos"></param>
        public void llenaProductos(ComboBox cbProductos)
        {
            DataRowView Devolucion = (DataRowView)cbIdDevolucionI.SelectedItem;
            Int64 IdDevolucion = (Int64)Devolucion.Row.ItemArray[0];

            // Genera la instruccion SQL
            string consultaProductos = "SELECT DISTINCT producto.IdProducto, producto.Nombre " +
            "FROM Inventario.Producto AS producto " +
            "INNER JOIN Transaccion.DetalleVenta AS detalleventa ON detalleventa.IdProducto = producto.IdProducto " +
            "INNER JOIN Transaccion.Devolucion AS devolucion ON devolucion.IdVenta = detalleventa.IdVenta " +
            "WHERE devolucion.IdDevolucion = " + IdDevolucion +
            " ORDER BY producto.IdProducto";

            // Despliega el nombre de los productos y guarda su Id para el manejo interno
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

            // Limpia el elemento seleccionado
            cbProductos.Text = "";
            cbProductos.SelectedIndex = -1;
        }

        public void calculaMaximoDevolucion() {

        }

        /// <summary>
        /// Método para limpiar el formulario donde se reciben los datos de una entrega
        /// </summary>
        private void limpiaFormulario()
        {
            cbIdDevolucionI.Text = "";
            cbIdDevolucionI.SelectedIndex = -1;
            cbIdProductoI.Text = "";
            cbIdProductoI.SelectedIndex = -1;
            tbCantindadI.Text = "";
            tbCantindadI.Enabled = false;
        }
    }
}

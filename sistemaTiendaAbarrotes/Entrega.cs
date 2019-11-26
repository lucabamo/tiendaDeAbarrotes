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
    class Entrega
    {
        SqlConnection conexion;
        DataTable tablaEntrega;
        DataTable tablaEntregaPura; //Donde no se muestran nombres si no IDs
        string IdEntregaSeleccionada;
        ComboBox cbIdProveedorI;
        ComboBox cbIdDevolucionI;
        ComboBox cbIdEmpleadoI;
        DateTimePicker dtFechaEntregaI;

        public Entrega(SqlConnection conexion, ComboBox cbIdProveedor, ComboBox cbIdDevolucion, 
            ComboBox cbIdEmpleado, DateTimePicker dtFechaEntrega) {
            this.conexion = conexion;
            tablaEntrega = new DataTable();
            tablaEntregaPura = new DataTable();
            this.cbIdProveedorI = cbIdProveedor;
            this.cbIdDevolucionI = cbIdDevolucion;
            this.cbIdEmpleadoI = cbIdEmpleado;
            this.dtFechaEntregaI = dtFechaEntrega;
            IdEntregaSeleccionada = "";
        }

        public string AccesoIdEntregaSeleccionada {
            get { return IdEntregaSeleccionada; }
            set { IdEntregaSeleccionada = value; }
        }

        public void Consulta(DataGridView dGEntrega)
        {
            tablaEntrega.Clear();
            tablaEntregaPura.Clear();
            string consulta = "SELECT IdEntrega,Proveedor.Nombre AS Nombre_Proveedor," +
                "Empleado.Nombre AS Nombre_Empleado, Devolucion.Motivo AS Motivo_Devolución, " +
                "FechaEntrega FROM Transaccion.Entrega Entrega " +
                "INNER JOIN Empresa.Proveedor Proveedor ON Entrega.IdProveedor = Proveedor.IdProveedor " +
                "INNER JOIN Transaccion.Devolucion Devolucion ON Entrega.IdDevolucion = Devolucion.IdDevolucion " +
                "INNER JOIN Empresa.Empleado Empleado ON Entrega.IdEmpleado = Empleado.IdEmpleado";
            string consultaDos = "SELECT * FROM Transaccion.Entrega";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tablaEntrega);
            comando = new SqlCommand(consultaDos, conexion);
            adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tablaEntregaPura);
            dGEntrega.DataSource = tablaEntrega;
            llenaComboBox();
        }

        private void llenaComboBox() {
            try {
                llenaNombreProveedor(cbIdProveedorI);
                llenaMotivosDevolucion(cbIdDevolucionI);
                llenaNombreEmpleado(cbIdEmpleadoI);
            }
            catch (Exception e) {

            }    
        }

        private void llenaMotivosDevolucion(ComboBox cbDevoluciones) {
            string consultaDevoluciones = "SELECT IdDevolucion, Motivo FROM Transaccion.Devolucion WHERE Entregada = 0";
            using (var command = new SqlCommand(consultaDevoluciones, conexion))
            {
                DataTable tablaDevolucion = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaDevolucion.Load(reader);
                    cbDevoluciones.ValueMember = "IdDevolucion";
                    cbDevoluciones.DisplayMember = "Motivo";
                    cbDevoluciones.DataSource = tablaDevolucion;       
                }
            }
            cbDevoluciones.Text = "";
            cbDevoluciones.SelectedIndex = -1;
        }
   
        private void llenaNombreProveedor(ComboBox cbProveedores) {

            string consultaProveedores = "SELECT IdProveedor,Nombre FROM Empresa.Proveedor";

            using (var command = new SqlCommand(consultaProveedores, conexion))
            {
                DataTable tablaProveedor = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaProveedor.Load(reader);
                    cbProveedores.ValueMember = "IdProveedor";
                    cbProveedores.DisplayMember = "Nombre";
                    cbProveedores.DataSource = tablaProveedor;
                }
            }
            cbProveedores.Text = "";
            cbProveedores.SelectedIndex = -1;
        }

        private void llenaNombreEmpleado(ComboBox cbEmpleados)
        {
            string consultaEmpleados = "SELECT IdEmpleado,Nombre FROM Empresa.Empleado";
            using (var command = new SqlCommand(consultaEmpleados, conexion))
            {
                DataTable tablaEmpleado = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaEmpleado.Load(reader);
                    cbEmpleados.ValueMember = "IdEmpleado";
                    cbEmpleados.DisplayMember = "Nombre";
                    cbEmpleados.DataSource = tablaEmpleado;
                }
            }
            cbEmpleados.Text = "";
            cbEmpleados.SelectedIndex = -1;
        }
      
        /// <summary>
        /// Método para insertar una tupla de la tabla Entrega
        /// </summary>
        public void Inserta()
        {
            try
            {
                //DataRowView es el tipo de dato para leer una tupla que se inserto en algún lugar con anterioridad
                DataRowView Proveedor = (DataRowView)cbIdProveedorI.SelectedItem; 
                DataRowView Devolucion = (DataRowView)cbIdDevolucionI.SelectedItem;
                DataRowView Empleado = (DataRowView)cbIdEmpleadoI.SelectedItem;
                Int64 IdProveedor = (Int64)Proveedor.Row.ItemArray[0]; //Nuestro elemento de la posición 0 es el ID
                Int64 IdDevolucion = (Int64)Devolucion.Row.ItemArray[0]; ;
                Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; ;
                DateTime FechaEntrega = dtFechaEntregaI.Value.Date;
                string query = "";
                query = "INSERT INTO Transaccion.Entrega (IdProveedor, IdDevolucion, IdEmpleado, FechaEntrega) " +
                        "VALUES (@IdProveedor, @IdDevolucion,@IdEmpleado,@FechaEntrega)";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                comando.Parameters.AddWithValue("@IdDevolucion", IdDevolucion);
                comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@FechaEntrega", FechaEntrega);
                try
                {
                    comando.ExecuteNonQuery();
                    obtenProductosEntrega(obtenUltimaEntrega());
                    MessageBox.Show("Inserción correcta");
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

        private Int64 obtenUltimaEntrega() {

            Int64 id = 0;

            string query = "";
            query = "SELECT TOP 1 IdEntrega FROM Transaccion.Entrega ORDER BY IdEntrega DESC";
            SqlCommand comando = new SqlCommand(query, conexion);

            object result = comando.ExecuteScalar();
            if (result != null) {
                id = (Int64)result;
            }
            return id;
        }

        private void obtenProductosEntrega(Int64 idEntrega) {

            DataTable tablaProductos;

            tablaProductos = new DataTable();

            string consulta = "SELECT producto.IdProducto, producto.Existencia, detalle.Cantidad, entrega.IdEntrega FROM Inventario.Producto AS producto " +
                "INNER JOIN Transaccion.DetalleDevolucion AS detalle ON detalle.IdProducto = producto.IdProducto " +
                "INNER JOIN Transaccion.Entrega AS entrega ON entrega.IdDevolucion = detalle.IdDevolucion " +
                "AND entrega.IdEntrega = @IdEntrega";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@IdEntrega", idEntrega);


            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tablaProductos);

            DataRow[] dr = tablaProductos.Select("IdEntrega = " + idEntrega.ToString());

            foreach (DataRow row in dr)
            {
                Int64 idproducto = row.Field<Int64>("IdProducto");
                int existencia = row.Field<int>("Existencia");
                int cantidadDevueltos = row.Field<int>("Cantidad");
                int existenciaActual = existencia - cantidadDevueltos;
                actualizaProducto(idproducto, existenciaActual);
            }

        }

        private void actualizaProducto(Int64 idProd, int existencia) {
            string query = "UPDATE Inventario.Producto SET Existencia = @existencia WHERE IdProducto = @idProd ";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@existencia", existencia);
            comando.Parameters.AddWithValue("@idProd", idProd);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la modificación del producto");
            }

        }

        /// <summary>
        /// Método para la eliminación de un registro que ha sido seleccionado.
        /// </summary>
        public void eliminaRegistroSeleccionado() {
            if (IdEntregaSeleccionada != "")
            {
                string queryElimina = "DELETE FROM Transaccion.Entrega WHERE IdEntrega = " + IdEntregaSeleccionada;
                SqlCommand comando = new SqlCommand(queryElimina, conexion);
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Eliminación exitosa");
                    limpiaFormulario();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR" + e.Message);

                }
            }
            else {
                MessageBox.Show("Es necesario seleccionar un registro para eliminar");
            }

        }

        /// <summary>
        /// Método para editar un registro que ha sido cargado dentro del formulario
        /// </summary>
        public void editaRegistroSeleccionado() {
            try {
                //DataRowView es el tipo de dato para leer una tupla que se inserto en algún lugar con anterioridad
                DataRowView Proveedor = (DataRowView)cbIdProveedorI.SelectedItem;
                DataRowView Devolucion = (DataRowView)cbIdDevolucionI.SelectedItem;
                DataRowView Empleado = (DataRowView)cbIdEmpleadoI.SelectedItem;
                Int64 IdProveedor = (Int64)Proveedor.Row.ItemArray[0]; //Nuestro elemento de la posición 0 es el ID
                Int64 IdDevolucion = (Int64)Devolucion.Row.ItemArray[0]; ;
                Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; ;
                DateTime FechaEntrega = dtFechaEntregaI.Value.Date;

                string queryEdita = "UPDATE Transaccion.Entrega SET IdProveedor = @IdProveedor, " +
                    "IdDevolucion = @IdDevolucion, IdEmpleado = @IdEmpleado, FechaEntrega = @FechaEntrega " +
                    "WHERE IdEntrega = " + IdEntregaSeleccionada;

                SqlCommand comando = new SqlCommand(queryEdita, conexion);

                comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                comando.Parameters.AddWithValue("@IdDevolucion", IdDevolucion);
                comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@FechaEntrega", FechaEntrega);
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Edición correcta");
                    limpiaFormulario();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hubo un error en la edición");
                }
            }
            catch (Exception e) 
                {
                MessageBox.Show("Todos los campos son necesarios");
            }

        }


        /// <summary>
        /// Método para cargar los datos de un registro en el formulario,
        /// que ha sido seleccionado desde el DataGridView
        /// </summary>
        public void cargaRegistroSeleccionado()
        {
            //Se toma la tupla seleccionada buscando dentro de la tablaEntrega con un Select buscando en el atributo
            //[IdEntrega]
            DataRow[] tuplaSeleccionada = tablaEntregaPura.Select("[IdEntrega] = " + IdEntregaSeleccionada);

            //Una vez seleccionada la tupla buscamos cada uno de los atributos
            var IdProveedor = tuplaSeleccionada[0].ItemArray[1];
            var IdEmpleado = tuplaSeleccionada[0].ItemArray[2];
            var IdDevolucion = tuplaSeleccionada[0].ItemArray[3];
            var FechaEntrega = (DateTime)tuplaSeleccionada[0].ItemArray[4];
            //cbIdProveedorI.SelectedValue = cbIdProveedorI.Items.IndexOf(IdEmpleado.ToString());

            cbIdProveedorI.SelectedValue = IdProveedor;
            cbIdEmpleadoI.SelectedValue = IdEmpleado;
            cbIdDevolucionI.SelectedValue = IdDevolucion;
            dtFechaEntregaI.Value = FechaEntrega;
        }

        /// <summary>
        /// Método para limpiar el formulario donde se reciben los datos de una entrega
        /// </summary>
        private void limpiaFormulario() {
            cbIdDevolucionI.Text = "";
            cbIdDevolucionI.SelectedIndex = -1;
            cbIdEmpleadoI.Text = "";
            cbIdEmpleadoI.SelectedIndex = -1;
            cbIdProveedorI.Text = "";
            cbIdProveedorI.SelectedIndex = -1;
            dtFechaEntregaI.Value = System.DateTime.Now;
        }

    }
}

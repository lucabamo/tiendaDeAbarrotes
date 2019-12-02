using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace sistemaTiendaAbarrotes
{
    // Clase para las operaciones de devolucion
    class Devolucion
    {
        // Variables
        SqlConnection conexion;
        DataTable tablaDevolucion;
        DataTable tablaDevolucionPura;
        string IdDevolucionSeleccionada;
        ComboBox cbNombreEmpleado;
        ComboBox cbVenta;
        TextBox tbMotivoDevolucion;
        TextBox tbCantidad;
        DateTimePicker dtFechaDevolucion;


        // Constructor de la clase, recibe la conexion y los controles 
        public Devolucion(SqlConnection conexion ,ComboBox nombreEmpleado, ComboBox venta, TextBox motivoDevolucion, 
            DateTimePicker fechaDevolucion, TextBox cantidad ) {
            tablaDevolucion = new DataTable();
            tablaDevolucionPura = new DataTable();
            this.conexion = conexion;
            IdDevolucionSeleccionada = "";
            cbNombreEmpleado = nombreEmpleado;
            cbVenta = venta;
            tbMotivoDevolucion = motivoDevolucion;
            tbCantidad = cantidad;
            dtFechaDevolucion = fechaDevolucion;
        }

        // Regresa el Id de la devolucion
        public string AccesoIDevolucionSeleccionada
        {
            get { return IdDevolucionSeleccionada; }
            set { IdDevolucionSeleccionada = value; }
        }

        // Metodo que llena el comobo box con los empleados disponibles
        private void llenaNombreEmpleados(ComboBox cbNombreEmpleados)
        {
            // Genera la consulta SQL
            string consultaEmpleados = "SELECT IdEmpleado, Nombre FROM Empresa.Empleado";
            using (var command = new SqlCommand(consultaEmpleados, conexion))
            {
                DataTable tablaEmpleados = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Despliega el nombre del empleado y guarda su Id para uso interno
                    tablaEmpleados.Load(reader);
                    cbNombreEmpleado.ValueMember = "IdEmpleado";
                    cbNombreEmpleado.DisplayMember = "Nombre";
                    cbNombreEmpleado.DataSource = tablaEmpleados;
                }
            }

            // Limpi el empleado seleccionado
            cbNombreEmpleado.Text = "";
            cbNombreEmpleado.SelectedIndex = -1;
        }


        // Metodo para llenar el combo box de las ventas 
        private void llenaVentas(ComboBox cbVentas)
        {
            // Genera consulta SQL
            string consultaVentas = "SELECT IdVenta FROM Transaccion.Venta";
            using (var command = new SqlCommand(consultaVentas, conexion))
            {
                DataTable tablaVentas = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Despliega las ventas disponibles
                    tablaVentas.Load(reader);
                    cbVentas.ValueMember = "IdVenta";
                    cbVentas.DisplayMember = "IdVenta";
                    cbVentas.DataSource = tablaVentas;
                }
            }

            // Limpia el elemento seleccionado
            cbVentas.Text = "";
            cbVentas.SelectedIndex = -1;
        }


        // Metodo para llenar los combo box
        private void llenaComboBox()
        {
            try
            {
                llenaNombreEmpleados(cbNombreEmpleado);
                llenaVentas(cbVenta);
            }
            catch (Exception e)
            {

            }
        }


        // Metodo para llenar la tabla de devolucion 
        public void Consulta(DataGridView dgDevolucion)
        {
            // Limpia las tablas
            tablaDevolucion.Clear();
            tablaDevolucionPura.Clear();

            // Genera una consulta entre las tablas Devolucion, Empleado y Venta
            string consulta = "SELECT IdDevolucion,Empleado.Nombre AS Nombre_Empleado," +
                "Devolucion.IdVenta, Fecha, Motivo, Monto " +
                "Monto FROM Transaccion.Devolucion Devolucion " +
                "INNER JOIN Empresa.Empleado Empleado ON Devolucion.IdEmpleado = Empleado.IdEmpleado " +
                "INNER JOIN Transaccion.Venta Venta ON Venta.IdVenta = Devolucion.IdVenta";
            string consultaDos = "SELECT * FROM Transaccion.Devolucion";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            // Llena las tablas con la informacion condultada
            adaptador.Fill(tablaDevolucion);
            comando = new SqlCommand(consultaDos, conexion);
            adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tablaDevolucionPura);
            dgDevolucion.DataSource = tablaDevolucion;

            // Llena los comb box
            llenaComboBox();
        }

        /// <summary>
        /// Método para insertar una tupla de la tabla Entrega
        /// </summary>
        public void Inserta()
        {
            try
            {
                //DataRowView es el tipo de dato para leer una tupla que se inserto en algún lugar con anterioridad
                DataRowView Empleado = (DataRowView)cbNombreEmpleado.SelectedItem;
                DataRowView Venta = (DataRowView)cbVenta.SelectedItem;
                Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; //Nuestro elemento de la posición 0 es el ID
                Int64 IdVenta = (Int64)Venta.Row.ItemArray[0];
                var motivoDev = tbMotivoDevolucion.Text;
                var cantidad = "0";
                DateTime fechaDevolucion = dtFechaDevolucion.Value.Date;
                string query = "";
                query = "INSERT INTO Transaccion.Devolucion (IdEmpleado, IdVenta, Fecha, Motivo, Monto, Entregada) " +
                        "VALUES (@IdEmpleado, @IdVenta,@fechaDevolucion,@motivoDev, @cantidad, 0)";

                // Manda la consulta a la base de datos
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@IdVenta", IdVenta);
                comando.Parameters.AddWithValue("@fechaDevolucion", fechaDevolucion);
                comando.Parameters.AddWithValue("@motivoDev", motivoDev);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                try
                {
                    // Ejecuta la instruccion
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Inserción correcta");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hubo un error en la inserción");
                }
                // Limpia los controles de texto
                limpiaFormulario();
            }
            catch (Exception exception)
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
            DataRow[] tuplaSeleccionada = tablaDevolucionPura.Select("[IdDevolucion] = " + IdDevolucionSeleccionada);

            //Una vez seleccionada la tupla buscamos cada uno de los atributos
            var IdEmpleado = tuplaSeleccionada[0].ItemArray[1];
            var IdVenta = tuplaSeleccionada[0].ItemArray[2];
            var Fecha = (DateTime)tuplaSeleccionada[0].ItemArray[3];
            var Motivo = tuplaSeleccionada[0].ItemArray[4];
            var Monto = tuplaSeleccionada[0].ItemArray[5];

            // Carga en cada campo el valor seleccionado
            cbNombreEmpleado.SelectedValue = IdEmpleado;
            cbVenta.SelectedValue = IdVenta;
            tbCantidad.Text = Monto.ToString();
            tbMotivoDevolucion.Text = (string)Motivo;
            dtFechaDevolucion.Value = Fecha;
        }


        // Metodo para modificar una tupla seleccionada de la tabla devolucion
        public void editaRegistroSeleccionado()
        {
            try
            {
                //DataRowView es el tipo de dato para leer una tupla que se inserto en algún lugar con anterioridad
                DataRowView Empleado = (DataRowView)cbNombreEmpleado.SelectedItem;
                DataRowView Venta = (DataRowView)cbVenta.SelectedItem;
                Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; //Nuestro elemento de la posición 0 es el ID
                Int64 IdVenta = (Int64)Venta.Row.ItemArray[0];
                var motivoDev = tbMotivoDevolucion.Text;
                var cantidad = tbCantidad.Text;
                DateTime fechaDevolucion = dtFechaDevolucion.Value.Date;

                // Genea consulta SQL
                string queryEdita = "UPDATE Transaccion.Devolucion SET IdEmpleado = @IdEmpleado, " +
                    "IdVenta = @IdVenta, Fecha = @fechaDevolucion, Motivo = @motivoDev," +
                    "Monto = @cantidad " +
                    "WHERE IdDevolucion = " + IdDevolucionSeleccionada;

                // Manda la consulta a la base de datos
                SqlCommand comando = new SqlCommand(queryEdita, conexion);

                comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@IdVenta", IdVenta);
                comando.Parameters.AddWithValue("@fechaDevolucion", fechaDevolucion);
                comando.Parameters.AddWithValue("@motivoDev", motivoDev);
                comando.Parameters.AddWithValue("@cantidad", cantidad);

                try
                {
                    // Ejecuta la consulta
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
        /// Método para la eliminación de un registro que ha sido seleccionado.
        /// </summary>
        public void eliminaRegistroSeleccionado()
        {
            if (IdDevolucionSeleccionada != "")
            {
                // Genera consulta SQL
                string queryElimina = "DELETE FROM Transaccion.Devolucion WHERE IdDevolucion = " + IdDevolucionSeleccionada;

                // Manda la consulta a la base de datos
                SqlCommand comando = new SqlCommand(queryElimina, conexion);
                try
                {
                    // Ejecuta la iinstruccion
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
                MessageBox.Show("Es necesario seleccionar un registro para eliminar");
            }

        }


        /// <summary>
        /// Método para limpiar el formulario donde se reciben los datos de una entrega
        /// </summary>
        private void limpiaFormulario()
        {
            cbNombreEmpleado.Text = "";
            cbNombreEmpleado.SelectedIndex = -1;
            cbVenta.Text = "";
            cbVenta.SelectedIndex = -1;
            dtFechaDevolucion.Value = System.DateTime.Now;
            tbCantidad.Text = "";
            tbMotivoDevolucion.Text = "";
        }

    }
}

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
    class Devolucion
    {
        SqlConnection conexion;
        DataTable tablaDevolucion;
        DataTable tablaDevolucionPura;
        string IdDevolucionSeleccionada;
        ComboBox cbNombreEmpleado;
        ComboBox cbVenta;
        TextBox tbMotivoDevolucion;
        TextBox tbCantidad;
        DateTimePicker dtFechaDevolucion;

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

        public string AccesoIDevolucionSeleccionada
        {
            get { return IdDevolucionSeleccionada; }
            set { IdDevolucionSeleccionada = value; }
        }

        private void llenaNombreEmpleados(ComboBox cbNombreEmpleados)
        {
            string consultaEmpleados = "SELECT IdEmpleado, Nombre FROM Empresa.Empleado";
            using (var command = new SqlCommand(consultaEmpleados, conexion))
            {
                DataTable tablaEmpleados = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaEmpleados.Load(reader);
                    cbNombreEmpleado.ValueMember = "IdEmpleado";
                    cbNombreEmpleado.DisplayMember = "Nombre";
                    cbNombreEmpleado.DataSource = tablaEmpleados;
                }
            }
            cbNombreEmpleado.Text = "";
            cbNombreEmpleado.SelectedIndex = -1;
        }

        private void llenaVentas(ComboBox cbVentas)
        {
            string consultaVentas = "SELECT IdVenta FROM Transaccion.Venta";
            using (var command = new SqlCommand(consultaVentas, conexion))
            {
                DataTable tablaVentas = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaVentas.Load(reader);
                    cbVentas.ValueMember = "IdVenta";
                    cbVentas.DisplayMember = "IdVenta";
                    cbVentas.DataSource = tablaVentas;
                }
            }
            cbVentas.Text = "";
            cbVentas.SelectedIndex = -1;
        }

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

        public void Consulta(DataGridView dgDevolucion)
        {
            tablaDevolucion.Clear();
            tablaDevolucionPura.Clear();
            string consulta = "SELECT IdDevolucion,Empleado.Nombre AS Nombre_Empleado," +
                "Devolucion.IdVenta, Fecha, Motivo, Monto " +
                "Monto FROM Transaccion.Devolucion Devolucion " +
                "INNER JOIN Empresa.Empleado Empleado ON Devolucion.IdEmpleado = Empleado.IdEmpleado " +
                "INNER JOIN Transaccion.Venta Venta ON Venta.IdVenta = Devolucion.IdVenta";
            string consultaDos = "SELECT * FROM Transaccion.Devolucion";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tablaDevolucion);
            comando = new SqlCommand(consultaDos, conexion);
            adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tablaDevolucionPura);
            dgDevolucion.DataSource = tablaDevolucion;
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

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@IdVenta", IdVenta);
                comando.Parameters.AddWithValue("@fechaDevolucion", fechaDevolucion);
                comando.Parameters.AddWithValue("@motivoDev", motivoDev);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                try
                {
                    comando.ExecuteNonQuery();
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

            cbNombreEmpleado.SelectedValue = IdEmpleado;
            cbVenta.SelectedValue = IdVenta;
            tbCantidad.Text = Monto.ToString();
            tbMotivoDevolucion.Text = (string)Motivo;
            dtFechaDevolucion.Value = Fecha;
        }

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

                string queryEdita = "UPDATE Transaccion.Devolucion SET IdEmpleado = @IdEmpleado, " +
                    "IdVenta = @IdVenta, Fecha = @fechaDevolucion, Motivo = @motivoDev," +
                    "Monto = @cantidad " +
                    "WHERE IdDevolucion = " + IdDevolucionSeleccionada;

                SqlCommand comando = new SqlCommand(queryEdita, conexion);

                comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@IdVenta", IdVenta);
                comando.Parameters.AddWithValue("@fechaDevolucion", fechaDevolucion);
                comando.Parameters.AddWithValue("@motivoDev", motivoDev);
                comando.Parameters.AddWithValue("@cantidad", cantidad);

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
        /// Método para la eliminación de un registro que ha sido seleccionado.
        /// </summary>
        public void eliminaRegistroSeleccionado()
        {
            if (IdDevolucionSeleccionada != "")
            {
                string queryElimina = "DELETE FROM Transaccion.Devolucion WHERE IdDevolucion = " + IdDevolucionSeleccionada;
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

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
    // Clase para las operaciones de venta
    public class Venta
    {
        private string idVenta;  // Identifica el Id de la venta


        // Constructor de la clase, inicializa el Id de la venta
        public Venta()
        {
            idVenta = "";
        }

        // Metodo que llena la tabla de ventas
        public DataTable selectVentas(SqlConnection connection)
        {
            string query = "SELECT * FROM Transaccion.Venta";
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Llena la tabla 
            adapter.Fill(table);

            // Regresa la tabla con los datos existentes
            return table; 
        }


        // Metodo que inserta una venta en la tabla
        public void insertVenta(SqlConnection connection, Int64 idEmpleado, DateTime fechaVenta)
        {
            // Genera consuulta SQL
            string query = "INSERT INTO Transaccion.Venta (IdEmpleado, FechaVenta, Total)" +
                "VALUES (@idEmpleado, @fechaVenta, @total)";

            // Envia la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            command.Parameters.AddWithValue("@fechaVenta", fechaVenta);
            command.Parameters.AddWithValue("@total", 0);
         
            try
            {
                // Ejecuta la consulta
                command.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error en la inserción");
            }
        }

        // Metodo que modifica una tupla de la tabla venta
        public void updateVenta(SqlConnection connection, Int64 idEmpleado, DateTime fechaVenta)
        {
            // Genera la consulta SQl
            string query = "UPDATE Transaccion.Venta SET IdEmpleado=@idEmpleado, FechaVenta = @fechaVenta WHERE IdVenta = @idVenta";

            // Envia la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            command.Parameters.AddWithValue("@fechaVenta", fechaVenta);
            command.Parameters.AddWithValue("@idVenta", idVenta);

            try
            {
                // Ejecuta la consulta
                command.ExecuteNonQuery();
                MessageBox.Show("Modificado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la modificación");
            }
        }


        // Metodo que elimina una tupla de la tabla ventas
        public void deleteVenta(SqlConnection connection)
        {
            // Genera la consulta SQL
            string query = "DELETE FROM Transaccion.Venta WHERE IdVenta = @idVenta";

            // Envia la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idVenta", idVenta);

            try
            {
                // Ejecuta la consulta
                command.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }


        // Metodo que llena el combo box de los empleados existentes
        public void consultaEmpleados(SqlConnection connection, ComboBox empleados)
        {
            // Genera la consulta 
            string consultaEmpleados = "SELECT IdEmpleado, Nombre FROM Empresa.Empleado";
            SqlCommand command = new SqlCommand(consultaEmpleados, connection);
            
            DataTable tablaEmpleados = new DataTable();
            SqlDataReader reader = command.ExecuteReader();
            
            // Despliega el nombre del empleado y guarda el Id para su manejo interno
            tablaEmpleados.Load(reader);
            empleados.ValueMember = "IdEmpleado";
            empleados.DisplayMember = "Nombre";
            empleados.DataSource = tablaEmpleados;

            // Limpia el elemento seleccionado
            empleados.Text = "";
            empleados.SelectedIndex = -1;
        }


        // Regresa el Id de la venta
        public string IdVenta { get { return idVenta; } set { idVenta = value; } }
    }
}

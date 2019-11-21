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
    public class Venta
    {
        private string idVenta;

        public Venta()
        {
            idVenta = "";
        }

        public DataTable selectVentas(SqlConnection connection)
        {
            string query = "SELECT * FROM Transaccion.Venta";
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(table);

            return table; 
        }

        public void insertVenta(SqlConnection connection, Int64 idEmpleado, DateTime fechaVenta)
        {
            string query = "INSERT INTO Transaccion.Venta (IdEmpleado, FechaVenta, Total)" +
                "VALUES (@idEmpleado, @fechaVenta, @total)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            command.Parameters.AddWithValue("@fechaVenta", fechaVenta);
            command.Parameters.AddWithValue("@total", 0);
         
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateVenta(SqlConnection connection, Int64 idEmpleado, DateTime fechaVenta)
        {
            string query = "UPDATE Transaccion.Venta SET IdEmpleado=@idEmpleado, FechaVenta = @fechaVenta WHERE IdVenta = @idVenta";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            command.Parameters.AddWithValue("@fechaVenta", fechaVenta);
            command.Parameters.AddWithValue("@idVenta", idVenta);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Modificado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteVenta(SqlConnection connection)
        {
            string query = "DELETE FROM Transaccion.Venta WHERE IdVenta = @idVenta";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idVenta", idVenta);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void consultaEmpleados(SqlConnection connection, ComboBox empleados)
        {
            string consultaEmpleados = "SELECT IdEmpleado, Nombre FROM Empresa.Empleado";
            SqlCommand command = new SqlCommand(consultaEmpleados, connection);
            
            DataTable tablaEmpleados = new DataTable();
            SqlDataReader reader = command.ExecuteReader();
                
            tablaEmpleados.Load(reader);
            empleados.ValueMember = "IdEmpleado";
            empleados.DisplayMember = "Nombre";
            empleados.DataSource = tablaEmpleados;

            empleados.Text = "";
            empleados.SelectedIndex = -1;
        }

        public string IdVenta { get => idVenta; set => idVenta = value; }
    }
}

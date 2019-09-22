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

        public void insertVenta(SqlConnection connection,string idEmpleado, string fechaVenta, string total)
        {
            string query = "INSERT INTO Transaccion.Venta (IdEmpleado, FechaVenta, Total)" +
                "VALUES (@idEmpleado, @fechaVenta, @total)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            command.Parameters.AddWithValue("@fechaVenta", fechaVenta);
            command.Parameters.AddWithValue("@total", total);

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

        public void updateVenta(SqlConnection connection, string idEmpleado, string fechaVenta, string total, string idVenta)
        {
            string query = "UPDATE Transaccion.Venta SET IdEmpleado=@idEmpleado, FechaVenta = @fechaVenta, Total = @total WHERE IdVenta = @idVenta";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            command.Parameters.AddWithValue("@fechaVenta", fechaVenta);
            command.Parameters.AddWithValue("@total", total);
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

        public void deleteVenta(SqlConnection connection, string idVenta)
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

        public string IdVenta { get => idVenta; set => idVenta = value; }
    }
}

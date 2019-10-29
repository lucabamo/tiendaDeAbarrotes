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
    public class DetalleVenta
    {
       public DetalleVenta()
        {

        }

        public DataTable selectDetalleVenta(SqlConnection connection)
        {
            string query = "SELECT * FROM Transaccion.DetalleVenta";
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(table);

            return table;
        }

        public void insertDetalleVenta(SqlConnection connection, string idVenta, string idPromocion, string idProducto, string cantidad, string subtotal)
        {
            string query = "INSERT INTO Transaccion.DetalleVenta (IdVenta, IdPromocion, IdProducto, Cantidad, Subtotal)" +
                "VALUES (@idVenta, @idPromocion, @idProducto, @cantidad, @subtotal)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idVenta", idVenta);
            command.Parameters.AddWithValue("@idPromocion", idPromocion);
            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@subtotal", subtotal);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateDetalleVenta(SqlConnection connection, string idVenta, string idPromocion, string idProducto, string cantidad, string subtotal)
        {
            string query = "UPDATE Transaccion.DetalleVenta SET IdVenta = @idVenta, IdPromocion = @idPromocion, IdProducto = @idProducto, Cantidad = @cantidad, SubTotal = @subtotal";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idVenta", idVenta);
            command.Parameters.AddWithValue("@idPromocion", idPromocion);
            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@subtotal", subtotal);

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

        public void deleteDetalleVenta(SqlConnection connection, string idVenta)
        {
            string query = "DELETE FROM Transaccion.DetalleVenta WHERE IdVenta = @IdVenta";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdVenta", idVenta);

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
    }
}

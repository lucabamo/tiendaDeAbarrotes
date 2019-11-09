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

        public void insertDetalleVenta(SqlConnection connection, Int64 idVenta, Int64 idPromocion, Int64 idProducto, string cantidad, string subtotal)
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

        public void updateDetalleVenta(SqlConnection connection, Int64 idVenta, Int64 idPromocion, Int64 idProducto, string cantidad, string subtotal)
        {
            string query = "UPDATE Transaccion.DetalleVenta SET IdVenta = @idVenta, IdPromocion = @idPromocion, IdProducto = @idProducto, Cantidad = @cantidad, SubTotal = @subtotal WHERE Id";
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

        public void consultaProductos(SqlConnection connection, ComboBox producto)
        {
            string query = "SELECT IdProducto, Nombre FROM Inventario.Producto";
            SqlCommand command = new SqlCommand(query, connection);

            DataTable tablaProducto = new DataTable();
            SqlDataReader reader = command.ExecuteReader();

            tablaProducto.Load(reader);
            producto.ValueMember = "IdProducto";
            producto.DisplayMember = "Nombre";
            producto.DataSource = tablaProducto;

            producto.Text = "";
            producto.SelectedIndex = -1;
        }

        public void consultaVentas(SqlConnection connection, ComboBox idVentas)
        {
            string query = "SELECT IdVenta FROM Transaccion.Venta";
            SqlCommand command = new SqlCommand(query, connection);

            DataTable tablaVenta = new DataTable();
            SqlDataReader reader = command.ExecuteReader();

            tablaVenta.Load(reader);
            idVentas.ValueMember = "IdVenta";
            idVentas.DisplayMember = "IdVenta";
            idVentas.DataSource = tablaVenta;

            idVentas.Text = "";
            idVentas.SelectedIndex = -1;
        }

        public void consultaPromociones(SqlConnection connection, ComboBox idPromociones)
        {
            string query = "SELECT IdPromocion FROM Transaccion.Promocion";
            SqlCommand command = new SqlCommand(query, connection);

            DataTable tablaPromocion = new DataTable();
            SqlDataReader reader = command.ExecuteReader();

            tablaPromocion.Load(reader);
            idPromociones.ValueMember = "IdPromocion";
            idPromociones.DisplayMember = "IdPromocion";
            idPromociones.DataSource = tablaPromocion;

            idPromociones.Text = "";
            idPromociones.SelectedIndex = -1;
        }
    }
}

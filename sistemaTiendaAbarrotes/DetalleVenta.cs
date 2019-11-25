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
       private string id;

        public string Id { get => id; set => id = value; }

        public DetalleVenta()
        {
            id = "";
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

        public void insertDetalleVenta(SqlConnection connection, Int64 idVenta, Int64 idPromocion, Int64 idProducto, string cantidad)
        {
            string query = "INSERT INTO Transaccion.DetalleVenta (IdVenta, IdPromocion, IdProducto, Cantidad)" +
                "VALUES (@idVenta, @idPromocion, @idProducto, @cantidad)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idVenta", idVenta);
            command.Parameters.AddWithValue("@idPromocion", idPromocion);
            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.Parameters.AddWithValue("@cantidad", cantidad);       

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (Exception ex)
            {
               MessageBox.Show("Hubo un error en la inserción");
            }
        }

        public void updateDetalleVenta(SqlConnection connection, Int64 idVenta, Int64 idPromocion, Int64 idProducto, string cantidad)
        {
            string query = "UPDATE Transaccion.DetalleVenta SET IdVenta = @idVenta, IdPromocion = @idPromocion, IdProducto = @idProducto, Cantidad = @cantidad WHERE IdDetalleVenta = @id";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idVenta", idVenta);
            command.Parameters.AddWithValue("@idPromocion", idPromocion);
            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Modificado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la modificación");
            }
        }

        public void deleteDetalleVenta(SqlConnection connection)
        {
            string query = "DELETE FROM Transaccion.DetalleVenta WHERE IdDetalleVenta = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar");
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

        public void consultaPromociones(SqlConnection connection, ComboBox idPromociones, Int64 idProducto)
        {
            string query = "SELECT Promocion.IdPromocion FROM Transaccion.Promocion  JOIN Inventario.Producto ON Promocion.IdProducto = Producto.IdProducto WHERE Producto.IdProducto = @IdProducto";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdProducto", idProducto);

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

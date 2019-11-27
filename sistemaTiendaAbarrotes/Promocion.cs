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
    
    public class Promocion
    {
        private string idPromocion;

        public Promocion()
        {
            idPromocion = "";
        }

        public DataTable selectPromocion(SqlConnection connection)
        {
            string query = "SELECT * FROM Transaccion.Promocion";
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(table);

            return table;
        }

        public void insertPromocion(SqlConnection connection, Int64 idProducto, DateTime fechaInicio, DateTime fechaFinal, string descuento)
        {
            string query = "INSERT INTO Transaccion.Promocion (IdProducto, FechaInicio, FechaFinal, Descuento)" +
                "VALUES (@idProducto, @fechaInicio, @fechaFinal, @descuento)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
            command.Parameters.AddWithValue("@descuento", descuento);

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

        public void updatePromocion(SqlConnection connection, Int64 idProducto, DateTime fechaInicio, DateTime fechaFinal, string descuento, string idPromocion)
        {
            string query = "UPDATE Transaccion.Promocion SET IdProducto=@idProducto, FechaInicio = @fechaInicio, FechaFinal = @fechaFinal, Descuento = @descuento WHERE IdPromocion = @idPromocion";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
            command.Parameters.AddWithValue("@descuento", descuento);
            command.Parameters.AddWithValue("@idPromocion", idPromocion);

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

        public void deletePromocion(SqlConnection connection, string idPromocion)
        {
            string query = "DELETE FROM Transaccion.Promocion WHERE IdPromocion = @idPromocion";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idPromocion", idPromocion);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        public void consultaPromocion(SqlConnection connection, ComboBox producto)
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

        public string IdPromocion { get => idPromocion; set => idPromocion = value; }
    }
}

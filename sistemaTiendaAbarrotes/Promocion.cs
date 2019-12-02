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
    // Clase para las operaciones de promocion
    public class Promocion
    {
        private string idPromocion; // Identifica el Id de la promocion

        // Constructor de la clase, inicializa el Id de la promocion
        public Promocion()
        {
            idPromocion = "";
        }

        // Metodo que llena la tabla de las promociones
        public DataTable selectPromocion(SqlConnection connection)
        {
            // Genera la consulta SQL
            string query = "SELECT * FROM Transaccion.Promocion";
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Llena la tabla con los datos 
            adapter.Fill(table);

            return table;
        }


        // Metodo que inserta una promocion en la tabla
        public void insertPromocion(SqlConnection connection, Int64 idProducto, DateTime fechaInicio, DateTime fechaFinal, string descuento)
        {
            // Genera la consulta SQL
            string query = "INSERT INTO Transaccion.Promocion (IdProducto, FechaInicio, FechaFinal, Descuento)" +
                "VALUES (@idProducto, @fechaInicio, @fechaFinal, @descuento)";

            // Envia la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
            command.Parameters.AddWithValue("@descuento", descuento);

            try
            {
                // Ejecuta la instruccion
                command.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la inserción");
            }
        }

        // Metodo que modifica una tupla de la tabla promocion
        public void updatePromocion(SqlConnection connection, Int64 idProducto, DateTime fechaInicio, DateTime fechaFinal, string descuento, string idPromocion)
        {
            // Genera la consulta SQL
            string query = "UPDATE Transaccion.Promocion SET IdProducto=@idProducto, FechaInicio = @fechaInicio, FechaFinal = @fechaFinal, Descuento = @descuento WHERE IdPromocion = @idPromocion";

            // Manda la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
            command.Parameters.AddWithValue("@descuento", descuento);
            command.Parameters.AddWithValue("@idPromocion", idPromocion);

            try
            {
                // Ejecuta la instruccion
                command.ExecuteNonQuery();
                MessageBox.Show("Modificado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la modificación");
            }
        }


        // Metodo que elimina una tupla de la tabla promocion
        public void deletePromocion(SqlConnection connection, string idPromocion)
        {
            // Genera la consulta SQL
            string query = "DELETE FROM Transaccion.Promocion WHERE IdPromocion = @idPromocion";

            // Envia la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idPromocion", idPromocion);

            try
            {
                // Ejecuta la instruccion
                command.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }


        // Metodo que llena el combo box de los productos
        public void consultaPromocion(SqlConnection connection, ComboBox producto)
        {
            // Genera la consulta SQL
            string query = "SELECT IdProducto, Nombre FROM Inventario.Producto";

            // Envia la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);

            DataTable tablaProducto = new DataTable();
            SqlDataReader reader = command.ExecuteReader();

            // Despliega el nombre del producto y guarda el Id para su manejo interno
            tablaProducto.Load(reader);
            producto.ValueMember = "IdProducto";
            producto.DisplayMember = "Nombre";
            producto.DataSource = tablaProducto;

            // Limpia el elemnto seleccionado
            producto.Text = "";
            producto.SelectedIndex = -1;
        }

        // Regresa el Id de la promocion
        public string IdPromocion { get { return idPromocion; } set { idPromocion = value; } }
    }
}

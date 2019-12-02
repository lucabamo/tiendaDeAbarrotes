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
    // Clase para las operaciones de detalle venta
    public class DetalleVenta
    {
       private string id; // Representa el Id del detalle venta

        // Regresa el Id del detalle venta
        public string Id { get { return id; } set { id = value; } }


        // Constructor de la clase, inicilaiza el Id
        public DetalleVenta()
        {
            id = "";
        }

        // Metodo para llenar y enviar la tabla de detalle venta
        public DataTable selectDetalleVenta(SqlConnection connection)
        {
            // Genera la consulta SQL
            string query = "SELECT * FROM Transaccion.DetalleVenta";
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Llena la tabla
            adapter.Fill(table);

            // Regresa la tabla con los datos existentes
            return table;
        }


        // Metodo para insertar un detalle venta a la tabla
        public void insertDetalleVenta(SqlConnection connection, Int64 idVenta, Int64 idPromocion, Int64 idProducto, string cantidad)
        {
            // Genera la consulta SQL
            string query = "INSERT INTO Transaccion.DetalleVenta (IdVenta, IdPromocion, IdProducto, Cantidad)" +
                "VALUES (@idVenta, @idPromocion, @idProducto, @cantidad)";

            // Manda la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idVenta", idVenta);
            command.Parameters.AddWithValue("@idPromocion", idPromocion);
            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.Parameters.AddWithValue("@cantidad", cantidad);       

            try
            {
                // Ejecuta la instruccion SQL
                command.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (Exception ex)
            {
               //MessageBox.Show(ex.ToString());
               MessageBox.Show("Hubo un error en la inserción");
            }
        }


        // Metodo que actualiza un detalle venta seleccionado
        public void updateDetalleVenta(SqlConnection connection, Int64 idVenta, Int64 idPromocion, Int64 idProducto, string cantidad)
        { 
            // Genera la consulta SQL
            string query = "UPDATE Transaccion.DetalleVenta SET IdVenta = @idVenta, IdPromocion = @idPromocion, IdProducto = @idProducto, Cantidad = @cantidad WHERE IdDetalleVenta = @id";

            // Manda la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@idVenta", idVenta);
            command.Parameters.AddWithValue("@idPromocion", idPromocion);
            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@id", id);

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


        // Metodo para eliminar un detalle venta
        public void deleteDetalleVenta(SqlConnection connection)
        {
            // Genera la consulta SQL
            string query = "DELETE FROM Transaccion.DetalleVenta WHERE IdDetalleVenta = @id";

            // Manda la consuta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                // Ejecuta la instruccion
                command.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar");
            }
        }


        // Metodo para llenar el combo box de productos 
        public void consultaProductos(SqlConnection connection, ComboBox producto)
        {
            // Genera la consulta SQL
            string query = "SELECT IdProducto, Nombre FROM Inventario.Producto";

            // Manda la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);

            DataTable tablaProducto = new DataTable();
            SqlDataReader reader = command.ExecuteReader();

            // Despliega el nombre del producto y guarda el Id para su manejo interno
            tablaProducto.Load(reader);
            producto.ValueMember = "IdProducto";
            producto.DisplayMember = "Nombre";
            producto.DataSource = tablaProducto;

            // Limpia el elemento seleccionado
            producto.Text = "";
            producto.SelectedIndex = -1;
        }

        // Metodo para llenar el combo box de las ventas
        public void consultaVentas(SqlConnection connection, ComboBox idVentas)
        {
            // Genera la consulta SQL
            string query = "SELECT IdVenta FROM Transaccion.Venta";

            // Manda la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);

            DataTable tablaVenta = new DataTable();
            SqlDataReader reader = command.ExecuteReader();

            // Despliega el Id de la venta en el combo box
            tablaVenta.Load(reader);
            idVentas.ValueMember = "IdVenta";
            idVentas.DisplayMember = "IdVenta";
            idVentas.DataSource = tablaVenta;

            // Limpia el elemento seleccinado
            idVentas.Text = "";
            idVentas.SelectedIndex = -1;
        }


        // Metodo para consultar las promociones del producto seleccionado
        public void consultaPromociones(SqlConnection connection, ComboBox idPromociones, Int64 idProducto)
        {
            // Genera la consulta SQL
            string query = "SELECT Promocion.IdPromocion FROM Transaccion.Promocion  JOIN Inventario.Producto ON Promocion.IdProducto = Producto.IdProducto WHERE Producto.IdProducto = @IdProducto";

            // Manda la consulta a la base de datos
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdProducto", idProducto);

            DataTable tablaPromocion = new DataTable();
            SqlDataReader reader = command.ExecuteReader();

            // Despliega las promociones disponibles
            tablaPromocion.Load(reader);
            idPromociones.ValueMember = "IdPromocion";
            idPromociones.DisplayMember = "IdPromocion";
            idPromociones.DataSource = tablaPromocion;

            // Limpia el elemento seleccionado
            idPromociones.Text = "";
            idPromociones.SelectedIndex = -1;
        }
    }
}

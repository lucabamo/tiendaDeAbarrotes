using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace sistemaTiendaAbarrotes
{
    // Clase para las operaciones de producto
    public class Producto
    {
        // Variables
        SqlConnection conexion;
        TextBox tbNombre;
        TextBox tbExistencias;
        TextBox tbCostoProveedor;
        TextBox tbCostoVenta;
        DataGridView dtProducto;
        string idProd; // Identifica el Id del producto

        // Constructor de la clase, recibe la conexion y los controles del formulario
        public Producto(SqlConnection con, TextBox nombre, TextBox existencias, TextBox costoProv, TextBox costoVenta, DataGridView productos)
        {
            conexion = con;
            tbNombre = nombre;
            tbExistencias = existencias;
            tbCostoProveedor = costoProv;
            tbCostoVenta = costoVenta;
            dtProducto = productos;

            // Llena la tabla con los productos existentes
            actualizaTabla();
        }

        // Metodo que inserta un producto en la tabla
        public void insertarProducto()
        {
            // Genera la consulta SQL
            string query = "INSERT INTO Inventario.Producto (Nombre, Existencia, CostoProveedor, CostoVenta) VALUES (@nombre, @existencia, @costoProveedor, @costoVenta) ";

            // Envia la consulta a la base de datos
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", tbNombre.Text);
            comando.Parameters.AddWithValue("@existencia", tbExistencias.Text);
            comando.Parameters.AddWithValue("@costoProveedor", tbCostoProveedor.Text);
            comando.Parameters.AddWithValue("@costoVenta", tbCostoVenta.Text);
            

            try
            {
                // Ejecuta la instruccion
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la inserción");
            }

            // Actualiza la tabla con la nueva tupla
            actualizaTabla();
        }


        // Metod que modifica una tupla de la tabla producto
        public void modificarProducto()
        {
            // Valida que se haya seleccionado un producto
            if (idProd != null)
            {
                // Genera la consulta SQL
                string query = "UPDATE Inventario.Producto SET Nombre = @nombre, Existencia = @existencia, CostoProveedor = @costoProveedor, CostoVenta = @costoVenta WHERE IdProducto = @idProd ";
                
                // Envia la consulta a la base de datos
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", tbNombre.Text);
                comando.Parameters.AddWithValue("@existencia", tbExistencias.Text);
                comando.Parameters.AddWithValue("@costoProveedor", tbCostoProveedor.Text);
                comando.Parameters.AddWithValue("@costoVenta", tbCostoVenta.Text);
                comando.Parameters.AddWithValue("@idProd", idProd);

                try
                {
                    // Ejecuta la instruccion
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error en la modificación");
                }

                // Actualiza la tabla con los nuevos datos
                actualizaTabla();

                // Limpia los cintroles de texto
                tbNombre.Text = "";
                tbCostoProveedor.Text = "";
                tbCostoVenta.Text = "";
                tbExistencias.Text = "";
            }
            else
                MessageBox.Show("Debe seleccionar una fila.");
        }

        // Metodo que elimina una tupla de la tabla producto
        public void eliminarProducto()
        {
            // Valida que se haya seleccionado una tupla
            if (idProd != null)
            {
                // Genera la consulta SQL
                string query = "DELETE FROM Inventario.Producto WHERE IdProducto = @idProd";

                // Envia la consulta a la base de datos
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idProd", idProd);

                try
                {
                    // Ejecuta la instruccion
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar");
                }

                // Actualiza la tabla sin la tupla que se elimino
                actualizaTabla();

                // Limpia los controles de texto
                tbNombre.Text = "";
                tbExistencias.Text = "";
                tbCostoProveedor.Text = "";
                tbCostoVenta.Text = "";

            }
            else
                MessageBox.Show("Debe seleccionar una fila.");
        }


        // Metodo que llena la tabla de productos
        public void actualizaTabla()
        {
            string query2 = "SELECT * FROM Inventario.Producto";
            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando2);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtProducto.DataSource = tabla;
        }


        // Metodo que carga un registro en los controles de texto
        public void colocaProducto()
        {
            DataGridViewRow fila = dtProducto.CurrentRow;
            idProd = fila.Cells[0].Value.ToString();
            fila.Selected = true;

            tbNombre.Text = fila.Cells[1].Value.ToString();
            tbExistencias.Text = fila.Cells[2].Value.ToString();
            tbCostoProveedor.Text = fila.Cells[3].Value.ToString();
            tbCostoVenta.Text = fila.Cells[4].Value.ToString();
            
        }
    }
}

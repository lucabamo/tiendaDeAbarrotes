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
    // Clase para las operaciones de Detalle Compra
    public class DetalleCompra
    {
        // Variables
        SqlConnection conexion;
        ComboBox cbCompra;
        ComboBox cbProducto;
        TextBox tbCantidad;
        DataGridView dtDetalleCompra;
        private string idDetalleCompra;  // Guarda el Id de la compra para su operacion


        // Metodo para obtener y regresar el Id de detalle compra
        public string IdDetalleCompra { get { return idDetalleCompra; } set { idDetalleCompra = value; } }


        // Constructor de la clase, recibe la conexion y los controles del formulario Compra
        public DetalleCompra(SqlConnection con, ComboBox compra, ComboBox producto, TextBox cantidad, DataGridView compras)
        {
            conexion = con;
            cbCompra = compra;
            cbProducto = producto;
            tbCantidad = cantidad;
            dtDetalleCompra = compras;
            idDetalleCompra = "";

            // Llena la tabla con las tuplas existentes
            actualizaTabla();
        }


        // Metodo para insertar un detalle compra en la tabla
        public void insertarDetalleCompra()
        {
            try
            {
                // Obtiene los valores que se encuentran en los controles de texto
                DataRowView Compra = (DataRowView)cbCompra.SelectedItem;
                DataRowView Producto = (DataRowView)cbProducto.SelectedItem;
                Int64 IdCompra = (Int64)Compra.Row.ItemArray[0];
                Int64 IdProducto = (Int64)Producto.Row.ItemArray[0]; ;

                // Genera la instruccion SQL
                string query = "INSERT INTO Transaccion.DetalleCompra (IdCompra, IdProducto, Cantidad) VALUES (@compra, @producto, @cantidad) ";

                // Manda la instruccion a la base de datos
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@compra", IdCompra);
                comando.Parameters.AddWithValue("@producto", IdProducto);
                comando.Parameters.AddWithValue("@cantidad", tbCantidad.Text);

                try
                {
                    // Ejecuta la instruccion
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Inserción correcta");
                    resetControles();

                }
                catch (Exception ex)
                {
                    // Manda un mensaje si no se logro la insercion
                    MessageBox.Show("Hubo un error en la inserción");
                }
            }

            catch (Exception ex) {
                // Manda mensaje si algun campo esta vacio
                MessageBox.Show("Es necesario insertar todos los campos");
            }

            // Actualiza a tabla con la nueva tupla
            actualizaTabla();
        }


        // Metodo para modificar los datos de una tupla de la tabla detalle compra
        public void modificarDetalleCompra()
        {
            // Valida si se selecciono una tupla
            if (idDetalleCompra != null)
            {
                // Obtiene los valores que se encuentran en los controles de texto
                DataRowView Compra = (DataRowView)cbCompra.SelectedItem;
                DataRowView Producto = (DataRowView)cbProducto.SelectedItem;
                Int64 IdCompra = (Int64)Compra.Row.ItemArray[0];
                Int64 IdProducto = (Int64)Producto.Row.ItemArray[0]; ;

                // Genera la instruccion SQL
                string query = "UPDATE Transaccion.Compra SET IdCompra = @compra, IdProducto = @producto, Cantidad = @cantidad WHERE IdDetalleCompra = @idDetalleCompra ";

                // Manda la instruccion a la base de datos
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@compra", IdCompra);
                comando.Parameters.AddWithValue("@producto", IdProducto);
                comando.Parameters.AddWithValue("@cantidad", tbCantidad.Text);
                comando.Parameters.AddWithValue("@idDetalleCompra", idDetalleCompra);

                try
                {
                    // Ejecuta la instruccion SQL
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manda un mensaje si la modifcacion no pudo realizarse
                    MessageBox.Show("Hubo un error en la modificación");
                }

                // Actualiza la tabla con los nuevos datos y limpia los controles de texto
                actualizaTabla();
                resetControles();

               
            }
            else
                // Manda un mensaje si no se ha seleccionado ninguna tupla
                MessageBox.Show("Debe seleccionar una fila.");
        }


        // Metodo para eliminar una tupla de la tabla detalle compra
        public void deleteDetalleCompra(SqlConnection connection)
        {
            // Genera la consulta SQL
            string query = "DELETE FROM Transaccion.DetalleCompra WHERE IdDetalleCompra = @id";

            // Manda la instruccion a la base de datos
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idDetalleCompra);

            try
            {
                // Ejecuta la instruccion SQL
                command.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception ex)
            {
                // Manda un mensaje si no se puede eliminar la tupla
                MessageBox.Show("No se puede eliminar");
            }

            // Actualiza la tabla sin la tupla eliminada y limpia los controles
            actualizaTabla();
            resetControles();
        }


        // Metodo para actualizar los datos de la tabla detalle compra 
        public void actualizaTabla()
        {
            // Genera la instruccion SQL
            string query2 = "SELECT * FROM Transaccion.DetalleCompra";

            // Manda la instruccion a la base de datos
            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando2);

            // LLena la tabla con los datos
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtDetalleCompra.DataSource = tabla;

            // Llena los combo box con las compras y los productos
            llenaNombreCompra();
            llenaNombreProducto();

        }


        // Metodo para llenar el combo box con las compras existentes
        public void llenaNombreCompra()
        {
            // Genera una sentencia de consulta
            string consultaCompras = "SELECT IdCompra FROM Transaccion.Compra";

            // Despliega el Id de la compra para su manejo interno
            using (var command = new SqlCommand(consultaCompras, conexion))
            {
                DataTable tablaCompras = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaCompras.Load(reader);
                    cbCompra.ValueMember = "IdCompra";
                    cbCompra.DisplayMember = "IdCompra";
                    cbCompra.DataSource = tablaCompras;
                }
            }

            // Limpia el valor seleccionado en el combo box
            cbCompra.Text = "";
            cbCompra.SelectedIndex = -1;
        }


        // Metodo para llenar el combo box con los productos existentes
        public void llenaNombreProducto()
        {
            // Genera la sentencia de consulta
            string consultaProductos = "SELECT IdProducto, Nombre FROM Inventario.Producto";

            // Despliega el nombre del producto y guarda el Id para su manejo interno
            using (var command = new SqlCommand(consultaProductos, conexion))
            {
                DataTable tablaProductos = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaProductos.Load(reader);
                    cbProducto.ValueMember = "IdProducto";
                    cbProducto.DisplayMember = "Nombre";
                    cbProducto.DataSource = tablaProductos;
                }
            }

            // Limpia el valor seleccionado del combo box
            cbProducto.Text = "";
            cbProducto.SelectedIndex = -1;
        }


        // Metodo para llenar los controles de texto con la tupla seleccionada
        public void colocaDetalleCompra(int index)
        {
            // Obtiene la fila seleccionada
            DataGridViewRow fila = dtDetalleCompra.CurrentRow;
           // idDetalleCompra = index.ToString();
            fila.Selected = true;

            // Coloca cada uno de los valores en el campo correspondiente
            cbCompra.SelectedValue = fila.Cells[1].Value;
            cbProducto.SelectedValue = fila.Cells[2].Value;
            tbCantidad.Text = fila.Cells[3].Value.ToString();

        }

        // Limpia los controles de texto
        public void resetControles()
        {
            cbCompra.Text = "";
            cbCompra.SelectedIndex = -1;
            cbProducto.Text = "";
            cbProducto.SelectedIndex = -1;
            tbCantidad.Text = "";
        }
    }
}

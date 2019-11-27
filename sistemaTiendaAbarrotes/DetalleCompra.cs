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
    public class DetalleCompra
    {
        SqlConnection conexion;
        ComboBox cbCompra;
        ComboBox cbProducto;
        TextBox tbCantidad;
        DataGridView dtDetalleCompra;
        private string idDetalleCompra;

        public string IdDetalleCompra { get { return idDetalleCompra; } set { idDetalleCompra = value; } }

        public DetalleCompra(SqlConnection con, ComboBox compra, ComboBox producto, TextBox cantidad, DataGridView compras)
        {
            conexion = con;
            cbCompra = compra;
            cbProducto = producto;
            tbCantidad = cantidad;
            dtDetalleCompra = compras;
            idDetalleCompra = "";

            actualizaTabla();
        }

        public void insertarDetalleCompra()
        {
            try
            {

                DataRowView Compra = (DataRowView)cbCompra.SelectedItem;
                DataRowView Producto = (DataRowView)cbProducto.SelectedItem;
                Int64 IdCompra = (Int64)Compra.Row.ItemArray[0];
                Int64 IdProducto = (Int64)Producto.Row.ItemArray[0]; ;

                string query = "INSERT INTO Transaccion.DetalleCompra (IdCompra, IdProducto, Cantidad) VALUES (@compra, @producto, @cantidad) ";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@compra", IdCompra);
                comando.Parameters.AddWithValue("@producto", IdProducto);
                comando.Parameters.AddWithValue("@cantidad", tbCantidad.Text);

                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Inserción correcta");
                    resetControles();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error en la inserción");
                }
            }

            catch (Exception ex) {
                MessageBox.Show("Es necesario insertar todos los campos");
            }


            actualizaTabla();
        }

        public void modificarDetalleCompra()
        {
            if (idDetalleCompra != null)
            {
                DataRowView Compra = (DataRowView)cbCompra.SelectedItem;
                DataRowView Producto = (DataRowView)cbProducto.SelectedItem;
                Int64 IdCompra = (Int64)Compra.Row.ItemArray[0];
                Int64 IdProducto = (Int64)Producto.Row.ItemArray[0]; ;

                string query = "UPDATE Transaccion.Compra SET IdCompra = @compra, IdProducto = @producto, Cantidad = @cantidad WHERE IdDetalleCompra = @idDetalleCompra ";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@compra", IdCompra);
                comando.Parameters.AddWithValue("@producto", IdProducto);
                comando.Parameters.AddWithValue("@cantidad", tbCantidad.Text);
                comando.Parameters.AddWithValue("@idDetalleCompra", idDetalleCompra);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error en la modificación");
                }

                actualizaTabla();
                resetControles();

               
            }
            else
                MessageBox.Show("Debe seleccionar una fila.");
        }


        public void deleteDetalleCompra(SqlConnection connection)
        {
            string query = "DELETE FROM Transaccion.DetalleCompra WHERE IdDetalleCompra = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idDetalleCompra);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar");
            }
            actualizaTabla();
            resetControles();
        }


        public void actualizaTabla()
        {
            string query2 = "SELECT * FROM Transaccion.DetalleCompra";
            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando2);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtDetalleCompra.DataSource = tabla;

            llenaNombreCompra();
            llenaNombreProducto();

        }

        public void llenaNombreCompra()
        {
            string consultaCompras = "SELECT IdCompra FROM Transaccion.Compra";
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
            cbCompra.Text = "";
            cbCompra.SelectedIndex = -1;
        }

        public void llenaNombreProducto()
        {
            string consultaProductos = "SELECT IdProducto, Nombre FROM Inventario.Producto";
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
            cbProducto.Text = "";
            cbProducto.SelectedIndex = -1;
        }

        public void colocaDetalleCompra(int index)
        {
            DataGridViewRow fila = dtDetalleCompra.CurrentRow;
           // idDetalleCompra = index.ToString();
            fila.Selected = true;

            cbCompra.SelectedValue = fila.Cells[1].Value;
            cbProducto.SelectedValue = fila.Cells[2].Value;
            tbCantidad.Text = fila.Cells[3].Value.ToString();

        }

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

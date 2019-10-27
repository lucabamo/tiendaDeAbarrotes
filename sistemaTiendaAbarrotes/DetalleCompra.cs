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
        TextBox tbSubtotal;
        DataGridView dtDetalleCompra;
        string idDetalleCompra;


        public DetalleCompra(SqlConnection con, ComboBox compra, ComboBox producto, TextBox cantidad, TextBox subtotal, DataGridView compras)
        {
            conexion = con;
            cbCompra = compra;
            cbProducto = producto;
            tbCantidad = cantidad;
            tbSubtotal = subtotal;
            dtDetalleCompra = compras;

            actualizaTabla();
        }

        public void insertarDetalleCompra()
        {
            DataRowView Compra = (DataRowView)cbCompra.SelectedItem;
            DataRowView Producto = (DataRowView)cbProducto.SelectedItem;
            Int64 IdCompra = (Int64)Compra.Row.ItemArray[0];
            Int64 IdProducto = (Int64)Producto.Row.ItemArray[0]; ;

            string query = "INSERT INTO Transaccion.DetalleCompra (IdCompra, IdProducto, Cantidad, Subtotal) VALUES (@compra, @producto, @cantidad, @subtotal) ";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@compra", IdCompra);
            comando.Parameters.AddWithValue("@producto", IdProducto);
            comando.Parameters.AddWithValue("@cantidad", tbCantidad.Text);
            comando.Parameters.AddWithValue("@subtotal", tbSubtotal.Text);


            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                string query = "UPDATE Transaccion.Compra SET IdCompra = @compra, IdProducto = @producto, Cantidad = @cantidad, Subtotal = @subtotal WHERE IdDetalleCompra = @idDetalleCompra ";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@compra", IdCompra);
                comando.Parameters.AddWithValue("@producto", IdProducto);
                comando.Parameters.AddWithValue("@cantidad", tbCantidad.Text);
                comando.Parameters.AddWithValue("@subtotal", tbSubtotal.Text);
                comando.Parameters.AddWithValue("@idDetalleCompra", idDetalleCompra);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                actualizaTabla();

                cbCompra.Text = "";
                cbCompra.SelectedIndex = -1;
                cbProducto.Text = "";
                cbProducto.SelectedIndex = -1;
                tbCantidad.Text = "";
                tbSubtotal.Text = "";
            }
            else
                MessageBox.Show("Debe seleccionar una fila.");
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
            //cbCompra.Items.Clear();

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
            //cbProducto.Items.Clear();

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
            idDetalleCompra = index.ToString();
            fila.Selected = true;

            cbCompra.SelectedValue = fila.Cells[0].Value;
            cbProducto.SelectedValue = fila.Cells[1].Value;
            tbCantidad.Text = fila.Cells[2].Value.ToString();
            tbSubtotal.Text = fila.Cells[3].Value.ToString();

        }
    }
}

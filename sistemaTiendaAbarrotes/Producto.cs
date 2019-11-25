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
    public class Producto
    {
        SqlConnection conexion;
        TextBox tbNombre;
        TextBox tbExistencias;
        TextBox tbCostoProveedor;
        TextBox tbCostoVenta;
        DataGridView dtProducto;
        string idProd;

        public Producto(SqlConnection con, TextBox nombre, TextBox existencias, TextBox costoProv, TextBox costoVenta, DataGridView productos)
        {
            conexion = con;
            tbNombre = nombre;
            tbExistencias = existencias;
            tbCostoProveedor = costoProv;
            tbCostoVenta = costoVenta;
            dtProducto = productos;

            actualizaTabla();
        }

        public void insertarProducto()
        {
            string query = "INSERT INTO Inventario.Producto (Nombre, Existencia, CostoProveedor, CostoVenta) VALUES (@nombre, @existencia, @costoProveedor, @costoVenta) ";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", tbNombre.Text);
            comando.Parameters.AddWithValue("@existencia", tbExistencias.Text);
            comando.Parameters.AddWithValue("@costoProveedor", tbCostoProveedor.Text);
            comando.Parameters.AddWithValue("@costoVenta", tbCostoVenta.Text);
            

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la inserción");
            }

            actualizaTabla();
        }


        public void modificarProducto()
        {
            if (idProd != null)
            {
                string query = "UPDATE Inventario.Producto SET Nombre = @nombre, Existencia = @existencia, CostoProveedor = @costoProveedor, CostoVenta = @costoVenta WHERE IdProducto = @idProd ";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", tbNombre.Text);
                comando.Parameters.AddWithValue("@existencia", tbExistencias.Text);
                comando.Parameters.AddWithValue("@costoProveedor", tbCostoProveedor.Text);
                comando.Parameters.AddWithValue("@costoVenta", tbCostoVenta.Text);
                comando.Parameters.AddWithValue("@idProd", idProd);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error en la modificación");
                }

                actualizaTabla();

                tbNombre.Text = "";
                tbCostoProveedor.Text = "";
                tbCostoVenta.Text = "";
                tbExistencias.Text = "";
            }
            else
                MessageBox.Show("Debe seleccionar una fila.");
        }

        public void eliminarProducto()
        {
            if (idProd != null)
            {
                string query = "DELETE FROM Inventario.Producto WHERE IdProducto = @idProd";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idProd", idProd);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar");
                }

                actualizaTabla();

                tbNombre.Text = "";
                tbExistencias.Text = "";
                tbCostoProveedor.Text = "";
                tbCostoVenta.Text = "";

            }
            else
                MessageBox.Show("Debe seleccionar una fila.");
        }

        public void actualizaTabla()
        {
            string query2 = "SELECT * FROM Inventario.Producto";
            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando2);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtProducto.DataSource = tabla;
        }

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

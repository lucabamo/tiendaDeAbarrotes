using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaTiendaAbarrotes
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
            conectar();

        }

        private void conectar()
        {
            string connectionString = null;
            //Cadena de conexión
            connectionString = "Server=LAPTOP-M8A5375A\\SQLEXPRESS; Database = TiendaAbarrotes; Trusted_Connection = true;";

            conexion = new SqlConnection(connectionString);
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar");
            }
        }

        private void consultaTablaDetalleDevolucion() {
            string consulta = "SELECT * FROM Transaccion.DetalleDevolucion";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dGDetalleDevoluciones.DataSource = tabla;
        }

        private void consultaTablaEntrega() {
            string consulta = "SELECT * FROM Transaccion.Entrega";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dGEntregas.DataSource = tabla;
        }

        private void TabVistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabVistas.SelectedIndex) {
                case 9:
                    DetalleDevolucion detalleDevolucion = new DetalleDevolucion(conexion);
                    detalleDevolucion.Consulta(dGDetalleDevoluciones);
                    break;
                case 10:
                    Entrega entrega = new Entrega(conexion);
                    entrega.Consulta(dGEntregas);
                    break;
            }
        }

        private void editarRegistro(string sidProducto)
        {
            string consulta = "SELECT * FROM Inventario.Producto WHERE idProducto = " + sidProducto;
            try
            {
                using (var command = new SqlCommand(consulta, conexion))
                {
                    Int64 idProducto = 0;
                    string nombreProducto = "";
                    double precioVenta = 0.0;
                    double precioCompra = 0.0;
                    int existencia = 0;
                    // Process results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idProducto = (Int64)reader["idProducto"];
                            nombreProducto = (string)reader["Nombre"];
                            precioVenta = (double)reader["PrecioVenta"];
                            precioCompra = (double)reader["PrecioCompra"];
                            existencia = (int)reader["Existencia"];
                        }
                    }
                  /*  tbIdProducto.Text = idProducto.ToString();
                    tbNombre.Text = nombreProducto;
                    tbPrecioVenta.Text = precioVenta.ToString();
                    tbPrecioCompra.Text = precioCompra.ToString();
                    tbExistencia.Text = existencia.ToString();*/
                }
            }
            catch (Exception e)
            {

            }
        }
        private void insertaEntrega()
        {
            //Int64 IdProveedor = 0;
            Int64 IdEmpleado = 0;
            Int64 IdDevolucion = 0;

            string consulta = "";
            consulta = "SELECT * FROM Empresa.Proveedor";

            using (var command = new SqlCommand(consulta, conexion))
            {
                Int64 IdProveedor = 0;
                string nombreProveedor = "";
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IdProveedor = (Int64)reader["IdProveedor"];
                        nombreProveedor = (string)reader["Nombre"];
                        cBIdProveedor.Items.Add(nombreProveedor);
                    }
                }

            }

                /*

                string query = "INSERT INTO Inventario.Producto (Nombre, PrecioVenta, PrecioCompra, Existencia) " +
                        "VALUES (@nombre, @precioventa,@preciocompra,@existencia)";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", tbNombre.Text);
                comando.Parameters.AddWithValue("@precioventa", tbPrecioVenta.Text);
                comando.Parameters.AddWithValue("@preciocompra", tbPrecioCompra.Text);
                comando.Parameters.AddWithValue("@existencia", tbExistencia.Text);
                try
                {
                    comando.ExecuteNonQuery();
                    if (enEdicion)
                    {
                        //MessageBox.Show("Edición Correcta");
                        enEdicion = false;
                    }
                    else
                    {
                        // MessageBox.Show("Inserción correcta");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex.Message);
                }
                refrescaTodo();
                */
            }

    }
}

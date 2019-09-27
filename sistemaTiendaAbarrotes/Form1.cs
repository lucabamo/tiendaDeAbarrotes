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
        DetalleDevolucion detalleDevolucion;
        Entrega entrega;
        public Form1()
        {
            InitializeComponent();
            conectar();
            detalleDevolucion = new DetalleDevolucion(conexion);
            entrega = new Entrega(conexion);

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
        private void TabVistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabVistas.SelectedIndex)
            {
                case 9:
                    detalleDevolucion.Consulta(dGDetalleDevoluciones);
                    break;
                case 10:
                    entrega.Consulta(dGEntregas);
                    entrega.llenaComboBox(cBIdProveedor, cBIdDevolucion, cBIdEmpleado);
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
                }
            }
            catch (Exception e)
            {

            }
        }

        private void BAgregarEntrega_Click(object sender, EventArgs e)
        {
            entrega.Inserta(cBIdProveedor, cBIdDevolucion, cBIdEmpleado, dTFechaEntrega);
            entrega.Consulta(dGEntregas);
        }
    }
}

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
        Venta venta;
        public Form1()
        {
            InitializeComponent();
            venta = new Venta();
            conectar();

        }

        private void conectar()
        {
            string connectionString = null;
            //Cadena de conexión
            connectionString = "Server=DESKTOP-AP88PFE\\SQLEXPRESS; Database = TiendaAbarrotes; Trusted_Connection = true;";

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

        private void btAgregarVenta_Click(object sender, EventArgs e)
        {
            dgVentas.DataSource = "";
            venta.insertVenta(conexion, tbIdEmpleado.Text, tbFechaVenta.Text, tbTotal.Text);
            dgVentas.DataSource = venta.selectVentas(conexion);
            resetTabVentas();
        }

        private void btModificarVenta_Click(object sender, EventArgs e)
        {
            dgVentas.DataSource = "";
            venta.updateVenta(conexion, tbIdEmpleado.Text, tbFechaVenta.Text, tbTotal.Text, venta.IdVenta);
            dgVentas.DataSource =  venta.selectVentas(conexion);
            resetTabVentas();
        }

        private void btEliminarVenta_Click(object sender, EventArgs e)
        {
            dgVentas.DataSource = "";
            venta.deleteVenta(conexion, venta.IdVenta);
            dgVentas.DataSource = venta.selectVentas(conexion);
            resetTabVentas();
        }

        private void dgVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dgVentas.Rows.Count - 1 && dgVentas.Rows[e.RowIndex].Cells[0].Value != null)
            {
                venta.IdVenta = dgVentas.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbIdEmpleado.Text = dgVentas.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbFechaVenta.Text = dgVentas.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbTotal.Text = dgVentas.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void tabVenta_Enter(object sender, EventArgs e)
        {
            dgVentas.DataSource = "";
            dgVentas.DataSource = venta.selectVentas(conexion);
        }

        private void resetTabVentas()
        {
            tbIdEmpleado.Text = "";
            tbFechaVenta.Text = "";
            tbTotal.Text = "";
        }
    }
}

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
        Venta venta;
        Promocion promocion;
        DetalleVenta detalleVenta;
        public Form1()
        {
            InitializeComponent();
            venta = new Venta();
            promocion = new Promocion();
            detalleVenta = new DetalleVenta();
            conectar();
            detalleDevolucion = new DetalleDevolucion(conexion,cbIdDevolucionDetalleDevo,cbIdProductoDetalleDevo,
                tbCantidadDetalleDevo);
            entrega = new Entrega(conexion,cBIdProveedor,cBIdDevolucion,cBIdEmpleado,dTFechaEntregaEntregas);

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
        private void TabVistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabVistas.SelectedIndex)
            {
                case 9:
                    detalleDevolucion.Consulta(dGDetalleDevoluciones);
                    break;
                case 10:
                    entrega.Consulta(dGEntregas);
                    break;
            }
        }

        private void BAgregarEntrega_Click(object sender, EventArgs e)
        {
            entrega.Inserta();
            entrega.Consulta(dGEntregas);
        }

        private void DGEntregas_CellClick(object sender, DataGridViewCellEventArgs e)
        {      
            string ID = dGEntregas.Rows[e.RowIndex].Cells[0].Value.ToString();
            entrega.AccesoIdEntregaSeleccionada = ID;
            entrega.cargaRegistroSeleccionado();
        }

        private void BEliminaEntrega_Click(object sender, EventArgs e)
        {
            entrega.eliminaRegistroSeleccionado();
            entrega.Consulta(dGEntregas);
        }

        private void BEditarEntrega_Click(object sender, EventArgs e)
        {
            entrega.editaRegistroSeleccionado();
            entrega.Consulta(dGEntregas);
        }

        private void DGDetalleDevoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dGDetalleDevoluciones.Rows[e.RowIndex].Cells[0].Value.ToString();
            detalleDevolucion.accesoIdDevolucion = ID;
            detalleDevolucion.cargaRegistroSeleccionado();
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

        private void btAgregarPromocion_Click(object sender, EventArgs e)
        {
            dgPromocion.DataSource = "";
            promocion.insertPromocion(conexion, tbIdProducto.Text, tbFechaInicio.Text, tbFechaFinal.Text, tbDescuento.Text);
            dgPromocion.DataSource = promocion.selectPromocion(conexion);
            resetTabPromocion();
        }

        private void btModificarPromocion_Click(object sender, EventArgs e)
        {
            dgPromocion.DataSource = "";
            promocion.updatePromocion(conexion, tbIdProducto.Text, tbFechaInicio.Text, tbFechaFinal.Text, tbDescuento.Text, promocion.IdPromocion);
            dgPromocion.DataSource = promocion.selectPromocion(conexion);
            resetTabPromocion();
        }

        private void btEliminarPromocion_Click(object sender, EventArgs e)
        {
            dgPromocion.DataSource = "";
            promocion.deletePromocion(conexion, promocion.IdPromocion);
            dgPromocion.DataSource = promocion.selectPromocion(conexion);
            resetTabPromocion();
        }

        private void dgPromocion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dgPromocion.Rows.Count - 1 && dgPromocion.Rows[e.RowIndex].Cells[0].Value != null)
            {
                promocion.IdPromocion = dgPromocion.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbIdProducto.Text = dgPromocion.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbFechaInicio.Text = dgPromocion.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbFechaFinal.Text = dgPromocion.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbDescuento.Text = dgPromocion.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void tabPromocion_Enter(object sender, EventArgs e)
        {
            dgPromocion.DataSource = "";
            dgPromocion.DataSource = promocion.selectPromocion(conexion);
        }

        private void resetTabPromocion()
        {
            tbIdProducto.Text = "";
            tbFechaInicio.Text = "";
            tbFechaFinal.Text = "";
            tbDescuento.Text = "";
        }

        private void btAgregarDetalleVenta_Click(object sender, EventArgs e)
        {
            dgDetalleVenta.DataSource = "";
            detalleVenta.insertDetalleVenta(conexion, tbIdVenta.Text, tbIdPromocion.Text, tbIdProducto2.Text, tbCantidad.Text, tbSubtotal.Text);
            dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);
            resetTabDetalleVenta();
            
        }

        private void btModificarDetalleVenta_Click(object sender, EventArgs e)
        {
            dgDetalleVenta.DataSource = "";
            detalleVenta.updateDetalleVenta(conexion, tbIdVenta.Text, tbIdPromocion.Text, tbIdProducto2.Text, tbCantidad.Text, tbSubtotal.Text);
            dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);
            resetTabDetalleVenta();
        }

        private void btEliminarDetalleVenta_Click(object sender, EventArgs e)
        {
            dgDetalleVenta.DataSource = "";
            detalleVenta.deleteDetalleVenta(conexion, tbIdVenta.Text);
            dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);
            resetTabDetalleVenta();
        }

        private void dgDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dgDetalleVenta.Rows.Count - 1 && dgDetalleVenta.Rows[e.RowIndex].Cells[0].Value != null)
            {
                //promocion.IdPromocion = dgDetalleVenta.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbIdVenta.Text = dgDetalleVenta.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbIdPromocion.Text = dgDetalleVenta.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbIdProducto2.Text = dgDetalleVenta.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbCantidad.Text = dgDetalleVenta.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbSubtotal.Text = dgDetalleVenta.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void tabDetalleVenta_Enter(object sender, EventArgs e)
        {
            dgDetalleVenta.DataSource = "";
            dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);
            resetTabDetalleVenta();
        }

        private void resetTabDetalleVenta()
        {
            tbIdVenta.Text = "";
            tbIdPromocion.Text = "";
            tbIdProducto2.Text = "";
            tbCantidad.Text = "";
            tbSubtotal.Text = "";
        }

        
    }
}

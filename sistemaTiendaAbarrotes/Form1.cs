﻿using System;
using System.Data;
using System.Data.SqlClient;
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
        Producto producto;
        Compra compra;
        DetalleCompra detalleCompra;
        Empleado empleado;
        Proveedor proveedor;
        Devolucion devolucion;

        public Form1()
        {
            InitializeComponent();
            conectar();
            inicializaObjetos();
        }

        private void conectar()
        {
            string connectionString = null;
            //Cadena de conexión
            //LAPTOP-M8A5375A
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

        private void inicializaObjetos()
        {
            empleado = new Empleado(conexion, tbEmpleadoNombre, tbEmpleadoUsuario, tbEmpleadoPass, tbEmpleadoDomicilio, dTEmpleadoFN);
            proveedor = new Proveedor(conexion, tbNombreProveedor, tbTelefonoProveedor, tbEmailProveedor, tbRFCProveedor, tbDomicilioFiscal);
            producto = new Producto(conexion, tbNombreProducto, tbExistenciasProducto, tbCostoProvProducto, tbCostoVentaProducto, dtProducto);
            venta = new Venta();
            promocion = new Promocion();
            detalleVenta = new DetalleVenta();
            compra = new Compra(conexion, cbEmpleadoCompras, cbProveedorCompras, dateCompras, dtCompras);
            detalleCompra = new DetalleCompra(conexion, cbCompraDetalleCom, cbProductoDetalleCom, tbCantidadDetalleCom, dtDetalleCom);
            devolucion = new Devolucion(conexion, cbNombreEmpleadosDevo, cbVentasDevo, tbMotivoDevolucionDevo, dtFechaVentaDevo, tbCantidadDevo);
            detalleDevolucion = new DetalleDevolucion(conexion, cbIdDevolucionDetalleDevo, cbIdProductoDetalleDevo, tbCantidadDetalleDevo);
            entrega = new Entrega(conexion, cBIdProveedor, cBIdDevolucion, cBIdEmpleado, dTFechaEntregaEntregas);

        }

        private void TabVistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabVistas.SelectedIndex)
            {
                case 0:
                    empleado.Consulta(dGEmpleados);
                    break;
                case 1:
                    proveedor.Consulta(dgProveedores);
                    break;
                case 8:
                    devolucion.Consulta(dgDevoluciones);
                    break;
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
            detalleDevolucion.AccesoIdDetalleDevolucionSeleccionada = ID;
            detalleDevolucion.cargaRegistroSeleccionado();
        }

        private void btAgregarVenta_Click(object sender, EventArgs e)
        {
            dgVentas.DataSource = "";

            DataRowView Empleado = (DataRowView)cbEmpleadoVentas.SelectedItem;
            Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; 
            venta.insertVenta(conexion, IdEmpleado, dtpFechaVenta.Value.Date);
            dgVentas.DataSource = venta.selectVentas(conexion);
            resetTabVentas();
        }

        private void btModificarVenta_Click(object sender, EventArgs e)
        {
            dgVentas.DataSource = "";
            DataRowView Empleado = (DataRowView)cbEmpleadoVentas.SelectedItem;
            Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; ;
            venta.updateVenta(conexion, IdEmpleado, dtpFechaVenta.Value.Date);
            dgVentas.DataSource =  venta.selectVentas(conexion);
            resetTabVentas();
        }

        private void btEliminarVenta_Click(object sender, EventArgs e)
        {
            dgVentas.DataSource = "";
            venta.deleteVenta(conexion);
            dgVentas.DataSource = venta.selectVentas(conexion);
            resetTabVentas();
        }

        private void dgVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dgVentas.Rows.Count - 1 && dgVentas.Rows[e.RowIndex].Cells[0].Value != null)
            {
                venta.IdVenta = dgVentas.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbEmpleadoVentas.SelectedValue = dgVentas.Rows[e.RowIndex].Cells[1].Value;
                dtpFechaVenta.Value = (DateTime)dgVentas.Rows[e.RowIndex].Cells[2].Value;
            }
        }

        private void tabVenta_Enter(object sender, EventArgs e)
        {
            dgVentas.DataSource = "";
            dgVentas.DataSource = venta.selectVentas(conexion);
            venta.consultaEmpleados(conexion, cbEmpleadoVentas);

        }

        private void resetTabVentas()
        {
            cbEmpleadoVentas.Text = "";
            cbEmpleadoVentas.SelectedIndex = -1;
        }

        private void btAgregarPromocion_Click(object sender, EventArgs e)
        {
            dgPromocion.DataSource = "";

            DataRowView producto = (DataRowView)cbProductoPromocion.SelectedItem;
            Int64 idProducto = (Int64)producto.Row.ItemArray[0];

            promocion.insertPromocion(conexion, idProducto, dtpFechaInicioPromo.Value.Date, dtpFechaFinalPromo.Value.Date, tbDescuento.Text);
            dgPromocion.DataSource = promocion.selectPromocion(conexion);
            resetTabPromocion();
        }

        private void btModificarPromocion_Click(object sender, EventArgs e)
        {
            dgPromocion.DataSource = "";

            DataRowView producto = (DataRowView)cbProductoPromocion.SelectedItem;
            Int64 idProducto = (Int64)producto.Row.ItemArray[0];


            promocion.updatePromocion(conexion, idProducto, dtpFechaInicioPromo.Value.Date, dtpFechaFinalPromo.Value.Date, tbDescuento.Text, promocion.IdPromocion);
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
                cbProductoPromocion.SelectedValue = dgPromocion.Rows[e.RowIndex].Cells[1].Value;
                dtpFechaInicioPromo.Value = (DateTime)dgPromocion.Rows[e.RowIndex].Cells[2].Value;
                dtpFechaFinalPromo.Value = (DateTime)dgPromocion.Rows[e.RowIndex].Cells[3].Value;
                tbDescuento.Text = dgPromocion.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void tabPromocion_Enter(object sender, EventArgs e)
        {
            dgPromocion.DataSource = "";
            dgPromocion.DataSource = promocion.selectPromocion(conexion);
            promocion.consultaPromocion(conexion, cbProductoPromocion);
        }

        private void resetTabPromocion()
        {
            cbProductoPromocion.Text = "";
            cbProductoPromocion.SelectedValue = -1;
            tbDescuento.Text = "";
        }

        private void btAgregarDetalleVenta_Click(object sender, EventArgs e)
        {
            dgDetalleVenta.DataSource = "";
            DataRowView producto = (DataRowView)cbProductoDetalleVenta.SelectedItem;
            DataRowView venta = (DataRowView)cbIdVentaDetalleVenta.SelectedItem;
            DataRowView promocion = (DataRowView)cbIdPromocionDetalleVenta.SelectedItem;
            Int64 idProducto = (Int64)producto.Row.ItemArray[0];
            Int64 idVenta = (Int64)venta.Row.ItemArray[0];
            Int64 idPromocion = (Int64)promocion.Row.ItemArray[0];

            detalleVenta.insertDetalleVenta(conexion, idVenta, idPromocion, idProducto, tbCantidad.Text);
            dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);
            resetTabDetalleVenta();
            
        }

        private void btModificarDetalleVenta_Click(object sender, EventArgs e)
        {
            dgDetalleVenta.DataSource = "";
            DataRowView producto = (DataRowView)cbProductoDetalleVenta.SelectedItem;
            DataRowView venta = (DataRowView)cbIdVentaDetalleVenta.SelectedItem;
            DataRowView promocion = (DataRowView)cbIdPromocionDetalleVenta.SelectedItem;
            Int64 idProducto = (Int64)producto.Row.ItemArray[0];
            Int64 idVenta = (Int64)venta.Row.ItemArray[0];
            Int64 idPromocion = (Int64)promocion.Row.ItemArray[0];

            detalleVenta.updateDetalleVenta(conexion,idVenta, idPromocion, idProducto, tbCantidad.Text);
            dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);
            resetTabDetalleVenta();
        }

        private void btEliminarDetalleVenta_Click(object sender, EventArgs e)
        {
            dgDetalleVenta.DataSource = "";
            detalleVenta.deleteDetalleVenta(conexion);
            dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);
            resetTabDetalleVenta();
        }

        private void dgDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dgDetalleVenta.Rows.Count - 1 && dgDetalleVenta.Rows[e.RowIndex].Cells[0].Value != null)
            {
                detalleVenta.Id = dgDetalleVenta.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbIdVentaDetalleVenta.SelectedValue = dgDetalleVenta.Rows[e.RowIndex].Cells[1].Value;
                cbIdPromocionDetalleVenta.SelectedValue = dgDetalleVenta.Rows[e.RowIndex].Cells[2].Value;
                cbProductoDetalleVenta.SelectedValue = dgDetalleVenta.Rows[e.RowIndex].Cells[3].Value;
                tbCantidad.Text = dgDetalleVenta.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void tabDetalleVenta_Enter(object sender, EventArgs e)
        {
            dgDetalleVenta.DataSource = "";
            dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);
            detalleVenta.consultaProductos(conexion, cbProductoDetalleVenta);
            detalleVenta.consultaPromociones(conexion, cbIdPromocionDetalleVenta);
            detalleVenta.consultaVentas(conexion, cbIdVentaDetalleVenta);
        }

        private void resetTabDetalleVenta()
        {
            cbProductoDetalleVenta.Text = "";
            cbProductoDetalleVenta.SelectedValue = -1;
            cbIdPromocionDetalleVenta.Text = "";
            cbIdPromocionDetalleVenta.SelectedValue = -1;
            cbIdVentaDetalleVenta.Text = "";
            cbIdVentaDetalleVenta.SelectedValue = -1;
            tbCantidad.Text = "";
        }

        private void dtProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto.colocaProducto();
        }

        private void btInsertarProducto_Click(object sender, EventArgs e)
        {
            producto.insertarProducto();
        }

        private void btActualizarProducto_Click(object sender, EventArgs e)
        {
            producto.modificarProducto();
        }

        private void btEliminarProducto_Click(object sender, EventArgs e)
        {
            producto.eliminarProducto();
        }

        private void btInsertarCompras_Click(object sender, EventArgs e)
        {
            compra.insertarCompra();
        }

        private void btActualizarCompras_Click(object sender, EventArgs e)
        {
            compra.modificarCompra();
        }

        private void btEliminarCompras_Click(object sender, EventArgs e)
        {
            compra.eliminarCompra();
        }

        private void dtCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            compra.colocaCompra();
        }

        private void dtDetalleCom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detalleCompra.IdDetalleCompra = dtDetalleCom.Rows[e.RowIndex].Cells[0].Value.ToString();
            detalleCompra.colocaDetalleCompra(dtDetalleCom.CurrentRow.Index);
        }

        private void btInsertarDetalleCom_Click(object sender, EventArgs e)
        {
            detalleCompra.insertarDetalleCompra();
        }

        private void btActualizarDetalleCom_Click(object sender, EventArgs e)
        {
            detalleCompra.modificarDetalleCompra();
        }

        private void btEliminarDetalleCompra_Click(object sender, EventArgs e)
        {
            detalleCompra.deleteDetalleCompra(conexion);
        }

        private void BAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (tbEmpleadoNombre.Text != "" && tbEmpleadoPass.Text != "" && tbEmpleadoUsuario.Text != ""
                && tbEmpleadoDomicilio.Text != "")
            {
                empleado.Inserta();
                empleado.Consulta(dGEmpleados);
            }
            else {
                MessageBox.Show("Todos los campos son necesarios");
            }
        }

        private void BEliminarEmpleado_Click(object sender, EventArgs e)
        {
            empleado.eliminaRegistroSeleccionado();
            empleado.Consulta(dGEmpleados);
        }

        private void DGEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dGEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
            empleado.AccesoIdEmpleadoSeleccionado = ID;
            empleado.cargaRegistroSeleccionado();
        }

        private void BEditarEmpleado_Click(object sender, EventArgs e)
        {
            empleado.editaRegistroSeleccionado();
            empleado.Consulta(dGEmpleados);
        }

        private void BAgregarProveedor_Click(object sender, EventArgs e)
        {
            proveedor.Inserta();
            proveedor.Consulta(dgProveedores);
        }

        private void DgProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dgProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            proveedor.AccesoIdProveedorSeleccionado = ID;
            proveedor.cargaRegistroSeleccionado();
        }

        private void BEditarProveedor_Click(object sender, EventArgs e)
        {
            proveedor.editaRegistroSeleccionado();
            proveedor.Consulta(dgProveedores);
        }

        private void BEliminaProveedor_Click(object sender, EventArgs e)
        {
            proveedor.eliminaRegistroSeleccionado();
            proveedor.Consulta(dgProveedores);
        }

        private void BAgregarDevo_Click(object sender, EventArgs e)
        {
            devolucion.Inserta();
            devolucion.Consulta(dgDevoluciones);
        }

        private void DgDevoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dgDevoluciones.Rows[e.RowIndex].Cells[0].Value.ToString();
            devolucion.AccesoIDevolucionSeleccionada = ID;
            devolucion.cargaRegistroSeleccionado();
        }

        private void BEditarDevo_Click(object sender, EventArgs e)
        {
            devolucion.editaRegistroSeleccionado();
            devolucion.Consulta(dgDevoluciones);
        }

        private void BEliminarDevo_Click(object sender, EventArgs e)
        {
            devolucion.eliminaRegistroSeleccionado();
            devolucion.Consulta(dgDevoluciones);
        }

        private void tabCompra_Enter(object sender, EventArgs e)
        {
            compra.llenaNombreEmpleado();
            compra.llenaNombreProveedor();
            compra.actualizaTabla();
        }

        private void tabEmpleado_Enter(object sender, EventArgs e)
        {
            empleado.Consulta(dGEmpleados);
        }

        private void tabDetalleCompra_Enter(object sender, EventArgs e)
        {
            detalleCompra.llenaNombreCompra();
            detalleCompra.llenaNombreProducto();
        }

        private void tabProducto_Enter(object sender, EventArgs e)
        {
            producto.actualizaTabla();
        }

        private void BInsertaDetalleDev_Click(object sender, EventArgs e)
        {
            detalleDevolucion.Inserta();
            detalleDevolucion.Consulta(dGDetalleDevoluciones);
        }

        private void CbIdDevolucionDetalleDevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdProductoDetalleDevo.SelectedIndex != -1) {
                tbCantidadDetalleDevo.Enabled = true;
            }
        }

        private void CbIdProductoDetalleDevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdDevolucionDetalleDevo.SelectedIndex != -1) {
                tbCantidadDetalleDevo.Enabled = true;
            }
        }

        private void BEditaDetalleDev_Click(object sender, EventArgs e)
        {
            detalleDevolucion.Edita();
            detalleDevolucion.Consulta(dGDetalleDevoluciones);
        }

        private void BEliminaDetalleDev_Click(object sender, EventArgs e)
        {
            detalleDevolucion.eliminaRegistroSeleccionado();
            detalleDevolucion.Consulta(dGDetalleDevoluciones);
        }
    }
}

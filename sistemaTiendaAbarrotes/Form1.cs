using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistemaTiendaAbarrotes
{
    // Formulario principal, en este se despliegan todas las pestañas para las diferentes
    // pantallas del sistema.
    public partial class Form1 : Form
    {
        // Variables globales
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


        // Constructor del formulario principal
        public Form1()
        {
            InitializeComponent();
            conectar(); // Conexion con la base de datos
            inicializaObjetos(); // Inicializa variables
        }



        // Metodo para hacer la conexion con la base de datos
        private void conectar()
        {
            string connectionString = null;
            //Cadena de conexión
            //LAPTOP-M8A5375A
            //connectionString = "Server=DESKTOP-AP88PFE\\SQLEXPRESS; Database = TiendaAbarrotes; Trusted_Connection = true;";
            connectionString = "Server=LAPTOP-R32V8BCP\\SQLEXPRESS; Database = TiendaAbarrotes; Trusted_Connection = true;";

            conexion = new SqlConnection(connectionString);

            // Abre la conexion con la  base y manda un mensaje de confirmacion
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión correcta.");
            }
            // En caso de no poder realizar la conexion, avisa con un mensaje
            catch (Exception ex)
            {
                MessageBox.Show("Conexión fallida.");
            }
        }



        // Metodo para inicializar todas las variables globales, 
        // mandando por parametro los correspondientes controles
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



        // Metodo del evento de cambio de una pestaña, dependiendo del indice de la pestaña en la que se encuentre
        // realiza una consulta para llenar la tabla de datos correspondiente, pasa por parametro el Data Grid a llenar
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
                    cbIdDevolucionDetalleDevo.SelectedIndex = -1;
                    detalleDevolucion.Consulta(dGDetalleDevoluciones);
                    break;
                case 10:
                    entrega.Consulta(dGEntregas);
                    break;
            }
        }



        // Metodo del evento del boton "Insertar" en la pestaña Entrega
        private void BAgregarEntrega_Click(object sender, EventArgs e)
        {
            entrega.Inserta(); // Llama al metodo que inserta una tupla en Entrega
            entrega.Consulta(dGEntregas); // Refresca la tabla con el nuevo registro
        }



        // Metodo del evento Click en una celda de la tabla Entrega
        private void DGEntregas_CellClick(object sender, DataGridViewCellEventArgs e)
        {      
            string ID = dGEntregas.Rows[e.RowIndex].Cells[0].Value.ToString(); // Extrae el Id del registro
            entrega.AccesoIdEntregaSeleccionada = ID;
            entrega.cargaRegistroSeleccionado(); // Carga el registro en los controles de texto
        }



        // Metodo del evento del boton "Eliminar" en la pestaña Entrega
        private void BEliminaEntrega_Click(object sender, EventArgs e)
        {
            entrega.eliminaRegistroSeleccionado(); // Llama al metodo que elimina una tupla
            entrega.Consulta(dGEntregas); // Refresca la tabla sin el registro eliminado
        }



        // Metodo del evento del boton "Modificar" en la pestaña Entrega
        private void BEditarEntrega_Click(object sender, EventArgs e)
        {
            entrega.editaRegistroSeleccionado(); // Llama al metodo que modifica una tupla
            entrega.Consulta(dGEntregas); // Refresca la tabla con los nuevos datos el registro
        }



        // Metodo del evento Click en una celda de la tabla Detalle Devolucion
        private void DGDetalleDevoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
   
            string ID = dGDetalleDevoluciones.Rows[e.RowIndex].Cells[0].Value.ToString(); // Extrae el Id del registro
            detalleDevolucion.AccesoIdDetalleDevolucionSeleccionada = ID;
            detalleDevolucion.cargaRegistroSeleccionado(); // Carga el registro en los controles de texto
        }



        // Metodo del evento del boton "Insertar" de la tabla Venta
        private void btAgregarVenta_Click(object sender, EventArgs e)
        {
            dgVentas.DataSource = "";   // Limpia la cadena de la fuente de los datos de la tabla
            
            // Extrae los datos de los controles de texto y los manda al metodo Insertar Venta y se actualiza la tabla
            try
            {
                DataRowView Empleado = (DataRowView)cbEmpleadoVentas.SelectedItem;
                Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0];
                venta.insertVenta(conexion, IdEmpleado, dtpFechaVenta.Value.Date);
                dgVentas.DataSource = venta.selectVentas(conexion);
                resetTabVentas();
            }
            // Si no se puede realizar la insercion se avisa con un mensaje y se actualiza la tabla
            catch (Exception ex) {
                MessageBox.Show("Es necesario insertar todos los campos");
                dgVentas.DataSource = venta.selectVentas(conexion);
            }

        }



        // Metodo del evento del boton "Modificar" de la tabla Venta
        private void btModificarVenta_Click(object sender, EventArgs e)
        {
            dgVentas.DataSource = "";   // Limpia la cadena de la fuente de los datos de la tabla

            // Extrae los datos de los controles de texto y los manda al metodo Modificar Venta y se actualiza la tabla
            DataRowView Empleado = (DataRowView)cbEmpleadoVentas.SelectedItem;
            Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; ;
            venta.updateVenta(conexion, IdEmpleado, dtpFechaVenta.Value.Date);
            dgVentas.DataSource =  venta.selectVentas(conexion);
            resetTabVentas();
        }



        // Metodo del evento del boton "Eliminar" de la tabla Venta
        private void btEliminarVenta_Click(object sender, EventArgs e)
        {
            dgVentas.DataSource = "";   // Limpia la cadena de la fuente de los datos de la tabla

            // Llama al metodo Eliminar Venta y se actualiza la tabla
            venta.deleteVenta(conexion);
            dgVentas.DataSource = venta.selectVentas(conexion);
            resetTabVentas();
        }



        // Metodo del evento Click en una celda de la tabla Venta
        private void dgVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Valida que la fila tengga datos
            if (e.RowIndex < dgVentas.Rows.Count - 1 && dgVentas.Rows[e.RowIndex].Cells[0].Value != null)
            {
                // Identifica el Id de la venta seleccionada
                venta.IdVenta = dgVentas.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Carga el registro en los controles de texto
                cbEmpleadoVentas.SelectedValue = dgVentas.Rows[e.RowIndex].Cells[1].Value;
                dtpFechaVenta.Value = (DateTime)dgVentas.Rows[e.RowIndex].Cells[2].Value;
            }
        }



        // Metodo que se ejecuta cuando la tabla Venta esta activa
        private void tabVenta_Enter(object sender, EventArgs e)
        {
            // Actualiza la tabla de ventas
            dgVentas.DataSource = "";
            dgVentas.DataSource = venta.selectVentas(conexion);

            // Actualiza el combo box de los empleados que esten actualmente registrados
            venta.consultaEmpleados(conexion, cbEmpleadoVentas);

        }



        // Metodo para reiniciar los controles de la pestaña Venta
        private void resetTabVentas()
        {
            // Elimina el texto del combo box y quita el elemento seleccionado actualmente
            cbEmpleadoVentas.Text = "";
            cbEmpleadoVentas.SelectedIndex = -1;
        }



        // Metodo del evento del boton "Insertar" de la tabla Promocion
        private void btAgregarPromocion_Click(object sender, EventArgs e)
        {
            // Coloca un descuento de 0 cuando no se selecciona ningun otro
            if (cBDescuentos.Text == "")
            {
                cBDescuentos.Text = "0.0";
            }
            
            
            try
            {
                dgPromocion.DataSource = "";    // Limpia la fuente de datos de la tabla

                // Extrae los datos de los controles de texto y los manda al metodo de Insertar Promocion
                DataRowView producto = (DataRowView)cbProductoPromocion.SelectedItem;
                Int64 idProducto = (Int64)producto.Row.ItemArray[0];
                promocion.insertPromocion(conexion, idProducto, dtpFechaInicioPromo.Value.Date, dtpFechaFinalPromo.Value.Date, cBDescuentos.Text);

                // Actualiza la tabla y reinicia los controles de combo box
                dgPromocion.DataSource = promocion.selectPromocion(conexion);
                resetTabPromocion();
            }

            // En caso de no poder realizar la conexion muestra un mensaje
            catch (Exception ex)
            {
                MessageBox.Show("Es necesario insertar todos los campos");
                dgPromocion.DataSource = promocion.selectPromocion(conexion);
            }
                
            
        }


        // Metodo para el evento del boton "Modificar" de la tabla Promocion
        private void btModificarPromocion_Click(object sender, EventArgs e)
        {
            dgPromocion.DataSource = "";    // Limpia la fuente de datos de la tabla

            // Extrae los datos de los controles de texto y los manda al metodo de Modificar Promocion
            DataRowView producto = (DataRowView)cbProductoPromocion.SelectedItem;
            Int64 idProducto = (Int64)producto.Row.ItemArray[0];
            promocion.updatePromocion(conexion, idProducto, dtpFechaInicioPromo.Value.Date, dtpFechaFinalPromo.Value.Date, cBDescuentos.Text, promocion.IdPromocion);

            // Actualiza la tabla y reinicia los controles de texto y combo box
            dgPromocion.DataSource = promocion.selectPromocion(conexion);
            cBDescuentos.Text = "";
            resetTabPromocion();
        }


        // Metodo para el evento del boton "Eliminar" de la tabla Promocion
        private void btEliminarPromocion_Click(object sender, EventArgs e)
        {
            dgPromocion.DataSource = "";    // Limpia la fuente de datos de la tabla

            // Llama al metodo de Eliminar Promocion y manda el Id del registro seleccionado
            promocion.deletePromocion(conexion, promocion.IdPromocion);

            // Actualiza la tabla y reinicia los controles de combo box
            dgPromocion.DataSource = promocion.selectPromocion(conexion);
            resetTabPromocion();
        }


        // Metodo para el evento Click a una celda de la tabla Promocion
        private void dgPromocion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Valida que la fila tenga datos
            if (e.RowIndex < dgPromocion.Rows.Count - 1 && dgPromocion.Rows[e.RowIndex].Cells[0].Value != null)
            {
                // Identifica el Id de la fila seleccionada
                promocion.IdPromocion = dgPromocion.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Carga el registro en los controles de texto de la pestaña
                cbProductoPromocion.SelectedValue = dgPromocion.Rows[e.RowIndex].Cells[1].Value;
                dtpFechaInicioPromo.Value = (DateTime)dgPromocion.Rows[e.RowIndex].Cells[2].Value;
                dtpFechaFinalPromo.Value = (DateTime)dgPromocion.Rows[e.RowIndex].Cells[3].Value;
                string desc = dgPromocion.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (desc == "0")
                {
                    cBDescuentos.Text = "0.0";

                }
                else {
                    cBDescuentos.Text = dgPromocion.Rows[e.RowIndex].Cells[4].Value.ToString();
                }

            }
        }


        // Metodo que se ejecuta cuando la pestaña Promocion esta activa
        private void tabPromocion_Enter(object sender, EventArgs e)
        {
            // Actualiza la tabla de Promocion
            dgPromocion.DataSource = "";
            dgPromocion.DataSource = promocion.selectPromocion(conexion);
            promocion.consultaPromocion(conexion, cbProductoPromocion);
        }


        // Metodo para reiniciar los controles de la tabla Promocion
        private void resetTabPromocion()
        {
            // Elimina el texto del combo box y quita el elemento seleccionado actualmente
            cbProductoPromocion.Text = "";
            cbProductoPromocion.SelectedValue = -1;
            cBDescuentos.Text = "";
        }


        // Metodo para el evento del boton "Insertar" de la pestaña Detalle Venta
        private void btAgregarDetalleVenta_Click(object sender, EventArgs e)
        {
            try
            {
                dgDetalleVenta.DataSource = "";     // Limpia la fuente de datos de la tabla

                // Extrae los datos de los controles de texto
                DataRowView producto = (DataRowView)cbProductoDetalleVenta.SelectedItem;
                DataRowView venta = (DataRowView)cbIdVentaDetalleVenta.SelectedItem;
                DataRowView promocion = (DataRowView)cbIdPromocionDetalleVenta.SelectedItem;
                Int64 idPromocion;

                // Si no se selecciona ninguna promocion por default se selecciona la numero 1,
                // que es una promocion de 0
                if (promocion == null)
                {
                    idPromocion = 1;
                }
                else {
                    idPromocion = (Int64)promocion.Row.ItemArray[0];
                }
                Int64 idProducto = (Int64)producto.Row.ItemArray[0];
                Int64 idVenta = (Int64)venta.Row.ItemArray[0];

                // Llama al metodo de Inserta Detalle Venta y manda los valores para el registro
                detalleVenta.insertDetalleVenta(conexion, idVenta, idPromocion, idProducto, tbCantidad.Text);

                // Actualiza la tabla con el nuevo registro y reinicia los controles de texto
                dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);
                resetTabDetalleVenta();
            }

            // Si no se puede insertar el registro avisa con un mensaje
            catch (Exception ex) {
                MessageBox.Show("Es necesario insertar todos los valores");
            }
        }


        // Metodo para el evento del boton "Modificar" de la pestaña Detalle Venta
        private void btModificarDetalleVenta_Click(object sender, EventArgs e)
        {
            dgDetalleVenta.DataSource = "";     // Limpia la fuente de datos de la tabla

            // Extrae los datos de los controles de texto
            DataRowView producto = (DataRowView)cbProductoDetalleVenta.SelectedItem;
            DataRowView venta = (DataRowView)cbIdVentaDetalleVenta.SelectedItem;
            DataRowView promocion = (DataRowView)cbIdPromocionDetalleVenta.SelectedItem;
            Int64 idProducto = (Int64)producto.Row.ItemArray[0];
            Int64 idVenta = (Int64)venta.Row.ItemArray[0];
            Int64 idPromocion = (Int64)promocion.Row.ItemArray[0];

            // Llama al metodo de Modificar Detalle Venta y manda los nuevos valores del registro
            detalleVenta.updateDetalleVenta(conexion,idVenta, idPromocion, idProducto, tbCantidad.Text);

            // Actualiza la tabla con los nuevos valores del registro y reinicia los controles de texto
            dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);
            resetTabDetalleVenta();
        }


        // Metodo para el evento del boton "Eliminar" de la pestaña Detalle Venta
        private void btEliminarDetalleVenta_Click(object sender, EventArgs e)
        {
            dgDetalleVenta.DataSource = "";     // Limpia la fuente de datos de la tabla

            // Llama al metodo de Eliminar Detalle Venta
            detalleVenta.deleteDetalleVenta(conexion);

            // Actualiza la tabla sin el registro eliminado y reinicia los controles de texto
            dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);
            resetTabDetalleVenta();
        }


        // Metodo para el evento Click en una celda de la tabla Detalle Venta
        private void dgDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Valida que la fila tenga datos
            if (e.RowIndex < dgDetalleVenta.Rows.Count - 1 && dgDetalleVenta.Rows[e.RowIndex].Cells[0].Value != null)
            {
                // Identifica el Id de la fila seleccionada
                detalleVenta.Id = dgDetalleVenta.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Carga los datos del registro en los controles de texto de la pestaña
                cbIdVentaDetalleVenta.SelectedValue = dgDetalleVenta.Rows[e.RowIndex].Cells[1].Value;
                cbIdPromocionDetalleVenta.SelectedValue = dgDetalleVenta.Rows[e.RowIndex].Cells[2].Value;
                cbProductoDetalleVenta.SelectedValue = dgDetalleVenta.Rows[e.RowIndex].Cells[3].Value;
                tbCantidad.Text = dgDetalleVenta.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }


        // Metodo que se ejecuta cuando la pestaña Detalle Venta esta activa
        private void tabDetalleVenta_Enter(object sender, EventArgs e)
        {
            dgDetalleVenta.DataSource = ""; // Limpia la fuente de datos de la tabla

            // Actualiza la tabla
            dgDetalleVenta.DataSource = detalleVenta.selectDetalleVenta(conexion);

            // Carga los productos y las ventas en los combo box, mediante consultas de las tablas correspondientes
            detalleVenta.consultaProductos(conexion, cbProductoDetalleVenta);
            detalleVenta.consultaVentas(conexion, cbIdVentaDetalleVenta);

            // Pone los controles en blanco y deshabilita el combo box de promociones
            cbProductoDetalleVenta.SelectedText = "";
            cbProductoDetalleVenta.SelectedIndex = -1;
            cbIdPromocionDetalleVenta.Enabled = false;
        }


        // Metodo para restablacer los valores de los controles de la pestaña Detalle Venta
        private void resetTabDetalleVenta()
        {
            // Limpia el texto y el elemento seleccionado en el combo box de producto
            cbProductoDetalleVenta.Text = "";
            cbProductoDetalleVenta.SelectedValue = -1;

            // Limpia el texto y el elemento seleccionado en el combo box de promocion
            // Deshabilita el combo box de promocion
            cbIdPromocionDetalleVenta.Enabled = false;
            cbIdPromocionDetalleVenta.Text = "";
            cbIdPromocionDetalleVenta.SelectedValue = -1;

            // Limpia el texto y el elemento seleccionado en el combo box de venta
            cbIdVentaDetalleVenta.Text = "";
            cbIdVentaDetalleVenta.SelectedValue = -1;

            // Limpia el texto de cantidad
            tbCantidad.Text = "";
        }


        // Metodo para el evento de Click en una celda de la tabla Producto
        private void dtProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Llama al metodo para cargar un registro en los controles de texto de la pestaña
            producto.colocaProducto();
        }


        // Metodo para el evento del boton "Insertar" de la pestaña Producto 
        private void btInsertarProducto_Click(object sender, EventArgs e)
        {
            // Valida que no exista un campo vacio 
            if (tbCostoProvProducto.Text != "" && tbCostoVentaProducto.Text != "" && tbNombreProducto.Text != ""
                && tbExistenciasProducto.Text != "")
            {
                // Llama al metodo para insertar un producto
                producto.insertarProducto();
            }
            else {
                // Manda un mensaje cuando falta algun campo de llenar
                MessageBox.Show("Es necesario llenar todos los campos");
            }
        }


        // Metodo para el evento del boton "Modificar" en la pestaña Producto
        private void btActualizarProducto_Click(object sender, EventArgs e)
        {
            // Llama al metodo para modificar un producto
            producto.modificarProducto();
        }


        // Metodo para el evento del boton "Eliminar" en la pestaña Producto 
        private void btEliminarProducto_Click(object sender, EventArgs e)
        {
            // Llama al metodo para eliminar un producto
            producto.eliminarProducto();
        }


        // Metodo para el evento del boton "Insertar" en la pestaña Compra
        private void btInsertarCompras_Click(object sender, EventArgs e)
        {
            // Llama al metodo para insertar una compra 
            compra.insertarCompra();
        }


        // Metodo para el evento del boton "Modificar" en la pestaña Compra
        private void btActualizarCompras_Click(object sender, EventArgs e)
        {
            // Llama al metodo para modificar una compra
            compra.modificarCompra();
        }


        // Metodo para el evento del boton "Eliminar" en la pestaña Compras
        private void btEliminarCompras_Click(object sender, EventArgs e)
        {
            // Llama al metodo para eliminar una compra 
            compra.eliminarCompra();
        }


        // Metodo para el evento de Click en una celda de la tabla Compras
        private void dtCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Llama al metodo que carga el registro seleccionado en los controles de texto de la pestaña
            compra.colocaCompra();
        }


        // Metodo para el evento de Click en una celda de la tabla Detalle Compra
        private void dtDetalleCom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Identifiica la fila que esta seleccionada
            detalleCompra.IdDetalleCompra = dtDetalleCom.Rows[e.RowIndex].Cells[0].Value.ToString();

            // Llama al metodo que carga el registro seleccionado en los controles de texto de la pestaña
            detalleCompra.colocaDetalleCompra(dtDetalleCom.CurrentRow.Index);
        }


        // Metodo para el evento del boton "Insertar" de la pestaña Detalle Compra
        private void btInsertarDetalleCom_Click(object sender, EventArgs e)
        {
            // Llama al metodo para insertar un detalle de compra
            detalleCompra.insertarDetalleCompra();
        }


        // Metodo para el evento del boton "Modificar" de la pestaña Detalle Compra
        private void btActualizarDetalleCom_Click(object sender, EventArgs e)
        {
            // Llama al metodo para modificar un detalle de compra
            detalleCompra.modificarDetalleCompra();
        }


        // Metodo para el evento del boton "Eliminar" de la pestaña Detalle Compra
        private void btEliminarDetalleCompra_Click(object sender, EventArgs e)
        {
            // Llama al metodo para eliminar un detalle de compra
            detalleCompra.deleteDetalleCompra(conexion);
        }


        // Metodo para el evento Click de una celda de la tabla Empleado
        private void BAgregarEmpleado_Click(object sender, EventArgs e)
        {
            // Valida que todos los campos tengan informacion
            if (tbEmpleadoNombre.Text != "" && tbEmpleadoPass.Text != "" && tbEmpleadoUsuario.Text != ""
                && tbEmpleadoDomicilio.Text != "")
            {
                // Llama al metodo para insertar un empleado y actualiza la tabla
                empleado.Inserta();
                empleado.Consulta(dGEmpleados);
            }
            else {
                // Manda un mensaje si alguno de los campos esta vacio
                MessageBox.Show("Todos los campos son necesarios");
            }
        }


        // Metodo para el evento del boton "Eliminar" de la pestaña Empleado
        private void BEliminarEmpleado_Click(object sender, EventArgs e)
        {
            // Llama al metodo para eliminar un empleado y actualiza la tabla
            empleado.eliminaRegistroSeleccionado();
            empleado.Consulta(dGEmpleados);
        }


        // Metodo para el evento Click de una celda de la tabla Empleado
        private void DGEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Valida que haya registros en la tabla 
            if (e.RowIndex != -1)
            {
                // Identifica el Id del registro que esta seleccionado
                string ID = dGEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
                empleado.AccesoIdEmpleadoSeleccionado = ID;

                // Carga el registro seleccionado en los controles de texto 
                empleado.cargaRegistroSeleccionado();
            }
        }


        // Metodo para el evento del boton "Modificar" de la pestaña Empleado
        private void BEditarEmpleado_Click(object sender, EventArgs e)
        {
            // Llama al metodo para modificar un empleado y actualiza la tabla
            empleado.editaRegistroSeleccionado();
            empleado.Consulta(dGEmpleados);
        }


        // Metodo para el evento del boton "Insertar" de la pestaña Proveedor
        private void BAgregarProveedor_Click(object sender, EventArgs e)
        {
            // Valida que todos los campos tengan informacion
            if (tbNombreProveedor.Text != "" && tbRFCProveedor.Text != "" && tbTelefonoProveedor.Text != "" &&
                tbEmailProveedor.Text != "")
            {
                // Llama al metodo para insertar un proveedor y actualiza la tabla
                proveedor.Inserta();
                proveedor.Consulta(dgProveedores);
            }
            else {
                // Manda un mensaje cuando alguno de los campos esta vacio
                MessageBox.Show("Todos los campos son necesarios");
            }
        }


        // Metodo para el evnto de Click en una celda de la tabla Proveedores
        private void DgProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Identifica el Id del registro seleccionado
            string ID = dgProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            proveedor.AccesoIdProveedorSeleccionado = ID;

            // Carga el registro seleccionado en los controles de texto
            proveedor.cargaRegistroSeleccionado();
        }


        // Metodo para el evento del boton "Modificar de la pestaña Proveedor
        private void BEditarProveedor_Click(object sender, EventArgs e)
        {
            // Llama al metodo para modifiicar un proveedor y actualiza la tabla
            proveedor.editaRegistroSeleccionado();
            proveedor.Consulta(dgProveedores);
        }


        // Metodo para el evento del boton "Eliminar" de la pestaña Proveedor 
        private void BEliminaProveedor_Click(object sender, EventArgs e)
        {
            // Llama al metodo para eliminar un proveedor y actualiza la tabla
            proveedor.eliminaRegistroSeleccionado();
            proveedor.Consulta(dgProveedores);
        }


        // Metodo para el evento del boton "Insertar" de la pestaña Devolucion
        private void BAgregarDevo_Click(object sender, EventArgs e)
        {
            // Llama al metodo para insertar una devolucion y actualiza la tabla
            devolucion.Inserta();
            devolucion.Consulta(dgDevoluciones);
        }


        // Metodo para el evento de Click en una celda de la tabla Devoluciones
        private void DgDevoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Identifica el Id del registro seleccionado
            string ID = dgDevoluciones.Rows[e.RowIndex].Cells[0].Value.ToString();
            devolucion.AccesoIDevolucionSeleccionada = ID;

            // Carga el registro en los controles de texto
            devolucion.cargaRegistroSeleccionado();
        }


        // Metodo para el evento del boton "Modificar" de la pestaña Devolucion
        private void BEditarDevo_Click(object sender, EventArgs e)
        {
            // Llama al metodo para modificar una devolucion y actualiza la tabla
            devolucion.editaRegistroSeleccionado();
            devolucion.Consulta(dgDevoluciones);
        }


        // Metodo para el evento del boton "Eliminar" de la pestaña Devolucion
        private void BEliminarDevo_Click(object sender, EventArgs e)
        {
            // Llama al metodo para eliminar una devolucion y actualiza la tabla
            devolucion.eliminaRegistroSeleccionado();
            devolucion.Consulta(dgDevoluciones);
        }


        // Metodo que se ejecuta cuando la pestaña de Compra esta activa
        private void tabCompra_Enter(object sender, EventArgs e)
        {
            // Llena los combo box con los empleados y proveedores existentes
            compra.llenaNombreEmpleado();
            compra.llenaNombreProveedor();

            // Actualiza la tabla de Compras
            compra.actualizaTabla();
        }


        // Metodo que se ejecuta cuando la pestaña de Empleado esta activa
        private void tabEmpleado_Enter(object sender, EventArgs e)
        {
            // Actualiza la tabla de Empleado
            empleado.Consulta(dGEmpleados);
        }


        // Metodo que se ejecuta cuando la pestaña de Detalle Compra esta activa
        private void tabDetalleCompra_Enter(object sender, EventArgs e)
        {
            // Llena los combo box con las compras y los productos existentes
            detalleCompra.llenaNombreCompra();
            detalleCompra.llenaNombreProducto();
        }


        // Metodo que se ejecuta cuando la pestaña Producto esta activa
        private void tabProducto_Enter(object sender, EventArgs e)
        {
            // Actualiza la tabla Producto
            producto.actualizaTabla();
        }


        // Metodo para el evento del boton "Insertar" de la pestaña Detalle Devolucion
        private void BInsertaDetalleDev_Click(object sender, EventArgs e)
        {
            // Valida que la cantidad a devolver sea valida
            if (tbCantidadDetalleDevo.Text != "")
            {
                // Valida que lo que se quiera devolver concuerde con lo que se compro
                bool detalleValida = detalleDevolucion.cantidadDeProductosComprados();
                if (detalleValida)
                {
                    // Llama al metodo para insertar un detalle devolucion y actualiza la tabla
                    detalleDevolucion.Inserta();
                    detalleDevolucion.Consulta(dGDetalleDevoluciones);
                }
                else
                {
                    // Manda mensaje cuando la cantidad a devolver no coincide
                    MessageBox.Show("La cantidad de devoluciones no es válida");
                }
            }
            else {
                // Manda emnsaje cuando la cantidad a devolver no es valida
                MessageBox.Show("Inserte una cantidad a devolver válida");
            }

        }
        bool primeraVez = true;


        // Metodo para el evento cuando cambia el elemnto seleccionado del combo box Devolucion en la pestaña Detalle Devolucion
        private void CbIdDevolucionDetalleDevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si se encuentra alguna devolucion seleccionada se llena el combo box de los productos
            if (cbIdDevolucionDetalleDevo.SelectedIndex != -1) {
                detalleDevolucion.llenaProductos(cbIdProductoDetalleDevo);
            }

            // Si se encuentra slgun producto seleccionado se habilita el text box para la cantidad
            if (cbIdProductoDetalleDevo.SelectedIndex != -1) {
                tbCantidadDetalleDevo.Enabled = true;
            }
        }


        // Metodo para el evento cuando cambia el elemnto seleccionado del combo box Producto en la pestaña Detalle Devolucion
        private void CbIdProductoDetalleDevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si se encuentra slgun producto seleccionado se habilita el text box para la cantidad
            if (cbIdDevolucionDetalleDevo.SelectedIndex != -1) {
                tbCantidadDetalleDevo.Enabled = true;
            }
        }


        // Metodo para el evento del boton "Modificar" de la pestaña Detalle Devolucion
        private void BEditaDetalleDev_Click(object sender, EventArgs e)
        {
            // Llama al metodo para modificar un detalle devolucion y actualiza la tabla
            detalleDevolucion.Edita();
            detalleDevolucion.Consulta(dGDetalleDevoluciones);
        }


        // Metodo para el evento del boton "Eliminar" de la pestaña Detalle Devolucion
        private void BEliminaDetalleDev_Click(object sender, EventArgs e)
        {
            // Llama al metodo para eliminar un detalle devolucion y actualiza la tabla
            detalleDevolucion.eliminaRegistroSeleccionado();
            detalleDevolucion.Consulta(dGDetalleDevoluciones);
        }


        // Metodo para el evento de presionar una tecla en el text box del telefono del proveedor
        private void TbTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que solo se escriban numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }


        // Metodo para el evento cuando cambia el elemento seleccionado del combo box Producto en la pestaña Detalle Venta
        private void cbProductoDetalleVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si se encuentra seleccionado un producto se habilita el combo box de promociones 
            // y se llena con las promociones de ese producto
            if (cbProductoDetalleVenta.SelectedIndex != -1)
            {
                cbIdPromocionDetalleVenta.Enabled = true;
                DataRowView producto = (DataRowView)cbProductoDetalleVenta.SelectedItem;
                Int64 idProducto = (Int64)producto.Row.ItemArray[0];

                detalleVenta.consultaPromociones(conexion, cbIdPromocionDetalleVenta, idProducto);
            }
        }

        private void dGEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dGEmpleados.Columns[e.ColumnIndex].Index == 6 && e.Value != null)
            {
                dGEmpleados.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}

﻿namespace sistemaTiendaAbarrotes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabVistas = new System.Windows.Forms.TabControl();
            this.tabEmpleado = new System.Windows.Forms.TabPage();
            this.bEditarEmpleado = new System.Windows.Forms.Button();
            this.dTEmpleadoFN = new System.Windows.Forms.DateTimePicker();
            this.dGEmpleados = new System.Windows.Forms.DataGridView();
            this.bEliminarEmpleado = new System.Windows.Forms.Button();
            this.tbEmpleadoPass = new System.Windows.Forms.TextBox();
            this.lEmpladoPass = new System.Windows.Forms.Label();
            this.bAgregarEmpleado = new System.Windows.Forms.Button();
            this.tbEmpleadoUsuario = new System.Windows.Forms.TextBox();
            this.lEmpleadoUsuario = new System.Windows.Forms.Label();
            this.lEmpleadoFN = new System.Windows.Forms.Label();
            this.tbEmpleadoDomicilio = new System.Windows.Forms.TextBox();
            this.lEmpleadoDomicilio = new System.Windows.Forms.Label();
            this.tbEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.lEmpleadoNombreEmpleado = new System.Windows.Forms.Label();
            this.tabProveedor = new System.Windows.Forms.TabPage();
            this.tbEmailProveedor = new System.Windows.Forms.TextBox();
            this.lEmailProveedor = new System.Windows.Forms.Label();
            this.bEditarProveedor = new System.Windows.Forms.Button();
            this.dgProveedores = new System.Windows.Forms.DataGridView();
            this.bEliminaProveedor = new System.Windows.Forms.Button();
            this.tbTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.lTelefonoProveedor = new System.Windows.Forms.Label();
            this.bAgregarProveedor = new System.Windows.Forms.Button();
            this.tbRFCProveedor = new System.Windows.Forms.TextBox();
            this.lRFCProveedor = new System.Windows.Forms.Label();
            this.tbDomicilioFiscal = new System.Windows.Forms.TextBox();
            this.lDomicilioProveedor = new System.Windows.Forms.Label();
            this.tbNombreProveedor = new System.Windows.Forms.TextBox();
            this.lNombreProveedor = new System.Windows.Forms.Label();
            this.tabProducto = new System.Windows.Forms.TabPage();
            this.btEliminarProducto = new System.Windows.Forms.Button();
            this.dtProducto = new System.Windows.Forms.DataGridView();
            this.btActualizarProducto = new System.Windows.Forms.Button();
            this.lbCostoVentaProducto = new System.Windows.Forms.Label();
            this.tbCostoVentaProducto = new System.Windows.Forms.TextBox();
            this.lbCostoProvProducto = new System.Windows.Forms.Label();
            this.tbCostoProvProducto = new System.Windows.Forms.TextBox();
            this.lbExistenciasProducto = new System.Windows.Forms.Label();
            this.tbExistenciasProducto = new System.Windows.Forms.TextBox();
            this.lbNombreProducto = new System.Windows.Forms.Label();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            this.btInsertarProducto = new System.Windows.Forms.Button();
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.cbEmpleadoVentas = new System.Windows.Forms.ComboBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.dgVentas = new System.Windows.Forms.DataGridView();
            this.btEliminarVenta = new System.Windows.Forms.Button();
            this.btModificarVenta = new System.Windows.Forms.Button();
            this.btAgregarVenta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPromocion = new System.Windows.Forms.TabPage();
            this.cbProductoPromocion = new System.Windows.Forms.ComboBox();
            this.dtpFechaFinalPromo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicioPromo = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgPromocion = new System.Windows.Forms.DataGridView();
            this.btEliminarPromocion = new System.Windows.Forms.Button();
            this.btModificarPromocion = new System.Windows.Forms.Button();
            this.btAgregarPromocion = new System.Windows.Forms.Button();
            this.tabDetalleVenta = new System.Windows.Forms.TabPage();
            this.cbIdPromocionDetalleVenta = new System.Windows.Forms.ComboBox();
            this.cbIdVentaDetalleVenta = new System.Windows.Forms.ComboBox();
            this.cbProductoDetalleVenta = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.dgDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btEliminarDetalleVenta = new System.Windows.Forms.Button();
            this.btModificarDetalleVenta = new System.Windows.Forms.Button();
            this.btAgregarDetalleVenta = new System.Windows.Forms.Button();
            this.tabCompra = new System.Windows.Forms.TabPage();
            this.lbFechaCompras = new System.Windows.Forms.Label();
            this.dateCompras = new System.Windows.Forms.DateTimePicker();
            this.btEliminarCompras = new System.Windows.Forms.Button();
            this.btActualizarCompras = new System.Windows.Forms.Button();
            this.btInsertarCompras = new System.Windows.Forms.Button();
            this.dtCompras = new System.Windows.Forms.DataGridView();
            this.lbProveedorCompras = new System.Windows.Forms.Label();
            this.cbProveedorCompras = new System.Windows.Forms.ComboBox();
            this.lbEmpleadoCompras = new System.Windows.Forms.Label();
            this.cbEmpleadoCompras = new System.Windows.Forms.ComboBox();
            this.tabDetalleCompra = new System.Windows.Forms.TabPage();
            this.btEliminarDetalleCompra = new System.Windows.Forms.Button();
            this.dtDetalleCom = new System.Windows.Forms.DataGridView();
            this.btActualizarDetalleCom = new System.Windows.Forms.Button();
            this.btInsertarDetalleCom = new System.Windows.Forms.Button();
            this.tbCantidadDetalleCom = new System.Windows.Forms.TextBox();
            this.lbCantidadDetalleCom = new System.Windows.Forms.Label();
            this.cbProductoDetalleCom = new System.Windows.Forms.ComboBox();
            this.lbProductoDetalleCom = new System.Windows.Forms.Label();
            this.cbCompraDetalleCom = new System.Windows.Forms.ComboBox();
            this.lbCompraDetalleCom = new System.Windows.Forms.Label();
            this.tabDevolucion = new System.Windows.Forms.TabPage();
            this.lFechaVentaDevo = new System.Windows.Forms.Label();
            this.dgDevoluciones = new System.Windows.Forms.DataGridView();
            this.bEditarDevo = new System.Windows.Forms.Button();
            this.bEliminarDevo = new System.Windows.Forms.Button();
            this.bAgregarDevo = new System.Windows.Forms.Button();
            this.lCantidadDevo = new System.Windows.Forms.Label();
            this.tbCantidadDevo = new System.Windows.Forms.TextBox();
            this.lMotivoDevolucionDevo = new System.Windows.Forms.Label();
            this.tbMotivoDevolucionDevo = new System.Windows.Forms.TextBox();
            this.dtFechaVentaDevo = new System.Windows.Forms.DateTimePicker();
            this.lVentaDevoluciones = new System.Windows.Forms.Label();
            this.cbVentasDevo = new System.Windows.Forms.ComboBox();
            this.lNombreEmpleadoDevolucion = new System.Windows.Forms.Label();
            this.cbNombreEmpleadosDevo = new System.Windows.Forms.ComboBox();
            this.tabDetalleDevolucion = new System.Windows.Forms.TabPage();
            this.bEditaDetalleDev = new System.Windows.Forms.Button();
            this.bEliminaDetalleDev = new System.Windows.Forms.Button();
            this.bInsertaDetalleDev = new System.Windows.Forms.Button();
            this.labelCantiDetalledev = new System.Windows.Forms.Label();
            this.labelProductoDetalleDev = new System.Windows.Forms.Label();
            this.labelMotivoDevDetalledev = new System.Windows.Forms.Label();
            this.tbCantidadDetalleDevo = new System.Windows.Forms.TextBox();
            this.cbIdProductoDetalleDevo = new System.Windows.Forms.ComboBox();
            this.cbIdDevolucionDetalleDevo = new System.Windows.Forms.ComboBox();
            this.dGDetalleDevoluciones = new System.Windows.Forms.DataGridView();
            this.tabEntrega = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lEntregasMotivoDev = new System.Windows.Forms.Label();
            this.bEditarEntrega = new System.Windows.Forms.Button();
            this.bEliminaEntrega = new System.Windows.Forms.Button();
            this.bAgregarEntrega = new System.Windows.Forms.Button();
            this.labelNombreEmpleadoEntrega = new System.Windows.Forms.Label();
            this.labelNombreProvEntrega = new System.Windows.Forms.Label();
            this.dTFechaEntregaEntregas = new System.Windows.Forms.DateTimePicker();
            this.cBIdDevolucion = new System.Windows.Forms.ComboBox();
            this.cBIdEmpleado = new System.Windows.Forms.ComboBox();
            this.cBIdProveedor = new System.Windows.Forms.ComboBox();
            this.dGEntregas = new System.Windows.Forms.DataGridView();
            this.cBDescuentos = new System.Windows.Forms.ComboBox();
            this.tabVistas.SuspendLayout();
            this.tabEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGEmpleados)).BeginInit();
            this.tabProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).BeginInit();
            this.tabProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProducto)).BeginInit();
            this.tabVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).BeginInit();
            this.tabPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPromocion)).BeginInit();
            this.tabDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).BeginInit();
            this.tabCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).BeginInit();
            this.tabDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalleCom)).BeginInit();
            this.tabDevolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevoluciones)).BeginInit();
            this.tabDetalleDevolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGDetalleDevoluciones)).BeginInit();
            this.tabEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGEntregas)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabVistas
            // 
            this.tabVistas.Controls.Add(this.tabEmpleado);
            this.tabVistas.Controls.Add(this.tabProveedor);
            this.tabVistas.Controls.Add(this.tabProducto);
            this.tabVistas.Controls.Add(this.tabVenta);
            this.tabVistas.Controls.Add(this.tabPromocion);
            this.tabVistas.Controls.Add(this.tabDetalleVenta);
            this.tabVistas.Controls.Add(this.tabCompra);
            this.tabVistas.Controls.Add(this.tabDetalleCompra);
            this.tabVistas.Controls.Add(this.tabDevolucion);
            this.tabVistas.Controls.Add(this.tabDetalleDevolucion);
            this.tabVistas.Controls.Add(this.tabEntrega);
            this.tabVistas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVistas.Location = new System.Drawing.Point(3, 10);
            this.tabVistas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVistas.Name = "tabVistas";
            this.tabVistas.SelectedIndex = 0;
            this.tabVistas.Size = new System.Drawing.Size(1199, 672);
            this.tabVistas.TabIndex = 1;
            this.tabVistas.SelectedIndexChanged += new System.EventHandler(this.TabVistas_SelectedIndexChanged);
            // 
            // tabEmpleado
            // 
            this.tabEmpleado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabEmpleado.Controls.Add(this.bEditarEmpleado);
            this.tabEmpleado.Controls.Add(this.dTEmpleadoFN);
            this.tabEmpleado.Controls.Add(this.dGEmpleados);
            this.tabEmpleado.Controls.Add(this.bEliminarEmpleado);
            this.tabEmpleado.Controls.Add(this.tbEmpleadoPass);
            this.tabEmpleado.Controls.Add(this.lEmpladoPass);
            this.tabEmpleado.Controls.Add(this.bAgregarEmpleado);
            this.tabEmpleado.Controls.Add(this.tbEmpleadoUsuario);
            this.tabEmpleado.Controls.Add(this.lEmpleadoUsuario);
            this.tabEmpleado.Controls.Add(this.lEmpleadoFN);
            this.tabEmpleado.Controls.Add(this.tbEmpleadoDomicilio);
            this.tabEmpleado.Controls.Add(this.lEmpleadoDomicilio);
            this.tabEmpleado.Controls.Add(this.tbEmpleadoNombre);
            this.tabEmpleado.Controls.Add(this.lEmpleadoNombreEmpleado);
            this.tabEmpleado.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmpleado.Location = new System.Drawing.Point(4, 29);
            this.tabEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmpleado.Size = new System.Drawing.Size(1191, 639);
            this.tabEmpleado.TabIndex = 0;
            this.tabEmpleado.Text = "Empleados";
            this.tabEmpleado.Enter += new System.EventHandler(this.tabEmpleado_Enter);
            // 
            // bEditarEmpleado
            // 
            this.bEditarEmpleado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditarEmpleado.ForeColor = System.Drawing.Color.DarkCyan;
            this.bEditarEmpleado.Location = new System.Drawing.Point(896, 112);
            this.bEditarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEditarEmpleado.Name = "bEditarEmpleado";
            this.bEditarEmpleado.Size = new System.Drawing.Size(100, 49);
            this.bEditarEmpleado.TabIndex = 14;
            this.bEditarEmpleado.Text = "Editar";
            this.bEditarEmpleado.UseVisualStyleBackColor = true;
            this.bEditarEmpleado.Click += new System.EventHandler(this.BEditarEmpleado_Click);
            // 
            // dTEmpleadoFN
            // 
            this.dTEmpleadoFN.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTEmpleadoFN.Location = new System.Drawing.Point(368, 59);
            this.dTEmpleadoFN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTEmpleadoFN.MaxDate = new System.DateTime(2000, 12, 25, 0, 0, 0, 0);
            this.dTEmpleadoFN.Name = "dTEmpleadoFN";
            this.dTEmpleadoFN.Size = new System.Drawing.Size(269, 26);
            this.dTEmpleadoFN.TabIndex = 2;
            this.dTEmpleadoFN.Value = new System.DateTime(2000, 12, 25, 0, 0, 0, 0);
            // 
            // dGEmpleados
            // 
            this.dGEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGEmpleados.Location = new System.Drawing.Point(39, 278);
            this.dGEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGEmpleados.Name = "dGEmpleados";
            this.dGEmpleados.RowHeadersWidth = 51;
            this.dGEmpleados.RowTemplate.Height = 24;
            this.dGEmpleados.Size = new System.Drawing.Size(1111, 313);
            this.dGEmpleados.TabIndex = 12;
            this.dGEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGEmpleados_CellClick);
            this.dGEmpleados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGEmpleados_CellFormatting);
            // 
            // bEliminarEmpleado
            // 
            this.bEliminarEmpleado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminarEmpleado.ForeColor = System.Drawing.Color.DarkCyan;
            this.bEliminarEmpleado.Location = new System.Drawing.Point(1016, 84);
            this.bEliminarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEliminarEmpleado.Name = "bEliminarEmpleado";
            this.bEliminarEmpleado.Size = new System.Drawing.Size(100, 49);
            this.bEliminarEmpleado.TabIndex = 11;
            this.bEliminarEmpleado.Text = "Eliminar";
            this.bEliminarEmpleado.UseVisualStyleBackColor = true;
            this.bEliminarEmpleado.Click += new System.EventHandler(this.BEliminarEmpleado_Click);
            // 
            // tbEmpleadoPass
            // 
            this.tbEmpleadoPass.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpleadoPass.Location = new System.Drawing.Point(39, 209);
            this.tbEmpleadoPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmpleadoPass.Name = "tbEmpleadoPass";
            this.tbEmpleadoPass.PasswordChar = '*';
            this.tbEmpleadoPass.Size = new System.Drawing.Size(269, 26);
            this.tbEmpleadoPass.TabIndex = 5;
            // 
            // lEmpladoPass
            // 
            this.lEmpladoPass.AutoSize = true;
            this.lEmpladoPass.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmpladoPass.ForeColor = System.Drawing.Color.DarkCyan;
            this.lEmpladoPass.Location = new System.Drawing.Point(35, 186);
            this.lEmpladoPass.Name = "lEmpladoPass";
            this.lEmpladoPass.Size = new System.Drawing.Size(90, 23);
            this.lEmpladoPass.TabIndex = 9;
            this.lEmpladoPass.Text = "Password:";
            // 
            // bAgregarEmpleado
            // 
            this.bAgregarEmpleado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bAgregarEmpleado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregarEmpleado.ForeColor = System.Drawing.Color.DarkCyan;
            this.bAgregarEmpleado.Location = new System.Drawing.Point(896, 34);
            this.bAgregarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAgregarEmpleado.Name = "bAgregarEmpleado";
            this.bAgregarEmpleado.Size = new System.Drawing.Size(100, 49);
            this.bAgregarEmpleado.TabIndex = 8;
            this.bAgregarEmpleado.Text = "Insertar";
            this.bAgregarEmpleado.UseVisualStyleBackColor = false;
            this.bAgregarEmpleado.Click += new System.EventHandler(this.BAgregarEmpleado_Click);
            // 
            // tbEmpleadoUsuario
            // 
            this.tbEmpleadoUsuario.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpleadoUsuario.Location = new System.Drawing.Point(40, 122);
            this.tbEmpleadoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmpleadoUsuario.Name = "tbEmpleadoUsuario";
            this.tbEmpleadoUsuario.Size = new System.Drawing.Size(269, 26);
            this.tbEmpleadoUsuario.TabIndex = 3;
            // 
            // lEmpleadoUsuario
            // 
            this.lEmpleadoUsuario.AutoSize = true;
            this.lEmpleadoUsuario.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmpleadoUsuario.ForeColor = System.Drawing.Color.DarkCyan;
            this.lEmpleadoUsuario.Location = new System.Drawing.Point(36, 101);
            this.lEmpleadoUsuario.Name = "lEmpleadoUsuario";
            this.lEmpleadoUsuario.Size = new System.Drawing.Size(74, 23);
            this.lEmpleadoUsuario.TabIndex = 6;
            this.lEmpleadoUsuario.Text = "Usuario:";
            // 
            // lEmpleadoFN
            // 
            this.lEmpleadoFN.AutoSize = true;
            this.lEmpleadoFN.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmpleadoFN.ForeColor = System.Drawing.Color.DarkCyan;
            this.lEmpleadoFN.Location = new System.Drawing.Point(365, 30);
            this.lEmpleadoFN.Name = "lEmpleadoFN";
            this.lEmpleadoFN.Size = new System.Drawing.Size(151, 23);
            this.lEmpleadoFN.TabIndex = 4;
            this.lEmpleadoFN.Text = "Fecha Nacimiento:";
            // 
            // tbEmpleadoDomicilio
            // 
            this.tbEmpleadoDomicilio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpleadoDomicilio.Location = new System.Drawing.Point(368, 133);
            this.tbEmpleadoDomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmpleadoDomicilio.Name = "tbEmpleadoDomicilio";
            this.tbEmpleadoDomicilio.Size = new System.Drawing.Size(269, 26);
            this.tbEmpleadoDomicilio.TabIndex = 4;
            // 
            // lEmpleadoDomicilio
            // 
            this.lEmpleadoDomicilio.AutoSize = true;
            this.lEmpleadoDomicilio.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmpleadoDomicilio.ForeColor = System.Drawing.Color.DarkCyan;
            this.lEmpleadoDomicilio.Location = new System.Drawing.Point(365, 112);
            this.lEmpleadoDomicilio.Name = "lEmpleadoDomicilio";
            this.lEmpleadoDomicilio.Size = new System.Drawing.Size(85, 23);
            this.lEmpleadoDomicilio.TabIndex = 2;
            this.lEmpleadoDomicilio.Text = "Domicilio:";
            // 
            // tbEmpleadoNombre
            // 
            this.tbEmpleadoNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpleadoNombre.Location = new System.Drawing.Point(40, 54);
            this.tbEmpleadoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmpleadoNombre.Name = "tbEmpleadoNombre";
            this.tbEmpleadoNombre.Size = new System.Drawing.Size(269, 26);
            this.tbEmpleadoNombre.TabIndex = 1;
            // 
            // lEmpleadoNombreEmpleado
            // 
            this.lEmpleadoNombreEmpleado.AutoSize = true;
            this.lEmpleadoNombreEmpleado.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmpleadoNombreEmpleado.ForeColor = System.Drawing.Color.DarkCyan;
            this.lEmpleadoNombreEmpleado.Location = new System.Drawing.Point(37, 30);
            this.lEmpleadoNombreEmpleado.Name = "lEmpleadoNombreEmpleado";
            this.lEmpleadoNombreEmpleado.Size = new System.Drawing.Size(75, 23);
            this.lEmpleadoNombreEmpleado.TabIndex = 0;
            this.lEmpleadoNombreEmpleado.Text = "Nombre:";
            // 
            // tabProveedor
            // 
            this.tabProveedor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabProveedor.Controls.Add(this.tbEmailProveedor);
            this.tabProveedor.Controls.Add(this.lEmailProveedor);
            this.tabProveedor.Controls.Add(this.bEditarProveedor);
            this.tabProveedor.Controls.Add(this.dgProveedores);
            this.tabProveedor.Controls.Add(this.bEliminaProveedor);
            this.tabProveedor.Controls.Add(this.tbTelefonoProveedor);
            this.tabProveedor.Controls.Add(this.lTelefonoProveedor);
            this.tabProveedor.Controls.Add(this.bAgregarProveedor);
            this.tabProveedor.Controls.Add(this.tbRFCProveedor);
            this.tabProveedor.Controls.Add(this.lRFCProveedor);
            this.tabProveedor.Controls.Add(this.tbDomicilioFiscal);
            this.tabProveedor.Controls.Add(this.lDomicilioProveedor);
            this.tabProveedor.Controls.Add(this.tbNombreProveedor);
            this.tabProveedor.Controls.Add(this.lNombreProveedor);
            this.tabProveedor.Location = new System.Drawing.Point(4, 29);
            this.tabProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProveedor.Name = "tabProveedor";
            this.tabProveedor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProveedor.Size = new System.Drawing.Size(1191, 639);
            this.tabProveedor.TabIndex = 1;
            this.tabProveedor.Text = "Proveedores";
            // 
            // tbEmailProveedor
            // 
            this.tbEmailProveedor.Location = new System.Drawing.Point(384, 48);
            this.tbEmailProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmailProveedor.Name = "tbEmailProveedor";
            this.tbEmailProveedor.Size = new System.Drawing.Size(269, 26);
            this.tbEmailProveedor.TabIndex = 2;
            // 
            // lEmailProveedor
            // 
            this.lEmailProveedor.AutoSize = true;
            this.lEmailProveedor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmailProveedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.lEmailProveedor.Location = new System.Drawing.Point(381, 18);
            this.lEmailProveedor.Name = "lEmailProveedor";
            this.lEmailProveedor.Size = new System.Drawing.Size(56, 23);
            this.lEmailProveedor.TabIndex = 29;
            this.lEmailProveedor.Text = "Email:";
            // 
            // bEditarProveedor
            // 
            this.bEditarProveedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.bEditarProveedor.Location = new System.Drawing.Point(896, 112);
            this.bEditarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEditarProveedor.Name = "bEditarProveedor";
            this.bEditarProveedor.Size = new System.Drawing.Size(100, 49);
            this.bEditarProveedor.TabIndex = 28;
            this.bEditarProveedor.Text = "Editar";
            this.bEditarProveedor.UseVisualStyleBackColor = true;
            this.bEditarProveedor.Click += new System.EventHandler(this.BEditarProveedor_Click);
            // 
            // dgProveedores
            // 
            this.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedores.Location = new System.Drawing.Point(39, 278);
            this.dgProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgProveedores.Name = "dgProveedores";
            this.dgProveedores.RowHeadersWidth = 51;
            this.dgProveedores.RowTemplate.Height = 24;
            this.dgProveedores.Size = new System.Drawing.Size(1111, 313);
            this.dgProveedores.TabIndex = 26;
            this.dgProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProveedores_CellClick);
            // 
            // bEliminaProveedor
            // 
            this.bEliminaProveedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.bEliminaProveedor.Location = new System.Drawing.Point(1016, 84);
            this.bEliminaProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEliminaProveedor.Name = "bEliminaProveedor";
            this.bEliminaProveedor.Size = new System.Drawing.Size(100, 49);
            this.bEliminaProveedor.TabIndex = 25;
            this.bEliminaProveedor.Text = "Eliminar";
            this.bEliminaProveedor.UseVisualStyleBackColor = true;
            this.bEliminaProveedor.Click += new System.EventHandler(this.BEliminaProveedor_Click);
            // 
            // tbTelefonoProveedor
            // 
            this.tbTelefonoProveedor.Location = new System.Drawing.Point(37, 204);
            this.tbTelefonoProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelefonoProveedor.Name = "tbTelefonoProveedor";
            this.tbTelefonoProveedor.Size = new System.Drawing.Size(269, 26);
            this.tbTelefonoProveedor.TabIndex = 5;
            this.tbTelefonoProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTelefonoProveedor_KeyPress);
            // 
            // lTelefonoProveedor
            // 
            this.lTelefonoProveedor.AutoSize = true;
            this.lTelefonoProveedor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefonoProveedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.lTelefonoProveedor.Location = new System.Drawing.Point(33, 178);
            this.lTelefonoProveedor.Name = "lTelefonoProveedor";
            this.lTelefonoProveedor.Size = new System.Drawing.Size(82, 23);
            this.lTelefonoProveedor.TabIndex = 23;
            this.lTelefonoProveedor.Text = "Teléfono:";
            // 
            // bAgregarProveedor
            // 
            this.bAgregarProveedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.bAgregarProveedor.Location = new System.Drawing.Point(896, 34);
            this.bAgregarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAgregarProveedor.Name = "bAgregarProveedor";
            this.bAgregarProveedor.Size = new System.Drawing.Size(100, 49);
            this.bAgregarProveedor.TabIndex = 22;
            this.bAgregarProveedor.Text = "Insertar";
            this.bAgregarProveedor.UseVisualStyleBackColor = true;
            this.bAgregarProveedor.Click += new System.EventHandler(this.BAgregarProveedor_Click);
            // 
            // tbRFCProveedor
            // 
            this.tbRFCProveedor.Location = new System.Drawing.Point(37, 123);
            this.tbRFCProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRFCProveedor.Name = "tbRFCProveedor";
            this.tbRFCProveedor.Size = new System.Drawing.Size(269, 26);
            this.tbRFCProveedor.TabIndex = 3;
            // 
            // lRFCProveedor
            // 
            this.lRFCProveedor.AutoSize = true;
            this.lRFCProveedor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRFCProveedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.lRFCProveedor.Location = new System.Drawing.Point(35, 97);
            this.lRFCProveedor.Name = "lRFCProveedor";
            this.lRFCProveedor.Size = new System.Drawing.Size(47, 23);
            this.lRFCProveedor.TabIndex = 20;
            this.lRFCProveedor.Text = "RFC:";
            // 
            // tbDomicilioFiscal
            // 
            this.tbDomicilioFiscal.Location = new System.Drawing.Point(384, 124);
            this.tbDomicilioFiscal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDomicilioFiscal.Name = "tbDomicilioFiscal";
            this.tbDomicilioFiscal.Size = new System.Drawing.Size(269, 26);
            this.tbDomicilioFiscal.TabIndex = 4;
            // 
            // lDomicilioProveedor
            // 
            this.lDomicilioProveedor.AutoSize = true;
            this.lDomicilioProveedor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDomicilioProveedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.lDomicilioProveedor.Location = new System.Drawing.Point(381, 97);
            this.lDomicilioProveedor.Name = "lDomicilioProveedor";
            this.lDomicilioProveedor.Size = new System.Drawing.Size(134, 23);
            this.lDomicilioProveedor.TabIndex = 17;
            this.lDomicilioProveedor.Text = "Domicilio Fiscal:";
            // 
            // tbNombreProveedor
            // 
            this.tbNombreProveedor.Location = new System.Drawing.Point(37, 52);
            this.tbNombreProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreProveedor.Name = "tbNombreProveedor";
            this.tbNombreProveedor.Size = new System.Drawing.Size(269, 26);
            this.tbNombreProveedor.TabIndex = 1;
            // 
            // lNombreProveedor
            // 
            this.lNombreProveedor.AutoSize = true;
            this.lNombreProveedor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreProveedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.lNombreProveedor.Location = new System.Drawing.Point(35, 26);
            this.lNombreProveedor.Name = "lNombreProveedor";
            this.lNombreProveedor.Size = new System.Drawing.Size(75, 23);
            this.lNombreProveedor.TabIndex = 15;
            this.lNombreProveedor.Text = "Nombre:";
            // 
            // tabProducto
            // 
            this.tabProducto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabProducto.Controls.Add(this.btEliminarProducto);
            this.tabProducto.Controls.Add(this.dtProducto);
            this.tabProducto.Controls.Add(this.btActualizarProducto);
            this.tabProducto.Controls.Add(this.lbCostoVentaProducto);
            this.tabProducto.Controls.Add(this.tbCostoVentaProducto);
            this.tabProducto.Controls.Add(this.lbCostoProvProducto);
            this.tabProducto.Controls.Add(this.tbCostoProvProducto);
            this.tabProducto.Controls.Add(this.lbExistenciasProducto);
            this.tabProducto.Controls.Add(this.tbExistenciasProducto);
            this.tabProducto.Controls.Add(this.lbNombreProducto);
            this.tabProducto.Controls.Add(this.tbNombreProducto);
            this.tabProducto.Controls.Add(this.btInsertarProducto);
            this.tabProducto.Location = new System.Drawing.Point(4, 29);
            this.tabProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProducto.Size = new System.Drawing.Size(1191, 639);
            this.tabProducto.TabIndex = 2;
            this.tabProducto.Text = "Productos";
            this.tabProducto.Enter += new System.EventHandler(this.tabProducto_Enter);
            // 
            // btEliminarProducto
            // 
            this.btEliminarProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.btEliminarProducto.Location = new System.Drawing.Point(1016, 84);
            this.btEliminarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEliminarProducto.Name = "btEliminarProducto";
            this.btEliminarProducto.Size = new System.Drawing.Size(100, 49);
            this.btEliminarProducto.TabIndex = 11;
            this.btEliminarProducto.Text = "Eliminar";
            this.btEliminarProducto.UseVisualStyleBackColor = true;
            this.btEliminarProducto.Click += new System.EventHandler(this.btEliminarProducto_Click);
            // 
            // dtProducto
            // 
            this.dtProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProducto.Location = new System.Drawing.Point(39, 278);
            this.dtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtProducto.Name = "dtProducto";
            this.dtProducto.RowHeadersWidth = 51;
            this.dtProducto.Size = new System.Drawing.Size(1111, 313);
            this.dtProducto.TabIndex = 10;
            this.dtProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProducto_CellClick);
            // 
            // btActualizarProducto
            // 
            this.btActualizarProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.btActualizarProducto.Location = new System.Drawing.Point(896, 112);
            this.btActualizarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btActualizarProducto.Name = "btActualizarProducto";
            this.btActualizarProducto.Size = new System.Drawing.Size(100, 49);
            this.btActualizarProducto.TabIndex = 9;
            this.btActualizarProducto.Text = "Editar";
            this.btActualizarProducto.UseVisualStyleBackColor = true;
            this.btActualizarProducto.Click += new System.EventHandler(this.btActualizarProducto_Click);
            // 
            // lbCostoVentaProducto
            // 
            this.lbCostoVentaProducto.AutoSize = true;
            this.lbCostoVentaProducto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostoVentaProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbCostoVentaProducto.Location = new System.Drawing.Point(375, 122);
            this.lbCostoVentaProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCostoVentaProducto.Name = "lbCostoVentaProducto";
            this.lbCostoVentaProducto.Size = new System.Drawing.Size(106, 23);
            this.lbCostoVentaProducto.TabIndex = 8;
            this.lbCostoVentaProducto.Text = "Costo venta:";
            // 
            // tbCostoVentaProducto
            // 
            this.tbCostoVentaProducto.Location = new System.Drawing.Point(376, 150);
            this.tbCostoVentaProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCostoVentaProducto.Name = "tbCostoVentaProducto";
            this.tbCostoVentaProducto.Size = new System.Drawing.Size(269, 26);
            this.tbCostoVentaProducto.TabIndex = 4;
            // 
            // lbCostoProvProducto
            // 
            this.lbCostoProvProducto.AutoSize = true;
            this.lbCostoProvProducto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostoProvProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbCostoProvProducto.Location = new System.Drawing.Point(375, 37);
            this.lbCostoProvProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCostoProvProducto.Name = "lbCostoProvProducto";
            this.lbCostoProvProducto.Size = new System.Drawing.Size(143, 23);
            this.lbCostoProvProducto.TabIndex = 6;
            this.lbCostoProvProducto.Text = "Costo proveedor:";
            // 
            // tbCostoProvProducto
            // 
            this.tbCostoProvProducto.Location = new System.Drawing.Point(376, 65);
            this.tbCostoProvProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCostoProvProducto.Name = "tbCostoProvProducto";
            this.tbCostoProvProducto.Size = new System.Drawing.Size(269, 26);
            this.tbCostoProvProducto.TabIndex = 2;
            // 
            // lbExistenciasProducto
            // 
            this.lbExistenciasProducto.AutoSize = true;
            this.lbExistenciasProducto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExistenciasProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbExistenciasProducto.Location = new System.Drawing.Point(49, 122);
            this.lbExistenciasProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExistenciasProducto.Name = "lbExistenciasProducto";
            this.lbExistenciasProducto.Size = new System.Drawing.Size(102, 23);
            this.lbExistenciasProducto.TabIndex = 4;
            this.lbExistenciasProducto.Text = "Existencias:";
            // 
            // tbExistenciasProducto
            // 
            this.tbExistenciasProducto.Location = new System.Drawing.Point(53, 150);
            this.tbExistenciasProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbExistenciasProducto.Name = "tbExistenciasProducto";
            this.tbExistenciasProducto.Size = new System.Drawing.Size(269, 26);
            this.tbExistenciasProducto.TabIndex = 3;
            // 
            // lbNombreProducto
            // 
            this.lbNombreProducto.AutoSize = true;
            this.lbNombreProducto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbNombreProducto.Location = new System.Drawing.Point(49, 33);
            this.lbNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreProducto.Name = "lbNombreProducto";
            this.lbNombreProducto.Size = new System.Drawing.Size(75, 23);
            this.lbNombreProducto.TabIndex = 2;
            this.lbNombreProducto.Text = "Nombre:";
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.Location = new System.Drawing.Point(53, 62);
            this.tbNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(269, 26);
            this.tbNombreProducto.TabIndex = 1;
            // 
            // btInsertarProducto
            // 
            this.btInsertarProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.btInsertarProducto.Location = new System.Drawing.Point(896, 34);
            this.btInsertarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btInsertarProducto.Name = "btInsertarProducto";
            this.btInsertarProducto.Size = new System.Drawing.Size(100, 49);
            this.btInsertarProducto.TabIndex = 0;
            this.btInsertarProducto.Text = "Insertar";
            this.btInsertarProducto.UseVisualStyleBackColor = true;
            this.btInsertarProducto.Click += new System.EventHandler(this.btInsertarProducto_Click);
            // 
            // tabVenta
            // 
            this.tabVenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabVenta.Controls.Add(this.cbEmpleadoVentas);
            this.tabVenta.Controls.Add(this.dtpFechaVenta);
            this.tabVenta.Controls.Add(this.dgVentas);
            this.tabVenta.Controls.Add(this.btEliminarVenta);
            this.tabVenta.Controls.Add(this.btModificarVenta);
            this.tabVenta.Controls.Add(this.btAgregarVenta);
            this.tabVenta.Controls.Add(this.label7);
            this.tabVenta.Controls.Add(this.label6);
            this.tabVenta.Location = new System.Drawing.Point(4, 29);
            this.tabVenta.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabVenta.Size = new System.Drawing.Size(1191, 639);
            this.tabVenta.TabIndex = 3;
            this.tabVenta.Text = "Ventas";
            this.tabVenta.Enter += new System.EventHandler(this.tabVenta_Enter);
            // 
            // cbEmpleadoVentas
            // 
            this.cbEmpleadoVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleadoVentas.FormattingEnabled = true;
            this.cbEmpleadoVentas.Location = new System.Drawing.Point(39, 65);
            this.cbEmpleadoVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmpleadoVentas.Name = "cbEmpleadoVentas";
            this.cbEmpleadoVentas.Size = new System.Drawing.Size(272, 28);
            this.cbEmpleadoVentas.TabIndex = 1;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Enabled = false;
            this.dtpFechaVenta.Location = new System.Drawing.Point(39, 164);
            this.dtpFechaVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(269, 26);
            this.dtpFechaVenta.TabIndex = 2;
            // 
            // dgVentas
            // 
            this.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentas.Location = new System.Drawing.Point(39, 278);
            this.dgVentas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgVentas.Name = "dgVentas";
            this.dgVentas.RowHeadersWidth = 51;
            this.dgVentas.Size = new System.Drawing.Size(1111, 313);
            this.dgVentas.TabIndex = 9;
            this.dgVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVentas_CellClick);
            // 
            // btEliminarVenta
            // 
            this.btEliminarVenta.ForeColor = System.Drawing.Color.DarkCyan;
            this.btEliminarVenta.Location = new System.Drawing.Point(1016, 84);
            this.btEliminarVenta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btEliminarVenta.Name = "btEliminarVenta";
            this.btEliminarVenta.Size = new System.Drawing.Size(100, 49);
            this.btEliminarVenta.TabIndex = 8;
            this.btEliminarVenta.Text = "Eliminar";
            this.btEliminarVenta.UseVisualStyleBackColor = true;
            this.btEliminarVenta.Click += new System.EventHandler(this.btEliminarVenta_Click);
            // 
            // btModificarVenta
            // 
            this.btModificarVenta.ForeColor = System.Drawing.Color.DarkCyan;
            this.btModificarVenta.Location = new System.Drawing.Point(896, 112);
            this.btModificarVenta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btModificarVenta.Name = "btModificarVenta";
            this.btModificarVenta.Size = new System.Drawing.Size(100, 49);
            this.btModificarVenta.TabIndex = 7;
            this.btModificarVenta.Text = "Editar";
            this.btModificarVenta.UseVisualStyleBackColor = true;
            this.btModificarVenta.Click += new System.EventHandler(this.btModificarVenta_Click);
            // 
            // btAgregarVenta
            // 
            this.btAgregarVenta.ForeColor = System.Drawing.Color.DarkCyan;
            this.btAgregarVenta.Location = new System.Drawing.Point(896, 34);
            this.btAgregarVenta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btAgregarVenta.Name = "btAgregarVenta";
            this.btAgregarVenta.Size = new System.Drawing.Size(100, 49);
            this.btAgregarVenta.TabIndex = 6;
            this.btAgregarVenta.Text = "Insertar";
            this.btAgregarVenta.UseVisualStyleBackColor = true;
            this.btAgregarVenta.Click += new System.EventHandler(this.btAgregarVenta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(36, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(36, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Empleado:";
            // 
            // tabPromocion
            // 
            this.tabPromocion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPromocion.Controls.Add(this.cBDescuentos);
            this.tabPromocion.Controls.Add(this.cbProductoPromocion);
            this.tabPromocion.Controls.Add(this.dtpFechaFinalPromo);
            this.tabPromocion.Controls.Add(this.dtpFechaInicioPromo);
            this.tabPromocion.Controls.Add(this.label12);
            this.tabPromocion.Controls.Add(this.label9);
            this.tabPromocion.Controls.Add(this.label10);
            this.tabPromocion.Controls.Add(this.label11);
            this.tabPromocion.Controls.Add(this.dgPromocion);
            this.tabPromocion.Controls.Add(this.btEliminarPromocion);
            this.tabPromocion.Controls.Add(this.btModificarPromocion);
            this.tabPromocion.Controls.Add(this.btAgregarPromocion);
            this.tabPromocion.Location = new System.Drawing.Point(4, 29);
            this.tabPromocion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPromocion.Name = "tabPromocion";
            this.tabPromocion.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPromocion.Size = new System.Drawing.Size(1191, 639);
            this.tabPromocion.TabIndex = 4;
            this.tabPromocion.Text = "Promociones";
            this.tabPromocion.Enter += new System.EventHandler(this.tabPromocion_Enter);
            // 
            // cbProductoPromocion
            // 
            this.cbProductoPromocion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductoPromocion.FormattingEnabled = true;
            this.cbProductoPromocion.Location = new System.Drawing.Point(67, 55);
            this.cbProductoPromocion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProductoPromocion.Name = "cbProductoPromocion";
            this.cbProductoPromocion.Size = new System.Drawing.Size(269, 28);
            this.cbProductoPromocion.TabIndex = 1;
            // 
            // dtpFechaFinalPromo
            // 
            this.dtpFechaFinalPromo.Location = new System.Drawing.Point(423, 52);
            this.dtpFechaFinalPromo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFinalPromo.Name = "dtpFechaFinalPromo";
            this.dtpFechaFinalPromo.Size = new System.Drawing.Size(269, 26);
            this.dtpFechaFinalPromo.TabIndex = 2;
            // 
            // dtpFechaInicioPromo
            // 
            this.dtpFechaInicioPromo.Location = new System.Drawing.Point(67, 129);
            this.dtpFechaInicioPromo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInicioPromo.Name = "dtpFechaInicioPromo";
            this.dtpFechaInicioPromo.Size = new System.Drawing.Size(269, 26);
            this.dtpFechaInicioPromo.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(419, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Fecha Final:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(419, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Descuento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(67, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha Inicio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(67, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Producto:";
            // 
            // dgPromocion
            // 
            this.dgPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPromocion.Location = new System.Drawing.Point(39, 278);
            this.dgPromocion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgPromocion.Name = "dgPromocion";
            this.dgPromocion.RowHeadersWidth = 51;
            this.dgPromocion.Size = new System.Drawing.Size(1111, 313);
            this.dgPromocion.TabIndex = 16;
            this.dgPromocion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPromocion_CellClick);
            // 
            // btEliminarPromocion
            // 
            this.btEliminarPromocion.ForeColor = System.Drawing.Color.DarkCyan;
            this.btEliminarPromocion.Location = new System.Drawing.Point(1016, 84);
            this.btEliminarPromocion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btEliminarPromocion.Name = "btEliminarPromocion";
            this.btEliminarPromocion.Size = new System.Drawing.Size(100, 49);
            this.btEliminarPromocion.TabIndex = 15;
            this.btEliminarPromocion.Text = "Eliminar";
            this.btEliminarPromocion.UseVisualStyleBackColor = true;
            this.btEliminarPromocion.Click += new System.EventHandler(this.btEliminarPromocion_Click);
            // 
            // btModificarPromocion
            // 
            this.btModificarPromocion.ForeColor = System.Drawing.Color.DarkCyan;
            this.btModificarPromocion.Location = new System.Drawing.Point(896, 112);
            this.btModificarPromocion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btModificarPromocion.Name = "btModificarPromocion";
            this.btModificarPromocion.Size = new System.Drawing.Size(100, 49);
            this.btModificarPromocion.TabIndex = 14;
            this.btModificarPromocion.Text = "Editar";
            this.btModificarPromocion.UseVisualStyleBackColor = true;
            this.btModificarPromocion.Click += new System.EventHandler(this.btModificarPromocion_Click);
            // 
            // btAgregarPromocion
            // 
            this.btAgregarPromocion.ForeColor = System.Drawing.Color.DarkCyan;
            this.btAgregarPromocion.Location = new System.Drawing.Point(896, 34);
            this.btAgregarPromocion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btAgregarPromocion.Name = "btAgregarPromocion";
            this.btAgregarPromocion.Size = new System.Drawing.Size(100, 49);
            this.btAgregarPromocion.TabIndex = 13;
            this.btAgregarPromocion.Text = "Insertar";
            this.btAgregarPromocion.UseVisualStyleBackColor = true;
            this.btAgregarPromocion.Click += new System.EventHandler(this.btAgregarPromocion_Click);
            // 
            // tabDetalleVenta
            // 
            this.tabDetalleVenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabDetalleVenta.Controls.Add(this.cbIdPromocionDetalleVenta);
            this.tabDetalleVenta.Controls.Add(this.cbIdVentaDetalleVenta);
            this.tabDetalleVenta.Controls.Add(this.cbProductoDetalleVenta);
            this.tabDetalleVenta.Controls.Add(this.label17);
            this.tabDetalleVenta.Controls.Add(this.label13);
            this.tabDetalleVenta.Controls.Add(this.label15);
            this.tabDetalleVenta.Controls.Add(this.label16);
            this.tabDetalleVenta.Controls.Add(this.tbCantidad);
            this.tabDetalleVenta.Controls.Add(this.dgDetalleVenta);
            this.tabDetalleVenta.Controls.Add(this.btEliminarDetalleVenta);
            this.tabDetalleVenta.Controls.Add(this.btModificarDetalleVenta);
            this.tabDetalleVenta.Controls.Add(this.btAgregarDetalleVenta);
            this.tabDetalleVenta.Location = new System.Drawing.Point(4, 29);
            this.tabDetalleVenta.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabDetalleVenta.Name = "tabDetalleVenta";
            this.tabDetalleVenta.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabDetalleVenta.Size = new System.Drawing.Size(1191, 639);
            this.tabDetalleVenta.TabIndex = 5;
            this.tabDetalleVenta.Text = "Detalle Ventas";
            this.tabDetalleVenta.Enter += new System.EventHandler(this.tabDetalleVenta_Enter);
            // 
            // cbIdPromocionDetalleVenta
            // 
            this.cbIdPromocionDetalleVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdPromocionDetalleVenta.Enabled = false;
            this.cbIdPromocionDetalleVenta.FormattingEnabled = true;
            this.cbIdPromocionDetalleVenta.Location = new System.Drawing.Point(68, 160);
            this.cbIdPromocionDetalleVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIdPromocionDetalleVenta.Name = "cbIdPromocionDetalleVenta";
            this.cbIdPromocionDetalleVenta.Size = new System.Drawing.Size(264, 28);
            this.cbIdPromocionDetalleVenta.TabIndex = 3;
            // 
            // cbIdVentaDetalleVenta
            // 
            this.cbIdVentaDetalleVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdVentaDetalleVenta.FormattingEnabled = true;
            this.cbIdVentaDetalleVenta.Location = new System.Drawing.Point(68, 54);
            this.cbIdVentaDetalleVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIdVentaDetalleVenta.Name = "cbIdVentaDetalleVenta";
            this.cbIdVentaDetalleVenta.Size = new System.Drawing.Size(264, 28);
            this.cbIdVentaDetalleVenta.TabIndex = 1;
            // 
            // cbProductoDetalleVenta
            // 
            this.cbProductoDetalleVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductoDetalleVenta.FormattingEnabled = true;
            this.cbProductoDetalleVenta.Location = new System.Drawing.Point(415, 53);
            this.cbProductoDetalleVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProductoDetalleVenta.Name = "cbProductoDetalleVenta";
            this.cbProductoDetalleVenta.Size = new System.Drawing.Size(264, 28);
            this.cbProductoDetalleVenta.TabIndex = 2;
            this.cbProductoDetalleVenta.SelectedIndexChanged += new System.EventHandler(this.cbProductoDetalleVenta_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(63, 18);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 23);
            this.label17.TabIndex = 35;
            this.label17.Text = "Id Venta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(409, 112);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 23);
            this.label13.TabIndex = 33;
            this.label13.Text = "Cantidad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(63, 112);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 23);
            this.label15.TabIndex = 31;
            this.label15.Text = "Id Promocion:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(409, 18);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 23);
            this.label16.TabIndex = 30;
            this.label16.Text = "Producto:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(409, 160);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(269, 26);
            this.tbCantidad.TabIndex = 4;
            // 
            // dgDetalleVenta
            // 
            this.dgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleVenta.Location = new System.Drawing.Point(39, 278);
            this.dgDetalleVenta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgDetalleVenta.Name = "dgDetalleVenta";
            this.dgDetalleVenta.RowHeadersWidth = 51;
            this.dgDetalleVenta.Size = new System.Drawing.Size(1111, 313);
            this.dgDetalleVenta.TabIndex = 28;
            this.dgDetalleVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalleVenta_CellClick);
            // 
            // btEliminarDetalleVenta
            // 
            this.btEliminarDetalleVenta.ForeColor = System.Drawing.Color.DarkCyan;
            this.btEliminarDetalleVenta.Location = new System.Drawing.Point(1016, 84);
            this.btEliminarDetalleVenta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btEliminarDetalleVenta.Name = "btEliminarDetalleVenta";
            this.btEliminarDetalleVenta.Size = new System.Drawing.Size(100, 49);
            this.btEliminarDetalleVenta.TabIndex = 27;
            this.btEliminarDetalleVenta.Text = "Eliminar";
            this.btEliminarDetalleVenta.UseVisualStyleBackColor = true;
            this.btEliminarDetalleVenta.Click += new System.EventHandler(this.btEliminarDetalleVenta_Click);
            // 
            // btModificarDetalleVenta
            // 
            this.btModificarDetalleVenta.ForeColor = System.Drawing.Color.DarkCyan;
            this.btModificarDetalleVenta.Location = new System.Drawing.Point(896, 112);
            this.btModificarDetalleVenta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btModificarDetalleVenta.Name = "btModificarDetalleVenta";
            this.btModificarDetalleVenta.Size = new System.Drawing.Size(100, 49);
            this.btModificarDetalleVenta.TabIndex = 26;
            this.btModificarDetalleVenta.Text = "Editar";
            this.btModificarDetalleVenta.UseVisualStyleBackColor = true;
            this.btModificarDetalleVenta.Click += new System.EventHandler(this.btModificarDetalleVenta_Click);
            // 
            // btAgregarDetalleVenta
            // 
            this.btAgregarDetalleVenta.ForeColor = System.Drawing.Color.DarkCyan;
            this.btAgregarDetalleVenta.Location = new System.Drawing.Point(896, 34);
            this.btAgregarDetalleVenta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btAgregarDetalleVenta.Name = "btAgregarDetalleVenta";
            this.btAgregarDetalleVenta.Size = new System.Drawing.Size(100, 49);
            this.btAgregarDetalleVenta.TabIndex = 25;
            this.btAgregarDetalleVenta.Text = "Insertar";
            this.btAgregarDetalleVenta.UseVisualStyleBackColor = true;
            this.btAgregarDetalleVenta.Click += new System.EventHandler(this.btAgregarDetalleVenta_Click);
            // 
            // tabCompra
            // 
            this.tabCompra.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabCompra.Controls.Add(this.lbFechaCompras);
            this.tabCompra.Controls.Add(this.dateCompras);
            this.tabCompra.Controls.Add(this.btEliminarCompras);
            this.tabCompra.Controls.Add(this.btActualizarCompras);
            this.tabCompra.Controls.Add(this.btInsertarCompras);
            this.tabCompra.Controls.Add(this.dtCompras);
            this.tabCompra.Controls.Add(this.lbProveedorCompras);
            this.tabCompra.Controls.Add(this.cbProveedorCompras);
            this.tabCompra.Controls.Add(this.lbEmpleadoCompras);
            this.tabCompra.Controls.Add(this.cbEmpleadoCompras);
            this.tabCompra.Location = new System.Drawing.Point(4, 29);
            this.tabCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCompra.Name = "tabCompra";
            this.tabCompra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCompra.Size = new System.Drawing.Size(1191, 639);
            this.tabCompra.TabIndex = 6;
            this.tabCompra.Text = "Compras";
            this.tabCompra.Enter += new System.EventHandler(this.tabCompra_Enter);
            // 
            // lbFechaCompras
            // 
            this.lbFechaCompras.AutoSize = true;
            this.lbFechaCompras.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaCompras.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbFechaCompras.Location = new System.Drawing.Point(81, 108);
            this.lbFechaCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaCompras.Name = "lbFechaCompras";
            this.lbFechaCompras.Size = new System.Drawing.Size(62, 23);
            this.lbFechaCompras.TabIndex = 14;
            this.lbFechaCompras.Text = "Fecha:";
            // 
            // dateCompras
            // 
            this.dateCompras.Enabled = false;
            this.dateCompras.Location = new System.Drawing.Point(85, 135);
            this.dateCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateCompras.Name = "dateCompras";
            this.dateCompras.Size = new System.Drawing.Size(269, 26);
            this.dateCompras.TabIndex = 3;
            // 
            // btEliminarCompras
            // 
            this.btEliminarCompras.ForeColor = System.Drawing.Color.DarkCyan;
            this.btEliminarCompras.Location = new System.Drawing.Point(1016, 84);
            this.btEliminarCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEliminarCompras.Name = "btEliminarCompras";
            this.btEliminarCompras.Size = new System.Drawing.Size(100, 49);
            this.btEliminarCompras.TabIndex = 12;
            this.btEliminarCompras.Text = "Eliminar";
            this.btEliminarCompras.UseVisualStyleBackColor = true;
            this.btEliminarCompras.Click += new System.EventHandler(this.btEliminarCompras_Click);
            // 
            // btActualizarCompras
            // 
            this.btActualizarCompras.ForeColor = System.Drawing.Color.DarkCyan;
            this.btActualizarCompras.Location = new System.Drawing.Point(896, 112);
            this.btActualizarCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btActualizarCompras.Name = "btActualizarCompras";
            this.btActualizarCompras.Size = new System.Drawing.Size(100, 49);
            this.btActualizarCompras.TabIndex = 11;
            this.btActualizarCompras.Text = "Editar";
            this.btActualizarCompras.UseVisualStyleBackColor = true;
            this.btActualizarCompras.Click += new System.EventHandler(this.btActualizarCompras_Click);
            // 
            // btInsertarCompras
            // 
            this.btInsertarCompras.ForeColor = System.Drawing.Color.DarkCyan;
            this.btInsertarCompras.Location = new System.Drawing.Point(896, 34);
            this.btInsertarCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btInsertarCompras.Name = "btInsertarCompras";
            this.btInsertarCompras.Size = new System.Drawing.Size(100, 49);
            this.btInsertarCompras.TabIndex = 10;
            this.btInsertarCompras.Text = "Insertar";
            this.btInsertarCompras.UseVisualStyleBackColor = true;
            this.btInsertarCompras.Click += new System.EventHandler(this.btInsertarCompras_Click);
            // 
            // dtCompras
            // 
            this.dtCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCompras.Location = new System.Drawing.Point(39, 278);
            this.dtCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtCompras.Name = "dtCompras";
            this.dtCompras.RowHeadersWidth = 51;
            this.dtCompras.Size = new System.Drawing.Size(1111, 313);
            this.dtCompras.TabIndex = 6;
            this.dtCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCompras_CellClick);
            // 
            // lbProveedorCompras
            // 
            this.lbProveedorCompras.AutoSize = true;
            this.lbProveedorCompras.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProveedorCompras.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbProveedorCompras.Location = new System.Drawing.Point(477, 37);
            this.lbProveedorCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProveedorCompras.Name = "lbProveedorCompras";
            this.lbProveedorCompras.Size = new System.Drawing.Size(94, 23);
            this.lbProveedorCompras.TabIndex = 3;
            this.lbProveedorCompras.Text = "Proveedor:";
            // 
            // cbProveedorCompras
            // 
            this.cbProveedorCompras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedorCompras.FormattingEnabled = true;
            this.cbProveedorCompras.Location = new System.Drawing.Point(481, 63);
            this.cbProveedorCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProveedorCompras.Name = "cbProveedorCompras";
            this.cbProveedorCompras.Size = new System.Drawing.Size(269, 28);
            this.cbProveedorCompras.TabIndex = 2;
            // 
            // lbEmpleadoCompras
            // 
            this.lbEmpleadoCompras.AutoSize = true;
            this.lbEmpleadoCompras.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpleadoCompras.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbEmpleadoCompras.Location = new System.Drawing.Point(81, 37);
            this.lbEmpleadoCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmpleadoCompras.Name = "lbEmpleadoCompras";
            this.lbEmpleadoCompras.Size = new System.Drawing.Size(91, 23);
            this.lbEmpleadoCompras.TabIndex = 1;
            this.lbEmpleadoCompras.Text = "Empleado:";
            // 
            // cbEmpleadoCompras
            // 
            this.cbEmpleadoCompras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleadoCompras.FormattingEnabled = true;
            this.cbEmpleadoCompras.Location = new System.Drawing.Point(85, 64);
            this.cbEmpleadoCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmpleadoCompras.Name = "cbEmpleadoCompras";
            this.cbEmpleadoCompras.Size = new System.Drawing.Size(269, 28);
            this.cbEmpleadoCompras.TabIndex = 1;
            // 
            // tabDetalleCompra
            // 
            this.tabDetalleCompra.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabDetalleCompra.Controls.Add(this.btEliminarDetalleCompra);
            this.tabDetalleCompra.Controls.Add(this.dtDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.btActualizarDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.btInsertarDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.tbCantidadDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.lbCantidadDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.cbProductoDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.lbProductoDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.cbCompraDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.lbCompraDetalleCom);
            this.tabDetalleCompra.Location = new System.Drawing.Point(4, 29);
            this.tabDetalleCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDetalleCompra.Name = "tabDetalleCompra";
            this.tabDetalleCompra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDetalleCompra.Size = new System.Drawing.Size(1191, 639);
            this.tabDetalleCompra.TabIndex = 7;
            this.tabDetalleCompra.Text = "Detalle Compras";
            this.tabDetalleCompra.Enter += new System.EventHandler(this.tabDetalleCompra_Enter);
            // 
            // btEliminarDetalleCompra
            // 
            this.btEliminarDetalleCompra.ForeColor = System.Drawing.Color.DarkCyan;
            this.btEliminarDetalleCompra.Location = new System.Drawing.Point(1032, 75);
            this.btEliminarDetalleCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEliminarDetalleCompra.Name = "btEliminarDetalleCompra";
            this.btEliminarDetalleCompra.Size = new System.Drawing.Size(100, 49);
            this.btEliminarDetalleCompra.TabIndex = 17;
            this.btEliminarDetalleCompra.Text = "Eliminar";
            this.btEliminarDetalleCompra.UseVisualStyleBackColor = true;
            this.btEliminarDetalleCompra.Click += new System.EventHandler(this.btEliminarDetalleCompra_Click);
            // 
            // dtDetalleCom
            // 
            this.dtDetalleCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetalleCom.Location = new System.Drawing.Point(39, 278);
            this.dtDetalleCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDetalleCom.Name = "dtDetalleCom";
            this.dtDetalleCom.RowHeadersWidth = 51;
            this.dtDetalleCom.Size = new System.Drawing.Size(1111, 313);
            this.dtDetalleCom.TabIndex = 16;
            this.dtDetalleCom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDetalleCom_CellClick);
            // 
            // btActualizarDetalleCom
            // 
            this.btActualizarDetalleCom.ForeColor = System.Drawing.Color.DarkCyan;
            this.btActualizarDetalleCom.Location = new System.Drawing.Point(896, 112);
            this.btActualizarDetalleCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btActualizarDetalleCom.Name = "btActualizarDetalleCom";
            this.btActualizarDetalleCom.Size = new System.Drawing.Size(100, 49);
            this.btActualizarDetalleCom.TabIndex = 14;
            this.btActualizarDetalleCom.Text = "Editar";
            this.btActualizarDetalleCom.UseVisualStyleBackColor = true;
            this.btActualizarDetalleCom.Click += new System.EventHandler(this.btActualizarDetalleCom_Click);
            // 
            // btInsertarDetalleCom
            // 
            this.btInsertarDetalleCom.ForeColor = System.Drawing.Color.DarkCyan;
            this.btInsertarDetalleCom.Location = new System.Drawing.Point(896, 34);
            this.btInsertarDetalleCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btInsertarDetalleCom.Name = "btInsertarDetalleCom";
            this.btInsertarDetalleCom.Size = new System.Drawing.Size(100, 49);
            this.btInsertarDetalleCom.TabIndex = 13;
            this.btInsertarDetalleCom.Text = "Insertar";
            this.btInsertarDetalleCom.UseVisualStyleBackColor = true;
            this.btInsertarDetalleCom.Click += new System.EventHandler(this.btInsertarDetalleCom_Click);
            // 
            // tbCantidadDetalleCom
            // 
            this.tbCantidadDetalleCom.Location = new System.Drawing.Point(95, 153);
            this.tbCantidadDetalleCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCantidadDetalleCom.Name = "tbCantidadDetalleCom";
            this.tbCantidadDetalleCom.Size = new System.Drawing.Size(269, 26);
            this.tbCantidadDetalleCom.TabIndex = 3;
            // 
            // lbCantidadDetalleCom
            // 
            this.lbCantidadDetalleCom.AutoSize = true;
            this.lbCantidadDetalleCom.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadDetalleCom.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbCantidadDetalleCom.Location = new System.Drawing.Point(91, 127);
            this.lbCantidadDetalleCom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCantidadDetalleCom.Name = "lbCantidadDetalleCom";
            this.lbCantidadDetalleCom.Size = new System.Drawing.Size(83, 23);
            this.lbCantidadDetalleCom.TabIndex = 5;
            this.lbCantidadDetalleCom.Text = "Cantidad:";
            // 
            // cbProductoDetalleCom
            // 
            this.cbProductoDetalleCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductoDetalleCom.FormattingEnabled = true;
            this.cbProductoDetalleCom.Location = new System.Drawing.Point(431, 60);
            this.cbProductoDetalleCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProductoDetalleCom.Name = "cbProductoDetalleCom";
            this.cbProductoDetalleCom.Size = new System.Drawing.Size(269, 28);
            this.cbProductoDetalleCom.TabIndex = 2;
            // 
            // lbProductoDetalleCom
            // 
            this.lbProductoDetalleCom.AutoSize = true;
            this.lbProductoDetalleCom.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductoDetalleCom.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbProductoDetalleCom.Location = new System.Drawing.Point(427, 36);
            this.lbProductoDetalleCom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProductoDetalleCom.Name = "lbProductoDetalleCom";
            this.lbProductoDetalleCom.Size = new System.Drawing.Size(85, 23);
            this.lbProductoDetalleCom.TabIndex = 2;
            this.lbProductoDetalleCom.Text = "Producto:";
            // 
            // cbCompraDetalleCom
            // 
            this.cbCompraDetalleCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompraDetalleCom.FormattingEnabled = true;
            this.cbCompraDetalleCom.Location = new System.Drawing.Point(95, 62);
            this.cbCompraDetalleCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCompraDetalleCom.Name = "cbCompraDetalleCom";
            this.cbCompraDetalleCom.Size = new System.Drawing.Size(269, 28);
            this.cbCompraDetalleCom.TabIndex = 1;
            // 
            // lbCompraDetalleCom
            // 
            this.lbCompraDetalleCom.AutoSize = true;
            this.lbCompraDetalleCom.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompraDetalleCom.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbCompraDetalleCom.Location = new System.Drawing.Point(91, 36);
            this.lbCompraDetalleCom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCompraDetalleCom.Name = "lbCompraDetalleCom";
            this.lbCompraDetalleCom.Size = new System.Drawing.Size(75, 23);
            this.lbCompraDetalleCom.TabIndex = 0;
            this.lbCompraDetalleCom.Text = "Compra:";
            // 
            // tabDevolucion
            // 
            this.tabDevolucion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabDevolucion.Controls.Add(this.lFechaVentaDevo);
            this.tabDevolucion.Controls.Add(this.dgDevoluciones);
            this.tabDevolucion.Controls.Add(this.bEditarDevo);
            this.tabDevolucion.Controls.Add(this.bEliminarDevo);
            this.tabDevolucion.Controls.Add(this.bAgregarDevo);
            this.tabDevolucion.Controls.Add(this.lCantidadDevo);
            this.tabDevolucion.Controls.Add(this.tbCantidadDevo);
            this.tabDevolucion.Controls.Add(this.lMotivoDevolucionDevo);
            this.tabDevolucion.Controls.Add(this.tbMotivoDevolucionDevo);
            this.tabDevolucion.Controls.Add(this.dtFechaVentaDevo);
            this.tabDevolucion.Controls.Add(this.lVentaDevoluciones);
            this.tabDevolucion.Controls.Add(this.cbVentasDevo);
            this.tabDevolucion.Controls.Add(this.lNombreEmpleadoDevolucion);
            this.tabDevolucion.Controls.Add(this.cbNombreEmpleadosDevo);
            this.tabDevolucion.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDevolucion.ForeColor = System.Drawing.Color.DarkCyan;
            this.tabDevolucion.Location = new System.Drawing.Point(4, 29);
            this.tabDevolucion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabDevolucion.Name = "tabDevolucion";
            this.tabDevolucion.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabDevolucion.Size = new System.Drawing.Size(1191, 639);
            this.tabDevolucion.TabIndex = 8;
            this.tabDevolucion.Text = "Devoluciones";
            // 
            // lFechaVentaDevo
            // 
            this.lFechaVentaDevo.AutoSize = true;
            this.lFechaVentaDevo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaVentaDevo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lFechaVentaDevo.Location = new System.Drawing.Point(464, 33);
            this.lFechaVentaDevo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lFechaVentaDevo.Name = "lFechaVentaDevo";
            this.lFechaVentaDevo.Size = new System.Drawing.Size(152, 23);
            this.lFechaVentaDevo.TabIndex = 20;
            this.lFechaVentaDevo.Text = "Fecha Devolución:";
            // 
            // dgDevoluciones
            // 
            this.dgDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDevoluciones.Location = new System.Drawing.Point(39, 278);
            this.dgDevoluciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDevoluciones.Name = "dgDevoluciones";
            this.dgDevoluciones.RowHeadersWidth = 51;
            this.dgDevoluciones.RowTemplate.Height = 24;
            this.dgDevoluciones.Size = new System.Drawing.Size(1111, 313);
            this.dgDevoluciones.TabIndex = 19;
            this.dgDevoluciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDevoluciones_CellClick);
            // 
            // bEditarDevo
            // 
            this.bEditarDevo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditarDevo.ForeColor = System.Drawing.Color.DarkCyan;
            this.bEditarDevo.Location = new System.Drawing.Point(896, 112);
            this.bEditarDevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEditarDevo.Name = "bEditarDevo";
            this.bEditarDevo.Size = new System.Drawing.Size(100, 49);
            this.bEditarDevo.TabIndex = 18;
            this.bEditarDevo.Text = "Editar";
            this.bEditarDevo.UseVisualStyleBackColor = true;
            this.bEditarDevo.Click += new System.EventHandler(this.BEditarDevo_Click);
            // 
            // bEliminarDevo
            // 
            this.bEliminarDevo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminarDevo.ForeColor = System.Drawing.Color.DarkCyan;
            this.bEliminarDevo.Location = new System.Drawing.Point(1016, 84);
            this.bEliminarDevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEliminarDevo.Name = "bEliminarDevo";
            this.bEliminarDevo.Size = new System.Drawing.Size(100, 49);
            this.bEliminarDevo.TabIndex = 17;
            this.bEliminarDevo.Text = "Eliminar";
            this.bEliminarDevo.UseVisualStyleBackColor = true;
            this.bEliminarDevo.Click += new System.EventHandler(this.BEliminarDevo_Click);
            // 
            // bAgregarDevo
            // 
            this.bAgregarDevo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregarDevo.ForeColor = System.Drawing.Color.DarkCyan;
            this.bAgregarDevo.Location = new System.Drawing.Point(896, 34);
            this.bAgregarDevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAgregarDevo.Name = "bAgregarDevo";
            this.bAgregarDevo.Size = new System.Drawing.Size(100, 49);
            this.bAgregarDevo.TabIndex = 16;
            this.bAgregarDevo.Text = "Insertar";
            this.bAgregarDevo.UseVisualStyleBackColor = true;
            this.bAgregarDevo.Click += new System.EventHandler(this.BAgregarDevo_Click);
            // 
            // lCantidadDevo
            // 
            this.lCantidadDevo.AutoSize = true;
            this.lCantidadDevo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidadDevo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lCantidadDevo.Location = new System.Drawing.Point(464, 112);
            this.lCantidadDevo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lCantidadDevo.Name = "lCantidadDevo";
            this.lCantidadDevo.Size = new System.Drawing.Size(63, 23);
            this.lCantidadDevo.TabIndex = 15;
            this.lCantidadDevo.Text = "Monto:";
            this.lCantidadDevo.Visible = false;
            // 
            // tbCantidadDevo
            // 
            this.tbCantidadDevo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidadDevo.Location = new System.Drawing.Point(469, 137);
            this.tbCantidadDevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbCantidadDevo.Name = "tbCantidadDevo";
            this.tbCantidadDevo.Size = new System.Drawing.Size(269, 26);
            this.tbCantidadDevo.TabIndex = 4;
            this.tbCantidadDevo.Visible = false;
            // 
            // lMotivoDevolucionDevo
            // 
            this.lMotivoDevolucionDevo.AutoSize = true;
            this.lMotivoDevolucionDevo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMotivoDevolucionDevo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lMotivoDevolucionDevo.Location = new System.Drawing.Point(76, 191);
            this.lMotivoDevolucionDevo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lMotivoDevolucionDevo.Name = "lMotivoDevolucionDevo";
            this.lMotivoDevolucionDevo.Size = new System.Drawing.Size(155, 23);
            this.lMotivoDevolucionDevo.TabIndex = 13;
            this.lMotivoDevolucionDevo.Text = "Motivo devolución:";
            // 
            // tbMotivoDevolucionDevo
            // 
            this.tbMotivoDevolucionDevo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMotivoDevolucionDevo.Location = new System.Drawing.Point(76, 215);
            this.tbMotivoDevolucionDevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbMotivoDevolucionDevo.Name = "tbMotivoDevolucionDevo";
            this.tbMotivoDevolucionDevo.Size = new System.Drawing.Size(269, 26);
            this.tbMotivoDevolucionDevo.TabIndex = 5;
            // 
            // dtFechaVentaDevo
            // 
            this.dtFechaVentaDevo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaVentaDevo.Location = new System.Drawing.Point(469, 58);
            this.dtFechaVentaDevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtFechaVentaDevo.Name = "dtFechaVentaDevo";
            this.dtFechaVentaDevo.Size = new System.Drawing.Size(269, 26);
            this.dtFechaVentaDevo.TabIndex = 2;
            // 
            // lVentaDevoluciones
            // 
            this.lVentaDevoluciones.AutoSize = true;
            this.lVentaDevoluciones.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVentaDevoluciones.ForeColor = System.Drawing.Color.DarkCyan;
            this.lVentaDevoluciones.Location = new System.Drawing.Point(75, 111);
            this.lVentaDevoluciones.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lVentaDevoluciones.Name = "lVentaDevoluciones";
            this.lVentaDevoluciones.Size = new System.Drawing.Size(58, 23);
            this.lVentaDevoluciones.TabIndex = 10;
            this.lVentaDevoluciones.Text = "Venta:";
            // 
            // cbVentasDevo
            // 
            this.cbVentasDevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVentasDevo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVentasDevo.FormattingEnabled = true;
            this.cbVentasDevo.Location = new System.Drawing.Point(75, 137);
            this.cbVentasDevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbVentasDevo.Name = "cbVentasDevo";
            this.cbVentasDevo.Size = new System.Drawing.Size(269, 28);
            this.cbVentasDevo.TabIndex = 3;
            // 
            // lNombreEmpleadoDevolucion
            // 
            this.lNombreEmpleadoDevolucion.AutoSize = true;
            this.lNombreEmpleadoDevolucion.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreEmpleadoDevolucion.ForeColor = System.Drawing.Color.DarkCyan;
            this.lNombreEmpleadoDevolucion.Location = new System.Drawing.Point(71, 33);
            this.lNombreEmpleadoDevolucion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lNombreEmpleadoDevolucion.Name = "lNombreEmpleadoDevolucion";
            this.lNombreEmpleadoDevolucion.Size = new System.Drawing.Size(154, 23);
            this.lNombreEmpleadoDevolucion.TabIndex = 8;
            this.lNombreEmpleadoDevolucion.Text = "Nombre empleado:";
            // 
            // cbNombreEmpleadosDevo
            // 
            this.cbNombreEmpleadosDevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreEmpleadosDevo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNombreEmpleadosDevo.FormattingEnabled = true;
            this.cbNombreEmpleadosDevo.Location = new System.Drawing.Point(76, 60);
            this.cbNombreEmpleadosDevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbNombreEmpleadosDevo.Name = "cbNombreEmpleadosDevo";
            this.cbNombreEmpleadosDevo.Size = new System.Drawing.Size(269, 28);
            this.cbNombreEmpleadosDevo.TabIndex = 1;
            // 
            // tabDetalleDevolucion
            // 
            this.tabDetalleDevolucion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabDetalleDevolucion.Controls.Add(this.bEditaDetalleDev);
            this.tabDetalleDevolucion.Controls.Add(this.bEliminaDetalleDev);
            this.tabDetalleDevolucion.Controls.Add(this.bInsertaDetalleDev);
            this.tabDetalleDevolucion.Controls.Add(this.labelCantiDetalledev);
            this.tabDetalleDevolucion.Controls.Add(this.labelProductoDetalleDev);
            this.tabDetalleDevolucion.Controls.Add(this.labelMotivoDevDetalledev);
            this.tabDetalleDevolucion.Controls.Add(this.tbCantidadDetalleDevo);
            this.tabDetalleDevolucion.Controls.Add(this.cbIdProductoDetalleDevo);
            this.tabDetalleDevolucion.Controls.Add(this.cbIdDevolucionDetalleDevo);
            this.tabDetalleDevolucion.Controls.Add(this.dGDetalleDevoluciones);
            this.tabDetalleDevolucion.Location = new System.Drawing.Point(4, 29);
            this.tabDetalleDevolucion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabDetalleDevolucion.Name = "tabDetalleDevolucion";
            this.tabDetalleDevolucion.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabDetalleDevolucion.Size = new System.Drawing.Size(1191, 639);
            this.tabDetalleDevolucion.TabIndex = 9;
            this.tabDetalleDevolucion.Text = "Detalle Devoluciones";
            // 
            // bEditaDetalleDev
            // 
            this.bEditaDetalleDev.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditaDetalleDev.ForeColor = System.Drawing.Color.DarkCyan;
            this.bEditaDetalleDev.Location = new System.Drawing.Point(845, 150);
            this.bEditaDetalleDev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEditaDetalleDev.Name = "bEditaDetalleDev";
            this.bEditaDetalleDev.Size = new System.Drawing.Size(100, 49);
            this.bEditaDetalleDev.TabIndex = 17;
            this.bEditaDetalleDev.Text = "Editar";
            this.bEditaDetalleDev.UseVisualStyleBackColor = true;
            this.bEditaDetalleDev.Click += new System.EventHandler(this.BEditaDetalleDev_Click);
            // 
            // bEliminaDetalleDev
            // 
            this.bEliminaDetalleDev.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminaDetalleDev.ForeColor = System.Drawing.Color.DarkCyan;
            this.bEliminaDetalleDev.Location = new System.Drawing.Point(965, 122);
            this.bEliminaDetalleDev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEliminaDetalleDev.Name = "bEliminaDetalleDev";
            this.bEliminaDetalleDev.Size = new System.Drawing.Size(100, 49);
            this.bEliminaDetalleDev.TabIndex = 16;
            this.bEliminaDetalleDev.Text = "Eliminar";
            this.bEliminaDetalleDev.UseVisualStyleBackColor = true;
            this.bEliminaDetalleDev.Click += new System.EventHandler(this.BEliminaDetalleDev_Click);
            // 
            // bInsertaDetalleDev
            // 
            this.bInsertaDetalleDev.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bInsertaDetalleDev.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsertaDetalleDev.ForeColor = System.Drawing.Color.DarkCyan;
            this.bInsertaDetalleDev.Location = new System.Drawing.Point(845, 71);
            this.bInsertaDetalleDev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInsertaDetalleDev.Name = "bInsertaDetalleDev";
            this.bInsertaDetalleDev.Size = new System.Drawing.Size(100, 49);
            this.bInsertaDetalleDev.TabIndex = 15;
            this.bInsertaDetalleDev.Text = "Insertar";
            this.bInsertaDetalleDev.UseVisualStyleBackColor = false;
            this.bInsertaDetalleDev.Click += new System.EventHandler(this.BInsertaDetalleDev_Click);
            // 
            // labelCantiDetalledev
            // 
            this.labelCantiDetalledev.AutoSize = true;
            this.labelCantiDetalledev.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantiDetalledev.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelCantiDetalledev.Location = new System.Drawing.Point(105, 122);
            this.labelCantiDetalledev.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCantiDetalledev.Name = "labelCantiDetalledev";
            this.labelCantiDetalledev.Size = new System.Drawing.Size(83, 23);
            this.labelCantiDetalledev.TabIndex = 6;
            this.labelCantiDetalledev.Text = "Cantidad:";
            // 
            // labelProductoDetalleDev
            // 
            this.labelProductoDetalleDev.AutoSize = true;
            this.labelProductoDetalleDev.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductoDetalleDev.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelProductoDetalleDev.Location = new System.Drawing.Point(484, 38);
            this.labelProductoDetalleDev.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProductoDetalleDev.Name = "labelProductoDetalleDev";
            this.labelProductoDetalleDev.Size = new System.Drawing.Size(85, 23);
            this.labelProductoDetalleDev.TabIndex = 5;
            this.labelProductoDetalleDev.Text = "Producto:";
            // 
            // labelMotivoDevDetalledev
            // 
            this.labelMotivoDevDetalledev.AutoSize = true;
            this.labelMotivoDevDetalledev.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotivoDevDetalledev.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelMotivoDevDetalledev.Location = new System.Drawing.Point(107, 39);
            this.labelMotivoDevDetalledev.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMotivoDevDetalledev.Name = "labelMotivoDevDetalledev";
            this.labelMotivoDevDetalledev.Size = new System.Drawing.Size(155, 23);
            this.labelMotivoDevDetalledev.TabIndex = 4;
            this.labelMotivoDevDetalledev.Text = "Motivo devolución:";
            // 
            // tbCantidadDetalleDevo
            // 
            this.tbCantidadDetalleDevo.Enabled = false;
            this.tbCantidadDetalleDevo.Location = new System.Drawing.Point(108, 148);
            this.tbCantidadDetalleDevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbCantidadDetalleDevo.Name = "tbCantidadDetalleDevo";
            this.tbCantidadDetalleDevo.Size = new System.Drawing.Size(269, 26);
            this.tbCantidadDetalleDevo.TabIndex = 3;
            // 
            // cbIdProductoDetalleDevo
            // 
            this.cbIdProductoDetalleDevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdProductoDetalleDevo.FormattingEnabled = true;
            this.cbIdProductoDetalleDevo.Location = new System.Drawing.Point(487, 68);
            this.cbIdProductoDetalleDevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbIdProductoDetalleDevo.Name = "cbIdProductoDetalleDevo";
            this.cbIdProductoDetalleDevo.Size = new System.Drawing.Size(269, 28);
            this.cbIdProductoDetalleDevo.TabIndex = 2;
            this.cbIdProductoDetalleDevo.SelectedIndexChanged += new System.EventHandler(this.CbIdProductoDetalleDevo_SelectedIndexChanged);
            // 
            // cbIdDevolucionDetalleDevo
            // 
            this.cbIdDevolucionDetalleDevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdDevolucionDetalleDevo.FormattingEnabled = true;
            this.cbIdDevolucionDetalleDevo.Location = new System.Drawing.Point(108, 68);
            this.cbIdDevolucionDetalleDevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbIdDevolucionDetalleDevo.Name = "cbIdDevolucionDetalleDevo";
            this.cbIdDevolucionDetalleDevo.Size = new System.Drawing.Size(269, 28);
            this.cbIdDevolucionDetalleDevo.TabIndex = 1;
            this.cbIdDevolucionDetalleDevo.SelectedIndexChanged += new System.EventHandler(this.CbIdDevolucionDetalleDevo_SelectedIndexChanged);
            // 
            // dGDetalleDevoluciones
            // 
            this.dGDetalleDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGDetalleDevoluciones.Location = new System.Drawing.Point(39, 278);
            this.dGDetalleDevoluciones.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dGDetalleDevoluciones.Name = "dGDetalleDevoluciones";
            this.dGDetalleDevoluciones.RowHeadersWidth = 51;
            this.dGDetalleDevoluciones.RowTemplate.Height = 24;
            this.dGDetalleDevoluciones.Size = new System.Drawing.Size(1111, 313);
            this.dGDetalleDevoluciones.TabIndex = 0;
            this.dGDetalleDevoluciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetalleDevoluciones_CellClick);
            // 
            // tabEntrega
            // 
            this.tabEntrega.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabEntrega.Controls.Add(this.label1);
            this.tabEntrega.Controls.Add(this.lEntregasMotivoDev);
            this.tabEntrega.Controls.Add(this.bEditarEntrega);
            this.tabEntrega.Controls.Add(this.bEliminaEntrega);
            this.tabEntrega.Controls.Add(this.bAgregarEntrega);
            this.tabEntrega.Controls.Add(this.labelNombreEmpleadoEntrega);
            this.tabEntrega.Controls.Add(this.labelNombreProvEntrega);
            this.tabEntrega.Controls.Add(this.dTFechaEntregaEntregas);
            this.tabEntrega.Controls.Add(this.cBIdDevolucion);
            this.tabEntrega.Controls.Add(this.cBIdEmpleado);
            this.tabEntrega.Controls.Add(this.cBIdProveedor);
            this.tabEntrega.Controls.Add(this.dGEntregas);
            this.tabEntrega.Location = new System.Drawing.Point(4, 29);
            this.tabEntrega.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabEntrega.Name = "tabEntrega";
            this.tabEntrega.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabEntrega.Size = new System.Drawing.Size(1191, 639);
            this.tabEntrega.TabIndex = 10;
            this.tabEntrega.Text = "Entregas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(501, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha Entrega:";
            // 
            // lEntregasMotivoDev
            // 
            this.lEntregasMotivoDev.AutoSize = true;
            this.lEntregasMotivoDev.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEntregasMotivoDev.ForeColor = System.Drawing.Color.DarkCyan;
            this.lEntregasMotivoDev.Location = new System.Drawing.Point(99, 137);
            this.lEntregasMotivoDev.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lEntregasMotivoDev.Name = "lEntregasMotivoDev";
            this.lEntregasMotivoDev.Size = new System.Drawing.Size(155, 23);
            this.lEntregasMotivoDev.TabIndex = 11;
            this.lEntregasMotivoDev.Text = "Motivo devolución:";
            // 
            // bEditarEntrega
            // 
            this.bEditarEntrega.ForeColor = System.Drawing.Color.DarkCyan;
            this.bEditarEntrega.Location = new System.Drawing.Point(896, 112);
            this.bEditarEntrega.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bEditarEntrega.Name = "bEditarEntrega";
            this.bEditarEntrega.Size = new System.Drawing.Size(100, 49);
            this.bEditarEntrega.TabIndex = 10;
            this.bEditarEntrega.Text = "Editar";
            this.bEditarEntrega.UseVisualStyleBackColor = true;
            this.bEditarEntrega.Click += new System.EventHandler(this.BEditarEntrega_Click);
            // 
            // bEliminaEntrega
            // 
            this.bEliminaEntrega.ForeColor = System.Drawing.Color.DarkCyan;
            this.bEliminaEntrega.Location = new System.Drawing.Point(1016, 84);
            this.bEliminaEntrega.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bEliminaEntrega.Name = "bEliminaEntrega";
            this.bEliminaEntrega.Size = new System.Drawing.Size(100, 49);
            this.bEliminaEntrega.TabIndex = 9;
            this.bEliminaEntrega.Text = "Eliminar";
            this.bEliminaEntrega.UseVisualStyleBackColor = true;
            this.bEliminaEntrega.Click += new System.EventHandler(this.BEliminaEntrega_Click);
            // 
            // bAgregarEntrega
            // 
            this.bAgregarEntrega.ForeColor = System.Drawing.Color.DarkCyan;
            this.bAgregarEntrega.Location = new System.Drawing.Point(896, 34);
            this.bAgregarEntrega.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bAgregarEntrega.Name = "bAgregarEntrega";
            this.bAgregarEntrega.Size = new System.Drawing.Size(100, 49);
            this.bAgregarEntrega.TabIndex = 8;
            this.bAgregarEntrega.Text = "Insertar";
            this.bAgregarEntrega.UseVisualStyleBackColor = true;
            this.bAgregarEntrega.Click += new System.EventHandler(this.BAgregarEntrega_Click);
            // 
            // labelNombreEmpleadoEntrega
            // 
            this.labelNombreEmpleadoEntrega.AutoSize = true;
            this.labelNombreEmpleadoEntrega.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEmpleadoEntrega.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelNombreEmpleadoEntrega.Location = new System.Drawing.Point(501, 47);
            this.labelNombreEmpleadoEntrega.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNombreEmpleadoEntrega.Name = "labelNombreEmpleadoEntrega";
            this.labelNombreEmpleadoEntrega.Size = new System.Drawing.Size(154, 23);
            this.labelNombreEmpleadoEntrega.TabIndex = 6;
            this.labelNombreEmpleadoEntrega.Text = "Nombre empleado:";
            // 
            // labelNombreProvEntrega
            // 
            this.labelNombreProvEntrega.AutoSize = true;
            this.labelNombreProvEntrega.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProvEntrega.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelNombreProvEntrega.Location = new System.Drawing.Point(99, 46);
            this.labelNombreProvEntrega.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNombreProvEntrega.Name = "labelNombreProvEntrega";
            this.labelNombreProvEntrega.Size = new System.Drawing.Size(158, 23);
            this.labelNombreProvEntrega.TabIndex = 5;
            this.labelNombreProvEntrega.Text = "Nombre proveedor:";
            // 
            // dTFechaEntregaEntregas
            // 
            this.dTFechaEntregaEntregas.Location = new System.Drawing.Point(505, 165);
            this.dTFechaEntregaEntregas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dTFechaEntregaEntregas.Name = "dTFechaEntregaEntregas";
            this.dTFechaEntregaEntregas.Size = new System.Drawing.Size(269, 26);
            this.dTFechaEntregaEntregas.TabIndex = 4;
            // 
            // cBIdDevolucion
            // 
            this.cBIdDevolucion.DropDownHeight = 206;
            this.cBIdDevolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIdDevolucion.FormattingEnabled = true;
            this.cBIdDevolucion.IntegralHeight = false;
            this.cBIdDevolucion.Location = new System.Drawing.Point(104, 165);
            this.cBIdDevolucion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cBIdDevolucion.Name = "cBIdDevolucion";
            this.cBIdDevolucion.Size = new System.Drawing.Size(269, 28);
            this.cBIdDevolucion.TabIndex = 3;
            // 
            // cBIdEmpleado
            // 
            this.cBIdEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIdEmpleado.FormattingEnabled = true;
            this.cBIdEmpleado.Location = new System.Drawing.Point(505, 75);
            this.cBIdEmpleado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cBIdEmpleado.Name = "cBIdEmpleado";
            this.cBIdEmpleado.Size = new System.Drawing.Size(269, 28);
            this.cBIdEmpleado.TabIndex = 2;
            // 
            // cBIdProveedor
            // 
            this.cBIdProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIdProveedor.FormattingEnabled = true;
            this.cBIdProveedor.Location = new System.Drawing.Point(104, 74);
            this.cBIdProveedor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cBIdProveedor.Name = "cBIdProveedor";
            this.cBIdProveedor.Size = new System.Drawing.Size(269, 28);
            this.cBIdProveedor.TabIndex = 1;
            // 
            // dGEntregas
            // 
            this.dGEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGEntregas.Location = new System.Drawing.Point(39, 278);
            this.dGEntregas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dGEntregas.Name = "dGEntregas";
            this.dGEntregas.RowHeadersWidth = 51;
            this.dGEntregas.RowTemplate.Height = 24;
            this.dGEntregas.Size = new System.Drawing.Size(1111, 313);
            this.dGEntregas.TabIndex = 0;
            this.dGEntregas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGEntregas_CellClick);
            // 
            // cBDescuentos
            // 
            this.cBDescuentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDescuentos.FormattingEnabled = true;
            this.cBDescuentos.Items.AddRange(new object[] {
            "0.0",
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1.0"});
            this.cBDescuentos.Location = new System.Drawing.Point(423, 133);
            this.cBDescuentos.Name = "cBDescuentos";
            this.cBDescuentos.Size = new System.Drawing.Size(182, 28);
            this.cBDescuentos.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 718);
            this.Controls.Add(this.tabVistas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Abarrotes";
            this.tabVistas.ResumeLayout(false);
            this.tabEmpleado.ResumeLayout(false);
            this.tabEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGEmpleados)).EndInit();
            this.tabProveedor.ResumeLayout(false);
            this.tabProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).EndInit();
            this.tabProducto.ResumeLayout(false);
            this.tabProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProducto)).EndInit();
            this.tabVenta.ResumeLayout(false);
            this.tabVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).EndInit();
            this.tabPromocion.ResumeLayout(false);
            this.tabPromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPromocion)).EndInit();
            this.tabDetalleVenta.ResumeLayout(false);
            this.tabDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).EndInit();
            this.tabCompra.ResumeLayout(false);
            this.tabCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).EndInit();
            this.tabDetalleCompra.ResumeLayout(false);
            this.tabDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalleCom)).EndInit();
            this.tabDevolucion.ResumeLayout(false);
            this.tabDevolucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevoluciones)).EndInit();
            this.tabDetalleDevolucion.ResumeLayout(false);
            this.tabDetalleDevolucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGDetalleDevoluciones)).EndInit();
            this.tabEntrega.ResumeLayout(false);
            this.tabEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGEntregas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabVistas;
        private System.Windows.Forms.TabPage tabEmpleado;
        private System.Windows.Forms.TabPage tabProveedor;
        private System.Windows.Forms.Button bAgregarEmpleado;
        private System.Windows.Forms.TextBox tbEmpleadoUsuario;
        private System.Windows.Forms.Label lEmpleadoUsuario;
        private System.Windows.Forms.Label lEmpleadoFN;
        private System.Windows.Forms.TextBox tbEmpleadoDomicilio;
        private System.Windows.Forms.Label lEmpleadoDomicilio;
        private System.Windows.Forms.TextBox tbEmpleadoNombre;
        private System.Windows.Forms.Label lEmpleadoNombreEmpleado;
        private System.Windows.Forms.Button bEliminarEmpleado;
        private System.Windows.Forms.TextBox tbEmpleadoPass;
        private System.Windows.Forms.Label lEmpladoPass;
        private System.Windows.Forms.TabPage tabProducto;
        private System.Windows.Forms.TabPage tabVenta;
        private System.Windows.Forms.TabPage tabPromocion;
        private System.Windows.Forms.TabPage tabDetalleVenta;
        private System.Windows.Forms.TabPage tabCompra;
        private System.Windows.Forms.TabPage tabDetalleCompra;
        private System.Windows.Forms.TabPage tabDevolucion;
        private System.Windows.Forms.TabPage tabDetalleDevolucion;
        private System.Windows.Forms.TabPage tabEntrega;
        private System.Windows.Forms.DataGridView dGDetalleDevoluciones;
        private System.Windows.Forms.DataGridView dGEntregas;
       // private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelNombreEmpleadoEntrega;
        private System.Windows.Forms.Label labelNombreProvEntrega;
        private System.Windows.Forms.DateTimePicker dTFechaEntregaEntregas;
        private System.Windows.Forms.ComboBox cBIdDevolucion;
        private System.Windows.Forms.ComboBox cBIdEmpleado;
        private System.Windows.Forms.Button bAgregarEntrega;
        private System.Windows.Forms.ComboBox cBIdProveedor;
        private System.Windows.Forms.Button bEliminaEntrega;
        private System.Windows.Forms.Button bEditarEntrega;
        private System.Windows.Forms.TextBox tbCantidadDetalleDevo;
        private System.Windows.Forms.ComboBox cbIdProductoDetalleDevo;
        private System.Windows.Forms.ComboBox cbIdDevolucionDetalleDevo;
        private System.Windows.Forms.Label labelCantiDetalledev;
        private System.Windows.Forms.Label labelProductoDetalleDev;
        private System.Windows.Forms.Label labelMotivoDevDetalledev;
        private System.Windows.Forms.DataGridView dgVentas;
        private System.Windows.Forms.Button btEliminarVenta;
        private System.Windows.Forms.Button btModificarVenta;
        private System.Windows.Forms.Button btAgregarVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgPromocion;
        private System.Windows.Forms.Button btEliminarPromocion;
        private System.Windows.Forms.Button btModificarPromocion;
        private System.Windows.Forms.Button btAgregarPromocion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.DataGridView dgDetalleVenta;
        private System.Windows.Forms.Button btEliminarDetalleVenta;
        private System.Windows.Forms.Button btModificarDetalleVenta;
        private System.Windows.Forms.Button btAgregarDetalleVenta;
        private System.Windows.Forms.Button btActualizarProducto;
        private System.Windows.Forms.Label lbCostoVentaProducto;
        private System.Windows.Forms.TextBox tbCostoVentaProducto;
        private System.Windows.Forms.Label lbCostoProvProducto;
        private System.Windows.Forms.TextBox tbCostoProvProducto;
        private System.Windows.Forms.Label lbExistenciasProducto;
        private System.Windows.Forms.TextBox tbExistenciasProducto;
        private System.Windows.Forms.Label lbNombreProducto;
        private System.Windows.Forms.TextBox tbNombreProducto;
        private System.Windows.Forms.Button btInsertarProducto;
        private System.Windows.Forms.DataGridView dtProducto;
        private System.Windows.Forms.DataGridView dtCompras;
        private System.Windows.Forms.Label lbProveedorCompras;
        private System.Windows.Forms.ComboBox cbProveedorCompras;
        private System.Windows.Forms.Label lbEmpleadoCompras;
        private System.Windows.Forms.ComboBox cbEmpleadoCompras;
        private System.Windows.Forms.Button btActualizarCompras;
        private System.Windows.Forms.Button btInsertarCompras;
        private System.Windows.Forms.Button btEliminarProducto;
        private System.Windows.Forms.Button btEliminarCompras;
        private System.Windows.Forms.Label lbFechaCompras;
        private System.Windows.Forms.DateTimePicker dateCompras;
        private System.Windows.Forms.Button btActualizarDetalleCom;
        private System.Windows.Forms.Button btInsertarDetalleCom;
        private System.Windows.Forms.TextBox tbCantidadDetalleCom;
        private System.Windows.Forms.Label lbCantidadDetalleCom;
        private System.Windows.Forms.ComboBox cbProductoDetalleCom;
        private System.Windows.Forms.Label lbProductoDetalleCom;
        private System.Windows.Forms.ComboBox cbCompraDetalleCom;
        private System.Windows.Forms.Label lbCompraDetalleCom;
        private System.Windows.Forms.DataGridView dtDetalleCom;
        private System.Windows.Forms.DataGridView dGEmpleados;
        private System.Windows.Forms.DateTimePicker dTEmpleadoFN;
        private System.Windows.Forms.Button bEditarEmpleado;
        private System.Windows.Forms.TextBox tbEmailProveedor;
        private System.Windows.Forms.Label lEmailProveedor;
        private System.Windows.Forms.Button bEditarProveedor;
        private System.Windows.Forms.DataGridView dgProveedores;
        private System.Windows.Forms.Button bEliminaProveedor;
        private System.Windows.Forms.TextBox tbTelefonoProveedor;
        private System.Windows.Forms.Label lTelefonoProveedor;
        private System.Windows.Forms.Button bAgregarProveedor;
        private System.Windows.Forms.TextBox tbRFCProveedor;
        private System.Windows.Forms.Label lRFCProveedor;
        private System.Windows.Forms.TextBox tbDomicilioFiscal;
        private System.Windows.Forms.Label lDomicilioProveedor;
        private System.Windows.Forms.TextBox tbNombreProveedor;
        private System.Windows.Forms.Label lNombreProveedor;
        private System.Windows.Forms.Label lEntregasMotivoDev;
        private System.Windows.Forms.Label lFechaVentaDevo;
        private System.Windows.Forms.DataGridView dgDevoluciones;
        private System.Windows.Forms.Button bEditarDevo;
        private System.Windows.Forms.Button bEliminarDevo;
        private System.Windows.Forms.Button bAgregarDevo;
        private System.Windows.Forms.Label lMotivoDevolucionDevo;
        private System.Windows.Forms.TextBox tbMotivoDevolucionDevo;
        private System.Windows.Forms.DateTimePicker dtFechaVentaDevo;
        private System.Windows.Forms.Label lVentaDevoluciones;
        private System.Windows.Forms.ComboBox cbVentasDevo;
        private System.Windows.Forms.Label lNombreEmpleadoDevolucion;
        private System.Windows.Forms.ComboBox cbNombreEmpleadosDevo;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalPromo;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioPromo;
        private System.Windows.Forms.ComboBox cbEmpleadoVentas;
        private System.Windows.Forms.ComboBox cbProductoPromocion;
        private System.Windows.Forms.ComboBox cbProductoDetalleVenta;
        private System.Windows.Forms.ComboBox cbIdPromocionDetalleVenta;
        private System.Windows.Forms.ComboBox cbIdVentaDetalleVenta;
        private System.Windows.Forms.Button btEliminarDetalleCompra;
        private System.Windows.Forms.Button bEditaDetalleDev;
        private System.Windows.Forms.Button bEliminaDetalleDev;
        private System.Windows.Forms.Button bInsertaDetalleDev;
        private System.Windows.Forms.Label lCantidadDevo;
        private System.Windows.Forms.TextBox tbCantidadDevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBDescuentos;
    }
}


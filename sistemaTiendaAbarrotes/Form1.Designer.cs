namespace sistemaTiendaAbarrotes
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProveedor = new System.Windows.Forms.TabPage();
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
            this.tabPromocion = new System.Windows.Forms.TabPage();
            this.tabDetalleVenta = new System.Windows.Forms.TabPage();
            this.tabCompra = new System.Windows.Forms.TabPage();
            this.lbFechaCompras = new System.Windows.Forms.Label();
            this.dateCompras = new System.Windows.Forms.DateTimePicker();
            this.btEliminarCompras = new System.Windows.Forms.Button();
            this.btActualizarCompras = new System.Windows.Forms.Button();
            this.btInsertarCompras = new System.Windows.Forms.Button();
            this.dtCompras = new System.Windows.Forms.DataGridView();
            this.lbTotalCompras = new System.Windows.Forms.Label();
            this.tbTotalCompras = new System.Windows.Forms.TextBox();
            this.lbProveedorCompras = new System.Windows.Forms.Label();
            this.cbProveedorCompras = new System.Windows.Forms.ComboBox();
            this.lbEmpleadoCompras = new System.Windows.Forms.Label();
            this.cbEmpleadoCompras = new System.Windows.Forms.ComboBox();
            this.tabDetalleCompra = new System.Windows.Forms.TabPage();
            this.tabDevolucion = new System.Windows.Forms.TabPage();
            this.tabDetalleDevolucion = new System.Windows.Forms.TabPage();
            this.tabEntrega = new System.Windows.Forms.TabPage();
            this.lbCompraDetalleCom = new System.Windows.Forms.Label();
            this.cbCompraDetalleCom = new System.Windows.Forms.ComboBox();
            this.cbProductoDetalleCom = new System.Windows.Forms.ComboBox();
            this.lbProductoDetalleCom = new System.Windows.Forms.Label();
            this.lbSubtotalDetalleCom = new System.Windows.Forms.Label();
            this.lbCantidadDetalleCom = new System.Windows.Forms.Label();
            this.tbSubtotalDetalleCom = new System.Windows.Forms.TextBox();
            this.tbCantidadDetalleCom = new System.Windows.Forms.TextBox();
            this.btActualizarDetalleCom = new System.Windows.Forms.Button();
            this.btInsertarDetalleCom = new System.Windows.Forms.Button();
            this.dtDetalleCom = new System.Windows.Forms.DataGridView();
            this.tabVistas.SuspendLayout();
            this.tabEmpleado.SuspendLayout();
            this.tabProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProducto)).BeginInit();
            this.tabCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).BeginInit();
            this.tabDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalleCom)).BeginInit();
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
            this.tabVistas.Location = new System.Drawing.Point(2, 8);
            this.tabVistas.Margin = new System.Windows.Forms.Padding(2);
            this.tabVistas.Name = "tabVistas";
            this.tabVistas.SelectedIndex = 0;
            this.tabVistas.Size = new System.Drawing.Size(791, 546);
            this.tabVistas.TabIndex = 1;
            // 
            // tabEmpleado
            // 
            this.tabEmpleado.Controls.Add(this.button2);
            this.tabEmpleado.Controls.Add(this.textBox5);
            this.tabEmpleado.Controls.Add(this.label5);
            this.tabEmpleado.Controls.Add(this.button1);
            this.tabEmpleado.Controls.Add(this.textBox4);
            this.tabEmpleado.Controls.Add(this.label4);
            this.tabEmpleado.Controls.Add(this.textBox3);
            this.tabEmpleado.Controls.Add(this.label3);
            this.tabEmpleado.Controls.Add(this.textBox2);
            this.tabEmpleado.Controls.Add(this.label2);
            this.tabEmpleado.Controls.Add(this.textBox1);
            this.tabEmpleado.Controls.Add(this.label1);
            this.tabEmpleado.Location = new System.Drawing.Point(4, 22);
            this.tabEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.Padding = new System.Windows.Forms.Padding(2);
            this.tabEmpleado.Size = new System.Drawing.Size(783, 520);
            this.tabEmpleado.TabIndex = 0;
            this.tabEmpleado.Text = "Empleados";
            this.tabEmpleado.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(29, 180);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(30, 111);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(183, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 53);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 120);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domicilio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabProveedor
            // 
            this.tabProveedor.Location = new System.Drawing.Point(4, 22);
            this.tabProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.tabProveedor.Name = "tabProveedor";
            this.tabProveedor.Padding = new System.Windows.Forms.Padding(2);
            this.tabProveedor.Size = new System.Drawing.Size(783, 520);
            this.tabProveedor.TabIndex = 1;
            this.tabProveedor.Text = "Proveedores";
            this.tabProveedor.UseVisualStyleBackColor = true;
            // 
            // tabProducto
            // 
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
            this.tabProducto.Location = new System.Drawing.Point(4, 22);
            this.tabProducto.Margin = new System.Windows.Forms.Padding(2);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(2);
            this.tabProducto.Size = new System.Drawing.Size(783, 520);
            this.tabProducto.TabIndex = 2;
            this.tabProducto.Text = "Productos";
            this.tabProducto.UseVisualStyleBackColor = true;
            this.tabProducto.Click += new System.EventHandler(this.tabProducto_Click);
            // 
            // btEliminarProducto
            // 
            this.btEliminarProducto.Location = new System.Drawing.Point(672, 48);
            this.btEliminarProducto.Name = "btEliminarProducto";
            this.btEliminarProducto.Size = new System.Drawing.Size(75, 40);
            this.btEliminarProducto.TabIndex = 11;
            this.btEliminarProducto.Text = "Eliminar";
            this.btEliminarProducto.UseVisualStyleBackColor = true;
            this.btEliminarProducto.Click += new System.EventHandler(this.btEliminarProducto_Click);
            // 
            // dtProducto
            // 
            this.dtProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProducto.Location = new System.Drawing.Point(24, 139);
            this.dtProducto.Name = "dtProducto";
            this.dtProducto.Size = new System.Drawing.Size(723, 349);
            this.dtProducto.TabIndex = 10;
            this.dtProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProducto_CellClick);
            // 
            // btActualizarProducto
            // 
            this.btActualizarProducto.Location = new System.Drawing.Point(565, 75);
            this.btActualizarProducto.Name = "btActualizarProducto";
            this.btActualizarProducto.Size = new System.Drawing.Size(75, 40);
            this.btActualizarProducto.TabIndex = 9;
            this.btActualizarProducto.Text = "Actualizar";
            this.btActualizarProducto.UseVisualStyleBackColor = true;
            this.btActualizarProducto.Click += new System.EventHandler(this.btActualizarProducto_Click);
            // 
            // lbCostoVentaProducto
            // 
            this.lbCostoVentaProducto.AutoSize = true;
            this.lbCostoVentaProducto.Location = new System.Drawing.Point(300, 75);
            this.lbCostoVentaProducto.Name = "lbCostoVentaProducto";
            this.lbCostoVentaProducto.Size = new System.Drawing.Size(67, 13);
            this.lbCostoVentaProducto.TabIndex = 8;
            this.lbCostoVentaProducto.Text = "Costo venta:";
            // 
            // tbCostoVentaProducto
            // 
            this.tbCostoVentaProducto.Location = new System.Drawing.Point(373, 72);
            this.tbCostoVentaProducto.Name = "tbCostoVentaProducto";
            this.tbCostoVentaProducto.Size = new System.Drawing.Size(100, 20);
            this.tbCostoVentaProducto.TabIndex = 7;
            // 
            // lbCostoProvProducto
            // 
            this.lbCostoProvProducto.AutoSize = true;
            this.lbCostoProvProducto.Location = new System.Drawing.Point(281, 30);
            this.lbCostoProvProducto.Name = "lbCostoProvProducto";
            this.lbCostoProvProducto.Size = new System.Drawing.Size(88, 13);
            this.lbCostoProvProducto.TabIndex = 6;
            this.lbCostoProvProducto.Text = "Costo proveedor:";
            // 
            // tbCostoProvProducto
            // 
            this.tbCostoProvProducto.Location = new System.Drawing.Point(373, 27);
            this.tbCostoProvProducto.Name = "tbCostoProvProducto";
            this.tbCostoProvProducto.Size = new System.Drawing.Size(100, 20);
            this.tbCostoProvProducto.TabIndex = 5;
            // 
            // lbExistenciasProducto
            // 
            this.lbExistenciasProducto.AutoSize = true;
            this.lbExistenciasProducto.Location = new System.Drawing.Point(37, 75);
            this.lbExistenciasProducto.Name = "lbExistenciasProducto";
            this.lbExistenciasProducto.Size = new System.Drawing.Size(63, 13);
            this.lbExistenciasProducto.TabIndex = 4;
            this.lbExistenciasProducto.Text = "Existencias:";
            // 
            // tbExistenciasProducto
            // 
            this.tbExistenciasProducto.Location = new System.Drawing.Point(108, 72);
            this.tbExistenciasProducto.Name = "tbExistenciasProducto";
            this.tbExistenciasProducto.Size = new System.Drawing.Size(100, 20);
            this.tbExistenciasProducto.TabIndex = 3;
            // 
            // lbNombreProducto
            // 
            this.lbNombreProducto.AutoSize = true;
            this.lbNombreProducto.Location = new System.Drawing.Point(53, 33);
            this.lbNombreProducto.Name = "lbNombreProducto";
            this.lbNombreProducto.Size = new System.Drawing.Size(47, 13);
            this.lbNombreProducto.TabIndex = 2;
            this.lbNombreProducto.Text = "Nombre:";
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.Location = new System.Drawing.Point(108, 30);
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.tbNombreProducto.TabIndex = 1;
            // 
            // btInsertarProducto
            // 
            this.btInsertarProducto.Location = new System.Drawing.Point(565, 19);
            this.btInsertarProducto.Name = "btInsertarProducto";
            this.btInsertarProducto.Size = new System.Drawing.Size(75, 40);
            this.btInsertarProducto.TabIndex = 0;
            this.btInsertarProducto.Text = "Insertar";
            this.btInsertarProducto.UseVisualStyleBackColor = true;
            this.btInsertarProducto.Click += new System.EventHandler(this.btInsertarProducto_Click);
            // 
            // tabVenta
            // 
            this.tabVenta.Location = new System.Drawing.Point(4, 22);
            this.tabVenta.Margin = new System.Windows.Forms.Padding(2);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(2);
            this.tabVenta.Size = new System.Drawing.Size(783, 520);
            this.tabVenta.TabIndex = 3;
            this.tabVenta.Text = "Ventas";
            this.tabVenta.UseVisualStyleBackColor = true;
            // 
            // tabPromocion
            // 
            this.tabPromocion.Location = new System.Drawing.Point(4, 22);
            this.tabPromocion.Margin = new System.Windows.Forms.Padding(2);
            this.tabPromocion.Name = "tabPromocion";
            this.tabPromocion.Padding = new System.Windows.Forms.Padding(2);
            this.tabPromocion.Size = new System.Drawing.Size(783, 520);
            this.tabPromocion.TabIndex = 4;
            this.tabPromocion.Text = "Promociones";
            this.tabPromocion.UseVisualStyleBackColor = true;
            // 
            // tabDetalleVenta
            // 
            this.tabDetalleVenta.Location = new System.Drawing.Point(4, 22);
            this.tabDetalleVenta.Margin = new System.Windows.Forms.Padding(2);
            this.tabDetalleVenta.Name = "tabDetalleVenta";
            this.tabDetalleVenta.Padding = new System.Windows.Forms.Padding(2);
            this.tabDetalleVenta.Size = new System.Drawing.Size(783, 520);
            this.tabDetalleVenta.TabIndex = 5;
            this.tabDetalleVenta.Text = "Detalle Ventas";
            this.tabDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // tabCompra
            // 
            this.tabCompra.Controls.Add(this.lbFechaCompras);
            this.tabCompra.Controls.Add(this.dateCompras);
            this.tabCompra.Controls.Add(this.btEliminarCompras);
            this.tabCompra.Controls.Add(this.btActualizarCompras);
            this.tabCompra.Controls.Add(this.btInsertarCompras);
            this.tabCompra.Controls.Add(this.dtCompras);
            this.tabCompra.Controls.Add(this.lbTotalCompras);
            this.tabCompra.Controls.Add(this.tbTotalCompras);
            this.tabCompra.Controls.Add(this.lbProveedorCompras);
            this.tabCompra.Controls.Add(this.cbProveedorCompras);
            this.tabCompra.Controls.Add(this.lbEmpleadoCompras);
            this.tabCompra.Controls.Add(this.cbEmpleadoCompras);
            this.tabCompra.Location = new System.Drawing.Point(4, 22);
            this.tabCompra.Margin = new System.Windows.Forms.Padding(2);
            this.tabCompra.Name = "tabCompra";
            this.tabCompra.Padding = new System.Windows.Forms.Padding(2);
            this.tabCompra.Size = new System.Drawing.Size(783, 520);
            this.tabCompra.TabIndex = 6;
            this.tabCompra.Text = "Compras";
            this.tabCompra.UseVisualStyleBackColor = true;
            // 
            // lbFechaCompras
            // 
            this.lbFechaCompras.AutoSize = true;
            this.lbFechaCompras.Location = new System.Drawing.Point(78, 79);
            this.lbFechaCompras.Name = "lbFechaCompras";
            this.lbFechaCompras.Size = new System.Drawing.Size(40, 13);
            this.lbFechaCompras.TabIndex = 14;
            this.lbFechaCompras.Text = "Fecha:";
            // 
            // dateCompras
            // 
            this.dateCompras.Location = new System.Drawing.Point(126, 76);
            this.dateCompras.Name = "dateCompras";
            this.dateCompras.Size = new System.Drawing.Size(200, 20);
            this.dateCompras.TabIndex = 13;
            // 
            // btEliminarCompras
            // 
            this.btEliminarCompras.Location = new System.Drawing.Point(691, 44);
            this.btEliminarCompras.Name = "btEliminarCompras";
            this.btEliminarCompras.Size = new System.Drawing.Size(75, 40);
            this.btEliminarCompras.TabIndex = 12;
            this.btEliminarCompras.Text = "Eliminar";
            this.btEliminarCompras.UseVisualStyleBackColor = true;
            this.btEliminarCompras.Click += new System.EventHandler(this.btEliminarCompras_Click);
            // 
            // btActualizarCompras
            // 
            this.btActualizarCompras.Location = new System.Drawing.Point(587, 75);
            this.btActualizarCompras.Name = "btActualizarCompras";
            this.btActualizarCompras.Size = new System.Drawing.Size(75, 40);
            this.btActualizarCompras.TabIndex = 11;
            this.btActualizarCompras.Text = "Actualizar";
            this.btActualizarCompras.UseVisualStyleBackColor = true;
            this.btActualizarCompras.Click += new System.EventHandler(this.btActualizarCompras_Click);
            // 
            // btInsertarCompras
            // 
            this.btInsertarCompras.Location = new System.Drawing.Point(586, 19);
            this.btInsertarCompras.Name = "btInsertarCompras";
            this.btInsertarCompras.Size = new System.Drawing.Size(75, 40);
            this.btInsertarCompras.TabIndex = 10;
            this.btInsertarCompras.Text = "Insertar";
            this.btInsertarCompras.UseVisualStyleBackColor = true;
            this.btInsertarCompras.Click += new System.EventHandler(this.btInsertarCompras_Click);
            // 
            // dtCompras
            // 
            this.dtCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCompras.Location = new System.Drawing.Point(38, 139);
            this.dtCompras.Name = "dtCompras";
            this.dtCompras.Size = new System.Drawing.Size(704, 339);
            this.dtCompras.TabIndex = 6;
            this.dtCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCompras_CellClick);
            // 
            // lbTotalCompras
            // 
            this.lbTotalCompras.AutoSize = true;
            this.lbTotalCompras.Location = new System.Drawing.Point(383, 82);
            this.lbTotalCompras.Name = "lbTotalCompras";
            this.lbTotalCompras.Size = new System.Drawing.Size(34, 13);
            this.lbTotalCompras.TabIndex = 5;
            this.lbTotalCompras.Text = "Total:";
            // 
            // tbTotalCompras
            // 
            this.tbTotalCompras.Location = new System.Drawing.Point(423, 79);
            this.tbTotalCompras.Name = "tbTotalCompras";
            this.tbTotalCompras.Size = new System.Drawing.Size(100, 20);
            this.tbTotalCompras.TabIndex = 4;
            // 
            // lbProveedorCompras
            // 
            this.lbProveedorCompras.AutoSize = true;
            this.lbProveedorCompras.Location = new System.Drawing.Point(358, 30);
            this.lbProveedorCompras.Name = "lbProveedorCompras";
            this.lbProveedorCompras.Size = new System.Drawing.Size(59, 13);
            this.lbProveedorCompras.TabIndex = 3;
            this.lbProveedorCompras.Text = "Proveedor:";
            // 
            // cbProveedorCompras
            // 
            this.cbProveedorCompras.FormattingEnabled = true;
            this.cbProveedorCompras.Location = new System.Drawing.Point(423, 30);
            this.cbProveedorCompras.Name = "cbProveedorCompras";
            this.cbProveedorCompras.Size = new System.Drawing.Size(121, 21);
            this.cbProveedorCompras.TabIndex = 2;
            // 
            // lbEmpleadoCompras
            // 
            this.lbEmpleadoCompras.AutoSize = true;
            this.lbEmpleadoCompras.Location = new System.Drawing.Point(61, 30);
            this.lbEmpleadoCompras.Name = "lbEmpleadoCompras";
            this.lbEmpleadoCompras.Size = new System.Drawing.Size(57, 13);
            this.lbEmpleadoCompras.TabIndex = 1;
            this.lbEmpleadoCompras.Text = "Empleado:";
            // 
            // cbEmpleadoCompras
            // 
            this.cbEmpleadoCompras.FormattingEnabled = true;
            this.cbEmpleadoCompras.Location = new System.Drawing.Point(126, 30);
            this.cbEmpleadoCompras.Name = "cbEmpleadoCompras";
            this.cbEmpleadoCompras.Size = new System.Drawing.Size(121, 21);
            this.cbEmpleadoCompras.TabIndex = 0;
            // 
            // tabDetalleCompra
            // 
            this.tabDetalleCompra.Controls.Add(this.dtDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.btActualizarDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.btInsertarDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.tbCantidadDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.tbSubtotalDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.lbCantidadDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.lbSubtotalDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.cbProductoDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.lbProductoDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.cbCompraDetalleCom);
            this.tabDetalleCompra.Controls.Add(this.lbCompraDetalleCom);
            this.tabDetalleCompra.Location = new System.Drawing.Point(4, 22);
            this.tabDetalleCompra.Margin = new System.Windows.Forms.Padding(2);
            this.tabDetalleCompra.Name = "tabDetalleCompra";
            this.tabDetalleCompra.Padding = new System.Windows.Forms.Padding(2);
            this.tabDetalleCompra.Size = new System.Drawing.Size(783, 520);
            this.tabDetalleCompra.TabIndex = 7;
            this.tabDetalleCompra.Text = "Detalle Compras";
            this.tabDetalleCompra.UseVisualStyleBackColor = true;
            // 
            // tabDevolucion
            // 
            this.tabDevolucion.Location = new System.Drawing.Point(4, 22);
            this.tabDevolucion.Margin = new System.Windows.Forms.Padding(2);
            this.tabDevolucion.Name = "tabDevolucion";
            this.tabDevolucion.Padding = new System.Windows.Forms.Padding(2);
            this.tabDevolucion.Size = new System.Drawing.Size(783, 520);
            this.tabDevolucion.TabIndex = 8;
            this.tabDevolucion.Text = "Devoluciones";
            this.tabDevolucion.UseVisualStyleBackColor = true;
            // 
            // tabDetalleDevolucion
            // 
            this.tabDetalleDevolucion.Location = new System.Drawing.Point(4, 22);
            this.tabDetalleDevolucion.Margin = new System.Windows.Forms.Padding(2);
            this.tabDetalleDevolucion.Name = "tabDetalleDevolucion";
            this.tabDetalleDevolucion.Padding = new System.Windows.Forms.Padding(2);
            this.tabDetalleDevolucion.Size = new System.Drawing.Size(783, 520);
            this.tabDetalleDevolucion.TabIndex = 9;
            this.tabDetalleDevolucion.Text = "Detalle Devoluciones";
            this.tabDetalleDevolucion.UseVisualStyleBackColor = true;
            // 
            // tabEntrega
            // 
            this.tabEntrega.Location = new System.Drawing.Point(4, 22);
            this.tabEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.tabEntrega.Name = "tabEntrega";
            this.tabEntrega.Padding = new System.Windows.Forms.Padding(2);
            this.tabEntrega.Size = new System.Drawing.Size(783, 520);
            this.tabEntrega.TabIndex = 10;
            this.tabEntrega.Text = "Entregas";
            this.tabEntrega.UseVisualStyleBackColor = true;
            // 
            // lbCompraDetalleCom
            // 
            this.lbCompraDetalleCom.AutoSize = true;
            this.lbCompraDetalleCom.Location = new System.Drawing.Point(56, 29);
            this.lbCompraDetalleCom.Name = "lbCompraDetalleCom";
            this.lbCompraDetalleCom.Size = new System.Drawing.Size(46, 13);
            this.lbCompraDetalleCom.TabIndex = 0;
            this.lbCompraDetalleCom.Text = "Compra:";
            // 
            // cbCompraDetalleCom
            // 
            this.cbCompraDetalleCom.FormattingEnabled = true;
            this.cbCompraDetalleCom.Location = new System.Drawing.Point(110, 26);
            this.cbCompraDetalleCom.Name = "cbCompraDetalleCom";
            this.cbCompraDetalleCom.Size = new System.Drawing.Size(121, 21);
            this.cbCompraDetalleCom.TabIndex = 1;
            // 
            // cbProductoDetalleCom
            // 
            this.cbProductoDetalleCom.FormattingEnabled = true;
            this.cbProductoDetalleCom.Location = new System.Drawing.Point(374, 26);
            this.cbProductoDetalleCom.Name = "cbProductoDetalleCom";
            this.cbProductoDetalleCom.Size = new System.Drawing.Size(121, 21);
            this.cbProductoDetalleCom.TabIndex = 3;
            // 
            // lbProductoDetalleCom
            // 
            this.lbProductoDetalleCom.AutoSize = true;
            this.lbProductoDetalleCom.Location = new System.Drawing.Point(320, 29);
            this.lbProductoDetalleCom.Name = "lbProductoDetalleCom";
            this.lbProductoDetalleCom.Size = new System.Drawing.Size(53, 13);
            this.lbProductoDetalleCom.TabIndex = 2;
            this.lbProductoDetalleCom.Text = "Producto:";
            // 
            // lbSubtotalDetalleCom
            // 
            this.lbSubtotalDetalleCom.AutoSize = true;
            this.lbSubtotalDetalleCom.Location = new System.Drawing.Point(320, 88);
            this.lbSubtotalDetalleCom.Name = "lbSubtotalDetalleCom";
            this.lbSubtotalDetalleCom.Size = new System.Drawing.Size(49, 13);
            this.lbSubtotalDetalleCom.TabIndex = 4;
            this.lbSubtotalDetalleCom.Text = "Subtotal:";
            // 
            // lbCantidadDetalleCom
            // 
            this.lbCantidadDetalleCom.AutoSize = true;
            this.lbCantidadDetalleCom.Location = new System.Drawing.Point(56, 84);
            this.lbCantidadDetalleCom.Name = "lbCantidadDetalleCom";
            this.lbCantidadDetalleCom.Size = new System.Drawing.Size(52, 13);
            this.lbCantidadDetalleCom.TabIndex = 5;
            this.lbCantidadDetalleCom.Text = "Cantidad:";
            // 
            // tbSubtotalDetalleCom
            // 
            this.tbSubtotalDetalleCom.Location = new System.Drawing.Point(374, 81);
            this.tbSubtotalDetalleCom.Name = "tbSubtotalDetalleCom";
            this.tbSubtotalDetalleCom.Size = new System.Drawing.Size(100, 20);
            this.tbSubtotalDetalleCom.TabIndex = 6;
            // 
            // tbCantidadDetalleCom
            // 
            this.tbCantidadDetalleCom.Location = new System.Drawing.Point(110, 81);
            this.tbCantidadDetalleCom.Name = "tbCantidadDetalleCom";
            this.tbCantidadDetalleCom.Size = new System.Drawing.Size(100, 20);
            this.tbCantidadDetalleCom.TabIndex = 7;
            // 
            // btActualizarDetalleCom
            // 
            this.btActualizarDetalleCom.Location = new System.Drawing.Point(550, 71);
            this.btActualizarDetalleCom.Name = "btActualizarDetalleCom";
            this.btActualizarDetalleCom.Size = new System.Drawing.Size(75, 40);
            this.btActualizarDetalleCom.TabIndex = 14;
            this.btActualizarDetalleCom.Text = "Actualizar";
            this.btActualizarDetalleCom.UseVisualStyleBackColor = true;
            this.btActualizarDetalleCom.Click += new System.EventHandler(this.btActualizarDetalleCom_Click);
            // 
            // btInsertarDetalleCom
            // 
            this.btInsertarDetalleCom.Location = new System.Drawing.Point(549, 15);
            this.btInsertarDetalleCom.Name = "btInsertarDetalleCom";
            this.btInsertarDetalleCom.Size = new System.Drawing.Size(75, 40);
            this.btInsertarDetalleCom.TabIndex = 13;
            this.btInsertarDetalleCom.Text = "Insertar";
            this.btInsertarDetalleCom.UseVisualStyleBackColor = true;
            this.btInsertarDetalleCom.Click += new System.EventHandler(this.btInsertarDetalleCom_Click);
            // 
            // dtDetalleCom
            // 
            this.dtDetalleCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetalleCom.Location = new System.Drawing.Point(18, 136);
            this.dtDetalleCom.Name = "dtDetalleCom";
            this.dtDetalleCom.Size = new System.Drawing.Size(731, 358);
            this.dtDetalleCom.TabIndex = 16;
            this.dtDetalleCom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDetalleCom_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 608);
            this.Controls.Add(this.tabVistas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Abarrotes";
            this.tabVistas.ResumeLayout(false);
            this.tabEmpleado.ResumeLayout(false);
            this.tabEmpleado.PerformLayout();
            this.tabProducto.ResumeLayout(false);
            this.tabProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProducto)).EndInit();
            this.tabCompra.ResumeLayout(false);
            this.tabCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).EndInit();
            this.tabDetalleCompra.ResumeLayout(false);
            this.tabDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalleCom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabVistas;
        private System.Windows.Forms.TabPage tabEmpleado;
        private System.Windows.Forms.TabPage tabProveedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabProducto;
        private System.Windows.Forms.TabPage tabVenta;
        private System.Windows.Forms.TabPage tabPromocion;
        private System.Windows.Forms.TabPage tabDetalleVenta;
        private System.Windows.Forms.TabPage tabCompra;
        private System.Windows.Forms.TabPage tabDetalleCompra;
        private System.Windows.Forms.TabPage tabDevolucion;
        private System.Windows.Forms.TabPage tabDetalleDevolucion;
        private System.Windows.Forms.TabPage tabEntrega;
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
        private System.Windows.Forms.Label lbTotalCompras;
        private System.Windows.Forms.TextBox tbTotalCompras;
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
        private System.Windows.Forms.TextBox tbSubtotalDetalleCom;
        private System.Windows.Forms.Label lbCantidadDetalleCom;
        private System.Windows.Forms.Label lbSubtotalDetalleCom;
        private System.Windows.Forms.ComboBox cbProductoDetalleCom;
        private System.Windows.Forms.Label lbProductoDetalleCom;
        private System.Windows.Forms.ComboBox cbCompraDetalleCom;
        private System.Windows.Forms.Label lbCompraDetalleCom;
        private System.Windows.Forms.DataGridView dtDetalleCom;
    }
}


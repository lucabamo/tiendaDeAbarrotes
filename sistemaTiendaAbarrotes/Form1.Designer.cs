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
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.tabPromocion = new System.Windows.Forms.TabPage();
            this.tabDetalleVenta = new System.Windows.Forms.TabPage();
            this.tabCompra = new System.Windows.Forms.TabPage();
            this.tabDetalleCompra = new System.Windows.Forms.TabPage();
            this.tabDevolucion = new System.Windows.Forms.TabPage();
            this.tabDetalleDevolucion = new System.Windows.Forms.TabPage();
            this.tabEntrega = new System.Windows.Forms.TabPage();
            this.tbIdEmpleado = new System.Windows.Forms.TextBox();
            this.tbFechaVenta = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btAgregarVenta = new System.Windows.Forms.Button();
            this.btModificarVenta = new System.Windows.Forms.Button();
            this.btEliminarVenta = new System.Windows.Forms.Button();
            this.dgVentas = new System.Windows.Forms.DataGridView();
            this.dgPromocion = new System.Windows.Forms.DataGridView();
            this.btEliminarPromocion = new System.Windows.Forms.Button();
            this.btModificarPromocion = new System.Windows.Forms.Button();
            this.btAgregarPromocion = new System.Windows.Forms.Button();
            this.tbDescuento = new System.Windows.Forms.TextBox();
            this.tbFechaInicio = new System.Windows.Forms.TextBox();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.tbFechaFinal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.dgDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btEliminarDetalleVenta = new System.Windows.Forms.Button();
            this.btModificarDetalleVenta = new System.Windows.Forms.Button();
            this.btAgregarDetalleVenta = new System.Windows.Forms.Button();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbIdProducto2 = new System.Windows.Forms.TextBox();
            this.tbIdPromocion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbIdVenta2 = new System.Windows.Forms.TextBox();
            this.tabVistas.SuspendLayout();
            this.tabEmpleado.SuspendLayout();
            this.tabVenta.SuspendLayout();
            this.tabPromocion.SuspendLayout();
            this.tabDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPromocion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).BeginInit();
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
            this.tabVistas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tabEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEmpleado.Size = new System.Drawing.Size(783, 520);
            this.tabEmpleado.TabIndex = 0;
            this.tabEmpleado.Text = "Empleados";
            this.tabEmpleado.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(29, 180);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(30, 111);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tabProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProveedor.Name = "tabProveedor";
            this.tabProveedor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProveedor.Size = new System.Drawing.Size(783, 520);
            this.tabProveedor.TabIndex = 1;
            this.tabProveedor.Text = "Proveedores";
            this.tabProveedor.UseVisualStyleBackColor = true;
            // 
            // tabProducto
            // 
            this.tabProducto.Location = new System.Drawing.Point(4, 22);
            this.tabProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProducto.Size = new System.Drawing.Size(783, 520);
            this.tabProducto.TabIndex = 2;
            this.tabProducto.Text = "Productos";
            this.tabProducto.UseVisualStyleBackColor = true;
            // 
            // tabVenta
            // 
            this.tabVenta.Controls.Add(this.dgVentas);
            this.tabVenta.Controls.Add(this.btEliminarVenta);
            this.tabVenta.Controls.Add(this.btModificarVenta);
            this.tabVenta.Controls.Add(this.btAgregarVenta);
            this.tabVenta.Controls.Add(this.label8);
            this.tabVenta.Controls.Add(this.label7);
            this.tabVenta.Controls.Add(this.label6);
            this.tabVenta.Controls.Add(this.tbTotal);
            this.tabVenta.Controls.Add(this.tbFechaVenta);
            this.tabVenta.Controls.Add(this.tbIdEmpleado);
            this.tabVenta.Location = new System.Drawing.Point(4, 22);
            this.tabVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabVenta.Size = new System.Drawing.Size(783, 520);
            this.tabVenta.TabIndex = 3;
            this.tabVenta.Text = "Ventas";
            this.tabVenta.UseVisualStyleBackColor = true;
            this.tabVenta.Enter += new System.EventHandler(this.tabVenta_Enter);
            // 
            // tabPromocion
            // 
            this.tabPromocion.Controls.Add(this.label12);
            this.tabPromocion.Controls.Add(this.label9);
            this.tabPromocion.Controls.Add(this.label10);
            this.tabPromocion.Controls.Add(this.label11);
            this.tabPromocion.Controls.Add(this.tbFechaFinal);
            this.tabPromocion.Controls.Add(this.dgPromocion);
            this.tabPromocion.Controls.Add(this.btEliminarPromocion);
            this.tabPromocion.Controls.Add(this.btModificarPromocion);
            this.tabPromocion.Controls.Add(this.btAgregarPromocion);
            this.tabPromocion.Controls.Add(this.tbDescuento);
            this.tabPromocion.Controls.Add(this.tbFechaInicio);
            this.tabPromocion.Controls.Add(this.tbIdProducto);
            this.tabPromocion.Location = new System.Drawing.Point(4, 22);
            this.tabPromocion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPromocion.Name = "tabPromocion";
            this.tabPromocion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPromocion.Size = new System.Drawing.Size(783, 520);
            this.tabPromocion.TabIndex = 4;
            this.tabPromocion.Text = "Promociones";
            this.tabPromocion.UseVisualStyleBackColor = true;
            this.tabPromocion.Enter += new System.EventHandler(this.tabPromocion_Enter);
            // 
            // tabDetalleVenta
            // 
            this.tabDetalleVenta.Controls.Add(this.label17);
            this.tabDetalleVenta.Controls.Add(this.tbIdVenta2);
            this.tabDetalleVenta.Controls.Add(this.label13);
            this.tabDetalleVenta.Controls.Add(this.label14);
            this.tabDetalleVenta.Controls.Add(this.label15);
            this.tabDetalleVenta.Controls.Add(this.label16);
            this.tabDetalleVenta.Controls.Add(this.tbCantidad);
            this.tabDetalleVenta.Controls.Add(this.dgDetalleVenta);
            this.tabDetalleVenta.Controls.Add(this.btEliminarDetalleVenta);
            this.tabDetalleVenta.Controls.Add(this.btModificarDetalleVenta);
            this.tabDetalleVenta.Controls.Add(this.btAgregarDetalleVenta);
            this.tabDetalleVenta.Controls.Add(this.tbSubtotal);
            this.tabDetalleVenta.Controls.Add(this.tbIdProducto2);
            this.tabDetalleVenta.Controls.Add(this.tbIdPromocion);
            this.tabDetalleVenta.Location = new System.Drawing.Point(4, 22);
            this.tabDetalleVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDetalleVenta.Name = "tabDetalleVenta";
            this.tabDetalleVenta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDetalleVenta.Size = new System.Drawing.Size(783, 520);
            this.tabDetalleVenta.TabIndex = 5;
            this.tabDetalleVenta.Text = "Detalle Ventas";
            this.tabDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // tabCompra
            // 
            this.tabCompra.Location = new System.Drawing.Point(4, 22);
            this.tabCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCompra.Name = "tabCompra";
            this.tabCompra.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCompra.Size = new System.Drawing.Size(783, 520);
            this.tabCompra.TabIndex = 6;
            this.tabCompra.Text = "Compras";
            this.tabCompra.UseVisualStyleBackColor = true;
            // 
            // tabDetalleCompra
            // 
            this.tabDetalleCompra.Location = new System.Drawing.Point(4, 22);
            this.tabDetalleCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDetalleCompra.Name = "tabDetalleCompra";
            this.tabDetalleCompra.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDetalleCompra.Size = new System.Drawing.Size(783, 520);
            this.tabDetalleCompra.TabIndex = 7;
            this.tabDetalleCompra.Text = "Detalle Compras";
            this.tabDetalleCompra.UseVisualStyleBackColor = true;
            // 
            // tabDevolucion
            // 
            this.tabDevolucion.Location = new System.Drawing.Point(4, 22);
            this.tabDevolucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDevolucion.Name = "tabDevolucion";
            this.tabDevolucion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDevolucion.Size = new System.Drawing.Size(783, 520);
            this.tabDevolucion.TabIndex = 8;
            this.tabDevolucion.Text = "Devoluciones";
            this.tabDevolucion.UseVisualStyleBackColor = true;
            // 
            // tabDetalleDevolucion
            // 
            this.tabDetalleDevolucion.Location = new System.Drawing.Point(4, 22);
            this.tabDetalleDevolucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDetalleDevolucion.Name = "tabDetalleDevolucion";
            this.tabDetalleDevolucion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDetalleDevolucion.Size = new System.Drawing.Size(783, 520);
            this.tabDetalleDevolucion.TabIndex = 9;
            this.tabDetalleDevolucion.Text = "Detalle Devoluciones";
            this.tabDetalleDevolucion.UseVisualStyleBackColor = true;
            // 
            // tabEntrega
            // 
            this.tabEntrega.Location = new System.Drawing.Point(4, 22);
            this.tabEntrega.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEntrega.Name = "tabEntrega";
            this.tabEntrega.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEntrega.Size = new System.Drawing.Size(783, 520);
            this.tabEntrega.TabIndex = 10;
            this.tabEntrega.Text = "Entregas";
            this.tabEntrega.UseVisualStyleBackColor = true;
            // 
            // tbIdEmpleado
            // 
            this.tbIdEmpleado.Location = new System.Drawing.Point(6, 30);
            this.tbIdEmpleado.Name = "tbIdEmpleado";
            this.tbIdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.tbIdEmpleado.TabIndex = 0;
            // 
            // tbFechaVenta
            // 
            this.tbFechaVenta.Location = new System.Drawing.Point(5, 78);
            this.tbFechaVenta.Name = "tbFechaVenta";
            this.tbFechaVenta.Size = new System.Drawing.Size(100, 20);
            this.tbFechaVenta.TabIndex = 1;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(6, 120);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "IdEmpleado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha Venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total";
            // 
            // btAgregarVenta
            // 
            this.btAgregarVenta.Location = new System.Drawing.Point(9, 158);
            this.btAgregarVenta.Name = "btAgregarVenta";
            this.btAgregarVenta.Size = new System.Drawing.Size(75, 23);
            this.btAgregarVenta.TabIndex = 6;
            this.btAgregarVenta.Text = "Agregar";
            this.btAgregarVenta.UseVisualStyleBackColor = true;
            this.btAgregarVenta.Click += new System.EventHandler(this.btAgregarVenta_Click);
            // 
            // btModificarVenta
            // 
            this.btModificarVenta.Location = new System.Drawing.Point(114, 158);
            this.btModificarVenta.Name = "btModificarVenta";
            this.btModificarVenta.Size = new System.Drawing.Size(75, 23);
            this.btModificarVenta.TabIndex = 7;
            this.btModificarVenta.Text = "Modificar";
            this.btModificarVenta.UseVisualStyleBackColor = true;
            this.btModificarVenta.Click += new System.EventHandler(this.btModificarVenta_Click);
            // 
            // btEliminarVenta
            // 
            this.btEliminarVenta.Location = new System.Drawing.Point(229, 158);
            this.btEliminarVenta.Name = "btEliminarVenta";
            this.btEliminarVenta.Size = new System.Drawing.Size(75, 23);
            this.btEliminarVenta.TabIndex = 8;
            this.btEliminarVenta.Text = "Eliminar";
            this.btEliminarVenta.UseVisualStyleBackColor = true;
            this.btEliminarVenta.Click += new System.EventHandler(this.btEliminarVenta_Click);
            // 
            // dgVentas
            // 
            this.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentas.Location = new System.Drawing.Point(9, 205);
            this.dgVentas.Name = "dgVentas";
            this.dgVentas.Size = new System.Drawing.Size(769, 310);
            this.dgVentas.TabIndex = 9;
            this.dgVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVentas_CellClick);
            // 
            // dgPromocion
            // 
            this.dgPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPromocion.Location = new System.Drawing.Point(9, 193);
            this.dgPromocion.Name = "dgPromocion";
            this.dgPromocion.Size = new System.Drawing.Size(769, 310);
            this.dgPromocion.TabIndex = 16;
            this.dgPromocion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPromocion_CellClick);
            // 
            // btEliminarPromocion
            // 
            this.btEliminarPromocion.Location = new System.Drawing.Point(229, 146);
            this.btEliminarPromocion.Name = "btEliminarPromocion";
            this.btEliminarPromocion.Size = new System.Drawing.Size(75, 23);
            this.btEliminarPromocion.TabIndex = 15;
            this.btEliminarPromocion.Text = "Eliminar";
            this.btEliminarPromocion.UseVisualStyleBackColor = true;
            this.btEliminarPromocion.Click += new System.EventHandler(this.btEliminarPromocion_Click);
            // 
            // btModificarPromocion
            // 
            this.btModificarPromocion.Location = new System.Drawing.Point(114, 146);
            this.btModificarPromocion.Name = "btModificarPromocion";
            this.btModificarPromocion.Size = new System.Drawing.Size(75, 23);
            this.btModificarPromocion.TabIndex = 14;
            this.btModificarPromocion.Text = "Modificar";
            this.btModificarPromocion.UseVisualStyleBackColor = true;
            this.btModificarPromocion.Click += new System.EventHandler(this.btModificarPromocion_Click);
            // 
            // btAgregarPromocion
            // 
            this.btAgregarPromocion.Location = new System.Drawing.Point(9, 146);
            this.btAgregarPromocion.Name = "btAgregarPromocion";
            this.btAgregarPromocion.Size = new System.Drawing.Size(75, 23);
            this.btAgregarPromocion.TabIndex = 13;
            this.btAgregarPromocion.Text = "Agregar";
            this.btAgregarPromocion.UseVisualStyleBackColor = true;
            this.btAgregarPromocion.Click += new System.EventHandler(this.btAgregarPromocion_Click);
            // 
            // tbDescuento
            // 
            this.tbDescuento.Location = new System.Drawing.Point(145, 85);
            this.tbDescuento.Name = "tbDescuento";
            this.tbDescuento.Size = new System.Drawing.Size(100, 20);
            this.tbDescuento.TabIndex = 12;
            // 
            // tbFechaInicio
            // 
            this.tbFechaInicio.Location = new System.Drawing.Point(5, 85);
            this.tbFechaInicio.Name = "tbFechaInicio";
            this.tbFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.tbFechaInicio.TabIndex = 11;
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.Location = new System.Drawing.Point(6, 34);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(100, 20);
            this.tbIdProducto.TabIndex = 10;
            // 
            // tbFechaFinal
            // 
            this.tbFechaFinal.Location = new System.Drawing.Point(145, 34);
            this.tbFechaFinal.Name = "tbFechaFinal";
            this.tbFechaFinal.Size = new System.Drawing.Size(100, 20);
            this.tbFechaFinal.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Descuento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha Inicio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "IdProducto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Fecha Final";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(140, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Cantidad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(140, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Subtotal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "IdPromocion";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "IdProducto";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(143, 28);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 29;
            // 
            // dgDetalleVenta
            // 
            this.dgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleVenta.Location = new System.Drawing.Point(9, 193);
            this.dgDetalleVenta.Name = "dgDetalleVenta";
            this.dgDetalleVenta.Size = new System.Drawing.Size(769, 310);
            this.dgDetalleVenta.TabIndex = 28;
            // 
            // btEliminarDetalleVenta
            // 
            this.btEliminarDetalleVenta.Location = new System.Drawing.Point(229, 164);
            this.btEliminarDetalleVenta.Name = "btEliminarDetalleVenta";
            this.btEliminarDetalleVenta.Size = new System.Drawing.Size(75, 23);
            this.btEliminarDetalleVenta.TabIndex = 27;
            this.btEliminarDetalleVenta.Text = "Eliminar";
            this.btEliminarDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // btModificarDetalleVenta
            // 
            this.btModificarDetalleVenta.Location = new System.Drawing.Point(114, 164);
            this.btModificarDetalleVenta.Name = "btModificarDetalleVenta";
            this.btModificarDetalleVenta.Size = new System.Drawing.Size(75, 23);
            this.btModificarDetalleVenta.TabIndex = 26;
            this.btModificarDetalleVenta.Text = "Modificar";
            this.btModificarDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // btAgregarDetalleVenta
            // 
            this.btAgregarDetalleVenta.Location = new System.Drawing.Point(9, 164);
            this.btAgregarDetalleVenta.Name = "btAgregarDetalleVenta";
            this.btAgregarDetalleVenta.Size = new System.Drawing.Size(75, 23);
            this.btAgregarDetalleVenta.TabIndex = 25;
            this.btAgregarDetalleVenta.Text = "Agregar";
            this.btAgregarDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Location = new System.Drawing.Point(143, 79);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(100, 20);
            this.tbSubtotal.TabIndex = 24;
            // 
            // tbIdProducto2
            // 
            this.tbIdProducto2.Location = new System.Drawing.Point(8, 124);
            this.tbIdProducto2.Name = "tbIdProducto2";
            this.tbIdProducto2.Size = new System.Drawing.Size(100, 20);
            this.tbIdProducto2.TabIndex = 23;
            // 
            // tbIdPromocion
            // 
            this.tbIdPromocion.Location = new System.Drawing.Point(9, 73);
            this.tbIdPromocion.Name = "tbIdPromocion";
            this.tbIdPromocion.Size = new System.Drawing.Size(100, 20);
            this.tbIdPromocion.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "IdVenta";
            // 
            // tbIdVenta2
            // 
            this.tbIdVenta2.Location = new System.Drawing.Point(9, 28);
            this.tbIdVenta2.Name = "tbIdVenta2";
            this.tbIdVenta2.Size = new System.Drawing.Size(100, 20);
            this.tbIdVenta2.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 608);
            this.Controls.Add(this.tabVistas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Abarrotes";
            this.tabVistas.ResumeLayout(false);
            this.tabEmpleado.ResumeLayout(false);
            this.tabEmpleado.PerformLayout();
            this.tabVenta.ResumeLayout(false);
            this.tabVenta.PerformLayout();
            this.tabPromocion.ResumeLayout(false);
            this.tabPromocion.PerformLayout();
            this.tabDetalleVenta.ResumeLayout(false);
            this.tabDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPromocion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).EndInit();
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
        private System.Windows.Forms.DataGridView dgVentas;
        private System.Windows.Forms.Button btEliminarVenta;
        private System.Windows.Forms.Button btModificarVenta;
        private System.Windows.Forms.Button btAgregarVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbFechaVenta;
        private System.Windows.Forms.TextBox tbIdEmpleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbFechaFinal;
        private System.Windows.Forms.DataGridView dgPromocion;
        private System.Windows.Forms.Button btEliminarPromocion;
        private System.Windows.Forms.Button btModificarPromocion;
        private System.Windows.Forms.Button btAgregarPromocion;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.TextBox tbFechaInicio;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbIdVenta2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.DataGridView dgDetalleVenta;
        private System.Windows.Forms.Button btEliminarDetalleVenta;
        private System.Windows.Forms.Button btModificarDetalleVenta;
        private System.Windows.Forms.Button btAgregarDetalleVenta;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbIdProducto2;
        private System.Windows.Forms.TextBox tbIdPromocion;
    }
}


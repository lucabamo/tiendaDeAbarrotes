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
            this.dGDetalleDevoluciones = new System.Windows.Forms.DataGridView();
            this.dGEntregas = new System.Windows.Forms.DataGridView();
            this.cBIdProveedor = new System.Windows.Forms.ComboBox();
            this.cBIdEmpleado = new System.Windows.Forms.ComboBox();
            this.cBIdDevolucion = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabVistas.SuspendLayout();
            this.tabEmpleado.SuspendLayout();
            this.tabDetalleDevolucion.SuspendLayout();
            this.tabEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGDetalleDevoluciones)).BeginInit();
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
            this.tabVistas.Location = new System.Drawing.Point(3, 10);
            this.tabVistas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVistas.Name = "tabVistas";
            this.tabVistas.SelectedIndex = 0;
            this.tabVistas.Size = new System.Drawing.Size(1055, 672);
            this.tabVistas.TabIndex = 1;
            this.tabVistas.SelectedIndexChanged += new System.EventHandler(this.TabVistas_SelectedIndexChanged);
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
            this.tabEmpleado.Location = new System.Drawing.Point(4, 25);
            this.tabEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmpleado.Size = new System.Drawing.Size(1047, 643);
            this.tabEmpleado.TabIndex = 0;
            this.tabEmpleado.Text = "Empleados";
            this.tabEmpleado.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 175);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(39, 222);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(243, 22);
            this.textBox5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(40, 137);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 22);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(369, 65);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 148);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domicilio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabProveedor
            // 
            this.tabProveedor.Location = new System.Drawing.Point(4, 25);
            this.tabProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProveedor.Name = "tabProveedor";
            this.tabProveedor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProveedor.Size = new System.Drawing.Size(1047, 643);
            this.tabProveedor.TabIndex = 1;
            this.tabProveedor.Text = "Proveedores";
            this.tabProveedor.UseVisualStyleBackColor = true;
            // 
            // tabProducto
            // 
            this.tabProducto.Location = new System.Drawing.Point(4, 25);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducto.Size = new System.Drawing.Size(1047, 643);
            this.tabProducto.TabIndex = 2;
            this.tabProducto.Text = "Productos";
            this.tabProducto.UseVisualStyleBackColor = true;
            // 
            // tabVenta
            // 
            this.tabVenta.Location = new System.Drawing.Point(4, 25);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenta.Size = new System.Drawing.Size(1047, 643);
            this.tabVenta.TabIndex = 3;
            this.tabVenta.Text = "Ventas";
            this.tabVenta.UseVisualStyleBackColor = true;
            // 
            // tabPromocion
            // 
            this.tabPromocion.Location = new System.Drawing.Point(4, 25);
            this.tabPromocion.Name = "tabPromocion";
            this.tabPromocion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPromocion.Size = new System.Drawing.Size(1047, 643);
            this.tabPromocion.TabIndex = 4;
            this.tabPromocion.Text = "Promociones";
            this.tabPromocion.UseVisualStyleBackColor = true;
            // 
            // tabDetalleVenta
            // 
            this.tabDetalleVenta.Location = new System.Drawing.Point(4, 25);
            this.tabDetalleVenta.Name = "tabDetalleVenta";
            this.tabDetalleVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalleVenta.Size = new System.Drawing.Size(1047, 643);
            this.tabDetalleVenta.TabIndex = 5;
            this.tabDetalleVenta.Text = "Detalle Ventas";
            this.tabDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // tabCompra
            // 
            this.tabCompra.Location = new System.Drawing.Point(4, 25);
            this.tabCompra.Name = "tabCompra";
            this.tabCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompra.Size = new System.Drawing.Size(1047, 643);
            this.tabCompra.TabIndex = 6;
            this.tabCompra.Text = "Compras";
            this.tabCompra.UseVisualStyleBackColor = true;
            // 
            // tabDetalleCompra
            // 
            this.tabDetalleCompra.Location = new System.Drawing.Point(4, 25);
            this.tabDetalleCompra.Name = "tabDetalleCompra";
            this.tabDetalleCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalleCompra.Size = new System.Drawing.Size(1047, 643);
            this.tabDetalleCompra.TabIndex = 7;
            this.tabDetalleCompra.Text = "Detalle Compras";
            this.tabDetalleCompra.UseVisualStyleBackColor = true;
            // 
            // tabDevolucion
            // 
            this.tabDevolucion.Location = new System.Drawing.Point(4, 25);
            this.tabDevolucion.Name = "tabDevolucion";
            this.tabDevolucion.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevolucion.Size = new System.Drawing.Size(1047, 643);
            this.tabDevolucion.TabIndex = 8;
            this.tabDevolucion.Text = "Devoluciones";
            this.tabDevolucion.UseVisualStyleBackColor = true;
            // 
            // tabDetalleDevolucion
            // 
            this.tabDetalleDevolucion.Controls.Add(this.dGDetalleDevoluciones);
            this.tabDetalleDevolucion.Location = new System.Drawing.Point(4, 25);
            this.tabDetalleDevolucion.Name = "tabDetalleDevolucion";
            this.tabDetalleDevolucion.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalleDevolucion.Size = new System.Drawing.Size(1047, 643);
            this.tabDetalleDevolucion.TabIndex = 9;
            this.tabDetalleDevolucion.Text = "Detalle Devoluciones";
            this.tabDetalleDevolucion.UseVisualStyleBackColor = true;
            // 
            // tabEntrega
            // 
            this.tabEntrega.Controls.Add(this.label8);
            this.tabEntrega.Controls.Add(this.label7);
            this.tabEntrega.Controls.Add(this.label6);
            this.tabEntrega.Controls.Add(this.dateTimePicker1);
            this.tabEntrega.Controls.Add(this.cBIdDevolucion);
            this.tabEntrega.Controls.Add(this.cBIdEmpleado);
            this.tabEntrega.Controls.Add(this.cBIdProveedor);
            this.tabEntrega.Controls.Add(this.dGEntregas);
            this.tabEntrega.Location = new System.Drawing.Point(4, 25);
            this.tabEntrega.Name = "tabEntrega";
            this.tabEntrega.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntrega.Size = new System.Drawing.Size(1047, 643);
            this.tabEntrega.TabIndex = 10;
            this.tabEntrega.Text = "Entregas";
            this.tabEntrega.UseVisualStyleBackColor = true;
            // 
            // dGDetalleDevoluciones
            // 
            this.dGDetalleDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGDetalleDevoluciones.Location = new System.Drawing.Point(28, 49);
            this.dGDetalleDevoluciones.Name = "dGDetalleDevoluciones";
            this.dGDetalleDevoluciones.RowHeadersWidth = 51;
            this.dGDetalleDevoluciones.RowTemplate.Height = 24;
            this.dGDetalleDevoluciones.Size = new System.Drawing.Size(970, 452);
            this.dGDetalleDevoluciones.TabIndex = 0;
            // 
            // dGEntregas
            // 
            this.dGEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGEntregas.Location = new System.Drawing.Point(29, 273);
            this.dGEntregas.Name = "dGEntregas";
            this.dGEntregas.RowHeadersWidth = 51;
            this.dGEntregas.RowTemplate.Height = 24;
            this.dGEntregas.Size = new System.Drawing.Size(989, 137);
            this.dGEntregas.TabIndex = 0;
            // 
            // cBIdProveedor
            // 
            this.cBIdProveedor.FormattingEnabled = true;
            this.cBIdProveedor.Location = new System.Drawing.Point(57, 52);
            this.cBIdProveedor.Name = "cBIdProveedor";
            this.cBIdProveedor.Size = new System.Drawing.Size(121, 24);
            this.cBIdProveedor.TabIndex = 1;
            // 
            // cBIdEmpleado
            // 
            this.cBIdEmpleado.FormattingEnabled = true;
            this.cBIdEmpleado.Location = new System.Drawing.Point(220, 52);
            this.cBIdEmpleado.Name = "cBIdEmpleado";
            this.cBIdEmpleado.Size = new System.Drawing.Size(121, 24);
            this.cBIdEmpleado.TabIndex = 2;
            // 
            // cBIdDevolucion
            // 
            this.cBIdDevolucion.FormattingEnabled = true;
            this.cBIdDevolucion.Location = new System.Drawing.Point(381, 52);
            this.cBIdDevolucion.Name = "cBIdDevolucion";
            this.cBIdDevolucion.Size = new System.Drawing.Size(121, 24);
            this.cBIdDevolucion.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(612, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Devolucion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 748);
            this.Controls.Add(this.tabVistas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Abarrotes";
            this.tabVistas.ResumeLayout(false);
            this.tabEmpleado.ResumeLayout(false);
            this.tabEmpleado.PerformLayout();
            this.tabDetalleDevolucion.ResumeLayout(false);
            this.tabEntrega.ResumeLayout(false);
            this.tabEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGDetalleDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGEntregas)).EndInit();
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
        private System.Windows.Forms.DataGridView dGDetalleDevoluciones;
        private System.Windows.Forms.DataGridView dGEntregas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cBIdDevolucion;
        private System.Windows.Forms.ComboBox cBIdEmpleado;
        private System.Windows.Forms.ComboBox cBIdProveedor;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistemaTiendaAbarrotes
{
    public class Compra
    {
        SqlConnection conexion;
        ComboBox cbEmpleado;
        ComboBox cbProveedor;
        DateTimePicker dateFechaCompra;
        DataGridView dtCompras;
        string idCompra;

        public Compra(SqlConnection con, ComboBox empleado, ComboBox proveedor, DateTimePicker fecha, DataGridView compras)
        {
            conexion = con;
            cbEmpleado = empleado;
            cbProveedor = proveedor;
            dateFechaCompra = fecha;
            dtCompras = compras;

            actualizaTabla();
        }

        public void insertarCompra()
        {
            try
            {
                DataRowView Proveedor = (DataRowView)cbProveedor.SelectedItem;
                DataRowView Empleado = (DataRowView)cbEmpleado.SelectedItem;
                Int64 IdProveedor = (Int64)Proveedor.Row.ItemArray[0];
                Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; ;
                DateTime FechaCompra = dateFechaCompra.Value.Date;

                string query = "INSERT INTO Transaccion.Compra (IdProveedor, IdEmpleado, Fecha, Total) VALUES (@proveedor, @empleado, @fecha, @total) ";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@proveedor", IdProveedor);
                comando.Parameters.AddWithValue("@empleado", IdEmpleado);
                comando.Parameters.AddWithValue("@fecha", FechaCompra);
                comando.Parameters.AddWithValue("@total", 0);


                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Es necesario insertar todos los campos");
            }

            actualizaTabla();
        }

        public void modificarCompra()
        {
            if (idCompra != null)
            {
                DataRowView Proveedor = (DataRowView)cbProveedor.SelectedItem;
                DataRowView Empleado = (DataRowView)cbEmpleado.SelectedItem;
                Int64 IdProveedor = (Int64)Proveedor.Row.ItemArray[0];
                Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; ;
                DateTime FechaCompra = dateFechaCompra.Value.Date;

                string query = "UPDATE Transaccion.Compra SET IdProveedor = @proveedor, IdEmpleado = @empleado, Fecha = @fecha WHERE IdCompra = @idCompra ";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@proveedor", IdProveedor);
                comando.Parameters.AddWithValue("@empleado", IdEmpleado);
                comando.Parameters.AddWithValue("@fecha", FechaCompra);
                comando.Parameters.AddWithValue("@idCompra", idCompra);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                actualizaTabla();

                cbEmpleado.Text = "";
                cbEmpleado.SelectedIndex = -1;
                cbProveedor.Text = "";
                cbProveedor.SelectedIndex = -1;
                dateFechaCompra.Value = System.DateTime.Now;
              
            }
            else
                MessageBox.Show("Debe seleccionar una fila.");
        }

        public void eliminarCompra()
        {
            if (idCompra != null)
            {
                string query = "DELETE FROM Transaccion.Compra WHERE IdCompra = @idCompra";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idCompra", idCompra);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                actualizaTabla();

                cbEmpleado.Text = "";
                cbEmpleado.SelectedIndex = -1;
                cbProveedor.Text = "";
                cbProveedor.SelectedIndex = -1;
                dateFechaCompra.Value = System.DateTime.Now;
                

            }
            else
                MessageBox.Show("Debe seleccionar una fila.");
        }


        public void actualizaTabla()
        {
            string query2 = "SELECT * FROM Transaccion.Compra";
            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando2);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtCompras.DataSource = tabla;

            llenaNombreEmpleado();
            llenaNombreProveedor();

        }

        public void llenaNombreEmpleado()
        {
            string consultaEmpleados = "SELECT IdEmpleado, Nombre FROM Empresa.Empleado";
            using (var command = new SqlCommand(consultaEmpleados, conexion))
            {
                DataTable tablaEmpleado = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaEmpleado.Load(reader);
                    cbEmpleado.ValueMember = "IdEmpleado";
                    cbEmpleado.DisplayMember = "Nombre";
                    cbEmpleado.DataSource = tablaEmpleado;
                }
            }
            cbEmpleado.Text = "";
            cbEmpleado.SelectedIndex = -1;
        }

        public void llenaNombreProveedor()
        {
            string consultaProveedores = "SELECT IdProveedor, Nombre FROM Empresa.Proveedor";
            using (var command = new SqlCommand(consultaProveedores, conexion))
            {
                DataTable tablaProveedor = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaProveedor.Load(reader);
                    cbProveedor.ValueMember = "IdProveedor";
                    cbProveedor.DisplayMember = "Nombre";
                    cbProveedor.DataSource = tablaProveedor;
                }
            }
            cbProveedor.Text = "";
            cbProveedor.SelectedIndex = -1;
        }

        public void colocaCompra()
        {
            DataGridViewRow fila = dtCompras.CurrentRow;
            idCompra = fila.Cells[0].Value.ToString();
            fila.Selected = true;

            cbEmpleado.SelectedValue = fila.Cells[1].Value;
            cbProveedor.SelectedValue = fila.Cells[2].Value;
            dateFechaCompra.Value = (DateTime)fila.Cells[3].Value;
       

        }
    }
}

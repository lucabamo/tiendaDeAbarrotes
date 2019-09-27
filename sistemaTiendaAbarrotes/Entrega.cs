using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaTiendaAbarrotes
{
    class Entrega
    {
        SqlConnection conexion;
        public Entrega(SqlConnection conexion) {
            this.conexion = conexion;
        }

        public void Consulta(DataGridView dGEntrega)
        {
            string consulta = "SELECT * FROM Transaccion.Entrega";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dGEntrega.DataSource = tabla;
        }

        public void llenaComboBox(ComboBox cbProveedores, ComboBox cbDevoluciones, ComboBox cbEmpelados) {
            try {
                llenaNombreProveedor(cbProveedores);
                llenaMotivosDevolucion(cbDevoluciones);
                llenaNombreEmpleado(cbEmpelados);
            }
            catch (Exception e) {

            }    
        }

        private void llenaMotivosDevolucion(ComboBox cbDevoluciones) {
            string consultaDevoluciones = "SELECT IdDevolucion, Motivo FROM Transaccion.Devolucion";
            using (var command = new SqlCommand(consultaDevoluciones, conexion))
            {
                DataTable tablaDevolucion = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaDevolucion.Load(reader);
                    cbDevoluciones.ValueMember = "IdDevolucion";
                    cbDevoluciones.DisplayMember = "Motivo";
                    cbDevoluciones.DataSource = tablaDevolucion;       
                }
            }
            cbDevoluciones.Text = "";
            cbDevoluciones.SelectedIndex = -1;
        }
   
        private void llenaNombreProveedor(ComboBox cbProveedores) {

            string consultaProveedores = "SELECT IdProveedor,Nombre FROM Empresa.Proveedor";

            using (var command = new SqlCommand(consultaProveedores, conexion))
            {
                DataTable tablaProveedor = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaProveedor.Load(reader);
                    cbProveedores.ValueMember = "IdProveedor";
                    cbProveedores.DisplayMember = "Nombre";
                    cbProveedores.DataSource = tablaProveedor;
                }
            }
            cbProveedores.Text = "";
            cbProveedores.SelectedIndex = -1;
        }

        private void llenaNombreEmpleado(ComboBox cbEmpleados)
        {
            string consultaEmpleados = "SELECT IdEmpleado,Nombre FROM Empresa.Empleado";
            using (var command = new SqlCommand(consultaEmpleados, conexion))
            {
                DataTable tablaEmpleado = new DataTable();
                // Process results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tablaEmpleado.Load(reader);
                    cbEmpleados.ValueMember = "IdEmpleado";
                    cbEmpleados.DisplayMember = "Nombre";
                    cbEmpleados.DataSource = tablaEmpleado;
                }
            }
            cbEmpleados.Text = "";
            cbEmpleados.SelectedIndex = -1;
        }
        public void Inserta(Int64 IdProveedor, Int64 IdDevolucion, Int64 IdEmpleado, DateTime FechaEntrega)
        {
            string query = "";
            query = "INSERT INTO Transaccion.Entrega (IdProveedor, IdDevolucion, IdEmpleado, FechaEntrega) " +
                    "VALUES (@IdProveedor, @IdDevolucion,@IdEmpleado,@FechaEntrega)";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);
            comando.Parameters.AddWithValue("@IdDevolucion", IdDevolucion);
            comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
            comando.Parameters.AddWithValue("@FechaEntrega", FechaEntrega);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
        }

        public void Inserta(ComboBox cBIdProveedor, ComboBox cBIdDevolucion, ComboBox cBIdEmpleado, DateTimePicker dTFechaEntrega)
        {
            try
            {
                DataRowView Proveedor = (DataRowView)cBIdProveedor.SelectedItem;
                DataRowView Devolucion = (DataRowView)cBIdDevolucion.SelectedItem;
                DataRowView Empleado = (DataRowView)cBIdEmpleado.SelectedItem;
                Int64 IdProveedor = (Int64)Proveedor.Row.ItemArray[0];
                Int64 IdDevolucion = (Int64)Devolucion.Row.ItemArray[0]; ;
                Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; ;
                DateTime FechaEntrega = dTFechaEntrega.Value.Date;
                string query = "";
                query = "INSERT INTO Transaccion.Entrega (IdProveedor, IdDevolucion, IdEmpleado, FechaEntrega) " +
                        "VALUES (@IdProveedor, @IdDevolucion,@IdEmpleado,@FechaEntrega)";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                comando.Parameters.AddWithValue("@IdDevolucion", IdDevolucion);
                comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@FechaEntrega", FechaEntrega);
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Inserción correcta");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hubo un error en la inserción");
                }
                limpiaFormulario(cBIdProveedor, cBIdDevolucion, cBIdEmpleado, dTFechaEntrega);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
        }

        public void cargaRegistroSeleccionado(string IdEntregaSeleccionada)
        {
            string consulta = "SELECT * FROM Transaccion.Entrega WHERE IdDevolucion = " + IdEntregaSeleccionada;
            try
            {
                using (var command = new SqlCommand(consulta, conexion))
                {
                    Int64 IdEntrega = -1;
                    Int64 IdProveedor = -1;
                    Int64 IdDevolucion = -1;
                    Int64 IdEmpleado = -1;
                    DateTime FechaEntrega;
                    // Process results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IdEntrega = (Int64)reader["IdEntrega"];
                            IdDevolucion = (Int64)reader["IdDevolucion"];
                            IdProveedor = (Int64)reader["IdProveedor"];
                            IdEmpleado = (Int64)reader["IdEmpleado"];
                            FechaEntrega = (DateTime)reader["FechaEntrega"];
                        }
                    }
                 
                }
            }
            catch (Exception e)
            {

            }
        }

        private void limpiaFormulario(ComboBox cbProveedores, ComboBox cbDevoluciones,
            ComboBox cbEmpelados, DateTimePicker dTFechaEntrega) {
            cbDevoluciones.Text = "";
            cbDevoluciones.SelectedIndex = -1;
            cbEmpelados.Text = "";
            cbEmpelados.SelectedIndex = -1;
            cbProveedores.Text = "";
            cbProveedores.SelectedIndex = -1;
            dTFechaEntrega.Value = System.DateTime.Now;
        }

    }
}

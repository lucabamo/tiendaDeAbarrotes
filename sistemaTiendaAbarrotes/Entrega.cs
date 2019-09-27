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
        DataTable tablaEntrega;
        string IdEntregaSeleccionada;
        ComboBox cbIdProveedorI;
        ComboBox cbIdDevolucionI;
        ComboBox cbIdEmpleadoI;
        DateTimePicker dtFechaEntregaI;
        public Entrega(SqlConnection conexion, ComboBox cbIdProveedor, ComboBox cbIdDevolucion, 
            ComboBox cbIdEmpleado, DateTimePicker dtFechaEntrega) {
            this.conexion = conexion;
            tablaEntrega = new DataTable();
            this.cbIdProveedorI = cbIdProveedor;
            this.cbIdDevolucionI = cbIdDevolucion;
            this.cbIdEmpleadoI = cbIdEmpleado;
            this.dtFechaEntregaI = dtFechaEntrega;
            IdEntregaSeleccionada = "";
        }

        public string AccesoIdEntregaSeleccionada {
            get { return IdEntregaSeleccionada; }
            set { IdEntregaSeleccionada = value; }
        }

        public void Consulta(DataGridView dGEntrega)
        {
            tablaEntrega.Clear();
            string consulta = "SELECT * FROM Transaccion.Entrega";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tablaEntrega);
            dGEntrega.DataSource = tablaEntrega;
            llenaComboBox();
        }

        private void llenaComboBox() {
            try {
                llenaNombreProveedor(cbIdProveedorI);
                llenaMotivosDevolucion(cbIdDevolucionI);
                llenaNombreEmpleado(cbIdEmpleadoI);
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
      
        /// <summary>
        /// Método para insertar una tupla de la tabla Entrega
        /// </summary>
        /// <param name="cBIdProveedor">ComboBox para el ID del proveedor</param>
        /// <param name="cBIdDevolucion">ComboBox para el ID de la Devolución</param>
        /// <param name="cBIdEmpleado">ComboBox para el ID del Empleado</param>
        /// <param name="dTFechaEntrega">DateTimePicker para la fecha seleccionada</param>
        public void Inserta(ComboBox cBIdProveedor, ComboBox cBIdDevolucion, ComboBox cBIdEmpleado, DateTimePicker dTFechaEntrega)
        {
            try
            {
                //DataRowView es el tipo de dato para leer una tupla que se inserto en algún lugar con anterioridad
                DataRowView Proveedor = (DataRowView)cBIdProveedor.SelectedItem; 
                DataRowView Devolucion = (DataRowView)cBIdDevolucion.SelectedItem;
                DataRowView Empleado = (DataRowView)cBIdEmpleado.SelectedItem;
                Int64 IdProveedor = (Int64)Proveedor.Row.ItemArray[0]; //Nuestro elemento de la posición 0 es el ID
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

        public void eliminaRegistroSeleccionado() {
            if (IdEntregaSeleccionada != "")
            {
                string queryElimina = "DELETE FROM Transaccion.Entrega WHERE IdEntrega = " + IdEntregaSeleccionada;
                SqlCommand comando = new SqlCommand(queryElimina, conexion);
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Eliminación exitosa");
                    limpiaFormulario(cbIdProveedorI,cbIdDevolucionI,cbIdEmpleadoI,dtFechaEntregaI);
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR" + e.Message);

                }
            }
            else {
                MessageBox.Show("Es necesario seleccionar un registro para eliminar");
            }

        }

        public void cargaRegistroSeleccionado()
        {
            //Se toma la tupla seleccionada buscando dentro de la tablaEntrega con un Select buscando en el atributo
            //[IdEntrega]
            DataRow[] tuplaSeleccionada = tablaEntrega.Select("[IdEntrega] = " + IdEntregaSeleccionada);

            //Una vez seleccionada la tupla buscamos cada uno de los atributos
            var IdProveedor = tuplaSeleccionada[0].ItemArray[1];
            var IdEmpleado = tuplaSeleccionada[0].ItemArray[2];
            var IdDevolucion = tuplaSeleccionada[0].ItemArray[3];
            var FechaEntrega = (DateTime)tuplaSeleccionada[0].ItemArray[4];

            cbIdProveedorI.SelectedValue = IdProveedor;
            cbIdEmpleadoI.SelectedValue = IdEmpleado;
            cbIdDevolucionI.SelectedValue = IdDevolucion;
            dtFechaEntregaI.Value = FechaEntrega;
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

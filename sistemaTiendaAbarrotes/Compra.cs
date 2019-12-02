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
    // Clase para las operaciones de compra
    public class Compra
    {
        // Variables
        SqlConnection conexion;
        ComboBox cbEmpleado;
        ComboBox cbProveedor;
        DateTimePicker dateFechaCompra;
        DataGridView dtCompras;
        string idCompra; // Guarda el Id de la compra para su operacion

        // Constructor de la clase, recibe la conexion y los controles del formulario Compra
        public Compra(SqlConnection con, ComboBox empleado, ComboBox proveedor, DateTimePicker fecha, DataGridView compras)
        {
            conexion = con;
            cbEmpleado = empleado;
            cbProveedor = proveedor;
            dateFechaCompra = fecha;
            dtCompras = compras;

            // Llena la tabla con las tuplas existentes
            actualizaTabla();
        }


        //Metodo para insertar una compra en la tabla
        public void insertarCompra()
        {
            try
            {
                // Obtiene los valores que se encuentran en los controles de texto
                DataRowView Proveedor = (DataRowView)cbProveedor.SelectedItem;
                DataRowView Empleado = (DataRowView)cbEmpleado.SelectedItem;
                Int64 IdProveedor = (Int64)Proveedor.Row.ItemArray[0];
                Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; ;
                DateTime FechaCompra = dateFechaCompra.Value.Date;

                // Genera la instruccion SQL
                string query = "INSERT INTO Transaccion.Compra (IdProveedor, IdEmpleado, Fecha, Total) VALUES (@proveedor, @empleado, @fecha, @total) ";

                // Manda la instruccion a la base de datos
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@proveedor", IdProveedor);
                comando.Parameters.AddWithValue("@empleado", IdEmpleado);
                comando.Parameters.AddWithValue("@fecha", FechaCompra);
                comando.Parameters.AddWithValue("@total", 0);


                try
                {
                    // Ejecuta la instruccion SQL
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Si no se pudo insertar manda un mensaje
                    MessageBox.Show("Hubo un error en la inserción");
                }
            }
            catch (Exception ex) {
                // Manda un mensaje si falta un campo de llenar en el formulario
                MessageBox.Show("Es necesario insertar todos los campos");
            }

            // Actualiza la tabla con la nueva tupla
            actualizaTabla();
        }


        // Metodo para modificar una tupla de la tabla compra
        public void modificarCompra()
        {
            if (idCompra != null)
            {
                // Obtiene los valores que se encuentran en los controles de texto
                DataRowView Proveedor = (DataRowView)cbProveedor.SelectedItem;
                DataRowView Empleado = (DataRowView)cbEmpleado.SelectedItem;
                Int64 IdProveedor = (Int64)Proveedor.Row.ItemArray[0];
                Int64 IdEmpleado = (Int64)Empleado.Row.ItemArray[0]; ;
                DateTime FechaCompra = dateFechaCompra.Value.Date;

                // Genera la instruccion SQL
                string query = "UPDATE Transaccion.Compra SET IdProveedor = @proveedor, IdEmpleado = @empleado, Fecha = @fecha WHERE IdCompra = @idCompra ";

                // Manda la instruccion a la base de datos
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@proveedor", IdProveedor);
                comando.Parameters.AddWithValue("@empleado", IdEmpleado);
                comando.Parameters.AddWithValue("@fecha", FechaCompra);
                comando.Parameters.AddWithValue("@idCompra", idCompra);

                try
                {
                    // Ejecuta la instruccion SQL
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manda un mensaje si no se puede modificar la compra
                    MessageBox.Show("Hubo un error en la modificación");
                }

                // Actualiza la tabla con los nuevos datos
                actualizaTabla();

                // Limpia los controles de texto
                cbEmpleado.Text = "";
                cbEmpleado.SelectedIndex = -1;
                cbProveedor.Text = "";
                cbProveedor.SelectedIndex = -1;
                dateFechaCompra.Value = System.DateTime.Now;
              
            }
            else
                // Manda un mensaje si no se ha seleccionado ninguna tupla
                MessageBox.Show("Debe seleccionar una fila.");
        }


        // Metodo para eliminar una tupla de la tabla
        public void eliminarCompra()
        {
            // Valida si se selecciono una tupla
            if (idCompra != null)
            {
                // Genera la instruccion SQL
                string query = "DELETE FROM Transaccion.Compra WHERE IdCompra = @idCompra";

                // Manda la instruccion a la base de datos
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idCompra", idCompra);

                try
                {
                    // Ejecuta la instruccion SQL
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manda un mensaje si no se pudo eliminar la tupla
                    MessageBox.Show("No se pudo eliminar");
                }

                // Actualiza la tabla sin la tupla eliminada
                actualizaTabla();

                // Limpia los controles de texto
                cbEmpleado.Text = "";
                cbEmpleado.SelectedIndex = -1;
                cbProveedor.Text = "";
                cbProveedor.SelectedIndex = -1;
                dateFechaCompra.Value = System.DateTime.Now;
                

            }
            else
                // Manda un mensaje si no se ha seleccionado niinguna tupla
                MessageBox.Show("Debe seleccionar una fila.");
        }

        // Metodo para actualizar la tabla con los cambios necesarios
        public void actualizaTabla()
        {
            // Genera una instruccion de consulta
            string query2 = "SELECT * FROM Transaccion.Compra";

            // Ejecuta la instruccion
            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando2);

            // Llena la tabla
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtCompras.DataSource = tabla;

            // Llena los combo box de empleado y proveedor
            llenaNombreEmpleado();
            llenaNombreProveedor();

        }


        // Metodo que llena el combo box de los empleados
        public void llenaNombreEmpleado()
        {
            // Genera la consulta hacia la tabla empleados
            string consultaEmpleados = "SELECT IdEmpleado, Nombre FROM Empresa.Empleado";

            // Despliega el nombre del empleado y guarda el Id para su manejo interno
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
            // Limpia el valor seleccionado en el combo box
            cbEmpleado.Text = "";
            cbEmpleado.SelectedIndex = -1;
        }


        // Metodo para llenar el combo box de los proveedores
        public void llenaNombreProveedor()
        {
            // Genera la consulta hacia la tabla proveedores
            string consultaProveedores = "SELECT IdProveedor, Nombre FROM Empresa.Proveedor";

            // Despliega el nombre del proveedor y guarda el Id para su manejo interno
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

            // Limpia el valor seleccionado en el combo box
            cbProveedor.Text = "";
            cbProveedor.SelectedIndex = -1;
        }


        // Metodo para llenar los controles de texto con la tupla seleccionada
        public void colocaCompra()
        {
            // Toma la fila seleccionada
            DataGridViewRow fila = dtCompras.CurrentRow;
            idCompra = fila.Cells[0].Value.ToString();
            fila.Selected = true;

            // Coloca cada uno de los valores en los campos correspondientes
            cbEmpleado.SelectedValue = fila.Cells[1].Value;
            cbProveedor.SelectedValue = fila.Cells[2].Value;
            dateFechaCompra.Value = (DateTime)fila.Cells[3].Value;
       

        }
    }
}

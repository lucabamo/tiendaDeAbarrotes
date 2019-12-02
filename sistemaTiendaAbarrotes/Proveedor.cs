using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace sistemaTiendaAbarrotes
{
    // Clase para las operaciones de proveedor
    public class Proveedor
    {
        // Variables
        SqlConnection conexion;
        DataTable tablaProveedor;
        string IdProveedorSeleccionado;
        TextBox tbNombre;
        TextBox tbTelefono;
        TextBox tbEmail;
        TextBox tbRFC;
        TextBox tbDomicilio;

        // Constructor de la clase, recibe la conecion y los controles del formulario
        public Proveedor(SqlConnection conexion, TextBox nombre, TextBox telefono, TextBox email,
            TextBox rfc, TextBox domicilio)
        {
            tablaProveedor = new DataTable();
            this.conexion = conexion;
            tbNombre = nombre;
            tbTelefono = telefono;
            tbEmail = email;
            tbRFC = rfc;
            tbDomicilio = domicilio;
            IdProveedorSeleccionado = "";
        }


        // Regresa el Id del proveedor
        public string AccesoIdProveedorSeleccionado
        {
            get { return IdProveedorSeleccionado; }
            set { IdProveedorSeleccionado = value; }
        }


        // Metodo que llena la tabla de proveedores
        public void Consulta(DataGridView dgProveedor)
        {
            tablaProveedor.Clear();
            // Genera la consulta SQL
            string consulta = "SELECT * FROM Empresa.Proveedor";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            // Llena la tabla
            adaptador.Fill(tablaProveedor);
            dgProveedor.DataSource = tablaProveedor;
        }


        // Metodo que inserta un proveedor en la tabla
        public void Inserta()
        {
            try
            {
                // Obtiene los valores de los campos
                string nombre = tbNombre.Text;
                string telefono = tbTelefono.Text;
                string email = tbEmail.Text;
                string rfc = tbRFC.Text;
                string domicilio = tbDomicilio.Text;

                // Genera la consulta SQl
                string query = "";
                query = "INSERT INTO Empresa.Proveedor (Nombre, Telefono, Email, RFC, DomicilioFiscal) " +
                        "VALUES (@nombre, @telefono,@email,@rfc, @domicilio)";

                // Envia la consulta a la base de datos
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@domicilio", domicilio);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@rfc", rfc);

                try
                {
                    // Ejecuta la instruccion
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Inserción correcta");
                    limpiaFormulario();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hubo un error en la inserción");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Todos los campos son necesarios");
            }
        }

        // Metodo que carga los valores de un registro a los controles de texto
        public void cargaRegistroSeleccionado()
        {
            //Se toma la tupla seleccionada buscando dentro de la tablaEntrega con un Select buscando en el atributo
            //[IdEntrega]
            DataRow[] tuplaSeleccionada = tablaProveedor.Select("[IdProveedor] = " + IdProveedorSeleccionado);

            //Una vez seleccionada la tupla buscamos cada uno de los atributos
            var Nombre = tuplaSeleccionada[0].ItemArray[1];
            var Telefono = tuplaSeleccionada[0].ItemArray[2];
            var Email = tuplaSeleccionada[0].ItemArray[3];
            var RFC = tuplaSeleccionada[0].ItemArray[4];
            var Domicilio = tuplaSeleccionada[0].ItemArray[5];


            //cbIdProveedorI.SelectedValue = cbIdProveedorI.Items.IndexOf(IdEmpleado.ToString());

            // Llena cada control con el valor que le corresponde
            tbNombre.Text = (string)Nombre;
            tbDomicilio.Text = (string)Domicilio;
            tbTelefono.Text = (string)Telefono;
            tbEmail.Text = (string)Email;
            tbRFC.Text = (string)RFC;
        }


        // Metodo que modifica una tupla de proveedor
        public void editaRegistroSeleccionado()
        {
            try
            {
                // Obtiene los nuevos valores
                string nombre = tbNombre.Text;
                string telefono = tbTelefono.Text;
                string email = tbEmail.Text;
                string rfc = tbRFC.Text;
                string domicilio = tbDomicilio.Text;

                // Genera la consulta SQL
                string queryEdita = "UPDATE Empresa.Proveedor SET Nombre = @nombre, " +
                    "Telefono = @telefono, Email = @email, RFC = @rfc," +
                    "DomicilioFiscal = @domicilio " +
                    "WHERE IdProveedor = " + IdProveedorSeleccionado;

                // Envia la consulta a la base datos
                SqlCommand comando = new SqlCommand(queryEdita, conexion);

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@domicilio", domicilio);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@rfc", rfc);

                try
                {
                    // Ejecuta la instruccion
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Edición correcta");
                    limpiaFormulario();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hubo un error en la edición");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Todos los campos son necesarios");
            }

        }

        /// <summary>
        /// Método para la eliminación de un registro que ha sido seleccionado.
        /// </summary>
        public void eliminaRegistroSeleccionado()
        {
            // Valida que se haya seleccionado un registro
            if (IdProveedorSeleccionado != "")
            {
                // Genera la consulta SQl
                string queryElimina = "DELETE FROM Empresa.Proveedor WHERE IdProveedor = " 
                    + IdProveedorSeleccionado;
                // Manda la consulta a la base de datos
                SqlCommand comando = new SqlCommand(queryElimina, conexion);
                try
                {
                    // Ejecuta la instruccion
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Eliminación exitosa");
                    limpiaFormulario();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR" + e.Message);

                }
            }
            else
            {
                MessageBox.Show("Es necesario seleccionar un registro para eliminar");
            }

        }

        // Metodo que limpia los controles de texto
        private void limpiaFormulario()
        {
            tbDomicilio.Text = "";
            tbNombre.Text = "";
            tbRFC.Text = "";
            tbTelefono.Text = "";
            tbEmail.Text = "";
        }

    }
}

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
    class Empleado
    {
        SqlConnection conexion;
        DataTable tablaEmpleado;
        string IdEmpleadoSeleccionado;
        DateTimePicker dtFechaNacimiento;
        TextBox tbNombre;
        TextBox tbUsuario;
        TextBox tbPassword;
        TextBox tbDomicilio;

        public Empleado(SqlConnection conexion,TextBox nombre, TextBox usuario, TextBox password, TextBox domicilio,
            DateTimePicker dtFechaNacimiento)
        {
            this.conexion = conexion;
            tablaEmpleado = new DataTable(); //Donde vamos a guardar la consulta 
            this.tbNombre = nombre;
            this.tbUsuario = usuario;
            this.tbPassword = password;
            this.tbDomicilio = domicilio;
            this.dtFechaNacimiento = dtFechaNacimiento;
            IdEmpleadoSeleccionado = "";

        }

        public void Consulta(DataGridView dGEmpleado)
        {
            tablaEmpleado.Clear();
            string consulta = "SELECT * FROM Empresa.Empleado";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tablaEmpleado);
            dGEmpleado.DataSource = tablaEmpleado;
        }

        public string AccesoIdEmpleadoSeleccionado
        {
            get { return IdEmpleadoSeleccionado; }
            set { IdEmpleadoSeleccionado = value; }
        }

        public void Inserta()
        {
            try
            {
                string nombre = tbNombre.Text;
                string usuario = tbUsuario.Text;
                string password = tbPassword.Text;
                string domicilio = tbDomicilio.Text;
                DateTime fechaNac = dtFechaNacimiento.Value.Date;
                string query = "";
                query = "INSERT INTO Empresa.Empleado (Nombre, Domicilio, FechaNac, Edad, Usuario, Contrasenia) " +
                        "VALUES (@nombre, @domicilio,@fechaNac,NULL, @usuario, @password)";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@domicilio", domicilio);
                comando.Parameters.AddWithValue("@fechaNac", fechaNac);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@password", password);

                try
                {
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

        /// <summary>
        /// Método para la eliminación de un registro que ha sido seleccionado.
        /// </summary>
        public void eliminaRegistroSeleccionado()
        {
            if (IdEmpleadoSeleccionado != "")
            {
                string queryElimina = "DELETE FROM Empresa.Empleado WHERE IdEmpleado = " + IdEmpleadoSeleccionado;
                SqlCommand comando = new SqlCommand(queryElimina, conexion);
                try
                {
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

        public void cargaRegistroSeleccionado()
        {
            //Se toma la tupla seleccionada buscando dentro de la tablaEntrega con un Select buscando en el atributo
            //[IdEntrega]
            DataRow[] tuplaSeleccionada = tablaEmpleado.Select("[IdEmpleado] = " + IdEmpleadoSeleccionado);

            //Una vez seleccionada la tupla buscamos cada uno de los atributos
            var Nombre = tuplaSeleccionada[0].ItemArray[1];
            var Domicilio = tuplaSeleccionada[0].ItemArray[2];
            var fechaNac = (DateTime)tuplaSeleccionada[0].ItemArray[3];
            var Usuario = tuplaSeleccionada[0].ItemArray[5];
            var Password = tuplaSeleccionada[0].ItemArray[6];

            //cbIdProveedorI.SelectedValue = cbIdProveedorI.Items.IndexOf(IdEmpleado.ToString());

            tbNombre.Text = (string)Nombre;
            tbDomicilio.Text = (string)Domicilio;
            tbUsuario.Text = (string)Usuario;
            tbPassword.Text = (string)Password;
            dtFechaNacimiento.Value = fechaNac;
        }

        public void editaRegistroSeleccionado()
        {
            try
            {
                string nombre = tbNombre.Text;
                string usuario = tbUsuario.Text;
                string password = tbPassword.Text;
                string domicilio = tbDomicilio.Text;
                DateTime fechaNac = dtFechaNacimiento.Value.Date;

                string queryEdita = "UPDATE Empresa.Empleado SET Nombre = @nombre, " +
                    "Domicilio = @domicilio, FechaNac = @fechaNac, Usuario = @usuario," +
                    "Contrasenia = @password " +
                    "WHERE IdEmpleado = " + IdEmpleadoSeleccionado;

                SqlCommand comando = new SqlCommand(queryEdita, conexion);

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@domicilio", domicilio);
                comando.Parameters.AddWithValue("@fechaNac", fechaNac);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@password", password);

                try
                {
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

        private void limpiaFormulario()
        {
            tbDomicilio.Text = "";
            tbNombre.Text = "";
            tbPassword.Text = "";
            tbUsuario.Text = "";
        }

    }
}

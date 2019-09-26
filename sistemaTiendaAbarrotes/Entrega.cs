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

        public void Insercion(string IdProveedor, string IdDevolucion, string IdEmpleado, string FechaEntrega)
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

    }
}

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
    class DetalleDevolucion
    {
        SqlConnection conexion;
        public DetalleDevolucion (SqlConnection conexion) {
            this.conexion = conexion;
        }
        public void Consulta(DataGridView dGDetalleDevoluciones) {
            string consulta = "SELECT * FROM Transaccion.DetalleDevolucion";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);   
            dGDetalleDevoluciones.DataSource = tabla;
        }

        public void Insercion(string IdDevolucion, string IdProducto, string Cantidad)
        {
            string query = "";
            query = "INSERT INTO Transaccion.Entrega (IdDevolucion, IdProducto, Cantidad) " +
                    "VALUES (@IdDevolucion, @IdProducto,@Cantidad)";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@IdDevolucion", IdDevolucion);
            comando.Parameters.AddWithValue("@IdProducto", IdProducto);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
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

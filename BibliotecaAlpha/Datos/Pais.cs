using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Pais
    {
        public void Agregar(Entidades.Pais pais)
        {
            string strSQL = @"insert into Paises(Nombre) values(@Nombre)";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objComAgregar = new SqlCommand(strSQL,objConexion);

            objComAgregar.Parameters.AddWithValue("@Nombre", pais.Nombre);

            objConexion.Open();
            objComAgregar.ExecuteNonQuery();
            objConexion.Close();
        }
    }
}

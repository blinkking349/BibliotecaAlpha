using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Datos
{
    public class Autor
    {
        public void Agregar(Entidades.Autor autor)
        {
            string strSQL = @"insert into AutoresNew(Apellido,Nombre,FechaNacimiento,IdPais)
                              values(@Apellido,@Nombre,@FechaNacimiento,@IdPais)";
            //Conexion SQL
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            //Comando Agregar a SQL
            SqlCommand objComAgregar = new SqlCommand(strSQL, objConexion);

            //parametros
            objComAgregar.Parameters.AddWithValue("@Apellido",autor.Apellido);
            objComAgregar.Parameters.AddWithValue("@Nombre", autor.Nombre);
            objComAgregar.Parameters.AddWithValue("@FechaNacimiento", autor.FechaNacimiento);
            objComAgregar.Parameters.AddWithValue("@IdPais", autor.Pais.ID);

            //abrir conexion 
            objConexion.Open();
            //envio comandos a SQL
            objComAgregar.ExecuteNonQuery();
            //cierro conexion
            objConexion.Close();

        }
    }
}

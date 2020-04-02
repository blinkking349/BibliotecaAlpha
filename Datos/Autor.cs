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
            string strSQL = @"insert into Autores(Apellido,Nombre,FechaNacimiento,IdPais)
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
        
        //Metodo para traer Autores de la base de datos sin Conexion
        public DataTable TraerAutores()
        {
            DataTable dtAutores = new DataTable();
            string strSQL = "select * from Autores";
            //SqlDataAdapter
            SqlDataAdapter objDataTraer = new SqlDataAdapter(strSQL, Conexion.strConexion);
            //Llenar datatable
            objDataTraer.Fill(dtAutores);
            return dtAutores;
        }

    }
}

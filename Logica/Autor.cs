using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{

    
    public class Autor
    {
        //creo instancia de Autor (DATOS)
        Datos.Autor objDatosAutor = new Datos.Autor();
        //metodos

        //agrega el autor a la lista <ListaAutores>
        public void Agregar(Entidades.Autor autor,List<Entidades.Autor> lista)
        {
            lista.Add(autor);
        }
        public void Agregar(Entidades.Autor autor)
        {
            
            //invoco al metodo Agregar() de la capa DATOS y paso el objeto Autor
            
            objDatosAutor.Agregar(autor);

        }

        public DataTable TraerAutores()
        {
            //llamo al metodo TraerAutores() de la capa Datos 
            return objDatosAutor.TraerAutores();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autor
    {
        //metodos
        
            //agrega el autor a la lista <ListaAutores>
        public void Agregar(Entidades.Autor autor,List<Entidades.Autor> lista)
        {
            lista.Add(autor);
        }
        public void Agregar(Entidades.Autor autor)
        {
            //creo instancia de Autor (DATOS)
            //e invoco al metodo Agregar() de la capa DATOS y paso el objeto Autor
            Datos.Autor objDatosAutor = new Datos.Autor();
            objDatosAutor.Agregar(autor);

        }
    }
}

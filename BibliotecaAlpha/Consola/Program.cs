using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Consola {
        static void Main(string[] args)
        {




            //creo lista nueva autores
            List<Entidades.Autor> ListaAutores = new List<Entidades.Autor>();
            string respuesta = "";
            int opcion;
            string dato;
            
            Console.WriteLine("Ingrese una opcion:");
            Console.WriteLine("1. Agregar Autores al registro");
            Console.WriteLine("2. Borrar autores al registro");
            Console.WriteLine("3. Consultar Registro ");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);
            switch (opcion)
            {
                case 1:

            do
            {
                        //Creo instancia de autor (entidades)
                Console.WriteLine("Nuevo Autor.. Agregue las informacion del mismo:");
                Entidades.Autor objEntidadAutor = new Entidades.Autor();
                Entidades.Pais objEntidadPais = new Entidades.Pais();
                 
                //objEntidadPais.ID = 1;
                

                Console.WriteLine("Ingrese el nombre del Autor:");
                objEntidadAutor.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el Apellido del Autor:");
                objEntidadAutor.Apellido = Console.ReadLine();                                
                Console.WriteLine("Ingrese la fecha de nacimiento del Autor:");
                objEntidadAutor.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Ingrese un numero");
                objEntidadPais.ID = Convert.ToInt32(Console.ReadLine());
                objEntidadAutor.Pais = objEntidadPais;
                        //Console.WriteLine("Ingrese un numero ID");
                        //        objEntidadPais.ID = 1;



                        //Creo  objeto logica autor para poder usar los metodos de la misma
                        Logica.Autor objLogicaAutor = new Logica.Autor();
                
                //envio el autor con sus propiedades a la capa datos 
                objLogicaAutor.Agregar(objEntidadAutor);
                
                Console.WriteLine("Enviando Datos");
                //agrego autor a la lista y envio a la capa de logica
                objLogicaAutor.Agregar(objEntidadAutor, ListaAutores);
                Console.WriteLine("Agregando Autor a Lista");
                Console.ReadKey();
                Console.WriteLine("Quiere subir otro autor a la lista?");
                Console.WriteLine("ingrese: si o no");
                respuesta = Console.ReadLine();
                Console.Clear();


            } while (respuesta == "si");


                    break;


                case 2:

                    break;

                case 3:

                    break;
        }
            
            
            foreach (var a in ListaAutores)
        {
            Console.WriteLine("Nombre: "+a.Nombre+ " Apellido:"+a.Apellido+  "Fecha de Nacimiento:" +a.FechaNacimiento);
        }



        }
    }

}

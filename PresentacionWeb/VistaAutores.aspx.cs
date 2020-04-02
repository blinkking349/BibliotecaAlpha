using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class VistaAutores : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //se ejecuta por cada request / peticion
            TraerAutoresTabla();
        }
        void TraerAutoresTabla()
        {
            Logica.Autor objLogicaAutor = new Logica.Autor();

            gvAutores.DataSource = objLogicaAutor.TraerAutores();
            gvAutores.DataBind();
          
        }

    }

}
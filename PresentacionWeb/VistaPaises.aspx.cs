using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class VistaPaises :Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //se ejecuta por cada request / peticion
            TraerPaises();
        }
        //al cargarse la pagina se inicia el metodo TraerPaises
        void TraerPaises()
        {
            //invocar al metodo TraerTodos de Logica
            Logica.Pais objLogica = new Logica.Pais();
            //vincular grilla al resultado
            gvPaises.DataSource = objLogica.TraerTodos();
            //lleno la grilla 
            gvPaises.DataBind();
                 
        }
    }
}
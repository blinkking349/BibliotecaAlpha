using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class NuevoPais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            //este codigo se ejecuta cuando el usuario hace click sobre el boton
            Logica.Pais objLogicaPais = new Logica.Pais();
            Entidades.Pais objEntidadPais = new Entidades.Pais();
            //envio completo nombre en Pais /Capa Entidad
            objEntidadPais.Nombre = txtNombre.Text;

            objLogicaPais.Agregar(objEntidadPais);
            lblMensaje.Text = "Pais Agregado";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class NuevoAutor : Page
    {
        Logica.Pais objLogicaPais = new Logica.Pais();
        protected void Page_Load(object sender, EventArgs e)
        {
            TraerPaises();

        }
        void TraerPaises()
        {
            ddlPaises.DataSource = objLogicaPais.TraerTodos();
            //campo select que quiero mostrar
            ddlPaises.DataTextField = "Nombre";
            //campo select que quiero guardar
            ddlPaises.DataValueField = "ID";

            ddlPaises.DataBind();

        }

         protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            //este codigo se ejecuta cuando el usuario clickea en el boton
            Logica.Autor objLogicaAutor = new Logica.Autor();
            Entidades.Autor objEntidadAutor = new Entidades.Autor();

            objEntidadAutor.Nombre = txtNombre.Text;
            objEntidadAutor.Apellido = txtApellido.Text;
            objEntidadAutor.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            objEntidadAutor.Pais.Nombre = ddlPaises.SelectedValue;
            objLogicaAutor.Agregar(objEntidadAutor);
            lblNombre.Text = "Nombre Agregado";
            lblApellido.Text = "Apellido Agregado";
            lblFechaNacimiento.Text = "Fecha Agregada";

        }
    }
}
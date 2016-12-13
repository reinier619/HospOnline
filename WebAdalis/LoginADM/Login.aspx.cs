using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospOnline.LoginADM
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtRut.Attributes.Add("placeholder", "Rut del Profesional...");
            txtPassword.Attributes.Add("placeholder", "Contraseña...");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Session["Administracion"] = "SI";
            Response.Redirect("../Main/Home.aspx");
        }
    }
}
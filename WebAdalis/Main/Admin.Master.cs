using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospOnline.Main
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Administracion"] == "SI" )
            {
                siderbarPersonal.Visible = true;
            }

            if (Session["Administracion"] == "NO")
            {
                siderbarPublico.Visible = true;
            }


            nombre_paciente.Text = "Reinier Utreras Lara";
        }
    }
}
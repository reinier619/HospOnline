using HospOnline.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospOnline.Main
{
    public partial class Ingreso_Examenes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PacienteDTO pacienteDTO = new PacienteDTO();

            pacienteDTO = (PacienteDTO)Session["pacienteDTO"];
        }
    }
}
using HospOnline.DTO;
using HospOnline.NEG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospOnline.Main
{
    public partial class Consulta_Examenes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargardatospaciente();

            IngresoDTO ingresoDTO = (IngresoDTO)Session["ingresoDTO"];
            PacienteDTO pacienteDTO = (PacienteDTO)Session["pacienteDTO"];

            List<ExamenDTO> listExamenDTO = new List<ExamenDTO>();
            ExamenNEG examenNEG = new ExamenNEG();
            ExamenDTO examenDTOIN = new ExamenDTO();

            examenDTOIN.ingresoID = ingresoDTO.ingresoID;

            listExamenDTO = examenNEG.readxIngreso(examenDTOIN);

            gvExamenes.DataSource = listExamenDTO;
            gvExamenes.DataBind();


            List<ImagenDTO> listImagenDTO = new List<ImagenDTO>();
            ImagenNEG imagenNEG = new ImagenNEG();
            ImagenDTO imagenDTOIN = new ImagenDTO();

            imagenDTOIN.ingresoID = ingresoDTO.ingresoID;

            listImagenDTO = imagenNEG.readxIngreso(imagenDTOIN);

            gvImagenes.DataSource = listImagenDTO;
            gvImagenes.DataBind();

            //List<ImagenesDTO> listExamenDTO = new List<ImagenesDTO>();
            //ExamenNEG examenNEG = new ExamenNEG();
            //ExamenDTO examenDTOIN = new ExamenDTO();

            //gvImagenes.DataSource = dtImagenes;
            //gvImagenes.DataBind();

            //DataTable dtImagenes = new DataTable();

            //dtImagenes.Clear();
            //dtImagenes.Columns.Add("nombre_imagen");
            //dtImagenes.Columns.Add("fecha_imagen");
            //dtImagenes.Columns.Add("diagnostico");

            //DataRow rowImagenes = dtImagenes.NewRow();
            //rowImagenes["nombre_imagen"] = "Radiografia Pierna Derecha";
            //rowImagenes["fecha_imagen"] = "26/11/2016";
            //rowImagenes["diagnostico"] = "Diagnostico 1";
            //dtImagenes.Rows.Add(rowImagenes);

            //gvImagenes.DataSource = dtImagenes;
            //gvImagenes.DataBind();
        }

        public void cargardatospaciente()
        {
            IngresoDTO ingresoDTO = (IngresoDTO)Session["ingresoDTO"];
            PacienteDTO pacienteDTO = (PacienteDTO)Session["pacienteDTO"];

            lblRut.Text = pacienteDTO.rut + "-" + pacienteDTO.digito_verificador;
            lblNombre.Text = pacienteDTO.nombre + " " + pacienteDTO.apellido_paterno + " " + pacienteDTO.apellido_materno;
            lblEdad.Text = pacienteDTO.edad;
            lblEstado.Text = ingresoDTO.estado;
            lblEnfermedad.Text = ingresoDTO.enfermedad;
            lblFechaIngreso.Text = pacienteDTO.fecha_registro.ToString("dd/MM/yyyy");
            lblHoraIngreso.Text = ingresoDTO.hora_ingreso;
            lblUnidad.Text = ingresoDTO.unidad.nombre;
            lblSala.Text = ingresoDTO.sala.numero;
            lblCama.Text = ingresoDTO.cama.descripcion;
            
            PersonalNEG personalNEG = new PersonalNEG();
            PersonalDTO personalDTOIN = new PersonalDTO();
            PersonalDTO personalDTOOUT = new PersonalDTO();

            personalDTOIN.unidadID = ingresoDTO.unidadID;
            personalDTOOUT = personalNEG.readxUnidad(personalDTOIN);

            PersonaDTO personaDTOIN = new PersonaDTO();
            PersonaDTO personaDTOOUT = new PersonaDTO();

            PersonaNEG personaNEG = new PersonaNEG();
            personaDTOIN.personaID = personalDTOOUT.personaID;
            personaDTOOUT = personaNEG.read(personaDTOIN);
            lblDoctor.Text = personaDTOOUT.nombre + " " + personaDTOOUT.apellido_paterno + " " + personaDTOOUT.apellido_materno; 

        }
    }
}
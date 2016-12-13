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
    public partial class Consulta_Paciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            cargardatospaciente();

            IngresoDTO ingresoDTO = (IngresoDTO)Session["ingresoDTO"];
            PacienteDTO pacienteDTO = (PacienteDTO)Session["pacienteDTO"];

            List<ProcedimientoDTO> listProcedimientoDTO = new List<ProcedimientoDTO>();
            ProcedimientoNEG procedimientoNEG = new ProcedimientoNEG();
            ProcedimientoDTO procedimientoDTOIN = new ProcedimientoDTO();

            procedimientoDTOIN.ingresoID = ingresoDTO.ingresoID;

            listProcedimientoDTO = procedimientoNEG.readxIngreso(procedimientoDTOIN);

            gvProcedimientos.DataSource = listProcedimientoDTO;
            gvProcedimientos.DataBind();


            //DataTable dtMedicamento = new DataTable();

            //dtMedicamento.Clear();
            //dtMedicamento.Columns.Add("cantidad");
            //dtMedicamento.Columns.Add("medicamento");
            //dtMedicamento.Columns.Add("medida");
            //dtMedicamento.Columns.Add("unidad_medida");

            //DataRow rowMedicamento = dtMedicamento.NewRow();
            //rowMedicamento["cantidad"] = "2";
            //rowMedicamento["medicamento"] = "Paracetamol";
            //rowMedicamento["medida"] = "500";
            //rowMedicamento["unidad_medida"] = "mg";

            //dtMedicamento.Rows.Add(rowMedicamento);

            //gvMedicamentos.DataSource = dtMedicamento;
            //gvMedicamentos.DataBind();

            //DataTable dtProcedimiento = new DataTable();

            //dtProcedimiento.Clear();
            //dtProcedimiento.Columns.Add("nombre_procedimiento");
            //dtProcedimiento.Columns.Add("fecha_procedimiento");

            //DataRow rowProcedimiento = dtProcedimiento.NewRow();
            //rowProcedimiento["nombre_procedimiento"] = "Curaciones";
            //rowProcedimiento["fecha_procedimiento"] = "26/11/2016";
            //dtProcedimiento.Rows.Add(rowProcedimiento);

            //gvProcedimientos.DataSource = dtProcedimiento;
            //gvProcedimientos.DataBind();



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
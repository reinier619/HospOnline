using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospOnline.DTO
{
    public class PersonalDTO
    {
        public Int64 personalID { get; set; }
        public Int64 personaID { get; set; }
        public PersonaDTO persona { get; set; }
        public Int64 cargoID { get; set; }
        public Int64 unidadID { get; set; }

        public PersonalDTO()
        {

        }
    }
}
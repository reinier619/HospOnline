using HospOnline.DAO;
using HospOnline.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HospOnline.NEG
{
    public class PersonalNEG
    {
        public PersonalDTO readxUnidad(PersonalDTO personalDTO)
        {
            DataTable dt = new DataTable();
            PersonalDTO retornoDTO = new PersonalDTO();
            PersonalDAO personalDAO = new PersonalDAO();
            
            dt = personalDAO.readxUnidad(personalDTO);

            foreach(DataRow row in dt.Rows)
            {
                retornoDTO.personalID = Convert.ToInt64(row["personalID"].ToString());
                retornoDTO.personaID = Convert.ToInt64(row["personaID"].ToString());

                if (retornoDTO.personaID != 0)
                {
                    
                    PersonaNEG personaNEG = new PersonaNEG();
                    PersonaDTO personaDTO = new PersonaDTO();

                    personaDTO.personaID = retornoDTO.personaID;
                    retornoDTO.persona = new PersonaDTO();
                    retornoDTO.persona = personaNEG.read(personaDTO);
                }

                retornoDTO.cargoID = Convert.ToInt64(row["cargoID"].ToString());
                retornoDTO.unidadID = Convert.ToInt64(row["unidadID"].ToString());
            }


            return retornoDTO;
        }

        public int delete(PersonalDTO personalDTO)
        {
            int retorno = 0;
            PersonalDAO personalDAO = new PersonalDAO();

            retorno = personalDAO.delete(personalDTO);

            return retorno;
        }

        public int create(PersonalDTO personalDTO)
        {
            int retorno = 0;
            PersonalDAO personalDAO = new PersonalDAO();

            retorno = personalDAO.create(personalDTO);

            return retorno;
        }
    }
}
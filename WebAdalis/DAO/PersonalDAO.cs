using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospOnline.DTO;
using System.Data;
using System.Data.SqlClient;

namespace HospOnline.DAO
{
    public class PersonalDAO
    {
        string connectionString = @"Server=UTERBRATENS-PC\SQLEXPRESS;Database=HospOnline;Trusted_Connection=True;";

        public int create(PersonalDTO personalDTO)
        {
            int retorno = 0;
            SqlConnection conn = new SqlConnection(connectionString);

            string sql = "INSERT INTO Personal (personaID, cargoID, unidadID) values(@personaID, @cargoID, @unidadID)";

            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@personaID", personalDTO.personaID);
            sqlcmd.Parameters.AddWithValue("@cargoID", personalDTO.cargoID);
            sqlcmd.Parameters.AddWithValue("@unidadID", personalDTO.unidadID);

            sqlcmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                retorno = sqlcmd.ExecuteNonQuery();
            }
            catch
            {
                retorno = 0;
            }
            finally
            {
                conn.Close();
            }

            return retorno;
        }

        public int actualizar(PersonalDTO personalDTO)
        {
            int retorno = 0;
            SqlConnection conn = new SqlConnection(connectionString);

            string sql = "UPDATE INTO Personal (personaID, cargoID, unidadID) values(@personaID, @cargoID, @unidadID)";

            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@personaID", personalDTO.personaID);
            sqlcmd.Parameters.AddWithValue("@cargoID", personalDTO.cargoID);
            sqlcmd.Parameters.AddWithValue("@unidadID", personalDTO.unidadID);

            sqlcmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                retorno = sqlcmd.ExecuteNonQuery();
            }
            catch
            {
                retorno = 0;
            }
            finally
            {
                conn.Close();
            }

            return retorno;
        }
        public DataTable read(PersonaDTO personaDTO)
        {
            DataTable dataTable = new DataTable();

            SqlConnection conn = new SqlConnection(connectionString);

            string sql = "select * from Personal where personalID = @personalID";

            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.Add(new SqlParameter("@personalID", SqlDbType.Int));

            sqlcmd.Parameters["@personalID"].Value = personaDTO.personaID;

            try
            {
                conn.Open();
                SqlDataReader rdr = sqlcmd.ExecuteReader();
                dataTable.Load(rdr);
                rdr.Close();
            }
            catch
            {
                dataTable = null;
            }
            finally
            {
                conn.Close();
            }
            return dataTable;


        }
        public DataTable readxUnidad(PersonalDTO personalDTO)
        {
            //List<ExamenDTO> retornoDTO = new List<ExamenDTO>();

            DataTable dataTable = new DataTable();

            SqlConnection conn = new SqlConnection(connectionString);

            string sql = "select * from Personal where unidadID = @unidadID and cargoID = 1";

            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.Add(new SqlParameter("@unidadID", SqlDbType.Int));

            sqlcmd.Parameters["@unidadID"].Value = personalDTO.unidadID;

            try
            {
                conn.Open();
                SqlDataReader rdr = sqlcmd.ExecuteReader();
                dataTable.Load(rdr);
                rdr.Close();
            }
            catch
            {
                dataTable = null;
            }
            finally
            {
                conn.Close();
            }
            return dataTable;


        }

        public PersonalDTO update(PersonalDTO personalDTO)
        {
            PersonalDTO retornoDTO = new PersonalDTO();

            return retornoDTO;
        }

        public int delete(PersonalDTO personalDTO)
        {
            int retorno = 0;

            string sql = "DELETE FROM Personal WHERE personalID=@personalID";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@personalID", personalDTO.personalID);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                retorno = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                retorno = 0;
            }
            finally
            {
                con.Close();
            }
            return retorno;
        }


        public List<PersonalDTO> readAll(PersonalDTO personalDTO)
        {
            List<PersonalDTO> listDTO = new List<PersonalDTO>();

            return listDTO;
        }
    }
}
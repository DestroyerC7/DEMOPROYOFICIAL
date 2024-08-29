using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DEMOPROY1.Models;


namespace DEMOPROY1.Controllers
{
    internal class DefensaExternaController
    {

        private SqlConnection conexion = new SqlConnection("server=LAPTOP-V980KNVQ\\SQLEXPRESS; database=DEMOPROY; integrated security=true");

        public DataTable ObtenerDefensaExterna()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT * FROM DEFENSA_EXTERNA";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener LA DEFENSA EXTERNA: " + ex.Message);
            }
            return dt;
        }
        public DataTable ObtenerTribunal()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT Id_Tribunal, PrimerNombre FROM TRIBUNAL";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el Tribunal: " + ex.Message);
            }
            return dt;
        }
        public DataTable ObtenerProyectos()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT Id_Proyecto, Titulo FROM PROYECTO";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el Proyecto: " + ex.Message);
            }
            return dt;
        }
        public DataTable ObtenerDefensaInterna()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT Id_Proyecto FROM DEFENSA_INTERNA";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el Proyecto: " + ex.Message);
            }
            return dt;
        }
        public void CreateDefensaExterna(DefensaExterna defensaExterna)
        {

            {
                conexion.Open();
                string query = "INSERT INTO DEFENSA_EXTERNA (FechaDefensaExterna, AProbado, Calficacion, Id_Tribunal1, Id_Tribunal2, Id_Tribunal3, Id_Tribunal4, Id_Tribunal5, Id_Proyecto, Id_DefensaInterna) " +
                               "VALUES (@FechaDefensaExterna, @Aprobado, @Calficacion, @Id_Tribunal1, @Id_Tribunal2, @Id_Tribunal3, @Id_Tribunal4, @Id_Tribunal5, @Id_Proyecto, @Id_DefensaInterna)";
                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@FechaDefensaExterna", defensaExterna.FechaDefensaExterna);
                cmd.Parameters.AddWithValue("@Aprobado", defensaExterna.AProbado);
                cmd.Parameters.AddWithValue("@Calficacion", defensaExterna.Calficacion);
                cmd.Parameters.AddWithValue("@Id_Tribunal1", defensaExterna.Id_Tribunal1);
                cmd.Parameters.AddWithValue("@Id_Tribunal2", defensaExterna.Id_Tribunal2);
                cmd.Parameters.AddWithValue("@Id_Tribunal3", defensaExterna.Id_Tribunal3);
                cmd.Parameters.AddWithValue("@Id_Tribunal4", defensaExterna.Id_Tribunal4);
                cmd.Parameters.AddWithValue("@Id_Tribunal5", defensaExterna.Id_Tribunal5);
                cmd.Parameters.AddWithValue("@Id_Proyecto", defensaExterna.Id_Proyecto);
                cmd.Parameters.AddWithValue("@Id_DefensaInterna", defensaExterna.Id_DefensaInterna);

                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        // Método para actualizar una DEFENSA_INTERNA existente
        public void UpdateDefensaExterna(DefensaExterna defensaExterna)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE DefensaExterna SET FechaDefensaExterna = @FechaDefensaExterna, AProbado = @AProbado, Calficacion = @Calficacion, " +
                               "Id_Tribunal1 = @Id_Tribunal1, Id_Tribunal2 = @Id_Tribunal2, Id_Tribunal3 = @Id_Tribunal3, " +
                               "Id_Tribunal4 = @Id_Tribunal4, Id_Tribunal5 = @Id_Tribunal5, Id_Proyecto = @Id_Proyecto, " +
                               "Id_DefensaInterna = @Id_DefensaInterna WHERE Id_DefensaExterna = @Id_DefensaExterna";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@FechaDefensaExterna", defensaExterna.FechaDefensaExterna);
                cmd.Parameters.AddWithValue("@AProbado", defensaExterna.AProbado);
                cmd.Parameters.AddWithValue("@Calficacion", defensaExterna.Calficacion);
                cmd.Parameters.AddWithValue("@Id_Tribunal1", defensaExterna.Id_Tribunal1);
                cmd.Parameters.AddWithValue("@Id_Tribunal2", defensaExterna.Id_Tribunal2);
                cmd.Parameters.AddWithValue("@Id_Tribunal3", defensaExterna.Id_Tribunal3);
                cmd.Parameters.AddWithValue("@Id_Tribunal4", defensaExterna.Id_Tribunal4);
                cmd.Parameters.AddWithValue("@Id_Tribunal5", defensaExterna.Id_Tribunal5);
                cmd.Parameters.AddWithValue("@Id_Proyecto", defensaExterna.Id_Proyecto);
                cmd.Parameters.AddWithValue("@Id_DefensaInterna", defensaExterna.Id_DefensaInterna);
                cmd.Parameters.AddWithValue("@Id_DefensaExterna", defensaExterna.Id_DefensaExterna);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }


        // Método para eliminar una DEFENSA_INTERNA
        public void DeleteDefensaExterna(int idDefensaExterna)
        {
            try
            {
                conexion.Open();
                string query = "DELETE FROM DefensaExterna WHERE Id_DefensaExterna = @Id_DefensaExterna";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id_DefensaExterna", idDefensaExterna);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }


        // Método para obtener los nombres de los tribunales (por PrimerNombre)
        public DefensaExterna GetDefensaExternaById(int idDefensaExterna)
        {
            DefensaExterna defensaExterna = null;

            try
            {
                conexion.Open();
                string query = "SELECT * FROM DefensaExterna WHERE Id_DefensaExterna = @Id_DefensaExterna";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id_DefensaExterna", idDefensaExterna);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    defensaExterna = new DefensaExterna
                    {
                        Id_DefensaExterna = (int)reader["Id_DefensaExterna"],
                        FechaDefensaExterna = (DateTime)reader["FechaDefensaExterna"],
                        AProbado = (bool)reader["AProbado"],
                        Calficacion = (int)reader["Calficacion"],
                        Id_Tribunal1 = (int)reader["Id_Tribunal1"],
                        Id_Tribunal2 = (int)reader["Id_Tribunal2"],
                        Id_Tribunal3 = (int)reader["Id_Tribunal3"],
                        Id_Tribunal4 = (int)reader["Id_Tribunal4"],
                        Id_Tribunal5 = (int)reader["Id_Tribunal5"],
                        Id_Proyecto = (int)reader["Id_Proyecto"],
                        Id_DefensaInterna = (int)reader["Id_DefensaInterna"]
                    };
                }

                reader.Close();
            }
            finally
            {
                conexion.Close();
            }

            return defensaExterna;
        }


    }

}

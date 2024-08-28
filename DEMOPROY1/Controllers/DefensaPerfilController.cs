using DEMOPROY1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DEMOPROY1.Controllers
{
    public class DefensaPerfilController
    {
        private SqlConnection conexion = new SqlConnection("server=DESTROYER; database=DEMOPROY; Integrated Security=True; TrustServerCertificate=True;");

        // Método para agregar una defensa de perfil
        public void AgregarDefensaPerfil(DefensaPerfil defensaPerfil)
        {
            
                conexion.Open();
                string query = "INSERT INTO DEFENSA_PERFIL (FechaDefensa, ESTADOPERFIL, Calificacion, ID_DocenteMDG1, ID_Tribunal1, ID_Postulante, ID_Perfil) " +
                               "VALUES (@FechaDefensa, @ESTADOPERFIL, @Calificacion, @ID_DocenteMDG1, @ID_Tribunal1, @ID_Postulante, @ID_Perfil)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@FechaDefensa", defensaPerfil.FechaDefensa);
                    cmd.Parameters.AddWithValue("@ESTADOPERFIL", defensaPerfil.EstadoPerfil);
                    cmd.Parameters.AddWithValue("@Calificacion", defensaPerfil.Calficacion);
                    cmd.Parameters.AddWithValue("@ID_DocenteMDG1", defensaPerfil.ID_DocenteMDG1);
                    cmd.Parameters.AddWithValue("@ID_Tribunal1", defensaPerfil.ID_Tribunal1);
                    cmd.Parameters.AddWithValue("@ID_Postulante", defensaPerfil.ID_Postulante);
                    cmd.Parameters.AddWithValue("@ID_Perfil", defensaPerfil.ID_Perfil);

                    cmd.ExecuteNonQuery();
                }
            
        }

        // Método para obtener todas las defensas de perfil
        public List<DefensaPerfil> ObtenerDefensasPerfil()
        {
            List<DefensaPerfil> defensasPerfil = new List<DefensaPerfil>();

            
                conexion.Open();
                string query = "SELECT * FROM DEFENSA_PERFIL";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DefensaPerfil defensaPerfil = new DefensaPerfil
                        {
                            FechaDefensa = (DateTime)reader["FechaDefensa"],
                            EstadoPerfil = (bool)reader["ESTADOPERFIL"],
                            Calficacion = (int)reader["Calificacion"],
                            ID_DocenteMDG1 = (int)reader["ID_DocenteMDG1"],
                            ID_Tribunal1 = (int)reader["ID_Tribunal1"],
                            ID_Postulante = (int)reader["ID_Postulante"],
                            ID_Perfil = (int)reader["ID_Perfil"]
                        };
                        defensasPerfil.Add(defensaPerfil);
                    }
                }
            

            return defensasPerfil;
        }

        // Método para actualizar una defensa de perfil
        public void ActualizarDefensaPerfil(DefensaPerfil defensaPerfil)
        {
            
                conexion.Open();
                string query = "UPDATE DEFENSA_PERFIL SET FechaDefensa = @FechaDefensa, ESTADOPERFIL = @ESTADOPERFIL, Calificacion = @Calificacion, " +
                               "ID_DocenteMDG1 = @ID_DocenteMDG1, ID_Tribunal1 = @ID_Tribunal1, ID_Postulante = @ID_Postulante, ID_Perfil = @ID_Perfil " +
                               "WHERE ID_DocenteMDG1 = @ID_DocenteMDG1 AND ID_Tribunal1 = @ID_Tribunal1 AND ID_Postulante = @ID_Postulante AND ID_Perfil = @ID_Perfil";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@FechaDefensa", defensaPerfil.FechaDefensa);
                    cmd.Parameters.AddWithValue("@ESTADOPERFIL", defensaPerfil.EstadoPerfil);
                    cmd.Parameters.AddWithValue("@Calificacion", defensaPerfil.Calficacion);
                    cmd.Parameters.AddWithValue("@ID_DocenteMDG1", defensaPerfil.ID_DocenteMDG1);
                    cmd.Parameters.AddWithValue("@ID_Tribunal1", defensaPerfil.ID_Tribunal1);
                    cmd.Parameters.AddWithValue("@ID_Postulante", defensaPerfil.ID_Postulante);
                    cmd.Parameters.AddWithValue("@ID_Perfil", defensaPerfil.ID_Perfil);

                    cmd.ExecuteNonQuery();
                }
            
        }

        // Método para eliminar una defensa de perfil
        public void EliminarDefensaPerfil(int idDocente, int idTribunal, int idPostulante, int idPerfil)
        {
            
                conexion.Open();
                string query = "DELETE FROM DEFENSA_PERFIL WHERE ID_DocenteMDG1 = @ID_DocenteMDG1 AND ID_Tribunal1 = @ID_Tribunal1 AND ID_Postulante = @ID_Postulante AND ID_Perfil = @ID_Perfil";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@ID_DocenteMDG1", idDocente);
                    cmd.Parameters.AddWithValue("@ID_Tribunal1", idTribunal);
                    cmd.Parameters.AddWithValue("@ID_Postulante", idPostulante);
                    cmd.Parameters.AddWithValue("@ID_Perfil", idPerfil);

                    cmd.ExecuteNonQuery();
                }
            
        }

        // Método para obtener una defensa de perfil por sus IDs
        public DefensaPerfil ObtenerDefensaPerfilPorIds(int idDocente, int idTribunal, int idPostulante, int idPerfil)
        {
            DefensaPerfil defensaPerfil = null;

            
                conexion.Open();
                string query = "SELECT * FROM DEFENSA_PERFIL WHERE ID_DocenteMDG1 = @ID_DocenteMDG1 AND ID_Tribunal1 = @ID_Tribunal1 AND ID_Postulante = @ID_Postulante AND ID_Perfil = @ID_Perfil";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@ID_DocenteMDG1", idDocente);
                    cmd.Parameters.AddWithValue("@ID_Tribunal1", idTribunal);
                    cmd.Parameters.AddWithValue("@ID_Postulante", idPostulante);
                    cmd.Parameters.AddWithValue("@ID_Perfil", idPerfil);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            defensaPerfil = new DefensaPerfil
                            {
                                FechaDefensa = (DateTime)reader["FechaDefensa"],
                                EstadoPerfil = (bool)reader["ESTADOPERFIL"],
                                Calficacion = (int)reader["Calificacion"],
                                ID_DocenteMDG1 = (int)reader["ID_DocenteMDG1"],
                                ID_Tribunal1 = (int)reader["ID_Tribunal1"],
                                ID_Postulante = (int)reader["ID_Postulante"],
                                ID_Perfil = (int)reader["ID_Perfil"]
                            };
                        }
                    }
                }
            

            return defensaPerfil;
        }
    }

}

﻿using DEMOPROY1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace DEMOPROY1.Controllers
{

    internal class DefensaInternaController
    {


        private SqlConnection conexion = new SqlConnection("server=LAPTOP-V980KNVQ\\SQLEXPRESS; database=DEMOPROY; integrated security=true");


        public DataTable ObtenerDefensas()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT * FROM DEFENSA_INTERNA";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las Defensas: " + ex.Message);
            }
            return dt;
        }
        public DataTable ObtenerTribunal()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = @"
            SELECT 
                DI.Id_DefensaInterna,
                T1.PrimerNombre AS Tribunal1_PrimerNombre,
                T1.PrimerApellido AS Tribunal1_PrimerApellido,
                T2.PrimerNombre AS Tribunal2_PrimerNombre,
                T2.PrimerApellido AS Tribunal2_PrimerApellido
            FROM 
                DEFENSA_INTERNA DI
            INNER JOIN 
                TRIBUNAL T1 ON DI.Id_Tribunal1 = T1.Id_Tribunal
            INNER JOIN 
                TRIBUNAL T2 ON DI.Id_Tribunal2 = T2.Id_Tribunal";

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
        public void CreateDefensaInterna(DefensaInterna defensa)
        {
            
            {
                conexion.Open();
                string query = "INSERT INTO DEFENSA_INTERNA (FechaDefensaInterna, Observaciones, Aprobada, Calficacion, Id_Tribunal1, Id_Tribunal2, Id_Proyecto) " +
                               "VALUES (@FechaDefensaInterna, @Observaciones, @Aprobada, @Calficacion, @Id_Tribunal1, @Id_Tribunal2, @Id_Proyecto)";
                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@FechaDefensaInterna", defensa.FechaDefensaInterna);
                cmd.Parameters.AddWithValue("@Observaciones", defensa.Observaciones);
                cmd.Parameters.AddWithValue("@Aprobada", defensa.Aprobada);
                cmd.Parameters.AddWithValue("@Calficacion", defensa.Calficacion);
                cmd.Parameters.AddWithValue("@Id_Tribunal1", defensa.Id_Tribunal1);
                cmd.Parameters.AddWithValue("@Id_Tribunal2", defensa.Id_Tribunal2);
                cmd.Parameters.AddWithValue("@Id_Proyecto", defensa.Id_Proyecto);

                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        // Método para actualizar una DEFENSA_INTERNA existente
        public void UpdateDefensaInterna(DefensaInterna defensa)
        {
            
            {
                conexion.Open();
                string query = "UPDATE DEFENSA_INTERNA SET FechaDefensaInterna = @FechaDefensaInterna, Observaciones = @Observaciones, " +
                               "Aprobada = @Aprobada, Calficacion = @Calficacion, Id_Tribunal1 = @Id_Tribunal1, Id_Tribunal2 = @Id_Tribunal2, " +
                               "Id_Proyecto = @Id_Proyecto WHERE Id_DefensaInterna = @Id_DefensaInterna";
                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@FechaDefensaInterna", defensa.FechaDefensaInterna);
                cmd.Parameters.AddWithValue("@Observaciones", defensa.Observaciones);
                cmd.Parameters.AddWithValue("@Aprobada", defensa.Aprobada);
                cmd.Parameters.AddWithValue("@Calficacion", defensa.Calficacion);
                cmd.Parameters.AddWithValue("@Id_Tribunal1", defensa.Id_Tribunal1);
                cmd.Parameters.AddWithValue("@Id_Tribunal2", defensa.Id_Tribunal2);
                cmd.Parameters.AddWithValue("@Id_Proyecto", defensa.Id_Proyecto);
                cmd.Parameters.AddWithValue("@Id_DefensaInterna", defensa.Id_DefensaInterna);

                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        // Método para eliminar una DEFENSA_INTERNA
        public void DeleteDefensaInterna(int id)
        {
            try
            
            {
                conexion.Open();
                string query = "DELETE FROM DEFENSA_INTERNA WHERE Id_DefensaInterna = @Id_DefensaInterna";
                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@Id_DefensaInterna", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar La Defensa: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        // Método para obtener los nombres de los tribunales (por PrimerNombre)
        public string GetTribunalName(int id)
        {
            string tribunalName = "";
         
            {
                conexion.Open();
                string query = "SELECT PrimerNombre FROM TRIBUNAL WHERE Id_Tribunal = @Id_Tribunal";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id_Tribunal", id);

                tribunalName = cmd.ExecuteScalar().ToString();
                conexion.Close();
            }
            return tribunalName;
            
        }

        // Método para obtener el código del estudiante (por el Código_Estudiante del Proyecto)
        public DefensaInterna GetDefensaInternaPorCodigoEstudiante(int codigoEstudiante)
        {
            DefensaInterna defensaInterna = null;
            
            {
                conexion.Open();
                string query = "SELECT * FROM DEFENSA_INTERNA WHERE Codigo_Estudiante = @CodigoEstudiante";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@CodigoEstudiante", codigoEstudiante);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        defensaInterna = new DefensaInterna
                        {
                            FechaDefensaInterna = Convert.ToDateTime(reader["FechaDefensaInterna"]),
                            Observaciones = Convert.ToBoolean(reader["Observaciones"]),
                            Aprobada = Convert.ToBoolean(reader["Aprobada"]),
                            Calficacion = Convert.ToInt32(reader["Calficacion"]),
                            Id_Tribunal1 = Convert.ToInt32(reader["Id_Tribunal1"]),
                            Id_Tribunal2 = Convert.ToInt32(reader["Id_Tribunal2"]),
                            Id_Proyecto = Convert.ToInt32(reader["Id_Proyecto"])
                        };
                    }
                }
            }
            return defensaInterna;
        }
        public int GetCodigoEstudiante(int idProyecto)
        {
            int codigoEstudiante = 0;
            
            {
                conexion.Open();
                string query = "SELECT Codigo_Estudiante FROM PROYECTO WHERE Id_Proyecto = @Id_Proyecto";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id_Proyecto", idProyecto);

                codigoEstudiante = (int)cmd.ExecuteScalar();
            }
            return codigoEstudiante;
        }

    }
}

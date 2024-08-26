using DEMOPROY1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOPROY1.Controllers
{   

    internal class DefensaInternaController
    {
        private SqlConnection conexion = new SqlConnection("server=LAPTOP-V980KNVQ\\SQLEXPRESS; database=DEMOPROY; integrated security=true");

        public DataTable ObtenerDefensasInternas()
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
                throw new Exception("Error al obtener las defensas internas: " + ex.Message);
            }
            return dt;
        }

        // Método para crear una nueva defensa interna
        public void CrearDefensaInterna(DefensaInterna defensaInterna)
        {
            try
            {
                conexion.Open();
                string query = "INSERT INTO DEFENSA_INTERNA (FechaDefensaInterna, Observaciones, Aprobada, Calficacion, Id_Tribunal1, Id_Tribunal2, Id_Proyecto) " +
                               "VALUES (@FechaDefensaInterna, @Observaciones, @Aprobada, @Calficacion, @Id_Tribunal1, @Id_Tribunal2, @Id_Proyecto)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@FechaDefensaInterna", defensaInterna.FechaDefensaInterna);
                cmd.Parameters.AddWithValue("@Observaciones", defensaInterna.Observaciones);
                cmd.Parameters.AddWithValue("@Aprobada", defensaInterna.Aprobada);
                cmd.Parameters.AddWithValue("@Calficacion", defensaInterna.Calficacion);
                cmd.Parameters.AddWithValue("@Id_Tribunal1", defensaInterna.Id_Tribunal1);
                cmd.Parameters.AddWithValue("@Id_Tribunal2", defensaInterna.Id_Tribunal2);
                cmd.Parameters.AddWithValue("@Id_Proyecto", defensaInterna.Id_Proyecto);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la defensa interna: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        // Método para editar una defensa interna existente
        public void EditarDefensaInterna(DefensaInterna defensaInterna)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE DEFENSA_INTERNA SET FechaDefensaInterna = @FechaDefensaInterna, Observaciones = @Observaciones, Aprobada = @Aprobada, " +
                               "Calficacion = @Calficacion, Id_Tribunal1 = @Id_Tribunal1, Id_Tribunal2 = @Id_Tribunal2, Id_Proyecto = @Id_Proyecto " +
                               "WHERE Id_DefensaInterna = @Id_DefensaInterna";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@FechaDefensaInterna", defensaInterna.FechaDefensaInterna);
                cmd.Parameters.AddWithValue("@Observaciones", defensaInterna.Observaciones);
                cmd.Parameters.AddWithValue("@Aprobada", defensaInterna.Aprobada);
                cmd.Parameters.AddWithValue("@Calficacion", defensaInterna.Calficacion);
                cmd.Parameters.AddWithValue("@Id_Tribunal1", defensaInterna.Id_Tribunal1);
                cmd.Parameters.AddWithValue("@Id_Tribunal2", defensaInterna.Id_Tribunal2);
                cmd.Parameters.AddWithValue("@Id_Proyecto", defensaInterna.Id_Proyecto);
                cmd.Parameters.AddWithValue("@Id_DefensaInterna", defensaInterna.Id_DefensaInterna);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar la defensa interna: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        // Método para eliminar una defensa interna
        public void EliminarDefensaInterna(int idDefensaInterna)
        {
            try
            {
                conexion.Open();
                string query = "DELETE FROM DEFENSA_INTERNA WHERE Id_DefensaInterna = @Id_DefensaInterna";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id_DefensaInterna", idDefensaInterna);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la defensa interna: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        // Método para buscar una defensa interna por ID
        public DataTable BuscarDefensaInternaPorId(int idDefensaInterna)
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT * FROM DEFENSA_INTERNA WHERE Id_DefensaInterna = @Id_DefensaInterna";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Id_DefensaInterna", idDefensaInterna);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la defensa interna: " + ex.Message);
            }
            return dt;
        }
    }
}

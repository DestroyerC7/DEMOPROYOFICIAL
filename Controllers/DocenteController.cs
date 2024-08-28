using DEMOPROY1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace _26_08_2024.Controladores
{
    public class DocenteController
    {
        private SqlConnection conexion = new SqlConnection("server=DESTROYER; database=DEMOPROY; Integrated Security=True; TrustServerCertificate=True;");

        // Método para agregar un docente
        public void AgregarDocente(Docente docente)
        {
            
                conexion.Open();
                string query = "INSERT INTO DOCENTE (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Email, Id_Titulo) " +
                               "VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Email, @Id_Titulo)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@PrimerNombre", docente.PrimerNombre);
                    cmd.Parameters.AddWithValue("@SegundoNombre", (object)docente.SegundoNombre ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrimerApellido", docente.PrimerApellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido", (object)docente.SegundoApellido ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", docente.Email);
                    cmd.Parameters.AddWithValue("@Id_Titulo", docente.Id_Titulo);

                    cmd.ExecuteNonQuery();
                }
            conexion.Close();
        }

        // Método para obtener todos los docentes
        public List<Docente> ObtenerDocentes()
        {
            List<Docente> docentes = new List<Docente>();

            
                conexion.Open();
                string query = "SELECT * FROM DOCENTE";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Docente docente = new Docente
                        {
                            Id_Docente = (int)reader["Id_Docente"],
                            PrimerNombre = (string)reader["PrimerNombre"],
                            SegundoNombre = reader["SegundoNombre"] as string,
                            PrimerApellido = (string)reader["PrimerApellido"],
                            SegundoApellido = reader["SegundoApellido"] as string,
                            Email = (string)reader["Email"],
                            Id_Titulo = (int)reader["Id_Titulo"]
                        };
                        docentes.Add(docente);
                    }
               }

            conexion.Close();
            return docentes;
        }

        // Método para actualizar un docente
        public void ActualizarDocente(Docente docente)
        {
            
                conexion.Open();
                string query = "UPDATE DOCENTE SET PrimerNombre = @PrimerNombre, SegundoNombre = @SegundoNombre, " +
                               "PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, Email = @Email, " +
                               "Id_Titulo = @Id_Titulo WHERE Id_Docente = @Id_Docente";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Id_Docente", docente.Id_Docente);
                    cmd.Parameters.AddWithValue("@PrimerNombre", docente.PrimerNombre);
                    cmd.Parameters.AddWithValue("@SegundoNombre", (object)docente.SegundoNombre ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrimerApellido", docente.PrimerApellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido", (object)docente.SegundoApellido ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", docente.Email);
                    cmd.Parameters.AddWithValue("@Id_Titulo", docente.Id_Titulo);

                    cmd.ExecuteNonQuery();
                }
            conexion.Close();
        }

        // Método para eliminar un docente
        public void EliminarDocente(int id)
        {
            
                conexion.Open();
                string query = "DELETE FROM DOCENTE WHERE Id_Docente = @Id_Docente";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Id_Docente", id);
                    cmd.ExecuteNonQuery();
                }
            conexion.Close();
        }

        // Método para obtener un docente por su ID
        public Docente ObtenerDocentePorId(int id)
        {
            Docente docente = null;

            
                conexion.Open();
                string query = "SELECT * FROM DOCENTE WHERE Id_Docente = @Id_Docente";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Id_Docente", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            docente = new Docente
                            {
                                Id_Docente = (int)reader["Id_Docente"],
                                PrimerNombre = (string)reader["PrimerNombre"],
                                SegundoNombre = reader["SegundoNombre"] as string,
                                PrimerApellido = (string)reader["PrimerApellido"],
                                SegundoApellido = reader["SegundoApellido"] as string,
                                Email = (string)reader["Email"],
                                Id_Titulo = (int)reader["Id_Titulo"]
                            };
                        }
                    }
                }
            conexion.Close();

            return docente;
        }
        public DataTable ObtenerTitulo()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT id_titulo , nivel_academico FROM TITULO_PROFESIONAL";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el titulo: " + ex.Message);
            }
            return dt;
        }
    }
}

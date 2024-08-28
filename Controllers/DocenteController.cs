using DEMOPROY1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace _26_08_2024.Controladores
{
    public class DocenteController
    {
        private string connectionString = "server=DESTROYER; database=DEMOPROY; Integrated Security=True; TrustServerCertificate=True;"; // Reemplaza esto con tu cadena de conexión a la base de datos

        // Método para agregar un docente
        public void AgregarDocente(Docente docente)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO DOCENTE (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Email, Id_Titulo) " +
                               "VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Email, @Id_Titulo)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PrimerNombre", docente.PrimerNombre);
                    cmd.Parameters.AddWithValue("@SegundoNombre", (object)docente.SegundoNombre ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrimerApellido", docente.PrimerApellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido", (object)docente.SegundoApellido ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", docente.Email);
                    cmd.Parameters.AddWithValue("@Id_Titulo", docente.Id_Titulo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener todos los docentes
        public List<Docente> ObtenerDocentes()
        {
            List<Docente> docentes = new List<Docente>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM DOCENTE";

                using (SqlCommand cmd = new SqlCommand(query, conn))
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
            }

            return docentes;
        }

        // Método para actualizar un docente
        public void ActualizarDocente(Docente docente)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE DOCENTE SET PrimerNombre = @PrimerNombre, SegundoNombre = @SegundoNombre, " +
                               "PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, Email = @Email, " +
                               "Id_Titulo = @Id_Titulo WHERE Id_Docente = @Id_Docente";

                using (SqlCommand cmd = new SqlCommand(query, conn))
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
            }
        }

        // Método para eliminar un docente
        public void EliminarDocente(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM DOCENTE WHERE Id_Docente = @Id_Docente";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_Docente", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener un docente por su ID
        public Docente ObtenerDocentePorId(int id)
        {
            Docente docente = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM DOCENTE WHERE Id_Docente = @Id_Docente";

                using (SqlCommand cmd = new SqlCommand(query, conn))
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
            }

            return docente;
        }
    }
}

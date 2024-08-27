using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _25_08_2024.Modelos;
using Microsoft.Data.SqlClient;

namespace _25_08_2024.Controladores
{
    public class TribunalController
    {
        private string connectionString = "server=DESTROYER; database=DEMOPROY; Integrated Security=True; TrustServerCertificate=True;"; // Reemplaza esto con tu cadena de conexión a la base de datos

        // Método para agregar un tribunal
        public void AgregarTribunal(Tribunal tribunal)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO TRIBUNAL (PrimerNombreT, SegundoNombreT, PrimerApellidoT, SegundoApellidoT, Tipo, Institucion, Id_titulo) " +
                               "VALUES (@PrimerNombreT, @SegundoNombreT, @PrimerApellidoT, @SegundoApellidoT, @Tipo, @Institucion, @Id_titulo)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PrimerNombreT", tribunal.PrimerNombreT);
                    cmd.Parameters.AddWithValue("@SegundoNombreT", (object)tribunal.SegundoNombreT ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrimerApellidoT", tribunal.PrimerApellidoT);
                    cmd.Parameters.AddWithValue("@SegundoApellidoT", (object)tribunal.SegundoApellidoT ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Tipo", tribunal.Tipo);
                    cmd.Parameters.AddWithValue("@Institucion", tribunal.Institucion);
                    cmd.Parameters.AddWithValue("@Id_titulo", tribunal.Id_titulo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener todos los tribunales
        public List<Tribunal> ObtenerTribunales()
        {
            List<Tribunal> tribunales = new List<Tribunal>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM TRIBUNAL";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tribunal tribunal = new Tribunal
                        {
                            Id_Tribunal = (int)reader["Id_Tribunal"],
                            PrimerNombreT = (string)reader["PrimerNombreT"],
                            SegundoNombreT = reader["SegundoNombreT"] as string,
                            PrimerApellidoT = (string)reader["PrimerApellidoT"],
                            SegundoApellidoT = reader["SegundoApellidoT"] as string,
                            Tipo = (string)reader["Tipo"],
                            Institucion = (string)reader["Institucion"],
                            Id_titulo = (int)reader["Id_titulo"]
                        };
                        tribunales.Add(tribunal);
                    }
                }
            }

            return tribunales;
        }

        // Método para actualizar un tribunal
        public void ActualizarTribunal(Tribunal tribunal)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE TRIBUNAL SET PrimerNombreT = @PrimerNombreT, SegundoNombreT = @SegundoNombreT, " +
                               "PrimerApellidoT = @PrimerApellidoT, SegundoApellidoT = @SegundoApellidoT, Tipo = @Tipo, " +
                               "Institucion = @Institucion, Id_titulo = @Id_titulo WHERE Id_Tribunal = @Id_Tribunal";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_Tribunal", tribunal.Id_Tribunal);
                    cmd.Parameters.AddWithValue("@PrimerNombreT", tribunal.PrimerNombreT);
                    cmd.Parameters.AddWithValue("@SegundoNombreT", (object)tribunal.SegundoNombreT ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrimerApellidoT", tribunal.PrimerApellidoT);
                    cmd.Parameters.AddWithValue("@SegundoApellidoT", (object)tribunal.SegundoApellidoT ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Tipo", tribunal.Tipo);
                    cmd.Parameters.AddWithValue("@Institucion", tribunal.Institucion);
                    cmd.Parameters.AddWithValue("@Id_titulo", tribunal.Id_titulo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un tribunal
        public void EliminarTribunal(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM TRIBUNAL WHERE Id_Tribunal = @Id_Tribunal";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_Tribunal", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener un tribunal por su ID
        public Tribunal ObtenerTribunalPorId(int id)
        {
            Tribunal tribunal = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM TRIBUNAL WHERE Id_Tribunal = @Id_Tribunal";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_Tribunal", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tribunal = new Tribunal
                            {
                                Id_Tribunal = (int)reader["Id_Tribunal"],
                                PrimerNombreT = (string)reader["PrimerNombreT"],
                                SegundoNombreT = reader["SegundoNombreT"] as string,
                                PrimerApellidoT = (string)reader["PrimerApellidoT"],
                                SegundoApellidoT = reader["SegundoApellidoT"] as string,
                                Tipo = (string)reader["Tipo"],
                                Institucion = (string)reader["Institucion"],
                                Id_titulo = (int)reader["Id_titulo"]
                            };
                        }
                    }
                }
            }

            return tribunal;
        }
    }

}

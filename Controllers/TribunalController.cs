using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEMOPROY1.Models;
using Microsoft.Data.SqlClient;

namespace DEMOPROY1.Controllers
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
                string query = "INSERT INTO TRIBUNAL (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Tipo, Institucion, Id_titulo) " +
                               "VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Tipo, @Institucion, @Id_titulo)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PrimerNombre", tribunal.PrimerNombre);
                    cmd.Parameters.AddWithValue("@SegundoNombre", (object)tribunal.SegundoNombre ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrimerApellido", tribunal.PrimerApellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido", (object)tribunal.SegundoApellido ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Tipo", tribunal.Tipo);
                    cmd.Parameters.AddWithValue("@Institucion", tribunal.Institucion);
                    cmd.Parameters.AddWithValue("@Id_Titulo", tribunal.Id_Titulo);

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
                            PrimerNombre = (string)reader["PrimerNombre"],
                            SegundoNombre = reader["SegundoNombre"] as string,
                            PrimerApellido = (string)reader["PrimerApellido"],
                            SegundoApellido = reader["SegundoApellido"] as string,
                            Tipo = (string)reader["Tipo"],
                            Institucion = (string)reader["Institucion"],
                            Id_Titulo = (int)reader["Id_Titulo"]
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
                string query = "UPDATE TRIBUNAL SET PrimerNombre = @PrimerNombre, SegundoNombre = @SegundoNombre, " +
                               "PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, Tipo = @Tipo, " +
                               "Institucion = @Institucion, Id_titulo = @Id_titulo WHERE Id_Tribunal = @Id_Tribunal";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_Tribunal", tribunal.Id_Tribunal);
                    cmd.Parameters.AddWithValue("@PrimerNombre", tribunal.PrimerNombre);
                    cmd.Parameters.AddWithValue("@SegundoNombre", (object)tribunal.SegundoNombre ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrimerApellido", tribunal.PrimerApellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido", (object)tribunal.SegundoApellido ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Tipo", tribunal.Tipo);
                    cmd.Parameters.AddWithValue("@Institucion", tribunal.Institucion);
                    cmd.Parameters.AddWithValue("@Id_Titulo", tribunal.Id_Titulo);

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
                                PrimerNombre = (string)reader["PrimerNombre"],
                                SegundoNombre = reader["SegundoNombre"] as string,
                                PrimerApellido = (string)reader["PrimerApellido"],
                                SegundoApellido = reader["SegundoApellido"] as string,
                                Tipo = (string)reader["Tipo"],
                                Institucion = (string)reader["Institucion"],
                                Id_Titulo = (int)reader["Id_Titulo"]
                            };
                        }
                    }
                }
            }

            return tribunal;
        }
        /*
        public DataTable CargarCombo()
        {
            //using (SqlConnection conn = new SqlConnection(connectionString))
            SqlDataAdapter da = new SqlDataAdapter("SP_CARGARCOMBOBOX",connectionString.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ObtenerDocente()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT Id_Docente , PrimerNombre FROM DOCENTE";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el docente: " + ex.Message);
            }
            return dt;
        }*/
    }

}

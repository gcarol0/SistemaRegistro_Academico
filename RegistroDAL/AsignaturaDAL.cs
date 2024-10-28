using RegistroBOL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDAL
{
    public class AsignaturaDAL
    {
        private string connectionString = ""; //Reemplaza con tu cadena de conexión aquí

        public bool Guardar(AsignaturaBOL asignatura)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO Asignaturas (NomAsignatura, Creditos) VALUES (@NomAsignatura, @Creditos)";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@NomAsignatura", asignatura.NomAsignatura);
                        cmd.Parameters.AddWithValue("@Creditos", asignatura.Creditos);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar la asignatura: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Modificar(AsignaturaBOL asignatura)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "UPDATE Asignaturas SET NomAsignatura = @NomAsignatura, Creditos = @Creditos WHERE CodAsignatura = @CodAsignatura";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@NomAsignatura", asignatura.NomAsignatura);
                        cmd.Parameters.AddWithValue("@Creditos", asignatura.Creditos);
                        cmd.Parameters.AddWithValue("@CodAsignatura", asignatura.CodAsignatura);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al modificar la asignatura: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Eliminar(int codAsignatura)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "DELETE FROM Asignaturas WHERE CodAsignatura = @CodAsignatura";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@CodAsignatura", codAsignatura);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar la asignatura: " + ex.Message);
                    return false;
                }
            }
        }

        public AsignaturaBOL SeleccionarPorID(int codAsignatura)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT CodAsignatura, NomAsignatura, Creditos FROM Asignaturas WHERE CodAsignatura = @CodAsignatura";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@CodAsignatura", codAsignatura);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                AsignaturaBOL asignatura = new AsignaturaBOL
                                {
                                    CodAsignatura = reader.GetInt32(reader.GetOrdinal("CodAsignatura")),
                                    NomAsignatura = reader.GetString(reader.GetOrdinal("NomAsignatura")),
                                    Creditos = reader.GetInt32(reader.GetOrdinal("Creditos"))
                                };
                                return asignatura;
                            }
                            else
                            {
                                return null; // No se encontró ningún registro
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al seleccionar la asignatura: " + ex.Message);
                    return null;
                }
            }
        }

        public List<AsignaturaBOL> ObtenerAsignaturas()
        {
            List<AsignaturaBOL> lista = new List<AsignaturaBOL>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Asignaturas";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AsignaturaBOL asignatura = new AsignaturaBOL
                                {
                                    CodAsignatura = Convert.ToInt32(reader["CodAsignatura"]),
                                    NomAsignatura = reader["NomAsignatura"].ToString(),
                                    Creditos = Convert.ToInt32(reader["Creditos"])
                                };
                                lista.Add(asignatura);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener las asignaturas: " + ex.Message);
                }
            }
            return lista;
        }
    }
}

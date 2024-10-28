using RegistroBOL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDAL
{
    public class AlumnoDAL
    {
        private string connectionString = ""; // Reemplaza con tu cadena de conexión

        // Asume que tienes una clase Alumno con las propiedades adecuadas
        public bool Guardar(AlumnoBOL alumno)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO Alumnos (Nombre, ApellidoPat, ApellidoMat, Email, NumMatricula) VALUES (@Nombre, @ApellidoPat, @ApellidoMat, @Email, @NumMatricula)";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        // Agregar los valores de los parámetros de la instancia de Alumno que se desea guardar
                        cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                        cmd.Parameters.AddWithValue("@ApellidoPat", alumno.ApellidoPat);
                        cmd.Parameters.AddWithValue("@ApellidoMat", alumno.ApellidoMat);
                        cmd.Parameters.AddWithValue("@Email", alumno.Email);
                        cmd.Parameters.AddWithValue("@NumMatricula", alumno.NumMatricula);

                        // Ejecuta el comando
                        int result = cmd.ExecuteNonQuery();

                        // Si el resultado es mayor a 0, entonces se insertó correctamente
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar el alumno: " + ex.Message);
                    return false;
                }
            }
            // No es necesario el bloque finally porque 'using' ya se encarga de cerrar la conexión
        }

        public bool Modificar(AlumnoBOL alumno)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "UPDATE Alumnos SET Nombre = @Nombre, ApellidoPat = @ApellidoPat, ApellidoMat = @ApellidoMat, Email = @Email, NumMatricula = @NumMatricula WHERE IDAlumno = @IDAlumno";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        // Agregar los valores de los parámetros del objeto Alumno
                        cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                        cmd.Parameters.AddWithValue("@ApellidoPat", alumno.ApellidoPat);
                        cmd.Parameters.AddWithValue("@ApellidoMat", alumno.ApellidoMat);
                        cmd.Parameters.AddWithValue("@Email", alumno.Email);
                        cmd.Parameters.AddWithValue("@NumMatricula", alumno.NumMatricula);
                        cmd.Parameters.AddWithValue("@IDAlumno", alumno.IDAlumno);

                        // Ejecuta el comando
                        int result = cmd.ExecuteNonQuery();

                        // Si el resultado es mayor a 0, entonces se modificó correctamente
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al modificar el alumno: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Eliminar(int idAlumno)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "DELETE FROM Alumnos WHERE IDAlumno = @IDAlumno";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        // Agregar el valor del parámetro IDAlumno
                        cmd.Parameters.AddWithValue("@IDAlumno", idAlumno);

                        // Ejecuta el comando
                        int result = cmd.ExecuteNonQuery();

                        // Si el resultado es mayor a 0, entonces se eliminó correctamente
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el alumno: " + ex.Message);
                    return false;
                }
            }
        }

        public AlumnoBOL SeleccionarPorID(int idAlumno)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT IDAlumno, Nombre, ApellidoPat, ApellidoMat, Email, NumMatricula FROM Alumnos WHERE IDAlumno = @IDAlumno";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDAlumno", idAlumno);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                AlumnoBOL alumno = new AlumnoBOL
                                {
                                    IDAlumno = reader.GetInt32(reader.GetOrdinal("IDAlumno")),
                                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                    ApellidoPat = reader.GetString(reader.GetOrdinal("ApellidoPat")),
                                    ApellidoMat = reader.GetString(reader.GetOrdinal("ApellidoMat")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    NumMatricula = reader.GetString(reader.GetOrdinal("NumMatricula"))
                                };
                                return alumno;
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
                    Console.WriteLine("Error al seleccionar el alumno: " + ex.Message);
                    return null;
                }
            }
        }

        public List<AlumnoBOL> ObtenerAlumnos()
        {
            List<AlumnoBOL> lista = new List<AlumnoBOL>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Alumnos";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AlumnoBOL alumno = new AlumnoBOL
                    {
                        IDAlumno = Convert.ToInt32(reader["IDAlumno"]),
                        Nombre = reader["Nombre"].ToString(),
                        ApellidoPat = reader["ApellidoPat"].ToString(),
                        ApellidoMat = reader["ApellidoMat"].ToString(),
                        Email = reader["Email"].ToString(),
                        NumMatricula = reader["NumMatricula"].ToString()
                    };
                    lista.Add(alumno);
                }
            }
            return lista;
        }      
    }
}

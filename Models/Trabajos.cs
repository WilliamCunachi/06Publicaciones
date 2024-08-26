using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Models
{
    public class Trabajo
    {
        public string IdTrabajo { get; set; }
        public string Descripcion { get; set; }
        public string NivelMinimo { get; set; }
        public string NivelMaximo { get; set; }
        public string DescripcionTrabajo { get; set; }

        public Trabajo() { }
        public static Trabajo Insertar(Trabajo trabajo)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO jobs(job_desc, min_lvl, max_lvl) " +
                "OUTPUT INSERTED.job_id, INSERTED.job_desc, INSERTED.min_lvl, INSERTED.max_lvl " +
                "VALUES(@Descripcion, @NivelMinimo, @NivelMaximo)";


                        using (var comando = new SqlCommand(consulta, conexion))
                        {
                            // No incluir el parámetro IdTrabajo
                            comando.Parameters.AddWithValue("@Descripcion", trabajo.Descripcion);
                            comando.Parameters.AddWithValue("@NivelMinimo", trabajo.NivelMinimo);
                            comando.Parameters.AddWithValue("@NivelMaximo", trabajo.NivelMaximo);

                            using (var lector = comando.ExecuteReader())
                            {
                                if (lector.Read())
                                {
                                    return new Trabajo
                                    {
                                        IdTrabajo = lector["job_id"].ToString(),  // Se leerá el valor generado
                                        Descripcion = lector["job_desc"].ToString(),
                                        NivelMinimo = lector["min_lvl"].ToString(),
                                        NivelMaximo = lector["max_lvl"].ToString(),
                                    };
                                }
                            }
                        }
                    }
                }
            
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el Trabajo.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el Trabajo.");
            }
            return null;
        }
        public static string Actualizar(Trabajo trabajo)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE jobs SET job_desc = @Descripcion, min_lvl = @NivelMinimo, max_lvl = @NivelMaximo " +
                                   "WHERE job_id = @IdTrabajo";


                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTrabajo", trabajo.IdTrabajo);
                        comando.Parameters.AddWithValue("@Descripcion", trabajo.Descripcion);
                        comando.Parameters.AddWithValue("@NivelMinimo", trabajo.NivelMinimo);
                        comando.Parameters.AddWithValue("@NivelMaximo", trabajo.NivelMaximo);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el Trabajo.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el Trabajo.");
                return "Error";
            }
        }
        public static string Eliminar(string IdTrabajo)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM jobs WHERE job_id = @IdTrabajo";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTrabajo", IdTrabajo);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el Trabajo.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el Trabajo.");
                return "Error";
            }
        }
        public static Trabajo ObtenerPorId(string IdTrabajo )
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM jobs WHERE job_id = @IdTrabajo";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTrabajo", IdTrabajo);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Trabajo
                                {
                                    IdTrabajo = lector["job_id"].ToString(),
                                    Descripcion = lector["job_desc"].ToString(),
                                    NivelMinimo = lector["min_lvl"].ToString(),
                                    NivelMaximo = lector["max_lvl"].ToString(),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el autor.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el autor.");
            }
            return null;
        }
        public static List<Trabajo> ObtenerTodos()
            {
                var trabajos = new List<Trabajo>();

                try
                {
                    using (var conexion = Conexion.GetConnection())
                    {
                        var consulta = "SELECT * FROM jobs";

                        using (var comando = new SqlCommand(consulta, conexion))
                        {
                            using (var lector = comando.ExecuteReader())
                            {
                                while (lector.Read())
                                {
                                    
                                    trabajos.Add(new Trabajo
                                    {

                                        IdTrabajo = lector["job_id"].ToString(),
                                        Descripcion = lector["job_desc"].ToString(),
                                        NivelMinimo = lector["min_lvl"].ToString(),
                                        NivelMaximo = lector["max_lvl"].ToString(),
                                        DescripcionTrabajo = lector["job_desc"].ToString() + " "
                                    });
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de autores.");
                }
                catch (Exception ex)
                {
                    ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de autores.");
                }

                return trabajos;
            }
    }
}
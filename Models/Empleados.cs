using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Models
{
    internal class Empleados
    {
        public string IdentificacionEmpirica { get; set; }
        public string Nombre { get; set; }
        public string Minito { get; set; }
        public string Apellido { get; set; }
        public string IdentificacionTrabajo { get; set; }
        public string NivelTrabajo { get; set; }
        public string IdentificacionPublica { get; set; }
        public string FechaContratacion { get; set; }
        public string DescripcionEmpleados { get; set; }


        public Empleados() { }
        public static Empleados Insertar(Empleados empleados)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO employee(emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date) " +
                "OUTPUT INSERTED.emp_id, INSERTED.fname, INSERTED.minit, INSERTED.lname,INSERTED.job_id, INSERTED.job_lvl,INSERTED.pub_id, INSERTED.hire_date " +
                "VALUES(@IdentificacionEmpirica, @Nombre, @ Minito, @ Apellido, @ IdentificacionTrabajo, @ NivelTrabajo, @ IdentificacionPublica, @ FechaContratacion )";


                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                       
                        comando.Parameters.AddWithValue("@IdentificacionEmpirica", empleados .DescripcionEmpleados);
                        comando.Parameters.AddWithValue("@Nombre", empleados.Nombre);
                        comando.Parameters.AddWithValue("@Minito", empleados.Minito);
                        comando.Parameters.AddWithValue("@Apellido", empleados.Apellido );
                        comando.Parameters.AddWithValue("@ IdentificacionTrabajo", empleados.IdentificacionTrabajo );
                        comando.Parameters.AddWithValue("@NivelTrabajo", empleados.NivelTrabajo );
                        comando.Parameters.AddWithValue("@IdentificacionPublica", empleados.IdentificacionPublica );
                        comando.Parameters.AddWithValue("@ FechaContratacion", empleados.FechaContratacion);
                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Empleados
                                {
                                    IdentificacionEmpirica = lector["emp_id"].ToString(),
                                    Nombre = lector["fname"].ToString(),
                                    Minito= lector["minit"].ToString(),
                                    Apellido = lector["lname"].ToString(),
                                    IdentificacionTrabajo= lector["job_id"].ToString(),
                                    NivelTrabajo= lector["job_lvl"].ToString(),
                                    IdentificacionPublica= lector["pub_id"].ToString(),
                                    FechaContratacion= lector["hire_date"].ToString(),
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
        public static string Actualizar(Empleados empleados)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE employee SET emp_id = @IdentificacionEmpirica, fname = @Nombre, " +
                        "minit = @Minito,  lname = @Apellido, job_id = @IdentificacionTrabajo, job_lvl = @NivelTrabajo, pub_id =@ IdentificacionPublica, hire_date=@FechaContratacion" +
                                   "WHERE emp_id = @IdentificacionEmpirica";


                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdentificacionEmpirica", empleados.DescripcionEmpleados);
                        comando.Parameters.AddWithValue("@Nombre", empleados.Nombre);
                        comando.Parameters.AddWithValue("@Minito", empleados.Minito);
                        comando.Parameters.AddWithValue("@Apellido", empleados.Apellido);
                        comando.Parameters.AddWithValue("@ IdentificacionTrabajo", empleados.IdentificacionTrabajo);
                        comando.Parameters.AddWithValue("@NivelTrabajo", empleados.NivelTrabajo);
                        comando.Parameters.AddWithValue("@IdentificacionPublica", empleados.IdentificacionPublica);
                        comando.Parameters.AddWithValue("@ FechaContratacion", empleados.FechaContratacion);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el Empleados.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el Empleados.");
                return "Error";
            }
        }
        public static Empleados ObtenerPorId(string IdEmpleados)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM employee WHERE emp_id = @IdentificacionEmpirica";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdentificacionEmpirica", IdEmpleados);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Empleados
                                {
                                    IdentificacionEmpirica = lector["emp_id"].ToString(),
                                    Nombre = lector["fname"].ToString(),
                                    Minito = lector["minit"].ToString(),
                                    Apellido = lector["lname"].ToString(),
                                    IdentificacionTrabajo = lector["job_id"].ToString(),
                                    NivelTrabajo = lector["job_lvl"].ToString(),
                                    IdentificacionPublica = lector["pub_id"].ToString(),
                                    FechaContratacion = lector["hire_date"].ToString(),
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
        public static List<Empleados> ObtenerTodos()
        {
            var trabajos = new List<Empleados>();

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

                                trabajos.Add(new Empleados
                                {

                                    IdentificacionEmpirica = lector["emp_id"].ToString(),
                                    Nombre = lector["fname"].ToString(),
                                    Minito = lector["minit"].ToString(),
                                    Apellido = lector["lname"].ToString(),
                                    IdentificacionTrabajo = lector["job_id"].ToString(),
                                    NivelTrabajo = lector["job_lvl"].ToString(),
                                    IdentificacionPublica = lector["pub_id"].ToString(),
                                    FechaContratacion = lector["hire_date"].ToString(),
                                    DescripcionEmpleados = lector["emp_id"].ToString() + " "
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

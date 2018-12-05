using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Biblioteca_Prestamos
    {
        //Llaves primarias
        private int _Idprestamo;
        private int _Idalumno;
        private int _Idempleado;

        //Auxiliares
        private string _Estado;
        private string _Filtro;

        //Alumno
        private string _Alumno;
        private string _Identificacion;
        private int _Nu_Identificacion;
        private DateTime _Prestamo;
        private DateTime _Devolucion;

        //Docente
        private string _Docente;
        private string _Identificacion_Docente;
        private int _Nu_Identificacion_Docente;
        private DateTime _Prestamo_Docente;
        private DateTime _Devolucion_Docente;

        public int Idalumno
        {
            get
            {
                return _Idalumno;
            }

            set
            {
                _Idalumno = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public string Filtro
        {
            get
            {
                return _Filtro;
            }

            set
            {
                _Filtro = value;
            }
        }

        public string Alumno
        {
            get
            {
                return _Alumno;
            }

            set
            {
                _Alumno = value;
            }
        }

        public string Identificacion
        {
            get
            {
                return _Identificacion;
            }

            set
            {
                _Identificacion = value;
            }
        }

        public int Nu_Identificacion
        {
            get
            {
                return _Nu_Identificacion;
            }

            set
            {
                _Nu_Identificacion = value;
            }
        }

        public DateTime Prestamo
        {
            get
            {
                return _Prestamo;
            }

            set
            {
                _Prestamo = value;
            }
        }

        public DateTime Devolucion
        {
            get
            {
                return _Devolucion;
            }

            set
            {
                _Devolucion = value;
            }
        }

        public string Docente
        {
            get
            {
                return _Docente;
            }

            set
            {
                _Docente = value;
            }
        }

        public string Identificacion_Docente
        {
            get
            {
                return _Identificacion_Docente;
            }

            set
            {
                _Identificacion_Docente = value;
            }
        }

        public int Nu_Identificacion_Docente
        {
            get
            {
                return _Nu_Identificacion_Docente;
            }

            set
            {
                _Nu_Identificacion_Docente = value;
            }
        }

        public DateTime Prestamo_Docente
        {
            get
            {
                return _Prestamo_Docente;
            }

            set
            {
                _Prestamo_Docente = value;
            }
        }

        public DateTime Devolucion_Docente
        {
            get
            {
                return _Devolucion_Docente;
            }

            set
            {
                _Devolucion_Docente = value;
            }
        }

        public int Idempleado
        {
            get
            {
                return _Idempleado;
            }

            set
            {
                _Idempleado = value;
            }
        }

        public int Idprestamo
        {
            get
            {
                return _Idprestamo;
            }

            set
            {
                _Idprestamo = value;
            }
        }

        public Conexion_Biblioteca_Prestamos()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Biblioteca_Prestamos(int idalumno, int iddocente, int idprestamo, string alumno, string identificacion, int nu_identificacion, DateTime prestamo, DateTime devolucion,
        string docente, string identificacion_docente, int nu_identificacion_docente, DateTime prestamo_docente, DateTime devolucion_docente, string auto, string filtro)
        {
            //Llaves primarias
            this.Idalumno = idalumno;
            this.Idprestamo = idprestamo;

            //Datos Basicos
            this.Alumno = alumno;
            this.Identificacion = identificacion;
            this.Nu_Identificacion = nu_identificacion;
            this.Prestamo = prestamo;
            this.Devolucion = devolucion;

            //Docente
            this.Idempleado = iddocente;
            this.Docente = Docente;
            this.Identificacion = identificacion_docente;
            this.Nu_Identificacion = nu_identificacion_docente;
            this.Prestamo = prestamo_docente;
            this.Devolucion = devolucion_docente;

            this.Filtro = filtro;
            
        }

        //Métodos
        public string Guardar_PrestamosAlumnos(Conexion_Biblioteca_Prestamos Prestamos, List<Conexion_Biblioteca_DetalleDePrestamos> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCon.Open();
                //Establecer la transacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Biblioteca.AJ_Prestamos_Alumnos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámetros
                SqlParameter ParIdprestamos = new SqlParameter();
                ParIdprestamos.ParameterName = "@Idprestamos";
                ParIdprestamos.SqlDbType = SqlDbType.Int;
                ParIdprestamos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdprestamos);

                SqlParameter ParIdalumno = new SqlParameter();
                ParIdalumno.ParameterName = "@Idalumno";
                ParIdalumno.SqlDbType = SqlDbType.Int;
                ParIdalumno.Value = Prestamos.Idalumno;
                SqlCmd.Parameters.Add(ParIdalumno);

                SqlParameter ParSolicitante = new SqlParameter();
                ParSolicitante.ParameterName = "@Solicitante";
                ParSolicitante.SqlDbType = SqlDbType.VarChar;
                ParSolicitante.Size = 50;
                ParSolicitante.Value = Prestamos.Alumno;
                SqlCmd.Parameters.Add(ParSolicitante);

                SqlParameter ParIdentificacion = new SqlParameter();
                ParIdentificacion.ParameterName = "@Identificacion";
                ParIdentificacion.SqlDbType = SqlDbType.VarChar;
                ParIdentificacion.Size = 20;
                ParIdentificacion.Value = Prestamos.Identificacion;
                SqlCmd.Parameters.Add(ParIdentificacion);

                SqlParameter ParNuIdentificacion = new SqlParameter();
                ParNuIdentificacion.ParameterName = "@NuIdentificacion";
                ParNuIdentificacion.SqlDbType = SqlDbType.Int;
                ParNuIdentificacion.Value = Prestamos.Nu_Identificacion;
                SqlCmd.Parameters.Add(ParNuIdentificacion);

                SqlParameter ParPrestamo = new SqlParameter();
                ParPrestamo.ParameterName = "@Prestamo";
                ParPrestamo.SqlDbType = SqlDbType.Date;
                ParPrestamo.Value = Prestamos.Prestamo;
                SqlCmd.Parameters.Add(ParPrestamo);

                SqlParameter ParDevolucion = new SqlParameter();
                ParDevolucion.ParameterName = "@Devolucion";
                ParDevolucion.SqlDbType = SqlDbType.Date;
                ParDevolucion.Value = Prestamos.Devolucion;
                SqlCmd.Parameters.Add(ParDevolucion);

                SqlParameter ParSistema = new SqlParameter();
                ParSistema.ParameterName = "@Sistema";
                ParSistema.SqlDbType = SqlDbType.VarChar;
                ParSistema.Size = 15;
                ParSistema.Value = Prestamos.Estado;
                SqlCmd.Parameters.Add(ParSistema);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    //Obtenemos el codigo del ingreso que se genero por la base de datos

                    this.Idprestamo = Convert.ToInt32(SqlCmd.Parameters["@Idprestamos"].Value);
                    foreach (Conexion_Biblioteca_DetalleDePrestamos det in Detalle)
                    {
                        //Establecemos el codigo del ingreso que se autogenero
                        det.Idprestamo = this.Idprestamo;
                        //Llamamos al metodo insertar de la clase DetalleIngreso
                        //y le pasamos la conexion y la transaccion que debe de usar
                        rpta = det.Guardar_DetallePrestamosAlumnos(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            //Si ocurre un error al insertar un detalle de ingreso salimos del for
                            break;
                        }
                    }
                }
                if (rpta.Equals("OK"))
                {
                    //Se inserto todo los detalles y confirmamos la transaccion
                    SqlTra.Commit();
                }
                else
                {
                    //Algun detalle no se inserto y negamos la transaccion
                    SqlTra.Rollback();
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        public string Guardar_PrestamosDocente(Conexion_Biblioteca_Prestamos Prestamos, List<Conexion_Biblioteca_DetalleDePrestamos> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCon.Open();
                //Establecer la transacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Biblioteca.AJ_Prestamos_Docente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámetros
                SqlParameter ParIdprestamos = new SqlParameter();
                ParIdprestamos.ParameterName = "@Idprestamos";
                ParIdprestamos.SqlDbType = SqlDbType.Int;
                ParIdprestamos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdprestamos);

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@Idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = Prestamos.Idempleado;
                SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParSolicitante = new SqlParameter();
                ParSolicitante.ParameterName = "@Solicitante";
                ParSolicitante.SqlDbType = SqlDbType.VarChar;
                ParSolicitante.Size = 900;
                ParSolicitante.Value = Prestamos.Alumno;
                SqlCmd.Parameters.Add(ParSolicitante);

                SqlParameter ParIdentificacion = new SqlParameter();
                ParIdentificacion.ParameterName = "@Identificacion";
                ParIdentificacion.SqlDbType = SqlDbType.VarChar;
                ParIdentificacion.Size = 900;
                ParIdentificacion.Value = Prestamos.Identificacion;
                SqlCmd.Parameters.Add(ParIdentificacion);

                SqlParameter ParNuIdentificacion = new SqlParameter();
                ParNuIdentificacion.ParameterName = "@NuIdentificacion";
                ParNuIdentificacion.SqlDbType = SqlDbType.Int;
                ParNuIdentificacion.Value = Prestamos.Nu_Identificacion;
                SqlCmd.Parameters.Add(ParNuIdentificacion);

                SqlParameter ParPrestamo = new SqlParameter();
                ParPrestamo.ParameterName = "@Prestamo";
                ParPrestamo.SqlDbType = SqlDbType.Date;
                ParPrestamo.Value = Prestamos.Prestamo;
                SqlCmd.Parameters.Add(ParPrestamo);

                SqlParameter ParDevolucion = new SqlParameter();
                ParDevolucion.ParameterName = "@Devolucion";
                ParDevolucion.SqlDbType = SqlDbType.Date;
                ParDevolucion.Value = Prestamos.Devolucion;
                SqlCmd.Parameters.Add(ParDevolucion);

                SqlParameter ParSistema = new SqlParameter();
                ParSistema.ParameterName = "@Sistema";
                ParSistema.SqlDbType = SqlDbType.VarChar;
                ParSistema.Size = 1;
                ParSistema.Value = Prestamos.Estado;
                SqlCmd.Parameters.Add(ParSistema);


                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    //Obtenemos el codigo del ingreso que se genero por la base de datos

                    this.Idprestamo = Convert.ToInt32(SqlCmd.Parameters["@Idprestamos"].Value);
                    foreach (Conexion_Biblioteca_DetalleDePrestamos det in Detalle)
                    {
                        //Establecemos el codigo del ingreso que se autogenero
                        det.Idprestamo = this.Idprestamo;
                        //Llamamos al metodo insertar de la clase DetalleIngreso
                        //y le pasamos la conexion y la transaccion que debe de usar
                        rpta = det.Guardar_DetallePrestamosDocente(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            //Si ocurre un error al insertar un detalle de ingreso salimos del for
                            break;
                        }
                    }
                }
                if (rpta.Equals("OK"))
                {
                    //Se inserto todo los detalles y confirmamos la transaccion
                    SqlTra.Commit();
                }
                else
                {
                    //Algun detalle no se inserto y negamos la transaccion
                    SqlTra.Rollback();
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }
    }
}

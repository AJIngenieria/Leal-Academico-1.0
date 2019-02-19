using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Bitacora
    {
        //Llaves primarias
        private int _Idbitacora;
        private int _Idalumno;

        //Datos
        private string _CodigoID;
        private string _Carnet;
        private string _Alumno;
        private string _Documento;
        private string _Identificacion;
        private string _Curso;
        private string _Jornada;
        private string _Director;
        private string _Bitacora;
        private string _Tipo;
        private DateTime _FechaDeRegistro;
        private DateTime _FechaDeCitacion;
        private string _Descripcion;

        //Consulta de Datos
        private string _Filtro;

        public int Idbitacora
        {
            get
            {
                return _Idbitacora;
            }

            set
            {
                _Idbitacora = value;
            }
        }

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

        public string CodigoID
        {
            get
            {
                return _CodigoID;
            }

            set
            {
                _CodigoID = value;
            }
        }

        public string Carnet
        {
            get
            {
                return _Carnet;
            }

            set
            {
                _Carnet = value;
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

        public string Documento
        {
            get
            {
                return _Documento;
            }

            set
            {
                _Documento = value;
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

        public string Curso
        {
            get
            {
                return _Curso;
            }

            set
            {
                _Curso = value;
            }
        }

        public string Jornada
        {
            get
            {
                return _Jornada;
            }

            set
            {
                _Jornada = value;
            }
        }

        public string Director
        {
            get
            {
                return _Director;
            }

            set
            {
                _Director = value;
            }
        }

        public string Bitacora
        {
            get
            {
                return _Bitacora;
            }

            set
            {
                _Bitacora = value;
            }
        }

        public string Tipo
        {
            get
            {
                return _Tipo;
            }

            set
            {
                _Tipo = value;
            }
        }

        public DateTime FechaDeRegistro
        {
            get
            {
                return _FechaDeRegistro;
            }

            set
            {
                _FechaDeRegistro = value;
            }
        }

        public DateTime FechaDeCitacion
        {
            get
            {
                return _FechaDeCitacion;
            }

            set
            {
                _FechaDeCitacion = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
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

        public Conexion_Academico_Bitacora()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_Bitacora(int idalumno, string codigoid, string carnet, string alumno, string documento, string identificacion, string curso, string jornada, string director, string bitacora, string tipo, DateTime fechaderegistro, DateTime fechadecitacion, string descripcion)
        {
            //Datos Basicos
            this.Idalumno = idalumno;
            this.CodigoID = codigoid;
            this.Carnet = carnet;
            this.Alumno = alumno;
            this.Documento = documento;
            this.Identificacion = identificacion;
            this.Curso = curso;
            this.Jornada = jornada;
            this.Director = director;
            this.Bitacora = bitacora;
            this.Tipo = tipo;
            this.FechaDeRegistro = fechaderegistro;
            this.FechaDeCitacion = fechadecitacion;
            this.Descripcion = descripcion;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Academico_Bitacora Alumno)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Jalo la conexion de la base de datos 
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCon.Open();

                //Establecer la conexion para mandar a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Academico.AJ_Bitacora";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdbitacora = new SqlParameter();
                ParIdbitacora.ParameterName = "@Idbitacora";
                ParIdbitacora.SqlDbType = SqlDbType.Int;
                ParIdbitacora.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdbitacora);

                SqlParameter ParIdalumno = new SqlParameter();
                ParIdalumno.ParameterName = "@Idalumno";
                ParIdalumno.SqlDbType = SqlDbType.Int;
                ParIdalumno.Value = Alumno.Idalumno;
                SqlCmd.Parameters.Add(ParIdalumno);

                SqlParameter ParCarnet = new SqlParameter();
                ParCarnet.ParameterName = "@Carnet";
                ParCarnet.SqlDbType = SqlDbType.VarChar;
                ParCarnet.Size = 20;
                ParCarnet.Value = Alumno.Carnet;
                SqlCmd.Parameters.Add(ParCarnet);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = Alumno.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParNombres = new SqlParameter();
                ParNombres.ParameterName = "@Alumno";
                ParNombres.SqlDbType = SqlDbType.VarChar;
                ParNombres.Size = 50;
                ParNombres.Value = Alumno.Alumno;
                SqlCmd.Parameters.Add(ParNombres);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 5;
                ParDocumento.Value = Alumno.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParIdentificacion = new SqlParameter();
                ParIdentificacion.ParameterName = "@Identificacion";
                ParIdentificacion.SqlDbType = SqlDbType.VarChar;
                ParIdentificacion.Size = 20;
                ParIdentificacion.Value = Alumno.Identificacion;
                SqlCmd.Parameters.Add(ParIdentificacion);

                SqlParameter ParCurso = new SqlParameter();
                ParCurso.ParameterName = "@Curso";
                ParCurso.SqlDbType = SqlDbType.VarChar;
                ParCurso.Size = 30;
                ParCurso.Value = Alumno.Curso;
                SqlCmd.Parameters.Add(ParCurso);

                SqlParameter ParJornada = new SqlParameter();
                ParJornada.ParameterName = "@Jornada";
                ParJornada.SqlDbType = SqlDbType.Date;
                ParJornada.Value = Alumno.Jornada;
                SqlCmd.Parameters.Add(ParJornada);

                SqlParameter ParDirector = new SqlParameter();
                ParDirector.ParameterName = "@Director";
                ParDirector.SqlDbType = SqlDbType.VarChar;
                ParDirector.Size = 20;
                ParDirector.Value = Alumno.Director;
                SqlCmd.Parameters.Add(ParDirector);

                SqlParameter ParBitacora = new SqlParameter();
                ParBitacora.ParameterName = "@Bitacora";
                ParBitacora.SqlDbType = SqlDbType.VarChar;
                ParBitacora.Size = 20;
                ParBitacora.Value = Alumno.Bitacora;
                SqlCmd.Parameters.Add(ParBitacora);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 20;
                ParTipo.Value = Alumno.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParFechaDeRegistro = new SqlParameter();
                ParFechaDeRegistro.ParameterName = "@FechaDeRegistro";
                ParFechaDeRegistro.SqlDbType = SqlDbType.Date;
                ParFechaDeRegistro.Value = Alumno.FechaDeRegistro;
                SqlCmd.Parameters.Add(ParFechaDeRegistro);

                SqlParameter ParFechaDeCitacion = new SqlParameter();
                ParFechaDeCitacion.ParameterName = "@FechaDeCitacion";
                ParFechaDeCitacion.SqlDbType = SqlDbType.Date;
                ParFechaDeCitacion.Value = Alumno.FechaDeCitacion;
                SqlCmd.Parameters.Add(ParFechaDeCitacion);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                ParDescripcion.Value = Alumno.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al Registrar";
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

        public DataTable AutoCompletar_CodigoID()
        {
            DataTable DtResultado = new DataTable("Academico.Bitacora");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Academico.CodigoID_Bitacora";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {

                DtResultado = null;
            }
            return DtResultado;
        }

    }
}

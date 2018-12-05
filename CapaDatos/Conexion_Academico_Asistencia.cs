using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Asistencia
    {
        private int _Idasistencia;
        private string _Curso;
        private string _Jornada;
        private string _Periodo;

        private string _Filtro;

        public int Idasistencia
        {
            get
            {
                return _Idasistencia;
            }

            set
            {
                _Idasistencia = value;
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

        public string Periodo
        {
            get
            {
                return _Periodo;
            }

            set
            {
                _Periodo = value;
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

        public Conexion_Academico_Asistencia()
        {

        }

        public Conexion_Academico_Asistencia(int idasistencia, string curso, string jornada, string periodo)
        {
            this.Idasistencia = idasistencia;
            this.Curso = curso;
            this.Jornada = jornada;
            this.Periodo = periodo;
        }
        //Metodo Insertar

        public string Guardar_DetalleAsistencia(Conexion_Academico_Asistencia Alumno)
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
                SqlCmd.CommandText = "Academico.Mostrar_TomaDeAsistencia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdalumno = new SqlParameter();
                ParIdalumno.ParameterName = "@idalumno";
                ParIdalumno.SqlDbType = SqlDbType.Int;
                ParIdalumno.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdalumno);

                SqlParameter ParCurso = new SqlParameter();
                ParCurso.ParameterName = "@Curso";
                ParCurso.SqlDbType = SqlDbType.VarChar;
                ParCurso.Size = 20;
                ParCurso.Value = Alumno.Curso;
                SqlCmd.Parameters.Add(ParCurso);

                SqlParameter ParJornada = new SqlParameter();
                ParJornada.ParameterName = "@Jornada";
                ParJornada.SqlDbType = SqlDbType.VarChar;
                ParJornada.Size = 20;
                ParJornada.Value = Alumno.Jornada;
                SqlCmd.Parameters.Add(ParJornada);

                

                //Ejecutamos nuestro comando 

                // ejecutamos el envio de datos

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

        public DataTable Mostrar_TomaDeAsistencia(Conexion_Academico_Asistencia Asistencia)
        {
            DataTable DtResultado = new DataTable("Tesoreria.Tesoreria_OrdenDeMatricula");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Academico.Mostrar_TomaDeAsistencia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCurso = new SqlParameter();
                ParCurso.ParameterName = "@Curso";
                ParCurso.SqlDbType = SqlDbType.VarChar;
                ParCurso.Size = 20;
                ParCurso.Value = Asistencia.Curso;
                SqlCmd.Parameters.Add(ParCurso);

                SqlParameter ParJornada = new SqlParameter();
                ParJornada.ParameterName = "@Jornada";
                ParJornada.SqlDbType = SqlDbType.VarChar;
                ParJornada.Size = 20;
                ParJornada.Value = Asistencia.Jornada;
                SqlCmd.Parameters.Add(ParJornada);

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

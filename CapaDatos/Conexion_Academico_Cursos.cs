using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Cursos
    {
        private int _Idcurso;
        private string _Auto;
        private string _Curso;
        private string _Año;
        private string _Estado;
        private string _Descripcion;

        public int Idcurso { get => _Idcurso; set => _Idcurso = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Curso { get => _Curso; set => _Curso = value; }
        public string Año { get => _Año; set => _Año = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }


        public Conexion_Academico_Cursos()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_Cursos(string auto, int idcurso, string curso, string estado, string año, string descripcion)
        {
            //Datos Basicos
            this.Idcurso = idcurso;
            this.Auto = auto;
            this.Curso = curso;
            this.Año = año;
            this.Estado = estado;
            this.Descripcion = descripcion;
        }

        
        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Academico_Cursos Curso)
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
                SqlCmd.CommandText = "Sistema.AJ_Curso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcurso = new SqlParameter();
                ParIdcurso.ParameterName = "@Idcurso";
                ParIdcurso.SqlDbType = SqlDbType.Int;
                ParIdcurso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcurso);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Curso.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParCurso = new SqlParameter();
                ParCurso.ParameterName = "@Curso";
                ParCurso.SqlDbType = SqlDbType.VarChar;
                ParCurso.Size = 20;
                ParCurso.Value = Curso.Curso;
                SqlCmd.Parameters.Add(ParCurso);

                SqlParameter ParAño = new SqlParameter();
                ParAño.ParameterName = "@Año";
                ParAño.SqlDbType = SqlDbType.VarChar;
                ParAño.Size = 10;
                ParAño.Value = Curso.Año;
                SqlCmd.Parameters.Add(ParAño);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 1;
                ParEstado.Value = Curso.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 200;
                ParDescripcion.Value = Curso.Descripcion;
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

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Sistema.Cursos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.Mostrar_Curso";
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


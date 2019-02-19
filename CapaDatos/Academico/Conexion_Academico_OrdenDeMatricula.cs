using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_OrdenDeMatricula
    {
        private int _Idorden;
        private int _Idvalor;
        private int _Idestado;
        private int _Idcurso;
        private int _Idjornada;
        private string _Alumno;
        private string _Documento;
        private string _Identificacion;
        private string _Valor;
        private string _Año;
        private string _Orden;

        private string _Auto;
        private string _Filtro;

        public int Idorden { get => _Idorden; set => _Idorden = value; }
        public int Idvalor { get => _Idvalor; set => _Idvalor = value; }
        public int Idestado { get => _Idestado; set => _Idestado = value; }
        public int Idcurso { get => _Idcurso; set => _Idcurso = value; }
        public int Idjornada { get => _Idjornada; set => _Idjornada = value; }
        public string Alumno { get => _Alumno; set => _Alumno = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Valor { get => _Valor; set => _Valor = value; }
        public string Año { get => _Año; set => _Año = value; }
        public string Orden { get => _Orden; set => _Orden = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        public Conexion_Academico_OrdenDeMatricula()
        {

        }

        public Conexion_Academico_OrdenDeMatricula(int idorden, int idvalor, int idestado, int idcurso, int idjornada, string alumno, string identificacion, string documento,string año, string valor, string orden)
        {
            this.Idorden = idorden;
            this.Idvalor = idvalor;
            this.Idestado = idestado;
            this.Idcurso = idcurso;
            this.Idjornada = idjornada;
            this.Alumno = alumno;
            this.Identificacion = identificacion;
            this.Documento = documento;
            this.Año = año;
            this.Valor = valor;
            this.Orden = orden;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Academico_OrdenDeMatricula Orden)
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
                SqlCmd.CommandText = "Academico.AJ_OrdenDeMatricula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdorden = new SqlParameter();
                ParIdorden.ParameterName = "@Idorden";
                ParIdorden.SqlDbType = SqlDbType.Int;
                ParIdorden.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdorden);

                SqlParameter ParIdvalor = new SqlParameter();
                ParIdvalor.ParameterName = "@Idvalor";
                ParIdvalor.SqlDbType = SqlDbType.Int;
                ParIdvalor.Value = Orden.Idvalor;
                SqlCmd.Parameters.Add(ParIdvalor);

                SqlParameter ParIdestado = new SqlParameter();
                ParIdestado.ParameterName = "@Idestado";
                ParIdestado.SqlDbType = SqlDbType.Int;
                ParIdestado.Value = Orden.Idestado;
                SqlCmd.Parameters.Add(ParIdestado);

                SqlParameter ParIdcurso = new SqlParameter();
                ParIdcurso.ParameterName = "@Idcurso";
                ParIdcurso.SqlDbType = SqlDbType.Int;
                ParIdcurso.Value = Orden.Idcurso;
                SqlCmd.Parameters.Add(ParIdcurso);

                SqlParameter ParIdjornada = new SqlParameter();
                ParIdjornada.ParameterName = "@Idjornada";
                ParIdjornada.SqlDbType = SqlDbType.Int;
                ParIdjornada.Value = Orden.Idjornada;
                SqlCmd.Parameters.Add(ParIdjornada);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Orden.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParAlumno = new SqlParameter();
                ParAlumno.ParameterName = "@Alumno";
                ParAlumno.SqlDbType = SqlDbType.VarChar;
                ParAlumno.Size = 50;
                ParAlumno.Value = Orden.Alumno;
                SqlCmd.Parameters.Add(ParAlumno);

                SqlParameter ParIdentificacion = new SqlParameter();
                ParIdentificacion.ParameterName = "@Identificacion";
                ParIdentificacion.SqlDbType = SqlDbType.VarChar;
                ParIdentificacion.Size = 20;
                ParIdentificacion.Value = Orden.Identificacion;
                SqlCmd.Parameters.Add(ParIdentificacion);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 5;
                ParDocumento.Value = Orden.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParAño = new SqlParameter();
                ParAño.ParameterName = "@Año";
                ParAño.SqlDbType = SqlDbType.VarChar;
                ParAño.Size = 10;
                ParAño.Value = Orden.Año;
                SqlCmd.Parameters.Add(ParAño);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@Valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 10;
                ParValor.Value = Orden.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParOrden = new SqlParameter();
                ParOrden.ParameterName = "@Orden";
                ParOrden.SqlDbType = SqlDbType.VarChar;
                ParOrden.Size = 20;
                ParOrden.Value = Orden.Orden;
                SqlCmd.Parameters.Add(ParOrden);

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

        public DataTable Buscar_OrdenDeMatricula(Conexion_Academico_OrdenDeMatricula Orden)
        {
            DataTable DtResultado = new DataTable("Tesoreria.Tesoreria_OrdenDeMatricula");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Tesoreria.Buscar_OrdenDeMatricula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFiltro = new SqlParameter();
                ParFiltro.ParameterName = "@Filtro";
                ParFiltro.SqlDbType = SqlDbType.VarChar;
                ParFiltro.Size = 50;
                ParFiltro.Value = Orden.Filtro;
                SqlCmd.Parameters.Add(ParFiltro);

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


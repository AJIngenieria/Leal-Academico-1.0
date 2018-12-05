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
        private int _Idvalores;
        private string _Alumno;
        private string _Identificacion;
        private string _NoIdentificacion;
        private string _Valor;
        private string _Año;
        private string _Orden;

        private string _Auto;
        private string _Filtro;

        public int Idorden { get => _Idorden; set => _Idorden = value; }
        public int Idvalores { get => _Idvalores; set => _Idvalores = value; }
        public string Alumno { get => _Alumno; set => _Alumno = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string NoIdentificacion { get => _NoIdentificacion; set => _NoIdentificacion = value; }
        public string Valor { get => _Valor; set => _Valor = value; }
        public string Año { get => _Año; set => _Año = value; }
        public string Orden { get => _Orden; set => _Orden = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        public Conexion_Academico_OrdenDeMatricula()
        {

        }

        public Conexion_Academico_OrdenDeMatricula(int idvalores, string alumno, string identificacion, string noidentificacion,string año, string valor, string orden)
        {
            this.Idvalores = idvalores;
            this.Alumno = alumno;
            this.Identificacion = identificacion;
            this.NoIdentificacion = noidentificacion;
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
                SqlCmd.CommandText = "Tesoreria.AJ_OrdenDeMatricula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdjornada = new SqlParameter();
                ParIdjornada.ParameterName = "@Idorden";
                ParIdjornada.SqlDbType = SqlDbType.Int;
                ParIdjornada.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdjornada);

                SqlParameter ParIdvalor = new SqlParameter();
                ParIdvalor.ParameterName = "@Idvalor";
                ParIdvalor.SqlDbType = SqlDbType.Int;
                ParIdvalor.Value = Orden.Idvalores;
                SqlCmd.Parameters.Add(ParIdvalor);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
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

                SqlParameter ParNoIdentificacion = new SqlParameter();
                ParNoIdentificacion.ParameterName = "@NoIdentificacion";
                ParNoIdentificacion.SqlDbType = SqlDbType.VarChar;
                ParNoIdentificacion.Size = 20;
                ParNoIdentificacion.Value = Orden.NoIdentificacion;
                SqlCmd.Parameters.Add(ParNoIdentificacion);

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

        public DataTable Buscar_OrdenPorAlumno(Conexion_Academico_OrdenDeMatricula Orden)
        {
            DataTable DtResultado = new DataTable("Tesoreria.Tesoreria_OrdenDeMatricula");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Tesoreria.Buscar_OrdenPorAlumno";
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

        public DataTable Buscar_OrdenPorOrden(Conexion_Academico_OrdenDeMatricula Orden)
        {
            DataTable DtResultado = new DataTable("Tesoreria.Tesoreria_OrdenDeMatricula");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Tesoreria.Buscar_OrdenPorOrden";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Orden.Filtro;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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

        public DataTable Buscar_OdenPorAño(Conexion_Academico_OrdenDeMatricula Orden)
        {
            DataTable DtResultado = new DataTable("Tesoreria.Tesoreria_OrdenDeMatricula");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Tesoreria.Buscar_OrdenPorAño";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Orden.Filtro;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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


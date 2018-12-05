using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Tesoreria_ValoresAcademicos
    {
        private int _Idvaloracademico;
        private string _Concepto;
        private string _Valor;
        private string _Periodo;
        private string _Año;

        private string _Auto;
        private string _Consulta;
        private string _Filtro;

        public int Idvaloracademico
        {
            get
            {
                return _Idvaloracademico;
            }

            set
            {
                _Idvaloracademico = value;
            }
        }

        public string Concepto
        {
            get
            {
                return _Concepto;
            }

            set
            {
                _Concepto = value;
            }
        }

        public string Valor
        {
            get
            {
                return _Valor;
            }

            set
            {
                _Valor = value;
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

        public string Año
        {
            get
            {
                return _Año;
            }

            set
            {
                _Año = value;
            }
        }

        public string Auto
        {
            get
            {
                return _Auto;
            }

            set
            {
                _Auto = value;
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

        public string Consulta
        {
            get
            {
                return _Consulta;
            }

            set
            {
                _Consulta = value;
            }
        }

        public Conexion_Tesoreria_ValoresAcademicos()
        {

        }

        public Conexion_Tesoreria_ValoresAcademicos( string concepto, string valor, string periodo, string año, string auto, string consulta,string filtro)
        {
            this.Concepto = concepto;
            this.Valor = valor;
            this.Periodo = periodo;
            this.Año = año;
            this.Filtro = filtro;
            this.Auto = auto;
            this.Consulta = consulta;
        }
        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Tesoreria_ValoresAcademicos Valores)
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
                SqlCmd.CommandText = "Tesoreria.AJ_ValoresAcademicos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdvalores = new SqlParameter();
                ParIdvalores.ParameterName = "@Idvalores";
                ParIdvalores.SqlDbType = SqlDbType.Int;
                ParIdvalores.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdvalores);
                
                SqlParameter ParConcepto = new SqlParameter();
                ParConcepto.ParameterName = "@Concepto";
                ParConcepto.SqlDbType = SqlDbType.VarChar;
                ParConcepto.Size = 50;
                ParConcepto.Value = Valores.Concepto;
                SqlCmd.Parameters.Add(ParConcepto);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@Valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 20;
                ParValor.Value = Valores.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParPeriodo = new SqlParameter();
                ParPeriodo.ParameterName = "@Periodo";
                ParPeriodo.SqlDbType = SqlDbType.VarChar;
                ParPeriodo.Size = 20;
                ParPeriodo.Value = Valores.Periodo;
                SqlCmd.Parameters.Add(ParPeriodo);

                SqlParameter ParAño = new SqlParameter();
                ParAño.ParameterName = "@Año";
                ParAño.SqlDbType = SqlDbType.VarChar;
                ParAño.Size = 10;
                ParAño.Value = Valores.Año;
                SqlCmd.Parameters.Add(ParAño);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Valores.Auto;
                SqlCmd.Parameters.Add(ParAuto);

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

        public DataTable Buscar_ValoresAcademico(Conexion_Tesoreria_ValoresAcademicos Valor)
        {
            DataTable DtResultado = new DataTable("Academico.ValoresAcademicos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Academico.Buscar_ValoresAcademicos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFiltro = new SqlParameter();
                ParFiltro.ParameterName = "@Filtro";
                ParFiltro.SqlDbType = SqlDbType.VarChar;
                ParFiltro.Size = 50;
                ParFiltro.Value = Valor.Filtro;
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

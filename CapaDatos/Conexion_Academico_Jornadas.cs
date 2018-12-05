using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Jornadas
    {
        private int _Idjornada;
        private string _Jornada;
        private int _Idestado;

        private string _Auto;
        private string _Filtro;

        public int Idjornada { get => _Idjornada; set => _Idjornada = value; }
        public string Jornada { get => _Jornada; set => _Jornada = value; }
        public int Idestado { get => _Idestado; set => _Idestado = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }


        public Conexion_Academico_Jornadas()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_Jornadas(string auto, int idjornada, string jornada, int idestado)
        {
            //Datos Basicos
            this.Idjornada = idjornada;
            this.Auto = auto;
            this.Jornada = jornada;
            this.Idestado = idestado;
        }

        
        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Academico_Jornadas Jornada)
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
                SqlCmd.CommandText = "Sistema.AJ_Jornada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdjornada = new SqlParameter();
                ParIdjornada.ParameterName = "@Idjornada";
                ParIdjornada.SqlDbType = SqlDbType.Int;
                ParIdjornada.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdjornada);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Jornada.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParJornada = new SqlParameter();
                ParJornada.ParameterName = "@Jornada";
                ParJornada.SqlDbType = SqlDbType.VarChar;
                ParJornada.Size = 20;
                ParJornada.Value = Jornada.Jornada;
                SqlCmd.Parameters.Add(ParJornada);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Idestado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Jornada.Idestado;
                SqlCmd.Parameters.Add(ParEstado);

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
            DataTable DtResultado = new DataTable("Sistema.Sistema_Jornadas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.Mostrar_Jornada";
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


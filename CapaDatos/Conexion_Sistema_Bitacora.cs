using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_Bitacora
    {
        //Llave primaria
        private int _Idbitacora;

        //Datos
        private string _Bitacora;

        //Consulta de Datos
        private string _Filtro;
        private string _Auto;

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

        public Conexion_Sistema_Bitacora()
        {

        }

        public Conexion_Sistema_Bitacora(int idbitacora,string auto,string bitacora, string filtro)
        {
            this.Idbitacora = idbitacora;
            this.Bitacora = bitacora;
            this.Filtro = filtro;
            this.Auto = auto;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Sistema_Bitacora Bitacora)
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
                SqlCmd.CommandText = "Sistema.AJ_Bitacora";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdbitacora = new SqlParameter();
                ParIdbitacora.ParameterName = "@Idbitacora";
                ParIdbitacora.SqlDbType = SqlDbType.Int;
                ParIdbitacora.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdbitacora);

                SqlParameter ParBitacora = new SqlParameter();
                ParBitacora.ParameterName = "@Bitacora";
                ParBitacora.SqlDbType = SqlDbType.VarChar;
                ParBitacora.Size = 50;
                ParBitacora.Value = Bitacora.Bitacora;
                SqlCmd.Parameters.Add(ParBitacora);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Bitacora.Auto;
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

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Sistema.Bitacora");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.Mostrar_Bitacora";
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

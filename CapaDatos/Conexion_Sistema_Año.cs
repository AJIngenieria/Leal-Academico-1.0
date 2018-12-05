using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_Año
    {
        private int _Idaño;
        private int _Idestado;
        private string _Auto;
        private string _Año;

        private string _Filtro;

        public int Idaño { get => _Idaño; set => _Idaño = value; }
        public int Idestado { get => _Idestado; set => _Idestado = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Año { get => _Año; set => _Año = value; }

        public Conexion_Sistema_Año()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Sistema_Año(string auto, int idaño, string curso, int idestado, string año)
        {
            //Datos Basicos
            this.Idaño = idaño;
            this.Auto = auto;
            this.Año = año;
            this.Idestado = idestado;
        }

        
        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Sistema_Año Año)
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
                SqlCmd.CommandText = "Sistema.AJ_Año";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcurso = new SqlParameter();
                ParIdcurso.ParameterName = "@Idaño";
                ParIdcurso.SqlDbType = SqlDbType.Int;
                ParIdcurso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcurso);

                SqlParameter ParAño = new SqlParameter();
                ParAño.ParameterName = "@Año";
                ParAño.SqlDbType = SqlDbType.VarChar;
                ParAño.Size = 10;
                ParAño.Value = Año.Año;
                SqlCmd.Parameters.Add(ParAño);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Año.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Idestado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Año.Idestado;
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
    }
}


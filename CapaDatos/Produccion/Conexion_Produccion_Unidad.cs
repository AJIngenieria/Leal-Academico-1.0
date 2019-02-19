using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Unidad
    {
        //Llaves primarias
        private int _Idunidad;
        private string _Auto;
        private string _Filtro;
        private string _Estado;

        //Datos Basicos
        private string _Unidad;
        private string _Descripcion;

        public int Idunidad { get => _Idunidad; set => _Idunidad = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Unidad { get => _Unidad; set => _Unidad = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        //Constructores
        public Conexion_Produccion_Unidad()
        {

        }
        public Conexion_Produccion_Unidad
            (//Datos Basicos
            int idunidad, string unidad, string descripcion,

            string filtro, string auto, string estado)
        {
            this.Estado = estado;
            this.Auto = auto;
            this.Filtro = filtro;

            this.Unidad = unidad;
            this.Descripcion = descripcion;

        }

        public string Guardar_DatosBasicos(Conexion_Produccion_Unidad DatosBasicos)
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
                SqlCmd.CommandText = "Produccion.AJ_Unidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdunidad = new SqlParameter();
                ParIdunidad.ParameterName = "@Idunidad";
                ParIdunidad.SqlDbType = SqlDbType.Int;
                ParIdunidad.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdunidad);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = DatosBasicos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParUnidad = new SqlParameter();
                ParUnidad.ParameterName = "@Unidad";
                ParUnidad.SqlDbType = SqlDbType.VarChar;
                ParUnidad.Size = 20;
                ParUnidad.Value = DatosBasicos.Unidad;
                SqlCmd.Parameters.Add(ParUnidad);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 20;
                ParDescripcion.Value = DatosBasicos.Descripcion;
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

    }
}

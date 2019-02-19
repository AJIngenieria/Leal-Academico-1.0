using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_AreaAcademica
    {
        private int _Idarea;
        private int _Idestado;
        private string _Area;

        private string _Auto;
        private string _Filtro;

        public int Idarea { get => _Idarea; set => _Idarea = value; }
        public int Idestado { get => _Idestado; set => _Idestado = value; }
        public string Area { get => _Area; set => _Area = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }


        public Conexion_Sistema_AreaAcademica()
        {

        }

        public Conexion_Sistema_AreaAcademica(string auto, int idarea, int idestado, string area)
        {
            //Datos Basicos
            this.Idarea = idarea;
            this.Area = area;
            this.Auto = auto;
            this.Idestado = idestado;
        }

        
        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Sistema_AreaAcademica Area)
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
                SqlCmd.CommandText = "Sistema.AJ_AreasAcademica";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcurso = new SqlParameter();
                ParIdcurso.ParameterName = "@Idarea";
                ParIdcurso.SqlDbType = SqlDbType.Int;
                ParIdcurso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcurso);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Area.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParArea = new SqlParameter();
                ParArea.ParameterName = "@Area";
                ParArea.SqlDbType = SqlDbType.VarChar;
                ParArea.Size = 20;
                ParArea.Value = Area.Area;
                SqlCmd.Parameters.Add(ParArea);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Idestado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Area.Idestado;
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


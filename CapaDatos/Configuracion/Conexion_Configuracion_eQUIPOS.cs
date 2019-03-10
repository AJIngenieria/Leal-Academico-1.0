using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Configuracion_Equipos
    {
        //Llaves Primarias
        private int _Idequipo;

        //Campos Generales
        private string _Equipo;
        private string _HDD;
        private string _Tipo;
        private string _Seguridad;

        //Campos de Consulta y Verificacion
        private string _Auto;
        private string _Filtro;

        public int Idequipo { get => _Idequipo; set => _Idequipo = value; }
        public string Equipo { get => _Equipo; set => _Equipo = value; }
        public string HDD { get => _HDD; set => _HDD = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Seguridad { get => _Seguridad; set => _Seguridad = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        //Constructor Vacio
        public Conexion_Configuracion_Equipos()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Configuracion_Equipos(

            //Campos Generales
            int idequipo, string equipo, string hdd, string seguridad,

            //Filtros de Busquda
            string filtro, string auto

            )
        {

            //Llaves Primarias
            this.Idequipo = idequipo;

            //Campos Generales
            this.Equipo = equipo;
            this.HDD = hdd;
            this.Seguridad = seguridad;

            //Filtros de Busquda
            this.Filtro = filtro;
            this.Auto = auto;
        }

        public string Guardar_Equipo(Conexion_Configuracion_Equipos Equipo)
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
                SqlCmd.CommandText = "Configuracion.AJ_CodigoID_Alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdequipo = new SqlParameter();
                ParIdequipo.ParameterName = "@Idequipo";
                ParIdequipo.SqlDbType = SqlDbType.Int;
                ParIdequipo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdequipo);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Equipo.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParEquipo = new SqlParameter();
                ParEquipo.ParameterName = "@Equipo";
                ParEquipo.SqlDbType = SqlDbType.VarChar;
                ParEquipo.Size = 30;
                ParEquipo.Value = Equipo.Equipo;
                SqlCmd.Parameters.Add(ParEquipo);

                SqlParameter ParHDD = new SqlParameter();
                ParHDD.ParameterName = "@HDD";
                ParHDD.SqlDbType = SqlDbType.VarChar;
                ParHDD.Size = 20;
                ParHDD.Value = Equipo.HDD;
                SqlCmd.Parameters.Add(ParHDD);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 10;
                ParTipo.Value = Equipo.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParSeguridad = new SqlParameter();
                ParSeguridad.ParameterName = "@Seguridad";
                ParSeguridad.SqlDbType = SqlDbType.VarChar;
                ParSeguridad.Size = 30;
                ParSeguridad.Value = Equipo.Seguridad;
                SqlCmd.Parameters.Add(ParSeguridad);


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

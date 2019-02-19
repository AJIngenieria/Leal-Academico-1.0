using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Aula
    {
        private int _Idaula;
        private int _Idcurso;
        private int _Idestado;
        private string _Aula;
        private string _Capacidad;
        private string _Año;

        private string _Auto;
        private string _Filtro;

        
        public Conexion_Academico_Aula()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_Aula(string auto, int idaula, int idestado, string aula, string capacidad, int idcurso, string año)
        { 
            //Datos Basicos
            this.Idaula = idaula;
            this.Auto = auto;
            this.Aula = aula;
            this.Capacidad = capacidad;
            this.Idcurso = idcurso;
            this.Año = año;
            this.Idestado = idestado;
        }

        public int Idaula { get => _Idaula; set => _Idaula = value; }
        public int Idcurso { get => _Idcurso; set => _Idcurso = value; }
        public int Idestado { get => _Idestado; set => _Idestado = value; }
        public string Aula { get => _Aula; set => _Aula = value; }
        public string Capacidad { get => _Capacidad; set => _Capacidad = value; }
        public string Año { get => _Año; set => _Año = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Academico_Aula Aula)
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
                SqlCmd.CommandText = "Sistema.AJ_Aula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcurso = new SqlParameter();
                ParIdcurso.ParameterName = "@Idaula";
                ParIdcurso.SqlDbType = SqlDbType.Int;
                ParIdcurso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcurso);

                SqlParameter ParAula = new SqlParameter();
                ParAula.ParameterName = "@Aula";
                ParAula.SqlDbType = SqlDbType.VarChar;
                ParAula.Size = 10;
                ParAula.Value = Aula.Aula;
                SqlCmd.Parameters.Add(ParAula);

                SqlParameter ParCapacidad = new SqlParameter();
                ParCapacidad.ParameterName = "@Capacidad";
                ParCapacidad.SqlDbType = SqlDbType.VarChar;
                ParCapacidad.Size = 10;
                ParCapacidad.Value = Aula.Capacidad;
                SqlCmd.Parameters.Add(ParCapacidad);

                SqlParameter ParCurso = new SqlParameter();
                ParCurso.ParameterName = "@Idcurso";
                ParCurso.SqlDbType = SqlDbType.Int;
                ParCurso.Value = Aula.Idcurso;
                SqlCmd.Parameters.Add(ParCurso);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Aula.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParAño = new SqlParameter();
                ParAño.ParameterName = "@Año";
                ParAño.SqlDbType = SqlDbType.VarChar;
                ParAño.Size = 10;
                ParAño.Value = Aula.Año;
                SqlCmd.Parameters.Add(ParAño);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Idestado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Aula.Idestado;
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


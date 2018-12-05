using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_CodigoID
    {
        private int _Idcodigoid;
        private string _Numero;
        private string _Letras;
        private string _Simbolo;

        private string _Auto;
        private string _Filtro;

        public int Idcodigoid
        {
            get
            {
                return _Idcodigoid;
            }

            set
            {
                _Idcodigoid = value;
            }
        }

        public string Numero
        {
            get
            {
                return _Numero;
            }

            set
            {
                _Numero = value;
            }
        }

        public string Letras
        {
            get
            {
                return _Letras;
            }

            set
            {
                _Letras = value;
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

        public string Simbolo
        {
            get
            {
                return _Simbolo;
            }

            set
            {
                _Simbolo = value;
            }
        }

        public Conexion_Sistema_CodigoID()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Sistema_CodigoID(int idcodigoid, string numero, string letra, string simbolo, string auto, string filtro)
        {
            //Datos Basicos
            this.Idcodigoid = idcodigoid;
            this.Numero = numero;
            this.Letras = letra;
            this.Simbolo = simbolo;

            this.Filtro = filtro;
            this.Auto = auto;
        }

        //Metodo Insertar

        public string Guardar(Conexion_Sistema_CodigoID Codigo)
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
                SqlCmd.CommandText = "Sistema.AJ_CodigoID";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcodigoid = new SqlParameter();
                ParIdcodigoid.ParameterName = "@Idcodigoid";
                ParIdcodigoid.SqlDbType = SqlDbType.Int;
                ParIdcodigoid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcodigoid);

                SqlParameter ParNumero = new SqlParameter();
                ParNumero.ParameterName = "@Numero";
                ParNumero.SqlDbType = SqlDbType.VarChar;
                ParNumero.Size = 10;
                ParNumero.Value = Codigo.Numero;
                SqlCmd.Parameters.Add(ParNumero);

                SqlParameter ParLetra = new SqlParameter();
                ParLetra.ParameterName = "@Letra";
                ParLetra.SqlDbType = SqlDbType.VarChar;
                ParLetra.Size = 10;
                ParLetra.Value = Codigo.Letras;
                SqlCmd.Parameters.Add(ParLetra);

                SqlParameter ParSimbolo = new SqlParameter();
                ParSimbolo.ParameterName = "@Simbolo";
                ParSimbolo.SqlDbType = SqlDbType.VarChar;
                ParSimbolo.Size = 10;
                ParSimbolo.Value = Codigo.Simbolo;
                SqlCmd.Parameters.Add(ParSimbolo);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Codigo.Auto;
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
    }
}

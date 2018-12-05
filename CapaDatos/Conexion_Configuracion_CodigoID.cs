using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Configuracion_CodigoID
    {
        //Llaves primarias
        private int _Idcodigoid;

        //Campos Auxiliares
        private string _Auto;
        private string _Filtro;

        //Datos Medicos
        private string _Letra_Alumno;
        private string _Simbolo_Alumno;
        private string _Numero_Alumno;

        //Datos Medicos
        private string _Letra_Empleado;
        private string _Simbolo_Empleado;
        private string _Numero_Empleado;

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

        public string Letra_Alumno
        {
            get
            {
                return _Letra_Alumno;
            }

            set
            {
                _Letra_Alumno = value;
            }
        }

        public string Simbolo_Alumno
        {
            get
            {
                return _Simbolo_Alumno;
            }

            set
            {
                _Simbolo_Alumno = value;
            }
        }

        public string Numero_Alumno
        {
            get
            {
                return _Numero_Alumno;
            }

            set
            {
                _Numero_Alumno = value;
            }
        }

        public string Letra_Empleado
        {
            get
            {
                return _Letra_Empleado;
            }

            set
            {
                _Letra_Empleado = value;
            }
        }

        public string Simbolo_Empleado
        {
            get
            {
                return _Simbolo_Empleado;
            }

            set
            {
                _Simbolo_Empleado = value;
            }
        }

        public string Numero_Empleado
        {
            get
            {
                return _Numero_Empleado;
            }

            set
            {
                _Numero_Empleado = value;
            }
        }

        //Constructor Vacio
        public Conexion_Configuracion_CodigoID()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Configuracion_CodigoID(

            //CodigosID
            int idcodigoid, string letra_alumno, string simbolo_alumno, string numero_alumno, string letra_empleado, string simbolo_empleado,
            string numero_empleado,

            //Filtros de Busquda
            string filtro, string auto

            )
        {

            //CodigoID Alumnos
            this.Idcodigoid = idcodigoid;
            this.Letra_Alumno = letra_alumno;
            this.Simbolo_Alumno = simbolo_alumno;
            this.Numero_Alumno = numero_alumno;

            //CodigoID Empleados
            this.Letra_Empleado = letra_empleado;
            this.Simbolo_Empleado = simbolo_empleado;
            this.Numero_Empleado = numero_empleado;

            //Filtros de Busquda
            this.Filtro = filtro;
            this.Auto = auto;
        }

        public string Guardar_IDAlumno(Conexion_Configuracion_CodigoID Alumno)
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
                SqlParameter ParIdcodigoid = new SqlParameter();
                ParIdcodigoid.ParameterName = "@Idcodigoid";
                ParIdcodigoid.SqlDbType = SqlDbType.Int;
                ParIdcodigoid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcodigoid);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Alumno.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParLetra_Alumno = new SqlParameter();
                ParLetra_Alumno.ParameterName = "@Letra_Al";
                ParLetra_Alumno.SqlDbType = SqlDbType.VarChar;
                ParLetra_Alumno.Size = 50;
                ParLetra_Alumno.Value = Alumno.Letra_Alumno;
                SqlCmd.Parameters.Add(ParLetra_Alumno);

                SqlParameter ParSimbolo_Al = new SqlParameter();
                ParSimbolo_Al.ParameterName = "@Simbolo_Al";
                ParSimbolo_Al.SqlDbType = SqlDbType.VarChar;
                ParSimbolo_Al.Size = 50;
                ParSimbolo_Al.Value = Alumno.Simbolo_Alumno;
                SqlCmd.Parameters.Add(ParSimbolo_Al);

                SqlParameter ParNumero_Alumno = new SqlParameter();
                ParNumero_Alumno.ParameterName = "@Numero_Al";
                ParNumero_Alumno.SqlDbType = SqlDbType.VarChar;
                ParNumero_Alumno.Size = 50;
                ParNumero_Alumno.Value = Alumno.Numero_Alumno;
                SqlCmd.Parameters.Add(ParNumero_Alumno);


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

        public string Guardar_IDEmpleado(Conexion_Configuracion_CodigoID Empleado)
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
                SqlCmd.CommandText = "Configuracion.AJ_CodigoID_Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcodigoid = new SqlParameter();
                ParIdcodigoid.ParameterName = "@Idcodigoid";
                ParIdcodigoid.SqlDbType = SqlDbType.Int;
                ParIdcodigoid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcodigoid);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Empleado.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParLetra_Em = new SqlParameter();
                ParLetra_Em.ParameterName = "@Letra_Em";
                ParLetra_Em.SqlDbType = SqlDbType.VarChar;
                ParLetra_Em.Size = 50;
                ParLetra_Em.Value = Empleado.Letra_Empleado;
                SqlCmd.Parameters.Add(ParLetra_Em);

                SqlParameter ParSimbolo_Em = new SqlParameter();
                ParSimbolo_Em.ParameterName = "@Simbolo_Em";
                ParSimbolo_Em.SqlDbType = SqlDbType.VarChar;
                ParSimbolo_Em.Size = 50;
                ParSimbolo_Em.Value = Empleado.Simbolo_Empleado;
                SqlCmd.Parameters.Add(ParSimbolo_Em);

                SqlParameter ParNumero_Em = new SqlParameter();
                ParNumero_Em.ParameterName = "@Numero_Em";
                ParNumero_Em.SqlDbType = SqlDbType.VarChar;
                ParNumero_Em.Size = 50;
                ParNumero_Em.Value = Empleado.Numero_Empleado;
                SqlCmd.Parameters.Add(ParNumero_Em);


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

        public DataTable AutoCompletar_Alumno()
        {
            DataTable DtResultado = new DataTable("Configuracion.CodigoID_Alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Configuracion.Auto_CodigoID_Alumno";
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

        public DataTable AutoCompletar_Empleado()
        {
            DataTable DtResultado = new DataTable("Configuracion.CodigoID_Empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Configuracion.Auto_CodigoID_Empleado";
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

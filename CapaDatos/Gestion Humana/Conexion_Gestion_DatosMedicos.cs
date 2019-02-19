using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Gestion_DatosMedicos
    {
        //Llaves primarias
        private int _Iddatosmedicos;
        private int _Idempleado;

        //Campos Auxiliares
        private string _Filtro;

        //Datos Medicos
        private string _CodigoID;
        private string _RH;
        private string _Eps;
        private string _Alimentos;
        private string _Animales;
        private string _Insectos;
        private string _Medicamentos;
        private string _Plantas;
        private string _Indicaciones;

        public int Iddatosmedicos
        {
            get
            {
                return _Iddatosmedicos;
            }

            set
            {
                _Iddatosmedicos = value;
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

        public string CodigoID
        {
            get
            {
                return _CodigoID;
            }

            set
            {
                _CodigoID = value;
            }
        }

        public string RH
        {
            get
            {
                return _RH;
            }

            set
            {
                _RH = value;
            }
        }

        public string Eps
        {
            get
            {
                return _Eps;
            }

            set
            {
                _Eps = value;
            }
        }

        public string Alimentos
        {
            get
            {
                return _Alimentos;
            }

            set
            {
                _Alimentos = value;
            }
        }

        public string Animales
        {
            get
            {
                return _Animales;
            }

            set
            {
                _Animales = value;
            }
        }

        public string Insectos
        {
            get
            {
                return _Insectos;
            }

            set
            {
                _Insectos = value;
            }
        }

        public string Medicamentos
        {
            get
            {
                return _Medicamentos;
            }

            set
            {
                _Medicamentos = value;
            }
        }

        public string Plantas
        {
            get
            {
                return _Plantas;
            }

            set
            {
                _Plantas = value;
            }
        }

        public string Indicaciones
        {
            get
            {
                return _Indicaciones;
            }

            set
            {
                _Indicaciones = value;
            }
        }

        public int Idempleado
        {
            get
            {
                return _Idempleado;
            }

            set
            {
                _Idempleado = value;
            }
        }

        public Conexion_Gestion_DatosMedicos()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Gestion_DatosMedicos(

            //Datos Medicos
            int iddatosmedicos, int idempleado, string rh, string eps, string alimentos, string animales, string insectos,
            string medicamentos, string plantas, string indicaciones,

            //Filtros de Busquda
            string filtro, string codigoid

            )
        {
            //Datos Medicos
            this.Idempleado = idempleado;

            this.RH = rh;
            this.Eps = eps;
            this.Alimentos = alimentos;
            this.Animales = animales;
            this.Insectos = insectos;
            this.Medicamentos = medicamentos;
            this.Plantas = plantas;
            this.Indicaciones = indicaciones;

            //Filtros de Busquda
            this.Filtro = filtro;
            this.CodigoID = codigoid;
        }

        public string Guardar_Salud(Conexion_Gestion_DatosMedicos Salud)
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
                SqlCmd.CommandText = "Gestion.AJ_DatosMedicos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIddatosmedicos = new SqlParameter();
                ParIddatosmedicos.ParameterName = "@Iddatosmedicos";
                ParIddatosmedicos.SqlDbType = SqlDbType.Int;
                ParIddatosmedicos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddatosmedicos);

                //SqlParameter ParIdempleado = new SqlParameter();
                //ParIdempleado.ParameterName = "@Idempleado";
                //ParIdempleado.SqlDbType = SqlDbType.Int;
                //ParIdempleado.Value = Salud.Idempleado;
                //SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 50;
                ParCodigoID.Value = Salud.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParRh = new SqlParameter();
                ParRh.ParameterName = "@Rh";
                ParRh.SqlDbType = SqlDbType.VarChar;
                ParRh.Size = 10;
                ParRh.Value = Salud.RH;
                SqlCmd.Parameters.Add(ParRh);

                SqlParameter ParEPS = new SqlParameter();
                ParEPS.ParameterName = "@EPS";
                ParEPS.SqlDbType = SqlDbType.VarChar;
                ParEPS.Size = 10;
                ParEPS.Value = Salud.Eps;
                SqlCmd.Parameters.Add(ParEPS);

                SqlParameter ParAlimentos = new SqlParameter();
                ParAlimentos.ParameterName = "@Alimentos";
                ParAlimentos.SqlDbType = SqlDbType.VarChar;
                ParAlimentos.Size = 50;
                ParAlimentos.Value = Salud.Alimentos;
                SqlCmd.Parameters.Add(ParAlimentos);

                SqlParameter ParAnimales = new SqlParameter();
                ParAnimales.ParameterName = "@Animales";
                ParAnimales.SqlDbType = SqlDbType.VarChar;
                ParAnimales.Size = 50;
                ParAnimales.Value = Salud.Animales;
                SqlCmd.Parameters.Add(ParAnimales);

                SqlParameter ParInsectos = new SqlParameter();
                ParInsectos.ParameterName = "@Insectos";
                ParInsectos.SqlDbType = SqlDbType.VarChar;
                ParInsectos.Size = 50;
                ParInsectos.Value = Salud.Insectos;
                SqlCmd.Parameters.Add(ParInsectos);

                SqlParameter ParMedicamentos = new SqlParameter();
                ParMedicamentos.ParameterName = "@Medicamentos";
                ParMedicamentos.SqlDbType = SqlDbType.VarChar;
                ParMedicamentos.Size = 50;
                ParMedicamentos.Value = Salud.Medicamentos;
                SqlCmd.Parameters.Add(ParMedicamentos);

                SqlParameter ParPlantas = new SqlParameter();
                ParPlantas.ParameterName = "@Plantas";
                ParPlantas.SqlDbType = SqlDbType.VarChar;
                ParPlantas.Size = 50;
                ParPlantas.Value = Salud.Plantas;
                SqlCmd.Parameters.Add(ParPlantas);

                SqlParameter ParIndicaciones = new SqlParameter();
                ParIndicaciones.ParameterName = "@Indicaciones";
                ParIndicaciones.SqlDbType = SqlDbType.VarChar;
                ParIndicaciones.Size = 100;
                ParIndicaciones.Value = Salud.Indicaciones;
                SqlCmd.Parameters.Add(ParIndicaciones);

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

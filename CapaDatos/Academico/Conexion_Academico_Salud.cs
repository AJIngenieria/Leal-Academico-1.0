using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Salud
    {
        //Llaves primarias
        private int _Idsalud;
        private int _Idalumno;

        //Campos Auxiliares
        private string _Auto;
        private string _Filtro;

        //Datos Medicos
        private string _CodigoID;
        private string _GrupoSanguineo;
        private string _Eps;
        private string _Alimentos;
        private string _Animales;
        private string _Insectos;
        private string _Medicamentos;
        private string _Plantas;
        private string _Otros;
        private string _Indicaciones;

        public int Idsalud { get => _Idsalud; set => _Idsalud = value; }
        public int Idalumno { get => _Idalumno; set => _Idalumno = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string GrupoSanguineo { get => _GrupoSanguineo; set => _GrupoSanguineo = value; }
        public string Eps { get => _Eps; set => _Eps = value; }
        public string Alimentos { get => _Alimentos; set => _Alimentos = value; }
        public string Animales { get => _Animales; set => _Animales = value; }
        public string Insectos { get => _Insectos; set => _Insectos = value; }
        public string Medicamentos { get => _Medicamentos; set => _Medicamentos = value; }
        public string Plantas { get => _Plantas; set => _Plantas = value; }
        public string Otros { get => _Otros; set => _Otros = value; }
        public string Indicaciones { get => _Indicaciones; set => _Indicaciones = value; }


        //Constructor Vacio
        public Conexion_Academico_Salud()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_Salud(
            
            //Datos Medicos
            int iddatosmedicos, string gruposanguineo, string eps, string alimentos, string animales, string insectos,
            string medicamentos, string plantas, string otros, string indicaciones,

            //Filtros de Busquda
            string filtro, string auto, string codigoid

            )
        {
            
            //Datos Medicos
            this.GrupoSanguineo = gruposanguineo;
            this.Eps = eps;
            this.Alimentos = alimentos;
            this.Animales = animales;
            this.Insectos = insectos;
            this.Medicamentos = medicamentos;
            this.Plantas = plantas;
            this.Otros = otros;
            this.Indicaciones = indicaciones;

            //Filtros de Busquda
            this.Filtro = filtro;
            this.Auto = auto;
            this.CodigoID = codigoid;
        }

        
        public string Guardar_Salud(Conexion_Academico_Salud Salud)
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
                SqlCmd.CommandText = "Academico.AJ_DatosMedicos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdalumno = new SqlParameter();
                ParIdalumno.ParameterName = "@Iddatosmedicos";
                ParIdalumno.SqlDbType = SqlDbType.Int;
                ParIdalumno.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdalumno);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = Salud.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Salud.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParRh = new SqlParameter();
                ParRh.ParameterName = "@Rh";
                ParRh.SqlDbType = SqlDbType.VarChar;
                ParRh.Size = 10;
                ParRh.Value = Salud.GrupoSanguineo;
                SqlCmd.Parameters.Add(ParRh);

                SqlParameter ParEPS = new SqlParameter();
                ParEPS.ParameterName = "@EPS";
                ParEPS.SqlDbType = SqlDbType.VarChar;
                ParEPS.Size = 20;
                ParEPS.Value = Salud.Eps;
                SqlCmd.Parameters.Add(ParEPS);

                SqlParameter ParAlimentos = new SqlParameter();
                ParAlimentos.ParameterName = "@Alimentos";
                ParAlimentos.SqlDbType = SqlDbType.VarChar;
                ParAlimentos.Size = 100;
                ParAlimentos.Value = Salud.Alimentos;
                SqlCmd.Parameters.Add(ParAlimentos);

                SqlParameter ParAnimales = new SqlParameter();
                ParAnimales.ParameterName = "@Animales";
                ParAnimales.SqlDbType = SqlDbType.VarChar;
                ParAnimales.Size = 100;
                ParAnimales.Value = Salud.Animales;
                SqlCmd.Parameters.Add(ParAnimales);

                SqlParameter ParInsectos = new SqlParameter();
                ParInsectos.ParameterName = "@Insectos";
                ParInsectos.SqlDbType = SqlDbType.VarChar;
                ParInsectos.Size = 100;
                ParInsectos.Value = Salud.Insectos;
                SqlCmd.Parameters.Add(ParInsectos);

                SqlParameter ParMedicamentos = new SqlParameter();
                ParMedicamentos.ParameterName = "@Medicamentos";
                ParMedicamentos.SqlDbType = SqlDbType.VarChar;
                ParMedicamentos.Size = 100;
                ParMedicamentos.Value = Salud.Medicamentos;
                SqlCmd.Parameters.Add(ParMedicamentos);

                SqlParameter ParPlantas = new SqlParameter();
                ParPlantas.ParameterName = "@Plantas";
                ParPlantas.SqlDbType = SqlDbType.VarChar;
                ParPlantas.Size = 100;
                ParPlantas.Value = Salud.Plantas;
                SqlCmd.Parameters.Add(ParPlantas);

                SqlParameter ParOtros = new SqlParameter();
                ParOtros.ParameterName = "@Otros";
                ParOtros.SqlDbType = SqlDbType.VarChar;
                ParOtros.Size = 100;
                ParOtros.Value = Salud.Otros;
                SqlCmd.Parameters.Add(ParOtros);

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

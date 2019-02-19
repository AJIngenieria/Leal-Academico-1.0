using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Gestion_Experiencias
    {
        //Llaves primarias
        private int _Idexperiencia;
        private int _Idempleados;

        private string _CodigoID;
        private string _Auto;

        //Experiencia
        private string _Empresa;
        private string _Cargo;
        private string _Tiempo;

        public int Idexperiencia
        {
            get
            {
                return _Idexperiencia;
            }

            set
            {
                _Idexperiencia = value;
            }
        }

        public string Empresa
        {
            get
            {
                return _Empresa;
            }

            set
            {
                _Empresa = value;
            }
        }

        public string Cargo
        {
            get
            {
                return _Cargo;
            }

            set
            {
                _Cargo = value;
            }
        }

        public string Tiempo
        {
            get
            {
                return _Tiempo;
            }

            set
            {
                _Tiempo = value;
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

        public int Idempleados
        {
            get
            {
                return _Idempleados;
            }

            set
            {
                _Idempleados = value;
            }
        }

        public Conexion_Gestion_Experiencias()
        {

        }
        public Conexion_Gestion_Experiencias

            (int idexperiencia, int idempleado, string codigoid, string auto, string empresa, string cargo, string tiempo)

        {
            //Llaves primarias
            this.Idexperiencia = idexperiencia;
            this.Idempleados = idempleado;
            this.Auto = auto;
            this.CodigoID = codigoid;

            //Experiencia
            this.Empresa = empresa;
            this.Cargo = cargo;
            this.Tiempo = tiempo;

        }
        //Método Insertar
        public string Guardar_Experiencia(Conexion_Gestion_Experiencias Detalle_Experiencia, ref SqlConnection SqlCon)
        {
            string rpta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                //SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Gestion.AJ_Experiencia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdexperiencia = new SqlParameter();
                ParIdexperiencia.ParameterName = "@Idexperiencia";
                ParIdexperiencia.SqlDbType = SqlDbType.Int;
                ParIdexperiencia.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdexperiencia);

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@Idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = Detalle_Experiencia.Idempleados;
                SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 50;
                ParCodigoID.Value = Detalle_Experiencia.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);
                
                SqlParameter ParEmpresa = new SqlParameter();
                ParEmpresa.ParameterName = "@Empresa";
                ParEmpresa.SqlDbType = SqlDbType.VarChar;
                ParEmpresa.Size = 50;
                ParEmpresa.Value = Detalle_Experiencia.Empresa;
                SqlCmd.Parameters.Add(ParEmpresa);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@Cargo";
                ParCargo.SqlDbType = SqlDbType.VarChar;
                ParCargo.Size = 50;
                ParCargo.Value = Detalle_Experiencia.Cargo;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter ParTiempo = new SqlParameter();
                ParTiempo.ParameterName = "@Tiempo";
                ParTiempo.SqlDbType = SqlDbType.VarChar;
                ParTiempo.Size = 20;
                ParTiempo.Value = Detalle_Experiencia.Tiempo;
                SqlCmd.Parameters.Add(ParTiempo);

                
                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }
    }
}
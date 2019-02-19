using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Gestion_Referencia
    {
        //Referencia
        private int _Idreferencia;
        private int _Idempleados;
        private string _CodigoID;
        private string _Auto;

        private string _Referencia;
        private string _Profesion;
        private string _Telefono;

        public int Idreferencia
        {
            get
            {
                return _Idreferencia;
            }

            set
            {
                _Idreferencia = value;
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

        public string Referencia
        {
            get
            {
                return _Referencia;
            }

            set
            {
                _Referencia = value;
            }
        }

        public string Profesion
        {
            get
            {
                return _Profesion;
            }

            set
            {
                _Profesion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
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

        public Conexion_Gestion_Referencia()
        {

        }
        public Conexion_Gestion_Referencia(int idreferencia, int idempleado, string auto, string referencia, string profesion, string telefono,string codigoid)

        {
            //Llaves primarias
            this.Idreferencia = idreferencia;
            this.Idempleados = idempleado;

            //Referencia
            this.Auto = auto;
            this.Referencia = referencia;
            this.Profesion = profesion;
            this.Telefono = telefono;
            this.CodigoID = codigoid;

        }

        public string Guardar_Referencia(Conexion_Gestion_Referencia Detalle_Referencia, ref SqlConnection SqlCon)
        {
            string rpta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                //SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Gestion.AJ_Referencia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdreferencia = new SqlParameter();
                ParIdreferencia.ParameterName = "@Idreferencia";
                ParIdreferencia.SqlDbType = SqlDbType.Int;
                ParIdreferencia.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdreferencia);

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@Idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = Detalle_Referencia.Idempleados;
                SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 50;
                ParCodigoID.Value = Detalle_Referencia.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParReferencia = new SqlParameter();
                ParReferencia.ParameterName = "@Referencia";
                ParReferencia.SqlDbType = SqlDbType.VarChar;
                ParReferencia.Size = 50;
                ParReferencia.Value = Detalle_Referencia.Referencia;
                SqlCmd.Parameters.Add(ParReferencia);

                SqlParameter ParProfesion = new SqlParameter();
                ParProfesion.ParameterName = "@Profesion";
                ParProfesion.SqlDbType = SqlDbType.VarChar;
                ParProfesion.Size = 50;
                ParProfesion.Value = Detalle_Referencia.Profesion;
                SqlCmd.Parameters.Add(ParProfesion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Detalle_Referencia.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

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

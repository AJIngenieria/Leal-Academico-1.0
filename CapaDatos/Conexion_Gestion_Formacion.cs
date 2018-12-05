using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Gestion_Formacion
    {
        //Llaves primarias
        private int _Idformacion;
        private int _Idempleados;
        private string _CodigoID;
        private string _Auto;

        //Formacion Academica
        private string _Entidad;
        private string _Carrera;
        private string _Año;

        public int Idformacion { get => _Idformacion; set => _Idformacion = value; }
        public int Idempleados { get => _Idempleados; set => _Idempleados = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Entidad { get => _Entidad; set => _Entidad = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public string Año { get => _Año; set => _Año = value; }

        //Constructores
        public Conexion_Gestion_Formacion()
        {

        }
        public Conexion_Gestion_Formacion
            (
            //Formacion Academica
            int idempleado, string entidad, string carrera, string año, 
            string codigoid, string auto)
        {
            this.Idempleados = idempleado;
            this.Entidad = entidad;
            this.Carrera = carrera;
            this.Año = año;

            this.Auto = auto;
            this.CodigoID = codigoid;
        }

        public string Guardar_Formacion(Conexion_Gestion_Formacion Detalle_Formacion, ref SqlConnection SqlCon)
        {
            string rpta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                //SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Gestion.AJ_Formacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdformacion = new SqlParameter();
                ParIdformacion.ParameterName = "@Idformacion";
                ParIdformacion.SqlDbType = SqlDbType.Int;
                ParIdformacion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdformacion);

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@Idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = Detalle_Formacion.Idempleados;
                SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 50;
                ParCodigoID.Value = Detalle_Formacion.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParEntidad = new SqlParameter();
                ParEntidad.ParameterName = "@Entidad";
                ParEntidad.SqlDbType = SqlDbType.VarChar;
                ParEntidad.Size = 50;
                ParEntidad.Value = Detalle_Formacion.Entidad;
                SqlCmd.Parameters.Add(ParEntidad);

                SqlParameter ParCarrera = new SqlParameter();
                ParCarrera.ParameterName = "@Carrera";
                ParCarrera.SqlDbType = SqlDbType.VarChar;
                ParCarrera.Size = 50;
                ParCarrera.Value = Detalle_Formacion.Carrera;
                SqlCmd.Parameters.Add(ParCarrera);

                SqlParameter ParAño = new SqlParameter();
                ParAño.ParameterName = "@Año";
                ParAño.SqlDbType = SqlDbType.VarChar;
                ParAño.Size = 20;
                ParAño.Value = Detalle_Formacion.Año;
                SqlCmd.Parameters.Add(ParAño);

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

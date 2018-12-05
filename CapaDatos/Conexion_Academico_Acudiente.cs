using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Acudiente
    {
        //Llaves primarias
        private int _Idacudiente;
        private int _Idalumno;
        private string _CodigoID;

        //Campos Auxiliares
        private string _Auto;
        private string _Filtro;

        //Datos del Acudiente
        private string _Acudiente;
        private string _Identificacion;
        private string _Documento;
        private string _Parentesco;
        private string _Direccion;
        private string _Telefono;
        private string _Movil;
        private string _Email;
        private string _Observacion;

        public int Idacudiente { get => _Idacudiente; set => _Idacudiente = value; }
        public int Idalumno { get => _Idalumno; set => _Idalumno = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Acudiente { get => _Acudiente; set => _Acudiente = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public string Parentesco { get => _Parentesco; set => _Parentesco = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Observacion { get => _Observacion; set => _Observacion = value; }

        //Constructor Vacio
        public Conexion_Academico_Acudiente()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_Acudiente(

            //Datos del acudiente

            int iddatosdelacudiente, string acudiente, string identificacionacudiente, string noidentificacionacudiente, string parentescoacudiente,
            string direccionacudiente, string telefonoacudiente, string movilacudiente, string emailacudiente, string observacionacudiente,

            //Filtros de Busquda
            string filtro, string auto, string codigoid

            )
        {
            
            //Datos del Acudiente
            this.Acudiente = acudiente;
            this.Identificacion = identificacionacudiente;
            this.Documento = noidentificacionacudiente;
            this.Parentesco = parentescoacudiente;
            this.Direccion = direccionacudiente;
            this.Telefono= telefonoacudiente;
            this.Movil = movilacudiente;
            this.Email = emailacudiente;
            this.Observacion = observacionacudiente;

            //Filtros de Busquda
            this.Filtro = filtro;
            this.CodigoID = codigoid;
            this.Auto = auto;
        }

        
        public string Guardar_Acudiente(Conexion_Academico_Acudiente Acudiente)
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
                SqlCmd.CommandText = "Academico.AJ_Acudiente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdalumno = new SqlParameter();
                ParIdalumno.ParameterName = "@Idacudiente";
                ParIdalumno.SqlDbType = SqlDbType.Int;
                ParIdalumno.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdalumno);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = Acudiente.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Acudiente.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParAcudiente = new SqlParameter();
                ParAcudiente.ParameterName = "@Acudiente";
                ParAcudiente.SqlDbType = SqlDbType.VarChar;
                ParAcudiente.Size = 50;
                ParAcudiente.Value = Acudiente.Acudiente;
                SqlCmd.Parameters.Add(ParAcudiente);

                SqlParameter ParIdentificacion = new SqlParameter();
                ParIdentificacion.ParameterName = "@Documento";
                ParIdentificacion.SqlDbType = SqlDbType.VarChar;
                ParIdentificacion.Size = 5;
                ParIdentificacion.Value = Acudiente.Documento;
                SqlCmd.Parameters.Add(ParIdentificacion);

                SqlParameter ParNoIdentificacion = new SqlParameter();
                ParNoIdentificacion.ParameterName = "@Identificacion";
                ParNoIdentificacion.SqlDbType = SqlDbType.VarChar;
                ParNoIdentificacion.Size = 20;
                ParNoIdentificacion.Value = Acudiente.Identificacion;
                SqlCmd.Parameters.Add(ParNoIdentificacion);

                SqlParameter ParParentesco = new SqlParameter();
                ParParentesco.ParameterName = "@Parentesco";
                ParParentesco.SqlDbType = SqlDbType.VarChar;
                ParParentesco.Size = 20;
                ParParentesco.Value = Acudiente.Parentesco;
                SqlCmd.Parameters.Add(ParParentesco);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Acudiente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 30;
                ParTelefono.Value = Acudiente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 30;
                ParMovil.Value = Acudiente.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Acudiente.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParObservacion = new SqlParameter();
                ParObservacion.ParameterName = "@Observacion";
                ParObservacion.SqlDbType = SqlDbType.VarChar;
                ParObservacion.Size = 200;
                ParObservacion.Value = Acudiente.Observacion;
                SqlCmd.Parameters.Add(ParObservacion);

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

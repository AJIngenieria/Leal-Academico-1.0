using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Madre
    {
        //Llaves primarias
        private int _Idmadre;
        private int _Idalumno;
        private string _CodigoID;

        //Campos Auxiliares
        private string _Auto;
        private string _Filtro;

        //Datos de la Madre
        private string _Madre;
        private string _Identificacion_Madre;
        private string _No_Identificacion_Madre;
        private string _Hogar_Madre;
        private string _Direccion_Madre;
        private string _Barrio_Madre;
        private string _Telefono_Madre;
        private string _Movil_Madre;
        private string _Profesion_Madre;
        private string _Empresa_Madre;
        private string _DireccionEmpresa_Madre;
        private string _TelefonoEmpresa_Madre;
        private string _EstadoCivil_Madre;
        private string _Email_Madre;
        private string _Retiro_Madre;
        private string _Informacion_Madre;

        public int Idmadre { get => _Idmadre; set => _Idmadre = value; }
        public int Idalumno { get => _Idalumno; set => _Idalumno = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Madre { get => _Madre; set => _Madre = value; }
        public string Identificacion_Madre { get => _Identificacion_Madre; set => _Identificacion_Madre = value; }
        public string No_Identificacion_Madre { get => _No_Identificacion_Madre; set => _No_Identificacion_Madre = value; }
        public string Hogar_Madre { get => _Hogar_Madre; set => _Hogar_Madre = value; }
        public string Direccion_Madre { get => _Direccion_Madre; set => _Direccion_Madre = value; }
        public string Barrio_Madre { get => _Barrio_Madre; set => _Barrio_Madre = value; }
        public string Telefono_Madre { get => _Telefono_Madre; set => _Telefono_Madre = value; }
        public string Movil_Madre { get => _Movil_Madre; set => _Movil_Madre = value; }
        public string Profesion_Madre { get => _Profesion_Madre; set => _Profesion_Madre = value; }
        public string Empresa_Madre { get => _Empresa_Madre; set => _Empresa_Madre = value; }
        public string DireccionEmpresa_Madre { get => _DireccionEmpresa_Madre; set => _DireccionEmpresa_Madre = value; }
        public string TelefonoEmpresa_Madre { get => _TelefonoEmpresa_Madre; set => _TelefonoEmpresa_Madre = value; }
        public string EstadoCivil_Madre { get => _EstadoCivil_Madre; set => _EstadoCivil_Madre = value; }
        public string Email_Madre { get => _Email_Madre; set => _Email_Madre = value; }
        public string Retiro_Madre { get => _Retiro_Madre; set => _Retiro_Madre = value; }
        public string Informacion_Madre { get => _Informacion_Madre; set => _Informacion_Madre = value; }


        //Constructor Vacio
        public Conexion_Academico_Madre()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_Madre(
            
            //Datos de la Madre
            int iddatosdelamadre, string madre, string identificacionmadre, string noidentificacionmadre, string hogarmadre, string direccionmadre, string barriomadre,
            string telefonomadre, string movilmadre, string profesionmadre, string empresamadre, string direccionempresamadre, string telefonoempresamadre,
            string estadocivilmadre, string emailmadre, string retiromadre, string informacionmadre,

            
            //Filtros de Busquda
            string filtro, string codigoid

            )
        {

            //Datos de la Madre
            this.Madre = madre;
            this.CodigoID = codigoid;
            this.Identificacion_Madre = identificacionmadre;
            this.No_Identificacion_Madre = noidentificacionmadre;
            this.Hogar_Madre = hogarmadre;
            this.Direccion_Madre = direccionmadre;
            this.Barrio_Madre = barriomadre;
            this.Telefono_Madre = telefonomadre;
            this.Movil_Madre = movilmadre;
            this.Profesion_Madre = profesionmadre;
            this.Empresa_Madre = empresamadre;
            this.DireccionEmpresa_Madre = direccionempresamadre;
            this.TelefonoEmpresa_Madre = telefonoempresamadre;
            this.EstadoCivil_Madre = estadocivilmadre;
            this.Email_Madre = emailmadre;
            this.Retiro_Madre = retiromadre;
            this.Informacion_Madre = informacionmadre;

            //Filtros de Busquda
            this.Filtro = filtro;
            
        }

        
        public string Guardar_Madre(Conexion_Academico_Madre Madre)
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
                SqlCmd.CommandText = "Academico.AJ_Madre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdmadre = new SqlParameter();
                ParIdmadre.ParameterName = "@Idmadre";
                ParIdmadre.SqlDbType = SqlDbType.Int;
                ParIdmadre.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdmadre);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Madre.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = Madre.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParMadre = new SqlParameter();
                ParMadre.ParameterName = "@Madre";
                ParMadre.SqlDbType = SqlDbType.VarChar;
                ParMadre.Size = 50;
                ParMadre.Value = Madre.Madre;
                SqlCmd.Parameters.Add(ParMadre);

                SqlParameter ParIdentificacion_Ma = new SqlParameter();
                ParIdentificacion_Ma.ParameterName = "@Documento";
                ParIdentificacion_Ma.SqlDbType = SqlDbType.VarChar;
                ParIdentificacion_Ma.Size = 5;
                ParIdentificacion_Ma.Value = Madre.Identificacion_Madre;
                SqlCmd.Parameters.Add(ParIdentificacion_Ma);

                SqlParameter ParNo_Identificacion_Madre = new SqlParameter();
                ParNo_Identificacion_Madre.ParameterName = "@Identificacion";
                ParNo_Identificacion_Madre.SqlDbType = SqlDbType.VarChar;
                ParNo_Identificacion_Madre.Size = 20;
                ParNo_Identificacion_Madre.Value = Madre.No_Identificacion_Madre;
                SqlCmd.Parameters.Add(ParNo_Identificacion_Madre);

                SqlParameter ParHogar_Madre = new SqlParameter();
                ParHogar_Madre.ParameterName = "@Hogar";
                ParHogar_Madre.SqlDbType = SqlDbType.VarChar;
                ParHogar_Madre.Size = 50;
                ParHogar_Madre.Value = Madre.Hogar_Madre;
                SqlCmd.Parameters.Add(ParHogar_Madre);

                SqlParameter ParDireccion_Madre = new SqlParameter();
                ParDireccion_Madre.ParameterName = "@Direccion";
                ParDireccion_Madre.SqlDbType = SqlDbType.VarChar;
                ParDireccion_Madre.Size = 50;
                ParDireccion_Madre.Value = Madre.Direccion_Madre;
                SqlCmd.Parameters.Add(ParDireccion_Madre);

                SqlParameter ParBarrio = new SqlParameter();
                ParBarrio.ParameterName = "@Barrio";
                ParBarrio.SqlDbType = SqlDbType.VarChar;
                ParBarrio.Size = 20;
                ParBarrio.Value = Madre.Barrio_Madre;
                SqlCmd.Parameters.Add(ParBarrio);

                SqlParameter ParTelefono_Ma = new SqlParameter();
                ParTelefono_Ma.ParameterName = "@Telefono";
                ParTelefono_Ma.SqlDbType = SqlDbType.VarChar;
                ParTelefono_Ma.Size = 30;
                ParTelefono_Ma.Value = Madre.Telefono_Madre;
                SqlCmd.Parameters.Add(ParTelefono_Ma);

                SqlParameter ParMovil_Madre = new SqlParameter();
                ParMovil_Madre.ParameterName = "@Movil";
                ParMovil_Madre.SqlDbType = SqlDbType.VarChar;
                ParMovil_Madre.Size = 30;
                ParMovil_Madre.Value = Madre.Movil_Madre;
                SqlCmd.Parameters.Add(ParMovil_Madre);

                SqlParameter ParProfesion_Madre = new SqlParameter();
                ParProfesion_Madre.ParameterName = "@Profesion";
                ParProfesion_Madre.SqlDbType = SqlDbType.VarChar;
                ParProfesion_Madre.Size = 50;
                ParProfesion_Madre.Value = Madre.Profesion_Madre;
                SqlCmd.Parameters.Add(ParProfesion_Madre);

                SqlParameter ParEmpresa_Madre = new SqlParameter();
                ParEmpresa_Madre.ParameterName = "@Empresa";
                ParEmpresa_Madre.SqlDbType = SqlDbType.VarChar;
                ParEmpresa_Madre.Size = 50;
                ParEmpresa_Madre.Value = Madre.Empresa_Madre;
                SqlCmd.Parameters.Add(ParEmpresa_Madre);

                SqlParameter ParDireccionEmpresa_Madre = new SqlParameter();
                ParDireccionEmpresa_Madre.ParameterName = "@DireccionEmpresa";
                ParDireccionEmpresa_Madre.SqlDbType = SqlDbType.VarChar;
                ParDireccionEmpresa_Madre.Size = 50;
                ParDireccionEmpresa_Madre.Value = Madre.DireccionEmpresa_Madre;
                SqlCmd.Parameters.Add(ParDireccionEmpresa_Madre);

                SqlParameter Par_TelefonoEmpresa_Madre = new SqlParameter();
                Par_TelefonoEmpresa_Madre.ParameterName = "@TelefonoEmpresa";
                Par_TelefonoEmpresa_Madre.SqlDbType = SqlDbType.VarChar;
                Par_TelefonoEmpresa_Madre.Size = 30;
                Par_TelefonoEmpresa_Madre.Value = Madre.TelefonoEmpresa_Madre;
                SqlCmd.Parameters.Add(Par_TelefonoEmpresa_Madre);

                SqlParameter ParEstadoCivil_Ma = new SqlParameter();
                ParEstadoCivil_Ma.ParameterName = "@EstadoCivil";
                ParEstadoCivil_Ma.SqlDbType = SqlDbType.VarChar;
                ParEstadoCivil_Ma.Size = 10;
                ParEstadoCivil_Ma.Value = Madre.EstadoCivil_Madre;
                SqlCmd.Parameters.Add(ParEstadoCivil_Ma);

                SqlParameter ParEmpresa_Padre = new SqlParameter();
                ParEmpresa_Padre.ParameterName = "@Email";
                ParEmpresa_Padre.SqlDbType = SqlDbType.VarChar;
                ParEmpresa_Padre.Size = 50;
                ParEmpresa_Padre.Value = Madre.Email_Madre;
                SqlCmd.Parameters.Add(ParEmpresa_Padre);

                SqlParameter ParRetirar_Pa = new SqlParameter();
                ParRetirar_Pa.ParameterName = "@Retirar";
                ParRetirar_Pa.SqlDbType = SqlDbType.VarChar;
                ParRetirar_Pa.Size = 20;
                ParRetirar_Pa.Value = Madre.Retiro_Madre;
                SqlCmd.Parameters.Add(ParRetirar_Pa);

                SqlParameter ParInformacion_Madre = new SqlParameter();
                ParInformacion_Madre.ParameterName = "@Informacion";
                ParInformacion_Madre.SqlDbType = SqlDbType.VarChar;
                ParInformacion_Madre.Size = 20;
                ParInformacion_Madre.Value = Madre.Informacion_Madre;
                SqlCmd.Parameters.Add(ParInformacion_Madre);

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

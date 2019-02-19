using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Padre
    {
        //Llaves primarias
        private int _Idpadre;
        private int _Idalumno;
        

        //Campos Auxiliares
        private string _Auto;
        private string _Filtro;

        //Datos del padre
        private string _CodigoID;
        private string _Padre;
        private string _Identificacion;
        private string _Documento;
        private string _Hogar;
        private string _Direccion;
        private string _Barrio;
        private string _Telefono;
        private string _Movil;
        private string _Profesion;
        private string _Empresa;
        private string _DireccionEmpresa;
        private string _TelefonoEmpresa;
        private string _EstadoCivil;
        private string _Email;
        private string _Retiro;
        private string _Informacion;

        public int Idpadre { get => _Idpadre; set => _Idpadre = value; }
        public int Idalumno { get => _Idalumno; set => _Idalumno = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Padre { get => _Padre; set => _Padre = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public string Hogar { get => _Hogar; set => _Hogar = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Barrio { get => _Barrio; set => _Barrio = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Profesion { get => _Profesion; set => _Profesion = value; }
        public string Empresa { get => _Empresa; set => _Empresa = value; }
        public string DireccionEmpresa { get => _DireccionEmpresa; set => _DireccionEmpresa = value; }
        public string TelefonoEmpresa { get => _TelefonoEmpresa; set => _TelefonoEmpresa = value; }
        public string EstadoCivil { get => _EstadoCivil; set => _EstadoCivil = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Retiro { get => _Retiro; set => _Retiro = value; }
        public string Informacion { get => _Informacion; set => _Informacion = value; }


        //Constructor Vacio
        public Conexion_Academico_Padre()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_Padre(
            
            //Dato del Padre
            int idpadre, string codigoid, string padre, string identificacionpadre, string noidentificacionpadre, string hogarpadre, string direccionpadre, string barriopadre,
            string telefonopadre, string movilpadre, string profesionpadre, string empresapadre,
            string direccionempresapadre, string telefonoempresapadre, string estadocivilpadre, string emailpadre, string retiropadre, string informacionpadre,

            
            //Filtros de Busquda
            string filtro

            )
        {

            //Datos del padre
            this.CodigoID = codigoid;
            this.Idpadre = idpadre;

            this.Padre = padre;
            this.Documento = identificacionpadre;
            this.Identificacion = noidentificacionpadre;
            this.Hogar = hogarpadre;
            this.Direccion = direccionpadre;
            this.Barrio = barriopadre;
            this.Telefono = telefonopadre;
            this.Movil = movilpadre;
            this.Profesion = profesionpadre;
            this.Empresa = empresapadre;
            this.DireccionEmpresa = direccionempresapadre;
            this.TelefonoEmpresa = telefonoempresapadre;
            this.EstadoCivil = estadocivilpadre;
            this.Email = emailpadre;
            this.Retiro = retiropadre;
            this.Informacion = informacionpadre;

            //Filtros de Busquda
            this.Filtro = filtro;
        }

        
        public string Guardar_Padre(Conexion_Academico_Padre Padre)
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
                SqlCmd.CommandText = "Academico.AJ_Padre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdpadre = new SqlParameter();
                ParIdpadre.ParameterName = "@Idpadre";
                ParIdpadre.SqlDbType = SqlDbType.Int;
                ParIdpadre.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdpadre);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = Padre.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Padre.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParPadre = new SqlParameter();
                ParPadre.ParameterName = "@Padre";
                ParPadre.SqlDbType = SqlDbType.VarChar;
                ParPadre.Size = 50;
                ParPadre.Value = Padre.Padre;
                SqlCmd.Parameters.Add(ParPadre);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 5;
                ParDocumento.Value = Padre.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParIdentificacion = new SqlParameter();
                ParIdentificacion.ParameterName = "@Identificacion";
                ParIdentificacion.SqlDbType = SqlDbType.VarChar;
                ParIdentificacion.Size = 20;
                ParIdentificacion.Value = Padre.Identificacion;
                SqlCmd.Parameters.Add(ParIdentificacion);

                SqlParameter ParHogar = new SqlParameter();
                ParHogar.ParameterName = "@Hogar";
                ParHogar.SqlDbType = SqlDbType.VarChar;
                ParHogar.Size = 50;
                ParHogar.Value = Padre.Hogar;
                SqlCmd.Parameters.Add(ParHogar);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Padre.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParBarrio = new SqlParameter();
                ParBarrio.ParameterName = "@Barrio";
                ParBarrio.SqlDbType = SqlDbType.VarChar;
                ParBarrio.Size = 20;
                ParBarrio.Value = Padre.Barrio;
                SqlCmd.Parameters.Add(ParBarrio);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 30;
                ParTelefono.Value = Padre.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil_Padre = new SqlParameter();
                ParMovil_Padre.ParameterName = "@Movil";
                ParMovil_Padre.SqlDbType = SqlDbType.VarChar;
                ParMovil_Padre.Size = 30;
                ParMovil_Padre.Value = Padre.Movil;
                SqlCmd.Parameters.Add(ParMovil_Padre);

                SqlParameter ParProfesion_Pa = new SqlParameter();
                ParProfesion_Pa.ParameterName = "@Profesion";
                ParProfesion_Pa.SqlDbType = SqlDbType.VarChar;
                ParProfesion_Pa.Size = 50;
                ParProfesion_Pa.Value = Padre.Profesion;
                SqlCmd.Parameters.Add(ParProfesion_Pa);

                SqlParameter ParEmpresa_Pa = new SqlParameter();
                ParEmpresa_Pa.ParameterName = "@Empresa";
                ParEmpresa_Pa.SqlDbType = SqlDbType.VarChar;
                ParEmpresa_Pa.Size = 50;
                ParEmpresa_Pa.Value = Padre.Empresa;
                SqlCmd.Parameters.Add(ParEmpresa_Pa);

                SqlParameter ParDireccionEmpresa_Padre = new SqlParameter();
                ParDireccionEmpresa_Padre.ParameterName = "@DireccionEmpresa";
                ParDireccionEmpresa_Padre.SqlDbType = SqlDbType.VarChar;
                ParDireccionEmpresa_Padre.Size = 50;
                ParDireccionEmpresa_Padre.Value = Padre.DireccionEmpresa;
                SqlCmd.Parameters.Add(ParDireccionEmpresa_Padre);

                SqlParameter ParTelefonoEmpresa_Padre = new SqlParameter();
                ParTelefonoEmpresa_Padre.ParameterName = "@TelefonoEmpresa";
                ParTelefonoEmpresa_Padre.SqlDbType = SqlDbType.VarChar;
                ParTelefonoEmpresa_Padre.Size = 30;
                ParTelefonoEmpresa_Padre.Value = Padre.TelefonoEmpresa;
                SqlCmd.Parameters.Add(ParTelefonoEmpresa_Padre);

                SqlParameter ParEstadoCivil_Padre = new SqlParameter();
                ParEstadoCivil_Padre.ParameterName = "@EstadoCivil";
                ParEstadoCivil_Padre.SqlDbType = SqlDbType.VarChar;
                ParEstadoCivil_Padre.Size = 10;
                ParEstadoCivil_Padre.Value = Padre.EstadoCivil;
                SqlCmd.Parameters.Add(ParEstadoCivil_Padre);

                SqlParameter ParEmpresa_Padre = new SqlParameter();
                ParEmpresa_Padre.ParameterName = "@Email";
                ParEmpresa_Padre.SqlDbType = SqlDbType.VarChar;
                ParEmpresa_Padre.Size = 50;
                ParEmpresa_Padre.Value = Padre.Email;
                SqlCmd.Parameters.Add(ParEmpresa_Padre);

                SqlParameter ParRetirar_Pa = new SqlParameter();
                ParRetirar_Pa.ParameterName = "@Retirar";
                ParRetirar_Pa.SqlDbType = SqlDbType.VarChar;
                ParRetirar_Pa.Size = 20;
                ParRetirar_Pa.Value = Padre.Retiro;
                SqlCmd.Parameters.Add(ParRetirar_Pa);

                SqlParameter ParInformacion_Padre = new SqlParameter();
                ParInformacion_Padre.ParameterName = "@Informacion";
                ParInformacion_Padre.SqlDbType = SqlDbType.VarChar;
                ParInformacion_Padre.Size = 20;
                ParInformacion_Padre.Value = Padre.Informacion;
                SqlCmd.Parameters.Add(ParInformacion_Padre);

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

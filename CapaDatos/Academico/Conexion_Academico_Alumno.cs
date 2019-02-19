using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Alumno
    {
        //Llaves primarias       
        
        private int _IdFamilia;
        private int _IdOrden;
        private string _Auto;


        //Datos Basicos
        private string _CodigoID;
        private string _Nombres;
        private string _Documentos;
        private string _Identificacion;
        private string _Carnet;
        private string _No_Orden;
        private string _Familia;
        private DateTime _FechaDeNacimiento;
        private string _Genero;
        private int _Idciudad;
        private int _Idmunicipio;
        private int _Idnacionalidad;
        private string _Becado;
        private string _Direccion;
        private string _Barrio;
        private string _Comuna;
        private string _Estracto;
        private string _Telefono;
        private string _Movil;
        private string _Email;

        //Filtros de Busquda
        private string _Filtro;

        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public int IdFamilia { get => _IdFamilia; set => _IdFamilia = value; }
        public int IdOrden { get => _IdOrden; set => _IdOrden = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Documentos { get => _Documentos; set => _Documentos = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Carnet { get => _Carnet; set => _Carnet = value; }
        public string No_Orden { get => _No_Orden; set => _No_Orden = value; }
        public string Familia { get => _Familia; set => _Familia = value; }
        public DateTime FechaDeNacimiento { get => _FechaDeNacimiento; set => _FechaDeNacimiento = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public int Idciudad { get => _Idciudad; set => _Idciudad = value; }
        public int Idmunicipio { get => _Idmunicipio; set => _Idmunicipio = value; }
        public int Idnacionalidad { get => _Idnacionalidad; set => _Idnacionalidad = value; }
        public string Becado { get => _Becado; set => _Becado = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Barrio { get => _Barrio; set => _Barrio = value; }
        public string Comuna { get => _Comuna; set => _Comuna = value; }
        public string Estracto { get => _Estracto; set => _Estracto = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        
        //Constructor Vacio
        public Conexion_Academico_Alumno()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_Alumno(
            //Datos Basicos
            string codigoid, int idfamilia, int idorden, string auto,string carnet, string noorden, string nombres,
            string documento, string identificacion, string familia, DateTime fechadenacimiento, string genero, int idciudad, int idmunicipio,
            int idnacionalidad, string becado, string direccion, string barrio, string estracto, string comuna, string telefono, string movil, string email,
            
            //Filtros de Busquda
            string filtro

            )
        {
            //Datos Basicos
            this.CodigoID = codigoid;
            this.IdFamilia = idfamilia;
            this.IdOrden = idorden;
            this.Auto = auto;
            this.Carnet = carnet;
            this.No_Orden = noorden;
            this.Nombres = nombres;
            this.Documentos = documento;
            this.Identificacion = identificacion;
            this.Familia = familia;
            this.FechaDeNacimiento = fechadenacimiento;
            this.Genero = genero;
            this.Idciudad = idciudad;
            this.Idmunicipio = idmunicipio;
            this.Idnacionalidad = idnacionalidad;
            this.Becado = becado;
            this.Direccion = direccion;
            this.Barrio = barrio;
            this.Estracto = estracto;
            this.Comuna = comuna;
            this.Telefono = telefono;
            this.Movil = movil;
            this.Email = email;

            //Filtros de Busquda
            this.Filtro = filtro;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos (Conexion_Academico_Alumno Alumno)
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
                SqlCmd.CommandText = "Academico.AJ_DatosBasicos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdalumno = new SqlParameter();
                ParIdalumno.ParameterName = "@idalumno";
                ParIdalumno.SqlDbType = SqlDbType.Int;
                ParIdalumno.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdalumno);

                SqlParameter ParIdfamilia = new SqlParameter();
                ParIdfamilia.ParameterName = "@Idfamilia";
                ParIdfamilia.SqlDbType = SqlDbType.Int;
                ParIdfamilia.Value = Alumno.IdFamilia;
                SqlCmd.Parameters.Add(ParIdfamilia);

                SqlParameter ParIdOrden = new SqlParameter();
                ParIdOrden.ParameterName = "@Idorden";
                ParIdOrden.SqlDbType = SqlDbType.Int;
                ParIdOrden.Value = Alumno.IdOrden;
                SqlCmd.Parameters.Add(ParIdOrden);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = Alumno.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Alumno.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParNombres = new SqlParameter();
                ParNombres.ParameterName = "@Alumno";
                ParNombres.SqlDbType = SqlDbType.VarChar;
                ParNombres.Size = 50;
                ParNombres.Value = Alumno.Nombres;
                SqlCmd.Parameters.Add(ParNombres);

                SqlParameter ParIdentificacion = new SqlParameter();
                ParIdentificacion.ParameterName = "@Documento";
                ParIdentificacion.SqlDbType = SqlDbType.VarChar;
                ParIdentificacion.Size = 5;
                ParIdentificacion.Value = Alumno.Documentos;
                SqlCmd.Parameters.Add(ParIdentificacion);

                SqlParameter ParNo_Identificacion = new SqlParameter();
                ParNo_Identificacion.ParameterName = "@Identificacion";
                ParNo_Identificacion.SqlDbType = SqlDbType.VarChar;
                ParNo_Identificacion.Size = 20;
                ParNo_Identificacion.Value = Alumno.Identificacion;
                SqlCmd.Parameters.Add(ParNo_Identificacion);

                SqlParameter ParCarnet = new SqlParameter();
                ParCarnet.ParameterName = "@Carnet";
                ParCarnet.SqlDbType = SqlDbType.VarChar;
                ParCarnet.Size = 20;
                ParCarnet.Value = Alumno.Carnet;
                SqlCmd.Parameters.Add(ParCarnet);

                SqlParameter ParOrden = new SqlParameter();
                ParOrden.ParameterName = "@Orden";
                ParOrden.SqlDbType = SqlDbType.VarChar;
                ParOrden.Size = 20;
                ParOrden.Value = Alumno.No_Orden;
                SqlCmd.Parameters.Add(ParOrden);

                SqlParameter ParFamilia = new SqlParameter();
                ParFamilia.ParameterName = "@Familia";
                ParFamilia.SqlDbType = SqlDbType.VarChar;
                ParFamilia.Size = 30;
                ParFamilia.Value = Alumno.Familia;
                SqlCmd.Parameters.Add(ParFamilia);

                SqlParameter ParNacimiento = new SqlParameter();
                ParNacimiento.ParameterName = "@Nacimiento";
                ParNacimiento.SqlDbType = SqlDbType.Date;
                ParNacimiento.Value = Alumno.FechaDeNacimiento;
                SqlCmd.Parameters.Add(ParNacimiento);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@Genero";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 20;
                ParGenero.Value = Alumno.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Idciudad";
                ParCiudad.SqlDbType = SqlDbType.Int;
                ParCiudad.Value = Alumno.Idciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParMunicipio = new SqlParameter();
                ParMunicipio.ParameterName = "@Idmunicipio";
                ParMunicipio.SqlDbType = SqlDbType.Int;
                ParMunicipio.Value = Alumno.Idmunicipio;
                SqlCmd.Parameters.Add(ParMunicipio);

                SqlParameter ParNacionalidad = new SqlParameter();
                ParNacionalidad.ParameterName = "@Idnacionalidad";
                ParNacionalidad.SqlDbType = SqlDbType.Int;
                ParNacionalidad.Value = Alumno.Idnacionalidad;
                SqlCmd.Parameters.Add(ParNacionalidad);

                SqlParameter ParBecado = new SqlParameter();
                ParBecado.ParameterName = "@Becario";
                ParBecado.SqlDbType = SqlDbType.VarChar;
                ParBecado.Size = 20;
                ParBecado.Value = Alumno.Becado;
                SqlCmd.Parameters.Add(ParBecado);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Alumno.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParBarrio = new SqlParameter();
                ParBarrio.ParameterName = "@Barrio";
                ParBarrio.SqlDbType = SqlDbType.VarChar;
                ParBarrio.Size = 50;
                ParBarrio.Value = Alumno.Barrio;
                SqlCmd.Parameters.Add(ParBarrio);

                SqlParameter ParComuna = new SqlParameter();
                ParComuna.ParameterName = "@Comuna";
                ParComuna.SqlDbType = SqlDbType.VarChar;
                ParComuna.Size = 10;
                ParComuna.Value = Alumno.Comuna;
                SqlCmd.Parameters.Add(ParComuna);

                SqlParameter ParEstracto = new SqlParameter();
                ParEstracto.ParameterName = "@Estracto";
                ParEstracto.SqlDbType = SqlDbType.VarChar;
                ParEstracto.Size = 10;
                ParEstracto.Value = Alumno.Estracto;
                SqlCmd.Parameters.Add(ParEstracto);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Alumno.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 30;
                ParMovil.Value = Alumno.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Alumno.Email;
                SqlCmd.Parameters.Add(ParEmail);

                //Ejecutamos nuestro comando 

                // ejecutamos el envio de datos

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

        public DataTable Buscar_Alumno(Conexion_Academico_Alumno Alumno)
        {
            DataTable DtResultado = new DataTable("Academico.DatosBasicos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Academico.Buscar_Alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Alumno.Filtro;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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

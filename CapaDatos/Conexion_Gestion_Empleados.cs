using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Gestion_Empleados
    {
        //Llaves primarias
        private int _Idempleados;
        private int _Idrol;

        private string _Estado;
        private string _Filtro;

        //Datos Basicos
        private string _CodigoID;
        private string _Empleado;
        private string _Profesion;
        private string _Identificacion;
        private string _Documento;
        private string _Expedicion;
        private DateTime _FechaExpedicion;
        private string _Email;
        private string _Telefono;
        private string _Direccion;
        private DateTime _FechaDeIngreso;
        private DateTime _Fechadesalida;

        public int Idempleados { get => _Idempleados; set => _Idempleados = value; }
        public int Idrol { get => _Idrol; set => _Idrol = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string Empleado { get => _Empleado; set => _Empleado = value; }
        public string Profesion { get => _Profesion; set => _Profesion = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public string Expedicion { get => _Expedicion; set => _Expedicion = value; }
        public DateTime FechaExpedicion { get => _FechaExpedicion; set => _FechaExpedicion = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public DateTime FechaDeIngreso { get => _FechaDeIngreso; set => _FechaDeIngreso = value; }
        public DateTime Fechadesalida { get => _Fechadesalida; set => _Fechadesalida = value; }


        //Constructores
        public Conexion_Gestion_Empleados()
        {

        }
        public Conexion_Gestion_Empleados
            (//Datos Basicos
            string idempleados, string idrol, string Empleado, string Profesion, string Identificacion, int N_Identificacion, string Expedicion, DateTime FechaExpedicion, string Email, string Telefono, 
            string Direccion, DateTime FechaDeIngreso, DateTime Fechadesalida,

            string filtro, string estado)
        {
            this.Estado=estado;
            this.Filtro = filtro;

            this.Empleado = Empleado;
            this.Profesion = Profesion;
            this.Identificacion = Identificacion;
            this.Documento = Documento;
            this.Expedicion = Expedicion;
            this.FechaExpedicion = FechaExpedicion;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.FechaDeIngreso = FechaDeIngreso;
            this.Fechadesalida = Fechadesalida;
        }

        public string Guardar_DatosBasicos(Conexion_Gestion_Empleados DatosBasicos)
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
                SqlCmd.CommandText = "Gestion.AJ_Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdempleados = new SqlParameter();
                ParIdempleados.ParameterName = "@Idempleado";
                ParIdempleados.SqlDbType = SqlDbType.Int;
                ParIdempleados.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdempleados);

                SqlParameter ParIdrol = new SqlParameter();
                ParIdrol.ParameterName = "@Idrol";
                ParIdrol.SqlDbType = SqlDbType.Int;
                ParIdrol.Value = DatosBasicos.Idrol;
                SqlCmd.Parameters.Add(ParIdrol);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 50;
                ParCodigoID.Value = DatosBasicos.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParEmpleado = new SqlParameter();
                ParEmpleado.ParameterName = "@Empleado";
                ParEmpleado.SqlDbType = SqlDbType.VarChar;
                ParEmpleado.Size = 50;
                ParEmpleado.Value = DatosBasicos.Empleado;
                SqlCmd.Parameters.Add(ParEmpleado);

                SqlParameter ParProfesion = new SqlParameter();
                ParProfesion.ParameterName = "@Profesion";
                ParProfesion.SqlDbType = SqlDbType.VarChar;
                ParProfesion.Size = 50;
                ParProfesion.Value = DatosBasicos.Profesion;
                SqlCmd.Parameters.Add(ParProfesion);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 5;
                ParDocumento.Value = DatosBasicos.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParIdentificacion = new SqlParameter();
                ParIdentificacion.ParameterName = "@Identificacion";
                ParIdentificacion.SqlDbType = SqlDbType.VarChar;
                ParIdentificacion.Size = 20;
                ParIdentificacion.Value = DatosBasicos.Identificacion;
                SqlCmd.Parameters.Add(ParIdentificacion);

                SqlParameter ParExpedida = new SqlParameter();
                ParExpedida.ParameterName = "@Expedida";
                ParExpedida.SqlDbType = SqlDbType.VarChar;
                ParExpedida.Size = 20;
                ParExpedida.Value = DatosBasicos.Expedicion;
                SqlCmd.Parameters.Add(ParExpedida);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@Fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = DatosBasicos.FechaExpedicion;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = DatosBasicos.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 30;
                ParTelefono.Value = DatosBasicos.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = DatosBasicos.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParFechaDeIngreso = new SqlParameter();
                ParFechaDeIngreso.ParameterName = "@Ingreso";
                ParFechaDeIngreso.SqlDbType = SqlDbType.Date;
                ParFechaDeIngreso.Value = DatosBasicos.FechaDeIngreso;
                SqlCmd.Parameters.Add(ParFechaDeIngreso);

                SqlParameter ParFechadesalida = new SqlParameter();
                ParFechadesalida.ParameterName = "@Salida";
                ParFechadesalida.SqlDbType = SqlDbType.Date;
                ParFechadesalida.Value = DatosBasicos.Fechadesalida;
                SqlCmd.Parameters.Add(ParFechadesalida);

                SqlParameter ParEstadoSistema = new SqlParameter();
                ParEstadoSistema.ParameterName = "@Estado";
                ParEstadoSistema.SqlDbType = SqlDbType.VarChar;
                ParEstadoSistema.Size = 1;
                ParEstadoSistema.Value = DatosBasicos.Estado;
                SqlCmd.Parameters.Add(ParEstadoSistema);

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

        
        public DataTable Examinar_DocentePorIdentificacion(Conexion_Gestion_Empleados Articulo)
        {
            DataTable DtResultado = new DataTable("Gestion.Empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Gestion.CB_PorIdentificacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Articulo.Filtro;
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

        public DataTable Examinar_DocentePorNombre(Conexion_Gestion_Empleados Articulo)
        {
            DataTable DtResultado = new DataTable("Gestion.Empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Gestion.CB_PorNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Articulo.Filtro;
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

        //Método Mostrar Detalle de Ingresos Almacen
        public DataTable MostrarDetalle(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("Almacen.Almacen_DetalleDeIngreso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Almacen.spMostrar_DetalleDeIngresoAlmacen";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable Mostrar_CodigoID()
        {
            DataTable DtResultado = new DataTable("Gestion.Empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Gestion.Auto_Empleado";
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
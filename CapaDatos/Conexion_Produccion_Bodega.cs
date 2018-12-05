using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Bodega
    {
        private int _Idbodega;
        private int _Idempleados;
        private string _Auto;
        private string _Estado;
        private string _Filtro;
        private string _CodigoID;
        private string _Descripcion;
        private string _Responsable;
        private string _Ciudad;
        private string _Zona;
        private string _Sucurzal;
        private string _Direccion;
        private string _Direccion2;
        private string _Telefono;
        private string _Movil;
        private string _Propiedad;
        private string _Mensualidad;
        private string _Valor;

        public int Idbodega { get => _Idbodega; set => _Idbodega = value; }
        public int Idempleados { get => _Idempleados; set => _Idempleados = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Responsable { get => _Responsable; set => _Responsable = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Zona { get => _Zona; set => _Zona = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Direccion2 { get => _Direccion2; set => _Direccion2 = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Propiedad { get => _Propiedad; set => _Propiedad = value; }
        public string Mensualidad { get => _Mensualidad; set => _Mensualidad = value; }
        public string Valor { get => _Valor; set => _Valor = value; }
        public string Sucurzal { get => _Sucurzal; set => _Sucurzal = value; }

        //Constructores
        public Conexion_Produccion_Bodega()
        {

        }
        public Conexion_Produccion_Bodega
            (
            //Datos Basicos
            int idbodega, int idempleado, string codigoid, string descripcion, string responsable, string ciudad, string zona,
            string sucurzal, string direccion1, string direccion2, string telefono, string movil, string propiedad, string mensualidad, string valor,

            string auto, string estado, string filtro)
        {
            this.Idbodega = idbodega;
            this.Idempleados = idempleado;

            this.Auto = auto;
            this.Estado = estado;
            this.Filtro = filtro;

            this.CodigoID = codigoid;
            this.Descripcion = descripcion;
            this.Responsable = responsable;
            this.Ciudad = ciudad;
            this.Zona = zona;
            this.Sucurzal = sucurzal;
            this.Direccion = direccion1;
            this.Direccion2 = direccion2;
            this.Telefono = telefono;
            this.Movil = movil;
            this.Propiedad = propiedad;
            this.Mensualidad = mensualidad;
            this.Valor = valor;
    }

        

        public string Guardar_DatosBasicos(Conexion_Produccion_Bodega DatosBasicos)
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
                SqlCmd.CommandText = "Produccion.AJ_Bodega";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdbodega = new SqlParameter();
                ParIdbodega.ParameterName = "@Idbodega";
                ParIdbodega.SqlDbType = SqlDbType.Int;
                ParIdbodega.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdbodega);

                SqlParameter ParIdempleados = new SqlParameter();
                ParIdempleados.ParameterName = "@Idempleado";
                ParIdempleados.SqlDbType = SqlDbType.Int;
                ParIdempleados.Value = DatosBasicos.Idempleados;
                SqlCmd.Parameters.Add(ParIdempleados);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = DatosBasicos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 10;
                ParEstado.Value = DatosBasicos.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = DatosBasicos.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                ParDescripcion.Value = DatosBasicos.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParResponsable = new SqlParameter();
                ParResponsable.ParameterName = "@Responsable";
                ParResponsable.SqlDbType = SqlDbType.VarChar;
                ParResponsable.Size = 50;
                ParResponsable.Value = DatosBasicos.Responsable;
                SqlCmd.Parameters.Add(ParResponsable);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 10;
                ParCiudad.Value = DatosBasicos.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParZona = new SqlParameter();
                ParZona.ParameterName = "@Zona";
                ParZona.SqlDbType = SqlDbType.VarChar;
                ParZona.Size = 10;
                ParZona.Value = DatosBasicos.Zona;
                SqlCmd.Parameters.Add(ParZona);

                SqlParameter ParSucurzal = new SqlParameter();
                ParSucurzal.ParameterName = "@Sucurzal";
                ParSucurzal.SqlDbType = SqlDbType.VarChar;
                ParSucurzal.Size = 50;
                ParSucurzal.Value = DatosBasicos.Sucurzal;
                SqlCmd.Parameters.Add(ParSucurzal);

                SqlParameter ParDireccion1 = new SqlParameter();
                ParDireccion1.ParameterName = "@Direccion1";
                ParDireccion1.SqlDbType = SqlDbType.VarChar;
                ParDireccion1.Size = 50;
                ParDireccion1.Value = DatosBasicos.Direccion;
                SqlCmd.Parameters.Add(ParDireccion1);

                SqlParameter ParDireccion2 = new SqlParameter();
                ParDireccion2.ParameterName = "@Direccion2";
                ParDireccion2.SqlDbType = SqlDbType.VarChar;
                ParDireccion2.Size = 50;
                ParDireccion2.Value = DatosBasicos.Direccion2;
                SqlCmd.Parameters.Add(ParDireccion2);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = DatosBasicos.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 20;
                ParMovil.Value = DatosBasicos.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParPropiedad = new SqlParameter();
                ParPropiedad.ParameterName = "@Propiedad";
                ParPropiedad.SqlDbType = SqlDbType.VarChar;
                ParPropiedad.Size = 20;
                ParPropiedad.Value = DatosBasicos.Propiedad;
                SqlCmd.Parameters.Add(ParPropiedad);

                SqlParameter ParMensualidad = new SqlParameter();
                ParMensualidad.ParameterName = "@Mensualidad";
                ParMensualidad.SqlDbType = SqlDbType.VarChar;
                ParMensualidad.Size = 20;
                ParMensualidad.Value = DatosBasicos.Mensualidad;
                SqlCmd.Parameters.Add(ParMensualidad);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@Valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 20;
                ParValor.Value = DatosBasicos.Valor;
                SqlCmd.Parameters.Add(ParValor);

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

        public DataTable Examinar_PorCodigo(Conexion_Produccion_Bodega Bodega)
        {
            DataTable DtResultado = new DataTable("Produccion.Bodega");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.CB_Bodega_PorCodigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Bodega.Filtro;
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

        public DataTable Examinar_PorNombre(Conexion_Produccion_Bodega Bodega)
        {
            DataTable DtResultado = new DataTable("Produccion.Bodega");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.CB_Bodega_PorNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Bodega.Filtro;
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


        public DataTable Examinar_PorSucurzal(Conexion_Produccion_Bodega Bodega)
        {
            DataTable DtResultado = new DataTable("Produccion.Bodega");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.CB_Bodega_PorSucurzal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Bodega.Filtro;
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

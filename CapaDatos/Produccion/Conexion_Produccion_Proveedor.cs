using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Proveedor
    {
        //Llaves Primarias
        private int _Idproveedor;
        private int _Idempleado;

        //Variable de Condicion Guardar o Editar
        private int _Auto;

        //Variables Generales
        
        private string _Tipo;
        private string _Area;
        private string _Proveedor;
        private string _CodigoID;
        private string _Documento;
        private int _Estado;
        private string _Titular;
        private string _Pais;
        private string _Ciudad;
        private string _Telefono;
        private string _Movil;
        private string _Direccion1;
        private string _Direccion2;
        private string _Email;
        private DateTime _Inicio;
        private byte[] _Foto;

        //Variable de Consulta General o Filtros
        private string _Filtro;

        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Area { get => _Area; set => _Area = value; }
        public string Proveedor { get => _Proveedor; set => _Proveedor = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string Titular { get => _Titular; set => _Titular = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Direccion1 { get => _Direccion1; set => _Direccion1 = value; }
        public string Direccion2 { get => _Direccion2; set => _Direccion2 = value; }
        public string Email { get => _Email; set => _Email = value; }
        public DateTime Inicio { get => _Inicio; set => _Inicio = value; }
        public byte[] Foto { get => _Foto; set => _Foto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }


        //Constructores
        public Conexion_Produccion_Proveedor()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Produccion_Proveedor(int idproveedor, int idempleado, string codigoid, string proveedor, string tipo, string area, string documento,
        string titular, string pais, string ciudad, string telefono, string movil, string direccion1, string direccion2, string email, DateTime inicio, byte[] foto,
        int auto, int estado, string filtro)

        {
            //Llaves principales
            this.Idproveedor = idproveedor;
            this.Idempleado = idempleado;

            //Datos Basicos
            this.CodigoID = codigoid;
            this.Proveedor = proveedor;
            this.Tipo = tipo;
            this.Area = area;
            this.Titular = titular;
            this.Documento = documento;
            this.Pais = pais;
            this.Ciudad = ciudad;
            this.Telefono = telefono;
            this.Movil = movil;
            this.Direccion1 = direccion1;
            this.Direccion2 = direccion2;
            this.Email = email;
            this.Inicio = inicio;
            this.Foto = foto;

            this.Estado = estado;

            this.Auto = auto;
            this.Filtro = filtro;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Produccion_Proveedor Proveedor)
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
                SqlCmd.CommandText = "Produccion.LA_Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@Idproveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@Idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = Proveedor.Idempleado;
                SqlCmd.Parameters.Add(ParIdempleado);


                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 20;
                ParTipo.Value = Proveedor.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParArea = new SqlParameter();
                ParArea.ParameterName = "@Area";
                ParArea.SqlDbType = SqlDbType.VarChar;
                ParArea.Size = 50;
                ParArea.Value = Proveedor.Area;
                SqlCmd.Parameters.Add(ParArea);

                SqlParameter ParProveedor = new SqlParameter();
                ParProveedor.ParameterName = "@Proveedor";
                ParProveedor.SqlDbType = SqlDbType.VarChar;
                ParProveedor.Size = 20;
                ParProveedor.Value = Proveedor.Proveedor;
                SqlCmd.Parameters.Add(ParProveedor);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = Proveedor.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 15;
                ParDocumento.Value = Proveedor.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Proveedor.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParRepresentante = new SqlParameter();
                ParRepresentante.ParameterName = "@Titular";
                ParRepresentante.SqlDbType = SqlDbType.VarChar;
                ParRepresentante.Size = 50;
                ParRepresentante.Value = Proveedor.Titular;
                SqlCmd.Parameters.Add(ParRepresentante);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = 20;
                ParPais.Value = Proveedor.Pais;
                SqlCmd.Parameters.Add(ParPais);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 20;
                ParCiudad.Value = Proveedor.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 20;
                ParMovil.Value = Proveedor.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParDireccion1 = new SqlParameter();
                ParDireccion1.ParameterName = "@Direccion1";
                ParDireccion1.SqlDbType = SqlDbType.VarChar;
                ParDireccion1.Size = 50;
                ParDireccion1.Value = Proveedor.Direccion1;
                SqlCmd.Parameters.Add(ParDireccion1);

                SqlParameter ParDireccion2 = new SqlParameter();
                ParDireccion2.ParameterName = "@Direccion2";
                ParDireccion2.SqlDbType = SqlDbType.VarChar;
                ParDireccion2.Size = 50;
                ParDireccion2.Value = Proveedor.Direccion2;
                SqlCmd.Parameters.Add(ParDireccion2);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 30;
                ParEmail.Value = Proveedor.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParInicio = new SqlParameter();
                ParInicio.ParameterName = "@Inicio";
                ParInicio.SqlDbType = SqlDbType.Date;
                ParInicio.Value = Proveedor.Inicio;
                SqlCmd.Parameters.Add(ParInicio);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@Logo";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Proveedor.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Proveedor.Auto;
                SqlCmd.Parameters.Add(ParAuto);

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

        public DataTable Buscar_Proveedor(Conexion_Produccion_Proveedor Proveedor)
        {
            DataTable DtResultado = new DataTable("Produccion.Proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Buscar_Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Proveedor.Filtro;
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

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Produccion.Proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Mostrar_Proveedor";
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

        public string Eliminar(Conexion_Produccion_Proveedor Proveedor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexión
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                //2. Abrir la conexión de la BD
                SqlCon.Open();
                //3. Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Eliminar_Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parámetros al comando
                //Establecemos los valores para el parámetro
                //@Idproveedor del Procedimiento Almacenado

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@Idproveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = Proveedor.Idproveedor;
                SqlCmd.Parameters.Add(ParIdproveedor);

                //Agregamos el parámetro al comando
                //5. Ejecutamos el commando
                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                //6. Cerramos la conexión con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public DataTable CodigoID_Solicitud(Conexion_Produccion_Proveedor CodigoID)
        {
            DataTable DtResultado = new DataTable("Produccion.Proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.ID_Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFiltro = new SqlParameter();
                ParFiltro.ParameterName = "@Filtro";
                ParFiltro.SqlDbType = SqlDbType.VarChar;
                ParFiltro.Size = 1;
                ParFiltro.Value = CodigoID.Filtro;
                SqlCmd.Parameters.Add(ParFiltro);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


    }
}

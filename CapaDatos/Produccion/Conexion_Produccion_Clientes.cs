using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Clientes
    {
        //Llaves Primarias
        private int _Idcliente;
        private int _Idempleado;
        private int _Estado;

        //Datos Basicos
        private string _Cliente;
        private string _Documento;
        private string _Pais;
        private string _Ciudad;
        private string _Movil;
        private string _Telefono;
        private string _Email;
        private string _Direccion;

        //Variables segun el proceso sea Insertar,Guardar,Buscar
        private int _Auto;
        private string _Filtro;

        public int Idcliente { get => Idcliente1; set => Idcliente1 = value; }
        public int Idcliente1 { get => _Idcliente; set => _Idcliente = value; }
        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string Cliente { get => _Cliente; set => _Cliente = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Movil { get => _Movil; set => _Movil = value; }

        public Conexion_Produccion_Clientes()
        {

        }

        public Conexion_Produccion_Clientes
            (
                int idcliente, int idempleado, string cliente, string documento, 
                string pais, string ciudad, string telefono, string movil, string email, string direccion, 
                
                int auto, string filtro
            )
        {
            this.Idcliente = idcliente;
            this.Idempleado = idempleado;
            this.Cliente =cliente;
            this.Documento = documento;
            this.Pais = pais;
            this.Ciudad = ciudad;
            this.Movil = movil;
            this.Telefono = telefono;
            this.Email = email;
            this.Direccion = direccion;

            this.Auto = auto;
            this.Filtro = filtro;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Produccion_Clientes Cliente)
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
                SqlCmd.CommandText = "Produccion.LA_Clientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@Idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Cliente.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@Idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = Cliente.Idempleado;
                SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Cliente.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParCliente = new SqlParameter();
                ParCliente.ParameterName = "@Cliente";
                ParCliente.SqlDbType = SqlDbType.VarChar;
                ParCliente.Size = 50;
                ParCliente.Value = Cliente.Cliente;
                SqlCmd.Parameters.Add(ParCliente);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 20;
                ParDocumento.Value = Cliente.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = 20;
                ParPais.Value = Cliente.Pais;
                SqlCmd.Parameters.Add(ParPais);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 20;
                ParCiudad.Value = Cliente.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 50;
                ParMovil.Value = Cliente.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

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

        public DataTable Buscar_Cliente(Conexion_Produccion_Clientes Clientes)
        {
            DataTable DtResultado = new DataTable("Produccion.Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Buscar_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Clientes.Filtro;
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
        public DataTable CodigoID_Solicitud(Conexion_Produccion_Clientes CodigoID)
        {
            DataTable DtResultado = new DataTable("Produccion.Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.ID_Cliente";
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

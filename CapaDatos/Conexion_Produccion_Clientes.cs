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
        private int _Idcliente;
        private int _Idestado;
        private int _Idciudad;
        private int _Idpais;

        private string _CodigoID;
        private string _Cliente;
        private string _Documento;
        private string _Identificacion;
        private string _Telefono;
        private string _Movil;
        private string _Email;
        private string _Direccion;

        private int _Auto;
        private string _Filtro;

        public int Idcliente { get => _Idcliente; set => _Idcliente = value; }
        public int Idestado { get => _Idestado; set => _Idestado = value; }
        public int Idciudad { get => _Idciudad; set => _Idciudad = value; }
        public int Idpais { get => _Idpais; set => _Idpais = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string Cliente { get => _Cliente; set => _Cliente = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        public Conexion_Produccion_Clientes()
        {

        }

        public Conexion_Produccion_Clientes(
            int idcliente, int idciudad, int idpais, string codigoid, string cliente, string documento, 
            string identificacion, string telefono, string movil, string email, string direccion, int auto, string filtro
            )
        {
            this.Idcliente = idcliente;
            this.Idciudad = idciudad;
            this.Idestado = Idestado;
            this.Idpais = idpais;
            this.CodigoID = codigoid;
            this.Cliente = cliente;
            this.Documento = documento;
            this.Identificacion = identificacion;
            this.Telefono = telefono;
            this.Movil = movil;
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
                SqlCmd.CommandText = "Produccion.AJ_Cliente";
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

                SqlParameter ParIdestado = new SqlParameter();
                ParIdestado.ParameterName = "@Idestado";
                ParIdestado.SqlDbType = SqlDbType.Int;
                ParIdestado.Value = Cliente.Idestado;
                SqlCmd.Parameters.Add(ParIdestado);

                SqlParameter ParIdpais = new SqlParameter();
                ParIdpais.ParameterName = "@Idpais";
                ParIdpais.SqlDbType = SqlDbType.Int;
                ParIdpais.Value = Cliente.Idpais;
                SqlCmd.Parameters.Add(ParIdpais);

                SqlParameter ParIdciudad = new SqlParameter();
                ParIdciudad.ParameterName = "@Idciudad";
                ParIdciudad.SqlDbType = SqlDbType.Int;
                ParIdciudad.Value = Cliente.Idciudad;
                SqlCmd.Parameters.Add(ParIdciudad);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = Cliente.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                //SqlParameter ParAutor = new SqlParameter();
                //ParAutor.ParameterName = "@Autor";
                //ParAutor.SqlDbType = SqlDbType.VarChar;
                //ParAutor.Size = 50;
                //ParAutor.Value = Cliente.Autor;
                //SqlCmd.Parameters.Add(ParAutor);

                //SqlParameter ParFecha = new SqlParameter();
                //ParFecha.ParameterName = "@Fecha";
                //ParFecha.SqlDbType = SqlDbType.Date;
                //ParFecha.Value = Cliente.Fecha;
                //SqlCmd.Parameters.Add(ParFecha);

                //SqlParameter ParCantidad = new SqlParameter();
                //ParCantidad.ParameterName = "@Cantidad";
                //ParCantidad.SqlDbType = SqlDbType.VarChar;
                //ParCantidad.Size = 20;
                //ParCantidad.Value = Cliente.Cantidad;
                //SqlCmd.Parameters.Add(ParCantidad);

                //SqlParameter ParSerie = new SqlParameter();
                //ParSerie.ParameterName = "@serie";
                //ParSerie.SqlDbType = SqlDbType.VarChar;
                //ParSerie.Size = 20;
                //ParSerie.Value = Cliente.Serie;
                //SqlCmd.Parameters.Add(ParSerie);

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

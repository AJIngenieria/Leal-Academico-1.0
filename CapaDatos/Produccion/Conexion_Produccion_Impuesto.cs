using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Impuesto
    {
        //Llaves primarias
        private int _Idimpuesto;
        private string _Auto;
        private string _Filtro;
        private int _Estado;

        //Adicional
        private int _Resultado;
        private int _Idproveedor;
        private string _Marca;
        private string _Descripcion;

        //Datos Basicos
        private string _Impuesto;
        private string _Tipo;
        private int _Valor;

        public int Idimpuesto { get => _Idimpuesto; set => _Idimpuesto = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Impuesto { get => _Impuesto; set => _Impuesto = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public int Valor { get => _Valor; set => _Valor = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public int Resultado { get => _Resultado; set => _Resultado = value; }
        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        //Constructores
        public Conexion_Produccion_Impuesto()
        {

        }
        public Conexion_Produccion_Impuesto
            (//Datos Basicos
            int idimpuesto, string impuesto, string tipo, int valor,

            string filtro, string auto, int estado, 
            
            int idproveedor, int resultado,
            string marca,string descripcion)
        {
            this.Estado = estado;
            this.Auto = auto;
            this.Filtro = filtro;

            this.Impuesto = impuesto;
            this.Tipo = tipo;
            this.Valor = valor;

            this.Idproveedor = idproveedor;
            this.Marca = marca;
            this.Descripcion = descripcion;
            this.Resultado = resultado;
        }

        public string Guardar_DatosBasicos(Conexion_Produccion_Impuesto DatosBasicos)
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
                SqlCmd.CommandText = "Produccion.AJ_Impuestos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdimpuesto = new SqlParameter();
                ParIdimpuesto.ParameterName = "@Idimpuesto";
                ParIdimpuesto.SqlDbType = SqlDbType.Int;
                ParIdimpuesto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdimpuesto);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = DatosBasicos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParImpuesto = new SqlParameter();
                ParImpuesto.ParameterName = "@Impuesto";
                ParImpuesto.SqlDbType = SqlDbType.VarChar;
                ParImpuesto.Size = 30;
                ParImpuesto.Value = DatosBasicos.Impuesto;
                SqlCmd.Parameters.Add(ParImpuesto);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 20;
                ParTipo.Value = DatosBasicos.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

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

        public DataTable Buscar_Impuesto(Conexion_Produccion_Impuesto Impuesto)
        {
            DataTable DtResultado = new DataTable("Produccion.Impuestos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Buscar_Impuestos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Impuesto.Filtro;
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

        public DataTable Mostrar_Impuesto()
        {
            DataTable DtResultado = new DataTable("Produccion.Impuestos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Mostrar_Impuestos";
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

        public string Guardar_AutoGenerador(Conexion_Produccion_Impuesto DatosBasicos)
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
                SqlCmd.CommandText = "Produccion.AutoGenerado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdimpuesto = new SqlParameter();
                ParIdimpuesto.ParameterName = "@Idimpuesto";
                ParIdimpuesto.SqlDbType = SqlDbType.Int;
                ParIdimpuesto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdimpuesto);

                SqlParameter ParIdmarcas = new SqlParameter();
                ParIdmarcas.ParameterName = "@Idmarcas";
                ParIdmarcas.SqlDbType = SqlDbType.Int;
                ParIdmarcas.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdmarcas);

                SqlParameter ParImpuesto = new SqlParameter();
                ParImpuesto.ParameterName = "@Impuesto";
                ParImpuesto.SqlDbType = SqlDbType.VarChar;
                ParImpuesto.Size = 30;
                ParImpuesto.Value = DatosBasicos.Impuesto;
                SqlCmd.Parameters.Add(ParImpuesto);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 20;
                ParTipo.Value = DatosBasicos.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@Valor";
                ParValor.SqlDbType = SqlDbType.Int;
                ParValor.Value = DatosBasicos.Valor;
                SqlCmd.Parameters.Add(ParValor);

                //Datos de Marcas

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@Idproveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = DatosBasicos.Idproveedor;
                SqlCmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@Marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 50;
                ParMarca.Value = DatosBasicos.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                ParDescripcion.Value = DatosBasicos.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

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

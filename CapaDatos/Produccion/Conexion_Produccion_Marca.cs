using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Marca
    {
        private int _Idmarca;
        private int _Estado;
        private int _Idproveedor;
        private string _Marca;
        private string _Descripcion;

        private int _Auto;
        private string _Filtro;

        public int Idmarca { get => _Idmarca; set => _Idmarca = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        public Conexion_Produccion_Marca()
        {

        }
        public Conexion_Produccion_Marca
            (
                int idmarca, int estado, int idproveedor, string marca, string descripcion, int auto, string filtro
            )
        {
            this.Idmarca = idmarca;
            this.Idproveedor = idproveedor;
            this.Marca = marca;
            this.Estado = estado;
            this.Descripcion = descripcion;

            this.Auto = auto;
            this.Filtro = filtro;
        }

        public string Guardar_DatosBasicos(Conexion_Produccion_Marca Marcas)
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
                SqlCmd.CommandText = "Produccion.LA_Marcas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdmarcas = new SqlParameter();
                ParIdmarcas.ParameterName = "@Idmarcas";
                ParIdmarcas.SqlDbType = SqlDbType.Int;
                ParIdmarcas.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdmarcas);

                SqlParameter ParIdestado = new SqlParameter();
                ParIdestado.ParameterName = "@Estado";
                ParIdestado.SqlDbType = SqlDbType.Int;
                ParIdestado.Value = Marcas.Estado;
                SqlCmd.Parameters.Add(ParIdestado);

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@Idproveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = Marcas.Idproveedor;
                SqlCmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Marcas.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@Marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 50;
                ParMarca.Value = Marcas.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 100;
                ParDescripcion.Value = Marcas.Descripcion;
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

        public DataTable Buscar_Marca(Conexion_Produccion_Marca Marca)
        {
            DataTable DtResultado = new DataTable("Produccion.Marcas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Buscar_Marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Marca.Filtro;
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
            DataTable DtResultado = new DataTable("Produccion.Marcas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Mostrar_Marcas";
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

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
        private int _Idestado;
        private int _Idproveedor;
        private string _Descripcion;

        private int _Auto;
        private string _Filtro;

        public int Idmarca { get => _Idmarca; set => _Idmarca = value; }
        public int Idestado { get => _Idestado; set => _Idestado = value; }
        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        public Conexion_Produccion_Marca()
        {

        }
        public Conexion_Produccion_Marca(
            int idmarca, int idestado, int idproveedor, string descripcion, int auto, string filtro
            )
        {
            this.Idmarca = idmarca;
            this.Idestado = idestado;
            this.Idproveedor = idproveedor;
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
                SqlCmd.CommandText = "Produccion.AJ_Marcas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdmarcas = new SqlParameter();
                ParIdmarcas.ParameterName = "@Idmarcas";
                ParIdmarcas.SqlDbType = SqlDbType.Int;
                ParIdmarcas.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdmarcas);

                SqlParameter ParIdestado = new SqlParameter();
                ParIdestado.ParameterName = "@Idestado";
                ParIdestado.SqlDbType = SqlDbType.Int;
                ParIdestado.Value = Marcas.Idestado;
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

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
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

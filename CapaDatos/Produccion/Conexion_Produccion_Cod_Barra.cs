using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Cod_Barra
    {
        private int _Idcodigo;
        private int _Idproducto;
        private string _Marca;
        private string _Referencia;
        private string _Codigo;

        private string _Filtro;
        private int _Auto;

        public int Idcodigo { get => _Idcodigo; set => _Idcodigo = value; }
        public int Idproducto { get => _Idproducto; set => _Idproducto = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Referencia { get => _Referencia; set => _Referencia = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public int Auto { get => _Auto; set => _Auto = value; }

        public Conexion_Produccion_Cod_Barra()
        {

        }

        public Conexion_Produccion_Cod_Barra
            
            (
            
                int auto,int idcodigo, int idproducto, 
                string codigo, string marca, string referencia,
                string filtro
            
            )
        {
            this.Idcodigo = idcodigo;
            this.Idproducto = idproducto;
            this.Codigo = codigo;
            this.Marca = marca;
            this.Referencia = referencia;

            this.Auto = auto;
            this.Filtro = filtro;
        }

        public string Guardar_DatosBasicos(Conexion_Produccion_Cod_Barra Codigos)
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
                SqlCmd.CommandText = "Produccion.LA_CodigosDeBarra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcodigo = new SqlParameter();
                ParIdcodigo.ParameterName = "@Idcodigo";
                ParIdcodigo.SqlDbType = SqlDbType.Int;
                ParIdcodigo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcodigo);

                SqlParameter ParIdproducto = new SqlParameter();
                ParIdproducto.ParameterName = "@idproducto";
                ParIdproducto.SqlDbType = SqlDbType.Int;
                ParIdproducto.Value = Codigos.Idproducto;
                SqlCmd.Parameters.Add(ParIdproducto);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Codigos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@Codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Codigos.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@Marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 50;
                ParMarca.Value = Codigos.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParReferencia = new SqlParameter();
                ParReferencia.ParameterName = "@Referencia";
                ParReferencia.SqlDbType = SqlDbType.VarChar;
                ParReferencia.Size = 50;
                ParReferencia.Value = Codigos.Referencia;
                SqlCmd.Parameters.Add(ParReferencia);

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

        public DataTable Buscar_CodigoDeBarra(Conexion_Produccion_Cod_Barra Codigos)
        {
            DataTable DtResultado = new DataTable("Produccion.Codigos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Buscar_CodigoDeBarra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Codigos.Filtro;
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

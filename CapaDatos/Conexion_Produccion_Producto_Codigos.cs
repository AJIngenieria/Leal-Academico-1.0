using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Producto_Codigos
    {
        private int _Idcodigo;
        private int _Idproducto;
        private string _Codigo;

        public int Idcodigo { get => _Idcodigo; set => _Idcodigo = value; }
        public int Idproducto { get => _Idproducto; set => _Idproducto = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }

        public Conexion_Produccion_Producto_Codigos()
        {

        }

        public Conexion_Produccion_Producto_Codigos(int idcodigo, int idproducto, string codigo)
        {
            this.Idcodigo = idcodigo;
            this.Idproducto = idproducto;
            this.Codigo = codigo;
        }

        public string Guardar_DatosBasicos(Conexion_Produccion_Producto_Codigos Detalle_de_Codigos, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Produccion.AJ_Productos_Codigos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcodigo = new SqlParameter();
                ParIdcodigo.ParameterName = "@Idcodigo";
                ParIdcodigo.SqlDbType = SqlDbType.Int;
                ParIdcodigo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcodigo);

                SqlParameter ParIdproducto = new SqlParameter();
                ParIdproducto.ParameterName = "@idproducto";
                ParIdproducto.SqlDbType = SqlDbType.Int;
                ParIdproducto.Value = Detalle_de_Codigos.Idproducto;
                SqlCmd.Parameters.Add(ParIdproducto);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@Codigo";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Size = 50;
                ParCodigo.Value = Detalle_de_Codigos.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }

    }
}

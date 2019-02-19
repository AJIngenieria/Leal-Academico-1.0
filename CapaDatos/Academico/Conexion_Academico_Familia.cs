using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Familia
    {
        private int _Idfamilia;
        private string _Familia;
        private string _Descripcion;

        private string _Auto;
        private string _Filtro;

        public int Idfamilia { get => _Idfamilia; set => _Idfamilia = value; }
        public string Familia { get => _Familia; set => _Familia = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        public Conexion_Academico_Familia()
        {

        }

        //Constructor con todos los parametros
        public Conexion_Academico_Familia(int idfamilia, string familia,string descripcion, string auto)
        {
            //Datos Basicos
            this.Idfamilia = idfamilia;
            this.Familia = familia;
            this.Descripcion = descripcion;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Academico_Familia Familia)
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
                SqlCmd.CommandText = "Academico.AJ_Familia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdfamilia = new SqlParameter();
                ParIdfamilia.ParameterName = "@Idfamilia";
                ParIdfamilia.SqlDbType = SqlDbType.Int;
                ParIdfamilia.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdfamilia);

                SqlParameter ParFamilia = new SqlParameter();
                ParFamilia.ParameterName = "@Familia";
                ParFamilia.SqlDbType = SqlDbType.VarChar;
                ParFamilia.Size = 50;
                ParFamilia.Value = Familia.Familia;
                SqlCmd.Parameters.Add(ParFamilia);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 200;
                ParDescripcion.Value = Familia.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Familia.Auto;
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

        public DataTable Buscar(Conexion_Academico_Familia Familia)
        {
            DataTable DtResultado = new DataTable("Academico.Familias");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Academico.Buscar_Familias";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Familia.Filtro;
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

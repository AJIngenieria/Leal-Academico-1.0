using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Producto
    {
        //Llaves primarias
        private int _Idproductos;
        private int _Idempleado;
        private int _Idestado;
        private int _Idmarca;

        private int _Auto;
        
        private string _Filtro;

        //Datos Basicos
        private string _CodigoID;
        private string _Producto;
        private string _Descripcion;
        private string _Referencia;
        private string _Importado;
        private string _Empacada;
        private string _Vence;
        private string _Grupo;
        private string _Ofertable;
        private string _Ubicacion;

        public int Idproductos { get => _Idproductos; set => _Idproductos = value; }
        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public int Idestado { get => _Idestado; set => _Idestado = value; }
        public int Idmarca { get => _Idmarca; set => _Idmarca = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string Producto { get => _Producto; set => _Producto = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Referencia { get => _Referencia; set => _Referencia = value; }
        public string Importado { get => _Importado; set => _Importado = value; }
        public string Empacada { get => _Empacada; set => _Empacada = value; }
        public string Vence { get => _Vence; set => _Vence = value; }
        public string Grupo { get => _Grupo; set => _Grupo = value; }
        public string Ofertable { get => _Ofertable; set => _Ofertable = value; }
        public string Ubicacion { get => _Ubicacion; set => _Ubicacion = value; }


        public Conexion_Produccion_Producto()
        {

        }
        public Conexion_Produccion_Producto(
            
            int idempleado, int auto, int idestado, string filtro, 
            string codigoid, string producto, string descripcion, string referencia, string importado, string empacado, string vence, string grupo,
            string ofertable, string ubicacion
            )

        {
            this.Idempleado = idempleado;
            this.Auto = auto;

            this.Idestado = idestado;
            this.Filtro = filtro;

            //Datos Basicos
            this.CodigoID = codigoid;
            this.Producto = producto;
            this.Descripcion = descripcion;
            this.Referencia = referencia;
            this.Importado = importado;
            this.Empacada = empacado;
            this.Vence = vence;
            this.Grupo = grupo;
            this.Ofertable = ofertable;
            this.Ubicacion = ubicacion;
        }

        
        //Método Insertar
        public string Guardar_DatosBasicos(Conexion_Produccion_Producto DatosBasicos)
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
                SqlCmd.CommandText = "Produccion.AJ_Productos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdproducto = new SqlParameter();
                ParIdproducto.ParameterName = "@Idproducto";
                ParIdproducto.SqlDbType = SqlDbType.Int;
                ParIdproducto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdproducto);

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@Idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = DatosBasicos.Idempleado;
                SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParIdmarca = new SqlParameter();
                ParIdmarca.ParameterName = "@Idmarca";
                ParIdmarca.SqlDbType = SqlDbType.Int;
                ParIdmarca.Value = DatosBasicos.Idmarca;
                SqlCmd.Parameters.Add(ParIdmarca);

                SqlParameter ParIdestado = new SqlParameter();
                ParIdestado.ParameterName = "@Idestado";
                ParIdestado.SqlDbType = SqlDbType.Int;
                ParIdestado.Value = DatosBasicos.Idestado;
                SqlCmd.Parameters.Add(ParIdestado);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = DatosBasicos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = DatosBasicos.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParProducto = new SqlParameter();
                ParProducto.ParameterName = "@Producto";
                ParProducto.SqlDbType = SqlDbType.VarChar;
                ParProducto.Size = 50;
                ParProducto.Value = DatosBasicos.Producto;
                SqlCmd.Parameters.Add(ParProducto);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                ParDescripcion.Value = DatosBasicos.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParReferencia = new SqlParameter();
                ParReferencia.ParameterName = "@Referencia";
                ParReferencia.SqlDbType = SqlDbType.VarChar;
                ParReferencia.Size = 50;
                ParReferencia.Value = DatosBasicos.Referencia;
                SqlCmd.Parameters.Add(ParReferencia);

                SqlParameter ParImportado = new SqlParameter();
                ParImportado.ParameterName = "@Importado";
                ParImportado.SqlDbType = SqlDbType.VarChar;
                ParImportado.Size = 5;
                ParImportado.Value = DatosBasicos.Importado;
                SqlCmd.Parameters.Add(ParImportado);

                SqlParameter ParEmpacado = new SqlParameter();
                ParEmpacado.ParameterName = "@Empacado";
                ParEmpacado.SqlDbType = SqlDbType.VarChar;
                ParEmpacado.Size = 10;
                ParEmpacado.Value = DatosBasicos.Empacada;
                SqlCmd.Parameters.Add(ParEmpacado);

                SqlParameter ParVence = new SqlParameter();
                ParVence.ParameterName = "@Vence";
                ParVence.SqlDbType = SqlDbType.VarChar;
                ParVence.Size = 5;
                ParVence.Value = DatosBasicos.Vence;
                SqlCmd.Parameters.Add(ParVence);

                SqlParameter ParGrupo = new SqlParameter();
                ParGrupo.ParameterName = "@Grupo";
                ParGrupo.SqlDbType = SqlDbType.VarChar;
                ParGrupo.Size = 10;
                ParGrupo.Value = DatosBasicos.Grupo;
                SqlCmd.Parameters.Add(ParGrupo);

                SqlParameter ParOfertable = new SqlParameter();
                ParOfertable.ParameterName = "@Ofertable";
                ParOfertable.SqlDbType = SqlDbType.VarChar;
                ParOfertable.Size = 10;
                ParOfertable.Value = DatosBasicos.Ofertable;
                SqlCmd.Parameters.Add(ParOfertable);

                SqlParameter ParUbicacion = new SqlParameter();
                ParUbicacion.ParameterName = "@Ubicacion";
                ParUbicacion.SqlDbType = SqlDbType.VarChar;
                ParUbicacion.Size = 10;
                ParUbicacion.Value = DatosBasicos.Ubicacion;
                SqlCmd.Parameters.Add(ParUbicacion);

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

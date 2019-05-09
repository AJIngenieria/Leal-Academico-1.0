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
        
        //Datos Basicos
        private int _Idproductos;
        private int _Idempleado;
        private int _Idmarca;
        
        private int _CodigoID;
        private string _Producto;
        private string _Referencia;
        private string _Descripcion;
        private string _Ofertable;
        private string _Importado;
        private string _Empacada;
        
        private string _Tipo;
        private string _Grupo;
        private string _Vence;
        private int _Estado;

        //Panel - Costos y Precios
        private string _ValorCompra;
        private string _ValorVenta1;
        private string _ValorVenta2;
        private string _ValorVenta3;
        private string _ValorOferta;
        private string _ValorVentaPublico;
        private string _Ca_Minima;
        private string _Ca_Maxima;


        //Panel - Impuestos Otros Datos
        private int _Idimpuesto;
        private int _Idbodega;
        private int _Idproveedor;
        private string _Ubicacion;
        private string _UnidadDeVenta;
        private string _Observacion;

        //Filtros y Metodos
        private int _Auto;
        private string _Filtro;

        public int Idproductos { get => _Idproductos; set => _Idproductos = value; }
        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public int Idmarca { get => _Idmarca; set => _Idmarca = value; }
        public int CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string Producto { get => _Producto; set => _Producto = value; }
        public string Referencia { get => _Referencia; set => _Referencia = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Ofertable { get => _Ofertable; set => _Ofertable = value; }
        public string Importado { get => _Importado; set => _Importado = value; }
        public string Empacada { get => _Empacada; set => _Empacada = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Grupo { get => _Grupo; set => _Grupo = value; }
        public string Vence { get => _Vence; set => _Vence = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string ValorCompra { get => _ValorCompra; set => _ValorCompra = value; }
        public string ValorVenta1 { get => _ValorVenta1; set => _ValorVenta1 = value; }
        public string ValorVenta2 { get => _ValorVenta2; set => _ValorVenta2 = value; }
        public string ValorVenta3 { get => _ValorVenta3; set => _ValorVenta3 = value; }
        public string ValorOferta { get => _ValorOferta; set => _ValorOferta = value; }
        public string ValorVentaPublico { get => _ValorVentaPublico; set => _ValorVentaPublico = value; }
        public string Ca_Minima { get => _Ca_Minima; set => _Ca_Minima = value; }
        public string Ca_Maxima { get => _Ca_Maxima; set => _Ca_Maxima = value; }
        public int Idimpuesto { get => _Idimpuesto; set => _Idimpuesto = value; }
        public int Idbodega { get => _Idbodega; set => _Idbodega = value; }
        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public string Ubicacion { get => _Ubicacion; set => _Ubicacion = value; }
        public string UnidadDeVenta { get => _UnidadDeVenta; set => _UnidadDeVenta = value; }
        public string Observacion { get => _Observacion; set => _Observacion = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        public Conexion_Produccion_Producto()
        {

        }
        public Conexion_Produccion_Producto
            (
                //llaves Primarias

                int idproducto, int idempleado,
                
                //Datos Basicos
                
                int idmarca, int codigoid, string producto, string referencia, string descripcion, 
                string ofertable, string importado, string empacado, string tipo, string grupo, string vence,

                //Costos de Productos
                string va_compra, string va_venta01, string va_venta02, string va_venta03,
                string va_oferta, string va_ventapublico, string ca_maxima, string ca_minimo,

                //Impuestos - Otros Datos
                int idimpuesto, int idbodega, int idproveedor, 
                string ubicacion, string unidaddeventa, string observacion,

                //Filtros y Metodo
                int estado, int auto, string filtro
            )

        {
            //Llave Primaria
            this.Idempleado = idempleado;

            //Datos Basicos
            this.Idmarca = idmarca;
            this.CodigoID = codigoid;
            this.Producto = producto;
            this.Descripcion = descripcion;
            this.Referencia = referencia;
            this.Ofertable = ofertable;
            this.Importado = importado;
            this.Empacada = empacado;
            this.Tipo = tipo;
            this.Vence = vence;
            this.Grupo = grupo;

            //Costos de Productos

            this.ValorCompra = ValorCompra;
            this.ValorVenta1 = va_venta01;
            this.ValorVenta2 = va_venta02;
            this.ValorVenta3 = va_venta03;
            this.ValorOferta = va_oferta;
            this.ValorVentaPublico = va_ventapublico;
            this.Ca_Minima = ca_minimo;
            this.Ca_Maxima = ca_maxima;

            //Impuestos - Otros Datos
            this.Idbodega = idbodega;
            this.Idproveedor = idproveedor;
            this.Idimpuesto = idimpuesto;
            this.Ubicacion = ubicacion;
            this.UnidadDeVenta = unidaddeventa;
            this.Observacion = observacion;

            //Metodos y Filtros

            this.Auto = auto;
            this.Estado = estado;
            this.Filtro = filtro;
            
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
                SqlCmd.CommandText = "Produccion.LA_Productos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos

                //Panel de Datos Basicos - Formulario frmProduccion_Productos
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

                //SqlParameter ParIdproveedor = new SqlParameter();
                //ParIdproveedor.ParameterName = "@Idproveedor";
                //ParIdproveedor.SqlDbType = SqlDbType.Int;
                //ParIdproveedor.Value = DatosBasicos.Idproveedor;
                //SqlCmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.Int;
                ParCodigoID.Value = DatosBasicos.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParProducto = new SqlParameter();
                ParProducto.ParameterName = "@Producto";
                ParProducto.SqlDbType = SqlDbType.VarChar;
                ParProducto.Size = 50;
                ParProducto.Value = DatosBasicos.Producto;
                SqlCmd.Parameters.Add(ParProducto);

                SqlParameter ParReferencia = new SqlParameter();
                ParReferencia.ParameterName = "@Referencia";
                ParReferencia.SqlDbType = SqlDbType.VarChar;
                ParReferencia.Size = 50;
                ParReferencia.Value = DatosBasicos.Referencia;
                SqlCmd.Parameters.Add(ParReferencia);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                ParDescripcion.Value = DatosBasicos.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParOfertable = new SqlParameter();
                ParOfertable.ParameterName = "@Ofertable";
                ParOfertable.SqlDbType = SqlDbType.VarChar;
                ParOfertable.Size = 10;
                ParOfertable.Value = DatosBasicos.Ofertable;
                SqlCmd.Parameters.Add(ParOfertable);

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

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 10;
                ParTipo.Value = DatosBasicos.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParGrupo = new SqlParameter();
                ParGrupo.ParameterName = "@Grupo";
                ParGrupo.SqlDbType = SqlDbType.VarChar;
                ParGrupo.Size = 10;
                ParGrupo.Value = DatosBasicos.Grupo;
                SqlCmd.Parameters.Add(ParGrupo);

                SqlParameter ParVence = new SqlParameter();
                ParVence.ParameterName = "@Vence";
                ParVence.SqlDbType = SqlDbType.VarChar;
                ParVence.Size = 5;
                ParVence.Value = DatosBasicos.Vence;
                SqlCmd.Parameters.Add(ParVence);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = DatosBasicos.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = DatosBasicos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                //Panel de Datos Basicos - Formulario frmProduccion_Productos

                //SqlParameter ParUbicacion = new SqlParameter();
                //ParUbicacion.ParameterName = "@Ubicacion";
                //ParUbicacion.SqlDbType = SqlDbType.VarChar;
                //ParUbicacion.Size = 30;
                //ParUbicacion.Value = DatosBasicos.Ubicacion;
                //SqlCmd.Parameters.Add(ParUbicacion);

                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "Error al Registrar";
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

        public DataTable CodigoID_Solicitud(Conexion_Produccion_Producto CodigoID)
        {
            DataTable DtResultado = new DataTable("Produccion.Productos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.ID_Productos";
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

        public DataTable Buscar_Producto(Conexion_Produccion_Producto Producto)
        {
            DataTable DtResultado = new DataTable("Produccion.Producto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Buscar_Productos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Producto.Filtro;
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

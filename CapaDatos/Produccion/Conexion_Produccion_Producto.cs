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
        private int _Idbodega;
        private string _Producto;
        private string _Referencia;
        private string _Descripcion;
        private string _Ofertable;
        private string _Importado;
        private string _Empacada;
        
        private string _Tipo;
        private string _Grupo;
        private string _Vence;
        private string _Dias;
        private string _Balanza;
        private int _Estado;

        //Codigo de Barras
        private int _Idcodigodebarra;
        private string _CodigoDeBarra;

        //Panel - Costos de Productos
        private int _Idcostos;
        private string _ValorCompra;
        private string _ValorVenta1;
        private string _ValorVenta2;
        private string _ValorVenta3;
        private string _ValorOferta1;
        private string _ValorOferta2;
        private string _ValorVentaPublico;
        private string _Ca_Minima;
        private string _Ca_Maxima;
        private string _UnidadDeVenta;

        //Panel - Impuestos
        private int _IdimpuestoProducto;
        private int _Idimpuesto;

        //Panel Distribuidor y/o Distribucion
        private int _Iddistribucion;
        private int _Idproveedor;
        private int _CodigoDistribucion;

        //Codigos Autogenerados

        private int _CodigoBasico;
        private int _CodigoCostos;
        private int _CodigoImpuesto;
        private int _CodigoProveedor;
        private int _CodigoBarra;


        //Filtros y Metodos
        private int _Auto;
        private string _Filtro;

        public int Idproductos { get => _Idproductos; set => _Idproductos = value; }
        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public int Idmarca { get => _Idmarca; set => _Idmarca = value; }
        public int Idbodega { get => _Idbodega; set => _Idbodega = value; }
        public string Producto { get => _Producto; set => _Producto = value; }
        public string Referencia { get => _Referencia; set => _Referencia = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Ofertable { get => _Ofertable; set => _Ofertable = value; }
        public string Importado { get => _Importado; set => _Importado = value; }
        public string Empacada { get => _Empacada; set => _Empacada = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Grupo { get => _Grupo; set => _Grupo = value; }
        public string Vence { get => _Vence; set => _Vence = value; }
        public string Dias { get => _Dias; set => _Dias = value; }
        public string Balanza { get => _Balanza; set => _Balanza = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public int Idcodigodebarra { get => _Idcodigodebarra; set => _Idcodigodebarra = value; }
        public string CodigoDeBarra { get => _CodigoDeBarra; set => _CodigoDeBarra = value; }
        public int Idcostos { get => _Idcostos; set => _Idcostos = value; }
        public string ValorCompra { get => _ValorCompra; set => _ValorCompra = value; }
        public string ValorVenta1 { get => _ValorVenta1; set => _ValorVenta1 = value; }
        public string ValorVenta2 { get => _ValorVenta2; set => _ValorVenta2 = value; }
        public string ValorVenta3 { get => _ValorVenta3; set => _ValorVenta3 = value; }
        public string ValorOferta1 { get => _ValorOferta1; set => _ValorOferta1 = value; }
        public string ValorOferta2 { get => _ValorOferta2; set => _ValorOferta2 = value; }
        public string ValorVentaPublico { get => _ValorVentaPublico; set => _ValorVentaPublico = value; }
        public string Ca_Minima { get => _Ca_Minima; set => _Ca_Minima = value; }
        public string Ca_Maxima { get => _Ca_Maxima; set => _Ca_Maxima = value; }
        public string UnidadDeVenta { get => _UnidadDeVenta; set => _UnidadDeVenta = value; }
        public int IdimpuestoProducto { get => _IdimpuestoProducto; set => _IdimpuestoProducto = value; }
        public int Idimpuesto { get => _Idimpuesto; set => _Idimpuesto = value; }
        public int Iddistribucion { get => _Iddistribucion; set => _Iddistribucion = value; }
        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public int CodigoDistribucion { get => _CodigoDistribucion; set => _CodigoDistribucion = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public int CodigoBasico { get => _CodigoBasico; set => _CodigoBasico = value; }
        public int CodigoCostos { get => _CodigoCostos; set => _CodigoCostos = value; }
        public int CodigoImpuesto { get => _CodigoImpuesto; set => _CodigoImpuesto = value; }
        public int CodigoProveedor { get => _CodigoProveedor; set => _CodigoProveedor = value; }
        public int CodigoBarra { get => _CodigoBarra; set => _CodigoBarra = value; }

        public Conexion_Produccion_Producto()
        {

        }
        public Conexion_Produccion_Producto
            (
            
                //Datos Basicos
                int idempleado, int idproveedor, int idmarca, int idbodega, int idimpuesto,
                int idcostos, int idcodigodebarra,
            
                string producto, string descripcion, string referencia, string importado, string empacado, string vence, string grupo,
                string ofertable, int estado,

                //Costos de Productos
                int idproducto, string compra, string promedio,
                string va_maximo, string va_minimo, string ca_maxima, string ca_minimo, string impuesto, string valor,
                string balanza, string unidad, string medida,


                //Filtros y Metodo
                int auto, string filtro
            )

        {
            this.Idempleado = idempleado;
            this.Idproveedor = idproveedor;
            this.Auto = auto;
            this.Idmarca = idmarca;
            this.Idbodega = idbodega;
            this.Idimpuesto = idimpuesto;
            this.Idcostos = idcostos;
            this.Idcodigodebarra = idcodigodebarra;

            this.Estado = estado;
            this.Filtro = filtro;

            //Datos Basicos
            //this.CodigoID = codigoid;
            this.Producto = producto;
            this.Descripcion = descripcion;
            this.Referencia = referencia;
            this.Importado = importado;
            this.Empacada = empacado;
            this.Vence = vence;
            this.Grupo = grupo;
            this.Ofertable = ofertable;
            //this.Ubicacion = ubicacion;

            ////Costos de Productos
            //this.Compra = compra;
            //this.Promedio = promedio;
            //this.Va_Maximo = va_maximo;
            //this.Va_Minimo = va_minimo;
            //this.Ca_Maxima = ca_maxima;
            //this.Impuesto = impuesto;
            //this.Valor = valor;
            //this.Balanza = balanza;
            //this.Unidad = unidad;
            //this.Medida = medida;
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

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@Idproveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = DatosBasicos.Idproveedor;
                SqlCmd.Parameters.Add(ParIdproveedor);

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

                //SqlParameter ParCodigoID = new SqlParameter();
                //ParCodigoID.ParameterName = "@CodigoID";
                //ParCodigoID.SqlDbType = SqlDbType.VarChar;
                //ParCodigoID.Size = 20;
                //ParCodigoID.Value = DatosBasicos.CodigoID;
                //SqlCmd.Parameters.Add(ParCodigoID);

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

                //SqlParameter ParUbicacion = new SqlParameter();
                //ParUbicacion.ParameterName = "@Ubicacion";
                //ParUbicacion.SqlDbType = SqlDbType.VarChar;
                //ParUbicacion.Size = 30;
                //ParUbicacion.Value = DatosBasicos.Ubicacion;
                //SqlCmd.Parameters.Add(ParUbicacion);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_DetalleDeIngreso
    {
        private int _Iddetalledeingresos;
        private int _Idingresos;
        private int _Idproducto;
        private int _Stock_Inicial;
        private int _Stock_Actual;
        private int _Precio_de_Compra;
        private int _Precio_de_Venta;

        public int Iddetalledeingresos { get => _Iddetalledeingresos; set => _Iddetalledeingresos = value; }
        public int Idingresos { get => _Idingresos; set => _Idingresos = value; }
        public int Idproducto { get => _Idproducto; set => _Idproducto = value; }
        public int Stock_Inicial { get => _Stock_Inicial; set => _Stock_Inicial = value; }
        public int Stock_Actual { get => _Stock_Actual; set => _Stock_Actual = value; }
        public int Precio_de_Compra { get => _Precio_de_Compra; set => _Precio_de_Compra = value; }
        public int Precio_de_Venta { get => _Precio_de_Venta; set => _Precio_de_Venta = value; }

        public Conexion_Produccion_DetalleDeIngreso()
        {

        }
        public Conexion_Produccion_DetalleDeIngreso(int iddetalledeingresos, int idproducto, int idingresos, int stock_inicial, int stock_actual, int precio_de_compra, int precio_de_venta)
        {
            this.Iddetalledeingresos = iddetalledeingresos;
            this.Idproducto = idproducto;
            this.Idingresos = idingresos;
            this.Stock_Inicial = stock_inicial;
            this.Stock_Actual = stock_actual;
            this.Precio_de_Compra = precio_de_compra;
            this.Precio_de_Venta = precio_de_venta;
        }
        //Método Insertar
        public string Insertar(Conexion_Produccion_DetalleDeIngreso Detalle_de_Ingreso, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Almacen.spInsertar_DetalleDeIngresoAlmacen";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_ingreso = new SqlParameter();
                ParIddetalle_ingreso.ParameterName = "@iddetalledeingresos";
                ParIddetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_ingreso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_ingreso);

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idingresos";
                ParIdingreso.SqlDbType = SqlDbType.Int;
                ParIdingreso.Value = Detalle_de_Ingreso.Idingresos;
                SqlCmd.Parameters.Add(ParIdingreso);

                SqlParameter ParIdarticuloalmacen = new SqlParameter();
                ParIdarticuloalmacen.ParameterName = "@idarticulosalmacen";
                ParIdarticuloalmacen.SqlDbType = SqlDbType.Int;
                ParIdarticuloalmacen.Value = Detalle_de_Ingreso.Idproducto;
                SqlCmd.Parameters.Add(ParIdarticuloalmacen);

                SqlParameter ParPrecio_Compra = new SqlParameter();
                ParPrecio_Compra.ParameterName = "@Precio_de_Compra";
                ParPrecio_Compra.SqlDbType = SqlDbType.Int;
                ParPrecio_Compra.Value = Detalle_de_Ingreso.Precio_de_Compra;
                SqlCmd.Parameters.Add(ParPrecio_Compra);

                SqlParameter ParPrecio_Venta = new SqlParameter();
                ParPrecio_Venta.ParameterName = "@Precio_de_Venta";
                ParPrecio_Venta.SqlDbType = SqlDbType.Int;
                ParPrecio_Venta.Value = Detalle_de_Ingreso.Precio_de_Venta;
                SqlCmd.Parameters.Add(ParPrecio_Venta);

                SqlParameter ParStock_Inicial = new SqlParameter();
                ParStock_Inicial.ParameterName = "@Stock_Inicial";
                ParStock_Inicial.SqlDbType = SqlDbType.Int;
                ParStock_Inicial.Value = Detalle_de_Ingreso.Stock_Inicial;
                SqlCmd.Parameters.Add(ParStock_Inicial);

                SqlParameter ParStock_Actual = new SqlParameter();
                ParStock_Actual.ParameterName = "@Stock_Actual";
                ParStock_Actual.SqlDbType = SqlDbType.Int;
                ParStock_Actual.Value = Detalle_de_Ingreso.Stock_Actual;
                SqlCmd.Parameters.Add(ParStock_Actual);


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

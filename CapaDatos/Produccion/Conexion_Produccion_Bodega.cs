﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Bodega
    {
        private int _Idbodega;
        private int _Idempleados;
        private int _Idsucurzal;

        private string _Descripcion;
        private string _Responsable;
        private string _Ciudad;
        private string _Zona;
        private string _Direccion01;
        private string _Direccion02;
        private string _Telefono;
        private string _Movil;

        private int _Estado;
        private string _Auto;
        private string _Filtro;

        public int Idbodega { get => _Idbodega; set => _Idbodega = value; }
        public int Idempleados { get => _Idempleados; set => _Idempleados = value; }
        public int Idsucurzal { get => _Idsucurzal; set => _Idsucurzal = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Responsable { get => _Responsable; set => _Responsable = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Zona { get => _Zona; set => _Zona = value; }
        public string Direccion01 { get => _Direccion01; set => _Direccion01 = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion02 { get => _Direccion02; set => _Direccion02 = value; }
        public string Movil { get => _Movil; set => _Movil = value; }

        //Constructores
        public Conexion_Produccion_Bodega()
        {

        }
        public Conexion_Produccion_Bodega
            (
            //Datos Basicos
            int idbodega, int idempleado, int idsucurzal, string descripcion, string responsable, string ciudad, string zona,
            string direccion01, string direccion02, string telefono, string movil,

            string auto, int estado, string filtro)
        {
            this.Idbodega = idbodega;
            this.Idempleados = idempleado;
            this.Idsucurzal = idsucurzal;

            this.Auto = auto;
            this.Estado = estado;
            this.Filtro = filtro;

            this.Descripcion = descripcion;
            this.Responsable = responsable;
            this.Ciudad = ciudad;
            this.Zona = zona;

            this.Direccion01 = direccion01;
            this.Direccion02 = direccion02;
            this.Telefono = telefono;
            this.Movil = movil;
        }
              
        public string Guardar_DatosBasicos(Conexion_Produccion_Bodega DatosBasicos)
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
                SqlCmd.CommandText = "Produccion.LA_Bodega";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdbodega = new SqlParameter();
                ParIdbodega.ParameterName = "@Idbodega";
                ParIdbodega.SqlDbType = SqlDbType.Int;
                ParIdbodega.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdbodega);

                SqlParameter ParIdempleados = new SqlParameter();
                ParIdempleados.ParameterName = "@Idempleado";
                ParIdempleados.SqlDbType = SqlDbType.Int;
                ParIdempleados.Value = DatosBasicos.Idempleados;
                SqlCmd.Parameters.Add(ParIdempleados);

                SqlParameter ParSucurzal = new SqlParameter();
                ParSucurzal.ParameterName = "@Idsucurzal";
                ParSucurzal.SqlDbType = SqlDbType.Int;
                ParSucurzal.Value = DatosBasicos.Idsucurzal;
                SqlCmd.Parameters.Add(ParSucurzal);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = DatosBasicos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = DatosBasicos.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                ParDescripcion.Value = DatosBasicos.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParResponsable = new SqlParameter();
                ParResponsable.ParameterName = "@Responsable";
                ParResponsable.SqlDbType = SqlDbType.VarChar;
                ParResponsable.Size = 50;
                ParResponsable.Value = DatosBasicos.Responsable;
                SqlCmd.Parameters.Add(ParResponsable);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 20;
                ParCiudad.Value = DatosBasicos.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParZona = new SqlParameter();
                ParZona.ParameterName = "@Zona";
                ParZona.SqlDbType = SqlDbType.VarChar;
                ParZona.Size = 10;
                ParZona.Value = DatosBasicos.Zona;
                SqlCmd.Parameters.Add(ParZona);

                SqlParameter ParDireccion01 = new SqlParameter();
                ParDireccion01.ParameterName = "@Direccion01";
                ParDireccion01.SqlDbType = SqlDbType.VarChar;
                ParDireccion01.Size = 100;
                ParDireccion01.Value = DatosBasicos.Direccion01;
                SqlCmd.Parameters.Add(ParDireccion01);

                SqlParameter ParDireccion02 = new SqlParameter();
                ParDireccion02.ParameterName = "@Direccion02";
                ParDireccion02.SqlDbType = SqlDbType.VarChar;
                ParDireccion02.Size = 100;
                ParDireccion02.Value = DatosBasicos.Direccion02;
                SqlCmd.Parameters.Add(ParDireccion02);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 30;
                ParTelefono.Value = DatosBasicos.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 30;
                ParMovil.Value = DatosBasicos.Movil;
                SqlCmd.Parameters.Add(ParMovil);

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

        public DataTable Buscar_Bodega(Conexion_Produccion_Bodega Bodega)
        {
            DataTable DtResultado = new DataTable("Produccion.Bodega");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Buscar_Bodega";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Bodega.Filtro;
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

        public DataTable CodigoID_Solicitud(Conexion_Produccion_Bodega CodigoID)
        {
            DataTable DtResultado = new DataTable("Produccion.Bodega");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CodigoID.ID_Bodega";
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

    }
}

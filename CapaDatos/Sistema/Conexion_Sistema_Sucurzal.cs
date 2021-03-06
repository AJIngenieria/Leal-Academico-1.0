﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_Sucurzal
    {
        private int _Idsucurzal;
        private string _Auto;
        private string _Filtro;
        private string _Estado;

        private string _Sucurzal;
        private string _Ciudad;
        private string _Descripcion;

        public int Idsucurzal { get => _Idsucurzal; set => _Idsucurzal = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Sucurzal { get => _Sucurzal; set => _Sucurzal = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        //Constructores
        public Conexion_Sistema_Sucurzal()
        {

        }
        public Conexion_Sistema_Sucurzal
            (
            //Datos Basicos
            int idsucurzal, string sucurzal, string ciudad, string descripcion,
            string auto, string estado, string filtro)
        {
            this.Idsucurzal = idsucurzal;

            this.Auto = auto;
            this.Estado = estado;
            this.Filtro = filtro;

            this.Sucurzal = sucurzal;
            this.Ciudad = ciudad;
            this.Descripcion = descripcion;
        }



        public string Guardar_DatosBasicos(Conexion_Sistema_Sucurzal DatosBasicos)
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
                SqlCmd.CommandText = "Produccion.AJ_Sucurzal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdsucurzal = new SqlParameter();
                ParIdsucurzal.ParameterName = "@Idsucurzal";
                ParIdsucurzal.SqlDbType = SqlDbType.Int;
                ParIdsucurzal.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdsucurzal);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = DatosBasicos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParSucurzal = new SqlParameter();
                ParSucurzal.ParameterName = "@Sucurzal";
                ParSucurzal.SqlDbType = SqlDbType.VarChar;
                ParSucurzal.Size = 50;
                ParSucurzal.Value = DatosBasicos.Sucurzal;
                SqlCmd.Parameters.Add(ParSucurzal);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 20;
                ParCiudad.Value = DatosBasicos.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                ParDescripcion.Value = DatosBasicos.Descripcion;
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

        public DataTable Mostrar_Surcurzal()
        {
            DataTable DtResultado = new DataTable("Produccion.Sucurzal");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.Mostrar_Sucurzal";
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

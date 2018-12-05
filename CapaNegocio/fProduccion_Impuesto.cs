﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class fProduccion_Impuesto
    {
        //Método Insertar que llama al método Insertar de la clase DIngreso
        //de la CapaDatos
        public static string Guardar_DatosBasicos(string auto, string impuesto, string tipo, string valor)
        {
            Conexion_Produccion_Impuesto Obj = new Conexion_Produccion_Impuesto();
            Obj.Auto = auto;
            Obj.Impuesto = impuesto;
            Obj.Tipo = tipo;
            Obj.Valor = valor;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Impuesto(string filtro)
        {
            Conexion_Produccion_Impuesto Obj = new Conexion_Produccion_Impuesto();
            Obj.Filtro = filtro;
            return Obj.Buscar_Impuesto(Obj);
        }

        public static DataTable Mostrar_Impuesto()
        {
            return new Conexion_Produccion_Impuesto().Mostrar_Impuesto();
        }
    }
}
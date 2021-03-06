﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fProduccion_Marcas
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            int auto, int estado, int idproveedor, string marca, string descripcion)
        {
            Conexion_Produccion_Marca Obj = new Conexion_Produccion_Marca();
            //Datos Basicos

            Obj.Estado = estado;
            Obj.Idproveedor = idproveedor;
            Obj.Marca = marca;
            Obj.Descripcion = descripcion;
            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Marca(string filtro)
        {
            Conexion_Produccion_Marca Obj = new Conexion_Produccion_Marca();
            Obj.Filtro = filtro;
            return Obj.Buscar_Marca(Obj);
        }

        public static DataTable Mostrar()
        {
            return new Conexion_Produccion_Marca().Mostrar();
        }
    }
}

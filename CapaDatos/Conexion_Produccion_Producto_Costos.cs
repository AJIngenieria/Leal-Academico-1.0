using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion_Produccion_Producto_Costos
    {
        private int _Idcostos;
        private int _Idproducto;
        private int _Idimpuesto;

        private string _Compra;
        private string _Promedio;
        private string _Va_Maximo;
        private string _Va_Minimo;
        private string _Ca_Maxima;
        private string _Ca_Minima;
        private string _Impuesto;
        private string _Valor;
        private string _Balanza;
        private string _Unidad;
        private string _Medida;

        public int Idcostos { get => _Idcostos; set => _Idcostos = value; }
        public int Idproducto { get => _Idproducto; set => _Idproducto = value; }
        public int Idimpuesto { get => _Idimpuesto; set => _Idimpuesto = value; }
        public string Compra { get => _Compra; set => _Compra = value; }
        public string Promedio { get => _Promedio; set => _Promedio = value; }
        public string Va_Maximo { get => _Va_Maximo; set => _Va_Maximo = value; }
        public string Va_Minimo { get => _Va_Minimo; set => _Va_Minimo = value; }
        public string Ca_Maxima { get => _Ca_Maxima; set => _Ca_Maxima = value; }
        public string Ca_Minima { get => _Ca_Minima; set => _Ca_Minima = value; }
        public string Impuesto { get => _Impuesto; set => _Impuesto = value; }
        public string Valor { get => _Valor; set => _Valor = value; }
        public string Balanza { get => _Balanza; set => _Balanza = value; }
        public string Unidad { get => _Unidad; set => _Unidad = value; }
        public string Medida { get => _Medida; set => _Medida = value; }

        public Conexion_Produccion_Producto_Costos()
        {

        }

        public Conexion_Produccion_Producto_Costos(int idcostos, int idproducto, int idimpuesto, string compra, string promedio,
            string va_maximo, string va_minimo, string ca_maxima, string ca_minimo, string impuesto, string valor,
            string balanza, string unidad, string medida)
        {
            this.Idcostos = idcostos;
            this.Idproducto = idproducto;
            this.Idimpuesto = idimpuesto;
            this.Compra = compra;
            this.Promedio = promedio;
            this.Va_Maximo = va_maximo;
            this.Va_Minimo = va_minimo;
            this.Ca_Maxima = ca_maxima;
            this.Impuesto = impuesto;
            this.Valor = valor;
            this.Balanza = balanza;
            this.Unidad = unidad;
            this.Medida = medida;
        }

    }
}

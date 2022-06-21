using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace artesaniaApi.Models.productos
{
    public class cPdorducto
    {
        private string nombre;
        private string descirpcion;
        private int cantidad;
        private float precio;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descirpcion { get => descirpcion; set => descirpcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}
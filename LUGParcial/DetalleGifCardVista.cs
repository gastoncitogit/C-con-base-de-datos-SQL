using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LUGParcial.Entidades;
namespace LUGParcial
{
    public class DetalleGifCardVista
    {
       
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        public int NumeroGifCard { get; set; }
        public float Saldo { get; set; }
        public GifCard.Estados Estado { get; set; }
        public GifCard.Rubros Rubro { get; set; }

        public string Locacion { get; set; }

        public DetalleGifCardVista(string nombre, string apellido, int dNI, int numeroGifCard, int saldo, GifCard.Estados estado, GifCard.Rubros rubro, string locacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            NumeroGifCard = numeroGifCard;
            Saldo = saldo;
            Estado = estado;
            Rubro = rubro;
            Locacion = locacion;
        }
    }
}

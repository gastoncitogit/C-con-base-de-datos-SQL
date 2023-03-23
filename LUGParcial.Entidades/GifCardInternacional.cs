using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUGParcial.Entidades
{
    public class GifCardInternacional : GifCard
    {

        public string Pais { get; set; }
        public GifCardInternacional(int numero, DateTime fechaVencimiento, int saldo, Estados estado, Rubros rubro,string pais)
            : base(numero,fechaVencimiento,saldo,estado,rubro)
        {
            Pais = pais;
            Descuento = 0.30f;
        }

        public GifCardInternacional()
        {
            Descuento = 0.30f;
        }

        public override string ObtenerRegion()
        {
            return Pais;
        }

        

        public override void AsignarRegion(string region)
        {
            Pais = region;
        }
    }
}

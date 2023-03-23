using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUGParcial.Entidades
{
    public class GifCardNacional : GifCard
    {

        public string Provincia { get; set; }
        public GifCardNacional(int numero, DateTime fechaVencimiento, int saldo, Estados estado, Rubros rubro,string provincia) 
            : base(numero, fechaVencimiento, saldo, estado, rubro)
        {
            Provincia = provincia;
            Descuento = 0.25f;
        }

        public GifCardNacional()
        {
            Descuento = 0.25f;
        }

        public override string ObtenerRegion()
        {
            return Provincia;
        }

        public override void AsignarRegion(string region)
        {
            Provincia = region;
        }
    }
}

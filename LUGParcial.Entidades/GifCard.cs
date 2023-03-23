using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUGParcial.Entidades
{
     public abstract class GifCard : Entidad
    {

        #region "Enum"

        public enum Rubros { Libre = 0, Calzado, Electrodomesticos}
        public enum Estados { Activa = 0, Baja, SinSaldo,Vencida}


        #endregion

        
        public GifCard(int numero, DateTime fechaVencimiento, int saldo, Estados estado, Rubros rubro)
        {
            Numero = numero;
            FechaVencimiento = fechaVencimiento;
            Saldo = saldo;
            Estado = estado;
            Rubro = rubro;
            DescuentoAcumulado = 0;
        }

       public GifCard()
        {

        }

        #region "Propiedades"

        public int Numero { get; set; }

        public  DateTime FechaVencimiento { get; set; }

        public float Saldo { get; set; }

        public Estados Estado { get; set; }
            
        public Rubros Rubro { get; set; }

        public float DescuentoAcumulado { get; set; }

        public float Descuento { get; protected set; }

        #endregion

        #region "Metodos"


        public abstract string ObtenerRegion();
        public abstract void AsignarRegion(string region);

        #endregion

    }
}

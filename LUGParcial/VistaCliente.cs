using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LUGParcial.Entidades;

namespace LUGParcial
{
    public class VistaCliente
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int DNI { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int NumeroTarjetaAsociada { get; set; }

        public VistaCliente(string nombre, string apellido, int dNI, DateTime fechaNacimiento, int tarjetaAsociadaNumero)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            FechaNacimiento = fechaNacimiento;
            NumeroTarjetaAsociada = tarjetaAsociadaNumero;
        }
    }
}

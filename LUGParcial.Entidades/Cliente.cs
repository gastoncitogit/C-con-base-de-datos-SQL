using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUGParcial.Entidades
{
    public class Cliente : Entidad
    {
        public Cliente()
        {
        }

        public Cliente(string nombre, string apellido, int dNI, DateTime fechaNacimiento, GifCard tarjetaAsociada)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            FechaNacimiento = fechaNacimiento;
            TarjetaAsociada = tarjetaAsociada;
        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int DNI { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public GifCard TarjetaAsociada { get; set; }
    }


}

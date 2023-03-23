using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LUGParcial.Abstraccion;
using LUGParcial.Mapper;
using LUGParcial.Entidades;

namespace LUGParcial.LogicaDeNegocio
{
    public class BLLGifCard : IGestor<GifCard>
    {

        public BLLGifCard()
        {
            tarjetaMapper = new MPPGifCard();
        }
        MPPGifCard tarjetaMapper;
        public void Alta(GifCard Objeto)
        {
            tarjetaMapper.Alta(Objeto);
        }

        public void Baja(GifCard Objeto)
        {
            tarjetaMapper.Baja(Objeto);
        }

        public List<GifCard> ListarTodo()
        {
            return tarjetaMapper.ListarTodo();
        }

        public void Modificacion(GifCard Objeto)
        {
            tarjetaMapper.Modificacion(Objeto);
        }
        public bool NumeroDeTarjetaExiste(GifCard ptarjeta)
        {
            List<GifCard> listaTarjetas = tarjetaMapper.ListarTodo();

            if (listaTarjetas.Exists(x => x.Numero == ptarjeta.Numero))
            {
                return true;
            }

            else { return false; }
        }

        public void ActualizarFechaVencimiento()
        {
            List<GifCard> listaTarjetas = tarjetaMapper.ListarTodo();

            List<GifCard> listaFechasVencidas = new List<GifCard>();

            foreach (GifCard auxTarjeta in listaTarjetas)
            {
                if (auxTarjeta.FechaVencimiento < DateTime.Now)
                    listaFechasVencidas.Add(auxTarjeta);
            }

            foreach (GifCard auxTarjeta in listaFechasVencidas)
            {
                auxTarjeta.Estado = GifCard.Estados.Vencida;
                tarjetaMapper.Modificacion(auxTarjeta);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LUGParcial.Abstraccion;
using LUGParcial.Entidades;
using LUGParcial.Mapper;

namespace LUGParcial.LogicaDeNegocio
{
    public class BLLCliente : IGestor<Cliente>
    {

        public BLLCliente()
        {
            clienteMapper = new MPPCliente();
        }

        MPPCliente clienteMapper;

        public void Alta(Cliente Objeto)
        {
            clienteMapper.Alta(Objeto);
        }

        public void Baja(Cliente Objeto)
        {
            clienteMapper.Baja(Objeto);
        }

        public void Modificacion(Cliente Objeto)
        {
            clienteMapper.Modificacion(Objeto);
        }

        public List<Cliente> ListarTodo()
        {
            return clienteMapper.ListarTodo();
            

        }

        public List<Cliente> TraerClientesSinTarjeta()
        {
            return clienteMapper.TraerClientesSinTarjeta();
        }
        public bool DocumentoExiste(Cliente pCliente)
        {
            List<Cliente> listaClientes = clienteMapper.ListarTodo();

            if (listaClientes.Exists(x => x.DNI == pCliente.DNI))
            {
                return true;
            }

            else { return false; }
        }
    }
}
        


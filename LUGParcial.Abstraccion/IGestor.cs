using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUGParcial.Abstraccion
{
    public interface IGestor<T> where T: IEntidad
    {
        void Alta(T Objeto);

        void Baja(T Objeto);

        void Modificacion(T Objeto);

        List<T> ListarTodo();

    }
}

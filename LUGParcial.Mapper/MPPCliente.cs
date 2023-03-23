using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LUGParcial.Abstraccion;
using LUGParcial.Entidades;
using LUGParcial.Datos;
using System.Data;

namespace LUGParcial.Mapper
{
    public class MPPCliente : IGestor<Cliente>
    {
        string consulta = string.Empty;
        DAL conexion;
        public void Alta(Cliente Objeto)
        {
            try
            {
                consulta = "INSERT INTO Cliente(Nombre,Apellido,DNI,FechaNacimiento) VALUES (@Nombre, @Apellido, @DNI, @FechaNacimiento)";
                conexion = new DAL();
                conexion.TransacAdd(consulta, Objeto.Nombre, Objeto.Apellido, Objeto.DNI, Objeto.FechaNacimiento);
                conexion.TransacExec();
            } catch(Exception ex)
            {
                throw new Exception("No se pudo generar el alta del cliente");
            }
            
            
        }

        public void Baja(Cliente Objeto)
        {
            try
            {
                consulta = "DELETE FROM Cliente WHERE DNI = @DNI";
                conexion = new DAL();
                conexion.TransacAdd(consulta, Objeto.DNI);
                conexion.TransacExec();
            }catch ( Exception ex)
            {
                throw new Exception("No se pudo generar la baja del cliente");
            }
            
            
        }

        public List<Cliente> ListarTodo()
        {
            DataTable tabla;
            conexion = new DAL();

            string Consulta = "SELECT ID,Nombre,Apellido,DNI,FechaNacimiento, NroTarjetaAsociada AS 'NumeroTarjeta' FROM Cliente";
            tabla = conexion.ObtenerTabla(Consulta);
            List<Cliente> ListaClientes = new List<Cliente>();
            List<GifCard> ListaGifCard = new MPPGifCard().ListarTodo();

            if(tabla.Rows.Count > 0)
            {
                foreach(DataRow fila in tabla.Rows)
                {
                    Cliente objCliente = new Cliente();
                    objCliente.ID = Convert.ToInt32(fila["ID"]);
                    objCliente.Nombre = fila["Nombre"].ToString();
                    objCliente.Apellido = fila["Apellido"].ToString();
                    objCliente.DNI = Convert.ToInt32(fila["DNI"]);
                    objCliente.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"]);
                    int numeroTarjeta = fila["NumeroTarjeta"] != DBNull.Value ? Convert.ToInt32(fila["NumeroTarjeta"]) : -1; //Se verifica que el número de tarjeta no sea null.
                    objCliente.TarjetaAsociada = ListaGifCard.Find(aux => (aux.Numero == numeroTarjeta)); 
                    ListaClientes.Add(objCliente);
                }
            }

            return ListaClientes;
        }
        public List<Cliente> TraerClientesSinTarjeta()
        {
            DataTable tabla;
            conexion = new DAL();

            string Consulta = "SELECT Nombre + ' ' + Apellido AS NombreCompleto, Cliente.ID FROM Cliente left join GifCard ON Cliente.NroTarjetaAsociada = GifCard.ID WHERE Cliente.NroTarjetaAsociada IS NULL";
            tabla = conexion.ObtenerTabla(Consulta);
            List<Cliente> ListaClientes = new List<Cliente>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Cliente objCliente = new Cliente();
                    objCliente.ID = Convert.ToInt32(fila["ID"]);
                    objCliente.Nombre = fila["NombreCompleto"].ToString();
                    
                    ListaClientes.Add(objCliente);
                }
            }

            else { ListaClientes = null; }

            return ListaClientes;
        }
        public void Modificacion(Cliente Objeto)
        {
            try
            {
                int numeroTarjeta = Objeto.TarjetaAsociada == null ? 0 : Objeto.TarjetaAsociada.Numero;
                string consulta = $"UPDATE Cliente SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento =  @FechaNacimiento, NroTarjetaAsociada = @NroTarjeta WHERE ID = @ID";

                DAL conexion = new DAL();

                conexion.TransacAdd(consulta, Objeto.Nombre, Objeto.Apellido, Objeto.FechaNacimiento, numeroTarjeta, Objeto.ID);
                conexion.TransacExec();
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo modificar el cliente");
            }
            

            
        }
        public bool ExisteDNICliente(Cliente Objeto)
        {  
            DAL conexion = new DAL();
            return (bool)conexion.EjecutarScalar("SELECT COUNT(DNI) from Cliente where DNI =" + Objeto.DNI + "");

        }
    }

}

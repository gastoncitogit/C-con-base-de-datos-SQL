using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LUGParcial.Abstraccion;
using LUGParcial.Datos;
using LUGParcial.Entidades;
using System.Data;


namespace LUGParcial.Mapper
{
    public class MPPGifCard : IGestor<GifCard>
    {
        
        DAL conexion;
        private string consulta;
        public void Alta(GifCard Objeto)
        {
            try
            {
                conexion = new DAL();
                if (Objeto is GifCardInternacional)
                {
                    consulta = "INSERT INTO GifCard(Numero,FechaVencimiento,Saldo,DescuentoAcumulado,Estado,Rubro,Pais) VALUES (@Numero, @FechaVencimiento, @Saldo, @DescuentoAcumulado, @Estado, @Rubro, @Pais)";
                    conexion.TransacAdd(consulta, Objeto.Numero, Objeto.FechaVencimiento, Objeto.Saldo, Objeto.DescuentoAcumulado, Objeto.Estado, Objeto.Rubro, Objeto.ObtenerRegion());
                    conexion.TransacExec();

                }
                else
                {
                    consulta = "INSERT INTO GifCard(Numero,FechaVencimiento,Saldo,DescuentoAcumulado,Estado,Rubro,Provincia) VALUES (@Numero, @FechaVencimiento, @Saldo, @DescuentoAcumulado, @Estado, @Rubro, @Provincia)";
                    conexion.EjecutarNonQuery(consulta, Objeto.Numero, Objeto.FechaVencimiento, Objeto.Saldo, Objeto.DescuentoAcumulado, Objeto.Estado, Objeto.Rubro, Objeto.ObtenerRegion());
                }

            } catch( Exception ex)
            {
                throw new Exception("No se pudo generar el alta de la tarjeta");
            }
        }

        public void Baja(GifCard Objeto)
        {
            try
            {
                consulta = "UPDATE GifCard SET Estado = @Estado WHERE ID = @ID";
                conexion = new DAL();
                conexion.TransacAdd(consulta, Objeto.Estado, Objeto.ID);
                conexion.TransacExec();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo generar la baja de la tarjeta");
            }
            
        }

        public List<GifCard> ListarTodo()
        {

            DataTable tabla;
            conexion = new DAL();

            string Consulta = "SELECT ID, Numero, FechaVencimiento, Saldo,DescuentoAcumulado, Estado, Rubro, Pais, Provincia FROM LUGParcial.dbo.GifCard";
            tabla = conexion.ObtenerTabla(Consulta);
            List<GifCard> ListaTarjetas = new List<GifCard>();


            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    if (fila["Pais"] != DBNull.Value)
                    {
                        GifCardInternacional tarjetaInternacionalAux = new GifCardInternacional();
                        tarjetaInternacionalAux.ID = Convert.ToInt32(fila["ID"]);
                        tarjetaInternacionalAux.Numero = Convert.ToInt32(fila["Numero"]);
                        tarjetaInternacionalAux.FechaVencimiento = Convert.ToDateTime(fila["FechaVencimiento"]);
                        tarjetaInternacionalAux.Saldo = Convert.ToInt32(fila["Saldo"]);
                        tarjetaInternacionalAux.DescuentoAcumulado = Convert.ToInt32(fila["DescuentoAcumulado"]);
                        tarjetaInternacionalAux.Estado = (GifCard.Estados)fila["Estado"];
                        tarjetaInternacionalAux.Rubro = (GifCard.Rubros)fila["Rubro"];
                        tarjetaInternacionalAux.Pais = fila["Pais"].ToString();
                        ListaTarjetas.Add(tarjetaInternacionalAux);
                    }

                    else
                    {
                        GifCardNacional tarjetaNacionalAux = new GifCardNacional();
                        tarjetaNacionalAux.ID = Convert.ToInt32(fila["ID"]);
                        tarjetaNacionalAux.Numero = Convert.ToInt32(fila["Numero"]);
                        tarjetaNacionalAux.FechaVencimiento = Convert.ToDateTime(fila["FechaVencimiento"]);
                        tarjetaNacionalAux.Saldo = Convert.ToInt32(fila["Saldo"]);
                        tarjetaNacionalAux.DescuentoAcumulado = Convert.ToInt32(fila["DescuentoAcumulado"]);
                        tarjetaNacionalAux.Estado = (GifCard.Estados)fila["Estado"];
                        tarjetaNacionalAux.Rubro = (GifCard.Rubros)fila["Rubro"];
                        tarjetaNacionalAux.Provincia = fila["Provincia"].ToString();
                        ListaTarjetas.Add(tarjetaNacionalAux);
                    }
                }
            }
            return ListaTarjetas;
        }

        public void Modificacion(GifCard Objeto)
        {
            try
            {
                string consulta = $"UPDATE GifCard SET Saldo = @Saldo, Estado = @Estado, DescuentoAcumulado = @DescuentoAcumulado WHERE ID = @ID";

                DAL conexion = new DAL();
                conexion.TransacAdd(consulta, Objeto.Saldo, Objeto.Estado, Objeto.DescuentoAcumulado, Objeto.ID);
                conexion.TransacExec();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar la tarjeta");
            }


            
            
        }
    }
}

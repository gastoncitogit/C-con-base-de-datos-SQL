using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LUGParcial.Entidades;
using LUGParcial.LogicaDeNegocio;

namespace LUGParcial
{
    public partial class frmCompras : Form
    {

        BLLCliente bllCliente;
        BLLGifCard bllTarjeta;
        public frmCompras()
        {
            InitializeComponent();
            bllCliente = new BLLCliente();
            bllTarjeta = new BLLGifCard();

        }

        public void ActualizarGrilla()
        {

            GrillaDetalleGifCards.DataSource = null;

            List<Cliente> listaClientes = bllCliente.ListarTodo();

            List<DetalleGifCardVista> listaVista = new List<DetalleGifCardVista>();

            
            foreach(Cliente aux in listaClientes)
            {
                if(aux.TarjetaAsociada != null)
                {
                    listaVista.Add(new DetalleGifCardVista(aux.Nombre, aux.Apellido, aux.DNI, aux.TarjetaAsociada.Numero, Convert.ToInt32(aux.TarjetaAsociada.Saldo), aux.TarjetaAsociada.Estado, aux.TarjetaAsociada.Rubro, aux.TarjetaAsociada.ObtenerRegion()));
                }

                
            }

            GrillaDetalleGifCards.DataSource = listaVista;
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            bllTarjeta.ActualizarFechaVencimiento();
            ActualizarGrilla();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                int montoIngresado = Convert.ToInt32(txtMonto.Text);
                DetalleGifCardVista auxTarjeta = (DetalleGifCardVista)GrillaDetalleGifCards.CurrentRow.DataBoundItem;
                GifCard tarjetaSeleccionada = bllTarjeta.ListarTodo().Find(aux => aux.Numero == auxTarjeta.NumeroGifCard);


                if (tarjetaSeleccionada.Estado == GifCard.Estados.Activa)
                {
                    
                    float descuento = montoIngresado * tarjetaSeleccionada.Descuento;
                    if (tarjetaSeleccionada.Saldo >= descuento) tarjetaSeleccionada.Saldo -= (montoIngresado - descuento);
                    else throw new Exception("El valor de compra supera al monto disponible");

                    if (tarjetaSeleccionada.Saldo <= 0) tarjetaSeleccionada.Estado = GifCard.Estados.SinSaldo;
                    MessageBox.Show($"Compra realizada con éxito. El precio inicial es de {montoIngresado} y con el descuento es de {montoIngresado - descuento}");
                    tarjetaSeleccionada.DescuentoAcumulado += descuento;

                    bllTarjeta.Modificacion(tarjetaSeleccionada);

                    
                } else
                {
                    throw new Exception("La tarjeta desde la cual se quiere efectuar la compra requiere estar activa");
                }

            } catch(Exception ex) { MessageBox.Show("Se ha producido un error, detalle:\n" + ex.Message); }

            ActualizarGrilla();
        }

        private void GrillaDetalleGifCards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class FrmMain : Form
    {
        BLLGifCard tarjetaNegocio;
        public FrmMain()
        {
            InitializeComponent();
            tarjetaNegocio = new BLLGifCard();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmUsuariosAux = new frmClientes();
            frmUsuariosAux.ShowDialog();
        }

        private void gestionTarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGifCards frmTarjetasAux = new frmGifCards();
            frmTarjetasAux.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmCompras frmComprasAux = new frmCompras();
            frmComprasAux.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tarjetaConMenorImporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<GifCard> listaTarjetas = tarjetaNegocio.ListarTodo();
            float saldoMinimo = 4000000000000000;
            foreach (GifCard aux in listaTarjetas)
            {
                if(saldoMinimo > aux.Saldo)
                {
                    saldoMinimo = aux.Saldo;
                }
            }
            MessageBox.Show($"La tarjeta con menor saldo tiene: {saldoMinimo} pesos");
        }

        private void tarjetaCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<GifCard> listaTarjetas = tarjetaNegocio.ListarTodo();
            float mayorDescuento = 0;

            foreach(GifCard aux in listaTarjetas)
            {
                if(mayorDescuento < aux.DescuentoAcumulado)
                {
                    mayorDescuento = aux.DescuentoAcumulado;
                }
            }
            MessageBox.Show($"La tarjeta con mayor descuento tiene {mayorDescuento} pesos");
        }

        private void informesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}

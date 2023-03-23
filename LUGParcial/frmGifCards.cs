using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LUGParcial.LogicaDeNegocio;
using LUGParcial.Entidades;
using System.Text.RegularExpressions;

namespace LUGParcial
{
    public partial class frmGifCards : Form
    {
        BLLGifCard bllTarjeta;
        BLLCliente bllCliente;
        
        public frmGifCards()
        {
            InitializeComponent();
            bllTarjeta = new BLLGifCard();
            bllCliente = new BLLCliente();
        }
        private void ActualizarGrilla()
        {
            this.GrillaTarjetas.DataSource = null;
            this.GrillaTarjetas.DataSource = bllTarjeta.ListarTodo();
            this.GrillaTarjetas.Columns["ID"].Visible = false;
        }

        void Limpiar()
        {
            txtNumero.Text = null;
            txtSaldo.Text = null;
        }



        private void btnAltaTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbInternacional.Checked)
                {
                    cbProvincias.Enabled = false;
                    GifCardInternacional objTarjetaInternacional = new GifCardInternacional();
                    objTarjetaInternacional.Numero = Convert.ToInt32(txtNumero.Text);
                    objTarjetaInternacional.FechaVencimiento = this.dateTimePicker1.Value;
                    int saldoAux = Convert.ToInt32(txtSaldo.Text);
                    if (saldoAux == 0)
                    {
                        MessageBox.Show("No se puede dar de alta una tarjeta con 0 de saldo.");
                    }
                    else
                    {
                        objTarjetaInternacional.Saldo = Convert.ToInt32(txtSaldo.Text);
                        if (rdbComestibles.Checked)
                        {
                            objTarjetaInternacional.Rubro = GifCard.Rubros.Calzado;
                        }
                        else if (rdbIndumentaria.Checked)
                        {
                            objTarjetaInternacional.Rubro = GifCard.Rubros.Electrodomesticos;
                        }
                        else
                        {
                            objTarjetaInternacional.Rubro = GifCard.Rubros.Libre;
                        }
                        objTarjetaInternacional.Pais = cbPaises.Text;
                        if (!bllTarjeta.NumeroDeTarjetaExiste(objTarjetaInternacional))
                        {
                            Cliente clienteSeleccionado = bllCliente.ListarTodo().Find(cliente => cliente.ID == (int)cbClientes.SelectedValue);
                            clienteSeleccionado.TarjetaAsociada = objTarjetaInternacional;
                            bllCliente.Modificacion(clienteSeleccionado);
                            bllTarjeta.Alta(objTarjetaInternacional);
                            bllTarjeta.ActualizarFechaVencimiento();
                            ActualizarGrilla();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("El numero de tarjeta que esta intentando ingresar ya ha sido dado de alta con anterioridad.");

                        }
                    }  
                }

                else
                {
                    cbPaises.Enabled = false;
                    GifCardNacional objTarjetaNacional = new GifCardNacional();
                    objTarjetaNacional.Numero = Convert.ToInt32(txtNumero.Text);
                    objTarjetaNacional.FechaVencimiento = this.dateTimePicker1.Value;
                    objTarjetaNacional.Saldo = Convert.ToInt32(txtSaldo.Text);
                    if (rdbComestibles.Checked == true)
                    {
                        objTarjetaNacional.Rubro = GifCard.Rubros.Calzado;
                    }
                    else if (rdbIndumentaria.Checked == true)
                    {
                        objTarjetaNacional.Rubro = GifCard.Rubros.Electrodomesticos;
                    }
                    else
                    {
                        objTarjetaNacional.Rubro = GifCard.Rubros.Libre;
                    }
                    objTarjetaNacional.Provincia = cbProvincias.Text;
                    if (!bllTarjeta.NumeroDeTarjetaExiste(objTarjetaNacional))
                    {
                        Cliente clienteSeleccionado = bllCliente.ListarTodo().Find(cliente => cliente.ID == (int)cbClientes.SelectedValue);
                        clienteSeleccionado.TarjetaAsociada = objTarjetaNacional;
                        bllCliente.Modificacion(clienteSeleccionado);
                        bllTarjeta.Alta(objTarjetaNacional);
                        bllTarjeta.ActualizarFechaVencimiento();
                        ActualizarGrilla();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El numero de tarjeta que esta intentando ingresar ya ha sido dado de alta con anterioridad.");
                    }    
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void CargarComboCliente()
        {
            cbClientes.DataSource = bllCliente.TraerClientesSinTarjeta();
            cbClientes.DisplayMember = "Nombre";
            cbClientes.ValueMember = "ID";
            
        }

        private void frmTarjetas_Load(object sender, EventArgs e)
        {
            bllTarjeta.ActualizarFechaVencimiento();
            ActualizarGrilla();
            CargarComboCliente();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnBajaTarjeta_Click(object sender, EventArgs e)
        {
            GifCard tarjetaAux;
            tarjetaAux  = (GifCard)GrillaTarjetas.CurrentRow.DataBoundItem;
            tarjetaAux.Estado = GifCard.Estados.Baja;
            bllTarjeta.Baja(tarjetaAux);
            ActualizarGrilla();
            
        }

        private void rdbNacional_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNacional.Checked)
            {
                cbPaises.Enabled = false;
                cbProvincias.Enabled = true;
            }

        }

        private void rdbInternacional_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInternacional.Checked)
            {
                cbPaises.Enabled = true;
                cbProvincias.Enabled = false;
            }
        }

        private void btnModificarTarjeta_Click(object sender, EventArgs e)
        {
            GifCard tarjetaAux;
            tarjetaAux = (GifCard)GrillaTarjetas.CurrentRow.DataBoundItem;
            tarjetaAux.Saldo = Convert.ToInt32(txtSaldo.Text);
            bllTarjeta.Modificacion(tarjetaAux);
            ActualizarGrilla();
            Limpiar();
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

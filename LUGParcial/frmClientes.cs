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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            objCliente = new Cliente();
            bllCliente = new BLLCliente();
        }

        Cliente objCliente;
        BLLCliente bllCliente;
        void Limpiar()
        {
            txtNombreCliente.Text = null;
            txtApellidoCliente.Text = null;
            txtDNICliente.Text = null;
            
        }

        private void ActualizarGrilla()
        {
            List<Cliente> listaClientes = bllCliente.ListarTodo();
            List<VistaCliente> listaVista = new List<VistaCliente>();
            foreach (Cliente aux in listaClientes)
            {
               if(aux.TarjetaAsociada != null)
                {
                    listaVista.Add(new VistaCliente(aux.Nombre, aux.Apellido, aux.DNI, aux.FechaNacimiento, aux.TarjetaAsociada.Numero));
                }
                else
                {
                    listaVista.Add(new VistaCliente(aux.Nombre, aux.Apellido, aux.DNI, aux.FechaNacimiento, 0));
                }
                

            }
            this.GrillaClientes.DataSource = null;
            this.GrillaClientes.DataSource = listaVista;        
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            
            try
            {
                objCliente.Nombre = txtNombreCliente.Text;
                objCliente.Apellido = txtApellidoCliente.Text;
                objCliente.DNI = Convert.ToInt32(txtDNICliente.Text);
                objCliente.FechaNacimiento = this.dateTimePicker1.Value;
                if (!bllCliente.DocumentoExiste(objCliente))
                {
                    bllCliente.Alta(objCliente);
                    ActualizarGrilla();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El documento que esta intentando ingresar ya ha sido dado de alta con anterioridad.");

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
        void Asignar()
        {
            try
            {
                objCliente.Nombre = txtNombreCliente.Text;
                objCliente.Apellido = txtApellidoCliente.Text;
                objCliente.FechaNacimiento = this.dateTimePicker1.Value;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

            VistaCliente auxCliente = (VistaCliente)GrillaClientes.CurrentRow.DataBoundItem;
            objCliente = bllCliente.ListarTodo().Find(aux => aux.DNI == auxCliente.DNI);
            Asignar();
            bllCliente.Modificacion(objCliente);
            ActualizarGrilla();
            Limpiar();
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {  
            try
            {
                VistaCliente auxCliente = (VistaCliente)GrillaClientes.CurrentRow.DataBoundItem;
                objCliente = bllCliente.ListarTodo().Find(aux => aux.DNI == auxCliente.DNI);
                Asignar();
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Confirma la eleminación del Cliente?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    
                    bllCliente.Baja(objCliente);
                    ActualizarGrilla();
                    Limpiar();
                    
                }
                else { this.Close(); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GrillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}

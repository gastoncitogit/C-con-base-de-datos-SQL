
namespace LUGParcial
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionTarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetaConMenorImporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetaCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // gestionClientesToolStripMenuItem
            // 
            this.gestionClientesToolStripMenuItem.Name = "gestionClientesToolStripMenuItem";
            this.gestionClientesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.gestionClientesToolStripMenuItem.Text = "Gestion clientes";
            this.gestionClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionClientesToolStripMenuItem_Click);
            // 
            // tarjetasToolStripMenuItem
            // 
            this.tarjetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionTarjetasToolStripMenuItem});
            this.tarjetasToolStripMenuItem.Name = "tarjetasToolStripMenuItem";
            this.tarjetasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tarjetasToolStripMenuItem.Text = "Tarjetas";
            // 
            // gestionTarjetasToolStripMenuItem
            // 
            this.gestionTarjetasToolStripMenuItem.Name = "gestionTarjetasToolStripMenuItem";
            this.gestionTarjetasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.gestionTarjetasToolStripMenuItem.Text = "Gestion tarjetas";
            this.gestionTarjetasToolStripMenuItem.Click += new System.EventHandler(this.gestionTarjetasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.tarjetasToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInformes,
            this.tarjetaConMenorImporteToolStripMenuItem,
            this.tarjetaCToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click_1);
            // 
            // btnInformes
            // 
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(231, 22);
            this.btnInformes.Text = "Tarjetas activas";
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // tarjetaConMenorImporteToolStripMenuItem
            // 
            this.tarjetaConMenorImporteToolStripMenuItem.Name = "tarjetaConMenorImporteToolStripMenuItem";
            this.tarjetaConMenorImporteToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.tarjetaConMenorImporteToolStripMenuItem.Text = "Tarjeta con menor importe";
            this.tarjetaConMenorImporteToolStripMenuItem.Click += new System.EventHandler(this.tarjetaConMenorImporteToolStripMenuItem_Click);
            // 
            // tarjetaCToolStripMenuItem
            // 
            this.tarjetaCToolStripMenuItem.Name = "tarjetaCToolStripMenuItem";
            this.tarjetaCToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.tarjetaCToolStripMenuItem.Text = "Tarjeta con mayor descuentos";
            this.tarjetaCToolStripMenuItem.Click += new System.EventHandler(this.tarjetaCToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 591);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionTarjetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnInformes;
        private System.Windows.Forms.ToolStripMenuItem tarjetaConMenorImporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetaCToolStripMenuItem;
    }
}


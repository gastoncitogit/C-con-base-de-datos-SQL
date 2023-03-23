namespace LUGParcial
{
    partial class frmCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrillaDetalleGifCards = new System.Windows.Forms.DataGridView();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDetalleGifCards)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaDetalleGifCards
            // 
            this.GrillaDetalleGifCards.AllowUserToAddRows = false;
            this.GrillaDetalleGifCards.AllowUserToDeleteRows = false;
            this.GrillaDetalleGifCards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaDetalleGifCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDetalleGifCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrillaDetalleGifCards.Location = new System.Drawing.Point(0, 0);
            this.GrillaDetalleGifCards.Name = "GrillaDetalleGifCards";
            this.GrillaDetalleGifCards.ReadOnly = true;
            this.GrillaDetalleGifCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaDetalleGifCards.Size = new System.Drawing.Size(800, 253);
            this.GrillaDetalleGifCards.TabIndex = 0;
            this.GrillaDetalleGifCards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaDetalleGifCards_CellContentClick);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(308, 332);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(155, 34);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = " Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(308, 306);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(155, 20);
            this.txtMonto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el monto de la compra";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.GrillaDetalleGifCards);
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDetalleGifCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaDetalleGifCards;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
    }
}
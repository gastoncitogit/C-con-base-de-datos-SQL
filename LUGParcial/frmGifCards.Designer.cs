
namespace LUGParcial
{
    partial class frmGifCards
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
            this.btnAltaTarjeta = new System.Windows.Forms.Button();
            this.btnModificarTarjeta = new System.Windows.Forms.Button();
            this.btnBajaTarjeta = new System.Windows.Forms.Button();
            this.GrillaTarjetas = new System.Windows.Forms.DataGridView();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.rdbLibre = new System.Windows.Forms.RadioButton();
            this.rdbIndumentaria = new System.Windows.Forms.RadioButton();
            this.rdbComestibles = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.rdbInternacional = new System.Windows.Forms.RadioButton();
            this.cbPaises = new System.Windows.Forms.ComboBox();
            this.cbProvincias = new System.Windows.Forms.ComboBox();
            this.lblAsignarCliente = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTarjetas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltaTarjeta
            // 
            this.btnAltaTarjeta.Location = new System.Drawing.Point(15, 357);
            this.btnAltaTarjeta.Name = "btnAltaTarjeta";
            this.btnAltaTarjeta.Size = new System.Drawing.Size(75, 23);
            this.btnAltaTarjeta.TabIndex = 11;
            this.btnAltaTarjeta.Text = "Alta";
            this.btnAltaTarjeta.UseVisualStyleBackColor = true;
            this.btnAltaTarjeta.Click += new System.EventHandler(this.btnAltaTarjeta_Click);
            // 
            // btnModificarTarjeta
            // 
            this.btnModificarTarjeta.Location = new System.Drawing.Point(117, 357);
            this.btnModificarTarjeta.Name = "btnModificarTarjeta";
            this.btnModificarTarjeta.Size = new System.Drawing.Size(75, 23);
            this.btnModificarTarjeta.TabIndex = 12;
            this.btnModificarTarjeta.Text = "Modificar";
            this.btnModificarTarjeta.UseVisualStyleBackColor = true;
            this.btnModificarTarjeta.Click += new System.EventHandler(this.btnModificarTarjeta_Click);
            // 
            // btnBajaTarjeta
            // 
            this.btnBajaTarjeta.Location = new System.Drawing.Point(213, 357);
            this.btnBajaTarjeta.Name = "btnBajaTarjeta";
            this.btnBajaTarjeta.Size = new System.Drawing.Size(75, 23);
            this.btnBajaTarjeta.TabIndex = 13;
            this.btnBajaTarjeta.Text = "Baja";
            this.btnBajaTarjeta.UseVisualStyleBackColor = true;
            this.btnBajaTarjeta.Click += new System.EventHandler(this.btnBajaTarjeta_Click);
            // 
            // GrillaTarjetas
            // 
            this.GrillaTarjetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaTarjetas.Location = new System.Drawing.Point(341, 47);
            this.GrillaTarjetas.Name = "GrillaTarjetas";
            this.GrillaTarjetas.ReadOnly = true;
            this.GrillaTarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaTarjetas.Size = new System.Drawing.Size(464, 333);
            this.GrillaTarjetas.TabIndex = 14;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 35);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Numero:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(12, 66);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(115, 13);
            this.lblFechaVencimiento.TabIndex = 17;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 122);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 19;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(65, 119);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 20;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // rdbLibre
            // 
            this.rdbLibre.AutoSize = true;
            this.rdbLibre.Location = new System.Drawing.Point(5, 42);
            this.rdbLibre.Name = "rdbLibre";
            this.rdbLibre.Size = new System.Drawing.Size(48, 17);
            this.rdbLibre.TabIndex = 21;
            this.rdbLibre.TabStop = true;
            this.rdbLibre.Text = "Libre";
            this.rdbLibre.UseVisualStyleBackColor = true;
            // 
            // rdbIndumentaria
            // 
            this.rdbIndumentaria.AutoSize = true;
            this.rdbIndumentaria.Location = new System.Drawing.Point(66, 42);
            this.rdbIndumentaria.Name = "rdbIndumentaria";
            this.rdbIndumentaria.Size = new System.Drawing.Size(63, 17);
            this.rdbIndumentaria.TabIndex = 22;
            this.rdbIndumentaria.TabStop = true;
            this.rdbIndumentaria.Text = "Calzado";
            this.rdbIndumentaria.UseVisualStyleBackColor = true;
            // 
            // rdbComestibles
            // 
            this.rdbComestibles.AutoSize = true;
            this.rdbComestibles.Location = new System.Drawing.Point(139, 43);
            this.rdbComestibles.Name = "rdbComestibles";
            this.rdbComestibles.Size = new System.Drawing.Size(111, 17);
            this.rdbComestibles.TabIndex = 23;
            this.rdbComestibles.TabStop = true;
            this.rdbComestibles.Text = "Electrodomesticos";
            this.rdbComestibles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "RUBRO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "COBERTURA:";
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Location = new System.Drawing.Point(74, 251);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(67, 17);
            this.rdbNacional.TabIndex = 26;
            this.rdbNacional.TabStop = true;
            this.rdbNacional.Text = "Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
            this.rdbNacional.CheckedChanged += new System.EventHandler(this.rdbNacional_CheckedChanged);
            // 
            // rdbInternacional
            // 
            this.rdbInternacional.AutoSize = true;
            this.rdbInternacional.Location = new System.Drawing.Point(179, 251);
            this.rdbInternacional.Name = "rdbInternacional";
            this.rdbInternacional.Size = new System.Drawing.Size(86, 17);
            this.rdbInternacional.TabIndex = 27;
            this.rdbInternacional.TabStop = true;
            this.rdbInternacional.Text = "Internacional";
            this.rdbInternacional.UseVisualStyleBackColor = true;
            this.rdbInternacional.CheckedChanged += new System.EventHandler(this.rdbInternacional_CheckedChanged);
            // 
            // cbPaises
            // 
            this.cbPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaises.FormattingEnabled = true;
            this.cbPaises.Items.AddRange(new object[] {
            "Brasil",
            "Uruguay",
            "Paraguay",
            "Chile"});
            this.cbPaises.Location = new System.Drawing.Point(167, 274);
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Size = new System.Drawing.Size(121, 21);
            this.cbPaises.TabIndex = 28;
            // 
            // cbProvincias
            // 
            this.cbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincias.FormattingEnabled = true;
            this.cbProvincias.Items.AddRange(new object[] {
            "Buenos Aires",
            "La pampa",
            "Chubut",
            "Formosa",
            "La Rioja"});
            this.cbProvincias.Location = new System.Drawing.Point(40, 274);
            this.cbProvincias.Name = "cbProvincias";
            this.cbProvincias.Size = new System.Drawing.Size(121, 21);
            this.cbProvincias.TabIndex = 29;
            // 
            // lblAsignarCliente
            // 
            this.lblAsignarCliente.AutoSize = true;
            this.lblAsignarCliente.Location = new System.Drawing.Point(37, 316);
            this.lblAsignarCliente.Name = "lblAsignarCliente";
            this.lblAsignarCliente.Size = new System.Drawing.Size(88, 13);
            this.lblAsignarCliente.TabIndex = 31;
            this.lblAsignarCliente.Text = "Asignar a cliente:";
            // 
            // cbClientes
            // 
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(131, 316);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(121, 21);
            this.cbClientes.TabIndex = 32;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(65, 32);
            this.txtNumero.MaxLength = 4;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 33;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbLibre);
            this.groupBox1.Controls.Add(this.rdbIndumentaria);
            this.groupBox1.Controls.Add(this.rdbComestibles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 66);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Solo se puede modificar el saldo.";
            // 
            // frmGifCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbNacional);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.lblAsignarCliente);
            this.Controls.Add(this.cbProvincias);
            this.Controls.Add(this.cbPaises);
            this.Controls.Add(this.rdbInternacional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.GrillaTarjetas);
            this.Controls.Add(this.btnBajaTarjeta);
            this.Controls.Add(this.btnModificarTarjeta);
            this.Controls.Add(this.btnAltaTarjeta);
            this.Name = "frmGifCards";
            this.Text = "frmTarjetas";
            this.Load += new System.EventHandler(this.frmTarjetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTarjetas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaTarjeta;
        private System.Windows.Forms.Button btnModificarTarjeta;
        private System.Windows.Forms.Button btnBajaTarjeta;
        private System.Windows.Forms.DataGridView GrillaTarjetas;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.RadioButton rdbLibre;
        private System.Windows.Forms.RadioButton rdbIndumentaria;
        private System.Windows.Forms.RadioButton rdbComestibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.RadioButton rdbInternacional;
        private System.Windows.Forms.ComboBox cbPaises;
        private System.Windows.Forms.ComboBox cbProvincias;
        private System.Windows.Forms.Label lblAsignarCliente;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
    }
}
namespace PantallasDesarrollo
{
    partial class NuevoDispositivo
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoDispositivo = new System.Windows.Forms.ComboBox();
            this.dgvMostrarItem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtIdDispositivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.modeloTest = new System.Windows.Forms.TextBox();
            this.TipoTest = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.OrangeRed;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.Location = new System.Drawing.Point(556, 368);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 42);
            this.btnVolver.TabIndex = 43;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "TIPO DISPOSITIVO";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(461, 368);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 42);
            this.btnAceptar.TabIndex = 37;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(200, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "DIAGNOSTICO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(200, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "DESCRIPCION";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "ID CLIENTE";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.ForeColor = System.Drawing.SystemColors.Info;
            this.txtIdCliente.Location = new System.Drawing.Point(12, 105);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(79, 20);
            this.txtIdCliente.TabIndex = 55;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDescripcion.Location = new System.Drawing.Point(203, 168);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.Size = new System.Drawing.Size(183, 70);
            this.txtDescripcion.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(355, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "ID DISPOSITIVO";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDiagnostico.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDiagnostico.Location = new System.Drawing.Point(203, 274);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDiagnostico.Size = new System.Drawing.Size(183, 74);
            this.txtDiagnostico.TabIndex = 64;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtFecha.Enabled = false;
            this.txtFecha.ForeColor = System.Drawing.SystemColors.Info;
            this.txtFecha.Location = new System.Drawing.Point(508, 105);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(123, 20);
            this.txtFecha.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(9, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "MARCA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(12, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "N° REGISTRO";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCliente.Enabled = false;
            this.txtCliente.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCliente.Location = new System.Drawing.Point(116, 105);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(212, 20);
            this.txtCliente.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(113, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "CLIENTE";
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMarca.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(12, 168);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(140, 21);
            this.cmbMarca.TabIndex = 79;
            this.cmbMarca.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // cmbModelo
            // 
            this.cmbModelo.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbModelo.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(12, 217);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(140, 21);
            this.cmbModelo.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "MODELO";
            // 
            // cmbTipoDispositivo
            // 
            this.cmbTipoDispositivo.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmbTipoDispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDispositivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoDispositivo.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbTipoDispositivo.FormattingEnabled = true;
            this.cmbTipoDispositivo.Location = new System.Drawing.Point(12, 274);
            this.cmbTipoDispositivo.Name = "cmbTipoDispositivo";
            this.cmbTipoDispositivo.Size = new System.Drawing.Size(140, 21);
            this.cmbTipoDispositivo.TabIndex = 82;
            // 
            // dgvMostrarItem
            // 
            this.dgvMostrarItem.AllowUserToAddRows = false;
            this.dgvMostrarItem.AllowUserToDeleteRows = false;
            this.dgvMostrarItem.AllowUserToResizeColumns = false;
            this.dgvMostrarItem.AllowUserToResizeRows = false;
            this.dgvMostrarItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarItem.ColumnHeadersVisible = false;
            this.dgvMostrarItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvMostrarItem.Location = new System.Drawing.Point(423, 168);
            this.dgvMostrarItem.Name = "dgvMostrarItem";
            this.dgvMostrarItem.Size = new System.Drawing.Size(208, 180);
            this.dgvMostrarItem.TabIndex = 84;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(420, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "ACCESORIOS";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtRegistro.ForeColor = System.Drawing.SystemColors.Info;
            this.txtRegistro.Location = new System.Drawing.Point(12, 328);
            this.txtRegistro.MaxLength = 100;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ShortcutsEnabled = false;
            this.txtRegistro.Size = new System.Drawing.Size(79, 20);
            this.txtRegistro.TabIndex = 85;
            this.txtRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registro_KeyPress);
            // 
            // txtIdDispositivo
            // 
            this.txtIdDispositivo.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtIdDispositivo.Enabled = false;
            this.txtIdDispositivo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtIdDispositivo.Location = new System.Drawing.Point(358, 105);
            this.txtIdDispositivo.Name = "txtIdDispositivo";
            this.txtIdDispositivo.Size = new System.Drawing.Size(79, 20);
            this.txtIdDispositivo.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(505, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "FECHA";
            // 
            // modeloTest
            // 
            this.modeloTest.BackColor = System.Drawing.SystemColors.MenuText;
            this.modeloTest.Enabled = false;
            this.modeloTest.ForeColor = System.Drawing.SystemColors.Info;
            this.modeloTest.Location = new System.Drawing.Point(608, 12);
            this.modeloTest.Name = "modeloTest";
            this.modeloTest.Size = new System.Drawing.Size(10, 20);
            this.modeloTest.TabIndex = 88;
            this.modeloTest.Visible = false;
            // 
            // TipoTest
            // 
            this.TipoTest.BackColor = System.Drawing.SystemColors.MenuText;
            this.TipoTest.Enabled = false;
            this.TipoTest.ForeColor = System.Drawing.SystemColors.Info;
            this.TipoTest.Location = new System.Drawing.Point(621, 12);
            this.TipoTest.Name = "TipoTest";
            this.TipoTest.Size = new System.Drawing.Size(10, 20);
            this.TipoTest.TabIndex = 91;
            this.TipoTest.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(15, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 25);
            this.label10.TabIndex = 92;
            this.label10.Text = "Nuevo Dispositivo";
            // 
            // NuevoDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(650, 433);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TipoTest);
            this.Controls.Add(this.modeloTest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdDispositivo);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.dgvMostrarItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbTipoDispositivo);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoDispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Dispositivo";
            this.Load += new System.EventHandler(this.NuevoDispositivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtIdCliente;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoDispositivo;
        public System.Windows.Forms.DataGridView dgvMostrarItem;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtRegistro;
        public System.Windows.Forms.TextBox txtIdDispositivo;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox modeloTest;
        public System.Windows.Forms.TextBox TipoTest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Label label10;
    }
}
namespace PantallasDesarrollo
{
    partial class clientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientes));
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNuevoDispositivo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEditarContacto = new System.Windows.Forms.Button();
            this.btnNuevoContacto = new System.Windows.Forms.Button();
            this.txtBuscarRtn = new System.Windows.Forms.TextBox();
            this.lblBuscarContacto = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.toolTipNombre = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRTN = new System.Windows.Forms.ToolTip(this.components);
            this.btnAyuda = new System.Windows.Forms.Button();
            this.Ayuda = new System.Windows.Forms.HelpProvider();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.OrangeRed;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.Location = new System.Drawing.Point(602, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 47);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 255);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.btnNuevoDispositivo);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.DgvClientes);
            this.tabPage1.Controls.Add(this.txtBuscarCliente);
            this.tabPage1.Controls.Add(this.lblBuscar);
            this.tabPage1.Controls.Add(this.btnNuevoCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(669, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            // 
            // btnNuevoDispositivo
            // 
            this.btnNuevoDispositivo.BackColor = System.Drawing.Color.Teal;
            this.btnNuevoDispositivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDispositivo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDispositivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoDispositivo.Location = new System.Drawing.Point(475, 20);
            this.btnNuevoDispositivo.Name = "btnNuevoDispositivo";
            this.btnNuevoDispositivo.Size = new System.Drawing.Size(89, 47);
            this.btnNuevoDispositivo.TabIndex = 15;
            this.btnNuevoDispositivo.Text = "NUEVO DISPOSITIVO";
            this.btnNuevoDispositivo.UseVisualStyleBackColor = false;
            this.btnNuevoDispositivo.Click += new System.EventHandler(this.btnNuevoDispositivo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(380, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 47);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // DgvClientes
            // 
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(6, 73);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.Size = new System.Drawing.Size(657, 150);
            this.DgvClientes.TabIndex = 13;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBuscarCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBuscarCliente.Location = new System.Drawing.Point(139, 43);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(176, 20);
            this.txtBuscarCliente.TabIndex = 11;
            this.toolTipNombre.SetToolTip(this.txtBuscarCliente, "Ingresar el nombre del Cliente");
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Location = new System.Drawing.Point(6, 46);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(127, 13);
            this.lblBuscar.TabIndex = 10;
            this.lblBuscar.Text = "BUSCAR POR NOMBRE";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoCliente.Location = new System.Drawing.Point(570, 20);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(89, 47);
            this.btnNuevoCliente.TabIndex = 7;
            this.btnNuevoCliente.Text = "NUEVO CLIENTE";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btnEditarContacto);
            this.tabPage2.Controls.Add(this.btnNuevoContacto);
            this.tabPage2.Controls.Add(this.txtBuscarRtn);
            this.tabPage2.Controls.Add(this.lblBuscarContacto);
            this.tabPage2.Controls.Add(this.dgvContactos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contactos";
            // 
            // btnEditarContacto
            // 
            this.btnEditarContacto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarContacto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarContacto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarContacto.Location = new System.Drawing.Point(454, 23);
            this.btnEditarContacto.Name = "btnEditarContacto";
            this.btnEditarContacto.Size = new System.Drawing.Size(89, 47);
            this.btnEditarContacto.TabIndex = 19;
            this.btnEditarContacto.Text = "EDITAR";
            this.btnEditarContacto.UseVisualStyleBackColor = false;
            this.btnEditarContacto.Click += new System.EventHandler(this.btnEditarContacto_Click_1);
            // 
            // btnNuevoContacto
            // 
            this.btnNuevoContacto.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNuevoContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoContacto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoContacto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoContacto.Location = new System.Drawing.Point(549, 23);
            this.btnNuevoContacto.Name = "btnNuevoContacto";
            this.btnNuevoContacto.Size = new System.Drawing.Size(89, 47);
            this.btnNuevoContacto.TabIndex = 17;
            this.btnNuevoContacto.Text = "NUEVO CONTACTO";
            this.btnNuevoContacto.UseVisualStyleBackColor = false;
            this.btnNuevoContacto.Click += new System.EventHandler(this.btnNuevoContacto_Click);
            // 
            // txtBuscarRtn
            // 
            this.txtBuscarRtn.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBuscarRtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBuscarRtn.Location = new System.Drawing.Point(123, 47);
            this.txtBuscarRtn.Name = "txtBuscarRtn";
            this.txtBuscarRtn.Size = new System.Drawing.Size(239, 20);
            this.txtBuscarRtn.TabIndex = 13;
            this.toolTipRTN.SetToolTip(this.txtBuscarRtn, "Ingresar el RTN aqui");
            this.txtBuscarRtn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarRtn_KeyUp);
            // 
            // lblBuscarContacto
            // 
            this.lblBuscarContacto.AutoSize = true;
            this.lblBuscarContacto.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarContacto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscarContacto.Location = new System.Drawing.Point(11, 50);
            this.lblBuscarContacto.Name = "lblBuscarContacto";
            this.lblBuscarContacto.Size = new System.Drawing.Size(106, 13);
            this.lblBuscarContacto.TabIndex = 12;
            this.lblBuscarContacto.Text = "BUSCAR POR RTN ";
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(6, 76);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.Size = new System.Drawing.Size(657, 147);
            this.dgvContactos.TabIndex = 6;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAyuda.Location = new System.Drawing.Point(4, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(72, 27);
            this.btnAyuda.TabIndex = 19;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // Ayuda
            // 
            this.Ayuda.HelpNamespace = "C:\\Users\\Jr\\Desktop\\Clases III periodo 2017\\Prueba y documentacion\\sistema versio" +
    "n prueba\\Source\\Manual de Usuario 2_Help.exe";
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(692, 322);
            this.ControlBox = false;
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientes";
            this.Load += new System.EventHandler(this.clientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarRtn;
        private System.Windows.Forms.Label lblBuscarContacto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Button btnNuevoDispositivo;
        private System.Windows.Forms.Button btnEditarContacto;
        private System.Windows.Forms.Button btnNuevoContacto;
        private System.Windows.Forms.ToolTip toolTipNombre;
        private System.Windows.Forms.ToolTip toolTipRTN;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.HelpProvider Ayuda;
    }
}
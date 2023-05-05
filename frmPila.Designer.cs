namespace pryBonaderoED
{
    partial class frmPila
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
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEliminado = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTramiteRO = new System.Windows.Forms.TextBox();
            this.txtNombreRO = new System.Windows.Forms.TextBox();
            this.lblCodigoRO = new System.Windows.Forms.Label();
            this.lblTramiteRO = new System.Windows.Forms.Label();
            this.txtCodigoRO = new System.Windows.Forms.TextBox();
            this.lblNombreRO = new System.Windows.Forms.Label();
            this.grbNuevo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.grbListado = new System.Windows.Forms.GroupBox();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.prbGrafico = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.grbEliminado.SuspendLayout();
            this.grbNuevo.SuspendLayout();
            this.grbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prbGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvCola.Location = new System.Drawing.Point(218, 190);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(406, 239);
            this.dgvCola.TabIndex = 9;
            // 
            // clmCodigo
            // 
            this.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.Width = 65;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            // 
            // clmTramite
            // 
            this.clmTramite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTramite.HeaderText = "Tramite";
            this.clmTramite.Name = "clmTramite";
            // 
            // grbEliminado
            // 
            this.grbEliminado.Controls.Add(this.btnEliminar);
            this.grbEliminado.Controls.Add(this.txtTramiteRO);
            this.grbEliminado.Controls.Add(this.txtNombreRO);
            this.grbEliminado.Controls.Add(this.lblCodigoRO);
            this.grbEliminado.Controls.Add(this.lblTramiteRO);
            this.grbEliminado.Controls.Add(this.txtCodigoRO);
            this.grbEliminado.Controls.Add(this.lblNombreRO);
            this.grbEliminado.Location = new System.Drawing.Point(420, 2);
            this.grbEliminado.Name = "grbEliminado";
            this.grbEliminado.Size = new System.Drawing.Size(200, 160);
            this.grbEliminado.TabIndex = 7;
            this.grbEliminado.TabStop = false;
            this.grbEliminado.Text = "Elemento Eliminado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtTramiteRO
            // 
            this.txtTramiteRO.Enabled = false;
            this.txtTramiteRO.Location = new System.Drawing.Point(56, 96);
            this.txtTramiteRO.Name = "txtTramiteRO";
            this.txtTramiteRO.ReadOnly = true;
            this.txtTramiteRO.Size = new System.Drawing.Size(138, 20);
            this.txtTramiteRO.TabIndex = 11;
            // 
            // txtNombreRO
            // 
            this.txtNombreRO.Enabled = false;
            this.txtNombreRO.Location = new System.Drawing.Point(56, 63);
            this.txtNombreRO.Name = "txtNombreRO";
            this.txtNombreRO.ReadOnly = true;
            this.txtNombreRO.Size = new System.Drawing.Size(138, 20);
            this.txtNombreRO.TabIndex = 10;
            // 
            // lblCodigoRO
            // 
            this.lblCodigoRO.AutoSize = true;
            this.lblCodigoRO.Location = new System.Drawing.Point(6, 33);
            this.lblCodigoRO.Name = "lblCodigoRO";
            this.lblCodigoRO.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoRO.TabIndex = 6;
            this.lblCodigoRO.Text = "Codigo:";
            // 
            // lblTramiteRO
            // 
            this.lblTramiteRO.AutoSize = true;
            this.lblTramiteRO.Location = new System.Drawing.Point(6, 99);
            this.lblTramiteRO.Name = "lblTramiteRO";
            this.lblTramiteRO.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteRO.TabIndex = 8;
            this.lblTramiteRO.Text = "Tramite:";
            // 
            // txtCodigoRO
            // 
            this.txtCodigoRO.Enabled = false;
            this.txtCodigoRO.Location = new System.Drawing.Point(94, 30);
            this.txtCodigoRO.Name = "txtCodigoRO";
            this.txtCodigoRO.ReadOnly = true;
            this.txtCodigoRO.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoRO.TabIndex = 9;
            // 
            // lblNombreRO
            // 
            this.lblNombreRO.AutoSize = true;
            this.lblNombreRO.Location = new System.Drawing.Point(6, 66);
            this.lblNombreRO.Name = "lblNombreRO";
            this.lblNombreRO.Size = new System.Drawing.Size(47, 13);
            this.lblNombreRO.TabIndex = 7;
            this.lblNombreRO.Text = "Nombre:";
            // 
            // grbNuevo
            // 
            this.grbNuevo.Controls.Add(this.btnAgregar);
            this.grbNuevo.Controls.Add(this.txtTramite);
            this.grbNuevo.Controls.Add(this.lblCodigo);
            this.grbNuevo.Controls.Add(this.txtNombre);
            this.grbNuevo.Controls.Add(this.lblNombre);
            this.grbNuevo.Controls.Add(this.txtCodigo);
            this.grbNuevo.Controls.Add(this.lblTramite);
            this.grbNuevo.Location = new System.Drawing.Point(214, 2);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Size = new System.Drawing.Size(200, 160);
            this.grbNuevo.TabIndex = 6;
            this.grbNuevo.TabStop = false;
            this.grbNuevo.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 129);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(56, 100);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(138, 20);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged_1);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(94, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 103);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            // 
            // grbListado
            // 
            this.grbListado.Controls.Add(this.lstCola);
            this.grbListado.Location = new System.Drawing.Point(2, 169);
            this.grbListado.Name = "grbListado";
            this.grbListado.Size = new System.Drawing.Size(636, 279);
            this.grbListado.TabIndex = 11;
            this.grbListado.TabStop = false;
            this.grbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(4, 21);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(204, 238);
            this.lstCola.TabIndex = 12;
            // 
            // prbGrafico
            // 
            this.prbGrafico.Image = global::pryBonaderoED.Properties.Resources.representacionPila;
            this.prbGrafico.Location = new System.Drawing.Point(6, 2);
            this.prbGrafico.Name = "prbGrafico";
            this.prbGrafico.Size = new System.Drawing.Size(206, 160);
            this.prbGrafico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbGrafico.TabIndex = 8;
            this.prbGrafico.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 457);
            this.Controls.Add(this.dgvCola);
            this.Controls.Add(this.prbGrafico);
            this.Controls.Add(this.grbEliminado);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.grbListado);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.grbEliminado.ResumeLayout(false);
            this.grbEliminado.PerformLayout();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            this.grbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prbGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.PictureBox prbGrafico;
        private System.Windows.Forms.GroupBox grbEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTramiteRO;
        private System.Windows.Forms.TextBox txtNombreRO;
        private System.Windows.Forms.Label lblCodigoRO;
        private System.Windows.Forms.Label lblTramiteRO;
        private System.Windows.Forms.TextBox txtCodigoRO;
        private System.Windows.Forms.Label lblNombreRO;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.GroupBox grbListado;
        private System.Windows.Forms.ListBox lstCola;
    }
}
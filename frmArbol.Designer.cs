
namespace pryBonaderoED
{
    partial class frmArbol
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
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoN = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbNuevo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvArbol = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRecorrido = new System.Windows.Forms.GroupBox();
            this.rdbDes = new System.Windows.Forms.RadioButton();
            this.rdbAsc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigoBUS = new System.Windows.Forms.Label();
            this.lblNombreBUS = new System.Windows.Forms.Label();
            this.txtTramiteBUS = new System.Windows.Forms.TextBox();
            this.lblTramiteBUS = new System.Windows.Forms.Label();
            this.txtNombreBUS = new System.Windows.Forms.TextBox();
            this.txtCodigoBUS = new System.Windows.Forms.TextBox();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbPostOrder = new System.Windows.Forms.RadioButton();
            this.rdbPreOrder = new System.Windows.Forms.RadioButton();
            this.rdbInOrder = new System.Windows.Forms.RadioButton();
            this.btnExportar = new System.Windows.Forms.Button();
            this.grbEliminar.SuspendLayout();
            this.grbNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).BeginInit();
            this.gbRecorrido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.cmbCodigo);
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Controls.Add(this.lblCodigoN);
            this.grbEliminar.Location = new System.Drawing.Point(421, 12);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(184, 96);
            this.grbEliminar.TabIndex = 21;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Eliminar Nodo";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(55, 29);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigo.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 64);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(167, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigoN
            // 
            this.lblCodigoN.AutoSize = true;
            this.lblCodigoN.Location = new System.Drawing.Point(6, 33);
            this.lblCodigoN.Name = "lblCodigoN";
            this.lblCodigoN.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoN.TabIndex = 0;
            this.lblCodigoN.Text = "Codigo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(6, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(134, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.grbNuevo.Location = new System.Drawing.Point(221, 11);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Size = new System.Drawing.Size(200, 168);
            this.grbNuevo.TabIndex = 20;
            this.grbNuevo.TabStop = false;
            this.grbNuevo.Text = "Nuevo Nodo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 138);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(56, 100);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(138, 20);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
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
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress_1);
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
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(204, 168);
            this.treeView1.TabIndex = 22;
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(12, 195);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(204, 238);
            this.lstCola.TabIndex = 23;
            // 
            // dgvArbol
            // 
            this.dgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvArbol.Location = new System.Drawing.Point(222, 195);
            this.dgvArbol.Name = "dgvArbol";
            this.dgvArbol.Size = new System.Drawing.Size(383, 238);
            this.dgvArbol.TabIndex = 24;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 65;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 69;
            // 
            // Tramite
            // 
            this.Tramite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            // 
            // gbRecorrido
            // 
            this.gbRecorrido.Controls.Add(this.rdbDes);
            this.gbRecorrido.Controls.Add(this.rdbAsc);
            this.gbRecorrido.Location = new System.Drawing.Point(421, 114);
            this.gbRecorrido.Name = "gbRecorrido";
            this.gbRecorrido.Size = new System.Drawing.Size(184, 65);
            this.gbRecorrido.TabIndex = 25;
            this.gbRecorrido.TabStop = false;
            this.gbRecorrido.Text = "Configurar Recorrido";
            // 
            // rdbDes
            // 
            this.rdbDes.AutoSize = true;
            this.rdbDes.Location = new System.Drawing.Point(5, 41);
            this.rdbDes.Name = "rdbDes";
            this.rdbDes.Size = new System.Drawing.Size(89, 17);
            this.rdbDes.TabIndex = 9;
            this.rdbDes.TabStop = true;
            this.rdbDes.Text = "Descendente";
            this.rdbDes.UseVisualStyleBackColor = true;
            // 
            // rdbAsc
            // 
            this.rdbAsc.AutoSize = true;
            this.rdbAsc.Location = new System.Drawing.Point(6, 18);
            this.rdbAsc.Name = "rdbAsc";
            this.rdbAsc.Size = new System.Drawing.Size(82, 17);
            this.rdbAsc.TabIndex = 8;
            this.rdbAsc.TabStop = true;
            this.rdbAsc.Text = "Ascendente";
            this.rdbAsc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigoBUS);
            this.groupBox1.Controls.Add(this.lblNombreBUS);
            this.groupBox1.Controls.Add(this.txtTramiteBUS);
            this.groupBox1.Controls.Add(this.lblTramiteBUS);
            this.groupBox1.Controls.Add(this.txtNombreBUS);
            this.groupBox1.Controls.Add(this.txtCodigoBUS);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(611, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 167);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Nodo";
            // 
            // lblCodigoBUS
            // 
            this.lblCodigoBUS.AutoSize = true;
            this.lblCodigoBUS.Location = new System.Drawing.Point(6, 32);
            this.lblCodigoBUS.Name = "lblCodigoBUS";
            this.lblCodigoBUS.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoBUS.TabIndex = 7;
            this.lblCodigoBUS.Text = "Codigo:";
            // 
            // lblNombreBUS
            // 
            this.lblNombreBUS.AutoSize = true;
            this.lblNombreBUS.Location = new System.Drawing.Point(6, 65);
            this.lblNombreBUS.Name = "lblNombreBUS";
            this.lblNombreBUS.Size = new System.Drawing.Size(47, 13);
            this.lblNombreBUS.TabIndex = 8;
            this.lblNombreBUS.Text = "Nombre:";
            // 
            // txtTramiteBUS
            // 
            this.txtTramiteBUS.Enabled = false;
            this.txtTramiteBUS.Location = new System.Drawing.Point(57, 95);
            this.txtTramiteBUS.Name = "txtTramiteBUS";
            this.txtTramiteBUS.ReadOnly = true;
            this.txtTramiteBUS.Size = new System.Drawing.Size(83, 20);
            this.txtTramiteBUS.TabIndex = 13;
            // 
            // lblTramiteBUS
            // 
            this.lblTramiteBUS.AutoSize = true;
            this.lblTramiteBUS.Location = new System.Drawing.Point(6, 98);
            this.lblTramiteBUS.Name = "lblTramiteBUS";
            this.lblTramiteBUS.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteBUS.TabIndex = 9;
            this.lblTramiteBUS.Text = "Tramite:";
            // 
            // txtNombreBUS
            // 
            this.txtNombreBUS.Enabled = false;
            this.txtNombreBUS.Location = new System.Drawing.Point(57, 62);
            this.txtNombreBUS.Name = "txtNombreBUS";
            this.txtNombreBUS.ReadOnly = true;
            this.txtNombreBUS.Size = new System.Drawing.Size(83, 20);
            this.txtNombreBUS.TabIndex = 12;
            // 
            // txtCodigoBUS
            // 
            this.txtCodigoBUS.Enabled = false;
            this.txtCodigoBUS.Location = new System.Drawing.Point(58, 29);
            this.txtCodigoBUS.Name = "txtCodigoBUS";
            this.txtCodigoBUS.ReadOnly = true;
            this.txtCodigoBUS.Size = new System.Drawing.Size(83, 20);
            this.txtCodigoBUS.TabIndex = 11;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(617, 195);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(138, 30);
            this.btnEquilibrar.TabIndex = 27;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbPostOrder);
            this.groupBox2.Controls.Add(this.rdbPreOrder);
            this.groupBox2.Controls.Add(this.rdbInOrder);
            this.groupBox2.Location = new System.Drawing.Point(611, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 96);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orden de Recorrido";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdbPostOrder
            // 
            this.rdbPostOrder.AutoSize = true;
            this.rdbPostOrder.Location = new System.Drawing.Point(9, 67);
            this.rdbPostOrder.Name = "rdbPostOrder";
            this.rdbPostOrder.Size = new System.Drawing.Size(72, 17);
            this.rdbPostOrder.TabIndex = 12;
            this.rdbPostOrder.TabStop = true;
            this.rdbPostOrder.Text = "PostOrder";
            this.rdbPostOrder.UseVisualStyleBackColor = true;
            // 
            // rdbPreOrder
            // 
            this.rdbPreOrder.AutoSize = true;
            this.rdbPreOrder.Location = new System.Drawing.Point(9, 44);
            this.rdbPreOrder.Name = "rdbPreOrder";
            this.rdbPreOrder.Size = new System.Drawing.Size(67, 17);
            this.rdbPreOrder.TabIndex = 11;
            this.rdbPreOrder.TabStop = true;
            this.rdbPreOrder.Text = "PreOrder";
            this.rdbPreOrder.UseVisualStyleBackColor = true;
            // 
            // rdbInOrder
            // 
            this.rdbInOrder.AutoSize = true;
            this.rdbInOrder.Location = new System.Drawing.Point(9, 21);
            this.rdbInOrder.Name = "rdbInOrder";
            this.rdbInOrder.Size = new System.Drawing.Size(60, 17);
            this.rdbInOrder.TabIndex = 10;
            this.rdbInOrder.TabStop = true;
            this.rdbInOrder.Text = "InOrder";
            this.rdbInOrder.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(617, 231);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(138, 30);
            this.btnExportar.TabIndex = 28;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 445);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.gbRecorrido);
            this.Controls.Add(this.dgvArbol);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArbol";
            this.Load += new System.EventHandler(this.frmArbol_Load);
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).EndInit();
            this.gbRecorrido.ResumeLayout(false);
            this.gbRecorrido.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoN;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.DataGridView dgvArbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox gbRecorrido;
        private System.Windows.Forms.RadioButton rdbDes;
        private System.Windows.Forms.RadioButton rdbAsc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTramiteBUS;
        private System.Windows.Forms.TextBox txtNombreBUS;
        private System.Windows.Forms.TextBox txtCodigoBUS;
        private System.Windows.Forms.Label lblCodigoBUS;
        private System.Windows.Forms.Label lblNombreBUS;
        private System.Windows.Forms.Label lblTramiteBUS;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbPostOrder;
        private System.Windows.Forms.RadioButton rdbPreOrder;
        private System.Windows.Forms.RadioButton rdbInOrder;
        private System.Windows.Forms.Button btnExportar;
    }
}
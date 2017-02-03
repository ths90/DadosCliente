namespace WindowsFormsApplication1
{
    partial class frmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.lblestado = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.mskcelular = new System.Windows.Forms.MaskedTextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.mskcep = new System.Windows.Forms.MaskedTextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tstPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncadastrar);
            this.groupBox1.Controls.Add(this.lblestado);
            this.groupBox1.Controls.Add(this.cboestado);
            this.groupBox1.Controls.Add(this.lblcelular);
            this.groupBox1.Controls.Add(this.mskcelular);
            this.groupBox1.Controls.Add(this.lblcep);
            this.groupBox1.Controls.Add(this.btnpesquisa);
            this.groupBox1.Controls.Add(this.mskcep);
            this.groupBox1.Controls.Add(this.lblbairro);
            this.groupBox1.Controls.Add(this.lblcidade);
            this.groupBox1.Controls.Add(this.lblnumero);
            this.groupBox1.Controls.Add(this.lblendereco);
            this.groupBox1.Controls.Add(this.txtcidade);
            this.groupBox1.Controls.Add(this.txtbairro);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.txtendereco);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Controls.Add(this.lblcodigo);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(733, 211);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 9;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(656, 140);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(46, 13);
            this.lblestado.TabIndex = 18;
            this.lblestado.Text = "Estado";
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboestado.Location = new System.Drawing.Point(659, 155);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(43, 21);
            this.cboestado.TabIndex = 7;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Location = new System.Drawing.Point(705, 140);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(46, 13);
            this.lblcelular.TabIndex = 16;
            this.lblcelular.Text = "Celular";
            // 
            // mskcelular
            // 
            this.mskcelular.Location = new System.Drawing.Point(708, 155);
            this.mskcelular.Mask = "(999) 00000-0000";
            this.mskcelular.Name = "mskcelular";
            this.mskcelular.Size = new System.Drawing.Size(100, 20);
            this.mskcelular.TabIndex = 8;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(19, 85);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(31, 13);
            this.lblcep.TabIndex = 14;
            this.lblcep.Text = "CEP";
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnpesquisa.Image")));
            this.btnpesquisa.Location = new System.Drawing.Point(98, 104);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(28, 21);
            this.btnpesquisa.TabIndex = 13;
            this.btnpesquisa.UseVisualStyleBackColor = true;
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // mskcep
            // 
            this.mskcep.Location = new System.Drawing.Point(19, 104);
            this.mskcep.Mask = "00000-000";
            this.mskcep.Name = "mskcep";
            this.mskcep.Size = new System.Drawing.Size(73, 20);
            this.mskcep.TabIndex = 2;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(19, 136);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(40, 13);
            this.lblbairro.TabIndex = 11;
            this.lblbairro.Text = "Bairro";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(314, 137);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(46, 13);
            this.lblcidade.TabIndex = 10;
            this.lblcidade.Text = "Cidade";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(737, 85);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(50, 13);
            this.lblnumero.TabIndex = 9;
            this.lblnumero.Text = "Número";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(161, 85);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(61, 13);
            this.lblendereco.TabIndex = 8;
            this.lblendereco.Text = "Endereço";
            // 
            // txtcidade
            // 
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcidade.Location = new System.Drawing.Point(314, 156);
            this.txtcidade.MaxLength = 50;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(339, 20);
            this.txtcidade.TabIndex = 6;
            // 
            // txtbairro
            // 
            this.txtbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbairro.Location = new System.Drawing.Point(19, 156);
            this.txtbairro.MaxLength = 30;
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(289, 20);
            this.txtbairro.TabIndex = 5;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(737, 104);
            this.txtnumero.MaxLength = 5;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(60, 20);
            this.txtnumero.TabIndex = 4;
            // 
            // txtendereco
            // 
            this.txtendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendereco.Location = new System.Drawing.Point(161, 104);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(570, 20);
            this.txtendereco.TabIndex = 3;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(135, 32);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(39, 13);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Nome";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(73, 32);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(46, 13);
            this.lblcodigo.TabIndex = 2;
            this.lblcodigo.Text = "Código";
            this.lblcodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Location = new System.Drawing.Point(138, 49);
            this.txtnome.MaxLength = 50;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(662, 20);
            this.txtnome.TabIndex = 1;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(19, 49);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstSalvar,
            this.toolStripSeparator1,
            this.tstExcluir,
            this.toolStripSeparator3,
            this.tstPesquisar,
            this.toolStripSeparator2,
            this.tstSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(866, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstSalvar
            // 
            this.tstSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tstSalvar.Image")));
            this.tstSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSalvar.Name = "tstSalvar";
            this.tstSalvar.Size = new System.Drawing.Size(42, 22);
            this.tstSalvar.Text = "&Salvar";
            this.tstSalvar.Click += new System.EventHandler(this.tstSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tstExcluir
            // 
            this.tstExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tstExcluir.Image")));
            this.tstExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstExcluir.Name = "tstExcluir";
            this.tstExcluir.Size = new System.Drawing.Size(45, 22);
            this.tstExcluir.Text = "&Excluir";
            this.tstExcluir.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tstPesquisar
            // 
            this.tstPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("tstPesquisar.Image")));
            this.tstPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstPesquisar.Name = "tstPesquisar";
            this.tstPesquisar.Size = new System.Drawing.Size(61, 22);
            this.tstPesquisar.Text = "&Pesquisar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tstSair
            // 
            this.tstSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSair.Image = ((System.Drawing.Image)(resources.GetObject("tstSair.Image")));
            this.tstSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSair.Name = "tstSair";
            this.tstSair.Size = new System.Drawing.Size(30, 22);
            this.tstSair.Text = "&Sair";
            this.tstSair.Click += new System.EventHandler(this.tstSair_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 347);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Cliente";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgenda_KeyPress_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.MaskedTextBox mskcep;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.MaskedTextBox mskcelular;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstExcluir;
        private System.Windows.Forms.ToolStripButton tstSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tstPesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tstSair;
    }
}


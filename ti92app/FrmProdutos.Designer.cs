namespace ti92app
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDescontinuado = new System.Windows.Forms.CheckBox();
            this.txtCodBar = new System.Windows.Forms.TextBox();
            this.mskDesconto = new System.Windows.Forms.MaskedTextBox();
            this.mskPreco = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtgLista = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescontinuado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.cmbUnidade);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.chkDescontinuado);
            this.groupBox1.Controls.Add(this.txtCodBar);
            this.groupBox1.Controls.Add(this.mskDesconto);
            this.groupBox1.Controls.Add(this.mskPreco);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(11, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUTO";
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Items.AddRange(new object[] {
            "KILO",
            "PEÇA",
            "CAIXA",
            "METRO",
            "UNIDADE"});
            this.cmbUnidade.Location = new System.Drawing.Point(21, 141);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(104, 26);
            this.cmbUnidade.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "DESCONTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "PREÇO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "COD BARRAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "UNIDADE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "DESCRIÇÃO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // chkDescontinuado
            // 
            this.chkDescontinuado.AutoSize = true;
            this.chkDescontinuado.Enabled = false;
            this.chkDescontinuado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDescontinuado.Location = new System.Drawing.Point(156, 159);
            this.chkDescontinuado.Name = "chkDescontinuado";
            this.chkDescontinuado.Size = new System.Drawing.Size(147, 21);
            this.chkDescontinuado.TabIndex = 6;
            this.chkDescontinuado.Text = "DESCONTINUADO";
            this.chkDescontinuado.UseVisualStyleBackColor = true;
            // 
            // txtCodBar
            // 
            this.txtCodBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCodBar.Location = new System.Drawing.Point(20, 183);
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(105, 24);
            this.txtCodBar.TabIndex = 3;
            // 
            // mskDesconto
            // 
            this.mskDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDesconto.Location = new System.Drawing.Point(170, 233);
            this.mskDesconto.Name = "mskDesconto";
            this.mskDesconto.Size = new System.Drawing.Size(120, 24);
            this.mskDesconto.TabIndex = 5;
            this.mskDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mskPreco
            // 
            this.mskPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPreco.Location = new System.Drawing.Point(22, 233);
            this.mskPreco.Name = "mskPreco";
            this.mskPreco.Size = new System.Drawing.Size(105, 24);
            this.mskPreco.TabIndex = 4;
            this.mskPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(20, 85);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(226, 24);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(20, 33);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(54, 24);
            this.txtId.TabIndex = 0;
            // 
            // dtgLista
            // 
            this.dtgLista.AllowUserToAddRows = false;
            this.dtgLista.AllowUserToDeleteRows = false;
            this.dtgLista.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnCodBar,
            this.clnDescricao,
            this.clnUnidade,
            this.clnPreco,
            this.clnDesconto,
            this.clnDescontinuado});
            this.dtgLista.Location = new System.Drawing.Point(11, 447);
            this.dtgLista.Name = "dtgLista";
            this.dtgLista.ReadOnly = true;
            this.dtgLista.RowHeadersVisible = false;
            this.dtgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLista.Size = new System.Drawing.Size(690, 150);
            this.dtgLista.TabIndex = 1;
            this.dtgLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLista_CellContentClick);
            this.dtgLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLista_CellDoubleClick);
            this.dtgLista.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgLista_UserDeletedRow);
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 60;
            // 
            // clnCodBar
            // 
            this.clnCodBar.Frozen = true;
            this.clnCodBar.HeaderText = "CODBAR";
            this.clnCodBar.Name = "clnCodBar";
            this.clnCodBar.ReadOnly = true;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Frozen = true;
            this.clnDescricao.HeaderText = "DESCRIÇÃO";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 230;
            // 
            // clnUnidade
            // 
            this.clnUnidade.Frozen = true;
            this.clnUnidade.HeaderText = "UND";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 50;
            // 
            // clnPreco
            // 
            this.clnPreco.Frozen = true;
            this.clnPreco.HeaderText = "PREÇO";
            this.clnPreco.Name = "clnPreco";
            this.clnPreco.ReadOnly = true;
            // 
            // clnDesconto
            // 
            this.clnDesconto.Frozen = true;
            this.clnDesconto.HeaderText = "DESCONTO";
            this.clnDesconto.Name = "clnDesconto";
            this.clnDesconto.ReadOnly = true;
            // 
            // clnDescontinuado
            // 
            this.clnDescontinuado.Frozen = true;
            this.clnDescontinuado.HeaderText = "ATIVO";
            this.clnDescontinuado.Name = "clnDescontinuado";
            this.clnDescontinuado.ReadOnly = true;
            this.clnDescontinuado.Width = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 427);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(623, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoSize = true;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(15, 430);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(57, 13);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.Text = "BUSCAR";
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = global::ti92app.Properties.Resources.View;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(24, 311);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 41);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::ti92app.Properties.Resources.erroo;
            this.btnCancelar.Location = new System.Drawing.Point(156, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 41);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::ti92app.Properties.Resources.Pencil;
            this.btnEditar.Location = new System.Drawing.Point(140, 264);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 41);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = global::ti92app.Properties.Resources._23;
            this.btnAdicionar.Location = new System.Drawing.Point(20, 263);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(107, 43);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 617);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtgLista);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProdutos";
            this.Text = "PRODUTOS";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.CheckBox chkDescontinuado;
        private System.Windows.Forms.TextBox txtCodBar;
        private System.Windows.Forms.MaskedTextBox mskDesconto;
        private System.Windows.Forms.MaskedTextBox mskPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgLista;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDesconto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnDescontinuado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtBuscar;
    }
}
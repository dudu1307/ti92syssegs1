namespace ti92app
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.txtNomeNivel = new System.Windows.Forms.TextBox();
            this.txtSiglaNivel = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsereNivel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.txtBuscaUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.comboNivelUsuario = new System.Windows.Forms.ComboBox();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsereUsuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 294);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(322, 121);
            this.listBox1.TabIndex = 2;
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.Location = new System.Drawing.Point(51, 19);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.ReadOnly = true;
            this.txtIdNivel.Size = new System.Drawing.Size(100, 20);
            this.txtIdNivel.TabIndex = 3;
            this.txtIdNivel.TextChanged += new System.EventHandler(this.txtIdNivel_TextChanged);
            // 
            // txtNomeNivel
            // 
            this.txtNomeNivel.Location = new System.Drawing.Point(51, 45);
            this.txtNomeNivel.Name = "txtNomeNivel";
            this.txtNomeNivel.Size = new System.Drawing.Size(100, 20);
            this.txtNomeNivel.TabIndex = 4;
            // 
            // txtSiglaNivel
            // 
            this.txtSiglaNivel.Location = new System.Drawing.Point(51, 71);
            this.txtSiglaNivel.Name = "txtSiglaNivel";
            this.txtSiglaNivel.Size = new System.Drawing.Size(100, 20);
            this.txtSiglaNivel.TabIndex = 5;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnExcluir);
            this.groupBox.Controls.Add(this.btnEditar);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.btnInsereNivel);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txtIdNivel);
            this.groupBox.Controls.Add(this.txtSiglaNivel);
            this.groupBox.Controls.Add(this.txtNomeNivel);
            this.groupBox.Location = new System.Drawing.Point(36, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(322, 240);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Nivel";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(202, 211);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(121, 211);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // btnInsereNivel
            // 
            this.btnInsereNivel.Location = new System.Drawing.Point(40, 211);
            this.btnInsereNivel.Name = "btnInsereNivel";
            this.btnInsereNivel.Size = new System.Drawing.Size(75, 23);
            this.btnInsereNivel.TabIndex = 9;
            this.btnInsereNivel.Text = "Inserir";
            this.btnInsereNivel.UseVisualStyleBackColor = true;
            this.btnInsereNivel.Click += new System.EventHandler(this.btnInsereNivel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SIGLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOME";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(36, 268);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(322, 20);
            this.txtBusca.TabIndex = 7;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // txtBuscaUsuario
            // 
            this.txtBuscaUsuario.Location = new System.Drawing.Point(397, 268);
            this.txtBuscaUsuario.Name = "txtBuscaUsuario";
            this.txtBuscaUsuario.Size = new System.Drawing.Size(322, 20);
            this.txtBuscaUsuario.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAtivo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSenhaUsuario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEmailUsuario);
            this.groupBox1.Controls.Add(this.comboNivelUsuario);
            this.groupBox1.Controls.Add(this.btnExcluirUsuario);
            this.groupBox1.Controls.Add(this.btnEditarUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInsereUsuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Controls.Add(this.txtNomeUsuario);
            this.groupBox1.Location = new System.Drawing.Point(397, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 240);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nivel";
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Location = new System.Drawing.Point(51, 167);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAtivo.TabIndex = 16;
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "ATIVO";
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(51, 105);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaUsuario.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "SENHA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "EMAIL";
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(51, 74);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtEmailUsuario.TabIndex = 11;
            // 
            // comboNivelUsuario
            // 
            this.comboNivelUsuario.FormattingEnabled = true;
            this.comboNivelUsuario.Location = new System.Drawing.Point(52, 128);
            this.comboNivelUsuario.Name = "comboNivelUsuario";
            this.comboNivelUsuario.Size = new System.Drawing.Size(100, 21);
            this.comboNivelUsuario.TabIndex = 10;
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Location = new System.Drawing.Point(199, 211);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirUsuario.TabIndex = 7;
            this.btnExcluirUsuario.Text = "Excluir";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(118, 211);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarUsuario.TabIndex = 7;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // btnInsereUsuario
            // 
            this.btnInsereUsuario.Location = new System.Drawing.Point(37, 211);
            this.btnInsereUsuario.Name = "btnInsereUsuario";
            this.btnInsereUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnInsereUsuario.TabIndex = 9;
            this.btnInsereUsuario.Text = "Inserir";
            this.btnInsereUsuario.UseVisualStyleBackColor = true;
            this.btnInsereUsuario.Click += new System.EventHandler(this.btnInsereUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "NÍVEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "NOME";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(51, 19);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIdUsuario.TabIndex = 3;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(51, 45);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomeUsuario.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(397, 294);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(322, 121);
            this.listBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscaUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtIdNivel;
        private System.Windows.Forms.TextBox txtNomeNivel;
        private System.Windows.Forms.TextBox txtSiglaNivel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsereNivel;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.TextBox txtBuscaUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboNivelUsuario;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsereUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailUsuario;
    }
}


namespace ProjetoPaintball
{
    partial class CadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxNomeUsu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxCodUsu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedCPF = new System.Windows.Forms.MaskedTextBox();
            this.tboxTelefone2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedRG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckboxMostraSenha = new System.Windows.Forms.CheckBox();
            this.tboxSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "Grupo de informações principais do usuário";
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.tboxNomeUsu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxCodUsu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Usuário";
            // 
            // tboxNomeUsu
            // 
            this.tboxNomeUsu.Location = new System.Drawing.Point(303, 35);
            this.tboxNomeUsu.MaxLength = 50;
            this.tboxNomeUsu.Name = "tboxNomeUsu";
            this.tboxNomeUsu.Size = new System.Drawing.Size(277, 26);
            this.tboxNomeUsu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome: ";
            // 
            // tboxCodUsu
            // 
            this.tboxCodUsu.Location = new System.Drawing.Point(96, 35);
            this.tboxCodUsu.MaxLength = 14;
            this.tboxCodUsu.Name = "tboxCodUsu";
            this.tboxCodUsu.Size = new System.Drawing.Size(102, 26);
            this.tboxCodUsu.TabIndex = 1;
            this.tboxCodUsu.TextChanged += new System.EventHandler(this.tboxCodUsu_TextChanged);
            this.tboxCodUsu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCodUsu_KeyPress);
            this.tboxCodUsu.Leave += new System.EventHandler(this.tboxCodUsu_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedCPF);
            this.groupBox2.Controls.Add(this.tboxTelefone2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.maskedRG);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tboxTelefone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tboxEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações Adicionais";
            // 
            // maskedCPF
            // 
            this.maskedCPF.Location = new System.Drawing.Point(298, 35);
            this.maskedCPF.Name = "maskedCPF";
            this.maskedCPF.Size = new System.Drawing.Size(143, 26);
            this.maskedCPF.TabIndex = 10;
            this.maskedCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedCPF_KeyPress);
            // 
            // tboxTelefone2
            // 
            this.tboxTelefone2.Location = new System.Drawing.Point(355, 81);
            this.tboxTelefone2.MaxLength = 20;
            this.tboxTelefone2.Name = "tboxTelefone2";
            this.tboxTelefone2.Size = new System.Drawing.Size(168, 26);
            this.tboxTelefone2.TabIndex = 9;
            this.tboxTelefone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxTelefone2_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefone 2 :";
            // 
            // maskedRG
            // 
            this.maskedRG.Location = new System.Drawing.Point(491, 37);
            this.maskedRG.MaxLength = 7;
            this.maskedRG.Name = "maskedRG";
            this.maskedRG.Size = new System.Drawing.Size(97, 26);
            this.maskedRG.TabIndex = 7;
            this.maskedRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedRG_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "RG :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "CPF :";
            // 
            // tboxTelefone
            // 
            this.tboxTelefone.Location = new System.Drawing.Point(105, 81);
            this.tboxTelefone.MaxLength = 20;
            this.tboxTelefone.Name = "tboxTelefone";
            this.tboxTelefone.Size = new System.Drawing.Size(132, 26);
            this.tboxTelefone.TabIndex = 3;
            this.tboxTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxTelefone_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefone :";
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(77, 35);
            this.tboxEmail.MaxLength = 50;
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(156, 26);
            this.tboxEmail.TabIndex = 1;
            this.tboxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxEmail_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "email :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckboxMostraSenha);
            this.groupBox3.Controls.Add(this.tboxSenha);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tboxLogin);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login e Senha";
            // 
            // ckboxMostraSenha
            // 
            this.ckboxMostraSenha.AutoSize = true;
            this.ckboxMostraSenha.Enabled = false;
            this.ckboxMostraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxMostraSenha.Location = new System.Drawing.Point(328, 70);
            this.ckboxMostraSenha.Name = "ckboxMostraSenha";
            this.ckboxMostraSenha.Size = new System.Drawing.Size(127, 20);
            this.ckboxMostraSenha.TabIndex = 4;
            this.ckboxMostraSenha.Text = "Mostrar Senha";
            this.ckboxMostraSenha.UseVisualStyleBackColor = true;
            this.ckboxMostraSenha.CheckedChanged += new System.EventHandler(this.ckboxMostraSenha_CheckedChanged);
            // 
            // tboxSenha
            // 
            this.tboxSenha.Location = new System.Drawing.Point(328, 40);
            this.tboxSenha.MaxLength = 10;
            this.tboxSenha.Name = "tboxSenha";
            this.tboxSenha.PasswordChar = '*';
            this.tboxSenha.Size = new System.Drawing.Size(121, 26);
            this.tboxSenha.TabIndex = 3;
            this.tboxSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxSenha_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha :";
            // 
            // tboxLogin
            // 
            this.tboxLogin.Location = new System.Drawing.Point(102, 38);
            this.tboxLogin.MaxLength = 10;
            this.tboxLogin.Name = "tboxLogin";
            this.tboxLogin.Size = new System.Drawing.Size(112, 26);
            this.tboxLogin.TabIndex = 1;
            this.tboxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxLogin_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login :";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(15, 362);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 35);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(138, 362);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(120, 35);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(256, 362);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 35);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(374, 362);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 35);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(492, 362);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 35);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseCompatibleTextRendering = true;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // CadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 413);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.CadUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckboxMostraSenha;
        private System.Windows.Forms.TextBox tboxSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tboxTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maskedRG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxTelefone2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedCPF;
        public System.Windows.Forms.TextBox tboxEmail;
        public System.Windows.Forms.TextBox tboxCodUsu;
        public System.Windows.Forms.TextBox tboxNomeUsu;
    }
}
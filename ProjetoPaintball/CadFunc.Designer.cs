namespace ProjetoPaintball
{
    partial class CadFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFunc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxNomeFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxCodFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tboxNomeCargos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxCodCargos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tboxCNHFunc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tboxEnderecoFunc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mkdDtDesl = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mkdDtCad = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxRGFunc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxCPFFunc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxTel2Func = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxTelFunc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxNomeFunc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxCodFunc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionários";
            // 
            // tboxNomeFunc
            // 
            this.tboxNomeFunc.Location = new System.Drawing.Point(364, 36);
            this.tboxNomeFunc.Name = "tboxNomeFunc";
            this.tboxNomeFunc.Size = new System.Drawing.Size(299, 26);
            this.tboxNomeFunc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Nome do funcionário: ";
            // 
            // tboxCodFunc
            // 
            this.tboxCodFunc.Location = new System.Drawing.Point(104, 33);
            this.tboxCodFunc.Name = "tboxCodFunc";
            this.tboxCodFunc.Size = new System.Drawing.Size(66, 26);
            this.tboxCodFunc.TabIndex = 1;
            this.tboxCodFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCodFunc_KeyPress);
            this.tboxCodFunc.Leave += new System.EventHandler(this.tboxCodFunc_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Código: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tboxNomeCargos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tboxCodCargos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(14, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargos/Função";
            // 
            // tboxNomeCargos
            // 
            this.tboxNomeCargos.Enabled = false;
            this.tboxNomeCargos.Location = new System.Drawing.Point(326, 29);
            this.tboxNomeCargos.Name = "tboxNomeCargos";
            this.tboxNomeCargos.Size = new System.Drawing.Size(335, 26);
            this.tboxNomeCargos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome do cargo: ";
            // 
            // tboxCodCargos
            // 
            this.tboxCodCargos.Location = new System.Drawing.Point(102, 29);
            this.tboxCodCargos.Name = "tboxCodCargos";
            this.tboxCodCargos.Size = new System.Drawing.Size(66, 26);
            this.tboxCodCargos.TabIndex = 5;
            this.tboxCodCargos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCodCargos_KeyPress);
            this.tboxCodCargos.Leave += new System.EventHandler(this.tboxCodCargos_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "*Código: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tboxCNHFunc);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tboxEnderecoFunc);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.mkdDtDesl);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.mkdDtCad);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tboxRGFunc);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tboxCPFFunc);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tboxTel2Func);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tboxTelFunc);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(17, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 224);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados";
            // 
            // tboxCNHFunc
            // 
            this.tboxCNHFunc.Location = new System.Drawing.Point(447, 73);
            this.tboxCNHFunc.Name = "tboxCNHFunc";
            this.tboxCNHFunc.Size = new System.Drawing.Size(206, 26);
            this.tboxCNHFunc.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(391, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "CNH:";
            // 
            // tboxEnderecoFunc
            // 
            this.tboxEnderecoFunc.Location = new System.Drawing.Point(120, 168);
            this.tboxEnderecoFunc.Name = "tboxEnderecoFunc";
            this.tboxEnderecoFunc.Size = new System.Drawing.Size(532, 26);
            this.tboxEnderecoFunc.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "*Endereço:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // mkdDtDesl
            // 
            this.mkdDtDesl.Location = new System.Drawing.Point(515, 119);
            this.mkdDtDesl.Mask = "00/00/0000";
            this.mkdDtDesl.Name = "mkdDtDesl";
            this.mkdDtDesl.Size = new System.Drawing.Size(138, 26);
            this.mkdDtDesl.TabIndex = 7;
            this.mkdDtDesl.ValidatingType = typeof(System.DateTime);
            this.mkdDtDesl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mkdDtDesl_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Data de Desligamento:";
            // 
            // mkdDtCad
            // 
            this.mkdDtCad.Location = new System.Drawing.Point(178, 119);
            this.mkdDtCad.Mask = "00/00/0000";
            this.mkdDtCad.Name = "mkdDtCad";
            this.mkdDtCad.Size = new System.Drawing.Size(134, 26);
            this.mkdDtCad.TabIndex = 6;
            this.mkdDtCad.ValidatingType = typeof(System.DateTime);
            this.mkdDtCad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mkdDtCad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mkdDtCad_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "*Data de Cadastro:";
            // 
            // tboxRGFunc
            // 
            this.tboxRGFunc.Location = new System.Drawing.Point(265, 73);
            this.tboxRGFunc.Name = "tboxRGFunc";
            this.tboxRGFunc.Size = new System.Drawing.Size(114, 26);
            this.tboxRGFunc.TabIndex = 4;
            this.tboxRGFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxRGFunc_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "RG: ";
            // 
            // tboxCPFFunc
            // 
            this.tboxCPFFunc.Location = new System.Drawing.Point(74, 73);
            this.tboxCPFFunc.Name = "tboxCPFFunc";
            this.tboxCPFFunc.Size = new System.Drawing.Size(136, 26);
            this.tboxCPFFunc.TabIndex = 3;
            this.tboxCPFFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCPFFunc_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "*CPF: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tboxTel2Func
            // 
            this.tboxTel2Func.Location = new System.Drawing.Point(432, 29);
            this.tboxTel2Func.Name = "tboxTel2Func";
            this.tboxTel2Func.Size = new System.Drawing.Size(221, 26);
            this.tboxTel2Func.TabIndex = 2;
            this.tboxTel2Func.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxTel2Func_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefone 2: ";
            // 
            // tboxTelFunc
            // 
            this.tboxTelFunc.Location = new System.Drawing.Point(110, 29);
            this.tboxTelFunc.Name = "tboxTelFunc";
            this.tboxTelFunc.Size = new System.Drawing.Size(204, 26);
            this.tboxTelFunc.TabIndex = 1;
            this.tboxTelFunc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tboxTelFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxTelFunc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "*Telefone: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(14, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "*Campos obrigatórios";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(543, 467);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(139, 35);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseCompatibleTextRendering = true;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(413, 467);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 35);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(282, 467);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(135, 35);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(152, 467);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(132, 35);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(17, 467);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(138, 35);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 511);
            this.Controls.Add(this.label12);
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
            this.Name = "CadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxNomeFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxCodFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tboxNomeCargos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxCodCargos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxTelFunc;
        private System.Windows.Forms.TextBox tboxTel2Func;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxRGFunc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxCPFFunc;
        private System.Windows.Forms.MaskedTextBox mkdDtCad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mkdDtDesl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tboxEnderecoFunc;
        private System.Windows.Forms.TextBox tboxCNHFunc;
        private System.Windows.Forms.Label label13;
    }
}
namespace ProjetoPaintball
{
    partial class CadTipoArma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadTipoArma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxDescTPArmas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxNomeTPArmas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxCodTPArmas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sGJPTPARMACODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGJPTPARMANOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGJPTPARMADESCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGJPTPARMABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGJPDataSet1 = new ProjetoPaintball.SGJPDataSet1();
            this.sGJP_TPARMATableAdapter = new ProjetoPaintball.SGJPDataSet1TableAdapters.SGJP_TPARMATableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGJPTPARMABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGJPDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxDescTPArmas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tboxNomeTPArmas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxCodTPArmas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de armas";
            // 
            // tboxDescTPArmas
            // 
            this.tboxDescTPArmas.Location = new System.Drawing.Point(12, 102);
            this.tboxDescTPArmas.MaxLength = 250;
            this.tboxDescTPArmas.Multiline = true;
            this.tboxDescTPArmas.Name = "tboxDescTPArmas";
            this.tboxDescTPArmas.Size = new System.Drawing.Size(636, 136);
            this.tboxDescTPArmas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição: ";
            // 
            // tboxNomeTPArmas
            // 
            this.tboxNomeTPArmas.Location = new System.Drawing.Point(369, 36);
            this.tboxNomeTPArmas.Name = "tboxNomeTPArmas";
            this.tboxNomeTPArmas.Size = new System.Drawing.Size(279, 26);
            this.tboxNomeTPArmas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da arma: ";
            // 
            // tboxCodTPArmas
            // 
            this.tboxCodTPArmas.Location = new System.Drawing.Point(104, 33);
            this.tboxCodTPArmas.Name = "tboxCodTPArmas";
            this.tboxCodTPArmas.Size = new System.Drawing.Size(118, 26);
            this.tboxCodTPArmas.TabIndex = 1;
            this.tboxCodTPArmas.Leave += new System.EventHandler(this.tboxCodTPArmas_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código: ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(524, 450);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(140, 35);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseCompatibleTextRendering = true;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(391, 450);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(135, 35);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(264, 450);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 35);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(134, 450);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(131, 35);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(9, 450);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(126, 35);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sGJPTPARMACODDataGridViewTextBoxColumn,
            this.sGJPTPARMANOMEDataGridViewTextBoxColumn,
            this.sGJPTPARMADESCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sGJPTPARMABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(655, 157);
            this.dataGridView1.TabIndex = 25;
            // 
            // sGJPTPARMACODDataGridViewTextBoxColumn
            // 
            this.sGJPTPARMACODDataGridViewTextBoxColumn.DataPropertyName = "SGJP_TPARMACOD";
            this.sGJPTPARMACODDataGridViewTextBoxColumn.HeaderText = "Codigo do tipo de Arma";
            this.sGJPTPARMACODDataGridViewTextBoxColumn.Name = "sGJPTPARMACODDataGridViewTextBoxColumn";
            this.sGJPTPARMACODDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGJPTPARMACODDataGridViewTextBoxColumn.Width = 145;
            // 
            // sGJPTPARMANOMEDataGridViewTextBoxColumn
            // 
            this.sGJPTPARMANOMEDataGridViewTextBoxColumn.DataPropertyName = "SGJP_TPARMANOME";
            this.sGJPTPARMANOMEDataGridViewTextBoxColumn.HeaderText = "Nome do tipo de Arma";
            this.sGJPTPARMANOMEDataGridViewTextBoxColumn.Name = "sGJPTPARMANOMEDataGridViewTextBoxColumn";
            this.sGJPTPARMANOMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGJPTPARMANOMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // sGJPTPARMADESCDataGridViewTextBoxColumn
            // 
            this.sGJPTPARMADESCDataGridViewTextBoxColumn.DataPropertyName = "SGJP_TPARMADESC";
            this.sGJPTPARMADESCDataGridViewTextBoxColumn.HeaderText = "Descrição dos tipos de arma";
            this.sGJPTPARMADESCDataGridViewTextBoxColumn.Name = "sGJPTPARMADESCDataGridViewTextBoxColumn";
            this.sGJPTPARMADESCDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGJPTPARMADESCDataGridViewTextBoxColumn.Width = 320;
            // 
            // sGJPTPARMABindingSource
            // 
            this.sGJPTPARMABindingSource.DataMember = "SGJP_TPARMA";
            this.sGJPTPARMABindingSource.DataSource = this.sGJPDataSet1;
            // 
            // sGJPDataSet1
            // 
            this.sGJPDataSet1.DataSetName = "SGJPDataSet1";
            this.sGJPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sGJP_TPARMATableAdapter
            // 
            this.sGJP_TPARMATableAdapter.ClearBeforeFill = true;
            // 
            // CadTipoArma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadTipoArma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar o tipo de arma";
            this.Load += new System.EventHandler(this.CadTipoArma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGJPTPARMABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGJPDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxDescTPArmas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxNomeTPArmas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxCodTPArmas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SGJPDataSet1 sGJPDataSet1;
        private System.Windows.Forms.BindingSource sGJPTPARMABindingSource;
        private SGJPDataSet1TableAdapters.SGJP_TPARMATableAdapter sGJP_TPARMATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGJPTPARMACODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGJPTPARMANOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGJPTPARMADESCDataGridViewTextBoxColumn;
    }
}
namespace ProjetoPaintball
{
    partial class CadCargoFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCargoFunc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxDescCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxNomeCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxCodCargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridCargoFunc = new System.Windows.Forms.DataGridView();
            this.sGJPCARGOFUNCCODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGJPCARGOFUNCDESCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGJPCARGOFUNCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGJPDataSet = new ProjetoPaintball.SGJPDataSet();
            this.sGJP_CARGOFUNCTableAdapter = new ProjetoPaintball.SGJPDataSetTableAdapters.SGJP_CARGOFUNCTableAdapter();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCargoFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGJPCARGOFUNCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGJPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxDescCargo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tboxNomeCargo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxCodCargo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargos";
            // 
            // tboxDescCargo
            // 
            this.tboxDescCargo.Location = new System.Drawing.Point(16, 102);
            this.tboxDescCargo.MaxLength = 350;
            this.tboxDescCargo.Multiline = true;
            this.tboxDescCargo.Name = "tboxDescCargo";
            this.tboxDescCargo.Size = new System.Drawing.Size(640, 136);
            this.tboxDescCargo.TabIndex = 5;
            this.tboxDescCargo.Enter += new System.EventHandler(this.tboxDescCargo_Enter);
            this.tboxDescCargo.Leave += new System.EventHandler(this.tboxDescCargo_Leave);
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
            // tboxNomeCargo
            // 
            this.tboxNomeCargo.Location = new System.Drawing.Point(377, 36);
            this.tboxNomeCargo.Name = "tboxNomeCargo";
            this.tboxNomeCargo.Size = new System.Drawing.Size(279, 26);
            this.tboxNomeCargo.TabIndex = 3;
            this.tboxNomeCargo.Enter += new System.EventHandler(this.tboxNomeCargo_Enter);
            this.tboxNomeCargo.Leave += new System.EventHandler(this.tboxNomeCargo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do cargo: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tboxCodCargo
            // 
            this.tboxCodCargo.Location = new System.Drawing.Point(104, 33);
            this.tboxCodCargo.Name = "tboxCodCargo";
            this.tboxCodCargo.Size = new System.Drawing.Size(118, 26);
            this.tboxCodCargo.TabIndex = 1;
            this.tboxCodCargo.Enter += new System.EventHandler(this.tboxCodCargo_Enter);
            this.tboxCodCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCodCargo_KeyPress);
            this.tboxCodCargo.Leave += new System.EventHandler(this.tboxCodCargo_Leave);
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
            // dtGridCargoFunc
            // 
            this.dtGridCargoFunc.AllowUserToAddRows = false;
            this.dtGridCargoFunc.AllowUserToDeleteRows = false;
            this.dtGridCargoFunc.AutoGenerateColumns = false;
            this.dtGridCargoFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCargoFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sGJPCARGOFUNCCODDataGridViewTextBoxColumn,
            this.sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn,
            this.sGJPCARGOFUNCDESCDataGridViewTextBoxColumn});
            this.dtGridCargoFunc.DataSource = this.sGJPCARGOFUNCBindingSource;
            this.dtGridCargoFunc.Location = new System.Drawing.Point(12, 280);
            this.dtGridCargoFunc.Name = "dtGridCargoFunc";
            this.dtGridCargoFunc.ReadOnly = true;
            this.dtGridCargoFunc.Size = new System.Drawing.Size(668, 149);
            this.dtGridCargoFunc.TabIndex = 0;
            this.dtGridCargoFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCargoFunc_CellContentClick);
            // 
            // sGJPCARGOFUNCCODDataGridViewTextBoxColumn
            // 
            this.sGJPCARGOFUNCCODDataGridViewTextBoxColumn.DataPropertyName = "SGJP_CARGOFUNCCOD";
            this.sGJPCARGOFUNCCODDataGridViewTextBoxColumn.HeaderText = "CÓDIGO DO CARGO";
            this.sGJPCARGOFUNCCODDataGridViewTextBoxColumn.MaxInputLength = 16;
            this.sGJPCARGOFUNCCODDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.sGJPCARGOFUNCCODDataGridViewTextBoxColumn.Name = "sGJPCARGOFUNCCODDataGridViewTextBoxColumn";
            this.sGJPCARGOFUNCCODDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGJPCARGOFUNCCODDataGridViewTextBoxColumn.Width = 132;
            // 
            // sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn
            // 
            this.sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn.DataPropertyName = "SGJP_CARGOFUNCNOME";
            this.sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn.HeaderText = "NOME DO CARGO";
            this.sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn.MaxInputLength = 35;
            this.sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn.Name = "sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn";
            this.sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sGJPCARGOFUNCDESCDataGridViewTextBoxColumn
            // 
            this.sGJPCARGOFUNCDESCDataGridViewTextBoxColumn.DataPropertyName = "SGJP_CARGOFUNCDESC";
            this.sGJPCARGOFUNCDESCDataGridViewTextBoxColumn.HeaderText = "DESCRIÇÃO DO CARGO";
            this.sGJPCARGOFUNCDESCDataGridViewTextBoxColumn.MaxInputLength = 300;
            this.sGJPCARGOFUNCDESCDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.sGJPCARGOFUNCDESCDataGridViewTextBoxColumn.Name = "sGJPCARGOFUNCDESCDataGridViewTextBoxColumn";
            this.sGJPCARGOFUNCDESCDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGJPCARGOFUNCDESCDataGridViewTextBoxColumn.Width = 300;
            // 
            // sGJPCARGOFUNCBindingSource
            // 
            this.sGJPCARGOFUNCBindingSource.DataMember = "SGJP_CARGOFUNC";
            this.sGJPCARGOFUNCBindingSource.DataSource = this.sGJPDataSet;
            // 
            // sGJPDataSet
            // 
            this.sGJPDataSet.DataSetName = "SGJPDataSet";
            this.sGJPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sGJP_CARGOFUNCTableAdapter
            // 
            this.sGJP_CARGOFUNCTableAdapter.ClearBeforeFill = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(531, 464);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 35);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseCompatibleTextRendering = true;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(413, 464);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 35);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(294, 464);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 35);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(175, 464);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(120, 35);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(51, 464);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 35);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CadCargoFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 509);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtGridCargoFunc);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadCargoFunc";
            this.Text = "Cadastro de cargo de funcionário";
            this.Load += new System.EventHandler(this.CadCargoFunc_Load);
            this.Enter += new System.EventHandler(this.CadCargoFunc_Enter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCargoFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGJPCARGOFUNCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGJPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxCodCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxNomeCargo;
        private System.Windows.Forms.TextBox tboxDescCargo;
        private SGJPDataSet sGJPDataSet;
        private System.Windows.Forms.BindingSource sGJPCARGOFUNCBindingSource;
        private SGJPDataSetTableAdapters.SGJP_CARGOFUNCTableAdapter sGJP_CARGOFUNCTableAdapter;
        private System.Windows.Forms.DataGridView dtGridCargoFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGJPCARGOFUNCCODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGJPCARGOFUNCNOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGJPCARGOFUNCDESCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}
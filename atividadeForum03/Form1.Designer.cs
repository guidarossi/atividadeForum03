namespace atividadeForum03
{
    partial class Inicial
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtEspecificacoes = new System.Windows.Forms.TextBox();
            this.lblEspecificacoes = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspecificacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(425, 27);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 91);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(12, 43);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(100, 20);
            this.txtFabricante.TabIndex = 2;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(235, 43);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 3;
            // 
            // txtEspecificacoes
            // 
            this.txtEspecificacoes.Location = new System.Drawing.Point(12, 98);
            this.txtEspecificacoes.Name = "txtEspecificacoes";
            this.txtEspecificacoes.Size = new System.Drawing.Size(323, 20);
            this.txtEspecificacoes.TabIndex = 4;
            // 
            // lblEspecificacoes
            // 
            this.lblEspecificacoes.AutoSize = true;
            this.lblEspecificacoes.Location = new System.Drawing.Point(9, 82);
            this.lblEspecificacoes.Name = "lblEspecificacoes";
            this.lblEspecificacoes.Size = new System.Drawing.Size(82, 13);
            this.lblEspecificacoes.TabIndex = 6;
            this.lblEspecificacoes.Text = "Especificações:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(232, 27);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(89, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data da locação:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(9, 27);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(60, 13);
            this.lblFabricante.TabIndex = 8;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnFabricante,
            this.ColumnData,
            this.ColumnEspecificacoes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 239);
            this.dataGridView1.TabIndex = 9;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnFabricante
            // 
            this.ColumnFabricante.HeaderText = "Fabricante";
            this.ColumnFabricante.Name = "ColumnFabricante";
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data da Locação";
            this.ColumnData.Name = "ColumnData";
            // 
            // ColumnEspecificacoes
            // 
            this.ColumnEspecificacoes.HeaderText = "Especificações";
            this.ColumnEspecificacoes.Name = "ColumnEspecificacoes";
            this.ColumnEspecificacoes.Width = 150;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEspecificacoes);
            this.Controls.Add(this.txtEspecificacoes);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Inicial";
            this.Text = "Locação de Veiculos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtEspecificacoes;
        private System.Windows.Forms.Label lblEspecificacoes;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEspecificacoes;
    }
}


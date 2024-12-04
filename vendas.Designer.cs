namespace ProjetoEstoque
{
    partial class fmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmVendas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltarVendas = new System.Windows.Forms.Button();
            this.dgdTabelaVendas = new System.Windows.Forms.DataGridView();
            this.gpDeletarVenda = new System.Windows.Forms.GroupBox();
            this.lblDigiteIDEstoque = new System.Windows.Forms.Label();
            this.txtID_Estoque = new System.Windows.Forms.TextBox();
            this.txtID_vendaeletar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletarVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTabelaVendas)).BeginInit();
            this.gpDeletarVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltarVendas
            // 
            this.btnVoltarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarVendas.Image")));
            this.btnVoltarVendas.Location = new System.Drawing.Point(15, 9);
            this.btnVoltarVendas.Name = "btnVoltarVendas";
            this.btnVoltarVendas.Size = new System.Drawing.Size(95, 38);
            this.btnVoltarVendas.TabIndex = 15;
            this.btnVoltarVendas.UseVisualStyleBackColor = true;
            this.btnVoltarVendas.Click += new System.EventHandler(this.btnVoltarVendas_Click);
            // 
            // dgdTabelaVendas
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdTabelaVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgdTabelaVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdTabelaVendas.Location = new System.Drawing.Point(151, 91);
            this.dgdTabelaVendas.Name = "dgdTabelaVendas";
            this.dgdTabelaVendas.Size = new System.Drawing.Size(621, 185);
            this.dgdTabelaVendas.TabIndex = 17;
            this.dgdTabelaVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdTabelaVendas_CellContentClick);
            // 
            // gpDeletarVenda
            // 
            this.gpDeletarVenda.Controls.Add(this.lblDigiteIDEstoque);
            this.gpDeletarVenda.Controls.Add(this.txtID_Estoque);
            this.gpDeletarVenda.Controls.Add(this.txtID_vendaeletar);
            this.gpDeletarVenda.Controls.Add(this.label1);
            this.gpDeletarVenda.Controls.Add(this.btnDeletarVenda);
            this.gpDeletarVenda.Location = new System.Drawing.Point(3, 107);
            this.gpDeletarVenda.Name = "gpDeletarVenda";
            this.gpDeletarVenda.Size = new System.Drawing.Size(125, 186);
            this.gpDeletarVenda.TabIndex = 18;
            this.gpDeletarVenda.TabStop = false;
            this.gpDeletarVenda.Text = "Deletar uma Venda";
            // 
            // lblDigiteIDEstoque
            // 
            this.lblDigiteIDEstoque.AutoSize = true;
            this.lblDigiteIDEstoque.Location = new System.Drawing.Point(10, 84);
            this.lblDigiteIDEstoque.Name = "lblDigiteIDEstoque";
            this.lblDigiteIDEstoque.Size = new System.Drawing.Size(104, 13);
            this.lblDigiteIDEstoque.TabIndex = 4;
            this.lblDigiteIDEstoque.Text = "Digite ID do estoque";
            // 
            // txtID_Estoque
            // 
            this.txtID_Estoque.Location = new System.Drawing.Point(9, 103);
            this.txtID_Estoque.Name = "txtID_Estoque";
            this.txtID_Estoque.Size = new System.Drawing.Size(100, 20);
            this.txtID_Estoque.TabIndex = 3;
            // 
            // txtID_vendaeletar
            // 
            this.txtID_vendaeletar.Location = new System.Drawing.Point(9, 59);
            this.txtID_vendaeletar.Name = "txtID_vendaeletar";
            this.txtID_vendaeletar.Size = new System.Drawing.Size(100, 20);
            this.txtID_vendaeletar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o ID da venda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDeletarVenda
            // 
            this.btnDeletarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarVenda.Image")));
            this.btnDeletarVenda.Location = new System.Drawing.Point(22, 135);
            this.btnDeletarVenda.Name = "btnDeletarVenda";
            this.btnDeletarVenda.Size = new System.Drawing.Size(67, 31);
            this.btnDeletarVenda.TabIndex = 0;
            this.btnDeletarVenda.UseVisualStyleBackColor = true;
            this.btnDeletarVenda.Click += new System.EventHandler(this.btnDeletarVenda_Click);
            // 
            // fmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 407);
            this.Controls.Add(this.gpDeletarVenda);
            this.Controls.Add(this.dgdTabelaVendas);
            this.Controls.Add(this.btnVoltarVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmVendas";
            this.Text = "Visualizar Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmVendas_FormClosing);
            this.Load += new System.EventHandler(this.vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdTabelaVendas)).EndInit();
            this.gpDeletarVenda.ResumeLayout(false);
            this.gpDeletarVenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltarVendas;
        private System.Windows.Forms.DataGridView dgdTabelaVendas;
        private System.Windows.Forms.GroupBox gpDeletarVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeletarVenda;
        private System.Windows.Forms.TextBox txtID_vendaeletar;
        private System.Windows.Forms.Label lblDigiteIDEstoque;
        private System.Windows.Forms.TextBox txtID_Estoque;
    }
}
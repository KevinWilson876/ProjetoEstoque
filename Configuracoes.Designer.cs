namespace ProjetoEstoque
{
    partial class fmConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmConfiguracoes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cobSelecionarCarne = new System.Windows.Forms.ComboBox();
            this.lblSelecioneCarne = new System.Windows.Forms.Label();
            this.lblIdEstoqueDefinir = new System.Windows.Forms.Label();
            this.btnDefinirEstoqueUso = new System.Windows.Forms.Button();
            this.gpDefinirEstoque = new System.Windows.Forms.GroupBox();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.cobId_estoque = new System.Windows.Forms.ComboBox();
            this.btnVoltarConfig = new System.Windows.Forms.Button();
            this.dgdTabelaEstoqueAtual = new System.Windows.Forms.DataGridView();
            this.lblEstoqueDefinido = new System.Windows.Forms.Label();
            this.gpLimiteEstoque = new System.Windows.Forms.GroupBox();
            this.btnDefinirLimeteEstoque = new System.Windows.Forms.Button();
            this.lblLimiteAtuallabel = new System.Windows.Forms.Label();
            this.lblLimiteAtual = new System.Windows.Forms.Label();
            this.lblDefinirLimite = new System.Windows.Forms.Label();
            this.txtDefinirNovoLimite = new System.Windows.Forms.TextBox();
            this.gpDefinirEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTabelaEstoqueAtual)).BeginInit();
            this.gpLimiteEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // cobSelecionarCarne
            // 
            this.cobSelecionarCarne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobSelecionarCarne.FormattingEnabled = true;
            this.cobSelecionarCarne.Location = new System.Drawing.Point(126, 33);
            this.cobSelecionarCarne.Name = "cobSelecionarCarne";
            this.cobSelecionarCarne.Size = new System.Drawing.Size(121, 21);
            this.cobSelecionarCarne.TabIndex = 1;
            this.cobSelecionarCarne.SelectedIndexChanged += new System.EventHandler(this.cobSelecionarCarne_SelectedIndexChanged);
            // 
            // lblSelecioneCarne
            // 
            this.lblSelecioneCarne.AutoSize = true;
            this.lblSelecioneCarne.Location = new System.Drawing.Point(6, 36);
            this.lblSelecioneCarne.Name = "lblSelecioneCarne";
            this.lblSelecioneCarne.Size = new System.Drawing.Size(96, 13);
            this.lblSelecioneCarne.TabIndex = 2;
            this.lblSelecioneCarne.Text = "Selecione a carne:";
            // 
            // lblIdEstoqueDefinir
            // 
            this.lblIdEstoqueDefinir.AutoSize = true;
            this.lblIdEstoqueDefinir.Location = new System.Drawing.Point(5, 66);
            this.lblIdEstoqueDefinir.Name = "lblIdEstoqueDefinir";
            this.lblIdEstoqueDefinir.Size = new System.Drawing.Size(123, 13);
            this.lblIdEstoqueDefinir.TabIndex = 3;
            this.lblIdEstoqueDefinir.Text = "Id_Estoque(Nota Fiscal):";
            // 
            // btnDefinirEstoqueUso
            // 
            this.btnDefinirEstoqueUso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefinirEstoqueUso.Image = ((System.Drawing.Image)(resources.GetObject("btnDefinirEstoqueUso.Image")));
            this.btnDefinirEstoqueUso.Location = new System.Drawing.Point(156, 107);
            this.btnDefinirEstoqueUso.Name = "btnDefinirEstoqueUso";
            this.btnDefinirEstoqueUso.Size = new System.Drawing.Size(67, 31);
            this.btnDefinirEstoqueUso.TabIndex = 4;
            this.btnDefinirEstoqueUso.UseVisualStyleBackColor = true;
            this.btnDefinirEstoqueUso.Click += new System.EventHandler(this.btnDefinirEstoqueUso_Click);
            // 
            // gpDefinirEstoque
            // 
            this.gpDefinirEstoque.Controls.Add(this.btnLimparCampos);
            this.gpDefinirEstoque.Controls.Add(this.cobId_estoque);
            this.gpDefinirEstoque.Controls.Add(this.lblSelecioneCarne);
            this.gpDefinirEstoque.Controls.Add(this.btnDefinirEstoqueUso);
            this.gpDefinirEstoque.Controls.Add(this.lblIdEstoqueDefinir);
            this.gpDefinirEstoque.Controls.Add(this.cobSelecionarCarne);
            this.gpDefinirEstoque.Location = new System.Drawing.Point(12, 59);
            this.gpDefinirEstoque.Name = "gpDefinirEstoque";
            this.gpDefinirEstoque.Size = new System.Drawing.Size(267, 155);
            this.gpDefinirEstoque.TabIndex = 5;
            this.gpDefinirEstoque.TabStop = false;
            this.gpDefinirEstoque.Text = "Definicao do estoque em Uso";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCampos.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCampos.Image")));
            this.btnLimparCampos.Location = new System.Drawing.Point(27, 107);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(123, 31);
            this.btnLimparCampos.TabIndex = 6;
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // cobId_estoque
            // 
            this.cobId_estoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobId_estoque.FormattingEnabled = true;
            this.cobId_estoque.Location = new System.Drawing.Point(126, 62);
            this.cobId_estoque.Name = "cobId_estoque";
            this.cobId_estoque.Size = new System.Drawing.Size(121, 21);
            this.cobId_estoque.TabIndex = 5;
            this.cobId_estoque.SelectedIndexChanged += new System.EventHandler(this.cobId_estoque_SelectedIndexChanged);
            // 
            // btnVoltarConfig
            // 
            this.btnVoltarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarConfig.Image")));
            this.btnVoltarConfig.Location = new System.Drawing.Point(15, 9);
            this.btnVoltarConfig.Name = "btnVoltarConfig";
            this.btnVoltarConfig.Size = new System.Drawing.Size(95, 38);
            this.btnVoltarConfig.TabIndex = 6;
            this.btnVoltarConfig.UseVisualStyleBackColor = true;
            this.btnVoltarConfig.Click += new System.EventHandler(this.btnVoltarConfig_Click);
            // 
            // dgdTabelaEstoqueAtual
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdTabelaEstoqueAtual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdTabelaEstoqueAtual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdTabelaEstoqueAtual.Location = new System.Drawing.Point(371, 72);
            this.dgdTabelaEstoqueAtual.Name = "dgdTabelaEstoqueAtual";
            this.dgdTabelaEstoqueAtual.Size = new System.Drawing.Size(325, 185);
            this.dgdTabelaEstoqueAtual.TabIndex = 8;
            // 
            // lblEstoqueDefinido
            // 
            this.lblEstoqueDefinido.AutoSize = true;
            this.lblEstoqueDefinido.Location = new System.Drawing.Point(467, 39);
            this.lblEstoqueDefinido.Name = "lblEstoqueDefinido";
            this.lblEstoqueDefinido.Size = new System.Drawing.Size(127, 13);
            this.lblEstoqueDefinido.TabIndex = 9;
            this.lblEstoqueDefinido.Text = "Configuração do Estoque";
            // 
            // gpLimiteEstoque
            // 
            this.gpLimiteEstoque.Controls.Add(this.btnDefinirLimeteEstoque);
            this.gpLimiteEstoque.Controls.Add(this.lblLimiteAtuallabel);
            this.gpLimiteEstoque.Controls.Add(this.lblLimiteAtual);
            this.gpLimiteEstoque.Controls.Add(this.lblDefinirLimite);
            this.gpLimiteEstoque.Controls.Add(this.txtDefinirNovoLimite);
            this.gpLimiteEstoque.Location = new System.Drawing.Point(39, 238);
            this.gpLimiteEstoque.Name = "gpLimiteEstoque";
            this.gpLimiteEstoque.Size = new System.Drawing.Size(240, 116);
            this.gpLimiteEstoque.TabIndex = 10;
            this.gpLimiteEstoque.TabStop = false;
            this.gpLimiteEstoque.Text = "Definir Limite de Estoque para Notificação";
            // 
            // btnDefinirLimeteEstoque
            // 
            this.btnDefinirLimeteEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefinirLimeteEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnDefinirLimeteEstoque.Image")));
            this.btnDefinirLimeteEstoque.Location = new System.Drawing.Point(101, 84);
            this.btnDefinirLimeteEstoque.Name = "btnDefinirLimeteEstoque";
            this.btnDefinirLimeteEstoque.Size = new System.Drawing.Size(67, 31);
            this.btnDefinirLimeteEstoque.TabIndex = 4;
            this.btnDefinirLimeteEstoque.UseVisualStyleBackColor = true;
            this.btnDefinirLimeteEstoque.Click += new System.EventHandler(this.btnDefinirLimeteEstoque_Click);
            // 
            // lblLimiteAtuallabel
            // 
            this.lblLimiteAtuallabel.AutoSize = true;
            this.lblLimiteAtuallabel.Location = new System.Drawing.Point(90, 31);
            this.lblLimiteAtuallabel.Name = "lblLimiteAtuallabel";
            this.lblLimiteAtuallabel.Size = new System.Drawing.Size(0, 13);
            this.lblLimiteAtuallabel.TabIndex = 3;
            this.lblLimiteAtuallabel.Visible = false;
            // 
            // lblLimiteAtual
            // 
            this.lblLimiteAtual.AutoSize = true;
            this.lblLimiteAtual.Location = new System.Drawing.Point(12, 31);
            this.lblLimiteAtual.Name = "lblLimiteAtual";
            this.lblLimiteAtual.Size = new System.Drawing.Size(63, 13);
            this.lblLimiteAtual.TabIndex = 2;
            this.lblLimiteAtual.Text = "Limite atual:";
            // 
            // lblDefinirLimite
            // 
            this.lblDefinirLimite.AutoSize = true;
            this.lblDefinirLimite.Location = new System.Drawing.Point(13, 59);
            this.lblDefinirLimite.Name = "lblDefinirLimite";
            this.lblDefinirLimite.Size = new System.Drawing.Size(70, 13);
            this.lblDefinirLimite.TabIndex = 1;
            this.lblDefinirLimite.Text = "Definir Limite:";
            // 
            // txtDefinirNovoLimite
            // 
            this.txtDefinirNovoLimite.Location = new System.Drawing.Point(90, 58);
            this.txtDefinirNovoLimite.Name = "txtDefinirNovoLimite";
            this.txtDefinirNovoLimite.Size = new System.Drawing.Size(100, 20);
            this.txtDefinirNovoLimite.TabIndex = 0;
            // 
            // fmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 407);
            this.Controls.Add(this.gpLimiteEstoque);
            this.Controls.Add(this.lblEstoqueDefinido);
            this.Controls.Add(this.dgdTabelaEstoqueAtual);
            this.Controls.Add(this.btnVoltarConfig);
            this.Controls.Add(this.gpDefinirEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmConfiguracoes";
            this.Text = "Configuraçôes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmConfiguracoes_FormClosing);
            this.Load += new System.EventHandler(this.fmConfiguracoes_Load);
            this.gpDefinirEstoque.ResumeLayout(false);
            this.gpDefinirEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTabelaEstoqueAtual)).EndInit();
            this.gpLimiteEstoque.ResumeLayout(false);
            this.gpLimiteEstoque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cobSelecionarCarne;
        private System.Windows.Forms.Label lblSelecioneCarne;
        private System.Windows.Forms.Label lblIdEstoqueDefinir;
        private System.Windows.Forms.Button btnDefinirEstoqueUso;
        private System.Windows.Forms.GroupBox gpDefinirEstoque;
        private System.Windows.Forms.Button btnVoltarConfig;
        private System.Windows.Forms.DataGridView dgdTabelaEstoqueAtual;
        private System.Windows.Forms.Label lblEstoqueDefinido;
        private System.Windows.Forms.ComboBox cobId_estoque;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.GroupBox gpLimiteEstoque;
        private System.Windows.Forms.Label lblDefinirLimite;
        private System.Windows.Forms.TextBox txtDefinirNovoLimite;
        private System.Windows.Forms.Button btnDefinirLimeteEstoque;
        private System.Windows.Forms.Label lblLimiteAtuallabel;
        private System.Windows.Forms.Label lblLimiteAtual;
    }
}
namespace ProjetoEstoque
{
    partial class fmvisaoGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmvisaoGeral));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgdTabela = new System.Windows.Forms.DataGridView();
            this.btnTesteConexao = new System.Windows.Forms.Button();
            this.gpBotoesAdicionar = new System.Windows.Forms.GroupBox();
            this.btnVisualizarVendas = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.bntAtualizarCarne = new System.Windows.Forms.Button();
            this.gpCarneEstoque = new System.Windows.Forms.GroupBox();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCarne = new System.Windows.Forms.Button();
            this.gpAdicionarCarne = new System.Windows.Forms.GroupBox();
            this.lblCodigoCarne = new System.Windows.Forms.Label();
            this.txtCodigoCarne = new System.Windows.Forms.TextBox();
            this.btnAdicionarCarne = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtTipoPeca = new System.Windows.Forms.TextBox();
            this.txtNomePeca = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblTipoPeca = new System.Windows.Forms.Label();
            this.lblNomePeca = new System.Windows.Forms.Label();
            this.btnVoltarAdicionarCarne = new System.Windows.Forms.Button();
            this.gpEstoque = new System.Windows.Forms.GroupBox();
            this.cboCarnesEstoque = new System.Windows.Forms.ComboBox();
            this.lblCarne = new System.Windows.Forms.Label();
            this.btnAdicionarEstoque = new System.Windows.Forms.Button();
            this.txtDatavalidadeEstoque = new System.Windows.Forms.TextBox();
            this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.txtId_estoque = new System.Windows.Forms.TextBox();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblID_estoque = new System.Windows.Forms.Label();
            this.btnVoltarEstoque = new System.Windows.Forms.Button();
            this.gpDeletarCarne = new System.Windows.Forms.GroupBox();
            this.cobSelecaoApagar = new System.Windows.Forms.ComboBox();
            this.lblSelecionarCarne = new System.Windows.Forms.Label();
            this.bntApagarRegistro = new System.Windows.Forms.Button();
            this.btnVoltarDeleteCarne = new System.Windows.Forms.Button();
            this.gpDeletarCarneEstoque = new System.Windows.Forms.GroupBox();
            this.btnDeletarEstoque = new System.Windows.Forms.Button();
            this.btnDeletarCarne = new System.Windows.Forms.Button();
            this.gpDeletarEstoque = new System.Windows.Forms.GroupBox();
            this.txtID_estoqueDeletar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApagarRegistroEstoque = new System.Windows.Forms.Button();
            this.btnVoltarDeletarEstoque = new System.Windows.Forms.Button();
            this.gpAtualizarCarne = new System.Windows.Forms.GroupBox();
            this.btnLimparCampus = new System.Windows.Forms.Button();
            this.txtprecoAtualizado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoltarAtualizarCarne = new System.Windows.Forms.Button();
            this.btnConsultarCarne = new System.Windows.Forms.Button();
            this.btnAtualizarPreco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodigoCarneAtualizar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTipoCarne = new System.Windows.Forms.Label();
            this.lblNomeCarne = new System.Windows.Forms.Label();
            this.txtId_codigoCArneAtualizar = new System.Windows.Forms.TextBox();
            this.lblprecoCarneAntigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTabela)).BeginInit();
            this.gpBotoesAdicionar.SuspendLayout();
            this.gpCarneEstoque.SuspendLayout();
            this.gpAdicionarCarne.SuspendLayout();
            this.gpEstoque.SuspendLayout();
            this.gpDeletarCarne.SuspendLayout();
            this.gpDeletarCarneEstoque.SuspendLayout();
            this.gpDeletarEstoque.SuspendLayout();
            this.gpAtualizarCarne.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(15, 9);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 38);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarregar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRecarregar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecarregar.Image")));
            this.btnRecarregar.Location = new System.Drawing.Point(28, 336);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(63, 57);
            this.btnRecarregar.TabIndex = 1;
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(6, 84);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 64);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(27, 455);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(63, 57);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(28, 396);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(63, 57);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgdTabela
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdTabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgdTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdTabela.Location = new System.Drawing.Point(139, 129);
            this.dgdTabela.Name = "dgdTabela";
            this.dgdTabela.Size = new System.Drawing.Size(633, 185);
            this.dgdTabela.TabIndex = 7;
            this.dgdTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdTabela_CellContentClick);
            // 
            // btnTesteConexao
            // 
            this.btnTesteConexao.Location = new System.Drawing.Point(650, 442);
            this.btnTesteConexao.Name = "btnTesteConexao";
            this.btnTesteConexao.Size = new System.Drawing.Size(113, 23);
            this.btnTesteConexao.TabIndex = 8;
            this.btnTesteConexao.Text = "teste Conexao";
            this.btnTesteConexao.UseVisualStyleBackColor = true;
            this.btnTesteConexao.Visible = false;
            this.btnTesteConexao.Click += new System.EventHandler(this.btnTesteConexao_Click);
            // 
            // gpBotoesAdicionar
            // 
            this.gpBotoesAdicionar.Controls.Add(this.btnVisualizarVendas);
            this.gpBotoesAdicionar.Controls.Add(this.txtPesquisar);
            this.gpBotoesAdicionar.Controls.Add(this.bntAtualizarCarne);
            this.gpBotoesAdicionar.Controls.Add(this.btnDeletar);
            this.gpBotoesAdicionar.Controls.Add(this.btnRecarregar);
            this.gpBotoesAdicionar.Controls.Add(this.btnVoltar);
            this.gpBotoesAdicionar.Controls.Add(this.btnPesquisar);
            this.gpBotoesAdicionar.Controls.Add(this.btnAdicionar);
            this.gpBotoesAdicionar.Location = new System.Drawing.Point(11, 0);
            this.gpBotoesAdicionar.Name = "gpBotoesAdicionar";
            this.gpBotoesAdicionar.Size = new System.Drawing.Size(120, 523);
            this.gpBotoesAdicionar.TabIndex = 9;
            this.gpBotoesAdicionar.TabStop = false;
            // 
            // btnVisualizarVendas
            // 
            this.btnVisualizarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarVendas.Image")));
            this.btnVisualizarVendas.Location = new System.Drawing.Point(6, 255);
            this.btnVisualizarVendas.Name = "btnVisualizarVendas";
            this.btnVisualizarVendas.Size = new System.Drawing.Size(104, 64);
            this.btnVisualizarVendas.TabIndex = 16;
            this.btnVisualizarVendas.UseVisualStyleBackColor = true;
            this.btnVisualizarVendas.Click += new System.EventHandler(this.btnVisualizarVendas_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(17, 152);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(81, 20);
            this.txtPesquisar.TabIndex = 15;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // bntAtualizarCarne
            // 
            this.bntAtualizarCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAtualizarCarne.Image = ((System.Drawing.Image)(resources.GetObject("bntAtualizarCarne.Image")));
            this.bntAtualizarCarne.Location = new System.Drawing.Point(6, 194);
            this.bntAtualizarCarne.Name = "bntAtualizarCarne";
            this.bntAtualizarCarne.Size = new System.Drawing.Size(104, 64);
            this.bntAtualizarCarne.TabIndex = 2;
            this.bntAtualizarCarne.UseVisualStyleBackColor = true;
            this.bntAtualizarCarne.Click += new System.EventHandler(this.bntAtualizarCarne_Click);
            // 
            // gpCarneEstoque
            // 
            this.gpCarneEstoque.Controls.Add(this.btnEstoque);
            this.gpCarneEstoque.Controls.Add(this.btnCarne);
            this.gpCarneEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpCarneEstoque.Location = new System.Drawing.Point(137, 324);
            this.gpCarneEstoque.Name = "gpCarneEstoque";
            this.gpCarneEstoque.Size = new System.Drawing.Size(94, 95);
            this.gpCarneEstoque.TabIndex = 10;
            this.gpCarneEstoque.TabStop = false;
            this.gpCarneEstoque.Text = "Adicionar";
            this.gpCarneEstoque.Visible = false;
            // 
            // btnEstoque
            // 
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.Location = new System.Drawing.Point(13, 55);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(67, 31);
            this.btnEstoque.TabIndex = 1;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnCarne
            // 
            this.btnCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarne.Image = ((System.Drawing.Image)(resources.GetObject("btnCarne.Image")));
            this.btnCarne.Location = new System.Drawing.Point(13, 18);
            this.btnCarne.Name = "btnCarne";
            this.btnCarne.Size = new System.Drawing.Size(67, 31);
            this.btnCarne.TabIndex = 0;
            this.btnCarne.UseVisualStyleBackColor = true;
            this.btnCarne.Click += new System.EventHandler(this.btnCarne_Click);
            // 
            // gpAdicionarCarne
            // 
            this.gpAdicionarCarne.Controls.Add(this.lblCodigoCarne);
            this.gpAdicionarCarne.Controls.Add(this.txtCodigoCarne);
            this.gpAdicionarCarne.Controls.Add(this.btnAdicionarCarne);
            this.gpAdicionarCarne.Controls.Add(this.txtPreco);
            this.gpAdicionarCarne.Controls.Add(this.txtTipoPeca);
            this.gpAdicionarCarne.Controls.Add(this.txtNomePeca);
            this.gpAdicionarCarne.Controls.Add(this.lblPreco);
            this.gpAdicionarCarne.Controls.Add(this.lblTipoPeca);
            this.gpAdicionarCarne.Controls.Add(this.lblNomePeca);
            this.gpAdicionarCarne.Controls.Add(this.btnVoltarAdicionarCarne);
            this.gpAdicionarCarne.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpAdicionarCarne.Location = new System.Drawing.Point(211, 53);
            this.gpAdicionarCarne.Name = "gpAdicionarCarne";
            this.gpAdicionarCarne.Size = new System.Drawing.Size(364, 252);
            this.gpAdicionarCarne.TabIndex = 11;
            this.gpAdicionarCarne.TabStop = false;
            this.gpAdicionarCarne.Text = "Adicionar Carne";
            this.gpAdicionarCarne.Visible = false;
            // 
            // lblCodigoCarne
            // 
            this.lblCodigoCarne.AutoSize = true;
            this.lblCodigoCarne.Location = new System.Drawing.Point(65, 45);
            this.lblCodigoCarne.Name = "lblCodigoCarne";
            this.lblCodigoCarne.Size = new System.Drawing.Size(89, 13);
            this.lblCodigoCarne.TabIndex = 14;
            this.lblCodigoCarne.Text = "Codigo da Carne:";
            // 
            // txtCodigoCarne
            // 
            this.txtCodigoCarne.Location = new System.Drawing.Point(157, 40);
            this.txtCodigoCarne.Name = "txtCodigoCarne";
            this.txtCodigoCarne.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCarne.TabIndex = 13;
            // 
            // btnAdicionarCarne
            // 
            this.btnAdicionarCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCarne.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarCarne.Image")));
            this.btnAdicionarCarne.Location = new System.Drawing.Point(169, 177);
            this.btnAdicionarCarne.Name = "btnAdicionarCarne";
            this.btnAdicionarCarne.Size = new System.Drawing.Size(78, 31);
            this.btnAdicionarCarne.TabIndex = 12;
            this.btnAdicionarCarne.UseVisualStyleBackColor = true;
            this.btnAdicionarCarne.Click += new System.EventHandler(this.btnAdicionarCarne_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(157, 135);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 11;
            // 
            // txtTipoPeca
            // 
            this.txtTipoPeca.Location = new System.Drawing.Point(157, 104);
            this.txtTipoPeca.Name = "txtTipoPeca";
            this.txtTipoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPeca.TabIndex = 10;
            // 
            // txtNomePeca
            // 
            this.txtNomePeca.Location = new System.Drawing.Point(157, 72);
            this.txtNomePeca.Name = "txtNomePeca";
            this.txtNomePeca.Size = new System.Drawing.Size(100, 20);
            this.txtNomePeca.TabIndex = 9;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(78, 139);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(72, 13);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço por Kg:";
            // 
            // lblTipoPeca
            // 
            this.lblTipoPeca.AutoSize = true;
            this.lblTipoPeca.Location = new System.Drawing.Point(78, 108);
            this.lblTipoPeca.Name = "lblTipoPeca";
            this.lblTipoPeca.Size = new System.Drawing.Size(73, 13);
            this.lblTipoPeca.TabIndex = 7;
            this.lblTipoPeca.Text = "Tipo da peça:";
            // 
            // lblNomePeca
            // 
            this.lblNomePeca.AutoSize = true;
            this.lblNomePeca.Location = new System.Drawing.Point(73, 76);
            this.lblNomePeca.Name = "lblNomePeca";
            this.lblNomePeca.Size = new System.Drawing.Size(80, 13);
            this.lblNomePeca.TabIndex = 6;
            this.lblNomePeca.Text = "Nome da peça:";
            this.lblNomePeca.Click += new System.EventHandler(this.lblNomePeca_Click);
            // 
            // btnVoltarAdicionarCarne
            // 
            this.btnVoltarAdicionarCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarAdicionarCarne.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarAdicionarCarne.Image")));
            this.btnVoltarAdicionarCarne.Location = new System.Drawing.Point(11, 211);
            this.btnVoltarAdicionarCarne.Name = "btnVoltarAdicionarCarne";
            this.btnVoltarAdicionarCarne.Size = new System.Drawing.Size(67, 31);
            this.btnVoltarAdicionarCarne.TabIndex = 5;
            this.btnVoltarAdicionarCarne.UseVisualStyleBackColor = true;
            this.btnVoltarAdicionarCarne.Click += new System.EventHandler(this.btnVoltarAdicionarCarne_Click);
            // 
            // gpEstoque
            // 
            this.gpEstoque.Controls.Add(this.cboCarnesEstoque);
            this.gpEstoque.Controls.Add(this.lblCarne);
            this.gpEstoque.Controls.Add(this.btnAdicionarEstoque);
            this.gpEstoque.Controls.Add(this.txtDatavalidadeEstoque);
            this.gpEstoque.Controls.Add(this.txtQuantidadeEstoque);
            this.gpEstoque.Controls.Add(this.txtId_estoque);
            this.gpEstoque.Controls.Add(this.lblDataValidade);
            this.gpEstoque.Controls.Add(this.lblQuantidade);
            this.gpEstoque.Controls.Add(this.lblID_estoque);
            this.gpEstoque.Controls.Add(this.btnVoltarEstoque);
            this.gpEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpEstoque.Location = new System.Drawing.Point(211, 53);
            this.gpEstoque.Name = "gpEstoque";
            this.gpEstoque.Size = new System.Drawing.Size(364, 252);
            this.gpEstoque.TabIndex = 13;
            this.gpEstoque.TabStop = false;
            this.gpEstoque.Text = "Adicionar Estoque";
            this.gpEstoque.Visible = false;
            // 
            // cboCarnesEstoque
            // 
            this.cboCarnesEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarnesEstoque.FormattingEnabled = true;
            this.cboCarnesEstoque.Location = new System.Drawing.Point(156, 75);
            this.cboCarnesEstoque.Name = "cboCarnesEstoque";
            this.cboCarnesEstoque.Size = new System.Drawing.Size(101, 21);
            this.cboCarnesEstoque.TabIndex = 14;
            // 
            // lblCarne
            // 
            this.lblCarne.AutoSize = true;
            this.lblCarne.Location = new System.Drawing.Point(71, 78);
            this.lblCarne.Name = "lblCarne";
            this.lblCarne.Size = new System.Drawing.Size(85, 13);
            this.lblCarne.TabIndex = 13;
            this.lblCarne.Text = "Adicionar Carne:";
            // 
            // btnAdicionarEstoque
            // 
            this.btnAdicionarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarEstoque.Image")));
            this.btnAdicionarEstoque.Location = new System.Drawing.Point(163, 179);
            this.btnAdicionarEstoque.Name = "btnAdicionarEstoque";
            this.btnAdicionarEstoque.Size = new System.Drawing.Size(78, 31);
            this.btnAdicionarEstoque.TabIndex = 12;
            this.btnAdicionarEstoque.UseVisualStyleBackColor = true;
            this.btnAdicionarEstoque.Click += new System.EventHandler(this.btnAdicionarEstoque_Click);
            // 
            // txtDatavalidadeEstoque
            // 
            this.txtDatavalidadeEstoque.Location = new System.Drawing.Point(157, 138);
            this.txtDatavalidadeEstoque.Name = "txtDatavalidadeEstoque";
            this.txtDatavalidadeEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtDatavalidadeEstoque.TabIndex = 11;
            // 
            // txtQuantidadeEstoque
            // 
            this.txtQuantidadeEstoque.Location = new System.Drawing.Point(157, 107);
            this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            this.txtQuantidadeEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeEstoque.TabIndex = 10;
            // 
            // txtId_estoque
            // 
            this.txtId_estoque.Location = new System.Drawing.Point(157, 48);
            this.txtId_estoque.Name = "txtId_estoque";
            this.txtId_estoque.Size = new System.Drawing.Size(100, 20);
            this.txtId_estoque.TabIndex = 9;
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Location = new System.Drawing.Point(71, 141);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(77, 13);
            this.lblDataValidade.TabIndex = 8;
            this.lblDataValidade.Text = "Data Validade:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(71, 110);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(81, 13);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade Kg:";
            // 
            // lblID_estoque
            // 
            this.lblID_estoque.AutoSize = true;
            this.lblID_estoque.Location = new System.Drawing.Point(34, 51);
            this.lblID_estoque.Name = "lblID_estoque";
            this.lblID_estoque.Size = new System.Drawing.Size(122, 13);
            this.lblID_estoque.TabIndex = 6;
            this.lblID_estoque.Text = "ID_Estoque(Nota fiscal):";
            // 
            // btnVoltarEstoque
            // 
            this.btnVoltarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarEstoque.Image")));
            this.btnVoltarEstoque.Location = new System.Drawing.Point(11, 211);
            this.btnVoltarEstoque.Name = "btnVoltarEstoque";
            this.btnVoltarEstoque.Size = new System.Drawing.Size(67, 31);
            this.btnVoltarEstoque.TabIndex = 5;
            this.btnVoltarEstoque.UseVisualStyleBackColor = true;
            this.btnVoltarEstoque.Click += new System.EventHandler(this.btnVoltarEstoque_Click);
            // 
            // gpDeletarCarne
            // 
            this.gpDeletarCarne.Controls.Add(this.cobSelecaoApagar);
            this.gpDeletarCarne.Controls.Add(this.lblSelecionarCarne);
            this.gpDeletarCarne.Controls.Add(this.bntApagarRegistro);
            this.gpDeletarCarne.Controls.Add(this.btnVoltarDeleteCarne);
            this.gpDeletarCarne.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpDeletarCarne.Location = new System.Drawing.Point(211, 53);
            this.gpDeletarCarne.Name = "gpDeletarCarne";
            this.gpDeletarCarne.Size = new System.Drawing.Size(364, 252);
            this.gpDeletarCarne.TabIndex = 15;
            this.gpDeletarCarne.TabStop = false;
            this.gpDeletarCarne.Text = "Deletar Carne";
            this.gpDeletarCarne.Visible = false;
            // 
            // cobSelecaoApagar
            // 
            this.cobSelecaoApagar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobSelecaoApagar.FormattingEnabled = true;
            this.cobSelecaoApagar.Location = new System.Drawing.Point(156, 75);
            this.cobSelecaoApagar.Name = "cobSelecaoApagar";
            this.cobSelecaoApagar.Size = new System.Drawing.Size(101, 21);
            this.cobSelecaoApagar.TabIndex = 14;
            // 
            // lblSelecionarCarne
            // 
            this.lblSelecionarCarne.AutoSize = true;
            this.lblSelecionarCarne.Location = new System.Drawing.Point(60, 78);
            this.lblSelecionarCarne.Name = "lblSelecionarCarne";
            this.lblSelecionarCarne.Size = new System.Drawing.Size(91, 13);
            this.lblSelecionarCarne.TabIndex = 13;
            this.lblSelecionarCarne.Text = "Selecionar Carne:";
            // 
            // bntApagarRegistro
            // 
            this.bntApagarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntApagarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("bntApagarRegistro.Image")));
            this.bntApagarRegistro.Location = new System.Drawing.Point(163, 130);
            this.bntApagarRegistro.Name = "bntApagarRegistro";
            this.bntApagarRegistro.Size = new System.Drawing.Size(84, 52);
            this.bntApagarRegistro.TabIndex = 12;
            this.bntApagarRegistro.UseVisualStyleBackColor = true;
            this.bntApagarRegistro.Click += new System.EventHandler(this.bntApagarRegistro_Click);
            // 
            // btnVoltarDeleteCarne
            // 
            this.btnVoltarDeleteCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarDeleteCarne.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarDeleteCarne.Image")));
            this.btnVoltarDeleteCarne.Location = new System.Drawing.Point(11, 211);
            this.btnVoltarDeleteCarne.Name = "btnVoltarDeleteCarne";
            this.btnVoltarDeleteCarne.Size = new System.Drawing.Size(67, 31);
            this.btnVoltarDeleteCarne.TabIndex = 5;
            this.btnVoltarDeleteCarne.UseVisualStyleBackColor = true;
            this.btnVoltarDeleteCarne.Click += new System.EventHandler(this.button2_Click);
            // 
            // gpDeletarCarneEstoque
            // 
            this.gpDeletarCarneEstoque.Controls.Add(this.btnDeletarEstoque);
            this.gpDeletarCarneEstoque.Controls.Add(this.btnDeletarCarne);
            this.gpDeletarCarneEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpDeletarCarneEstoque.Location = new System.Drawing.Point(137, 426);
            this.gpDeletarCarneEstoque.Name = "gpDeletarCarneEstoque";
            this.gpDeletarCarneEstoque.Size = new System.Drawing.Size(94, 95);
            this.gpDeletarCarneEstoque.TabIndex = 11;
            this.gpDeletarCarneEstoque.TabStop = false;
            this.gpDeletarCarneEstoque.Text = "Deletar";
            this.gpDeletarCarneEstoque.Visible = false;
            // 
            // btnDeletarEstoque
            // 
            this.btnDeletarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarEstoque.Image")));
            this.btnDeletarEstoque.Location = new System.Drawing.Point(13, 55);
            this.btnDeletarEstoque.Name = "btnDeletarEstoque";
            this.btnDeletarEstoque.Size = new System.Drawing.Size(67, 31);
            this.btnDeletarEstoque.TabIndex = 1;
            this.btnDeletarEstoque.UseVisualStyleBackColor = true;
            this.btnDeletarEstoque.Click += new System.EventHandler(this.btnDeletarEstoque_Click);
            // 
            // btnDeletarCarne
            // 
            this.btnDeletarCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarCarne.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarCarne.Image")));
            this.btnDeletarCarne.Location = new System.Drawing.Point(13, 18);
            this.btnDeletarCarne.Name = "btnDeletarCarne";
            this.btnDeletarCarne.Size = new System.Drawing.Size(67, 31);
            this.btnDeletarCarne.TabIndex = 0;
            this.btnDeletarCarne.UseVisualStyleBackColor = true;
            this.btnDeletarCarne.Click += new System.EventHandler(this.btnDeletarCarne_Click);
            // 
            // gpDeletarEstoque
            // 
            this.gpDeletarEstoque.Controls.Add(this.txtID_estoqueDeletar);
            this.gpDeletarEstoque.Controls.Add(this.label1);
            this.gpDeletarEstoque.Controls.Add(this.btnApagarRegistroEstoque);
            this.gpDeletarEstoque.Controls.Add(this.btnVoltarDeletarEstoque);
            this.gpDeletarEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpDeletarEstoque.Location = new System.Drawing.Point(211, 53);
            this.gpDeletarEstoque.Name = "gpDeletarEstoque";
            this.gpDeletarEstoque.Size = new System.Drawing.Size(364, 252);
            this.gpDeletarEstoque.TabIndex = 16;
            this.gpDeletarEstoque.TabStop = false;
            this.gpDeletarEstoque.Text = "Deletar Estoque";
            this.gpDeletarEstoque.Visible = false;
            // 
            // txtID_estoqueDeletar
            // 
            this.txtID_estoqueDeletar.Location = new System.Drawing.Point(189, 75);
            this.txtID_estoqueDeletar.Name = "txtID_estoqueDeletar";
            this.txtID_estoqueDeletar.Size = new System.Drawing.Size(100, 20);
            this.txtID_estoqueDeletar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Digite O ID_estoque(Nota fiscal):";
            // 
            // btnApagarRegistroEstoque
            // 
            this.btnApagarRegistroEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarRegistroEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnApagarRegistroEstoque.Image")));
            this.btnApagarRegistroEstoque.Location = new System.Drawing.Point(195, 118);
            this.btnApagarRegistroEstoque.Name = "btnApagarRegistroEstoque";
            this.btnApagarRegistroEstoque.Size = new System.Drawing.Size(84, 52);
            this.btnApagarRegistroEstoque.TabIndex = 12;
            this.btnApagarRegistroEstoque.UseVisualStyleBackColor = true;
            this.btnApagarRegistroEstoque.Click += new System.EventHandler(this.btnApagarRegistroEstoque_Click);
            // 
            // btnVoltarDeletarEstoque
            // 
            this.btnVoltarDeletarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarDeletarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarDeletarEstoque.Image")));
            this.btnVoltarDeletarEstoque.Location = new System.Drawing.Point(11, 211);
            this.btnVoltarDeletarEstoque.Name = "btnVoltarDeletarEstoque";
            this.btnVoltarDeletarEstoque.Size = new System.Drawing.Size(67, 31);
            this.btnVoltarDeletarEstoque.TabIndex = 5;
            this.btnVoltarDeletarEstoque.UseVisualStyleBackColor = true;
            this.btnVoltarDeletarEstoque.Click += new System.EventHandler(this.btnVoltarDeletarEstoque_Click);
            // 
            // gpAtualizarCarne
            // 
            this.gpAtualizarCarne.BackColor = System.Drawing.Color.Transparent;
            this.gpAtualizarCarne.Controls.Add(this.btnLimparCampus);
            this.gpAtualizarCarne.Controls.Add(this.txtprecoAtualizado);
            this.gpAtualizarCarne.Controls.Add(this.label5);
            this.gpAtualizarCarne.Controls.Add(this.btnVoltarAtualizarCarne);
            this.gpAtualizarCarne.Controls.Add(this.btnConsultarCarne);
            this.gpAtualizarCarne.Controls.Add(this.btnAtualizarPreco);
            this.gpAtualizarCarne.Controls.Add(this.label4);
            this.gpAtualizarCarne.Controls.Add(this.lblCodigoCarneAtualizar);
            this.gpAtualizarCarne.Controls.Add(this.label3);
            this.gpAtualizarCarne.Controls.Add(this.lblTipoCarne);
            this.gpAtualizarCarne.Controls.Add(this.lblNomeCarne);
            this.gpAtualizarCarne.Controls.Add(this.txtId_codigoCArneAtualizar);
            this.gpAtualizarCarne.Controls.Add(this.lblprecoCarneAntigo);
            this.gpAtualizarCarne.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpAtualizarCarne.Location = new System.Drawing.Point(211, 53);
            this.gpAtualizarCarne.Name = "gpAtualizarCarne";
            this.gpAtualizarCarne.Size = new System.Drawing.Size(364, 252);
            this.gpAtualizarCarne.TabIndex = 15;
            this.gpAtualizarCarne.TabStop = false;
            this.gpAtualizarCarne.Text = "Atualizar Carne";
            this.gpAtualizarCarne.Visible = false;
            // 
            // btnLimparCampus
            // 
            this.btnLimparCampus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCampus.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCampus.Image")));
            this.btnLimparCampus.Location = new System.Drawing.Point(103, 161);
            this.btnLimparCampus.Name = "btnLimparCampus";
            this.btnLimparCampus.Size = new System.Drawing.Size(67, 31);
            this.btnLimparCampus.TabIndex = 22;
            this.btnLimparCampus.UseVisualStyleBackColor = true;
            this.btnLimparCampus.Click += new System.EventHandler(this.btnLimparCampus_Click);
            // 
            // txtprecoAtualizado
            // 
            this.txtprecoAtualizado.Location = new System.Drawing.Point(232, 216);
            this.txtprecoAtualizado.Name = "txtprecoAtualizado";
            this.txtprecoAtualizado.Size = new System.Drawing.Size(100, 20);
            this.txtprecoAtualizado.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Preço:";
            // 
            // btnVoltarAtualizarCarne
            // 
            this.btnVoltarAtualizarCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarAtualizarCarne.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarAtualizarCarne.Image")));
            this.btnVoltarAtualizarCarne.Location = new System.Drawing.Point(11, 211);
            this.btnVoltarAtualizarCarne.Name = "btnVoltarAtualizarCarne";
            this.btnVoltarAtualizarCarne.Size = new System.Drawing.Size(67, 31);
            this.btnVoltarAtualizarCarne.TabIndex = 5;
            this.btnVoltarAtualizarCarne.UseVisualStyleBackColor = true;
            this.btnVoltarAtualizarCarne.Click += new System.EventHandler(this.btnVoltarAtualizarCarne_Click);
            // 
            // btnConsultarCarne
            // 
            this.btnConsultarCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCarne.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarCarne.Image")));
            this.btnConsultarCarne.Location = new System.Drawing.Point(189, 150);
            this.btnConsultarCarne.Name = "btnConsultarCarne";
            this.btnConsultarCarne.Size = new System.Drawing.Size(84, 52);
            this.btnConsultarCarne.TabIndex = 18;
            this.btnConsultarCarne.UseVisualStyleBackColor = true;
            this.btnConsultarCarne.Click += new System.EventHandler(this.btnConsultarCarne_Click);
            // 
            // btnAtualizarPreco
            // 
            this.btnAtualizarPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarPreco.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarPreco.Image")));
            this.btnAtualizarPreco.Location = new System.Drawing.Point(103, 211);
            this.btnAtualizarPreco.Name = "btnAtualizarPreco";
            this.btnAtualizarPreco.Size = new System.Drawing.Size(123, 31);
            this.btnAtualizarPreco.TabIndex = 23;
            this.btnAtualizarPreco.UseVisualStyleBackColor = true;
            this.btnAtualizarPreco.Click += new System.EventHandler(this.btnAtualizarPreco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo:";
            // 
            // lblCodigoCarneAtualizar
            // 
            this.lblCodigoCarneAtualizar.AutoSize = true;
            this.lblCodigoCarneAtualizar.Location = new System.Drawing.Point(94, 31);
            this.lblCodigoCarneAtualizar.Name = "lblCodigoCarneAtualizar";
            this.lblCodigoCarneAtualizar.Size = new System.Drawing.Size(89, 13);
            this.lblCodigoCarneAtualizar.TabIndex = 13;
            this.lblCodigoCarneAtualizar.Text = "Codigo da Carne:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nome carne:";
            // 
            // lblTipoCarne
            // 
            this.lblTipoCarne.AutoSize = true;
            this.lblTipoCarne.Location = new System.Drawing.Point(192, 73);
            this.lblTipoCarne.Name = "lblTipoCarne";
            this.lblTipoCarne.Size = new System.Drawing.Size(0, 13);
            this.lblTipoCarne.TabIndex = 16;
            // 
            // lblNomeCarne
            // 
            this.lblNomeCarne.AutoSize = true;
            this.lblNomeCarne.Location = new System.Drawing.Point(192, 52);
            this.lblNomeCarne.Name = "lblNomeCarne";
            this.lblNomeCarne.Size = new System.Drawing.Size(0, 13);
            this.lblNomeCarne.TabIndex = 15;
            // 
            // txtId_codigoCArneAtualizar
            // 
            this.txtId_codigoCArneAtualizar.Location = new System.Drawing.Point(188, 28);
            this.txtId_codigoCArneAtualizar.Name = "txtId_codigoCArneAtualizar";
            this.txtId_codigoCArneAtualizar.Size = new System.Drawing.Size(100, 20);
            this.txtId_codigoCArneAtualizar.TabIndex = 14;
            // 
            // lblprecoCarneAntigo
            // 
            this.lblprecoCarneAntigo.AutoSize = true;
            this.lblprecoCarneAntigo.Location = new System.Drawing.Point(191, 94);
            this.lblprecoCarneAntigo.Name = "lblprecoCarneAntigo";
            this.lblprecoCarneAntigo.Size = new System.Drawing.Size(0, 13);
            this.lblprecoCarneAntigo.TabIndex = 17;
            // 
            // fmvisaoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.gpBotoesAdicionar);
            this.Controls.Add(this.btnTesteConexao);
            this.Controls.Add(this.gpDeletarCarneEstoque);
            this.Controls.Add(this.gpCarneEstoque);
            this.Controls.Add(this.gpEstoque);
            this.Controls.Add(this.gpAdicionarCarne);
            this.Controls.Add(this.gpDeletarEstoque);
            this.Controls.Add(this.dgdTabela);
            this.Controls.Add(this.gpDeletarCarne);
            this.Controls.Add(this.gpAtualizarCarne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmvisaoGeral";
            this.Text = "Controle de Estoque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmvisaoGeral_FormClosing);
            this.Load += new System.EventHandler(this.fmvisaoGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdTabela)).EndInit();
            this.gpBotoesAdicionar.ResumeLayout(false);
            this.gpBotoesAdicionar.PerformLayout();
            this.gpCarneEstoque.ResumeLayout(false);
            this.gpAdicionarCarne.ResumeLayout(false);
            this.gpAdicionarCarne.PerformLayout();
            this.gpEstoque.ResumeLayout(false);
            this.gpEstoque.PerformLayout();
            this.gpDeletarCarne.ResumeLayout(false);
            this.gpDeletarCarne.PerformLayout();
            this.gpDeletarCarneEstoque.ResumeLayout(false);
            this.gpDeletarEstoque.ResumeLayout(false);
            this.gpDeletarEstoque.PerformLayout();
            this.gpAtualizarCarne.ResumeLayout(false);
            this.gpAtualizarCarne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgdTabela;
        private System.Windows.Forms.Button btnTesteConexao;
        private System.Windows.Forms.GroupBox gpBotoesAdicionar;
        private System.Windows.Forms.GroupBox gpCarneEstoque;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnCarne;
        private System.Windows.Forms.GroupBox gpAdicionarCarne;
        private System.Windows.Forms.Button btnVoltarAdicionarCarne;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblTipoPeca;
        private System.Windows.Forms.Label lblNomePeca;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtTipoPeca;
        private System.Windows.Forms.TextBox txtNomePeca;
        private System.Windows.Forms.Button btnAdicionarCarne;
        private System.Windows.Forms.GroupBox gpEstoque;
        private System.Windows.Forms.Button btnAdicionarEstoque;
        private System.Windows.Forms.TextBox txtDatavalidadeEstoque;
        private System.Windows.Forms.TextBox txtQuantidadeEstoque;
        private System.Windows.Forms.TextBox txtId_estoque;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblID_estoque;
        private System.Windows.Forms.Button btnVoltarEstoque;
        private System.Windows.Forms.Label lblCarne;
        private System.Windows.Forms.ComboBox cboCarnesEstoque;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox gpDeletarCarneEstoque;
        private System.Windows.Forms.Button btnDeletarEstoque;
        private System.Windows.Forms.Button btnDeletarCarne;
        private System.Windows.Forms.GroupBox gpDeletarCarne;
        private System.Windows.Forms.ComboBox cobSelecaoApagar;
        private System.Windows.Forms.Label lblSelecionarCarne;
        private System.Windows.Forms.Button bntApagarRegistro;
        private System.Windows.Forms.Button btnVoltarDeleteCarne;
        private System.Windows.Forms.GroupBox gpDeletarEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApagarRegistroEstoque;
        private System.Windows.Forms.Button btnVoltarDeletarEstoque;
        private System.Windows.Forms.TextBox txtID_estoqueDeletar;
        private System.Windows.Forms.Label lblCodigoCarne;
        private System.Windows.Forms.TextBox txtCodigoCarne;
        private System.Windows.Forms.Button btnVisualizarVendas;
        private System.Windows.Forms.Button bntAtualizarCarne;
        private System.Windows.Forms.GroupBox gpAtualizarCarne;
        private System.Windows.Forms.Label lblCodigoCarneAtualizar;
        private System.Windows.Forms.Button btnVoltarAtualizarCarne;
        private System.Windows.Forms.TextBox txtId_codigoCArneAtualizar;
        private System.Windows.Forms.Label lblprecoCarneAntigo;
        private System.Windows.Forms.Label lblTipoCarne;
        private System.Windows.Forms.Label lblNomeCarne;
        private System.Windows.Forms.Button btnConsultarCarne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimparCampus;
        private System.Windows.Forms.TextBox txtprecoAtualizado;
        private System.Windows.Forms.Button btnAtualizarPreco;
    }
}
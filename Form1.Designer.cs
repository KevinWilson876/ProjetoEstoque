namespace ProjetoEstoque
{
    partial class fmInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmInicial));
            this.plBarraSuperior = new System.Windows.Forms.Panel();
            this.lblTituloControleEstoque = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnVisaoGeral = new System.Windows.Forms.Button();
            this.btnIniciarServico = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.plCentro = new System.Windows.Forms.Panel();
            this.txtLeitorTeste = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.plBarraSuperior.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.plCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // plBarraSuperior
            // 
            this.plBarraSuperior.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.plBarraSuperior.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plBarraSuperior.Controls.Add(this.lblTituloControleEstoque);
            this.plBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.plBarraSuperior.Name = "plBarraSuperior";
            this.plBarraSuperior.Size = new System.Drawing.Size(784, 87);
            this.plBarraSuperior.TabIndex = 1;
            // 
            // lblTituloControleEstoque
            // 
            this.lblTituloControleEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloControleEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloControleEstoque.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloControleEstoque.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTituloControleEstoque.Location = new System.Drawing.Point(0, 0);
            this.lblTituloControleEstoque.Name = "lblTituloControleEstoque";
            this.lblTituloControleEstoque.Size = new System.Drawing.Size(784, 87);
            this.lblTituloControleEstoque.TabIndex = 0;
            this.lblTituloControleEstoque.Text = "Controle de estoque";
            this.lblTituloControleEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTituloControleEstoque.Click += new System.EventHandler(this.lblTituloControleEstoque_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.3125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.6875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Controls.Add(this.btnRelatorios, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVisaoGeral, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIniciarServico, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfig, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(150, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 155);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.ForeColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.Location = new System.Drawing.Point(170, 3);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(159, 71);
            this.btnRelatorios.TabIndex = 3;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnVisaoGeral
            // 
            this.btnVisaoGeral.BackColor = System.Drawing.Color.Transparent;
            this.btnVisaoGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVisaoGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisaoGeral.ForeColor = System.Drawing.Color.Transparent;
            this.btnVisaoGeral.Image = ((System.Drawing.Image)(resources.GetObject("btnVisaoGeral.Image")));
            this.btnVisaoGeral.Location = new System.Drawing.Point(3, 3);
            this.btnVisaoGeral.Name = "btnVisaoGeral";
            this.btnVisaoGeral.Size = new System.Drawing.Size(161, 71);
            this.btnVisaoGeral.TabIndex = 2;
            this.btnVisaoGeral.UseVisualStyleBackColor = false;
            this.btnVisaoGeral.Click += new System.EventHandler(this.btnVisaoGeral_Click);
            // 
            // btnIniciarServico
            // 
            this.btnIniciarServico.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarServico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarServico.BackgroundImage")));
            this.btnIniciarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIniciarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarServico.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarServico.Location = new System.Drawing.Point(170, 80);
            this.btnIniciarServico.Name = "btnIniciarServico";
            this.btnIniciarServico.Size = new System.Drawing.Size(159, 72);
            this.btnIniciarServico.TabIndex = 7;
            this.btnIniciarServico.Text = "Iniciar Serviço";
            this.btnIniciarServico.UseVisualStyleBackColor = false;
            this.btnIniciarServico.Click += new System.EventHandler(this.btnIniciarServico_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(335, 3);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(165, 71);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // plCentro
            // 
            this.plCentro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.plCentro.Controls.Add(this.txtLeitorTeste);
            this.plCentro.Controls.Add(this.tableLayoutPanel1);
            this.plCentro.Location = new System.Drawing.Point(-2, 87);
            this.plCentro.Name = "plCentro";
            this.plCentro.Size = new System.Drawing.Size(784, 325);
            this.plCentro.TabIndex = 7;
            // 
            // txtLeitorTeste
            // 
            this.txtLeitorTeste.Location = new System.Drawing.Point(354, 233);
            this.txtLeitorTeste.Name = "txtLeitorTeste";
            this.txtLeitorTeste.Size = new System.Drawing.Size(100, 20);
            this.txtLeitorTeste.TabIndex = 8;
            this.txtLeitorTeste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLeitorTeste_KeyPress);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Executando";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click_1);
            // 
            // fmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 407);
            this.Controls.Add(this.plCentro);
            this.Controls.Add(this.plBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmInicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmInicial_KeyDown);
            this.plBarraSuperior.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.plCentro.ResumeLayout(false);
            this.plCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plBarraSuperior;
        private System.Windows.Forms.Label lblTituloControleEstoque;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnVisaoGeral;
        private System.Windows.Forms.Button btnIniciarServico;
        private System.Windows.Forms.Panel plCentro;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox txtLeitorTeste;
    }
}


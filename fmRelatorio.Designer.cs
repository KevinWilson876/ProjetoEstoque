namespace ProjetoEstoque
{
    partial class fmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRelatorio));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dataGridViewRelatorio = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnRrelatorioDia = new System.Windows.Forms.Button();
            this.btnRelatorioSemana = new System.Windows.Forms.Button();
            this.btnRelatorioMes = new System.Windows.Forms.Button();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.gpRelatorios = new System.Windows.Forms.GroupBox();
            this.btnVisualizarGrafico = new System.Windows.Forms.Button();
            this.gpGrafico = new System.Windows.Forms.GroupBox();
            this.btnVoltarRelatorio = new System.Windows.Forms.Button();
            this.chartRelatorio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTesteConexao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).BeginInit();
            this.gpRelatorios.SuspendLayout();
            this.gpGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRelatorio)).BeginInit();
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
            // dataGridViewRelatorio
            // 
            this.dataGridViewRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorio.Location = new System.Drawing.Point(23, 108);
            this.dataGridViewRelatorio.Name = "dataGridViewRelatorio";
            this.dataGridViewRelatorio.Size = new System.Drawing.Size(462, 150);
            this.dataGridViewRelatorio.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(150, 36);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged_1);
            // 
            // btnRrelatorioDia
            // 
            this.btnRrelatorioDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRrelatorioDia.Image = ((System.Drawing.Image)(resources.GetObject("btnRrelatorioDia.Image")));
            this.btnRrelatorioDia.Location = new System.Drawing.Point(48, 284);
            this.btnRrelatorioDia.Name = "btnRrelatorioDia";
            this.btnRrelatorioDia.Size = new System.Drawing.Size(120, 31);
            this.btnRrelatorioDia.TabIndex = 3;
            this.btnRrelatorioDia.UseVisualStyleBackColor = true;
            this.btnRrelatorioDia.Click += new System.EventHandler(this.btnRrelatorioDia_Click);
            // 
            // btnRelatorioSemana
            // 
            this.btnRelatorioSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioSemana.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorioSemana.Image")));
            this.btnRelatorioSemana.Location = new System.Drawing.Point(174, 284);
            this.btnRelatorioSemana.Name = "btnRelatorioSemana";
            this.btnRelatorioSemana.Size = new System.Drawing.Size(144, 31);
            this.btnRelatorioSemana.TabIndex = 4;
            this.btnRelatorioSemana.UseVisualStyleBackColor = true;
            this.btnRelatorioSemana.Click += new System.EventHandler(this.btnRelatorioSemana_Click);
            // 
            // btnRelatorioMes
            // 
            this.btnRelatorioMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioMes.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorioMes.Image")));
            this.btnRelatorioMes.Location = new System.Drawing.Point(324, 284);
            this.btnRelatorioMes.Name = "btnRelatorioMes";
            this.btnRelatorioMes.Size = new System.Drawing.Size(125, 31);
            this.btnRelatorioMes.TabIndex = 5;
            this.btnRelatorioMes.UseVisualStyleBackColor = true;
            this.btnRelatorioMes.Click += new System.EventHandler(this.btnRelatorioMes_Click);
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Location = new System.Drawing.Point(225, 77);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(0, 13);
            this.lblRelatorio.TabIndex = 6;
            // 
            // gpRelatorios
            // 
            this.gpRelatorios.Controls.Add(this.btnVisualizarGrafico);
            this.gpRelatorios.Controls.Add(this.dateTimePicker);
            this.gpRelatorios.Controls.Add(this.lblRelatorio);
            this.gpRelatorios.Controls.Add(this.dataGridViewRelatorio);
            this.gpRelatorios.Controls.Add(this.btnRelatorioMes);
            this.gpRelatorios.Controls.Add(this.btnRrelatorioDia);
            this.gpRelatorios.Controls.Add(this.btnRelatorioSemana);
            this.gpRelatorios.Location = new System.Drawing.Point(151, 12);
            this.gpRelatorios.Name = "gpRelatorios";
            this.gpRelatorios.Size = new System.Drawing.Size(507, 369);
            this.gpRelatorios.TabIndex = 7;
            this.gpRelatorios.TabStop = false;
            // 
            // btnVisualizarGrafico
            // 
            this.btnVisualizarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarGrafico.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarGrafico.Image")));
            this.btnVisualizarGrafico.Location = new System.Drawing.Point(186, 329);
            this.btnVisualizarGrafico.Name = "btnVisualizarGrafico";
            this.btnVisualizarGrafico.Size = new System.Drawing.Size(122, 31);
            this.btnVisualizarGrafico.TabIndex = 7;
            this.btnVisualizarGrafico.UseVisualStyleBackColor = true;
            this.btnVisualizarGrafico.Click += new System.EventHandler(this.btnVisualizarGrafico_Click);
            // 
            // gpGrafico
            // 
            this.gpGrafico.Controls.Add(this.btnVoltarRelatorio);
            this.gpGrafico.Controls.Add(this.chartRelatorio);
            this.gpGrafico.Location = new System.Drawing.Point(136, 12);
            this.gpGrafico.Name = "gpGrafico";
            this.gpGrafico.Size = new System.Drawing.Size(541, 396);
            this.gpGrafico.TabIndex = 8;
            this.gpGrafico.TabStop = false;
            this.gpGrafico.Visible = false;
            // 
            // btnVoltarRelatorio
            // 
            this.btnVoltarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarRelatorio.Image")));
            this.btnVoltarRelatorio.Location = new System.Drawing.Point(228, 346);
            this.btnVoltarRelatorio.Name = "btnVoltarRelatorio";
            this.btnVoltarRelatorio.Size = new System.Drawing.Size(96, 31);
            this.btnVoltarRelatorio.TabIndex = 1;
            this.btnVoltarRelatorio.UseVisualStyleBackColor = true;
            this.btnVoltarRelatorio.Click += new System.EventHandler(this.btnVoltarRelatorio_Click);
            // 
            // chartRelatorio
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRelatorio.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRelatorio.Legends.Add(legend1);
            this.chartRelatorio.Location = new System.Drawing.Point(6, 35);
            this.chartRelatorio.Name = "chartRelatorio";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRelatorio.Series.Add(series1);
            this.chartRelatorio.Size = new System.Drawing.Size(529, 288);
            this.chartRelatorio.TabIndex = 0;
            this.chartRelatorio.Text = "chart1";
            // 
            // btnTesteConexao
            // 
            this.btnTesteConexao.Location = new System.Drawing.Point(15, 134);
            this.btnTesteConexao.Name = "btnTesteConexao";
            this.btnTesteConexao.Size = new System.Drawing.Size(113, 23);
            this.btnTesteConexao.TabIndex = 9;
            this.btnTesteConexao.Text = "teste Conexao";
            this.btnTesteConexao.UseVisualStyleBackColor = true;
            this.btnTesteConexao.Visible = false;
            this.btnTesteConexao.Click += new System.EventHandler(this.btnTesteConexao_Click);
            // 
            // fmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTesteConexao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpRelatorios);
            this.Controls.Add(this.gpGrafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmRelatorio";
            this.Text = "Relatorios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmRelatorio_FormClosing);
            this.Load += new System.EventHandler(this.fmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).EndInit();
            this.gpRelatorios.ResumeLayout(false);
            this.gpRelatorios.PerformLayout();
            this.gpGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridViewRelatorio;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnRrelatorioDia;
        private System.Windows.Forms.Button btnRelatorioSemana;
        private System.Windows.Forms.Button btnRelatorioMes;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.GroupBox gpRelatorios;
        private System.Windows.Forms.Button btnVisualizarGrafico;
        private System.Windows.Forms.GroupBox gpGrafico;
        private System.Windows.Forms.Button btnVoltarRelatorio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRelatorio;
        private System.Windows.Forms.Button btnTesteConexao;
    }
}
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static ProjetoEstoque.fmInicial;

namespace ProjetoEstoque
{
    public partial class fmRelatorio : Form
    {        
        private Form form1; // Adicione uma referência ao Form1
        public fmRelatorio(Form form1)
        {
            InitializeComponent();
            this.form1 = form1; // Inicialize a referência ao Form1
                    
        }

        private void fmRelatorio_Load(object sender, EventArgs e)
        {
            btnVisualizarGrafico.FlatAppearance.BorderSize = 0; // Remove a borda
            btnVisualizarGrafico.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            btnRelatorioMes.FlatAppearance.BorderSize = 0; // Remove a borda
            btnRelatorioMes.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            btnRelatorioSemana.FlatAppearance.BorderSize = 0; // Remove a borda
            btnRelatorioSemana.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            btnRrelatorioDia.FlatAppearance.BorderSize = 0; // Remove a borda
            btnRrelatorioDia.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            btnVoltarRelatorio.FlatAppearance.BorderSize = 0; // Remove a borda
            btnVoltarRelatorio.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            //trocando de cor do background 
            this.BackColor = ColorTranslator.FromHtml("#b3bac4");

            btnVoltar.BackColor = ColorTranslator.FromHtml("#b3bac4");
            btnVoltar.ForeColor = ColorTranslator.FromHtml("#b3bac4");

            // Configurações do DataGridView
            dataGridViewRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRelatorio.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRelatorio.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta o Form2
            form1.Show(); // Mostra o Form1
        }
        private void CarregarRelatorioVendas(DateTime data)
        {
            
            OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString); // Substitua pela sua string de conexão
            con.Open();

            string query = @"
SELECT 
    c.NOME AS ""Nome da Carne"", 
    SUM(v.PESO) AS ""Total Vendido (Kg)"", 
    SUM(v.PRECO_TOTAL) AS ""Receita Total (R$)""
FROM 
    VENDA v
JOIN 
    VENDIDO vd ON v.ID_VENDA = vd.ID_VENDA
JOIN 
    CARNE c ON vd.ID_CARNE = c.ID_CARNE
WHERE 
    TRUNC(v.DATA_VENDA) = :data_venda
GROUP BY 
    c.NOME
ORDER BY 
    SUM(v.PESO) DESC";

            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                cmd.Parameters.Add(new OracleParameter("data_venda", data.Date));
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewRelatorio.DataSource = dataTable; // dataGridViewRelatorio é o nome do seu DataGridView
            }

            con.Close();
        }

        private void dateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker.Value; // Obtém a data selecionada
            CarregarRelatorioVendas(selectedDate); // Recarrega o relatório para a data selecionada
        }

        private void btnRrelatorioDia_Click(object sender, EventArgs e)
        {
            CarregarRelatorioVendas(DateTime.Now); // Carrega o relatório para a data atual ao abrir o formulário
            lblRelatorio.Text = "Relatorio do Dia";
        }

        private void CarregarRelatorioSemanal()
        {
            OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString); // Substitua pela sua string de conexão
            con.Open();

            // Calcular a data inicial da semana (segunda-feira)
            DateTime dataFinal = DateTime.Now;
            DateTime dataInicial = dataFinal.AddDays(-(int)dataFinal.DayOfWeek + (int)DayOfWeek.Monday);
            if (dataFinal.DayOfWeek == DayOfWeek.Sunday)
            {
                dataInicial = dataInicial.AddDays(-7); // Ajuste caso o dia atual seja domingo
            }

            string query = @"
SELECT 
    c.NOME AS ""Nome da Carne"", 
    SUM(v.PESO) AS ""Total Vendido (Kg)"", 
    SUM(v.PRECO_TOTAL) AS ""Receita Total (R$)""
FROM 
    VENDA v
JOIN 
    VENDIDO vd ON v.ID_VENDA = vd.ID_VENDA
JOIN 
    CARNE c ON vd.ID_CARNE = c.ID_CARNE
WHERE 
    TRUNC(v.DATA_VENDA) BETWEEN :data_inicial AND :data_final
GROUP BY 
    c.NOME
ORDER BY 
    SUM(v.PESO) DESC";

            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                cmd.Parameters.Add(new OracleParameter("data_inicial", dataInicial.Date));
                cmd.Parameters.Add(new OracleParameter("data_final", dataFinal.Date));
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewRelatorio.DataSource = dataTable; // dataGridViewRelatorio é o nome do seu DataGridView
            }

            con.Close();
        }

        private void btnRelatorioSemana_Click(object sender, EventArgs e)
        {
            CarregarRelatorioSemanal();
            lblRelatorio.Text = "Relatorio da Semana";
        }

        private void CarregarRelatorioMensal()
        {
            OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString); // Substitua pela sua string de conexão
            con.Open();

            DateTime dataFinal = DateTime.Now;
            DateTime dataInicial = new DateTime(dataFinal.Year, dataFinal.Month, 1); // Primeiro dia do mês atual

            string query = @"
SELECT 
    c.NOME AS ""Nome da Carne"", 
    SUM(v.PESO) AS ""Total Vendido (Kg)"", 
    SUM(v.PRECO_TOTAL) AS ""Receita Total (R$)""
FROM 
    VENDA v
JOIN 
    VENDIDO vd ON v.ID_VENDA = vd.ID_VENDA
JOIN 
    CARNE c ON vd.ID_CARNE = c.ID_CARNE
WHERE 
    TRUNC(v.DATA_VENDA) BETWEEN :data_inicial AND :data_final
GROUP BY 
    c.NOME
ORDER BY 
    SUM(v.PESO) DESC";

            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                cmd.Parameters.Add(new OracleParameter("data_inicial", dataInicial.Date));
                cmd.Parameters.Add(new OracleParameter("data_final", dataFinal.Date));
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewRelatorio.DataSource = dataTable; // dataGridViewRelatorio é o nome do seu DataGridView
            }

            con.Close();
        }

        private void btnRelatorioMes_Click(object sender, EventArgs e)
        {
            CarregarRelatorioMensal();
            lblRelatorio.Text = "Relatorio do Més";
        }

        private void btnVisualizarGrafico_Click(object sender, EventArgs e)
        {
            gpRelatorios.Visible = false;
            gpGrafico.Visible = true;
            // Supondo que 'dataGridViewRelatorio.DataSource' tenha os dados necessários
            DataTable dataTable = (DataTable)dataGridViewRelatorio.DataSource;
            if (dataTable != null)
            {
                // Atualiza o gráfico com os dados do DataTable
                AtualizarGrafico(dataTable);
            }
            else
            {
                MessageBox.Show("Nenhum dado disponível para gerar o gráfico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVoltarRelatorio_Click(object sender, EventArgs e)
        {
            gpGrafico.Visible = false;
            gpRelatorios.Visible=true;
        }

        private void AtualizarGrafico(DataTable dataTable)
        {
            chartRelatorio.Series.Clear();
            chartRelatorio.Titles.Clear();

            // Adicionar título
            chartRelatorio.Titles.Add("Relatório de Vendas");

            Series series = chartRelatorio.Series.Add("Total Vendido (Kg)");
            series.ChartType = SeriesChartType.Bar;
            series.IsValueShownAsLabel = true; // Mostra os valores nas barras

            // Personalizar cores
            series.Color = Color.FromArgb(79, 129, 189);

            foreach (DataRow row in dataTable.Rows)
            {
                string nomeCarne = row["Nome da Carne"].ToString();
                double totalVendido = Convert.ToDouble(row["Total Vendido (Kg)"]);
                int index = series.Points.AddXY(nomeCarne, totalVendido);

                // Define cores alternadas para as barras
                series.Points[index].Color = index % 2 == 0 ? Color.FromArgb(103, 171, 204) : Color.FromArgb(180, 198, 231);

                // Adiciona rótulos aos pontos
                series.Points[index].Label = totalVendido.ToString("F2") + " Kg";
                series.Points[index].LabelForeColor = Color.Black;
            }

            // Ajustar os títulos dos eixos
            chartRelatorio.ChartAreas[0].AxisX.Title = "Nome da Carne";
            chartRelatorio.ChartAreas[0].AxisX.TitleFont = new Font("Verdana", 10, FontStyle.Bold);
            chartRelatorio.ChartAreas[0].AxisY.Title = "Total Vendido (Kg)";
            chartRelatorio.ChartAreas[0].AxisY.TitleFont = new Font("Verdana", 10, FontStyle.Bold);

            // Estilizar os eixos
            chartRelatorio.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Verdana", 8);
            chartRelatorio.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Verdana", 8);

            // Estilizar a legenda
            if (chartRelatorio.Legends.Count > 0)
            {
                chartRelatorio.Legends[0].Font = new Font("Verdana", 8);
            }
            else
            {
                var legend = chartRelatorio.Legends.Add("Legend1");
                legend.Font = new Font("Verdana", 8);
            }
        }

        private void fmRelatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancelar o fechamento do formulário
            e.Cancel = true;
            // Opcional: Exibir uma mensagem para o usuário
            MessageBox.Show("Você não pode fechar esta janela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTesteConexao_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(GlobalVariables.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Conexão estabelecida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao estabelecer conexão: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}


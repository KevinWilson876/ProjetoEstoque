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
using static ProjetoEstoque.fmInicial;

namespace ProjetoEstoque
{
    public partial class fmConfiguracoes : Form
    {   
        private Form form1; // Adicione uma referência ao Form1
        public fmConfiguracoes(fmInicial form1)
        {
            InitializeComponent();
            this.form1 = form1; // Inicialize a referência ao Form1

            // Configurações do DataGridView
            dgdTabelaEstoqueAtual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgdTabelaEstoqueAtual.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgdTabelaEstoqueAtual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdTabelaEstoqueAtual.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        }

        private void fmConfiguracoes_Load(object sender, EventArgs e)
        {
            btnVoltarConfig.BackColor = ColorTranslator.FromHtml("#b3bac4");
            btnVoltarConfig.ForeColor = ColorTranslator.FromHtml("#b3bac4");

            btnDefinirLimeteEstoque.FlatAppearance.BorderSize = 0; // Remove a borda
            btnDefinirLimeteEstoque.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            btnDefinirEstoqueUso.FlatAppearance.BorderSize = 0; // Remove a borda
            btnDefinirEstoqueUso.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            btnLimparCampos.FlatAppearance.BorderSize = 0; // Remove a borda
            btnLimparCampos.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            //trocando de cor do background 
            this.BackColor = ColorTranslator.FromHtml("#b3bac4");

            LoadData();
            // Chamar o método para carregar carnes no ComboBox ao carregar o formulário
            CarregarCarnesNoComboBox();

            try
            {
                using (OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    con.Open(); 
                    decimal valorConfiguracao = ObterValorConfiguracaoPorID(con, 1); // Ajuste o ID conforme necessário
                    lblLimiteAtual.Text = $"Limite atual: {valorConfiguracao}"; 
                } 
            } 
            catch (Exception ex) 
            { 
                lblLimiteAtual.Text = $"Erro: {ex.Message}"; 
            }

        }
        private decimal ObterValorConfiguracaoPorID(OracleConnection con, int idConfiguracao)
        {
            string queryConfiguracao = @"SELECT VALOR_CONFIGURACAO 
                                 FROM CONFIGURACOES 
                                 WHERE ID_CONFIGURACAO = :id_configuracao";
            using (OracleCommand cmdConfiguracao = new OracleCommand(queryConfiguracao, con))
            {
                cmdConfiguracao.Parameters.Add(new OracleParameter("id_configuracao", idConfiguracao));
                object valor = cmdConfiguracao.ExecuteScalar();
                if (valor != null && decimal.TryParse(valor.ToString(), out decimal valorDecimal))
                {
                    return valorDecimal;
                }
                else
                {
                    throw new Exception("Configuração não encontrada ou valor inválido.");
                }
            }
        }

        private void LoadData()
        {
            try
            {

                string query = @"
    SELECT 
        ea.ID_ESTOQUE_ATUAL AS ""ID Estoque Atual"", 
        c.NOME AS ""Nome Carne"", 
        c.TIPO AS ""Tipo Carne""
    FROM 
        ESTOQUE_ATUAL ea
    JOIN 
        CARNE c ON ea.ID_CARNE = c.ID_CARNE";



                using (OracleConnection conn = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    OracleDataAdapter da = new OracleDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgdTabelaEstoqueAtual.DataSource = dt;

                    // Adicione um MessageBox para verificar se o DataTable está preenchido
                    //if (dt.Rows.Count > 0) 
                    //{ 
                    //    MessageBox.Show($"Dados carregados com sucesso. Total de registros: {dt.Rows.Count}"); 
                    //} 
                    //else 
                    //{ 
                    //    MessageBox.Show("Nenhum dado encontrado."); 
                    //}

                    foreach (DataGridViewColumn column in dgdTabelaEstoqueAtual.Columns)
                    {
                        column.Visible = true;
                    }

                    dgdTabelaEstoqueAtual.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void CarregarCarnesNoComboBox()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    conn.Open();

                    // Consulta para obter os nomes das carnes
                    string query = "SELECT NOME FROM CARNE";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Adiciona cada nome de carne ao ComboBox
                                cobSelecionarCarne.Items.Add(reader["NOME"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar carnes: " + ex.Message);
            }
        }

        private void btnVoltarConfig_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta o Form2
            form1.Show(); // Mostra o Form1
        }

        private void btnDefinirEstoqueUso_Click(object sender, EventArgs e)
        {
            if (cobSelecionarCarne.Text !="" && cobId_estoque.Text !="")
            {
                string carneSelecionada = cobSelecionarCarne.SelectedItem.ToString();
                string idEstoque = cobId_estoque.Text;
                DefinirEstoqueUso(carneSelecionada, idEstoque);
                //txtId_EstoqueDefinir.Clear();
                LoadData();
            }
            else
            {
                MessageBox.Show("Escolha um Item da lista");
            }
            
        }

        private void DefinirEstoqueUso(string carneSelecionada, string idEstoque)
        {
            using (OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString))
            {
                con.Open();

                // Busca as informações do ID_CARNE da carne selecionada
                string queryCarne = "SELECT ID_CARNE FROM CARNE WHERE NOME = :nome";
                using (OracleCommand cmdCarne = new OracleCommand(queryCarne, con))
                {
                    cmdCarne.Parameters.Add(new OracleParameter("nome", carneSelecionada));
                    OracleDataReader readerCarne = cmdCarne.ExecuteReader();
                    if (readerCarne.Read())
                    {
                        int idCarne = readerCarne.GetInt32(0);

                        // Verifica se o ID_CARNE e ID_ESTOQUE existem na tabela ARMAZENA
                        string queryArmazena = "SELECT 1 FROM ARMAZENA WHERE ID_CARNE = :id_carne AND ID_ESTOQUE = :id_estoque";
                        using (OracleCommand cmdArmazena = new OracleCommand(queryArmazena, con))
                        {
                            cmdArmazena.Parameters.Add(new OracleParameter("id_carne", idCarne));
                            cmdArmazena.Parameters.Add(new OracleParameter("id_estoque", idEstoque));
                            OracleDataReader readerArmazena = cmdArmazena.ExecuteReader();

                            if (readerArmazena.Read())
                            {
                                // Verifique se os valores estão dentro dos limites especificados
                                if (int.TryParse(idEstoque, out int idEstoqueInt))
                                {
                                    if (idCarne <= 99999 && idEstoqueInt <= 999999999)
                                    {
                                        // Insere ou atualiza o estoque atual na tabela ESTOQUE_ATUAL
                                        string queryInsertEstoqueAtual = "MERGE INTO ESTOQUE_ATUAL e USING (SELECT :id_estoque AS ID_ESTOQUE_ATUAL, :id_carne AS ID_CARNE FROM DUAL) s " +
                                                                         "ON (e.ID_CARNE = s.ID_CARNE) " +
                                                                         "WHEN MATCHED THEN UPDATE SET e.ID_ESTOQUE_ATUAL = s.ID_ESTOQUE_ATUAL " +
                                                                         "WHEN NOT MATCHED THEN INSERT (ID_ESTOQUE_ATUAL, ID_CARNE) VALUES (s.ID_ESTOQUE_ATUAL, s.ID_CARNE)";
                                        using (OracleCommand cmdInsertEstoqueAtual = new OracleCommand(queryInsertEstoqueAtual, con))
                                        {
                                            cmdInsertEstoqueAtual.Parameters.Add(new OracleParameter("id_estoque", OracleDbType.Int32) { Value = idEstoqueInt });
                                            cmdInsertEstoqueAtual.Parameters.Add(new OracleParameter("id_carne", OracleDbType.Int32) { Value = idCarne });
                                            cmdInsertEstoqueAtual.ExecuteNonQuery();
                                        }

                                        // Seleciona ID_ESTOQUE_ATUAL da tabela ESTOQUE_ATUAL para exibir na mensagem
                                        string querySelectEstoqueAtual = "SELECT ID_ESTOQUE_ATUAL FROM ESTOQUE_ATUAL WHERE ID_CARNE = :id_carne";
                                        using (OracleCommand cmdSelectEstoqueAtual = new OracleCommand(querySelectEstoqueAtual, con))
                                        {
                                            cmdSelectEstoqueAtual.Parameters.Add(new OracleParameter("id_carne", idCarne));
                                            OracleDataReader readerEstoqueAtual = cmdSelectEstoqueAtual.ExecuteReader();
                                            if (readerEstoqueAtual.Read())
                                            {
                                                int idEstoqueAtual = readerEstoqueAtual.GetInt32(0);
                                                // Exibe a mensagem com as informações registradas
                                                MessageBox.Show("Estoque Atualizado");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Erro ao confirmar o registro na tabela ESTOQUE_ATUAL.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Valores de ID_CARNE ou ID_ESTOQUE fora dos limites permitidos.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("ID_ESTOQUE inválido.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Carne ou estoque não encontrado na tabela ARMAZENA.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Carne não encontrada.");
                    }
                }
            }
        }

        private void cobSelecionarCarne_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarIdEstoque();

        }
        private void CarregarIdEstoque()
        {
            if (cobSelecionarCarne.SelectedItem != null)
            {
                string carneSelecionada = cobSelecionarCarne.SelectedItem.ToString();
                                
                using (OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    a.ID_ESTOQUE AS ""ID Estoque""
                FROM 
                    CARNE c
                JOIN 
                    ARMAZENA a ON c.ID_CARNE = a.ID_CARNE
                WHERE 
                    c.NOME = :nomeCarne
                ORDER BY 
                    a.ID_ESTOQUE";

                    using (OracleCommand command = new OracleCommand(query, con))
                    {
                        command.Parameters.Add(new OracleParameter("nomeCarne", carneSelecionada));

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            cobId_estoque.DataSource = dataTable;
                            cobId_estoque.DisplayMember = "ID Estoque";
                            cobId_estoque.ValueMember = "ID Estoque";
                        }
                    }
                }
            }
            //else
            //{
            //    MessageBox.Show("Por favor, selecione uma carne.");
            //}
        }

        private void cobId_estoque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            cobSelecionarCarne.SelectedIndex = -1; // Desmarca a seleção do ComboBox
            cobId_estoque.SelectedIndex = -1;
        }


        private void btnDefinirLimeteEstoque_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDefinirNovoLimite.Text, out decimal novoValor))
            {
                try
                {
                    using (OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString))
                    {
                        con.Open();
                        AtualizarValorConfiguracao(con, 1, "LIMITE_ESTOQUE", novoValor); // Ajuste o ID e o nome conforme necessário
                        lblLimiteAtual.Text = $"Limite atual: {novoValor}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtDefinirNovoLimite.Clear();
        }
        private void AtualizarValorConfiguracao(OracleConnection con, int idConfiguracao, string nomeConfiguracao, decimal novoValor)
        {
            string queryAtualizacao = @"UPDATE CONFIGURACOES
                                SET VALOR_CONFIGURACAO = :novo_valor
                                WHERE ID_CONFIGURACAO = :id_configuracao AND NOME_CONFIGURACAO = :nome_configuracao";

            using (OracleCommand cmdAtualizacao = new OracleCommand(queryAtualizacao, con))
            {
                cmdAtualizacao.Parameters.Add(new OracleParameter("novo_valor", novoValor));
                cmdAtualizacao.Parameters.Add(new OracleParameter("id_configuracao", idConfiguracao));
                cmdAtualizacao.Parameters.Add(new OracleParameter("nome_configuracao", nomeConfiguracao));

                int rowsUpdated = cmdAtualizacao.ExecuteNonQuery();
                if (rowsUpdated > 0)
                {
                    MessageBox.Show("Valor da configuração atualizado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Configuração não encontrada ou valor inválido.");
                }
            }
        }

        private void fmConfiguracoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancelar o fechamento do formulário
            e.Cancel = true;
            // Opcional: Exibir uma mensagem para o usuário
            MessageBox.Show("Você não pode fechar esta janela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static ProjetoEstoque.fmInicial;

namespace ProjetoEstoque
{
    public partial class fmvisaoGeral : Form
    {        
        private Form form1; // Adicione uma referência ao Form1

        public fmvisaoGeral(Form form1)
        {
            InitializeComponent();
            this.form1 = form1; // Inicialize a referência ao Form1

            // Configurações do DataGridView
            dgdTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgdTabela.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgdTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdTabela.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

        }

        private void fmvisaoGeral_Load(object sender, EventArgs e)
        {
            //trocando de cor do background 
            this.BackColor = ColorTranslator.FromHtml("#3B5982");

            btnVoltar.BackColor = ColorTranslator.FromHtml("#3B5982");
            btnVoltar.ForeColor = ColorTranslator.FromHtml("#3B5982");
            btnVoltar.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982"); 


            // Configurações do botão recarregar
            btnRecarregar.FlatAppearance.BorderSize = 0; // Remove a borda
            btnRecarregar.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982"); // Remove a cor de fundo ao passar o mouse

            btnDeletar.FlatAppearance.BorderSize = 0; // Remove a borda
            btnDeletar.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnAdicionar.FlatAppearance.BorderSize = 0; // Remove a borda
            btnAdicionar.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            bntAtualizarCarne.FlatAppearance.BorderSize = 0; // Remove a borda
            bntAtualizarCarne.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnVisualizarVendas.FlatAppearance.BorderSize = 0; // Remove a borda
            btnVisualizarVendas.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnPesquisar.FlatAppearance.BorderSize = 0; // Remove a borda
            btnPesquisar.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnAtualizarPreco.FlatAppearance.BorderSize = 0; // Remove a borda
            btnAtualizarPreco.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnVoltarAtualizarCarne.FlatAppearance.BorderSize = 0; // Remove a borda
            btnVoltarAtualizarCarne.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnConsultarCarne.FlatAppearance.BorderSize = 0; // Remove a borda
            btnConsultarCarne.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnLimparCampus.FlatAppearance.BorderSize = 0; // Remove a borda
            btnLimparCampus.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnVoltarEstoque.FlatAppearance.BorderSize = 0; // Remove a borda
            btnVoltarEstoque.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnAdicionarEstoque.FlatAppearance.BorderSize = 0; // Remove a borda
            btnAdicionarEstoque.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnVoltarAdicionarCarne.FlatAppearance.BorderSize = 0; // Remove a borda
            btnVoltarAdicionarCarne.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnAdicionarCarne.FlatAppearance.BorderSize = 0; // Remove a borda
            btnAdicionarCarne.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnVoltarDeletarEstoque.FlatAppearance.BorderSize = 0; // Remove a borda
            btnVoltarDeletarEstoque.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnApagarRegistroEstoque.FlatAppearance.BorderSize = 0; // Remove a borda
            btnApagarRegistroEstoque.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnVoltarDeleteCarne.FlatAppearance.BorderSize = 0; // Remove a borda
            btnVoltarDeleteCarne.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            bntApagarRegistro.FlatAppearance.BorderSize = 0; // Remove a borda
            bntApagarRegistro.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnDeletarEstoque.FlatAppearance.BorderSize = 0; // Remove a borda
            btnDeletarEstoque.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnDeletarCarne.FlatAppearance.BorderSize = 0; // Remove a borda
            btnDeletarCarne.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnEstoque.FlatAppearance.BorderSize = 0; // Remove a borda
            btnEstoque.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");

            btnCarne.FlatAppearance.BorderSize = 0; // Remove a borda
            btnCarne.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3B5982");


            LoadData();
            // Chamar o método para carregar carnes no ComboBox ao carregar o formulário
            CarregarCarnesNoComboBox();
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta o Form2
            form1.Show(); // Mostra o Form1
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
                                cboCarnesEstoque.Items.Add(reader["NOME"].ToString());
                                // Adiciona cada nome de carne ao ComboBox para apagar a carne
                                cobSelecaoApagar.Items.Add(reader["NOME"].ToString());
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

        private void LoadData()
        {
            try
            {
                string query = @" SELECT e.ID_ESTOQUE AS ""ID Estoque"", c.NOME AS ""Nome Carne"", c.TIPO AS ""Tipo Carne"", e.DATA_ADICAO AS ""Data Adicao"", e.QUANTIDADE_ADICIONADA AS ""Quantidade em Kg"", e.DATA_VALIDADE AS ""Data Validade"" FROM CARNE c JOIN ARMAZENA a ON c.ID_CARNE = a.ID_CARNE JOIN ESTOQUE e ON a.ID_ESTOQUE = e.ID_ESTOQUE ORDER BY e.DATA_VALIDADE, c.NOME ";

                using (OracleConnection conn = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    OracleDataAdapter da = new OracleDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgdTabela.DataSource = dt;

                    // Adicione um MessageBox para verificar se o DataTable está preenchido
                    //if (dt.Rows.Count > 0) 
                    //{ 
                    //    MessageBox.Show($"Dados carregados com sucesso. Total de registros: {dt.Rows.Count}"); 
                    //} 
                    //else 
                    //{ 
                    //    MessageBox.Show("Nenhum dado encontrado."); 
                    //}

                    foreach (DataGridViewColumn column in dgdTabela.Columns)
                    {
                        column.Visible = true;
                    }

                    dgdTabela.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void fmvisaoGeral_FormClosing(object sender, FormClosingEventArgs e)
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

        private bool toggleFunction = false; // Variável para controlar a alternância
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (toggleFunction)
            {
                FunctionOne();
            }
            else
            {
                FunctionTwo();
            }

            // Alterna o valor da variável boolean para a próxima chamada
            toggleFunction = !toggleFunction;
        }

        private void FunctionOne()
        {
            gpCarneEstoque.Visible = false;
        }
        private void FunctionTwo()
        {
            gpCarneEstoque.Visible = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int idEstoque;
            if (int.TryParse(txtPesquisar.Text, out idEstoque))
            {
                PesquisarEstoquePorId(idEstoque);
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de estoque válido.");
            }
            txtPesquisar.Clear();
        }

        private void PesquisarEstoquePorId(int idEstoque)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    conn.Open();

                    // Consulta para obter os dados do estoque pelo ID
                    string query = @" SELECT e.ID_ESTOQUE, c.NOME AS NomeCarne, c.TIPO AS TipoCarne, e.QUANTIDADE_ADICIONADA, e.DATA_ADICAO, e.DATA_VALIDADE FROM ESTOQUE e JOIN ARMAZENA a ON e.ID_ESTOQUE = a.ID_ESTOQUE JOIN CARNE c ON a.ID_CARNE = c.ID_CARNE WHERE e.ID_ESTOQUE = :ID_ESTOQUE";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("ID_ESTOQUE", idEstoque));
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                // Exibir os resultados no DataGridView
                                dgdTabela.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("Estoque não encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar estoque: " + ex.Message);
            }
        }

        private void btnCarne_Click(object sender, EventArgs e)
        {
            dgdTabela.Visible = false;
            gpBotoesAdicionar.Visible = false;
            gpCarneEstoque.Visible = false;
            gpAdicionarCarne.Visible = true;

        }

        private void btnVoltarAdicionarCarne_Click(object sender, EventArgs e)
        {
            dgdTabela.Visible = true;
            gpBotoesAdicionar.Visible = true;            
            toggleFunction = false;
            gpAdicionarCarne.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarCarne_Click(object sender, EventArgs e)
        {
            AdicionarCarne(Convert.ToInt32(txtCodigoCarne.Text), txtNomePeca.Text, txtTipoPeca.Text, Convert.ToDecimal(txtPreco.Text)); 
            txtCodigoCarne.Clear(); 
            txtNomePeca.Clear(); 
            txtTipoPeca.Clear(); 
            txtPreco.Clear();
        }

        private void AdicionarCarne(int idCarne, string nome, string tipo, decimal preco)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    conn.Open();

                    // Obter o ID máximo existente na tabela CARNE
                    int novoIdCarne;
                    using (OracleCommand cmd = new OracleCommand("SELECT COALESCE(MAX(ID_CARNE), 0) + 1 FROM CARNE", conn))
                    {
                        novoIdCarne = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Inserir nova carne na tabela CARNE
                    using (OracleCommand cmd = new OracleCommand("INSERT INTO CARNE (ID_CARNE, NOME, TIPO, PRECO) VALUES (:ID_CARNE, :NOME, :TIPO, :PRECO)", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("ID_CARNE", idCarne)); 
                        cmd.Parameters.Add(new OracleParameter("NOME", nome)); 
                        cmd.Parameters.Add(new OracleParameter("TIPO", tipo)); 
                        cmd.Parameters.Add(new OracleParameter("PRECO", preco)); 
                        
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Carne adicionada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar carne: " + ex.Message);
            }
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            dgdTabela.Visible = false;
            gpBotoesAdicionar.Visible = false;
            gpCarneEstoque.Visible = false;
            gpEstoque.Visible = true;
        }

        private void btnVoltarEstoque_Click(object sender, EventArgs e)
        {
            dgdTabela.Visible = true;
            gpBotoesAdicionar.Visible = true;            
            toggleFunction = false;
            gpEstoque.Visible = false;
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            int idEstoque, quantidade;
            DateTime dataValidade;

            if (int.TryParse(txtId_estoque.Text, out idEstoque) && int.TryParse(txtQuantidadeEstoque.Text, out quantidade) && DateTime.TryParse(txtDatavalidadeEstoque.Text, out dataValidade))
            {
                AdicionarEstoque(idEstoque, cboCarnesEstoque.SelectedItem.ToString(), quantidade, DateTime.Now, dataValidade);
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos.");
            }
            txtId_estoque.Clear();
            cboCarnesEstoque.SelectedIndex = -1; // Desmarca a seleção do ComboBox
            txtQuantidadeEstoque.Clear();
            txtDatavalidadeEstoque.Clear();
        }

        private void AdicionarEstoque(int idEstoque, string nomeCarne, int quantidadeAdicionada, DateTime dataAdicao, DateTime dataValidade)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    conn.Open();

                    // Obter o ID_CARNE correspondente ao nome da carne selecionado
                    int idCarne;
                    using (OracleCommand cmd = new OracleCommand("SELECT ID_CARNE FROM CARNE WHERE NOME = :NOME", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("NOME", nomeCarne));
                        idCarne = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Inserir novo estoque na tabela ESTOQUE
                    using (OracleCommand cmd = new OracleCommand("INSERT INTO ESTOQUE (ID_ESTOQUE, QUANTIDADE_ADICIONADA, DATA_ADICAO, DATA_VALIDADE) VALUES (:ID_ESTOQUE, :QUANTIDADE_ADICIONADA, :DATA_ADICAO, :DATA_VALIDADE)", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("ID_ESTOQUE", idEstoque));
                        cmd.Parameters.Add(new OracleParameter("QUANTIDADE_ADICIONADA", quantidadeAdicionada));
                        cmd.Parameters.Add(new OracleParameter("DATA_ADICAO", dataAdicao));
                        cmd.Parameters.Add(new OracleParameter("DATA_VALIDADE", dataValidade));

                        cmd.ExecuteNonQuery();
                    }

                    // Atualizar a tabela ARMAZENA para vincular o novo estoque com a carne existente
                    using (OracleCommand cmd = new OracleCommand("INSERT INTO ARMAZENA (ID_CARNE, ID_ESTOQUE) VALUES (:ID_CARNE, :ID_ESTOQUE)", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("ID_CARNE", idCarne));
                        cmd.Parameters.Add(new OracleParameter("ID_ESTOQUE", idEstoque));
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Estoque adicionado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar estoque: " + ex.Message);
            }
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private bool toggleFunctionDeletar = false; // Variável para controlar a alternância
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (toggleFunctionDeletar)
            {
                FunctionOneDeletar();
            }
            else
            {
                FunctionTwoDeletar();
            }

            // Alterna o valor da variável boolean para a próxima chamada
            toggleFunctionDeletar = !toggleFunctionDeletar;
        }

        private void FunctionOneDeletar()
        {
            gpDeletarCarneEstoque.Visible = false;
        }
        private void FunctionTwoDeletar()
        {
            gpDeletarCarneEstoque.Visible = true;
        }

        private void btnDeletarCarne_Click(object sender, EventArgs e)
        {
            dgdTabela.Visible = false;
            gpDeletarCarneEstoque.Visible = false;
            gpDeletarCarne.Visible = true;
            gpBotoesAdicionar.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgdTabela.Visible = true;
            toggleFunctionDeletar = false;
            gpDeletarCarne.Visible = false;
            gpBotoesAdicionar.Visible = true;
        }

        private void bntApagarRegistro_Click(object sender, EventArgs e)
        {
            if (cobSelecaoApagar.SelectedItem != null)
            {
                string nomeCarne = cobSelecaoApagar.SelectedItem.ToString();
                ApagarCarne(nomeCarne);

                // Limpar o ComboBox após apagar a carne
                cobSelecaoApagar.SelectedIndex = -1;

                // Recarregar a lista de carnes no ComboBox
                cobSelecaoApagar.Items.Clear();
                CarregarCarnesNoComboBox();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma carne para apagar.");
            }
        }

        private void ApagarCarne(string nomeCarne)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    conn.Open();

                    // Verificar se há registros associados que impedem a exclusão
                    string checkQuery = @" SELECT COUNT(*) FROM ARMAZENA a WHERE a.ID_CARNE = (SELECT ID_CARNE FROM CARNE WHERE NOME = :NOME) UNION ALL SELECT COUNT(*) FROM VENDIDO v WHERE v.ID_CARNE = (SELECT ID_CARNE FROM CARNE WHERE NOME = :NOME)";

                    int relatedRecords;
                    using (OracleCommand cmd = new OracleCommand(checkQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("NOME", nomeCarne));
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            relatedRecords = 0; while (reader.Read())
                            {
                                relatedRecords += reader.GetInt32(0);
                            }
                        }
                    }

                    if (relatedRecords > 0)
                    {
                        MessageBox.Show("Não é possível excluir esta carne porque está associada a estoques ou vendas.");
                        return;
                    }

                    // Apagar o registro da tabela CARNE
                    using (OracleCommand cmd = new OracleCommand("DELETE FROM CARNE WHERE NOME = :NOME", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("NOME", nomeCarne));
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Carne apagada com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Carne não encontrada.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar carne: " + ex.Message);
            }
        }

        private void btnDeletarEstoque_Click(object sender, EventArgs e)
        {
            dgdTabela.Visible = false;
            gpDeletarCarneEstoque.Visible = false;
            gpDeletarEstoque.Visible = true;
            gpBotoesAdicionar.Visible = false;
        }

        private void btnVoltarDeletarEstoque_Click(object sender, EventArgs e)
        {
            dgdTabela.Visible = true;
            gpDeletarCarneEstoque.Visible = true;
            gpDeletarEstoque.Visible = false;
            gpBotoesAdicionar.Visible = true;
        }

        private void btnApagarRegistroEstoque_Click(object sender, EventArgs e)
        {
            int idEstoque;
            if (int.TryParse(txtID_estoqueDeletar.Text, out idEstoque))
            {
                ApagarEstoque(idEstoque);

                // Limpar o campo após apagar o estoque
                txtID_estoqueDeletar.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de estoque válido.");
            }
        }

        private void ApagarEstoque(int idEstoque)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    conn.Open();

                    using (OracleTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Apagar registros dependentes na tabela ARMAZENA
                            using (OracleCommand cmd = new OracleCommand("DELETE FROM ARMAZENA WHERE ID_ESTOQUE = :ID_ESTOQUE", conn))
                            {
                                cmd.Parameters.Add(new OracleParameter("ID_ESTOQUE", idEstoque));
                                cmd.ExecuteNonQuery();
                            }

                            // Apagar o registro da tabela ESTOQUE
                            using (OracleCommand cmd = new OracleCommand("DELETE FROM ESTOQUE WHERE ID_ESTOQUE = :ID_ESTOQUE", conn))
                            {
                                cmd.Parameters.Add(new OracleParameter("ID_ESTOQUE", idEstoque));
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Registro do estoque apagado com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Registro de estoque não encontrado.");
                                }
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Erro ao apagar estoque: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar estoque: " + ex.Message);
            }
        }

        private void btnVisualizarVendas_Click(object sender, EventArgs e)
        {
            fmVendas form1 = new fmVendas (this); // Crie uma nova instância do Form2 // Passe o Form1 como referência para o Form2
            form1.Show(); // Mostre o Form2
            this.Hide(); // Opcional: Esconda o Form1
        }

        private void dgdTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarCarne_Click(object sender, EventArgs e)
        {
            // Obtém o ID_CARNE do TextBox
            string idCarne = txtId_codigoCArneAtualizar.Text;

            if (!string.IsNullOrEmpty(idCarne))
            {
                ConsultarCarne(idCarne);
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de Carne válido.");
            }
        }

        private void ConsultarCarne(string idCarne)
        {            
            using (OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString))
            {
                con.Open();

                // Consulta SQL para obter os detalhes da carne
                string queryCarne = @"
            SELECT 
                NOME, 
                TIPO, 
                PRECO 
            FROM 
                CARNE 
            WHERE 
                ID_CARNE = :id_carne";

                using (OracleCommand cmdCarne = new OracleCommand(queryCarne, con))
                {
                    cmdCarne.Parameters.Add(new OracleParameter("id_carne", idCarne));
                    OracleDataReader readerCarne = cmdCarne.ExecuteReader();
                    if (readerCarne.Read())
                    {
                        // Atualiza os labels com os valores obtidos da consulta
                        lblNomeCarne.Text = readerCarne["NOME"].ToString();
                        lblTipoCarne.Text = readerCarne["TIPO"].ToString();
                        lblprecoCarneAntigo.Text = Convert.ToDecimal(readerCarne["PRECO"]).ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Carne não encontrada.");
                    }
                }
            }
        }

        private void bntAtualizarCarne_Click(object sender, EventArgs e)
        {
            dgdTabela.Visible = false;
            gpBotoesAdicionar.Visible = false;
            gpCarneEstoque.Visible = false;
            gpAtualizarCarne.Visible = true;
        }

        private void btnVoltarAtualizarCarne_Click(object sender, EventArgs e)
        {
            dgdTabela.Visible = true;
            gpBotoesAdicionar.Visible = true;
            gpAtualizarCarne.Visible = false;
        }

        private void btnLimparCampus_Click(object sender, EventArgs e)
        {
            txtId_codigoCArneAtualizar.Clear();
            lblNomeCarne.Text = "";
            lblTipoCarne.Text = "";
            lblprecoCarneAntigo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void gpAtulizarInformacoes_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtualizarPreco_Click(object sender, EventArgs e)
        {
            // Obtém o ID_CARNE e o novo preço dos TextBoxes
            string idCarne = txtId_codigoCArneAtualizar.Text;
            string precoAtualizadoString = txtprecoAtualizado.Text;

            if (!string.IsNullOrEmpty(idCarne) && !string.IsNullOrEmpty(precoAtualizadoString))
            {
                if (decimal.TryParse(precoAtualizadoString, out decimal precoAtualizado))
                {
                    AtualizarPrecoCarne(idCarne, precoAtualizado);
                }
                else
                {
                    MessageBox.Show("Por favor, insira um valor válido para o preço.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de Carne e um preço válido.");
            }
            txtprecoAtualizado.Clear();
        }

        private void AtualizarPrecoCarne(string idCarne, decimal precoAtualizado)
        {            
            using (OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString))
            {
                con.Open();

                // Consulta SQL para atualizar o preço da carne
                string queryAtualizarPreco = @"
            UPDATE 
                CARNE 
            SET 
                PRECO = :preco_atualizado 
            WHERE 
                ID_CARNE = :id_carne";

                using (OracleCommand cmdAtualizarPreco = new OracleCommand(queryAtualizarPreco, con))
                {
                    cmdAtualizarPreco.Parameters.Add(new OracleParameter("preco_atualizado", precoAtualizado));
                    cmdAtualizarPreco.Parameters.Add(new OracleParameter("id_carne", idCarne));

                    int rowsAffected = cmdAtualizarPreco.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Preço da carne atualizado com sucesso!");

                        // Opcional: Atualizar os labels com o novo preço
                        lblprecoCarneAntigo.Text = precoAtualizado.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("ID da carne não encontrado.");
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void AtualizarCarne(string idCarne, string novoNome, string novoTipo, decimal novoPreco)
        {            
            using (OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString))
            {
                con.Open();

                // Consulta SQL para atualizar os dados da carne
                string queryAtualizarCarne = @"
            UPDATE 
                CARNE 
            SET 
                NOME = :novo_nome, 
                TIPO = :novo_tipo, 
                PRECO = :novo_preco 
            WHERE 
                ID_CARNE = :id_carne";

                using (OracleCommand cmdAtualizarCarne = new OracleCommand(queryAtualizarCarne, con))
                {
                    cmdAtualizarCarne.Parameters.Add(new OracleParameter("novo_nome", novoNome));
                    cmdAtualizarCarne.Parameters.Add(new OracleParameter("novo_tipo", novoTipo));
                    cmdAtualizarCarne.Parameters.Add(new OracleParameter("novo_preco", novoPreco));
                    cmdAtualizarCarne.Parameters.Add(new OracleParameter("id_carne", idCarne));

                    int rowsAffected = cmdAtualizarCarne.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dados da carne atualizados com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("ID da carne não encontrado.");
                    }
                }
            }
        }

        private void gpConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void lblNomePeca_Click(object sender, EventArgs e)
        {

        }
    }
}

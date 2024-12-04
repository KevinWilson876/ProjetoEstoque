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
    public partial class fmVendas : Form
    {        
        private Form form1; // Adicione uma referência ao Form1
        public fmVendas(Form form1)
        {
            InitializeComponent();
            this.form1 = form1; // Inicialize a referência ao Form1

            // Configurações do DataGridView
            dgdTabelaVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgdTabelaVendas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgdTabelaVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdTabelaVendas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        }
        private void vendas_Load(object sender, EventArgs e)
        {
            //trocando de cor do background 
            this.BackColor = ColorTranslator.FromHtml("#b3bac4");

            btnVoltarVendas.BackColor = ColorTranslator.FromHtml("#b3bac4");
            btnVoltarVendas.ForeColor = ColorTranslator.FromHtml("#b3bac4");

            btnDeletarVenda.FlatAppearance.BorderSize = 0; // Remove a borda
            btnDeletarVenda.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"
SELECT 
    v.ID_VENDA AS ""ID Venda"",
    c.NOME AS ""Nome Carne"",
    c.TIPO AS ""Tipo Carne"",
    v.PESO AS ""Peso Vendido"",
    v.PRECO_TOTAL AS ""Preço Total"",
    v.DATA_VENDA AS ""Data Venda"",
    v.ID_ESTOQUE AS ""ID Estoque""
FROM 
    VENDA v
JOIN 
    VENDIDO vd ON v.ID_VENDA = vd.ID_VENDA
JOIN 
    CARNE c ON vd.ID_CARNE = c.ID_CARNE
ORDER BY 
    v.DATA_VENDA, v.ID_VENDA";


                using (OracleConnection conn = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    OracleDataAdapter da = new OracleDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgdTabelaVendas.DataSource = dt;

                    // Adicione um MessageBox para verificar se o DataTable está preenchido
                    //if (dt.Rows.Count > 0) 
                    //{ 
                    //    MessageBox.Show($"Dados carregados com sucesso. Total de registros: {dt.Rows.Count}"); 
                    //} 
                    //else 
                    //{ 
                    //    MessageBox.Show("Nenhum dado encontrado."); 
                    //}

                    foreach (DataGridViewColumn column in dgdTabelaVendas.Columns)
                    {
                        column.Visible = true;
                    }

                    dgdTabelaVendas.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btnVoltarVendas_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta o Form2
            form1.Show(); // Mostra o Form1
        }

        private void dgdTabelaVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletarVenda_Click(object sender, EventArgs e)
        {
            string vendaID = txtID_vendaeletar.Text;
            string estoqueID = txtID_Estoque.Text;

            if (!string.IsNullOrEmpty(vendaID) && !string.IsNullOrEmpty(estoqueID))
            {                
                using (OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString))
                {
                    con.Open();

                    // Inicia uma transação
                    using (OracleTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            OracleCommand command = con.CreateCommand();
                            command.Transaction = transaction;

                            // Verificar se o ID de venda existe na tabela VENDA
                            command.CommandText = "SELECT COUNT(*) FROM VENDA WHERE ID_VENDA = :id_venda";
                            command.Parameters.Clear();
                            command.Parameters.Add(new OracleParameter("id_venda", vendaID));
                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count > 0)
                            {
                                // Recuperar o peso vendido e o ID do estoque
                                command.CommandText = @"
                            SELECT v.PESO, a.ID_ESTOQUE
                            FROM VENDA v
                            JOIN VENDIDO vd ON v.ID_VENDA = vd.ID_VENDA
                            JOIN ARMAZENA a ON vd.ID_CARNE = a.ID_CARNE
                            WHERE v.ID_VENDA = :id_venda AND a.ID_ESTOQUE = :id_estoque";
                                command.Parameters.Clear();
                                command.Parameters.Add(new OracleParameter("id_venda", vendaID));
                                command.Parameters.Add(new OracleParameter("id_estoque", estoqueID));
                                OracleDataReader reader = command.ExecuteReader();
                                if (reader.Read())
                                {
                                    decimal pesoVendido = reader.GetDecimal(0);
                                    string idEstoque = reader.GetString(1);

                                    // Verificar que o ID do estoque é o correto
                                    if (idEstoque == estoqueID)
                                    {
                                        // Deletar da tabela VENDIDO
                                        command.CommandText = "DELETE FROM VENDIDO WHERE ID_VENDA = :id_venda AND ID_CARNE IN (SELECT ID_CARNE FROM ARMAZENA WHERE ID_ESTOQUE = :id_estoque)";
                                        command.Parameters.Clear();
                                        command.Parameters.Add(new OracleParameter("id_venda", vendaID));
                                        command.Parameters.Add(new OracleParameter("id_estoque", estoqueID));
                                        command.ExecuteNonQuery();

                                        // Deletar da tabela VENDA
                                        command.CommandText = "DELETE FROM VENDA WHERE ID_VENDA = :id_venda";
                                        command.Parameters.Clear();
                                        command.Parameters.Add(new OracleParameter("id_venda", vendaID));
                                        command.ExecuteNonQuery();

                                        // Atualizar a quantidade no estoque correto
                                        command.CommandText = "UPDATE ESTOQUE SET QUANTIDADE_ADICIONADA = QUANTIDADE_ADICIONADA + :peso WHERE ID_ESTOQUE = :id_estoque";
                                        command.Parameters.Clear();
                                        command.Parameters.Add(new OracleParameter("peso", pesoVendido));
                                        command.Parameters.Add(new OracleParameter("id_estoque", idEstoque));
                                        command.ExecuteNonQuery();

                                        // Confirma a transação
                                        transaction.Commit();

                                        MessageBox.Show("Registro deletado com sucesso e quantidade devolvida ao estoque correto!");
                                        LoadData();
                                    }
                                    else
                                    {
                                        MessageBox.Show("O ID do estoque não corresponde ao estoque da venda.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao recuperar informações da venda.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("ID de venda não encontrado.");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Reverte a transação em caso de erro
                            transaction.Rollback();
                            MessageBox.Show($"Erro ao deletar o registro: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de venda e um ID de estoque válido.");
            }
            txtID_vendaeletar.Clear();
            txtID_Estoque.Clear();
        }

        private void fmVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancelar o fechamento do formulário
            e.Cancel = true;
            // Opcional: Exibir uma mensagem para o usuário
            MessageBox.Show("Você não pode fechar esta janela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

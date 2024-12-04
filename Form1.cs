using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; // Adicionar esta linha para usar a classe Color
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // Importa a biblioteca necessária para reprodução de som
using System.Diagnostics;
using System.Runtime.InteropServices;
using Oracle.ManagedDataAccess;

namespace ProjetoEstoque
{
    public partial class fmInicial : Form
    {        
        public fmInicial()
        {
            InitializeComponent();

            this.KeyPreview = true; // Permite que o formulário capture eventos de teclado
            this.KeyDown += new KeyEventHandler(fmInicial_KeyDown); // Adiciona o evento KeyDown

            _textBox = txtLeitorTeste; // Substituído pelo nome do seu TextBox
            SetHook(_proc); // Passa o delegate ao definir o hook
                       
        }

        public static class GlobalVariables
        {
            public static string ConnectionString { get; set; } = "User Id=KEVIN;Password=64002488;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //trocando de cor do background 
            this.BackColor = ColorTranslator.FromHtml("#b3bac4");

            //BarraSuperior superior
            plBarraSuperior.BackColor = ColorTranslator.FromHtml("#3b5982");

            //TituloControleEstoque
            lblTituloControleEstoque.Font = new Font("Arial", 20, FontStyle.Bold);
            lblTituloControleEstoque.ForeColor = Color.White;

            //Cor dos botoes das bordas
            btnRelatorios.BackColor = ColorTranslator.FromHtml("#b3bac4");
            btnRelatorios.ForeColor = ColorTranslator.FromHtml("#b3bac4");
            btnRelatorios.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            btnConfig.BackColor = ColorTranslator.FromHtml("#b3bac4");
            btnConfig.ForeColor = ColorTranslator.FromHtml("#b3bac4");
            btnConfig.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            btnVisaoGeral.BackColor = ColorTranslator.FromHtml("#b3bac4");
            btnVisaoGeral.ForeColor = ColorTranslator.FromHtml("#b3bac4");
            btnVisaoGeral.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");

            btnIniciarServico.BackColor = ColorTranslator.FromHtml("#b3bac4");
            btnIniciarServico.FlatAppearance.BorderSize = 0; // Remove a borda
            btnIniciarServico.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#b3bac4");
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam); // Delegate para o hook do teclado
        
        private LowLevelKeyboardProc _proc;     // Callback do hook do teclado
        private IntPtr _hookID = IntPtr.Zero;   // TextBox usado para exibir a saída
        private TextBox _textBox;

        private bool botaoServico = false; // Variável para controlar a alternância

        private void btnIniciarServico_Click(object sender, EventArgs e)
        {
            if (botaoServico)
            {
                FunctionOne();
            }
            else
            {
                FunctionTwo();
            }
            // Alterna o valor da variável boolean para a próxima chamada
            botaoServico = !botaoServico;
        }

        private void FunctionOne()
        {
            btnIniciarServico.Text = "Iniciar Serviço";
            UnhookWindowsHookEx(_hookID); // Remove o hook de teclado global
        }

        private void FunctionTwo()
        {
            _proc = HookCallback; // Inicializa o delegate do hook do teclado
            btnIniciarServico.Text = "Finalizar Serviço";

            // Minimiza o formulário
            this.WindowState = FormWindowState.Minimized;

            // Define a ação de clique no NotifyIcon
            notifyIcon.Click += new EventHandler(notifyIcon_Click_1);

            // Exibe o NotifyIcon na bandeja do sistema
            notifyIcon.Visible = true;

            // Configura o hook de teclado global
            _hookID = SetHook(_proc);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;

                // Converte as teclas do teclado numérico para seus equivalentes de dígitos
                if (key >= Keys.NumPad0 && key <= Keys.NumPad9)
                {
                    key = key - Keys.NumPad0 + Keys.D0; // Converte Keys.NumPad0 a Keys.NumPad9 para Keys.D0 a Keys.D9
                }

                // Adiciona condição para a tecla Enter
                if (key == Keys.Enter)
                {
                    // Crie os argumentos para o evento KeyPress
                    char keyChar = '\r'; // Representa a tecla Enter
                    KeyPressEventArgs args = new KeyPressEventArgs(keyChar);

                    // Chama o método txtLeitorTeste_KeyPress
                    this.Invoke(new Action(() => txtLeitorTeste_KeyPress(_textBox, args)));
                }
                else
                {
                    this.Invoke(new Action(() => _textBox.Text += key.ToString().Replace("D", "")));
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnhookWindowsHookEx(_hookID);
            base.OnFormClosing(e);
        }

        // Evento de clique no NotifyIcon para restaurar o formulário
        private void notifyIcon_Click_1(object sender, EventArgs e)
        {
            // Restaura o formulário
            this.WindowState = FormWindowState.Normal;

            // Oculta o NotifyIcon da bandeja do sistema
            notifyIcon.Visible = false;
        }        

        private void txtLeitorTeste_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla Enter foi pressionada
            if (e.KeyChar == (char)13)
            {
                string codigoBarras = txtLeitorTeste.Text;
                if (codigoBarras.Length == 12)
                {
                    // Separa o código de barras em ID_CARNE e preço total (ignorando os zeros do meio)
                    string idCarne = codigoBarras.Substring(0, 4).TrimStart('0'); // Primeiros 4 dígitos
                    string precoTotalString = codigoBarras.Substring(6, 6); // Últimos 6 dígitos
                    
                    // **Linha destacada: Converte os últimos 4 dígitos para o formato de preço com vírgula na terceira casa decimal**
                    decimal precoTotal = Convert.ToDecimal(precoTotalString.Insert(3, ",")); // Formato 3.989

                    ObterIdCarne(idCarne, precoTotal);
                }
                else
                {
                    MessageBox.Show("Código de barras inválido.");
                }
                txtLeitorTeste.Clear(); // Limpa o TextBox para a próxima leitura
            }
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            // Restaurar o formulário quando o ícone da bandeja for clicado
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void fmInicial_KeyDown(object sender, KeyEventArgs e)
        {
            //// Verifica se Ctrl+I foi pressionado
            //if (e.Control && e.KeyCode == Keys.I)
            //{
            //    if (botaoServico)
            //    {
            //        // Restaura o formulário
            //        this.WindowState = FormWindowState.Normal;
            //        notifyIcon.Visible = false; // Esconde o NotifyIcon
            //    }
            //}
        }
                    
        private void ObterIdCarne(string idCarne, decimal precoTotal)
        {            
            using (OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString))
            {
                con.Open();
                
                // Busca as informações da carne no banco de dados
                string queryCarne = "SELECT NOME, PRECO FROM CARNE WHERE ID_CARNE = :id_carne";
                using (OracleCommand cmdCarne = new OracleCommand(queryCarne, con))
                {
                    cmdCarne.Parameters.Add(new OracleParameter("id_carne", idCarne));
                    OracleDataReader readerCarne = cmdCarne.ExecuteReader();

                    if (readerCarne.Read())
                    {
                        string nomeCarne = readerCarne.GetString(0);
                        decimal precoPorQuilo = readerCarne.GetDecimal(1);
                        decimal peso = precoTotal / precoPorQuilo;

                        // Busca o ID_ESTOQUE_ATUAL da tabela ESTOQUE_ATUAL com base no ID_CARNE
                        string queryEstoque = "SELECT ID_ESTOQUE_ATUAL FROM ESTOQUE_ATUAL WHERE ID_CARNE = :id_carne";
                        using (OracleCommand cmdEstoque = new OracleCommand(queryEstoque, con))
                        {
                            cmdEstoque.Parameters.Add(new OracleParameter("id_carne", idCarne)); // Parâmetro para ID_CARNE
                            OracleDataReader readerEstoque = cmdEstoque.ExecuteReader();
                            if (readerEstoque.Read())
                            {
                                string idEstoque = readerEstoque.GetString(0);

                                // Gera um ID de venda único baseado em um valor menor
                                int idVenda = ObterProximoIdVenda();

                                //int idVenda = new Random().Next(1, 1000000);  // Gera um valor entre 1 e 999999

                                // Inicia uma transação
                                using (OracleTransaction transaction = con.BeginTransaction())
                                {
                                    try
                                    {
                                        // Insere um registro na tabela VENDA
                                        string queryVenda = "INSERT INTO VENDA (ID_VENDA, PESO, PRECO_TOTAL, DATA_VENDA, ID_ESTOQUE) " + "VALUES (:id_venda, :peso, :preco_total, SYSDATE, :id_estoque)"; 
                                        using (OracleCommand cmdVenda = new OracleCommand(queryVenda, con)) 
                                        { 
                                            cmdVenda.Transaction = transaction; 
                                            cmdVenda.Parameters.Add(new OracleParameter("id_venda", idVenda)); 
                                            cmdVenda.Parameters.Add(new OracleParameter("peso", peso)); 
                                            cmdVenda.Parameters.Add(new OracleParameter("preco_total", precoTotal)); 
                                            cmdVenda.Parameters.Add(new OracleParameter("id_estoque", idEstoque)); 
                                            cmdVenda.ExecuteNonQuery(); }

                                        // Insere um registro na tabela VENDIDO
                                        string queryVendido = "INSERT INTO VENDIDO (ID_VENDA, ID_CARNE) VALUES (:id_venda, :id_carne)";
                                        using (OracleCommand cmdVendido = new OracleCommand(queryVendido, con))
                                        {
                                            cmdVendido.Transaction = transaction;
                                            cmdVendido.Parameters.Add(new OracleParameter("id_venda", idVenda));
                                            cmdVendido.Parameters.Add(new OracleParameter("id_carne", idCarne));
                                            cmdVendido.ExecuteNonQuery();
                                        }

                                        // Atualiza a QUANTIDADE_ADICIONADA na tabela ESTOQUE
                                        string queryUpdateEstoque = "UPDATE ESTOQUE SET QUANTIDADE_ADICIONADA = QUANTIDADE_ADICIONADA - :peso WHERE ID_ESTOQUE = :id_estoque";
                                        using (OracleCommand cmdUpdateEstoque = new OracleCommand(queryUpdateEstoque, con))
                                        {
                                            cmdUpdateEstoque.Transaction = transaction;
                                            cmdUpdateEstoque.Parameters.Add(new OracleParameter("peso", peso));
                                            cmdUpdateEstoque.Parameters.Add(new OracleParameter("id_estoque", idEstoque));
                                            cmdUpdateEstoque.ExecuteNonQuery();
                                        }

                                        // Verifica a quantidade restante no estoque
                                        VerificarQuantidadeEstoque(con, idEstoque);

                                        // Confirma a transação
                                        transaction.Commit();

                                        // Reproduz um som após a conclusão da venda
                                        PlaySuccessSound();

                                        // Exibe a mensagem com o ID_CARNE, nome da carne, ID_ESTOQUE_ATUAL, peso e preço total
                                        //MessageBox.Show($"ID da Carne: {idCarne}\nNome da Carne: {nomeCarne}\nID do Estoque Atual: {idEstoque}\nPeso: {peso:F3} kg\nPreço Total: R$ {precoTotal:F2}\n\nVenda registrada com sucesso!");
                                    }
                                    catch (Exception ex)
                                    {
                                        // Reverte a transação em caso de erro
                                        transaction.Rollback();
                                        MessageBox.Show($"Erro ao registrar a venda: {ex.Message}");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Estoque atual não encontrado.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Carne não encontrada.");
                    }

                }
                //con.Close();
            }
           
        }

        private void VerificarQuantidadeEstoque(OracleConnection con, string idEstoque)
        {
            // Obter o valor de configuração desejado pelo ID
            int idConfiguracao = 1; // ID da configuração desejada
            decimal limiteQuantidade = ObterValorConfiguracaoPorID(con, idConfiguracao);

            string queryQuantidade = @"
        SELECT c.NOME, e.QUANTIDADE_ADICIONADA, e.ID_ESTOQUE 
        FROM ESTOQUE e
        JOIN ARMAZENA a ON e.ID_ESTOQUE = a.ID_ESTOQUE
        JOIN CARNE c ON a.ID_CARNE = c.ID_CARNE
        WHERE e.ID_ESTOQUE = :id_estoque";
            using (OracleCommand cmdQuantidade = new OracleCommand(queryQuantidade, con))
            {
                cmdQuantidade.Parameters.Add(new OracleParameter("id_estoque", idEstoque));
                OracleDataReader readerQuantidade = cmdQuantidade.ExecuteReader();

                if (readerQuantidade.Read())
                {
                    string nomeCarne = readerQuantidade.GetString(0);
                    decimal quantidadeAdicionada = readerQuantidade.GetDecimal(1);
                    string idEstoqueRecuperado = readerQuantidade.GetString(2);
                    if (quantidadeAdicionada < limiteQuantidade) // Verifica se a quantidade é menor que o limite desejado
                    {
                        string mensagem = $"Atenção: Quantidade de {nomeCarne} no estoque (ID: {idEstoqueRecuperado}) está baixa. Restam apenas {quantidadeAdicionada} Kg.";
                        NotificarBalao(mensagem);
                    }
                }
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

        private void NotificarBalao(string mensagem)
        {
            notifyIcon.ShowBalloonTip(5000, "Sistema de Estoque", mensagem, ToolTipIcon.Warning);
        }
        
        private void NotificarBalaoData(string mensagem)
        {
            notifyIcon.ShowBalloonTip(5000, "Sistema de Estoque", mensagem, ToolTipIcon.Warning);
        }

        // Variável estática para armazenar o último ID de venda gerado
        private static int ultimoIdVenda = 0;
        private int ObterProximoIdVenda()
        {
            // Implementação para obter próximo ID de venda manualmente         
            using (OracleConnection con = new OracleConnection(GlobalVariables.ConnectionString))
            {
                con.Open();
                string query = "SELECT NVL(MAX(ID_VENDA), 0) + 1 FROM VENDA";
                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }               

        private void btnConfig_Click(object sender, EventArgs e)
        {
            fmConfiguracoes form3 = new fmConfiguracoes(this); // Crie uma nova instância do Form3 // Passe o Form1 como referência para o Form2
            form3.Show(); // Mostre o Form3
            this.Hide(); // Opcional: Esconda o Form1
        }

        // Método para reproduzir o som de sucesso
        private void PlaySuccessSound() 
        {
            try
            {
                // Caminho do arquivo de som (ajuste conforme necessário)
                string soundFilePath = @".\somCopia.wav";
                SoundPlayer player = new SoundPlayer(soundFilePath);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao reproduzir o som: {ex.Message}");
            }
        }
                             
        private void btnVisaoGeral_Click(object sender, EventArgs e)
        {
            fmvisaoGeral form2 = new fmvisaoGeral(this); // Crie uma nova instância do Form2 // Passe o Form1 como referência para o Form2
            form2.Show(); // Mostre o Form2
            this.Hide(); // Opcional: Esconda o Form1
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            fmRelatorio relatorioVendasForm = new fmRelatorio(this);
            relatorioVendasForm.Show();
            this.Hide(); // Opcional: Esconda o Form1
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }
        private void lblTituloControleEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Pessoas_V.V.A.L.D.J
{
    public partial class FormEditarFuncionario : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=VVALDJ;User ID=root;Password=root;";
        private int funcionarioId;
        public FormEditarFuncionario(int id)
        {
            InitializeComponent();
            funcionarioId = id;  // Atribui o ID antes de carregar os dados
            CarregarDadosFuncionario(); // Chama o método após o ID ser definido
        }
        private void FormEditarFuncionario_Load(object sender, EventArgs e)
        {
            CarregarDadosFuncionario();

        }
        private void CarregarDadosFuncionario()
        {
            try
            {
                // Verifica se a conexão está nula ou fechada e a abre
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                }

                // Define a consulta para buscar os dados do funcionário pelo ID
                string query = "SELECT * FROM Funcionarios WHERE ID = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", funcionarioId);

                    // Executa a consulta e obtém os dados do funcionário
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preenche os campos de edição com os dados do funcionário
                            txtEditFuncionarioNome.Text = reader["Nome"].ToString();
                            txtEditFuncionarioCpf.Text = reader["CPF"].ToString();
                            txtEditFuncionarioEndereco.Text = reader["Endereco"].ToString();
                            dtpEditFuncionarioNascimento.Value = Convert.ToDateTime(reader["Nascimento"]);
                            dateEditFuncionarioAdmissao.Value = Convert.ToDateTime(reader["Admissao"]);
                            txtEditFuncionarioFuncao.Text = reader["Funcao"].ToString();
                            txtEditFuncionarioQualificacao.Text = reader["Qualificacao"].ToString();
                            txtEditFuncionarioSalarioInicial.Text = reader["SalarioInicial"].ToString();

                            // TODO: Preencher os radioButtons para "Situação"
                            string situacao = reader["Situacao"].ToString();
                            if (situacao == "Ativo")
                            {
                                rbEditFuncionarioStatusAtivo.Checked = true;
                            }
                            else if (situacao == "Desligado")
                            {
                                rbEditFuncionarioStatusDesligado.Checked = true;
                                lblAddFuncionarioDataDesligamentoAfastamento.Visible = true;
                                dtpEditFuncionarioDataDesligamentoAfastamento.Visible = true;
                                dtpEditFuncionarioDataDesligamentoAfastamento.Value = Convert.ToDateTime(reader["Desligamento"]);
                            }
                            else if (situacao == "Afastado")
                            {
                                rbEditFuncionarioStatusAfastado.Checked = true;
                                lblAddFuncionarioDataDesligamentoAfastamento.Visible = true;
                                dtpEditFuncionarioDataDesligamentoAfastamento.Visible = true;
                                dtpEditFuncionarioDataDesligamentoAfastamento.Value = Convert.ToDateTime(reader["Desligamento"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do funcionário: " + ex.Message);
            }
        }
        private void rbEditFuncionarioStatusAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEditFuncionarioStatusDesligado.Checked || rbEditFuncionarioStatusAfastado.Checked)
            {
                lblAddFuncionarioDataDesligamentoAfastamento.Visible = true;
                dtpEditFuncionarioDataDesligamentoAfastamento.Visible = true;
            }
            else
            {
                lblAddFuncionarioDataDesligamentoAfastamento.Visible = false;
                dtpEditFuncionarioDataDesligamentoAfastamento.Visible = false;
            }
        }

        private void txtEditFuncionarioQualificacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEditFuncionarioNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpEditFuncionarioDataDesligamentoAfastamento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddFuncionarioSalvar_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }

            try
            {
                // Coletando os dados dos controles
                var funcionarioId = this.funcionarioId;  // ID do funcionário a ser editado
                var funcionarioNome = txtEditFuncionarioNome.Text;
                var cpfFuncionario = txtEditFuncionarioCpf.Text;
                var Nascimento = dtpEditFuncionarioNascimento.Value;
                var endereco = txtEditFuncionarioEndereco.Text;
                var Admissao = dateEditFuncionarioAdmissao.Value;
                var funcao = txtEditFuncionarioFuncao.Text;
                var qualificacao = txtEditFuncionarioQualificacao.Text;
                var salarioInicial = Convert.ToDecimal(txtEditFuncionarioSalarioInicial.Text);
                var situacao = "";

                if (rbEditFuncionarioStatusAfastado.Checked)
                {
                    situacao = "Afastado";
                }
                else if (rbEditFuncionarioStatusAtivo.Checked)
                {
                    situacao = "Ativo";
                }
                else if (rbEditFuncionarioStatusDesligado.Checked)
                {
                    situacao = "Desligado";
                }

                // Data de desligamento ou afastamento, caso exista
                var dataDesligamentoAfastamento = dtpEditFuncionarioDataDesligamentoAfastamento.Visible ?
                                                  dtpEditFuncionarioDataDesligamentoAfastamento.Value :
                                                  (DateTime?)null;

                // Query SQL para atualizar os dados do funcionário
                string query = @"UPDATE Funcionarios 
                         SET Nome = @Nome, 
                             CPF = @CPF, 
                             Nascimento = @Nascimento, 
                             Endereco = @Endereco, 
                             Admissao = @Admissao, 
                             Funcao = @Funcao, 
                             Qualificacao = @Qualificacao, 
                             SalarioInicial = @SalarioInicial, 
                             Situacao = @Situacao, 
                             Desligamento = @Desligamento
                         WHERE ID = @ID";

                using (var command = new MySqlCommand(query, connection))
                {
                    // Adicionando os parâmetros ao comando SQL
                    command.Parameters.AddWithValue("@ID", funcionarioId);
                    command.Parameters.AddWithValue("@Nome", funcionarioNome);
                    command.Parameters.AddWithValue("@CPF", cpfFuncionario);
                    command.Parameters.AddWithValue("@Nascimento", Nascimento);
                    command.Parameters.AddWithValue("@Endereco", endereco);
                    command.Parameters.AddWithValue("@Admissao", Admissao);
                    command.Parameters.AddWithValue("@Funcao", funcao);
                    command.Parameters.AddWithValue("@Qualificacao", qualificacao);
                    command.Parameters.AddWithValue("@SalarioInicial", salarioInicial);
                    command.Parameters.AddWithValue("@Situacao", situacao);
                    command.Parameters.AddWithValue("@Desligamento",
                        (object)dataDesligamentoAfastamento ?? DBNull.Value);

                    // Executando a query para atualizar o funcionário
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Funcionário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar funcionário: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

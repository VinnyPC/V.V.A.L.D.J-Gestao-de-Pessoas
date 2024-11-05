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
    }
}

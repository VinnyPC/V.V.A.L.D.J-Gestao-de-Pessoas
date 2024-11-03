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
        private int funcionarioId;
        private MySqlConnection connection;
        public FormEditarFuncionario()
        {
            InitializeComponent();
            //rbAddFuncionarioStatusAtivo.CheckedChanged += RadioButton_CheckedChanged;
            //rbAddFuncionarioStatusDesligado.CheckedChanged += RadioButton_CheckedChanged;
            //rbAddFuncionarioStatusAfastado.CheckedChanged += RadioButton_CheckedChanged;


        }
        public FormEditarFuncionario(int id, MySqlConnection existingConnection)
        {
            InitializeComponent();
            funcionarioId = id;
            connection = existingConnection;
        }
        private void FormEditarFuncionario_Load(object sender, EventArgs e)
        {
            CarregarDadosFuncionario();
        }
        private void CarregarDadosFuncionario()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = "SELECT * FROM Funcionarios WHERE ID = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", funcionarioId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtEditFuncionarioNome.Text = reader["Nome"].ToString();
                            txtEditFuncionarioCpf.Text = reader["CPF"].ToString();
                            txtEditFuncionarioEndereco.Text = reader["Endereco"].ToString();
                            dtpEditFuncionarioNascimento.Text = reader["Nascimento"].ToString();
                            dateEditFuncionarioAdmissao.Text = reader["Admissao"].ToString();
                            txtEditFuncionarioFuncao.Text = reader["Funcao"].ToString();
                            txtEditFuncionarioQualificacao.Text = reader["Qualificacao"].ToString();
                            txtEditFuncionarioSalarioInicial.Text = reader["SalarioInicial"].ToString();
                            //TODO: radioButtons
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
    }
}

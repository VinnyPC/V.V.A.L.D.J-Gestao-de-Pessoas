namespace Gestão_de_Pessoas_V.V.A.L.D.J;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;

public partial class Form1 : Form
{
    private string connectionString = "Server=localhost;Database=VVALDJ;User ID=root;Password=root;";
    public Form1()
    {
        InitializeComponent();
        CarregarFuncionarios();
    }

    private void CarregarFuncionarios()
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Funcionarios", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["Id"].Visible = false; // Ocultar coluna ID, se necessário
        }
    }

    private void lblFuncionarios_Click(object sender, EventArgs e)
    {

    }

    private void lblFuncionariosQtd_Click(object sender, EventArgs e)
    {

    }

    private void lblFuncoes_Click(object sender, EventArgs e)
    {

    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}

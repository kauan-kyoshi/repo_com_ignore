using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LogiN
{
    public partial class TelaClientes : Form
    {
        int idSelecionado = 0;
        bool modoEdicao = false;

        public TelaClientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += TelaClientes_Load;
        }

        private void TelaClientes_Load(object sender, EventArgs e)
        {
            panelCadastroCliente.Visible = false;
            dgvClientes.Visible = true;

            ConfigurarGrid();
            CarregarClientes();
        }

        // ================= GRID =================
        private void ConfigurarGrid()
        {
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add("Id", "Id");
            dgvClientes.Columns["Id"].Visible = false;

            dgvClientes.Columns.Add("Nome", "Nome");
            dgvClientes.Columns.Add("CPF", "CPF");
            dgvClientes.Columns.Add("Telefone", "Telefone");

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.AllowUserToAddRows = false;
        }

        // ================= CARREGAR =================
        private void CarregarClientes()
        {
            dgvClientes.Rows.Clear();

            try
            {
                ConexaoC conexao = new ConexaoC();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    conn.Open();

                    string sql = "SELECT * FROM Clientes";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dgvClientes.Rows.Add(
                            reader["Id"],
                            reader["Nome"],
                            reader["CPF"],
                            reader["Telefone"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro REAL ao carregar:\n" + ex.ToString());
            }
        }

        // ================= NOVO =================
        private void btnNovoClienteC_Click(object sender, EventArgs e)
        {
            modoEdicao = false;

            txtNomeC.Clear();
            txtCPF.Clear();
            txtTelefoneC.Clear();

            dgvClientes.Visible = false;
            panelCadastroCliente.Visible = true;
            panelCadastroCliente.BringToFront();
        }

        // ================= EDITAR =================
        private void btnEditarC_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                modoEdicao = true;

                idSelecionado = Convert.ToInt32(
                    dgvClientes.SelectedRows[0].Cells["Id"].Value
                );

                txtNomeC.Text = dgvClientes.SelectedRows[0].Cells["Nome"].Value.ToString();
                txtCPF.Text = dgvClientes.SelectedRows[0].Cells["CPF"].Value.ToString();
                txtTelefoneC.Text = dgvClientes.SelectedRows[0].Cells["Telefone"].Value.ToString();

                dgvClientes.Visible = false;
                panelCadastroCliente.Visible = true;
                panelCadastroCliente.BringToFront();
            }
            else
            {
                MessageBox.Show("Selecione um cliente!");
            }
        }

        // ================= SALVAR =================
        private void btnSalvarC_Click(object sender, EventArgs e)
        {
            string nome = txtNomeC.Text;
            string cpf = txtCPF.Text;
            string telefone = txtTelefoneC.Text;

            if (!string.IsNullOrWhiteSpace(nome) &&
                !string.IsNullOrWhiteSpace(cpf) &&
                !string.IsNullOrWhiteSpace(telefone))
            {
                try
                {
                    ConexaoC conexao = new ConexaoC();

                    using (MySqlConnection conn = conexao.Conectar())
                    {
                        conn.Open();

                        if (!modoEdicao)
                        {
                            string sql = "INSERT INTO Clientes (Nome, CPF, Telefone) VALUES (@nome, @cpf, @tel)";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);

                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@cpf", cpf);
                            cmd.Parameters.AddWithValue("@tel", telefone);

                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string sql = "UPDATE Clientes SET Nome=@nome, CPF=@cpf, Telefone=@tel WHERE Id=@id";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);

                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@cpf", cpf);
                            cmd.Parameters.AddWithValue("@tel", telefone);
                            cmd.Parameters.AddWithValue("@id", idSelecionado);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    panelCadastroCliente.Visible = false;
                    dgvClientes.Visible = true;
                    dgvClientes.BringToFront();

                    CarregarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro REAL ao salvar:\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        // ================= EXCLUIR =================
        private void btnExcluirC_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(
                        dgvClientes.SelectedRows[0].Cells["Id"].Value
                    );

                    ConexaoC conexao = new ConexaoC();

                    using (MySqlConnection conn = conexao.Conectar())
                    {
                        conn.Open();

                        string sql = "DELETE FROM Clientes WHERE Id=@id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }

                    CarregarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro REAL ao excluir:\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente!");
            }
        }

        // ================= VOLTAR =================
        private void btnVoltarC_Click(object sender, EventArgs e)
        {
            panelCadastroCliente.Visible = false;
            dgvClientes.Visible = true;
            dgvClientes.BringToFront();
        }

        // ================= BUSCA =================
        private void txtBuscaC_TextChanged(object sender, EventArgs e)
        {
            string termo = txtBuscaC.Text.ToLower();

            foreach (DataGridViewRow linha in dgvClientes.Rows)
            {
                if (linha.IsNewRow) continue;

                string nome = linha.Cells["Nome"].Value?.ToString().ToLower() ?? "";
                string cpf = linha.Cells["CPF"].Value?.ToString().ToLower() ?? "";
                string telefone = linha.Cells["Telefone"].Value?.ToString().ToLower() ?? "";

                linha.Visible =
                    nome.Contains(termo) ||
                    cpf.Contains(termo) ||
                    telefone.Contains(termo);
            }
        }

        // ================= NAVEGAÇÃO =================
        private void btnEstoqueC_Click(object sender, EventArgs e)
        {
            new TelaEstoque().Show();
            this.Hide();
        }

        private void btnServicosC_Click(object sender, EventArgs e)
        {
            new TelaServicos().Show();
            this.Hide();
        }

        private void btnPedidosC_Click(object sender, EventArgs e)
        {
            new TelaPedidos().Show();
            this.Hide();
        }
    }
}
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LogiN
{
    public partial class TelaEstoque : Form
    {
        int idSelecionado = 0;
        bool modoEdicao = false;

        public TelaEstoque()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += TelaEstoque_Load;
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {
            panelCadastroE.Visible = false;
            dgvEstoque.Visible = true;

            ConfigurarGrid();
            CarregarEstoque();
        }

        // ================= GRID =================
        private void ConfigurarGrid()
        {
            dgvEstoque.Columns.Clear();

            dgvEstoque.Columns.Add("Id", "Id");
            dgvEstoque.Columns["Id"].Visible = false;

            dgvEstoque.Columns.Add("Nome", "Nome");
            dgvEstoque.Columns.Add("Quantidade", "Quantidade");
            dgvEstoque.Columns.Add("Categoria", "Categoria");

            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoque.AllowUserToAddRows = false;
        }

        // ================= CARREGAR =================
        private void CarregarEstoque()
        {
            dgvEstoque.Rows.Clear();

            try
            {
                ConexaoE conexao = new ConexaoE();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    conn.Open();

                    string sql = "SELECT * FROM Estoque";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dgvEstoque.Rows.Add(
                            reader["Id"],
                            reader["Nome"],
                            reader["Quantidade"],
                            reader["Categoria"]
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
        private void btnAbrirCadastroE_Click(object sender, EventArgs e)
        {
            modoEdicao = false;

            txtNomeItemE.Clear();
            QuantidadeE.Value = 0;
            cmbCategoriaE.SelectedIndex = -1;

            dgvEstoque.Visible = false;
            panelCadastroE.Visible = true;
            panelCadastroE.BringToFront(); // 🔥 importante
        }

        // ================= EDITAR =================
        private void btnEditarE_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.SelectedRows.Count > 0)
            {
                modoEdicao = true;

                idSelecionado = Convert.ToInt32(
                    dgvEstoque.SelectedRows[0].Cells["Id"].Value
                );

                txtNomeItemE.Text = dgvEstoque.SelectedRows[0].Cells["Nome"].Value.ToString();
                QuantidadeE.Value = Convert.ToInt32(dgvEstoque.SelectedRows[0].Cells["Quantidade"].Value);
                cmbCategoriaE.Text = dgvEstoque.SelectedRows[0].Cells["Categoria"].Value.ToString();

                dgvEstoque.Visible = false;
                panelCadastroE.Visible = true;
                panelCadastroE.BringToFront(); // 🔥 importante
            }
            else
            {
                MessageBox.Show("Selecione um item!");
            }
        }

        // ================= SALVAR =================
        private void btnSalvarE_Click(object sender, EventArgs e)
        {
            string nome = txtNomeItemE.Text;
            int quantidade = (int)QuantidadeE.Value;
            string categoria = cmbCategoriaE.Text;

            if (!string.IsNullOrWhiteSpace(nome) &&
                !string.IsNullOrWhiteSpace(categoria))
            {
                try
                {
                    ConexaoE conexao = new ConexaoE();

                    using (MySqlConnection conn = conexao.Conectar())
                    {
                        conn.Open();

                        if (!modoEdicao)
                        {
                            string sql = "INSERT INTO Estoque (Nome, Quantidade, Categoria) VALUES (@nome, @qtd, @cat)";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);

                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@qtd", quantidade);
                            cmd.Parameters.AddWithValue("@cat", categoria);

                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string sql = "UPDATE Estoque SET Nome=@nome, Quantidade=@qtd, Categoria=@cat WHERE Id=@id";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);

                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@qtd", quantidade);
                            cmd.Parameters.AddWithValue("@cat", categoria);
                            cmd.Parameters.AddWithValue("@id", idSelecionado);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    panelCadastroE.Visible = false;
                    dgvEstoque.Visible = true;
                    dgvEstoque.BringToFront();

                    CarregarEstoque();
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
        private void btnExcluirE_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(
                        dgvEstoque.SelectedRows[0].Cells["Id"].Value
                    );

                    ConexaoE conexao = new ConexaoE();

                    using (MySqlConnection conn = conexao.Conectar())
                    {
                        conn.Open();

                        string sql = "DELETE FROM Estoque WHERE Id=@id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }

                    CarregarEstoque();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro REAL ao excluir:\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Selecione um item!");
            }
        }

        // ================= VOLTAR =================
        private void btnVoltarE_Click(object sender, EventArgs e)
        {
            panelCadastroE.Visible = false;
            dgvEstoque.Visible = true;
            dgvEstoque.BringToFront(); // 🔥 importante
        }

        // ================= BUSCA =================
        private void txtBuscaE_TextChanged(object sender, EventArgs e)
        {
            string termo = txtBuscaE.Text.ToLower();

            foreach (DataGridViewRow linha in dgvEstoque.Rows)
            {
                if (linha.IsNewRow) continue;

                string nome = linha.Cells["Nome"].Value?.ToString().ToLower() ?? "";
                string categoria = linha.Cells["Categoria"].Value?.ToString().ToLower() ?? "";

                linha.Visible =
                    nome.Contains(termo) ||
                    categoria.Contains(termo);
            }
        }

        // ================= NAVEGAÇÃO =================
        private void btnClientesE_Click(object sender, EventArgs e)
        {
            new TelaClientes().Show();
            this.Hide();
        }

        private void btnServicosE_Click(object sender, EventArgs e)
        {
            new TelaServicos().Show();
            this.Hide();
        }

        private void btnPedidosE_Click(object sender, EventArgs e)
        {
            new TelaPedidos().Show();
            this.Hide();
        }
    }
}
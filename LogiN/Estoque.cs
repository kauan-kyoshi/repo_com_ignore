using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogiN
{
    public partial class TelaEstoque : System.Windows.Forms.Form
    {
        public TelaEstoque()
        {
            InitializeComponent();
            btnEstoque.BackColor = Color.FromArgb(191, 165, 187);
            btnEstoque.ForeColor = Color.Black;
            this.StartPosition = FormStartPosition.CenterScreen;

            ConfigurarColunas();

            panelCadastro.Visible = false;

            dataGridView1.Rows.Add("Tecido Algodão Branco", "25", "Tecido");
            dataGridView1.Rows.Add("Tecido Jeans Azul", "15", "Tecido");
            dataGridView1.Rows.Add("Linha Preta", "50", "Linha");
            dataGridView1.Rows.Add("Botões Pretos (Pacote)", "8", "Aviamentos");
            dataGridView1.Rows.Add("Zíper 20cm", "30", "Aviamentos");
            dataGridView1.Rows.Add("Linha Azul", "40", "Linha");
            dataGridView1.Rows.Add("Linha Verde", "35", "Linha");
            dataGridView1.Rows.Add("Tecido Seda Vermelha", "12", "Tecido");
            dataGridView1.Rows.Add("Tecido Linho Bege", "20", "Tecido");
            dataGridView1.Rows.Add("Botões Metálicos (Pacote)", "15", "Aviamentos");
            dataGridView1.Rows.Add("Zíper 60cm", "10", "Aviamentos");
            dataGridView1.Rows.Add("Elástico Branco 2cm", "25", "Aviamentos");
            dataGridView1.Rows.Add("Fita de Cetim Vermelha", "50", "Aviamentos");
            dataGridView1.Rows.Add("Agulhas de Costura (Caixa)", "100", "Ferramentas");
            dataGridView1.Rows.Add("Tesoura de Alfaiate", "5", "Ferramentas");
            dataGridView1.Rows.Add("Linha Dourada", "18", "Linha");
            dataGridView1.Rows.Add("Tecido Veludo Preto", "8", "Tecido");
        }

        private void ConfigurarColunas()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Quantidade", "Quantidade");
            dataGridView1.Columns.Add("Categoria", "Categoria");

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.FromArgb(245, 245, 245);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 50;

            DataGridViewCellStyle styleHeader = new DataGridViewCellStyle();
            styleHeader.BackColor = Color.White;
            styleHeader.ForeColor = Color.Gray;
            styleHeader.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            styleHeader.SelectionBackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = styleHeader;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCellStyle styleCell = new DataGridViewCellStyle();
            styleCell.SelectionBackColor = Color.FromArgb(191, 165, 187);
            styleCell.SelectionForeColor = Color.Black;
            styleCell.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle = styleCell;
        }

        private void btnAbrirCadastro_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panelCadastro.Visible = true;
            panelCadastro.BringToFront();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeItem.Text;
            int quantidade = (int)Quantidade.Value;
            string categoria = cmbCategoria.SelectedItem?.ToString() ?? "";

            if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(categoria))
            {
                dataGridView1.Rows.Add(nome, quantidade.ToString(), categoria);
                panelCadastro.Visible = false;
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelCadastro.Visible = false;
            dataGridView1.Visible = true;
        }

        private void TelaEstoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            string termoBusca = txtBusca.Text.ToLower();

            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                if (linha.IsNewRow) continue;

                string nome = linha.Cells["Nome"].Value?.ToString().ToLower() ?? "";
                string quantidade = linha.Cells["Quantidade"].Value?.ToString().ToLower() ?? "";
                string categoria = linha.Cells["Categoria"].Value?.ToString().ToLower() ?? "";

                bool corresponde = nome.Contains(termoBusca)
                                   || quantidade.Contains(termoBusca)
                                   || categoria.Contains(termoBusca);

                linha.Visible = corresponde;
            }
        }

        private void btnSalvarEstoque_Click(object sender, EventArgs e)
        {
            string nome = txtNomeItem.Text;
            int quantidade = (int)Quantidade.Value;
            string categoria = cmbCategoria.SelectedItem?.ToString() ?? "";

            if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(categoria))
            {
                dataGridView1.Rows.Add(nome, quantidade.ToString(), categoria);

                txtNomeItem.Clear();
                Quantidade.Value = 0;
                cmbCategoria.SelectedIndex = -1;
                panelCadastro.Visible = false;
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarEstoque_Click(object sender, EventArgs e)
        {
            txtNomeItem.Clear();
            Quantidade.Value = 0;
            cmbCategoria.SelectedIndex = -1;
            panelCadastro.Visible = false;
            dataGridView1.Visible = true;
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {

        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            TelaCadastro telaClientes = new TelaCadastro();
            telaClientes.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            TelaPedidos tela = new TelaPedidos();
            tela.Show();
            this.Hide();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            TelaPedidos tela = new TelaPedidos();
            tela.StartPosition = FormStartPosition.CenterScreen;
            tela.Show();
            this.Hide();
        }


    }
}


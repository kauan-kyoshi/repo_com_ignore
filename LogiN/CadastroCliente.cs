using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LogiN
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConfigurarColunasClientes();
            panelCadastroCliente.Visible = false;

            dataGridViewClientes.Rows.Add("Maria Silva", "123.456.789-00", "(11) 98765-4321");
            dataGridViewClientes.Rows.Add("João Santos", "987.654.321-00", "(11) 91234-5678");
            dataGridViewClientes.Rows.Add("Ana Costa", "456.789.123-00", "(11) 99876-5432");
        }

        private void ConfigurarColunasClientes()
        {
            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.Columns.Clear();

            dataGridViewClientes.Columns.Add("Nome", "Nome");
            dataGridViewClientes.Columns.Add("CPF", "CPF");
            dataGridViewClientes.Columns.Add("Telefone", "Telefone");

            dataGridViewClientes.BackgroundColor = Color.White;
            dataGridViewClientes.BorderStyle = BorderStyle.None;
            dataGridViewClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewClientes.GridColor = Color.FromArgb(245, 245, 245);

            dataGridViewClientes.EnableHeadersVisualStyles = false;
            dataGridViewClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewClientes.ColumnHeadersHeight = 50;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                SelectionBackColor = Color.White
            };
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = headerStyle;

            dataGridViewClientes.RowHeadersVisible = false;
            dataGridViewClientes.RowTemplate.Height = 45;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(191, 165, 187),
                SelectionForeColor = Color.Black,
                Font = new Font("Segoe UI", 10)
            };
            dataGridViewClientes.DefaultCellStyle = cellStyle;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            dataGridViewClientes.Visible = false;
            panelCadastroCliente.Visible = true;
            panelCadastroCliente.BringToFront();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCompleto.Text;
            string cpf = txtCPF.Text;
            string telefone = txtTelefone.Text;

            if (!string.IsNullOrWhiteSpace(nome) &&
                !string.IsNullOrWhiteSpace(cpf) &&
                !string.IsNullOrWhiteSpace(telefone))
            {
                dataGridViewClientes.Rows.Add(nome, cpf, telefone);

                txtNomeCompleto.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();

                panelCadastroCliente.Visible = false;
                dataGridViewClientes.Visible = true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();

            panelCadastroCliente.Visible = false;
            dataGridViewClientes.Visible = true;
        }

        private void txtBuscaCliente_TextChanged(object sender, EventArgs e)
        {
            string termo = txtBuscaCliente.Text.ToLower();

            foreach (DataGridViewRow linha in dataGridViewClientes.Rows)
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
        private void btnSalvarClientes_Click(object sender, EventArgs e)
        {
           InserirBanco banco = new InserirBanco();
           banco.Inserir(txtNomeCompleto.Text, txtTelefone.Text, txtCPF.Text);
           


        }

        private void panelCadastroCliente_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnServicos_Click(object sender, EventArgs e)
        {
            TelaPedidos tela = new TelaPedidos();
            tela.Show();
            this.Hide();
        }


        private void lblCadastroClientes_Click(object sender, EventArgs e)
        {
            TelaCadastro tela = new TelaCadastro();
            tela.StartPosition = FormStartPosition.CenterScreen;
            tela.Show();
            this.Close();
        }

    }
}
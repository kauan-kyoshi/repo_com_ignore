using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LogiN
{
    public partial class TelaClientes : Form
    {
        public TelaClientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConfigurarColunasClientes();
            panelCadastroC.Visible = false;

            dgvClientes.Rows.Add("Maria Silva", "123.456.789-00", "(11) 98765-4321");
            dgvClientes.Rows.Add("João Santos", "987.654.321-00", "(11) 91234-5678");
            dgvClientes.Rows.Add("Ana Costa", "456.789.123-00", "(11) 99876-5432");
        }

        private void ConfigurarColunasClientes()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add("Nome", "Nome");
            dgvClientes.Columns.Add("CPF", "CPF");
            dgvClientes.Columns.Add("Telefone", "Telefone");

            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.GridColor = Color.FromArgb(245, 245, 245);

            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.ColumnHeadersHeight = 50;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                SelectionBackColor = Color.White
            };
            dgvClientes.ColumnHeadersDefaultCellStyle = headerStyle;

            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowTemplate.Height = 45;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(191, 165, 187),
                SelectionForeColor = Color.Black,
                Font = new Font("Segoe UI", 10)
            };
            dgvClientes.DefaultCellStyle = cellStyle;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            dgvClientes.Visible = false;
            panelCadastroC.Visible = true;
            panelCadastroC.BringToFront();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtNomeC.Text;
            string cpf = txtCPF.Text;
            string telefone = txtTelefoneC.Text;

            if (!string.IsNullOrWhiteSpace(nome) &&
                !string.IsNullOrWhiteSpace(cpf) &&
                !string.IsNullOrWhiteSpace(telefone))
            {
                dgvClientes.Rows.Add(nome, cpf, telefone);

                txtNomeC.Clear();
                txtCPF.Clear();
                txtTelefoneC.Clear();

                panelCadastroC.Visible = false;
                dgvClientes.Visible = true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            txtNomeC.Clear();
            txtCPF.Clear();
            txtTelefoneC.Clear();

            panelCadastroC.Visible = false;
            dgvClientes.Visible = true;
        }

        /*private void txtBuscaCliente_TextChanged(object sender, EventArgs e)
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
        }*/
        private void btnSalvarClientes_Click(object sender, EventArgs e)
        {
            InserirBanco banco = new InserirBanco();
            banco.Inserir(txtNomeC.Text, txtTelefoneC.Text, txtCPF.Text);



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
            TelaClientes tela = new TelaClientes();
            tela.StartPosition = FormStartPosition.CenterScreen;
            tela.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
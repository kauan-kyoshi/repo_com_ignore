namespace TelaPrincipal
{
    public partial class FormPrincipal : Form
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
            ConfigurarColunas();

            dataGridView1.Rows.Add("Tecido Algodão Branco", "25", "Tecido");
            dataGridView1.Rows.Add("Tecido Jeans Azul", "15", "Tecido");
            dataGridView1.Rows.Add("Linha Preta", "50", "Linha");
            dataGridView1.Rows.Add("Botões Pretos (Pacote)", "8", "Aviamentos");
            dataGridView1.Rows.Add("Zíper 20cm", "30", "Aviamentos");

            if (ucCadastro != null)
            {
                ucCadastro.Visible = false;
                //ucCadastro2.ItemSalvo += UcCadastro_ItemSalvo;
            }
        }

        private void ConfigurarColunas()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Nome", "Nome");
                dataGridView1.Columns.Add("Quantidade", "Quantidade");
                dataGridView1.Columns.Add("Categoria", "Categoria");
            }

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
            styleHeader.SelectionBackColor = Color.White; // Evita mudar de cor ao clicar
            dataGridView1.ColumnHeadersDefaultCellStyle = styleHeader;

            dataGridView1.RowHeadersVisible = false; // Remove a coluna da esquerda
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCellStyle styleCell = new DataGridViewCellStyle();
            styleCell.SelectionBackColor = Color.FromArgb(240, 245, 255); // Azul bem clarinho ao clicar
            styleCell.SelectionForeColor = Color.Black;
            styleCell.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle = styleCell;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            ucCadastro2.Visible = true;
            ucCadastro2.BringToFront();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ucCadastro2.Visible = false;
            dataGridView1.Visible = true;
        }

        private void UcCadastro_ItemSalvo(string nome, int quantidade, string categoria)
        {
            dataGridView1.Rows.Add(nome, quantidade, categoria);

            ucCadastro2.Visible = false;
            dataGridView1.Visible = true;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            string termoBusca = txtBusca.Text.ToLower();

            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {

                if (linha.IsNewRow) continue;
                string nomeMaterial = linha.Cells["Nome"].Value?.ToString().ToLower() ?? "";

                if (nomeMaterial.Contains(termoBusca))
                {
                    linha.Visible = true;
                }
                else
                {
                    CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                    if (cm != null) { cm.SuspendBinding(); }

                    linha.Visible = false;
                }
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
          
        }
    }
}

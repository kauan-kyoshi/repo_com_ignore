namespace LogiN
{
    partial class TelaServicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaServicos));
            btnAbrirCadastro = new Button();
            dgvServicos = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtBusca = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnServicosS = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnPedidosS = new Button();
            btnClientesS = new Button();
            btnEstoqueS = new Button();
            panelCadastroS = new Panel();
            label8 = new Label();
            CadastrarNovoCliente = new GroupBox();
            label10 = new Label();
            btnVoltar = new Button();
            btnSalvarS = new Button();
            txtTelefone = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            TipodeServicoS = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelCadastroS.SuspendLayout();
            CadastrarNovoCliente.SuspendLayout();
            SuspendLayout();
            // 
            // btnAbrirCadastro
            // 
            btnAbrirCadastro.BackColor = Color.FromArgb(191, 165, 187);
            btnAbrirCadastro.FlatAppearance.BorderSize = 0;
            btnAbrirCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnAbrirCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnAbrirCadastro.FlatStyle = FlatStyle.Flat;
            btnAbrirCadastro.Font = new Font("Century Gothic", 12F);
            btnAbrirCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirCadastro.Location = new Point(1062, 46);
            btnAbrirCadastro.Margin = new Padding(3, 2, 3, 2);
            btnAbrirCadastro.Name = "btnAbrirCadastro";
            btnAbrirCadastro.Size = new Size(188, 37);
            btnAbrirCadastro.TabIndex = 24;
            btnAbrirCadastro.Text = "Novo serviço";
            btnAbrirCadastro.UseVisualStyleBackColor = false;
            // 
            // dgvServicos
            // 
            dgvServicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvServicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicos.BackgroundColor = Color.White;
            dgvServicos.BorderStyle = BorderStyle.None;
            dgvServicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvServicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvServicos.ColumnHeadersHeight = 50;
            dgvServicos.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvServicos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvServicos.EnableHeadersVisualStyles = false;
            dgvServicos.Location = new Point(350, 219);
            dgvServicos.Margin = new Padding(3, 2, 3, 2);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.RowHeadersVisible = false;
            dgvServicos.RowHeadersWidth = 51;
            dgvServicos.RowTemplate.Height = 40;
            dgvServicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicos.Size = new Size(898, 411);
            dgvServicos.TabIndex = 25;
            dgvServicos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tipo de Serviço";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Valor";
            Column3.Name = "Column3";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtBusca);
            panel2.Location = new Point(342, 114);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 47);
            panel2.TabIndex = 23;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 8);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 29);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtBusca
            // 
            txtBusca.BackColor = Color.White;
            txtBusca.Location = new Point(52, 8);
            txtBusca.Margin = new Padding(3, 2, 3, 2);
            txtBusca.Multiline = true;
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(857, 30);
            txtBusca.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F);
            label3.Location = new Point(337, 35);
            label3.Name = "label3";
            label3.Size = new Size(301, 19);
            label3.TabIndex = 22;
            label3.Text = "Gerencie os seus trabalhos e encomendas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label2.Location = new Point(337, 9);
            label2.Name = "label2";
            label2.Size = new Size(99, 26);
            label2.TabIndex = 21;
            label2.Text = "Serviços";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnServicosS);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnPedidosS);
            panel1.Controls.Add(btnClientesS);
            panel1.Controls.Add(btnEstoqueS);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 620);
            panel1.TabIndex = 20;
            // 
            // btnServicosS
            // 
            btnServicosS.BackColor = Color.White;
            btnServicosS.FlatAppearance.BorderSize = 0;
            btnServicosS.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnServicosS.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnServicosS.FlatStyle = FlatStyle.Flat;
            btnServicosS.Font = new Font("Century Gothic", 12F);
            btnServicosS.Image = (Image)resources.GetObject("btnServicosS.Image");
            btnServicosS.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicosS.Location = new Point(23, 429);
            btnServicosS.Margin = new Padding(3, 2, 3, 2);
            btnServicosS.Name = "btnServicosS";
            btnServicosS.Size = new Size(255, 48);
            btnServicosS.TabIndex = 6;
            btnServicosS.Text = "Serviços";
            btnServicosS.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            label1.Location = new Point(41, 124);
            label1.Name = "label1";
            label1.Size = new Size(207, 22);
            label1.TabIndex = 5;
            label1.Text = "Bem-vinda ao Sistema";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnPedidosS
            // 
            btnPedidosS.BackColor = Color.White;
            btnPedidosS.FlatAppearance.BorderSize = 0;
            btnPedidosS.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnPedidosS.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnPedidosS.FlatStyle = FlatStyle.Flat;
            btnPedidosS.Font = new Font("Century Gothic", 12F);
            btnPedidosS.Image = (Image)resources.GetObject("btnPedidosS.Image");
            btnPedidosS.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidosS.Location = new Point(23, 511);
            btnPedidosS.Margin = new Padding(3, 2, 3, 2);
            btnPedidosS.Name = "btnPedidosS";
            btnPedidosS.Size = new Size(255, 48);
            btnPedidosS.TabIndex = 2;
            btnPedidosS.Text = "Pedidos";
            btnPedidosS.UseVisualStyleBackColor = false;
            btnPedidosS.Click += btnServicos_Click;
            // 
            // btnClientesS
            // 
            btnClientesS.BackColor = Color.White;
            btnClientesS.FlatAppearance.BorderSize = 0;
            btnClientesS.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnClientesS.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnClientesS.FlatStyle = FlatStyle.Flat;
            btnClientesS.Font = new Font("Century Gothic", 12F);
            btnClientesS.Image = (Image)resources.GetObject("btnClientesS.Image");
            btnClientesS.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientesS.Location = new Point(23, 347);
            btnClientesS.Margin = new Padding(3, 2, 3, 2);
            btnClientesS.Name = "btnClientesS";
            btnClientesS.Size = new Size(255, 48);
            btnClientesS.TabIndex = 1;
            btnClientesS.Text = "Clientes";
            btnClientesS.UseVisualStyleBackColor = false;
            btnClientesS.Click += btnClientes_Click;
            // 
            // btnEstoqueS
            // 
            btnEstoqueS.BackColor = Color.White;
            btnEstoqueS.FlatAppearance.BorderSize = 0;
            btnEstoqueS.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnEstoqueS.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnEstoqueS.FlatStyle = FlatStyle.Flat;
            btnEstoqueS.Font = new Font("Century Gothic", 12F);
            btnEstoqueS.ForeColor = Color.Black;
            btnEstoqueS.Image = (Image)resources.GetObject("btnEstoqueS.Image");
            btnEstoqueS.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoqueS.Location = new Point(23, 265);
            btnEstoqueS.Margin = new Padding(3, 2, 3, 2);
            btnEstoqueS.Name = "btnEstoqueS";
            btnEstoqueS.Size = new Size(255, 48);
            btnEstoqueS.TabIndex = 0;
            btnEstoqueS.Text = "Estoque";
            btnEstoqueS.UseVisualStyleBackColor = false;
            btnEstoqueS.Click += btnEstoque_Click;
            // 
            // panelCadastroS
            // 
            panelCadastroS.BackColor = Color.White;
            panelCadastroS.Controls.Add(label8);
            panelCadastroS.Controls.Add(CadastrarNovoCliente);
            panelCadastroS.Location = new Point(300, 2);
            panelCadastroS.Name = "panelCadastroS";
            panelCadastroS.Size = new Size(992, 620);
            panelCadastroS.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 402);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 3;
            // 
            // CadastrarNovoCliente
            // 
            CadastrarNovoCliente.Controls.Add(TipodeServicoS);
            CadastrarNovoCliente.Controls.Add(label10);
            CadastrarNovoCliente.Controls.Add(btnVoltar);
            CadastrarNovoCliente.Controls.Add(btnSalvarS);
            CadastrarNovoCliente.Controls.Add(txtTelefone);
            CadastrarNovoCliente.Controls.Add(label5);
            CadastrarNovoCliente.Controls.Add(label7);
            CadastrarNovoCliente.Controls.Add(label6);
            CadastrarNovoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CadastrarNovoCliente.Location = new Point(42, 176);
            CadastrarNovoCliente.Name = "CadastrarNovoCliente";
            CadastrarNovoCliente.Size = new Size(898, 243);
            CadastrarNovoCliente.TabIndex = 0;
            CadastrarNovoCliente.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F);
            label10.Location = new Point(23, 45);
            label10.Name = "label10";
            label10.Size = new Size(306, 21);
            label10.TabIndex = 23;
            label10.Text = "Gerencie seus trbalhos e encomendas";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.White;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Century Gothic", 10F);
            btnVoltar.Location = new Point(779, 203);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 26);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnSalvarS
            // 
            btnSalvarS.BackColor = Color.FromArgb(191, 165, 187);
            btnSalvarS.FlatAppearance.BorderSize = 0;
            btnSalvarS.FlatStyle = FlatStyle.Flat;
            btnSalvarS.Font = new Font("Century Gothic", 10F);
            btnSalvarS.Location = new Point(657, 203);
            btnSalvarS.Margin = new Padding(3, 2, 3, 2);
            btnSalvarS.Name = "btnSalvarS";
            btnSalvarS.Size = new Size(94, 26);
            btnSalvarS.TabIndex = 8;
            btnSalvarS.Text = "Salvar";
            btnSalvarS.UseVisualStyleBackColor = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(491, 141);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(382, 25);
            txtTelefone.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.Location = new Point(491, 121);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 1;
            label5.Text = "Valor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label7.Location = new Point(23, 20);
            label7.Name = "label7";
            label7.Size = new Size(270, 23);
            label7.TabIndex = 2;
            label7.Text = "Cadastre seu novo serviço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F);
            label6.Location = new Point(20, 121);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 1;
            label6.Text = "Tipo de serviço";
            // 
            // TipodeServicoS
            // 
            TipodeServicoS.FormattingEnabled = true;
            TipodeServicoS.Items.AddRange(new object[] { "Tecido", "Linha", "Aviamentos" });
            TipodeServicoS.Location = new Point(23, 141);
            TipodeServicoS.Margin = new Padding(3, 2, 3, 2);
            TipodeServicoS.Name = "TipodeServicoS";
            TipodeServicoS.Size = new Size(382, 25);
            TipodeServicoS.TabIndex = 24;
            // 
            // TelaServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1291, 620);
            Controls.Add(panelCadastroS);
            Controls.Add(btnAbrirCadastro);
            Controls.Add(dgvServicos);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaServicos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicos";
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelCadastroS.ResumeLayout(false);
            panelCadastroS.PerformLayout();
            CadastrarNovoCliente.ResumeLayout(false);
            CadastrarNovoCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirCadastro;
        private DataGridView dgvServicos;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtBusca;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnServicos;
        private Button btnClientes;
        private Button btnEstoque;
        private Panel panelCadastroCliente;
        private Label label10;
        private Label label9;
        private Label label8;
        private GroupBox CadastrarNovoCliente;
        private Button btnCancelarCliente;
        private Button btnSalvarClientes;
        private TextBox txtTelefone;
        private TextBox txtNomeCliente;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label11;
        private DataGridView dataGridViewClientes;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private ComboBox cmbCategoria;
        private Button button1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private Button btnServicosS;
        private Button btnPedidosS;
        private Button btnClientesS;
        private Button btnEstoqueS;
        private Button btnVoltar;
        private Button btnSalvarS;
        private Panel panelCadastroS;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ComboBox TipodeServicoS;
    }
}
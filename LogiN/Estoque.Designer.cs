namespace LogiN
{
    partial class TelaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstoque));
            btnAbrirCadastro = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtBusca = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panelCadastro = new Panel();
            groupBox1 = new GroupBox();
            btnCancelarEstoque = new Button();
            btnSalvarEstoque = new Button();
            label6 = new Label();
            label8 = new Label();
            cmbCategoria = new ComboBox();
            txtNomeItem = new TextBox();
            label7 = new Label();
            Quantidade = new NumericUpDown();
            btnVoltar = new Button();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnServicos = new Button();
            btnClientes = new Button();
            btnEstoque = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelCadastro.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Quantidade).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnAbrirCadastro.Location = new Point(1074, 47);
            btnAbrirCadastro.Margin = new Padding(3, 2, 3, 2);
            btnAbrirCadastro.Name = "btnAbrirCadastro";
            btnAbrirCadastro.Size = new Size(188, 37);
            btnAbrirCadastro.TabIndex = 18;
            btnAbrirCadastro.Text = "+ Adicionar Item";
            btnAbrirCadastro.UseVisualStyleBackColor = false;
            btnAbrirCadastro.Click += btnAbrirCadastro_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(356, 190);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(898, 411);
            dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Quantidade";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoria";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtBusca);
            panel2.Location = new Point(348, 116);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 47);
            panel2.TabIndex = 17;
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
            label3.Location = new Point(356, 47);
            label3.Name = "label3";
            label3.Size = new Size(269, 19);
            label3.TabIndex = 16;
            label3.Text = "Gerencie seus materiais e aviamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label2.Location = new Point(356, 16);
            label2.Name = "label2";
            label2.Size = new Size(228, 26);
            label2.TabIndex = 15;
            label2.Text = "Controle de Estoque";
            // 
            // panelCadastro
            // 
            panelCadastro.Controls.Add(groupBox1);
            panelCadastro.Controls.Add(btnVoltar);
            panelCadastro.Controls.Add(label4);
            panelCadastro.Controls.Add(label5);
            panelCadastro.Location = new Point(300, 0);
            panelCadastro.Margin = new Padding(3, 2, 3, 2);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(992, 618);
            panelCadastro.TabIndex = 20;
            panelCadastro.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelarEstoque);
            groupBox1.Controls.Add(btnSalvarEstoque);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(txtNomeItem);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(Quantidade);
            groupBox1.Location = new Point(25, 213);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(906, 227);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // btnCancelarEstoque
            // 
            btnCancelarEstoque.BackColor = Color.White;
            btnCancelarEstoque.FlatAppearance.BorderSize = 0;
            btnCancelarEstoque.FlatStyle = FlatStyle.Flat;
            btnCancelarEstoque.Font = new Font("Century Gothic", 10F);
            btnCancelarEstoque.Location = new Point(789, 179);
            btnCancelarEstoque.Margin = new Padding(3, 2, 3, 2);
            btnCancelarEstoque.Name = "btnCancelarEstoque";
            btnCancelarEstoque.Size = new Size(94, 26);
            btnCancelarEstoque.TabIndex = 7;
            btnCancelarEstoque.Text = "Cancelar";
            btnCancelarEstoque.UseVisualStyleBackColor = false;
            btnCancelarEstoque.Click += btnCancelarEstoque_Click;
            // 
            // btnSalvarEstoque
            // 
            btnSalvarEstoque.BackColor = Color.FromArgb(191, 165, 187);
            btnSalvarEstoque.FlatAppearance.BorderSize = 0;
            btnSalvarEstoque.FlatStyle = FlatStyle.Flat;
            btnSalvarEstoque.Font = new Font("Century Gothic", 10F);
            btnSalvarEstoque.Location = new Point(638, 179);
            btnSalvarEstoque.Margin = new Padding(3, 2, 3, 2);
            btnSalvarEstoque.Name = "btnSalvarEstoque";
            btnSalvarEstoque.Size = new Size(94, 26);
            btnSalvarEstoque.TabIndex = 6;
            btnSalvarEstoque.Text = "Salvar";
            btnSalvarEstoque.UseVisualStyleBackColor = false;
            btnSalvarEstoque.Click += btnSalvarEstoque_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F);
            label6.Location = new Point(46, 58);
            label6.Name = "label6";
            label6.Size = new Size(50, 19);
            label6.TabIndex = 3;
            label6.Text = "Nome";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F);
            label8.Location = new Point(651, 59);
            label8.Name = "label8";
            label8.Size = new Size(79, 19);
            label8.TabIndex = 5;
            label8.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Tecido", "Linha", "Aviamentos" });
            cmbCategoria.Location = new Point(651, 78);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(209, 23);
            cmbCategoria.TabIndex = 1;
            // 
            // txtNomeItem
            // 
            txtNomeItem.Location = new Point(43, 76);
            txtNomeItem.Margin = new Padding(3, 2, 3, 2);
            txtNomeItem.Name = "txtNomeItem";
            txtNomeItem.Size = new Size(209, 23);
            txtNomeItem.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F);
            label7.Location = new Point(338, 59);
            label7.Name = "label7";
            label7.Size = new Size(96, 19);
            label7.TabIndex = 4;
            label7.Text = "Quantidade";
            // 
            // Quantidade
            // 
            Quantidade.Location = new Point(338, 76);
            Quantidade.Margin = new Padding(3, 2, 3, 2);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(206, 23);
            Quantidade.TabIndex = 2;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(191, 165, 187);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Century Gothic", 12F);
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(766, 55);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(188, 37);
            btnVoltar.TabIndex = 21;
            btnVoltar.Text = "+ Adicionar Item";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F);
            label4.Location = new Point(49, 55);
            label4.Name = "label4";
            label4.Size = new Size(269, 19);
            label4.TabIndex = 20;
            label4.Text = "Gerencie seus materiais e aviamentos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label5.Location = new Point(49, 24);
            label5.Name = "label5";
            label5.Size = new Size(228, 26);
            label5.TabIndex = 19;
            label5.Text = "Controle de Estoque";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnServicos);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnEstoque);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 620);
            panel1.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(23, 505);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(255, 48);
            button1.TabIndex = 6;
            button1.Text = "Serviços";
            button1.UseVisualStyleBackColor = false;
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
            // btnServicos
            // 
            btnServicos.BackColor = Color.WhiteSmoke;
            btnServicos.FlatAppearance.BorderSize = 0;
            btnServicos.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnServicos.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnServicos.FlatStyle = FlatStyle.Flat;
            btnServicos.Font = new Font("Century Gothic", 12F);
            btnServicos.Image = (Image)resources.GetObject("btnServicos.Image");
            btnServicos.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicos.Location = new Point(23, 418);
            btnServicos.Margin = new Padding(3, 2, 3, 2);
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new Size(255, 48);
            btnServicos.TabIndex = 2;
            btnServicos.Text = "Pedidos";
            btnServicos.UseVisualStyleBackColor = false;
            btnServicos.Click += btnServicos_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.WhiteSmoke;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 12F);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(23, 331);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(255, 48);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click_1;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.WhiteSmoke;
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnEstoque.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Century Gothic", 12F);
            btnEstoque.ForeColor = Color.Black;
            btnEstoque.Image = (Image)resources.GetObject("btnEstoque.Image");
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(23, 248);
            btnEstoque.Margin = new Padding(3, 2, 3, 2);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(255, 48);
            btnEstoque.TabIndex = 0;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // TelaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1291, 620);
            Controls.Add(panel1);
            Controls.Add(panelCadastro);
            Controls.Add(btnAbrirCadastro);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "TelaEstoque";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaEstoque";
            Load += TelaEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelCadastro.ResumeLayout(false);
            panelCadastro.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Quantidade).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirCadastro;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtBusca;
        private Label label3;
        private Label label2;
        private Panel panelCadastro;
        private Button btnVoltar;
        private Label label4;
        private Label label5;
        private Label label8;
        private ComboBox cmbCategoria;
        private Label label7;
        private NumericUpDown Quantidade;
        private Label label6;
        private TextBox txtNomeItem;
        private GroupBox groupBox1;
        private Button btnSalvarEstoque;
        private Button btnCancelarEstoque;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnServicos;
        private Button btnClientes;
        private Button btnEstoque;
    }
}
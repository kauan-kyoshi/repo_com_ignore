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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstoque));
            btnAbrirCadastroE = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtBuscaE = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panelCadastroE = new Panel();
            groupBox1 = new GroupBox();
            btnVoltarE = new Button();
            btnSalvarE = new Button();
            label6 = new Label();
            label8 = new Label();
            cmbCategoriaE = new ComboBox();
            txtNomeItemE = new TextBox();
            label7 = new Label();
            QuantidadeE = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            btnServicosE = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnPedidosE = new Button();
            btnClientesE = new Button();
            btnEstoqueE = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelCadastroE.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantidadeE).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAbrirCadastroE
            // 
            btnAbrirCadastroE.BackColor = Color.FromArgb(191, 165, 187);
            btnAbrirCadastroE.FlatAppearance.BorderSize = 0;
            btnAbrirCadastroE.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnAbrirCadastroE.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnAbrirCadastroE.FlatStyle = FlatStyle.Flat;
            btnAbrirCadastroE.Font = new Font("Century Gothic", 12F);
            btnAbrirCadastroE.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirCadastroE.Location = new Point(1074, 47);
            btnAbrirCadastroE.Margin = new Padding(3, 2, 3, 2);
            btnAbrirCadastroE.Name = "btnAbrirCadastroE";
            btnAbrirCadastroE.Size = new Size(188, 37);
            btnAbrirCadastroE.TabIndex = 18;
            btnAbrirCadastroE.Text = "+ Adicionar Item";
            btnAbrirCadastroE.UseVisualStyleBackColor = false;
            btnAbrirCadastroE.Click += btnAbrirCadastro_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
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
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtBuscaE);
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
            // txtBuscaE
            // 
            txtBuscaE.BackColor = Color.White;
            txtBuscaE.Location = new Point(52, 8);
            txtBuscaE.Margin = new Padding(3, 2, 3, 2);
            txtBuscaE.Multiline = true;
            txtBuscaE.Name = "txtBuscaE";
            txtBuscaE.Size = new Size(857, 30);
            txtBuscaE.TabIndex = 0;
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
            // panelCadastroE
            // 
            panelCadastroE.BackColor = Color.White;
            panelCadastroE.Controls.Add(groupBox1);
            panelCadastroE.Controls.Add(label4);
            panelCadastroE.Controls.Add(label5);
            panelCadastroE.Location = new Point(300, 0);
            panelCadastroE.Margin = new Padding(3, 2, 3, 2);
            panelCadastroE.Name = "panelCadastroE";
            panelCadastroE.Size = new Size(992, 618);
            panelCadastroE.TabIndex = 20;
            panelCadastroE.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVoltarE);
            groupBox1.Controls.Add(btnSalvarE);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbCategoriaE);
            groupBox1.Controls.Add(txtNomeItemE);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(QuantidadeE);
            groupBox1.Location = new Point(25, 213);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(906, 227);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // btnVoltarE
            // 
            btnVoltarE.BackColor = Color.White;
            btnVoltarE.FlatAppearance.BorderSize = 0;
            btnVoltarE.FlatStyle = FlatStyle.Flat;
            btnVoltarE.Font = new Font("Century Gothic", 10F);
            btnVoltarE.Location = new Point(789, 179);
            btnVoltarE.Margin = new Padding(3, 2, 3, 2);
            btnVoltarE.Name = "btnVoltarE";
            btnVoltarE.Size = new Size(94, 26);
            btnVoltarE.TabIndex = 7;
            btnVoltarE.Text = "Voltar";
            btnVoltarE.UseVisualStyleBackColor = false;
            btnVoltarE.Click += btnCancelarEstoque_Click;
            // 
            // btnSalvarE
            // 
            btnSalvarE.BackColor = Color.FromArgb(191, 165, 187);
            btnSalvarE.FlatAppearance.BorderSize = 0;
            btnSalvarE.FlatStyle = FlatStyle.Flat;
            btnSalvarE.Font = new Font("Century Gothic", 10F);
            btnSalvarE.Location = new Point(638, 179);
            btnSalvarE.Margin = new Padding(3, 2, 3, 2);
            btnSalvarE.Name = "btnSalvarE";
            btnSalvarE.Size = new Size(94, 26);
            btnSalvarE.TabIndex = 6;
            btnSalvarE.Text = "Salvar";
            btnSalvarE.UseVisualStyleBackColor = false;
            btnSalvarE.Click += btnSalvarEstoque_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F);
            label6.Location = new Point(46, 58);
            label6.Name = "label6";
            label6.Size = new Size(84, 19);
            label6.TabIndex = 3;
            label6.Text = "Nome Item";
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
            // cmbCategoriaE
            // 
            cmbCategoriaE.FormattingEnabled = true;
            cmbCategoriaE.Items.AddRange(new object[] { "Tecido", "Linha", "Aviamentos" });
            cmbCategoriaE.Location = new Point(651, 80);
            cmbCategoriaE.Margin = new Padding(3, 2, 3, 2);
            cmbCategoriaE.Name = "cmbCategoriaE";
            cmbCategoriaE.Size = new Size(209, 23);
            cmbCategoriaE.TabIndex = 1;
            // 
            // txtNomeItemE
            // 
            txtNomeItemE.Location = new Point(43, 79);
            txtNomeItemE.Margin = new Padding(3, 2, 3, 2);
            txtNomeItemE.Name = "txtNomeItemE";
            txtNomeItemE.Size = new Size(209, 23);
            txtNomeItemE.TabIndex = 0;
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
            // QuantidadeE
            // 
            QuantidadeE.Location = new Point(338, 80);
            QuantidadeE.Margin = new Padding(3, 2, 3, 2);
            QuantidadeE.Name = "QuantidadeE";
            QuantidadeE.Size = new Size(206, 23);
            QuantidadeE.TabIndex = 2;
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnServicosE);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnPedidosE);
            panel1.Controls.Add(btnClientesE);
            panel1.Controls.Add(btnEstoqueE);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 620);
            panel1.TabIndex = 21;
            // 
            // btnServicosE
            // 
            btnServicosE.BackColor = Color.White;
            btnServicosE.FlatAppearance.BorderSize = 0;
            btnServicosE.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnServicosE.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnServicosE.FlatStyle = FlatStyle.Flat;
            btnServicosE.Font = new Font("Century Gothic", 12F);
            btnServicosE.Image = (Image)resources.GetObject("btnServicosE.Image");
            btnServicosE.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicosE.Location = new Point(23, 414);
            btnServicosE.Margin = new Padding(3, 2, 3, 2);
            btnServicosE.Name = "btnServicosE";
            btnServicosE.Size = new Size(255, 48);
            btnServicosE.TabIndex = 6;
            btnServicosE.Text = "Serviços";
            btnServicosE.UseVisualStyleBackColor = false;
            btnServicosE.Click += btnServicosE_Click;
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
            // btnPedidosE
            // 
            btnPedidosE.BackColor = Color.White;
            btnPedidosE.FlatAppearance.BorderSize = 0;
            btnPedidosE.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnPedidosE.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnPedidosE.FlatStyle = FlatStyle.Flat;
            btnPedidosE.Font = new Font("Century Gothic", 12F);
            btnPedidosE.Image = (Image)resources.GetObject("btnPedidosE.Image");
            btnPedidosE.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidosE.Location = new Point(23, 497);
            btnPedidosE.Margin = new Padding(3, 2, 3, 2);
            btnPedidosE.Name = "btnPedidosE";
            btnPedidosE.Size = new Size(255, 48);
            btnPedidosE.TabIndex = 2;
            btnPedidosE.Text = "Pedidos";
            btnPedidosE.UseVisualStyleBackColor = false;
            btnPedidosE.Click += btnServicos_Click;
            // 
            // btnClientesE
            // 
            btnClientesE.BackColor = Color.White;
            btnClientesE.FlatAppearance.BorderSize = 0;
            btnClientesE.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnClientesE.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnClientesE.FlatStyle = FlatStyle.Flat;
            btnClientesE.Font = new Font("Century Gothic", 12F);
            btnClientesE.Image = (Image)resources.GetObject("btnClientesE.Image");
            btnClientesE.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientesE.Location = new Point(23, 331);
            btnClientesE.Margin = new Padding(3, 2, 3, 2);
            btnClientesE.Name = "btnClientesE";
            btnClientesE.Size = new Size(255, 48);
            btnClientesE.TabIndex = 1;
            btnClientesE.Text = "Clientes";
            btnClientesE.UseVisualStyleBackColor = false;
            btnClientesE.Click += btnClientes_Click_1;
            // 
            // btnEstoqueE
            // 
            btnEstoqueE.BackColor = Color.White;
            btnEstoqueE.FlatAppearance.BorderSize = 0;
            btnEstoqueE.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnEstoqueE.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnEstoqueE.FlatStyle = FlatStyle.Flat;
            btnEstoqueE.Font = new Font("Century Gothic", 12F);
            btnEstoqueE.ForeColor = Color.Black;
            btnEstoqueE.Image = (Image)resources.GetObject("btnEstoqueE.Image");
            btnEstoqueE.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoqueE.Location = new Point(23, 248);
            btnEstoqueE.Margin = new Padding(3, 2, 3, 2);
            btnEstoqueE.Name = "btnEstoqueE";
            btnEstoqueE.Size = new Size(255, 48);
            btnEstoqueE.TabIndex = 0;
            btnEstoqueE.Text = "Estoque";
            btnEstoqueE.UseVisualStyleBackColor = false;
            // 
            // TelaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1291, 620);
            Controls.Add(panel1);
            Controls.Add(panelCadastroE);
            Controls.Add(btnAbrirCadastroE);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelCadastroE.ResumeLayout(false);
            panelCadastroE.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantidadeE).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirCadastroE;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtBuscaE;
        private Label label3;
        private Label label2;
        private Panel panelCadastroE;
        private Label label4;
        private Label label5;
        private Label label8;
        private ComboBox cmbCategoriaE;
        private Label label7;
        private NumericUpDown QuantidadeE;
        private Label label6;
        private TextBox txtNomeItemE;
        private GroupBox groupBox1;
        private Button btnSalvarE;
        private Button btnVoltarE;
        private Panel panel1;
        private Button btnServicosE;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnPedidosE;
        private Button btnClientesE;
        private Button btnEstoqueE;
    }
}
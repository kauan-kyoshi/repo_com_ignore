namespace LogiN
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnNovoCliente = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtBuscaCliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panelCadastroCliente = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            CadastrarNovoCliente = new GroupBox();
            btnCancelarCliente = new Button();
            btnSalvarClientes = new Button();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            txtNomeCompleto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridViewClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnServicos = new Button();
            btnClientes = new Button();
            btnEstoque = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelCadastroCliente.SuspendLayout();
            CadastrarNovoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.BackColor = Color.FromArgb(191, 165, 187);
            btnNovoCliente.FlatAppearance.BorderSize = 0;
            btnNovoCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 165, 187);
            btnNovoCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 165, 187);
            btnNovoCliente.FlatStyle = FlatStyle.Flat;
            btnNovoCliente.Font = new Font("Century Gothic", 12F);
            btnNovoCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoCliente.Location = new Point(1088, 47);
            btnNovoCliente.Margin = new Padding(3, 2, 3, 2);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(188, 37);
            btnNovoCliente.TabIndex = 24;
            btnNovoCliente.Text = "+ Novo Cliente";
            btnNovoCliente.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtBuscaCliente);
            panel2.Location = new Point(362, 116);
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
            // txtBuscaCliente
            // 
            txtBuscaCliente.BackColor = Color.White;
            txtBuscaCliente.Location = new Point(52, 8);
            txtBuscaCliente.Margin = new Padding(3, 2, 3, 2);
            txtBuscaCliente.Multiline = true;
            txtBuscaCliente.Name = "txtBuscaCliente";
            txtBuscaCliente.Size = new Size(857, 30);
            txtBuscaCliente.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F);
            label3.Location = new Point(370, 47);
            label3.Name = "label3";
            label3.Size = new Size(161, 19);
            label3.TabIndex = 22;
            label3.Text = "Gerencie seus clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label2.Location = new Point(370, 16);
            label2.Name = "label2";
            label2.Size = new Size(238, 26);
            label2.TabIndex = 21;
            label2.Text = "Cadastro de Clientes";
            // 
            // panelCadastroCliente
            // 
            panelCadastroCliente.Controls.Add(label10);
            panelCadastroCliente.Controls.Add(label9);
            panelCadastroCliente.Controls.Add(label8);
            panelCadastroCliente.Controls.Add(CadastrarNovoCliente);
            panelCadastroCliente.Location = new Point(300, 0);
            panelCadastroCliente.Name = "panelCadastroCliente";
            panelCadastroCliente.Size = new Size(992, 620);
            panelCadastroCliente.TabIndex = 27;
            panelCadastroCliente.Paint += panelCadastroCliente_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10F);
            label10.Location = new Point(70, 45);
            label10.Name = "label10";
            label10.Size = new Size(161, 19);
            label10.TabIndex = 23;
            label10.Text = "Gerencie seus clientes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(70, 14);
            label9.Name = "label9";
            label9.Size = new Size(224, 25);
            label9.TabIndex = 22;
            label9.Text = "Cadastro de Clientes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 350);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 3;
            // 
            // CadastrarNovoCliente
            // 
            CadastrarNovoCliente.Controls.Add(btnCancelarCliente);
            CadastrarNovoCliente.Controls.Add(btnSalvarClientes);
            CadastrarNovoCliente.Controls.Add(txtTelefone);
            CadastrarNovoCliente.Controls.Add(txtCPF);
            CadastrarNovoCliente.Controls.Add(txtNomeCompleto);
            CadastrarNovoCliente.Controls.Add(label5);
            CadastrarNovoCliente.Controls.Add(label4);
            CadastrarNovoCliente.Controls.Add(label7);
            CadastrarNovoCliente.Controls.Add(label6);
            CadastrarNovoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CadastrarNovoCliente.Location = new Point(70, 117);
            CadastrarNovoCliente.Name = "CadastrarNovoCliente";
            CadastrarNovoCliente.Size = new Size(890, 323);
            CadastrarNovoCliente.TabIndex = 0;
            CadastrarNovoCliente.TabStop = false;
            // 
            // btnCancelarCliente
            // 
            btnCancelarCliente.BackColor = Color.White;
            btnCancelarCliente.FlatAppearance.BorderSize = 0;
            btnCancelarCliente.FlatStyle = FlatStyle.Flat;
            btnCancelarCliente.Font = new Font("Century Gothic", 10F);
            btnCancelarCliente.Location = new Point(777, 280);
            btnCancelarCliente.Margin = new Padding(3, 2, 3, 2);
            btnCancelarCliente.Name = "btnCancelarCliente";
            btnCancelarCliente.Size = new Size(94, 26);
            btnCancelarCliente.TabIndex = 9;
            btnCancelarCliente.Text = "Cancelar";
            btnCancelarCliente.UseVisualStyleBackColor = false;
            // 
            // btnSalvarClientes
            // 
            btnSalvarClientes.BackColor = Color.FromArgb(191, 165, 187);
            btnSalvarClientes.FlatAppearance.BorderSize = 0;
            btnSalvarClientes.FlatStyle = FlatStyle.Flat;
            btnSalvarClientes.Font = new Font("Century Gothic", 10F);
            btnSalvarClientes.Location = new Point(658, 280);
            btnSalvarClientes.Margin = new Padding(3, 2, 3, 2);
            btnSalvarClientes.Name = "btnSalvarClientes";
            btnSalvarClientes.Size = new Size(94, 26);
            btnSalvarClientes.TabIndex = 8;
            btnSalvarClientes.Text = "Salvar";
            btnSalvarClientes.UseVisualStyleBackColor = false;
            btnSalvarClientes.Click += btnSalvarClientes_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(20, 148);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(851, 25);
            txtTelefone.TabIndex = 5;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(20, 221);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(851, 25);
            txtCPF.TabIndex = 4;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(20, 78);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(851, 25);
            txtNomeCompleto.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.Location = new Point(20, 128);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 1;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F);
            label4.Location = new Point(20, 58);
            label4.Name = "label4";
            label4.Size = new Size(119, 17);
            label4.TabIndex = 0;
            label4.Text = "Nome Completo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 21);
            label7.Name = "label7";
            label7.Size = new Size(188, 19);
            label7.TabIndex = 2;
            label7.Text = "Cadastrar Novo Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F);
            label6.Location = new Point(20, 201);
            label6.Name = "label6";
            label6.Size = new Size(33, 17);
            label6.TabIndex = 1;
            label6.Text = "CPF";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.BackgroundColor = Color.WhiteSmoke;
            dataGridViewClientes.BorderStyle = BorderStyle.None;
            dataGridViewClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewClientes.ColumnHeadersHeight = 50;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewClientes.EnableHeadersVisualStyles = false;
            dataGridViewClientes.Location = new Point(362, 176);
            dataGridViewClientes.Margin = new Padding(3, 2, 3, 2);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersVisible = false;
            dataGridViewClientes.RowHeadersWidth = 45;
            dataGridViewClientes.RowTemplate.Height = 40;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(898, 411);
            dataGridViewClientes.TabIndex = 24;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "CPF";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Telefone";
            Column3.Name = "Column3";
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
            panel1.TabIndex = 28;
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
            button1.Location = new Point(23, 470);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(255, 48);
            button1.TabIndex = 6;
            button1.Text = "Pedidos";
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
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 620);
            Controls.Add(panel1);
            Controls.Add(panelCadastroCliente);
            Controls.Add(dataGridViewClientes);
            Controls.Add(btnNovoCliente);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "TelaCadastro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelCadastroCliente.ResumeLayout(false);
            panelCadastroCliente.PerformLayout();
            CadastrarNovoCliente.ResumeLayout(false);
            CadastrarNovoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovoCliente;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtBuscaCliente;
        private Label label3;
        private Label label2;
        private Panel panelCadastroCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox CadastrarNovoCliente;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label9;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private TextBox txtNomeCompleto;
        private Button btnSalvarClientes;
        private Button btnCancelarCliente;
        private DataGridView dataGridViewClientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnServicos;
        private Button btnClientes;
        private Button btnEstoque;
        private Button button1;
    }
}
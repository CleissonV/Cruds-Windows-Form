namespace CrudPessoas
{
    partial class Pessoas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgPessoas = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtCpf = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            btnAdicionar = new Button();
            btnAlterar = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPessoas).BeginInit();
            SuspendLayout();
            // 
            // dgPessoas
            // 
            dgPessoas.AllowUserToAddRows = false;
            dgPessoas.AllowUserToDeleteRows = false;
            dgPessoas.AllowUserToResizeRows = false;
            dgPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPessoas.Location = new Point(0, -1);
            dgPessoas.Name = "dgPessoas";
            dgPessoas.RowTemplate.Height = 25;
            dgPessoas.Size = new Size(460, 609);
            dgPessoas.TabIndex = 0;
            dgPessoas.CellClick += dgPessoas_CellClick;
            dgPessoas.CellContentClick += dgPessoas_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(498, 51);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(498, 79);
            txtId.Name = "txtId";
            txtId.Size = new Size(223, 23);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(727, 79);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(236, 23);
            txtNome.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(727, 51);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(498, 155);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(223, 23);
            txtCpf.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 127);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 5;
            label3.Text = "Cpf";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(727, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 23);
            txtEmail.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(727, 127);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(560, 227);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(692, 227);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(837, 227);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 11;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // Pessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 606);
            Controls.Add(btnRemover);
            Controls.Add(btnAlterar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtCpf);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgPessoas);
            Name = "Pessoas";
            Text = "Pessoas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPessoas;
        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCpf;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Button btnAdicionar;
        private Button btnAlterar;
        private Button btnRemover;
    }
}
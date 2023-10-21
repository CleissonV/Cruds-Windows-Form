namespace CrudAnimais
{
    partial class Animais
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
            dgAnimais = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtRaca = new TextBox();
            label3 = new Label();
            txtProprietario = new TextBox();
            label4 = new Label();
            btnAdicionar = new Button();
            btnAlterar = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgAnimais).BeginInit();
            SuspendLayout();
            // 
            // dgAnimais
            // 
            dgAnimais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAnimais.Location = new Point(0, -1);
            dgAnimais.Name = "dgAnimais";
            dgAnimais.RowTemplate.Height = 25;
            dgAnimais.Size = new Size(435, 510);
            dgAnimais.TabIndex = 0;
            dgAnimais.CellClick += dgAnimais_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 24);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(488, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(173, 23);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(676, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(173, 23);
            txtNome.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(676, 24);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(488, 106);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(173, 23);
            txtRaca.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 88);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "Raça";
            // 
            // txtProprietario
            // 
            txtProprietario.Location = new Point(676, 106);
            txtProprietario.Name = "txtProprietario";
            txtProprietario.Size = new Size(173, 23);
            txtProprietario.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(676, 88);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Proprietário";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(532, 172);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(624, 172);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(715, 172);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 11;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // Animais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 508);
            Controls.Add(btnRemover);
            Controls.Add(btnAlterar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtProprietario);
            Controls.Add(label4);
            Controls.Add(txtRaca);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgAnimais);
            Name = "Animais";
            Text = "Animais";
            Load += Animais_Load;
            ((System.ComponentModel.ISupportInitialize)dgAnimais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgAnimais;
        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtRaca;
        private Label label3;
        private TextBox txtProprietario;
        private Label label4;
        private Button btnAdicionar;
        private Button btnAlterar;
        private Button btnRemover;
    }
}
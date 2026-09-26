namespace hafta2
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnArama = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 245);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(608, 193);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtName.Location = new Point(139, 36);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 37);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSurname.Location = new Point(139, 104);
            txtSurname.Multiline = true;
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(166, 37);
            txtSurname.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEmail.Location = new Point(139, 170);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 36);
            txtEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 104);
            label2.Name = "label2";
            label2.Size = new Size(127, 37);
            label2.TabIndex = 5;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(27, 170);
            label3.Name = "label3";
            label3.Size = new Size(88, 37);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(339, 36);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(111, 64);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Add";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnAdd_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(339, 142);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(111, 64);
            btnSil.TabIndex = 8;
            btnSil.Text = "Delete";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnDelete_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(480, 36);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(111, 64);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Update";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnUpdate_Click;
            // 
            // btnArama
            // 
            btnArama.Location = new Point(480, 142);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(111, 64);
            btnArama.TabIndex = 10;
            btnArama.Text = "Search";
            btnArama.UseVisualStyleBackColor = true;
            btnArama.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnArama);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 236);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Management";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnArama;
        private GroupBox groupBox1;
    }
}

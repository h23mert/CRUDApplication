namespace CRUDApplication
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
            button1 = new Button();
            button2Click = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(92, 395);
            button1.Name = "button1";
            button1.Size = new Size(136, 63);
            button1.TabIndex = 0;
            button1.Text = "MENÜ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2Click
            // 
            button2Click.BackColor = Color.DodgerBlue;
            button2Click.Font = new Font("Segoe UI", 13.8F);
            button2Click.ForeColor = SystemColors.ControlLightLight;
            button2Click.Location = new Point(234, 395);
            button2Click.Name = "button2Click";
            button2Click.Size = new Size(136, 63);
            button2Click.TabIndex = 1;
            button2Click.Text = "OLUŞTUR";
            button2Click.UseVisualStyleBackColor = false;
            button2Click.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Font = new Font("Segoe UI", 13.8F);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(376, 395);
            button3.Name = "button3";
            button3.Size = new Size(136, 63);
            button3.TabIndex = 2;
            button3.Text = "OKU";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Segoe UI", 13.8F);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(518, 395);
            button4.Name = "button4";
            button4.Size = new Size(136, 63);
            button4.TabIndex = 3;
            button4.Text = "GÜNCELLE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 13.8F);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(660, 395);
            button5.Name = "button5";
            button5.Size = new Size(136, 63);
            button5.TabIndex = 4;
            button5.Text = "SİL";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(200, 69);
            label1.Name = "label1";
            label1.Size = new Size(36, 31);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(200, 132);
            label2.Name = "label2";
            label2.Size = new Size(70, 31);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(200, 196);
            label3.Name = "label3";
            label3.Size = new Size(43, 31);
            label3.TabIndex = 7;
            label3.Text = "Ad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(200, 261);
            label4.Name = "label4";
            label4.Size = new Size(141, 31);
            label4.TabIndex = 8;
            label4.Text = "Kullanıcı Adı";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(200, 325);
            label5.Name = "label5";
            label5.Size = new Size(59, 31);
            label5.TabIndex = 9;
            label5.Text = "Şifre";
            label5.Click += label5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 13.8F);
            numericUpDown1.Location = new Point(399, 62);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(256, 38);
            numericUpDown1.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.8F);
            txtEmail.Location = new Point(398, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 38);
            txtEmail.TabIndex = 11;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F);
            txtName.Location = new Point(398, 191);
            txtName.Name = "txtName";
            txtName.Size = new Size(256, 38);
            txtName.TabIndex = 12;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 13.8F);
            txtUser.Location = new Point(397, 249);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(257, 38);
            txtUser.TabIndex = 13;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 13.8F);
            txtPass.Location = new Point(397, 313);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(257, 38);
            txtPass.TabIndex = 14;
            txtPass.UseSystemPasswordChar = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(704, 311);
            dataGridView1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(845, 481);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 16;
            label6.Text = "Hamza Mert Boyrazlı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1049, 554);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2Click);
            Controls.Add(button1);
            Name = "Form1";
            Text = "CRUD Application";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2Click;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtUser;
        private TextBox txtPass;
        private DataGridView dataGridView1;
        private Label label6;
    }
}

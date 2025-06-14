namespace praktekwinform
{
    partial class register
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
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            btnRegister = new Button();
            label4 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            linkLabel1.Location = new Point(1185, 504);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 25);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(1119, 469);
            label5.Name = "label5";
            label5.Size = new Size(188, 25);
            label5.TabIndex = 17;
            label5.Text = "Sudah punya akun?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkGray;
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.Font = new Font("Microsoft Sans Serif", 12F);
            btnRegister.ForeColor = Color.Honeydew;
            btnRegister.Location = new Point(1167, 424);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 42);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(1086, 272);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 15;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1086, 216);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 14;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(1086, 295);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 34);
            txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(1086, 239);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 34);
            txtUsername.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-632, 93);
            label2.Name = "label2";
            label2.Size = new Size(0, 42);
            label2.TabIndex = 11;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label1.Location = new Point(1119, 159);
            label1.Name = "label1";
            label1.Size = new Size(165, 29);
            label1.TabIndex = 10;
            label1.Text = "New Account";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Location = new Point(1086, 362);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(244, 34);
            txtConfirmPassword.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(1086, 339);
            label6.Name = "label6";
            label6.Size = new Size(168, 28);
            label6.TabIndex = 20;
            label6.Text = "Confirm Password";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.ChatGPT_Image_Jun_12__2025__05_16_11_PM;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(849, 238);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 166);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Location = new Point(31, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 699);
            panel2.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.ChatGPT_Image_Jun_12__2025__05_53_48_PM;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            panel3.Location = new Point(1168, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(71, 66);
            panel3.TabIndex = 27;
            panel3.Paint += panel3_Paint;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1519, 741);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(txtConfirmPassword);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Cursor = Cursors.PanNW;
            Name = "register";
            Text = "register";
            Load += register_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label5;
        private Button btnRegister;
        private Label label4;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private TextBox txtConfirmPassword;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
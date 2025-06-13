namespace praktekwinform
{
    partial class login
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
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnLogin = new Button();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            chkShowPassword = new CheckBox();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1124, 183);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 19;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsername.Location = new Point(1055, 265);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 30);
            txtUsername.TabIndex = 20;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.Location = new Point(1055, 322);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 30);
            txtPassword.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(1058, 240);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 22;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(1058, 299);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 23;
            label4.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gainsboro;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F);
            btnLogin.Location = new Point(1136, 376);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 24;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(1095, 414);
            label5.Name = "label5";
            label5.Size = new Size(185, 25);
            label5.TabIndex = 25;
            label5.Text = "Belum punya akun?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            linkLabel1.Location = new Point(1143, 439);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 25);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(1207, 298);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 28;
            label2.Text = "Show/Hide";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Microsoft Sans Serif", 12F);
            chkShowPassword.Location = new Point(1271, 329);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(18, 17);
            chkShowPassword.TabIndex = 27;
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.ChatGPT_Image_Jun_12__2025__05_53_48_PM;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(1124, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(84, 69);
            panel2.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.ChatGPT_Image_Jun_12__2025__05_16_11_PM;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(849, 240);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 152);
            panel1.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Location = new Point(31, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(658, 697);
            panel3.TabIndex = 30;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1516, 742);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(chkShowPassword);
            Controls.Add(linkLabel1);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private Button btnLogin;
        private Label label5;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private Label label2;
        private CheckBox chkShowPassword;
        private Panel panel1;
        private Panel panel3;
    }
}
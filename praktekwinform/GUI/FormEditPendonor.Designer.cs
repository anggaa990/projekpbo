namespace praktekwinform
{
    partial class FormEditPendonor
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
            panel1 = new Panel();
            cbRhesus = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSimpan = new Button();
            txtNoHP = new TextBox();
            txtAlamat = new TextBox();
            dtpTanggalLahir = new DateTimePicker();
            cbGolonganDarah = new ComboBox();
            cbJenisKelamin = new ComboBox();
            txtNama = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(cbRhesus);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(txtNoHP);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(dtpTanggalLahir);
            panel1.Controls.Add(cbGolonganDarah);
            panel1.Controls.Add(cbJenisKelamin);
            panel1.Controls.Add(txtNama);
            panel1.Location = new Point(307, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 427);
            panel1.TabIndex = 19;
            // 
            // cbRhesus
            // 
            cbRhesus.FormattingEnabled = true;
            cbRhesus.Location = new Point(182, 158);
            cbRhesus.Name = "cbRhesus";
            cbRhesus.Size = new Size(116, 28);
            cbRhesus.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 140);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 16;
            label7.Text = "Rhesus";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 296);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 15;
            label6.Text = "Nomor HP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 242);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 14;
            label5.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 189);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 13;
            label4.Text = "Tanggal Lahir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 140);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 12;
            label3.Text = "Golongan Darah";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 88);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 11;
            label2.Text = "Jenis Kelamin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 35);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 10;
            label1.Text = "Nama Pendonor";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(130, 352);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Update";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click_1;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(48, 319);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(250, 27);
            txtNoHP.TabIndex = 5;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(48, 265);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(250, 27);
            txtAlamat.TabIndex = 4;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(48, 212);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(250, 27);
            dtpTanggalLahir.TabIndex = 3;
            // 
            // cbGolonganDarah
            // 
            cbGolonganDarah.FormattingEnabled = true;
            cbGolonganDarah.Location = new Point(48, 158);
            cbGolonganDarah.Name = "cbGolonganDarah";
            cbGolonganDarah.Size = new Size(116, 28);
            cbGolonganDarah.TabIndex = 2;
            // 
            // cbJenisKelamin
            // 
            cbJenisKelamin.FormattingEnabled = true;
            cbJenisKelamin.Location = new Point(48, 109);
            cbJenisKelamin.Name = "cbJenisKelamin";
            cbJenisKelamin.Size = new Size(250, 28);
            cbJenisKelamin.TabIndex = 1;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(48, 58);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(250, 27);
            txtNama.TabIndex = 0;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(401, 41);
            label8.Name = "label8";
            label8.Size = new Size(141, 28);
            label8.TabIndex = 18;
            label8.Text = "Edit Pendonor";
            // 
            // FormEditPendonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(981, 575);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "FormEditPendonor";
            Text = "FormEditPendonor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox cbRhesus;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSimpan;
        private TextBox txtNoHP;
        private TextBox txtAlamat;
        private DateTimePicker dtpTanggalLahir;
        private ComboBox cbGolonganDarah;
        private ComboBox cbJenisKelamin;
        private TextBox txtNama;
        private Label label8;
    }
}
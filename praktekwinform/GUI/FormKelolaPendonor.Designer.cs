namespace praktekwinform
{
    partial class FormKelolaPendonor
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
            txtNama = new TextBox();
            cbJenisKelamin = new ComboBox();
            cbGolonganDarah = new ComboBox();
            dtpTanggalLahir = new DateTimePicker();
            txtAlamat = new TextBox();
            txtNoHP = new TextBox();
            btnSimpan = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbRhesus = new ComboBox();
            panel1 = new Panel();
            label8 = new Label();
            button1 = new Button();
            dgvPendonor = new DataGridView();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendonor).BeginInit();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtNama.Location = new Point(74, 51);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(250, 28);
            txtNama.TabIndex = 0;
            // 
            // cbJenisKelamin
            // 
            cbJenisKelamin.Font = new Font("Microsoft Sans Serif", 10.8F);
            cbJenisKelamin.FormattingEnabled = true;
            cbJenisKelamin.Location = new Point(74, 102);
            cbJenisKelamin.Name = "cbJenisKelamin";
            cbJenisKelamin.Size = new Size(250, 30);
            cbJenisKelamin.TabIndex = 1;
            // 
            // cbGolonganDarah
            // 
            cbGolonganDarah.Font = new Font("Microsoft Sans Serif", 10.8F);
            cbGolonganDarah.FormattingEnabled = true;
            cbGolonganDarah.Location = new Point(74, 151);
            cbGolonganDarah.Name = "cbGolonganDarah";
            cbGolonganDarah.Size = new Size(116, 30);
            cbGolonganDarah.TabIndex = 2;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Font = new Font("Microsoft Sans Serif", 10.8F);
            dtpTanggalLahir.Location = new Point(74, 205);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(250, 28);
            dtpTanggalLahir.TabIndex = 3;
            // 
            // txtAlamat
            // 
            txtAlamat.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtAlamat.Location = new Point(74, 258);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(250, 28);
            txtAlamat.TabIndex = 4;
            // 
            // txtNoHP
            // 
            txtNoHP.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtNoHP.Location = new Point(74, 312);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(250, 28);
            txtNoHP.TabIndex = 5;
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnSimpan.Location = new Point(156, 346);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F);
            label1.Location = new Point(74, 28);
            label1.Name = "label1";
            label1.Size = new Size(140, 22);
            label1.TabIndex = 10;
            label1.Text = "Nama Pendonor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F);
            label2.Location = new Point(74, 81);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 11;
            label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F);
            label3.Location = new Point(74, 133);
            label3.Name = "label3";
            label3.Size = new Size(142, 22);
            label3.TabIndex = 12;
            label3.Text = "Golongan Darah";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F);
            label4.Location = new Point(75, 182);
            label4.Name = "label4";
            label4.Size = new Size(121, 22);
            label4.TabIndex = 13;
            label4.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F);
            label5.Location = new Point(74, 235);
            label5.Name = "label5";
            label5.Size = new Size(65, 22);
            label5.TabIndex = 14;
            label5.Text = "Alamat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F);
            label6.Location = new Point(75, 289);
            label6.Name = "label6";
            label6.Size = new Size(93, 22);
            label6.TabIndex = 15;
            label6.Text = "Nomor HP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F);
            label7.Location = new Point(238, 133);
            label7.Name = "label7";
            label7.Size = new Size(71, 22);
            label7.TabIndex = 16;
            label7.Text = "Rhesus";
            // 
            // cbRhesus
            // 
            cbRhesus.Font = new Font("Microsoft Sans Serif", 10.8F);
            cbRhesus.FormattingEnabled = true;
            cbRhesus.Location = new Point(208, 151);
            cbRhesus.Name = "cbRhesus";
            cbRhesus.Size = new Size(116, 30);
            cbRhesus.TabIndex = 17;
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
            panel1.Location = new Point(116, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 446);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(232, 80);
            label8.Name = "label8";
            label8.Size = new Size(188, 28);
            label8.TabIndex = 19;
            label8.Text = "Kelola Pendonor";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 14);
            button1.Name = "button1";
            button1.Size = new Size(135, 37);
            button1.TabIndex = 20;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dgvPendonor
            // 
            dgvPendonor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendonor.Location = new Point(542, 123);
            dgvPendonor.Name = "dgvPendonor";
            dgvPendonor.RowHeadersWidth = 51;
            dgvPendonor.Size = new Size(959, 446);
            dgvPendonor.TabIndex = 21;
            dgvPendonor.CellContentClick += dgvPendonor_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(923, 80);
            label9.Name = "label9";
            label9.Size = new Size(233, 28);
            label9.TabIndex = 22;
            label9.Text = "Tabel Data Pendonor";
            // 
            // FormKelolaPendonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1513, 739);
            Controls.Add(label9);
            Controls.Add(dgvPendonor);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "FormKelolaPendonor";
            Text = "FormKelolaPendonor";
            Load += FormKelolaPendonor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendonor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNama;
        private ComboBox cbJenisKelamin;
        private ComboBox cbGolonganDarah;
        private DateTimePicker dtpTanggalLahir;
        private TextBox txtAlamat;
        private TextBox txtNoHP;
        private Button btnSimpan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbRhesus;
        private Panel panel1;
        private Label label8;
        private Button button1;
        private DataGridView dgvPendonor;
        private Label label9;
    }
}
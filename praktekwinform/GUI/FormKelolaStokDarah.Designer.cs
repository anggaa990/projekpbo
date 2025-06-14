namespace praktekwinform
{
    partial class FormKelolaStokDarah
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
            comboBoxPendonor = new ComboBox();
            label2 = new Label();
            txtGolonganDarah = new TextBox();
            label3 = new Label();
            txtRhesus = new TextBox();
            label4 = new Label();
            dtTanggalMasuk = new DateTimePicker();
            label5 = new Label();
            dtTanggalExp = new DateTimePicker();
            label6 = new Label();
            txtJumlahKantong = new TextBox();
            btnSimpan = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            dataGridViewStok = new DataGridView();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStok).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(152, 32);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Pendonor";
            // 
            // comboBoxPendonor
            // 
            comboBoxPendonor.Font = new Font("Microsoft Sans Serif", 12F);
            comboBoxPendonor.FormattingEnabled = true;
            comboBoxPendonor.Location = new Point(77, 60);
            comboBoxPendonor.Name = "comboBoxPendonor";
            comboBoxPendonor.Size = new Size(232, 33);
            comboBoxPendonor.TabIndex = 1;
            comboBoxPendonor.SelectedIndexChanged += comboBoxPendonor_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(60, 96);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 2;
            label2.Text = "Golongan darah";
            // 
            // txtGolonganDarah
            // 
            txtGolonganDarah.Font = new Font("Microsoft Sans Serif", 12F);
            txtGolonganDarah.Location = new Point(77, 124);
            txtGolonganDarah.Name = "txtGolonganDarah";
            txtGolonganDarah.ReadOnly = true;
            txtGolonganDarah.Size = new Size(116, 30);
            txtGolonganDarah.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(218, 96);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "Rhesus";
            // 
            // txtRhesus
            // 
            txtRhesus.Font = new Font("Microsoft Sans Serif", 12F);
            txtRhesus.Location = new Point(215, 124);
            txtRhesus.Name = "txtRhesus";
            txtRhesus.ReadOnly = true;
            txtRhesus.Size = new Size(94, 30);
            txtRhesus.TabIndex = 5;
            txtRhesus.TextChanged += txtRhesus_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(130, 170);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 6;
            label4.Text = "Tanggal masuk";
            // 
            // dtTanggalMasuk
            // 
            dtTanggalMasuk.Font = new Font("Microsoft Sans Serif", 12F);
            dtTanggalMasuk.Location = new Point(77, 198);
            dtTanggalMasuk.Name = "dtTanggalMasuk";
            dtTanggalMasuk.Size = new Size(232, 30);
            dtTanggalMasuk.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(107, 253);
            label5.Name = "label5";
            label5.Size = new Size(189, 25);
            label5.TabIndex = 8;
            label5.Text = "Tanggal Kadaluarsa";
            // 
            // dtTanggalExp
            // 
            dtTanggalExp.Font = new Font("Microsoft Sans Serif", 12F);
            dtTanggalExp.Location = new Point(77, 281);
            dtTanggalExp.Name = "dtTanggalExp";
            dtTanggalExp.Size = new Size(232, 30);
            dtTanggalExp.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(119, 338);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 10;
            label6.Text = "Jumlah kantong";
            // 
            // txtJumlahKantong
            // 
            txtJumlahKantong.Font = new Font("Microsoft Sans Serif", 12F);
            txtJumlahKantong.Location = new Point(77, 366);
            txtJumlahKantong.Name = "txtJumlahKantong";
            txtJumlahKantong.Size = new Size(232, 30);
            txtJumlahKantong.TabIndex = 11;
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Microsoft Sans Serif", 12F);
            btnSimpan.Location = new Point(130, 434);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(140, 40);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(32, 21);
            button2.Name = "button2";
            button2.Size = new Size(148, 41);
            button2.TabIndex = 14;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(txtJumlahKantong);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtTanggalExp);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtTanggalMasuk);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtRhesus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtGolonganDarah);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxPendonor);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(196, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 501);
            panel1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(303, 82);
            label7.Name = "label7";
            label7.Size = new Size(170, 28);
            label7.TabIndex = 16;
            label7.Text = "Masukkan Stok";
            // 
            // dataGridViewStok
            // 
            dataGridViewStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStok.Location = new Point(601, 113);
            dataGridViewStok.Name = "dataGridViewStok";
            dataGridViewStok.RowHeadersWidth = 51;
            dataGridViewStok.Size = new Size(900, 501);
            dataGridViewStok.TabIndex = 17;
            dataGridViewStok.CellContentClick += dataGridViewStok_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(921, 82);
            label8.Name = "label8";
            label8.Size = new Size(246, 28);
            label8.TabIndex = 18;
            label8.Text = "Tabel Data Stok Darah";
            // 
            // FormKelolaStokDarah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1513, 740);
            Controls.Add(label8);
            Controls.Add(dataGridViewStok);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(button2);
            Name = "FormKelolaStokDarah";
            Text = "FormKelolaStokDarah";
            Load += FormKelolaStokDarah_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxPendonor;
        private Label label2;
        private TextBox txtGolonganDarah;
        private Label label3;
        private TextBox txtRhesus;
        private Label label4;
        private DateTimePicker dtTanggalMasuk;
        private Label label5;
        private DateTimePicker dtTanggalExp;
        private Label label6;
        private TextBox txtJumlahKantong;
        private Button btnSimpan;
        private Button button2;
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridViewStok;
        private Label label8;
    }
}
namespace praktekwinform
{
    partial class FormKelolaPermintaan
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
            txtRumahSakit = new TextBox();
            txtJumlah = new TextBox();
            txtPengaju = new TextBox();
            cbRhesus = new ComboBox();
            cbGolongan = new ComboBox();
            dtpTanggal = new DateTimePicker();
            btnTambah = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtRumahSakit
            // 
            txtRumahSakit.Font = new Font("Microsoft Sans Serif", 12F);
            txtRumahSakit.Location = new Point(249, 55);
            txtRumahSakit.Name = "txtRumahSakit";
            txtRumahSakit.Size = new Size(240, 30);
            txtRumahSakit.TabIndex = 0;
            txtRumahSakit.TextChanged += textBox1_TextChanged;
            // 
            // txtJumlah
            // 
            txtJumlah.Font = new Font("Microsoft Sans Serif", 12F);
            txtJumlah.Location = new Point(249, 223);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(240, 30);
            txtJumlah.TabIndex = 1;
            // 
            // txtPengaju
            // 
            txtPengaju.Font = new Font("Microsoft Sans Serif", 12F);
            txtPengaju.Location = new Point(249, 101);
            txtPengaju.Name = "txtPengaju";
            txtPengaju.Size = new Size(240, 30);
            txtPengaju.TabIndex = 2;
            // 
            // cbRhesus
            // 
            cbRhesus.Font = new Font("Microsoft Sans Serif", 12F);
            cbRhesus.FormattingEnabled = true;
            cbRhesus.Location = new Point(249, 182);
            cbRhesus.Name = "cbRhesus";
            cbRhesus.Size = new Size(240, 33);
            cbRhesus.Sorted = true;
            cbRhesus.TabIndex = 3;
            // 
            // cbGolongan
            // 
            cbGolongan.Font = new Font("Microsoft Sans Serif", 12F);
            cbGolongan.FormattingEnabled = true;
            cbGolongan.Location = new Point(249, 140);
            cbGolongan.Name = "cbGolongan";
            cbGolongan.Size = new Size(240, 33);
            cbGolongan.TabIndex = 4;
            cbGolongan.SelectedIndexChanged += cbGolongan_SelectedIndexChanged;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Font = new Font("Microsoft Sans Serif", 12F);
            dtpTanggal.Location = new Point(249, 263);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(240, 30);
            dtpTanggal.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.Font = new Font("Microsoft Sans Serif", 12F);
            btnTambah.Location = new Point(205, 333);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(135, 42);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Simpan";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(63, 58);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 8;
            label1.Text = "Nama Rumah Sakit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(63, 104);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 9;
            label2.Text = "Nama Pengaju";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(63, 148);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 10;
            label3.Text = "Golongan Darah";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(64, 185);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 11;
            label4.Text = "Rhesus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(64, 223);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 12;
            label5.Text = "Jumlah";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(55, 268);
            label6.Name = "label6";
            label6.Size = new Size(188, 25);
            label6.TabIndex = 13;
            label6.Text = "Tanggal Permintaan";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(dtpTanggal);
            panel1.Controls.Add(cbGolongan);
            panel1.Controls.Add(cbRhesus);
            panel1.Controls.Add(txtPengaju);
            panel1.Controls.Add(txtJumlah);
            panel1.Controls.Add(txtRumahSakit);
            panel1.Location = new Point(61, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 539);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(225, 106);
            label7.Name = "label7";
            label7.Size = new Size(225, 28);
            label7.TabIndex = 15;
            label7.Text = "Tambah Permintaan";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(34, 29);
            button1.Name = "button1";
            button1.Size = new Size(125, 41);
            button1.TabIndex = 16;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(945, 106);
            label8.Name = "label8";
            label8.Size = new Size(254, 28);
            label8.TabIndex = 17;
            label8.Text = "Tabel Data Permintaan";
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(630, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(878, 539);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormKelolaPermintaan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1520, 746);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(panel1);
            Name = "FormKelolaPermintaan";
            Text = "FormKelolaPermintaan";
            Load += FormKelolaPermintaan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRumahSakit;
        private TextBox txtJumlah;
        private TextBox txtPengaju;
        private ComboBox cbRhesus;
        private ComboBox cbGolongan;
        private DateTimePicker dtpTanggal;
        private Button btnTambah;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private Button button1;
        private Label label8;
        private DataGridView dataGridView1;
    }
}
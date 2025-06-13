namespace praktekwinform
{
    partial class FormKelolaEvent
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
            dgvEvents = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSimpan = new Button();
            txtDeskripsi = new TextBox();
            txtWaktu = new TextBox();
            dtpTanggal = new DateTimePicker();
            txtAlamat = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEvents
            // 
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(418, 140);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.Size = new Size(1086, 469);
            dgvEvents.TabIndex = 0;
            dgvEvents.CellContentClick += dgvEvents_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold);
            label1.Location = new Point(616, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 1;
            label1.Text = "Event Donor Keliling";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(25, 19);
            button2.Name = "button2";
            button2.Size = new Size(144, 44);
            button2.TabIndex = 3;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold);
            label2.Location = new Point(828, 106);
            label2.Name = "label2";
            label2.Size = new Size(191, 28);
            label2.TabIndex = 4;
            label2.Text = "Tabel Data event";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(txtDeskripsi);
            panel1.Controls.Add(txtWaktu);
            panel1.Controls.Add(dtpTanggal);
            panel1.Controls.Add(txtAlamat);
            panel1.Location = new Point(54, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 469);
            panel1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(38, 265);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 9;
            label4.Text = "Deskripsi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(38, 190);
            label3.Name = "label3";
            label3.Size = new Size(191, 25);
            label3.TabIndex = 8;
            label3.Text = "Waktu event (12:00)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(38, 116);
            label5.Name = "label5";
            label5.Size = new Size(137, 25);
            label5.TabIndex = 7;
            label5.Text = "Tanggal event";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(38, 44);
            label6.Name = "label6";
            label6.Size = new Size(126, 25);
            label6.TabIndex = 6;
            label6.Text = "Alamat event";
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Microsoft Sans Serif", 12F);
            btnSimpan.Location = new Point(95, 324);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(105, 35);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Font = new Font("Microsoft Sans Serif", 12F);
            txtDeskripsi.Location = new Point(38, 288);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(216, 30);
            txtDeskripsi.TabIndex = 3;
            // 
            // txtWaktu
            // 
            txtWaktu.Font = new Font("Microsoft Sans Serif", 12F);
            txtWaktu.Location = new Point(38, 213);
            txtWaktu.Name = "txtWaktu";
            txtWaktu.Size = new Size(216, 30);
            txtWaktu.TabIndex = 2;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Font = new Font("Microsoft Sans Serif", 12F);
            dtpTanggal.Location = new Point(38, 139);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(216, 30);
            dtpTanggal.TabIndex = 1;
            // 
            // txtAlamat
            // 
            txtAlamat.Font = new Font("Microsoft Sans Serif", 12F);
            txtAlamat.Location = new Point(38, 67);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(216, 30);
            txtAlamat.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold);
            label7.Location = new Point(130, 106);
            label7.Name = "label7";
            label7.Size = new Size(162, 28);
            label7.TabIndex = 12;
            label7.Text = "Tambah Event";
            // 
            // FormKelolaEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1516, 744);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dgvEvents);
            Name = "FormKelolaEvent";
            Text = "FormKelolaEvent";
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEvents;
        private Label label1;
        private Button button2;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btnSimpan;
        private TextBox txtDeskripsi;
        private TextBox txtWaktu;
        private DateTimePicker dtpTanggal;
        private TextBox txtAlamat;
        private Label label7;
    }
}
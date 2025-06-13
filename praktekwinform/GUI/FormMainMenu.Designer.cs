namespace praktekwinform
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            label1 = new Label();
            btnPendonor = new Button();
            btnEvent = new Button();
            btnPermintaan = new Button();
            btnStokDarah = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dataGridMasuk = new DataGridView();
            dataGridKeluar = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMasuk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridKeluar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 74);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 5;
            label1.Text = "MainMenu";
            // 
            // btnPendonor
            // 
            btnPendonor.Font = new Font("Trebuchet MS", 13.8F);
            btnPendonor.Location = new Point(123, 76);
            btnPendonor.Name = "btnPendonor";
            btnPendonor.Size = new Size(301, 55);
            btnPendonor.TabIndex = 0;
            btnPendonor.Text = "Kelola Pendonor";
            btnPendonor.UseVisualStyleBackColor = true;
            btnPendonor.Click += btnPendonor_Click;
            // 
            // btnEvent
            // 
            btnEvent.Font = new Font("Trebuchet MS", 13.8F);
            btnEvent.Location = new Point(123, 264);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(301, 52);
            btnEvent.TabIndex = 1;
            btnEvent.Text = "Kelola Event donor";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click_1;
            // 
            // btnPermintaan
            // 
            btnPermintaan.Font = new Font("Trebuchet MS", 13.8F);
            btnPermintaan.Location = new Point(123, 198);
            btnPermintaan.Name = "btnPermintaan";
            btnPermintaan.Size = new Size(301, 53);
            btnPermintaan.TabIndex = 2;
            btnPermintaan.Text = "Kelola Permintaan darah";
            btnPermintaan.UseVisualStyleBackColor = true;
            btnPermintaan.Click += btnPermintaan_Click_1;
            // 
            // btnStokDarah
            // 
            btnStokDarah.Font = new Font("Trebuchet MS", 13.8F);
            btnStokDarah.Location = new Point(123, 137);
            btnStokDarah.Name = "btnStokDarah";
            btnStokDarah.Size = new Size(301, 55);
            btnStokDarah.TabIndex = 3;
            btnStokDarah.Text = "Kelola Stok darah";
            btnStokDarah.UseVisualStyleBackColor = true;
            btnStokDarah.Click += btnStokDarah_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(123, 406);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(301, 52);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnEvent);
            panel1.Controls.Add(btnPermintaan);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(btnStokDarah);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btnPendonor);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(91, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 508);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(53, 406);
            panel5.Name = "panel5";
            panel5.Size = new Size(64, 52);
            panel5.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Location = new Point(53, 264);
            panel7.Name = "panel7";
            panel7.Size = new Size(64, 52);
            panel7.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(53, 198);
            panel6.Name = "panel6";
            panel6.Size = new Size(64, 52);
            panel6.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(53, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(64, 55);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(53, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(64, 55);
            panel4.TabIndex = 10;
            panel4.Paint += panel4_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(983, 74);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 10;
            label2.Text = "Laporan";
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridMasuk
            // 
            dataGridMasuk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMasuk.Location = new Point(629, 169);
            dataGridMasuk.Name = "dataGridMasuk";
            dataGridMasuk.RowHeadersWidth = 51;
            dataGridMasuk.Size = new Size(818, 166);
            dataGridMasuk.TabIndex = 11;
            dataGridMasuk.CellContentClick += dataGridMasuk_CellContentClick;
            // 
            // dataGridKeluar
            // 
            dataGridKeluar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridKeluar.Location = new Point(629, 404);
            dataGridKeluar.Name = "dataGridKeluar";
            dataGridKeluar.RowHeadersWidth = 51;
            dataGridKeluar.Size = new Size(818, 174);
            dataGridKeluar.TabIndex = 12;
            dataGridKeluar.CellContentClick += dataGridKeluar_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.Location = new Point(629, 130);
            label3.Name = "label3";
            label3.Size = new Size(165, 29);
            label3.TabIndex = 13;
            label3.Text = "Darah masuk :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F);
            label4.Location = new Point(631, 361);
            label4.Name = "label4";
            label4.Size = new Size(161, 29);
            label4.TabIndex = 14;
            label4.Text = "Darah keluar :";
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1511, 657);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridKeluar);
            Controls.Add(dataGridMasuk);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormMainMenu";
            Text = "Mainmenu";
            Load += FormMainMenu_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridMasuk).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridKeluar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnPendonor;
        private Button btnEvent;
        private Button btnPermintaan;
        private Button btnStokDarah;
        private Button btnLogout;
        private Panel panel1;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panel4;
        private Panel panel2;
        private Label label2;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dataGridMasuk;
        private DataGridView dataGridKeluar;
        private Label label3;
        private Label label4;
    }
}
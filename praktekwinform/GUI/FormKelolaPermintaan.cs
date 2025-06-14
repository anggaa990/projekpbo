using Npgsql;
using praktekwinform.Design;
using praktekwinform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktekwinform
{
    public partial class FormKelolaPermintaan : Form
    {
        public FormKelolaPermintaan()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Columns.Clear();

            var permintaan = new PermintaanDarah();
            var dt = permintaan.GetAll();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Data tidak ditemukan di tabel permintaan_darah.");
            }

            dataGridView1.DataSource = dt;
            TambahTombolAksi();
        }

        private void FormKelolaPermintaan_Load(object sender, EventArgs e)
        {
            cbGolongan.Items.AddRange(new string[] { "A", "B", "AB", "O" });
            cbRhesus.Items.AddRange(new string[] { "Positif", "Negatif" });
            cbGolongan.SelectedIndex = 0;
            cbRhesus.SelectedIndex = 0;

            datagridviewstyle.ApplyDefaultStyle(dataGridView1);
        }

        private void TambahTombolAksi()
        {

            if (dataGridView1.Columns["btnSetujui"] == null)
            {
                dataGridView1.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Aksi",
                    Text = "Setujui",
                    Name = "btnSetujui",
                    UseColumnTextForButtonValue = true
                });

                dataGridView1.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "",
                    Text = "Tolak",
                    Name = "btnTolak",
                    UseColumnTextForButtonValue = true
                });

                dataGridView1.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "",
                    Text = "Hapus",
                    Name = "btnHapus",
                    UseColumnTextForButtonValue = true
                });
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRumahSakit.Text) ||
        string.IsNullOrWhiteSpace(txtPengaju.Text) ||
        string.IsNullOrWhiteSpace(txtJumlah.Text))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi input jumlah harus angka
            if (!int.TryParse(txtJumlah.Text.Trim(), out int jumlahDarah))
            {
                MessageBox.Show("Jumlah harus berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var permintaan = new PermintaanDarah
            {
                NamaRS = txtRumahSakit.Text.Trim(),
                NamaPengaju = txtPengaju.Text.Trim(),
                GolonganDarah = cbGolongan.Text,
                Rhesus = cbRhesus.Text,
                Jumlah = jumlahDarah,
                TanggalPermintaan = dtpTanggal.Value,
                Status = "Menunggu"
            };

            bool berhasil = permintaan.SimpanSaja();

            if (berhasil)
                MessageBox.Show("Permintaan berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Gagal menyimpan permintaan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = "Admin";
            FormMainMenu form = new FormMainMenu(username);
            this.Hide();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                var permintaan = new PermintaanDarah();

                string kolom = dataGridView1.Columns[e.ColumnIndex].Name;

                if (kolom == "btnSetujui")
                {
                    if (permintaan.Setujui(id))
                        MessageBox.Show("Permintaan disetujui dan stok dikurangi.");
                    else
                        MessageBox.Show("Stok darah tidak mencukupi!");
                }
                else if (kolom == "btnTolak")
                {
                    if (permintaan.Tolak(id))
                        MessageBox.Show("Permintaan ditolak.");
                    else
                        MessageBox.Show("Gagal menolak permintaan.");
                }
                else if (kolom == "btnHapus")
                {
                    var konfirmasi = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (konfirmasi == DialogResult.Yes)
                    {
                        if (permintaan.Hapus(id))
                            MessageBox.Show("Permintaan dihapus.");
                        else
                            MessageBox.Show("Gagal menghapus permintaan.");
                    }
                }

                LoadData(); // Refresh data setiap aksi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbGolongan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

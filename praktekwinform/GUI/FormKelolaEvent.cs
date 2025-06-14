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
    public partial class FormKelolaEvent : Form
    {
        public Event EventData { get; set; }
        public FormKelolaEvent()
        {
            InitializeComponent();
            LoadData();
            this.dgvEvents.CellContentClick += new DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
            this.Load += FormKelolaEvent_Load;
        }

        private void ClearForm()
        {
            txtAlamat.Text = "";
            dtpTanggal.Value = DateTime.Today;
            txtWaktu.Text = "";
            txtDeskripsi.Text = "";
            EventData = null;
        }

        private void FormKelolaEvent_Load(object sender, EventArgs e)
        {
            ClearForm();
            datagridviewstyle.ApplyDefaultStyle(dgvEvents);
        }

        private void LoadData()
        {
            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                var dt = new DataTable();
                var da = new NpgsqlDataAdapter("SELECT * FROM events ORDER BY tanggal", conn);
                da.Fill(dt);
                dgvEvents.DataSource = dt;
            }

            // Header kolom
            if (dgvEvents.Columns.Contains("id")) dgvEvents.Columns["id"].HeaderText = "ID";
            if (dgvEvents.Columns.Contains("alamat")) dgvEvents.Columns["alamat"].HeaderText = "Alamat";
            if (dgvEvents.Columns.Contains("tanggal")) dgvEvents.Columns["tanggal"].HeaderText = "Tanggal";
            if (dgvEvents.Columns.Contains("waktu")) dgvEvents.Columns["waktu"].HeaderText = "Waktu";
            if (dgvEvents.Columns.Contains("deskripsi")) dgvEvents.Columns["deskripsi"].HeaderText = "Deskripsi";

            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tambah tombol edit & hapus jika belum ada
            if (!dgvEvents.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Edit";
                btnEdit.Text = "Edit";
                btnEdit.Name = "btnEdit";
                btnEdit.UseColumnTextForButtonValue = true;
                dgvEvents.Columns.Add(btnEdit);
            }
            if (!dgvEvents.Columns.Contains("btnHapus"))
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.HeaderText = "Hapus";
                btnHapus.Text = "Hapus";
                btnHapus.Name = "btnHapus";
                btnHapus.UseColumnTextForButtonValue = true;
                dgvEvents.Columns.Add(btnHapus);
            }
        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvEvents.Rows[e.RowIndex];

                if (dgvEvents.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                    // Langsung isi input dengan data baris yang dipilih
                    EventData = new Event
                    {
                        Id = Convert.ToInt32(row.Cells["id"].Value),
                        Alamat = row.Cells["alamat"].Value.ToString(),
                        Tanggal = Convert.ToDateTime(row.Cells["tanggal"].Value),
                        Waktu = row.Cells["waktu"].Value.ToString(),
                        Deskripsi = row.Cells["deskripsi"].Value.ToString()
                    };
                    txtAlamat.Text = EventData.Alamat;
                    dtpTanggal.Value = EventData.Tanggal;
                    txtWaktu.Text = EventData.Waktu;
                    txtDeskripsi.Text = EventData.Deskripsi;
                }
                else if (dgvEvents.Columns[e.ColumnIndex].Name == "btnHapus")
                {
                    int id = Convert.ToInt32(row.Cells["id"].Value);
                    var confirm = MessageBox.Show("Hapus event ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        using (var conn = new NpgsqlConnection(Database.ConnString))
                        {
                            conn.Open();
                            var cmd = new NpgsqlCommand("DELETE FROM events WHERE id = @id", conn);
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                        }
                        LoadData();
                        ClearForm();
                    }
                }
            }
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                string.IsNullOrWhiteSpace(txtWaktu.Text) ||
                string.IsNullOrWhiteSpace(txtDeskripsi.Text))
            {
                MessageBox.Show("Semua data harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                NpgsqlCommand cmd;
                if (EventData == null)
                {
                    // Tambah baru
                    cmd = new NpgsqlCommand("INSERT INTO events (alamat, tanggal, waktu, deskripsi) VALUES (@alamat, @tanggal, @waktu, @deskripsi)", conn);
                }
                else
                {
                    // Update
                    cmd = new NpgsqlCommand("UPDATE events SET alamat = @alamat, tanggal = @tanggal, waktu = @waktu, deskripsi = @deskripsi WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("id", EventData.Id);
                }
                cmd.Parameters.AddWithValue("alamat", txtAlamat.Text.Trim());
                cmd.Parameters.AddWithValue("tanggal", dtpTanggal.Value.Date);
                cmd.Parameters.AddWithValue("waktu", txtWaktu.Text.Trim());
                cmd.Parameters.AddWithValue("deskripsi", txtDeskripsi.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data event berhasil disimpan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = "Admin";
            FormMainMenu form = new FormMainMenu(username);
            this.Hide();
            form.ShowDialog();
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {

        }

        private void dgvEvents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

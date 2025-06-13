using Npgsql;
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
    public partial class FormEditPendonor : Form
    {
        private int _id;

        public FormEditPendonor(int id, string nama, string jenisKelamin, string golonganDarah, string rhesus,
                                DateTime tanggalLahir, string alamat, string noHp)
        {
            InitializeComponent();
            this.Load += FormEditPendonor_Load;
            _id = id;

            txtNama.Text = nama;
            cbJenisKelamin.SelectedItem = jenisKelamin;
            cbGolonganDarah.SelectedItem = golonganDarah;
            cbRhesus.SelectedItem = rhesus;
            dtpTanggalLahir.Value = tanggalLahir;
            txtAlamat.Text = alamat;
            txtNoHP.Text = noHp;
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"
                    UPDATE pendonor SET
                        nama = @nama,
                        jenis_kelamin = @jk,
                        golongan_darah = @gol,
                        rhesus = @rhesus,
                        tanggal_lahir = @tgl,
                        alamat = @alamat,
                        no_hp = @hp
                    WHERE id = @id", conn);

                cmd.Parameters.AddWithValue("nama", txtNama.Text);
                cmd.Parameters.AddWithValue("jk", cbJenisKelamin.Text);
                cmd.Parameters.AddWithValue("gol", cbGolonganDarah.Text);
                cmd.Parameters.AddWithValue("rhesus", cbRhesus.Text);
                cmd.Parameters.AddWithValue("tgl", dtpTanggalLahir.Value);
                cmd.Parameters.AddWithValue("alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("hp", txtNoHP.Text);
                cmd.Parameters.AddWithValue("id", _id);

                cmd.ExecuteNonQuery();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormEditPendonor_Load(object sender, EventArgs e)
        {
            cbJenisKelamin.Items.Clear();
            cbGolonganDarah.Items.Clear();
            cbRhesus.Items.Clear();

            cbJenisKelamin.Items.AddRange(new string[] { "Laki-laki", "Perempuan" });
            cbGolonganDarah.Items.AddRange(new string[] { "A", "B", "AB", "O" });
            cbRhesus.Items.AddRange(new string[] { "Positif", "Negatif" });
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

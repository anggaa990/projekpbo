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
    public partial class FormMainMenu : Form
    {
        private string username;

        public FormMainMenu(string username)
        {
            InitializeComponent();
            this.username = username;
            this.Load += FormMainMenu_Load;
        }

        private void btnPendonor_Click(object sender, EventArgs e)
        {
            FormKelolaPendonor form = new FormKelolaPendonor();
            this.Hide();
            form.ShowDialog();
        }

        private void btnStokDarah_Click_1(object sender, EventArgs e)
        {
            FormKelolaStokDarah form = new FormKelolaStokDarah();
            this.Hide();
            form.ShowDialog();
        }

        private void btnPermintaan_Click_1(object sender, EventArgs e)
        {
            FormKelolaPermintaan form = new FormKelolaPermintaan();
            this.Hide();
            form.ShowDialog();
        }

        private void btnEvent_Click_1(object sender, EventArgs e)
        {
            FormKelolaEvent form = new FormKelolaEvent();
            this.Hide();
            form.ShowDialog();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            LoadLaporanDarah();
        }

        private void LoadLaporanDarah()
        {
            var laporan = new LaporanDarah();

            try
            {
                dataGridMasuk.DataSource = laporan.GetDarahMasuk();
                
                if (dataGridMasuk.Columns.Contains("golongan_darah"))
                    dataGridMasuk.Columns["golongan_darah"].HeaderText = "Golongan Darah";
                if (dataGridMasuk.Columns.Contains("rhesus"))
                    dataGridMasuk.Columns["rhesus"].HeaderText = "Rhesus";
                if (dataGridMasuk.Columns.Contains("jumlah_kantong"))
                    dataGridMasuk.Columns["jumlah_kantong"].HeaderText = "Jumlah";

                datagridviewstyle.ApplyLaporanStyle(dataGridMasuk);
                datagridviewstyle.StretchAllColumns(dataGridMasuk);

                dataGridKeluar.DataSource = laporan.GetDarahKeluar();
                
                if (dataGridKeluar.Columns.Contains("nama_rs"))
                    dataGridKeluar.Columns["nama_rs"].HeaderText = "Nama Instansi";
                if (dataGridKeluar.Columns.Contains("golongan_darah"))
                    dataGridKeluar.Columns["golongan_darah"].HeaderText = "Golongan Darah";
                if (dataGridKeluar.Columns.Contains("rhesus"))
                    dataGridKeluar.Columns["rhesus"].HeaderText = "Rhesus";
                if (dataGridKeluar.Columns.Contains("jumlah"))
                    dataGridKeluar.Columns["jumlah"].HeaderText = "Jumlah";
                if (dataGridKeluar.Columns.Contains("tanggal_permintaan"))
                    dataGridKeluar.Columns["tanggal_permintaan"].HeaderText = "Tanggal Permintaan";

                datagridviewstyle.ApplyLaporanStyle(dataGridKeluar);
                datagridviewstyle.StretchAllColumns(dataGridKeluar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message);
            }
        }


        private void dataGridKeluar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridMasuk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMainMenu_Load_1(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

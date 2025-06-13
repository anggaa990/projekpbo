using Npgsql;
using System.Data;

namespace praktekwinform.Model
{
    public class LaporanDarah
    {
        public DataTable GetDarahMasuk()
        {
            using var conn = new NpgsqlConnection(Database.ConnString);
            conn.Open();
            string query = "SELECT golongan_darah, rhesus, jumlah_kantong FROM stokdarah";
            using var cmd = new NpgsqlCommand(query, conn);
            using var da = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetDarahKeluar()
        {
            using var conn = new NpgsqlConnection(Database.ConnString);
            conn.Open();
            string query = @"SELECT nama_rs, golongan_darah, rhesus, jumlah, tanggal_permintaan 
                             FROM permintaan_darah WHERE status = 'Disetujui'";
            using var cmd = new NpgsqlCommand(query, conn);
            using var da = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

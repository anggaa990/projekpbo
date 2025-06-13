using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktekwinform.Model
{
    public class PermintaanDarah
    {
        public int Id { get; set; }
        public string NamaRS { get; set; }
        public string NamaPengaju { get; set; }
        public string GolonganDarah { get; set; }
        public string Rhesus { get; set; }
        public int Jumlah { get; set; }
        public DateTime TanggalPermintaan { get; set; }
        public string Status { get; set; }


        public bool SimpanSaja()
        {
            try
            {
                using (var conn = new NpgsqlConnection(Database.ConnString))
                {
                    conn.Open();
                    string query = @"INSERT INTO permintaan_darah 
                             (nama_rs, nama_pengaju, golongan_darah, rhesus, jumlah, tanggal_permintaan, status)
                             VALUES (@rs, @pengaju, @gd, @rhesus, @jumlah, @tanggal, @status)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rs", NamaRS);
                        cmd.Parameters.AddWithValue("@pengaju", NamaPengaju);
                        cmd.Parameters.AddWithValue("@gd", GolonganDarah);
                        cmd.Parameters.AddWithValue("@rhesus", Rhesus);
                        cmd.Parameters.AddWithValue("@jumlah", Jumlah);
                        cmd.Parameters.AddWithValue("@tanggal", TanggalPermintaan);
                        cmd.Parameters.AddWithValue("@status", Status);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool Setujui(int id)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Database.ConnString))
                {
                    conn.Open();

                    // Kurangi stok
                    string updateStok = @"UPDATE stokdarah 
                                  SET jumlah_kantong = jumlah_kantong - (SELECT jumlah FROM permintaan_darah WHERE id_permintaan = @id)
                                  WHERE golongan_darah = (SELECT golongan_darah FROM permintaan_darah WHERE id_permintaan = @id)
                                  AND rhesus = (SELECT rhesus FROM permintaan_darah WHERE id_permintaan = @id)
                                  AND jumlah_kantong >= (SELECT jumlah FROM permintaan_darah WHERE id_permintaan = @id);";

                    using (var cmdStok = new NpgsqlCommand(updateStok, conn))
                    {
                        cmdStok.Parameters.AddWithValue("@id", id);
                        int affected = cmdStok.ExecuteNonQuery();

                        if (affected == 0) return false; // stok tidak cukup
                    }

                    // Update status jadi "Disetujui"
                    string update = @"UPDATE permintaan_darah SET status = 'Disetujui' WHERE id_permintaan = @id";
                    using (var cmd = new NpgsqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool Tolak(int id)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Database.ConnString))
                {
                    conn.Open();
                    string query = @"UPDATE permintaan_darah SET status = 'Ditolak' WHERE id_permintaan = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool Hapus(int id)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Database.ConnString))
                {
                    conn.Open();
                    string query = @"DELETE FROM permintaan_darah WHERE id_permintaan = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public DataTable GetAll()
        {
            using var conn = new NpgsqlConnection(Database.ConnString);
            conn.Open();

            string query = @"SELECT 
                                id_permintaan AS id, 
                                nama_rs, 
                                nama_pengaju, 
                                golongan_darah, 
                                rhesus, 
                                jumlah, 
                                tanggal_permintaan, 
                                status 
                             FROM permintaan_darah";

            using var cmd = new NpgsqlCommand(query, conn);
            using var da = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }

}

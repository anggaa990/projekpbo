using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktekwinform.Model
{
    public abstract class Pendonorbase
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public string GolonganDarah { get; set; }
        public string Rhesus { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string Alamat { get; set; }
        public string NoHP { get; set; }

        public abstract void Simpan();
    }

    public class Pendonor : Pendonorbase
    {
        public override void Simpan()
        {
            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                var query = @"INSERT INTO pendonor 
                (nama, jenis_kelamin, golongan_darah, rhesus, tanggal_lahir, alamat, no_hp) 
                VALUES (@nama, @jk, @gd, @rhesus, @tgl, @alamat, @hp)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", this.Nama);
                    cmd.Parameters.AddWithValue("jk", this.JenisKelamin);
                    cmd.Parameters.AddWithValue("gd", this.GolonganDarah);
                    cmd.Parameters.AddWithValue("rhesus", this.Rhesus);
                    cmd.Parameters.AddWithValue("tgl", this.TanggalLahir);
                    cmd.Parameters.AddWithValue("alamat", this.Alamat);
                    cmd.Parameters.AddWithValue("hp", this.NoHP);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Pendonor() { }
    }
}

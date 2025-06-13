using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktekwinform.Model
{
    public class Event
    {
        public int Id { get; set; }
        public string Alamat { get; set; }
        public DateTime Tanggal { get; set; }
        public string Waktu { get; set; }
        public string Deskripsi { get; set; }
    }
}

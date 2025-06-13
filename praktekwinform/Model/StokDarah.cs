using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktekwinform.Model
{
    public class StokDarah
    {
        public int Id { get; set; }
        public string GolonganDarah { get; set; }
        public string Rhesus { get; set; }
        public int JumlahKantong { get; set; }
        public DateTime TanggalMasuk { get; set; }
        public DateTime TanggalExp { get; set; }

        public bool IsExpired => DateTime.Now > TanggalExp;
    }
}

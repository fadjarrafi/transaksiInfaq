using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaksiInfaq.Model.Entity
{
    class Pengeluaran
    {
        public string No_Faktur { get; set; }
        public DateTime Tanggal { get; set; }
        public  string Kode_pengurus { get; set; }
        public int Total_keluar { get; set; }
        public string Keperluan { get; set; }
        public string No_rekening { get; set; }

    }
}

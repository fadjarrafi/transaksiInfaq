using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaksiInfaq.Model.Entity
{
    public class Pengeluaran
    {
        public string No_Faktur { get; set; }
        public string Tanggal { get; set; }
        public  string Kode_pengurus { get; set; }
        public string Total_keluar { get; set; }
        public string Keperluan { get; set; }
        public string No_rekening { get; set; }

    }
}

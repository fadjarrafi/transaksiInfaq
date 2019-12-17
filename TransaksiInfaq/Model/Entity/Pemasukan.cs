using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaksiInfaq.Model.Entity
{
    public class Pemasukan
    {
        public string Kode_masuk { get; set; }
        public string Tanggal { get; set; }
        public string Kode_Pengurus { get; set; }
        public string No_rekening { get; set; }
        public string Total_masuk { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaksiInfaq.Model.Entity
{
    class Pemasukan
    {
        public int Kode_masuk { get; set; }
        public DateTime Tanggal { get; set; }
        public string Kode_Pengurus { get; set; }
        public string No_rekening { get; set; }
        public int Total_masuk { get; set; }
    }
}

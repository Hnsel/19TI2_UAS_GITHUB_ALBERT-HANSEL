using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukuKasPribadi.Model
{
    class Utang
    {
        string keterangan_utang, jam_utang, nama_utang;
        int nominal_utang;
        DateTime tanggal_utang;

        public string Keterangan_utang { get => keterangan_utang; set => keterangan_utang = value; }
        public string Jam_utang { get => jam_utang; set => jam_utang = value; }
        public string Nama_utang { get => nama_utang; set => nama_utang = value; }
        public int Nominal_utang { get => nominal_utang; set => nominal_utang = value; }
        public DateTime Tanggal_utang { get => tanggal_utang; set => tanggal_utang = value; }
    }
}

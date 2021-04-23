using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukuKasPribadi.Model
{
    class Piutang
    {
        string keterangan_piutang, jam_piutang, nama_piutang;
        int nominal_piutang;
        DateTime tanggal_piutang;

        public string Keterangan_piutang { get => keterangan_piutang; set => keterangan_piutang = value; }
        public string Jam_piutang { get => jam_piutang; set => jam_piutang = value; }
        public string Nama_piutang { get => nama_piutang; set => nama_piutang = value; }
        public int Nominal_piutang { get => nominal_piutang; set => nominal_piutang = value; }
        public DateTime Tanggal_piutang { get => tanggal_piutang; set => tanggal_piutang = value; }
    }
}

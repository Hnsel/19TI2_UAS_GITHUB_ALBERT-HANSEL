using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukuKasPribadi.Model
{
    class Pengeluaran
    {
        string keterangan_pengeluaran, jam_pengeluaran;
        int nominal_pengeluaran;
        DateTime tanggal_pengeluaran;

        public string Keterangan_pengeluaran { get => keterangan_pengeluaran; set => keterangan_pengeluaran = value; }
        public string Jam_pengeluaran { get => jam_pengeluaran; set => jam_pengeluaran = value; }
        public int Nominal_pengeluaran { get => nominal_pengeluaran; set => nominal_pengeluaran = value; }
        public DateTime Tanggal_pengeluaran { get => tanggal_pengeluaran; set => tanggal_pengeluaran = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukuKasPribadi.Model
{
    class Pemasukkan
    {
        string keterangan_pemasukkan, jam_pemasukkan;
        int nominal_pemasukkan;
        DateTime tanggal_pemasukkan;

        public string Keterangan_pemasukkan { get => keterangan_pemasukkan; set => keterangan_pemasukkan = value; }
        public string Jam_pemasukkan { get => jam_pemasukkan; set => jam_pemasukkan = value; }
        public int Nominal_pemasukkan { get => nominal_pemasukkan; set => nominal_pemasukkan = value; }
        public DateTime Tanggal_pemasukkan { get => tanggal_pemasukkan; set => tanggal_pemasukkan = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penggajian_Karyawan
{
    class Arsip_Gaji
    {
        public Pegawai Pegawai { get; set; }
        public Int64 Gaji { get; set; }

        public Arsip_Gaji(Pegawai pegawai, long gaji)
        {
            Pegawai = pegawai;
            Gaji = gaji;
        }
    }
}

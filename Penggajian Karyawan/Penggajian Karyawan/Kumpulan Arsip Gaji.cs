using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penggajian_Karyawan
{
    class Kumpulan_Arsip_Gaji
    {
        public List<Arsip_Gaji> Daftar_Arsip_Gaji { get; set; }

        public Kumpulan_Arsip_Gaji()
        {

        }

        public Kumpulan_Arsip_Gaji(List<Arsip_Gaji> daftar_Arsip_Gaji)
        {
            Daftar_Arsip_Gaji = daftar_Arsip_Gaji;
        }
    }
}

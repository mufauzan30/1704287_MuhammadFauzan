using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penggajian_Karyawan
{
    class Hitung_Gaji
    {
        public Int64 Hitung_Gaji_Total(Pegawai Pegawai)
        {
            Int64 Gaji_Pokok = (Pegawai.Level + 1) * 1000000;
            Int64 Honor_Lembur = Pegawai.Jumlah_Lembur * 50000;
            Int64 Pinalti_Absen = Pegawai.Jumlah_Absen * 100000;

            if(Pegawai.Level == 3)
            {
                Honor_Lembur *= 2;
            }
            Int64 Total_Gaji = Gaji_Pokok + Honor_Lembur - Pinalti_Absen;

            return Total_Gaji;
        }
    }
}

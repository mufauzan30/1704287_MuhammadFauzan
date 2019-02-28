using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penggajian_Karyawan
{
    public class Pegawai
    {
        public int Id { get => Id; set => Id = value; }
        public int Kode { get => Kode; set => Kode = value; }
        public String Nama { get => Nama; set => Nama = value; }
        public int Level { get => Level; set => Level = value; }
        public int Jumlah_Absen { get => Jumlah_Absen; set => Jumlah_Absen = value; }
        public int Jumlah_Lembur { get => Jumlah_Lembur; set => Jumlah_Lembur = value; }

        public Pegawai(int id, int kode,string nama,int level,int jumlah_Absen, int jumlah_Lembur)
        {
            Id = id;
            Kode = kode;
            Nama = nama;
            Level = level;
            Jumlah_Absen = jumlah_Absen;
            Jumlah_Lembur = jumlah_Lembur;  

        }
    }
}

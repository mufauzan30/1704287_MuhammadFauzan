using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penggajian_Karyawan
{
    public class ListPegawai
    {
        private List<Pegawai> _dpegawai;

       

        public ListPegawai()
        {
            Dpegawai = new List<Pegawai>();
        }

        public List<Pegawai> Dpegawai { get => _dpegawai; set => _dpegawai = value; }
    }
}

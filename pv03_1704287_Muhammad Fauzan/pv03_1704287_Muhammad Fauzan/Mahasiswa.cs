using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pv03_1704287_Muhammad_Fauzan
{
    class Mahasiswa
    {
        public Mahasiswa(int id,string nim,string nama)
        {
            Id = id;
            Nim = nim;
            Nama = nama;
        }

        public int Id { get; set; }

        public string Nim { get; set; }

        public string Nama { get; set; }
    }
}

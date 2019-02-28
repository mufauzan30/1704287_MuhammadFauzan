using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSatu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnUkt_Click(object sender, EventArgs e)
        {
            //panggil form 1
            Form1 frm = new Form1();
            frm.ShowDialog();

        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            //tutup aplikasi
            Application.Exit();
        }

        private void btnKonversiMassa_Click(object sender, EventArgs e)
        {
            //panggil form 4
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void btnKonversiPanjang_Click(object sender, EventArgs e)
        {
            //panggil form 5
            Form5 frm = new Form5();
            frm.ShowDialog();
        }

        private void btnKuadran_Click(object sender, EventArgs e)
        {
            //panggil form 5
            Form6 frm = new Form6();
            frm.ShowDialog();
        }
    }
}

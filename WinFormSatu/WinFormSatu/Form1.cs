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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                //untuk proses perhitungan
                double Ukt;
                int LamaKuliah;
                double TotalUkt;

                //ambil nilai dari textbox
                Ukt = Convert.ToDouble(txtUkt.Text);
                LamaKuliah = Convert.ToInt16(txtlamaKuliah.Text);

                //hitung total
                TotalUkt = Ukt * LamaKuliah;

                //Tampilkan total pada textbox
                txtTotalUkt.Text = Convert.ToString(TotalUkt);
            }
            catch
            {
                MessageBox.Show("Masukkan Angka!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //mengosongkan textbox
            txtUkt.Text = "";
            txtlamaKuliah.Text = "";
            txtTotalUkt.Text = "";

            //memindahkan cursor
            txtUkt.Focus();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            //menutup aplikasi
            MessageBox.Show("Do You Want To Continue?", "Question?", MessageBoxButtons.YesNo);

            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

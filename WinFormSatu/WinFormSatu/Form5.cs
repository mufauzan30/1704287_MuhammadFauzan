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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            try
            {
                //untuk proses perhitungan
                double Meter;


                //ambil nilai dari textbox
                Meter = Convert.ToDouble(txtMeter.Text);


                //hitung total
                Meter = Meter * 100;

                //Tampilkan total pada textbox
                txtCentimeter.Text = Convert.ToString(Meter);
            }
            catch
            {
                MessageBox.Show("Masukkan Angka!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //mengosongkan textbox
            txtMeter.Text = "";
            txtCentimeter.Text = "";

            //memindahkan cursor
            txtMeter.Focus();
        }
    }
}

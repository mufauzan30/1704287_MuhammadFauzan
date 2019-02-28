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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            try
            {
                //untuk proses perhitungan
                double Kilogram;
                

                //ambil nilai dari textbox
                Kilogram = Convert.ToDouble(txtKilogram.Text);
                

                //hitung total
                Kilogram = Kilogram * 1000;

                //Tampilkan total pada textbox
                txtGram.Text = Convert.ToString(Kilogram);
            }
            catch
            {
                MessageBox.Show("Masukkan Angka!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //mengosongkan textbox
            txtKilogram.Text = "";
            txtGram.Text = "";

            //memindahkan cursor
            txtKilogram.Focus();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                //untuk proses perhitungan
                double X;
                string Hasil;
                double Y;

                //ambil nilai dari textbox
                X = Convert.ToDouble(txtX.Text);
                Y = Convert.ToDouble(txtY.Text);
                
                if(X > 0 && Y > 0)
                {
                    Hasil = "Kuadran 1";
                    txtHasil.Text = Convert.ToString(Hasil);
                }
                else if(X < 0 && Y > 0)
                {
                    Hasil = "Kuadran 2";
                    txtHasil.Text = Convert.ToString(Hasil);
                }
                else if(X < 0 && Y < 0)
                {
                    Hasil = "Kuadran 3";
                    txtHasil.Text = Convert.ToString(Hasil);
                }
                else if(X > 0 && Y < 0)
                {
                    Hasil = "Kuadran 4";
                    txtHasil.Text = Convert.ToString(Hasil);
                }

 
                
                
            }
            catch
            {
                MessageBox.Show("Masukkan Angka!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //mengosongkan textbox
            txtX.Text = "";
            txtY.Text = "";
            txtHasil.Text = "";

            //memindahkan cursor
            txtX.Focus();
        }
    }
    
}

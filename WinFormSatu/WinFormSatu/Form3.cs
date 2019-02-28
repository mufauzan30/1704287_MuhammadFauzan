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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panggil form 1
            string xusername;
            string xpassword;

            xusername = Convert.ToString(txtUsername.Text);
            xpassword = Convert.ToString(txtPassword.Text);

            if(xusername != "root" && xpassword != "1234")
            {
                MessageBox.Show("Username Or Password Incorrect", "Wrong Login");
                
            }
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

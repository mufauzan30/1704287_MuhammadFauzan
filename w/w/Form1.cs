using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static void Main()
        {
            int n;
            try
            {
                // Do not initialize this variable here.
                n = 123;
            }
            catch
            {
            }
            // Error: Use of unassigned local variable 'n'.
            Console.Write(n);
        }
    }
}

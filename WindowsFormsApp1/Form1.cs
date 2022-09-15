using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{ 
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        public void definicja()
        {
            var nazwisko = nazwiskotb;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tb4_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {

            var reg = new Regex(@"([A-Z]{0,})");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class form1 : Form
    {
        private object n;

        public form1()
        {
            InitializeComponent();
        }

        private bool check(string x, char dau)
        {
            for (int i=0; i<x.Length; ++i) if (x[i] == dau) return true;
            return false; 
            
        }

        long a;

        public void solve()
        {
            string c = "";
            long b = a;
            for (long i=2; i*i<=a; ++i)
            {
                if (a % i == 0)
                {
                    while (a % i == 0)
                    {
                        c += i;
                        
                        a /= i;
                        if (a > 1) c += " * ";
                    }
                }
            }
            if (a > 1) c += a;
            if (a == b && b!=1) num_anw.Text = b.ToString();
            else num_anw.Text = c;

        }

        private void num_num_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(num_num.Text, out a)) 
                solve();
            
            else
            {
                if (num_num.Text != "")
                MessageBox.Show("Wrong input format!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void num_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
            if (num_num.Text.Length > 11 && e.KeyChar != 8 ) e.Handled = true;
        }

        private void letter_close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KEEP STUDYING MATHS", "FRIENDLY ADVICE", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
        }
    }
}

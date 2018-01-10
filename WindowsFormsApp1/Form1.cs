using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ФАКТОРИАЛ;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ulong n;
            if (ulong.TryParse(textBox1.Text, out n) && (n >= 1))
            {
                Class1 obj = new Class1();
                ulong F = obj.Factorial(n);
                label1.Text = "факториал = " + F;
            }
            else
            {
                label1.Text = "Некорректно введено число";
            }
        }
    }
}

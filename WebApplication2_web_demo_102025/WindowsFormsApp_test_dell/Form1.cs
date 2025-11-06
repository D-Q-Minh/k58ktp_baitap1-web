using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp_test_dell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //be tu console text sang, sua

            double a, b;
            a = (double)(numericUpDown1.Value);
            b = (double)(numericUpDown2.Value);

            //goi dll
            toan_lop_1.cong bt = new toan_lop_1.cong();
            bt.a = a;
            bt.b = b;
            bt.tinh_tong();
            //System.Console.WriteLine($"ket qua: {bt.ketqua}");

            labelKQ.Text = $"ket qua = {bt.ketqua}";
        }
    }
}

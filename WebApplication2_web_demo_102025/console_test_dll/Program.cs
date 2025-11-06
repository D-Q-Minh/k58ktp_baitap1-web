using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace console_test_dll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cong 2 so: ");
            Console.WriteLine("nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine()); //float trong c# convert dung ToSingle

            Console.WriteLine("nhap b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //goi dll
            toan_lop_1.cong bt = new toan_lop_1.cong();
            bt.a = a;
            bt.b = b;
            bt.tinh_tong();
            System.Console.WriteLine($"ket qua: {bt.ketqua}");
        }
    }
}

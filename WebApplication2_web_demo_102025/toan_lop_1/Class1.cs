using System;
using System.Collections.Generic;
using System.Text;

namespace toan_lop_1
{
    public class cong
    {
        public double a, b;
        
        //dau ra
        public double ketqua
        {
            get;
            private set;    //trong class moi set dc
        }
        public void tinh_tong()
        {
            ketqua = a + b;
        }
    }
}

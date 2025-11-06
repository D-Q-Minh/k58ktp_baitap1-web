using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2_web_demo_102025
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //nhan du lieu gui len tu client
            //sd 1 dll de giai quyet bai toan
            trave tong2so = new trave();
            if (!IsPostBack)
            {
                double a, b;
                a = double.Parse(this.Request.Form["a"]);
                b = double.Parse(this.Request.Form["b"]);

                //goi dll
                toan_lop_1.cong bt = new toan_lop_1.cong();
                bt.a = a;
                bt.b = b;

                //thu ket qua (chuoi, so,...)
                
                bt.tinh_tong();
                //System.Console.WriteLine($"ket qua: {bt.ketqua}");

                tong2so.kq = bt.ketqua;
            }
            

            //chuyen ket qua thanh json, 
            string json = JsonConvert.SerializeObject(tong2so);
            //gui client
            this.Response.Write(json);
            Response.End();
        }
        class trave
        {
            public double kq;
        }
    }
}
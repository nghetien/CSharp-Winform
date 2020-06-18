using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XemBanDo
{
    public partial class fNapTien : Form
    {
        public fNapTien()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public class ThongTinThe
        {
            public int ID { get; set; }
            public string MaTheNap { get; set; }
            public string SoSeri { get; set; }
            public decimal GiaThe { get; set; }
            public int DaSuDung { get; set; }
        }
        decimal giathe = 0;
        private void button_napthe_Click(object sender, EventArgs e)
        {
            dbTRAVELDataContext napthe = new dbTRAVELDataContext();
            string soseri = textBox_soseri.Text.ToString();
            string mathe = textBox_mathenap.Text.ToString();
            if(soseri.Length ==0 || mathe.Length == 0)
            {
                MessageBox.Show("Error,Bạn đã nhập thiếu số Seri hoặc Mã Thẻ", "Thông báo");
            }
            else
            {
                var data = (from a in napthe.TheNaps
                            where a.SoSeri == soseri & a.MaTheNap==mathe
                            select new ThongTinThe
                            {
                                ID = a.ID,
                                MaTheNap = a.MaTheNap,
                                GiaThe = a.GiaThe,
                                DaSuDung = a.DaSuDung,
                                SoSeri = a.SoSeri,
                            }).FirstOrDefault();
                if (data == null || data.DaSuDung ==1)
                {
                    MessageBox.Show("Số Seri, Mã thẻ nạp không đúng hoặc đã qua sử dụng", "Nạp thất bại");
                }
                else
                {
                    dbTRAVELDataContext the = new dbTRAVELDataContext();
                    var thenap = the.TheNaps.Where(p => p.SoSeri == soseri & p.MaTheNap == mathe).SingleOrDefault(); 
                    thenap.DaSuDung = 1;
                    the.SubmitChanges();
                    giathe = data.GiaThe;
                    dbTRAVELDataContext tk = new dbTRAVELDataContext();
                    var datatk = tk.Accounts.Where(a => a.TenTaiKhoan == fDangNhap.LuuThongTin.myusername).SingleOrDefault();
                    datatk.Tien += giathe;
                    //GuiTien(datatk.Tien +giathe);
                    tk.SubmitChanges();
                    MessageBox.Show("Bạn vừa nạp thành công " + giathe.ToString(), "Nạp thành công");

                }
            }
        }



        private void button_thoatnapthe_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

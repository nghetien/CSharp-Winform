using MapWinGIS;
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
using System.Xml;
//using XemBanDo.DAO;
//using XemBanDo.DTO;

namespace XemBanDo
{
    public partial class fLichSu : Form
    {
        public fLichSu()
        {
            InitializeComponent();
        }

        private void fLichSu_Load(object sender, EventArgs e)
        {
            dbTRAVELDataContext ls = new dbTRAVELDataContext();
            var data = from p in ls.HoaDons
                       join q in ls.Accounts on p.TenTaiKhoan equals q.TenTaiKhoan
                       join k in ls.Tuas on p.MaTua equals k.MaTua
                       where q.TenTaiKhoan==fDangNhap.LuuThongTin.myusername
                       select new { p.ID, q.TenTaiKhoan,k.TenTua,p.NgayDat,k.NgayDen,k.NgayDi,k.MaTua,k.Gia,k.DatNuoc,k.KhachSan };
            dataGridView_lichsumuave.DataSource = data;
        }

        private void button_thoatls_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using XemBanDo.DAO;
namespace XemBanDo
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }
        public class LuuThongTin
        {
            static public string myusername;
        }
        private void button_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình","Thông Báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel=true;
            }
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            using(dbTRAVELDataContext dangnhap=new dbTRAVELDataContext())
            {
                var login = (from a in dangnhap.Accounts
                             where a.TenTaiKhoan == textBox_taikhoan.Text.ToString() && a.MatKhau == textBox_matkhau.Text.ToString()
                             select a).FirstOrDefault();
                if (login == null)
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.","Lỗi");
                }
                else
                {
                    LuuThongTin.myusername = textBox_taikhoan.Text.ToString();
                    fDatChuyen dattua = new fDatChuyen();
                    this.Hide();
                    dattua.ShowDialog();
                    this.Show();
                }
            }
        }

        private void button_dangky_Click(object sender, EventArgs e)
        {
            fDangKy dangky = new fDangKy();
            this.Hide();
            dangky.ShowDialog();
            this.Show();
        }
    }
}

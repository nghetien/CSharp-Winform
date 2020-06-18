using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XemBanDo
{
    public partial class fDangKy : Form
    {
        public fDangKy()
        {
            InitializeComponent();
        }

        private void button_dangky_Click(object sender, EventArgs e)
        {
            string tk = textBox_taikhoan.Text.ToString();
            string mk1 = textBox_matkhau1.Text.ToString();
            string mk2 = textBox_matkhau2.Text.ToString();
            using (dbTRAVELDataContext kiemtra = new dbTRAVELDataContext())
            {
                var check = (from a in kiemtra.Accounts
                             where a.TenTaiKhoan == tk
                             select a).FirstOrDefault();
                if (check != null)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Lỗi");
                }
                else
                {
                    if (mk1 != mk2)
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại 2 mật khẩu", "Lỗi");
                    }
                    else
                    {
                        using (dbTRAVELDataContext dangky = new dbTRAVELDataContext())
                        {
                            Account dk = new Account();
                            dk.TenTaiKhoan = tk;
                            dk.MatKhau = mk1;
                            dk.IsAdmin = 0;
                            dk.Tien = 0;
                            dangky.Accounts.InsertOnSubmit(dk);
                            dangky.SubmitChanges();
                            MessageBox.Show("Đăng ký thành công", "Thông báo");
                        }
                    }
                }
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

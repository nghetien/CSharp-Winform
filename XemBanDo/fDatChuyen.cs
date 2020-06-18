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

namespace XemBanDo
{
    public partial class fDatChuyen : Form
    {
        decimal TIENDANGCO = 0;
        decimal GIATUA = 0;
        string MATUA = "";
        int ISADMIN = 0;
        public fDatChuyen()
        {
            InitializeComponent();
            LoadTable();
        }
        void ShowGia(string username)
        {
            using (dbTRAVELDataContext account = new dbTRAVELDataContext())
            {
                var data = (from a in account.Accounts
                            where a.TenTaiKhoan == username
                            select a).FirstOrDefault();
                TIENDANGCO = data.Tien;
                ISADMIN = data.IsAdmin;
                textBox_tiendangco.Text = TIENDANGCO.ToString();
            }
        }
        void LoadTable()
        {
            flowLayoutPanel_cactua.Controls.Clear();
            string taikhoan = fDangNhap.LuuThongTin.myusername;
            ShowGia(taikhoan);
            using (dbTRAVELDataContext full_tua = new dbTRAVELDataContext())
            {
                var tua = from a in full_tua.Tuas
                          select a;
                foreach(Tua item in tua)
                {
                    Button btn = new Button()
                    {
                        Width = 100,
                        Height = 100
                    };
                    string temp = "Chưa Đặt";
                    if (item.DaDat == 1)
                    {
                        temp = "Đã Đặt";
                    }
                    btn.Text = item.TenTua + Environment.NewLine + temp;

                    btn.Tag = item;
                    btn.Click += button_Click;
                    
                    switch (item.DaDat)
                    {
                        case 1:
                            btn.BackColor = Color.Red;
                            break;
                        default:
                            btn.BackColor = Color.Aquamarine;
                            break;
                    }
                    flowLayoutPanel_cactua.Controls.Add(btn);
                }
            }
        }
        void ShowTua(int TuaID)
        {
            listView_thongtintua.Items.Clear();
            using (dbTRAVELDataContext showtua = new dbTRAVELDataContext())
            {
                var show = (from a in showtua.Tuas
                            where a.ID == TuaID
                            select a).FirstOrDefault();
                ListViewItem lvItem = new ListViewItem(show.ID.ToString());
                lvItem.SubItems.Add(show.TenTua.ToString());
                lvItem.SubItems.Add(show.DatNuoc.ToString());
                lvItem.SubItems.Add(show.DanhMuc.ToString());
                lvItem.SubItems.Add(show.Gia.ToString());
                lvItem.SubItems.Add(show.KhachSan.ToString());
                lvItem.SubItems.Add(show.NgayDen.ToString());
                lvItem.SubItems.Add(show.NgayDi.ToString());
                lvItem.SubItems.Add(show.DaDat.ToString());
                listView_thongtintua.Items.Add(lvItem);
                textBox_tiengiatua.Text = show.Gia.ToString();
                MATUA = show.MaTua;
                GIATUA = show.Gia;
            }
        }


        void button_Click(object sender, EventArgs e)
        {
            int TuaID=((sender as Button).Tag as Tua).ID;
            ShowTua(TuaID);
        }
        private void button_xembando_Click(object sender, EventArgs e)
        {
            fBanDo bando = new fBanDo();
            this.Hide();
            bando.ShowDialog();// top điều khiển
            this.Show();
        }
        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void quanly_stripmenu_Click(object sender, EventArgs e)
        {
            if(ISADMIN==0)
            {
                MessageBox.Show("Bạn không phải là Admin nên không thể dùng chức năng này", "Thông báo");
            }
            else
            {
                fAdmin bando = new fAdmin();
                this.Hide();
                bando.ShowDialog();// top điều khiển
                this.Show();
                LoadTable();
            }
        }


        public class DaDatTua
        {
            public int DaDat { get; set; }
        }

        private void button_dattua_Click(object sender, EventArgs e)
        {
            if(MATUA.Length >0)
            {
                if (GIATUA > TIENDANGCO)
                {
                    MessageBox.Show("Tiền đang có của bạn không đủ để thanh toán", "Thông báo");
                }
                else
                {
                    using (dbTRAVELDataContext tuavuadat = new dbTRAVELDataContext())
                    {
                        var data = tuavuadat.Tuas.Where(a => a.MaTua == MATUA).SingleOrDefault();
                        if (data.DaDat != 1)
                        {
                            data.DaDat = 1;
                            tuavuadat.SubmitChanges();
                            MessageBox.Show("Thanh toán thành công bạn hãy lưu mã này lại dùng để CheckIn tại quầy" + Environment.NewLine + "Mã số tua của bạn là:" + MATUA, "Thông báo");
                            using (dbTRAVELDataContext tk = new dbTRAVELDataContext())
                            {
                                var datatk = tk.Accounts.Where(a => a.TenTaiKhoan == fDangNhap.LuuThongTin.myusername).SingleOrDefault();
                                datatk.Tien -= GIATUA;
                                TIENDANGCO -= GIATUA;
                                tk.SubmitChanges();
                                textBox_tiendangco.Text = datatk.Tien.ToString();
                            }
                            LoadTable();
                            using (dbTRAVELDataContext luulichsu = new dbTRAVELDataContext())
                            {
                                DateTime date_default = DateTime.Now;
                                HoaDon history = new HoaDon();
                                history.MaTua = MATUA;
                                history.GiaTua = GIATUA;
                                history.TenTaiKhoan = fDangNhap.LuuThongTin.myusername;
                                history.NgayDat = date_default;
                                luulichsu.HoaDons.InsertOnSubmit(history);
                                luulichsu.SubmitChanges();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tua này đã được đặt vui lòng chọn tua khác", "Thông báo");
                        }
                    }
                }  
            }
            else
            {
                MessageBox.Show("Bạn vui lòng chọn tua để đặt", "Thông báo");
            }
            
        }

        private void naptien_stripmenu_Click(object sender, EventArgs e)
        {
            fNapTien naptien = new fNapTien();
            this.Hide();
            naptien.ShowDialog();
            this.Show();
            LoadTable();
        }
        private void button_lichsudat_Click(object sender, EventArgs e)
        {
            fLichSu ls = new fLichSu();
            this.Hide();
            ls.ShowDialog();
            this.Show();
        }

        private void thongtintaikhoan_stripmenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang đăng nhập bởi tài khoản: "+ fDangNhap.LuuThongTin.myusername + Environment.NewLine + "Với số tiền đang có là: "+TIENDANGCO, "Thông báo");
        }
    }
} 
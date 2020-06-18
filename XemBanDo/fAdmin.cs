using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapWinGIS;
using AxMapWinGIS;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Xml;
//using XemBanDo.DAO;

namespace XemBanDo
{
    public partial class fAdmin : Form
    {
        int IDTUA;
        int IDDANHMUC;
        public fAdmin()
        {
            InitializeComponent();
            LoadTua();
            LoadDanhMuc();
            LoadTaiKhoan();
            LoadTheNap();
            LoadDoanhThu();
        }

        void LoadTua()
        {
            using (dbTRAVELDataContext tuafull = new dbTRAVELDataContext())
            {
                var data_tua = from a in tuafull.Tuas
                              select new { a.ID,a.TenTua,a.DatNuoc,a.IDDanhMuc,a.Gia,a.KhachSan,a.NgayDen,a.NgayDi,a.DaDat,a.MaTua};
                dataGridView_tua.DataSource = data_tua;
                var data_iddanhmuc = from a in tuafull.DanhMucs
                              select new { a.ID};
                comboBox_iddanhmuc.DisplayMember = "ID";
                comboBox_iddanhmuc.DataSource = data_iddanhmuc;
                var data_iddatnuoc = from a in tuafull.Countries
                                     select new { a.Id };
                comboBox_iddatnuoc.DisplayMember = "Id";
                comboBox_iddatnuoc.DataSource = data_iddatnuoc;
            }
        }

        private void button_thoattua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_chontua_Click(object sender, EventArgs e)
        {
            string idTua = dataGridView_tua.Rows[dataGridView_tua.CurrentRow.Index].Cells[0].Value.ToString();
            IDTUA = int.Parse(idTua);
            string idDanhMuc = dataGridView_tua.Rows[dataGridView_tua.CurrentRow.Index].Cells[3].Value.ToString();
            IDDANHMUC = int.Parse(idDanhMuc);
            dbTRAVELDataContext tua = new dbTRAVELDataContext();
            var query = (from b in tua.Tuas
                         where b.ID == IDTUA
                         select b).FirstOrDefault();
            textBox_matua.Text = query.MaTua.ToString();
            textBox_tentua.Text = query.TenTua.ToString();
            comboBox_iddanhmuc.Text = query.IDDanhMuc.ToString();
            textBox_khachsan.Text = query.KhachSan.ToString();
            dateTimePicker_ngayden.Value  = query.NgayDen.Date;
            dateTimePicker_ngaydi.Value = query.NgayDi.Date;
            comboBox_iddatnuoc.Text = query.DatNuoc.ToString();
            textBox_giatientua.Text = query.Gia.ToString();
            textBox_dadattua.Text = query.DaDat.ToString();
            textBox_idtua_tim.Text = IDTUA.ToString();
        }

        private void button_taomoitua_Click(object sender, EventArgs e)
        {
            DateTime date_default = DateTime.Now;
            textBox_matua.Text = "";
            textBox_tentua.Text = "";
            textBox_khachsan.Text = "";
            comboBox_iddanhmuc.Text = null;
            textBox_giatientua.Text = null;
            textBox_dadattua.Text = 0.ToString();
            textBox_idtua_tim.Text = "";
            dateTimePicker_ngayden.Value = date_default;
            dateTimePicker_ngaydi.Value = date_default;
            comboBox_iddatnuoc.Text = null;
            LoadTua();
        }

        private void button_themtua_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbTRAVELDataContext themtua = new dbTRAVELDataContext())
                {
                    Tua them = new Tua();
                    them.MaTua = textBox_matua.Text.ToString();
                    them.TenTua = textBox_tentua.Text.ToString();
                    them.IDDanhMuc = int.Parse(comboBox_iddanhmuc.Text.ToString());
                    them.KhachSan = textBox_khachsan.Text.ToString();
                    them.NgayDen = dateTimePicker_ngayden.Value;
                    them.NgayDi = dateTimePicker_ngaydi.Value;
                    them.DatNuoc = int.Parse(comboBox_iddatnuoc.Text.ToString());
                    them.Gia = decimal.Parse(textBox_giatientua.Text.ToString());
                    them.DaDat = 0;
                    themtua.Tuas.InsertOnSubmit(them);
                    themtua.SubmitChanges();
                    MessageBox.Show("Thêm tua thành công", "Thông báo");
                    LoadTua();
                }
            }
            catch(Exception loi)
            {
                MessageBox.Show("Thêm không hợp lệ vui lòng xem lại dữ liệu đầu vào", "Lỗi");
            }
        }

        private void button_timtua_Click(object sender, EventArgs e)
        {
            int IDTUA_temp = int.Parse(textBox_idtua_tim.Text.ToString());
            using (dbTRAVELDataContext tim_tua = new dbTRAVELDataContext())
            {
                var query_tim = (from b in tim_tua.Tuas
                                    where b.ID == IDTUA_temp
                                 select b).FirstOrDefault();
                if(query_tim==null)
                {
                    MessageBox.Show("Tua bạn tìm không tồn tại", "Lỗi");
                }
                else
                {
                    textBox_matua.Text = query_tim.MaTua.ToString();
                    textBox_tentua.Text = query_tim.TenTua.ToString();
                    comboBox_iddanhmuc.Text = query_tim.IDDanhMuc.ToString();
                    textBox_khachsan.Text = query_tim.KhachSan.ToString();
                    dateTimePicker_ngayden.Value = query_tim.NgayDen.Date;
                    dateTimePicker_ngaydi.Value = query_tim.NgayDi.Date;
                    comboBox_iddatnuoc.Text = query_tim.DatNuoc.ToString();
                    textBox_giatientua.Text = query_tim.Gia.ToString();
                    textBox_dadattua.Text = query_tim.DaDat.ToString();
                    textBox_idtua_tim.Text = IDTUA.ToString();
                    IDTUA = query_tim.ID;
                    IDDANHMUC = query_tim.IDDanhMuc;
                }
            }
        }

        private void button_suatua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn sửa tua có id: " + textBox_idtua_tim.Text.ToString() + " không", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    using (dbTRAVELDataContext suatua = new dbTRAVELDataContext())
                    {
                        var tua_sua = (from a in suatua.Tuas
                                       where a.ID == int.Parse(textBox_idtua_tim.Text.ToString())
                                       select a).FirstOrDefault();
                        if (tua_sua == null)
                        {
                            MessageBox.Show("Sửa thất bại", "Lỗi");
                        }
                        else
                        {
                            tua_sua.MaTua = textBox_matua.Text.ToString();
                            tua_sua.TenTua = textBox_tentua.Text.ToString();
                            tua_sua.IDDanhMuc = int.Parse(comboBox_iddanhmuc.Text.ToString());
                            tua_sua.KhachSan = textBox_khachsan.Text.ToString();
                            tua_sua.NgayDen = dateTimePicker_ngayden.Value.Date;
                            tua_sua.NgayDi = dateTimePicker_ngaydi.Value.Date;
                            tua_sua.DatNuoc = int.Parse(comboBox_iddatnuoc.Text.ToString());
                            tua_sua.Gia = decimal.Parse(textBox_giatientua.Text.ToString());
                            tua_sua.DaDat = int.Parse(textBox_dadattua.Text.ToString());
                            textBox_idtua_tim.Text = IDTUA.ToString();
                            suatua.SubmitChanges();
                            MessageBox.Show("Bạn đã sửa tua: " + IDTUA.ToString() + " thành công", "Thông báo");
                            LoadTua();
                        }
                    }
                }
                catch (Exception loi)
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi");
                }
            } 
        }

        private void button_xoatua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa tua có id: "+ textBox_idtua_tim.Text.ToString() +" không", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    using (dbTRAVELDataContext xoatua = new dbTRAVELDataContext())
                    {
                        var xoa = xoatua.Tuas.Where(a => a.MaTua == textBox_matua.Text.ToString() && a.IDDanhMuc==int.Parse(comboBox_iddanhmuc.Text.ToString())).SingleOrDefault();
                        xoatua.Tuas.DeleteOnSubmit(xoa);
                        xoatua.SubmitChanges();
                        MessageBox.Show("Bạn đã xóa tua: " + IDTUA.ToString() + " thành công", "Thông báo");
                        LoadTua();
                    }
                }
                catch
                {
                    MessageBox.Show("Tua này đã bị xóa hoặc không tồn tại", "Lỗi");
                }
            }
        }



        int IDDANHMUC_O_DanhMuc;
        void LoadDanhMuc()
        {
            using (dbTRAVELDataContext danhmuc_full = new dbTRAVELDataContext())
            {
                var data_danhmuc= from a in danhmuc_full.DanhMucs
                               select new { a.ID,a.TenDanhMuc };
                dataGridView_danhmuc.DataSource = data_danhmuc;
            }
        }

        private void button_themdanhmuc_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbTRAVELDataContext them_danhmuc = new dbTRAVELDataContext())
                {
                    if(textBox_tendanhmuc.Text=="")
                    {
                        MessageBox.Show("Thêm không hợp lệ vui lòng xem lại dữ liệu đầu vào", "Lỗi");
                    }
                    else
                    {
                        DanhMuc them = new DanhMuc();
                        them.TenDanhMuc = textBox_tendanhmuc.Text.ToString();
                        them_danhmuc.DanhMucs.InsertOnSubmit(them);
                        them_danhmuc.SubmitChanges();
                        MessageBox.Show("Thêm danh mục thành công", "Thông báo");
                        LoadDanhMuc();
                    }
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show("Thêm không hợp lệ vui lòng xem lại dữ liệu đầu vào", "Lỗi");
            }
        }

        private void button_suadanhmuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn sửa danh mục có id: " + textBox_iddanhmuc.Text.ToString() + " không", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    using (dbTRAVELDataContext suadanhmuc = new dbTRAVELDataContext())
                    {
                        var sua = (from a in suadanhmuc.DanhMucs
                                   where a.ID == IDDANHMUC_O_DanhMuc
                                   select a).FirstOrDefault();
                        if (textBox_tendanhmuc.Text == "")
                        {
                            MessageBox.Show("Vui lòng nhập tên danh mục thay thế", "Lỗi");
                        }
                        else
                        {
                            sua.TenDanhMuc = textBox_tendanhmuc.Text.ToString();
                            suadanhmuc.SubmitChanges();
                            MessageBox.Show("Bạn đã sửa thành công");
                            LoadDanhMuc();
                        }

                    }
                }
                catch (Exception loi)
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi");
                }
            }    
        }

        private void button_xoadanhmuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa danh mục có id: " + textBox_iddanhmuc.Text.ToString() + " không", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    IDDANHMUC_O_DanhMuc = int.Parse(textBox_iddanhmuc.Text.ToString());
                    using (dbTRAVELDataContext xoadanhmuc = new dbTRAVELDataContext())
                    {
                        var xoa_dm = xoadanhmuc.DanhMucs.Where(a => a.ID == IDDANHMUC_O_DanhMuc).SingleOrDefault();
                        xoadanhmuc.DanhMucs.DeleteOnSubmit(xoa_dm);
                        xoadanhmuc.SubmitChanges();
                        MessageBox.Show("Bạn đã xóa danh mục: " + IDDANHMUC_O_DanhMuc.ToString() + " thành công", "Thông báo");
                        LoadDanhMuc();
                    }
                }
                catch
                {
                    MessageBox.Show("Danh mục này đã bị xóa hoặc không tồn tại", "Lỗi");
                }
            }
        }
        private void button_taomoidanhmuc_Click(object sender, EventArgs e)
        {
            textBox_iddanhmuc.Text = "";
            textBox_tendanhmuc.Text = "";
        }
        private void button_chitietdanhmuc_Click(object sender, EventArgs e)
        {
            string iddanhmuc = dataGridView_danhmuc.Rows[dataGridView_danhmuc.CurrentRow.Index].Cells[0].Value.ToString();
            IDDANHMUC_O_DanhMuc = int.Parse(iddanhmuc);
            dbTRAVELDataContext danhmuc = new dbTRAVELDataContext();
            var query = (from b in danhmuc.DanhMucs
                         where b.ID == IDDANHMUC_O_DanhMuc
                         select b).FirstOrDefault();
            textBox_iddanhmuc.Text = query.ID.ToString();
            textBox_tendanhmuc.Text = query.TenDanhMuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int IDTAIKHOAN;
        void LoadTaiKhoan()
        {
            using (dbTRAVELDataContext taikhoan_full = new dbTRAVELDataContext())
            {
                var data_taikhoan = from a in taikhoan_full.Accounts
                                    select new { a.ID, a.TenTaiKhoan, a.MatKhau,a.IsAdmin,a.Tien };

                dataGridView_taikhoan.DataSource = data_taikhoan;
            }
        }
        private void button_taomoitaikhoan_Click(object sender, EventArgs e)
        {
            textBox_idtaikhoan.Text = "";
            textBox_tentaikhoan.Text = "";
            textBox_matkhau.Text = "";
            textBox_isadmin.Text = "";
            textBox_tiendangco.Text = "";
            textBox_timkiemtaikhoan.Text = "";
            LoadTaiKhoan();
        }
        private void button_chitiettaikhoan_Click(object sender, EventArgs e)
        {
            string idTaiKhoan = dataGridView_taikhoan.Rows[dataGridView_taikhoan.CurrentRow.Index].Cells[0].Value.ToString();
            IDTAIKHOAN = int.Parse(idTaiKhoan);
            using (dbTRAVELDataContext taikhoan = new dbTRAVELDataContext())
            {
                var tk = (from a in taikhoan.Accounts
                         where a.ID == IDTAIKHOAN
                         select a).FirstOrDefault();
                textBox_idtaikhoan.Text = tk.ID.ToString();
                textBox_tentaikhoan.Text = tk.TenTaiKhoan.ToString();
                textBox_matkhau.Text = tk.MatKhau.ToString();
                textBox_isadmin.Text = tk.IsAdmin.ToString();
                textBox_tiendangco.Text = tk.Tien.ToString();
                textBox_timkiemtaikhoan.Text = tk.ID.ToString();
            }
        }

        private void button_taikhoan_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbTRAVELDataContext them_taikhoan = new dbTRAVELDataContext())
                {
                    Account them_tk = new Account();
                    them_tk.TenTaiKhoan = textBox_tentaikhoan.Text.ToString();
                    them_tk.MatKhau = textBox_matkhau.Text.ToString();
                    them_tk.IsAdmin = int.Parse(textBox_isadmin.Text.ToString());
                    them_tk.Tien = decimal.Parse(textBox_tiendangco.Text.ToString());
                    them_taikhoan.Accounts.InsertOnSubmit(them_tk);
                    them_taikhoan.SubmitChanges();
                    MessageBox.Show("Thêm danh mục thành công", "Thông báo");
                    LoadTaiKhoan();
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show("Tài khoản đã tồn tại hoặc dữ liệu đầu vào bị lỗi", "Lỗi");
            }
        }

        private void button_timtaikhoan_Click(object sender, EventArgs e)
        {
            int idTaiKhoan = int.Parse(textBox_timkiemtaikhoan.Text.ToString());
            using (dbTRAVELDataContext tim_taikhoan = new dbTRAVELDataContext())
            {
                var query_tim = (from b in tim_taikhoan.Accounts
                                 where b.ID == idTaiKhoan
                                 select b).FirstOrDefault();
                if (query_tim == null)
                {
                    MessageBox.Show("Tài khoản bạn tìm không tồn tại", "Lỗi");
                }
                else
                {
                    textBox_idtaikhoan.Text = query_tim.ID.ToString();
                    textBox_tentaikhoan.Text = query_tim.TenTaiKhoan.ToString();
                    textBox_matkhau.Text = query_tim.MatKhau.ToString();
                    textBox_isadmin.Text = query_tim.IsAdmin.ToString();
                    textBox_tiendangco.Text = query_tim.Tien.ToString();
                    textBox_timkiemtaikhoan.Text = query_tim.ID.ToString();
                    IDTAIKHOAN = query_tim.ID;
                }
            }
        }

        private void button_suataikhoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn sửa tài khoản có id: " + textBox_idtaikhoan.Text.ToString() + " không", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    using (dbTRAVELDataContext sua_taikhoan = new dbTRAVELDataContext())
                    {
                        var sua_tk = (from a in sua_taikhoan.Accounts
                                      where a.ID == int.Parse(textBox_idtaikhoan.Text.ToString())
                                      select a).FirstOrDefault();
                        if (sua_tk == null)
                        {
                            MessageBox.Show("Sửa thất bại", "Lỗi");
                        }
                        else
                        {
                            sua_tk.TenTaiKhoan = textBox_tentaikhoan.Text.ToString();
                            sua_tk.MatKhau = textBox_matkhau.Text.ToString();
                            sua_tk.IsAdmin = int.Parse(textBox_isadmin.Text.ToString());
                            sua_tk.Tien = decimal.Parse(textBox_tiendangco.Text.ToString());
                            sua_taikhoan.SubmitChanges();
                            MessageBox.Show("Bạn đã sửa tài khoản: " + textBox_idtaikhoan.Text.ToString() + " thành công", "Thông báo");
                            LoadTaiKhoan();
                        }
                    }
                }
                catch (Exception loi)
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi");
                }
            }    
        }

        private void button_xoataikhoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa tài khoản có id: " + textBox_idtaikhoan.Text.ToString() + " không", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    using (dbTRAVELDataContext xoa_taikhoan = new dbTRAVELDataContext())
                    {
                        var xoa_tk = xoa_taikhoan.Accounts.Where(a => a.ID == int.Parse(textBox_idtaikhoan.Text.ToString())).SingleOrDefault();
                        xoa_taikhoan.Accounts.DeleteOnSubmit(xoa_tk);
                        xoa_taikhoan.SubmitChanges();
                        MessageBox.Show("Bạn đã xóa tài khoản: " + textBox_idtaikhoan.Text.ToString() + " thành công", "Thông báo");
                        LoadTaiKhoan();
                    }
                }
                catch
                {
                    MessageBox.Show("Tài khoản này đã bị xóa hoặc không tồn tại", "Lỗi");
                }
            }    
                
        }

        private void button_thoattaikhoan_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void LoadTheNap()
        {
            using (dbTRAVELDataContext thenap_full = new dbTRAVELDataContext())
            {
                var data_thenap = from a in thenap_full.TheNaps
                                    select new { a.ID,a.MaTheNap,a.SoSeri,a.GiaThe,a.DaSuDung};

                dataGridView_thenap.DataSource = data_thenap;
            }
        }

        private void button_themthenap_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbTRAVELDataContext them_thenap = new dbTRAVELDataContext())
                {
                    TheNap them_tn = new TheNap();
                    them_tn.MaTheNap = textBox_mathenap.Text.ToString();
                    them_tn.GiaThe = decimal.Parse(textBox_giathenap.Text.ToString());
                    them_tn.SoSeri = textBox_soseri.Text.ToString();
                    them_tn.DaSuDung = 0;
                    them_thenap.TheNaps.InsertOnSubmit(them_tn);
                    them_thenap.SubmitChanges();
                    MessageBox.Show("Thêm thẻ nạp mới thành công", "Thông báo");
                    LoadTheNap();
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show("Thẻ đã tồn tại hoặc dữ liệu bị thiếu", "Lỗi");
            }
        }
        private void button_chitietthenap_Click(object sender, EventArgs e)
        {
            string MATHENAP = dataGridView_thenap.Rows[dataGridView_thenap.CurrentRow.Index].Cells[1].Value.ToString();
            string SOSERI = dataGridView_thenap.Rows[dataGridView_thenap.CurrentRow.Index].Cells[2].Value.ToString();
            using (dbTRAVELDataContext chon_thenap = new dbTRAVELDataContext())
            {
                var tn = (from a in chon_thenap.TheNaps
                          where a.MaTheNap == MATHENAP && a.SoSeri == SOSERI
                          select a).FirstOrDefault();
                textBox_idthenap.Text = tn.ID.ToString();
                textBox_mathenap.Text = tn.MaTheNap.ToString();
                textBox_giathenap.Text = tn.GiaThe.ToString();
                textBox_soseri.Text = tn.SoSeri.ToString();
                textBox_dasudung.Text = tn.DaSuDung.ToString();
            }
        }

        private void button_taomoi_thenap_Click(object sender, EventArgs e)
        {
            textBox_idthenap.Text = null;
            textBox_mathenap.Text = null;
            textBox_giathenap.Text = null;
            textBox_soseri.Text = null;
            textBox_dasudung.Text = null;
        }

        private void button_thoat_thenap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        



        void LoadDoanhThu()
        {
            using(dbTRAVELDataContext load_doanhthu = new dbTRAVELDataContext())
            {
                decimal tongdoanhthu=0;
                load_doanhthu.DeferredLoadingEnabled = false;
                var load = (from a in load_doanhthu.HoaDons
                           select a);
                dataGridView_doanhthu.DataSource = load;
                foreach(HoaDon item in load)
                {
                    tongdoanhthu += item.GiaTua;
                }
                textBox_tongtien.Text = tongdoanhthu.ToString();
            }
        }

        private void button_xemdoanhso_Click(object sender, EventArgs e)
        {
            DateTime ngaydat1 = dateTimePicker_ngaydat1.Value;
            DateTime ngaydat2 = dateTimePicker_ngaydat2.Value;
            using (dbTRAVELDataContext doanhthu = new dbTRAVELDataContext())
            {
                doanhthu.DeferredLoadingEnabled = false;
                decimal tongdoanhthu = 0;
                var load_tua = from a in doanhthu.HoaDons
                           where (a.NgayDat>= ngaydat1 && a.NgayDat<= ngaydat2)
                           select a;
                dataGridView_doanhthu.DataSource = load_tua;
                foreach (HoaDon item in load_tua)
                {
                    tongdoanhthu += item.GiaTua;
                }
                textBox_tongtien.Text = tongdoanhthu.ToString();
            }
        }

        private void button_thoat_doanhthu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

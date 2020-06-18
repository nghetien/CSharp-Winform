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
using System.Data.Linq;

namespace XemBanDo
{
    public partial class fTimKiem : Form
    {
        public fTimKiem()
        {
            InitializeComponent();
        }

        private void fTimKiem_Load(object sender, EventArgs e)
        {
            using(dbTRAVELDataContext datnuoc = new dbTRAVELDataContext())
            {
                var data = from a in datnuoc.Countries select a;
                dataGridView_tkdatnuoc.DataSource = data;
            }
        }

        private void button_tiemdatnuoc_Click(object sender, EventArgs e)
        {
            string tendatnuoc = textBox_tendatnuoc.Text;
            using (dbTRAVELDataContext datnuoc = new dbTRAVELDataContext())
            {
                var data = from a in datnuoc.Countries where a.CommonName == tendatnuoc select a;
                dataGridView_tkdatnuoc.DataSource = data;
                if(data == null)
                {
                    MessageBox.Show("Không có tên đất nước mà bạn cần tìm", "Thông báo");
                }
            }
        }

        private void button_tatcadatnuoc_Click(object sender, EventArgs e)
        {
            using (dbTRAVELDataContext datnuoc = new dbTRAVELDataContext())
            {
                var data = from a in datnuoc.Countries select a;
                dataGridView_tkdatnuoc.DataSource = data;
            }
        }

        private void button_thoattimkiem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

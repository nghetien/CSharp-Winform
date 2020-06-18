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

namespace XemBanDo
{
    public partial class fBanDo : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lparam);
        public fBanDo()
        {
            InitializeComponent();
        }
        
        private void button_dichuyen_Click(object sender, EventArgs e)
        {
            axMap.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void button_zoom_Click(object sender, EventArgs e)
        {
            axMap.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn;
        }

        private void button_khoangcach_Click(object sender, EventArgs e)
        {
            axMap.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
        }

        private void button_dientich_Click(object sender, EventArgs e)
        {
            axMap.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
            axMap.Measuring.MeasuringType = MapWinGIS.tkMeasuringType.MeasureArea;
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            fTimKiem seach = new fTimKiem();
            this.Hide();
            seach.ShowDialog();
            this.Show();
        }

        private void button_loai1_Click(object sender, EventArgs e)
        {
            axMap.TileProvider = MapWinGIS.tkTileProvider.OpenHumanitarianMap;
        }

        private void button_loai2_Click(object sender, EventArgs e)
        {
            axMap.TileProvider = MapWinGIS.tkTileProvider.OpenStreetMap;
        }

        private void button_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fBanDo_Load(object sender, EventArgs e)
        {

        }
    }
}

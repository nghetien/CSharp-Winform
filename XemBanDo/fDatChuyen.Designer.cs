namespace XemBanDo
{
    partial class fDatChuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thongtintaikhoan_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.quanly_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.naptien_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView_thongtintua = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_xembando = new System.Windows.Forms.Button();
            this.groupBox_chucnang = new System.Windows.Forms.GroupBox();
            this.button_lichsudat = new System.Windows.Forms.Button();
            this.textBox_tiendangco = new System.Windows.Forms.TextBox();
            this.textBox_tiengiatua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_dattua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_cactua = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox_chucnang.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongtintaikhoan_stripmenu,
            this.quanly_stripmenu,
            this.naptien_stripmenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thongtintaikhoan_stripmenu
            // 
            this.thongtintaikhoan_stripmenu.Name = "thongtintaikhoan_stripmenu";
            this.thongtintaikhoan_stripmenu.Size = new System.Drawing.Size(126, 20);
            this.thongtintaikhoan_stripmenu.Text = "Thông Tin Tài Khoản";
            this.thongtintaikhoan_stripmenu.Click += new System.EventHandler(this.thongtintaikhoan_stripmenu_Click);
            // 
            // quanly_stripmenu
            // 
            this.quanly_stripmenu.Name = "quanly_stripmenu";
            this.quanly_stripmenu.Size = new System.Drawing.Size(62, 20);
            this.quanly_stripmenu.Text = "Quản Lý";
            this.quanly_stripmenu.Click += new System.EventHandler(this.quanly_stripmenu_Click);
            // 
            // naptien_stripmenu
            // 
            this.naptien_stripmenu.Name = "naptien_stripmenu";
            this.naptien_stripmenu.Size = new System.Drawing.Size(66, 20);
            this.naptien_stripmenu.Text = "Nạp Tiền";
            this.naptien_stripmenu.Click += new System.EventHandler(this.naptien_stripmenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox_chucnang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 147);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listView_thongtintua);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(129, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 147);
            this.panel4.TabIndex = 3;
            // 
            // listView_thongtintua
            // 
            this.listView_thongtintua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_thongtintua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_thongtintua.GridLines = true;
            this.listView_thongtintua.HideSelection = false;
            this.listView_thongtintua.Location = new System.Drawing.Point(0, 0);
            this.listView_thongtintua.Name = "listView_thongtintua";
            this.listView_thongtintua.Size = new System.Drawing.Size(466, 147);
            this.listView_thongtintua.TabIndex = 0;
            this.listView_thongtintua.UseCompatibleStateImageBehavior = false;
            this.listView_thongtintua.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Tua";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đất Nước";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Danh Mục";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Khách Sạn";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày Đến";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày Đi";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Đã Đặt";
            this.columnHeader8.Width = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_thoat);
            this.panel3.Controls.Add(this.button_xembando);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 147);
            this.panel3.TabIndex = 2;
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(12, 79);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(93, 48);
            this.button_thoat.TabIndex = 2;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_xembando
            // 
            this.button_xembando.Location = new System.Drawing.Point(12, 20);
            this.button_xembando.Name = "button_xembando";
            this.button_xembando.Size = new System.Drawing.Size(93, 48);
            this.button_xembando.TabIndex = 1;
            this.button_xembando.Text = "Xem Bản Đồ Thế Giới";
            this.button_xembando.UseVisualStyleBackColor = true;
            this.button_xembando.Click += new System.EventHandler(this.button_xembando_Click);
            // 
            // groupBox_chucnang
            // 
            this.groupBox_chucnang.Controls.Add(this.button_lichsudat);
            this.groupBox_chucnang.Controls.Add(this.textBox_tiendangco);
            this.groupBox_chucnang.Controls.Add(this.textBox_tiengiatua);
            this.groupBox_chucnang.Controls.Add(this.label2);
            this.groupBox_chucnang.Controls.Add(this.label1);
            this.groupBox_chucnang.Controls.Add(this.button_dattua);
            this.groupBox_chucnang.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox_chucnang.Location = new System.Drawing.Point(595, 0);
            this.groupBox_chucnang.Name = "groupBox_chucnang";
            this.groupBox_chucnang.Size = new System.Drawing.Size(269, 147);
            this.groupBox_chucnang.TabIndex = 1;
            this.groupBox_chucnang.TabStop = false;
            this.groupBox_chucnang.Text = "Chức Năng";
            // 
            // button_lichsudat
            // 
            this.button_lichsudat.Location = new System.Drawing.Point(139, 19);
            this.button_lichsudat.Name = "button_lichsudat";
            this.button_lichsudat.Size = new System.Drawing.Size(118, 64);
            this.button_lichsudat.TabIndex = 8;
            this.button_lichsudat.Text = "Lịch Sử";
            this.button_lichsudat.UseVisualStyleBackColor = true;
            this.button_lichsudat.Click += new System.EventHandler(this.button_lichsudat_Click);
            // 
            // textBox_tiendangco
            // 
            this.textBox_tiendangco.Location = new System.Drawing.Point(167, 121);
            this.textBox_tiendangco.Name = "textBox_tiendangco";
            this.textBox_tiendangco.ReadOnly = true;
            this.textBox_tiendangco.Size = new System.Drawing.Size(90, 20);
            this.textBox_tiendangco.TabIndex = 7;
            // 
            // textBox_tiengiatua
            // 
            this.textBox_tiengiatua.Location = new System.Drawing.Point(24, 121);
            this.textBox_tiengiatua.Name = "textBox_tiengiatua";
            this.textBox_tiengiatua.ReadOnly = true;
            this.textBox_tiengiatua.Size = new System.Drawing.Size(85, 20);
            this.textBox_tiengiatua.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá Của Tua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tiền Đang có";
            // 
            // button_dattua
            // 
            this.button_dattua.Location = new System.Drawing.Point(7, 19);
            this.button_dattua.Name = "button_dattua";
            this.button_dattua.Size = new System.Drawing.Size(118, 64);
            this.button_dattua.TabIndex = 3;
            this.button_dattua.Text = "Đặt Tua";
            this.button_dattua.UseVisualStyleBackColor = true;
            this.button_dattua.Click += new System.EventHandler(this.button_dattua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel_cactua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 320);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel_cactua
            // 
            this.flowLayoutPanel_cactua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_cactua.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_cactua.Name = "flowLayoutPanel_cactua";
            this.flowLayoutPanel_cactua.Size = new System.Drawing.Size(864, 320);
            this.flowLayoutPanel_cactua.TabIndex = 0;
            // 
            // fDatChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fDatChuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDatChuyen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox_chucnang.ResumeLayout(false);
            this.groupBox_chucnang.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thongtintaikhoan_stripmenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView_thongtintua;
        private System.Windows.Forms.GroupBox groupBox_chucnang;
        private System.Windows.Forms.Button button_dattua;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_xembando;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_cactua;
        private System.Windows.Forms.ToolStripMenuItem quanly_stripmenu;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripMenuItem naptien_stripmenu;
        private System.Windows.Forms.TextBox textBox_tiendangco;
        private System.Windows.Forms.TextBox textBox_tiengiatua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_lichsudat;
    }
}
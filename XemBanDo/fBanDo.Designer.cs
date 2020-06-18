namespace XemBanDo
{
    partial class fBanDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBanDo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_loaimap = new System.Windows.Forms.GroupBox();
            this.button_loai2 = new System.Windows.Forms.Button();
            this.button_loai1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_zoom = new System.Windows.Forms.Button();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.button_khoangcach = new System.Windows.Forms.Button();
            this.button_dientich = new System.Windows.Forms.Button();
            this.button_dichuyen = new System.Windows.Forms.Button();
            this.axMap = new AxMapWinGIS.AxMap();
            this.panel1.SuspendLayout();
            this.groupBox_loaimap.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_loaimap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 449);
            this.panel1.TabIndex = 0;
            // 
            // groupBox_loaimap
            // 
            this.groupBox_loaimap.Controls.Add(this.button_loai2);
            this.groupBox_loaimap.Controls.Add(this.button_loai1);
            this.groupBox_loaimap.Location = new System.Drawing.Point(14, 13);
            this.groupBox_loaimap.Name = "groupBox_loaimap";
            this.groupBox_loaimap.Size = new System.Drawing.Size(220, 103);
            this.groupBox_loaimap.TabIndex = 0;
            this.groupBox_loaimap.TabStop = false;
            this.groupBox_loaimap.Text = "Chọn Loại Bản Đồ";
            // 
            // button_loai2
            // 
            this.button_loai2.Location = new System.Drawing.Point(126, 34);
            this.button_loai2.Name = "button_loai2";
            this.button_loai2.Size = new System.Drawing.Size(75, 38);
            this.button_loai2.TabIndex = 2;
            this.button_loai2.Text = "Loại 2";
            this.button_loai2.UseVisualStyleBackColor = true;
            this.button_loai2.Click += new System.EventHandler(this.button_loai2_Click);
            // 
            // button_loai1
            // 
            this.button_loai1.Location = new System.Drawing.Point(26, 34);
            this.button_loai1.Name = "button_loai1";
            this.button_loai1.Size = new System.Drawing.Size(75, 38);
            this.button_loai1.TabIndex = 0;
            this.button_loai1.Text = "Loại 1";
            this.button_loai1.UseVisualStyleBackColor = true;
            this.button_loai1.Click += new System.EventHandler(this.button_loai1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_thoat);
            this.panel2.Controls.Add(this.button_zoom);
            this.panel2.Controls.Add(this.button_timkiem);
            this.panel2.Controls.Add(this.button_khoangcach);
            this.panel2.Controls.Add(this.button_dientich);
            this.panel2.Controls.Add(this.button_dichuyen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 42);
            this.panel2.TabIndex = 1;
            // 
            // button_thoat
            // 
            this.button_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thoat.Location = new System.Drawing.Point(140, 6);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(75, 30);
            this.button_thoat.TabIndex = 6;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_dangxuat_Click);
            // 
            // button_zoom
            // 
            this.button_zoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_zoom.Location = new System.Drawing.Point(393, 0);
            this.button_zoom.Name = "button_zoom";
            this.button_zoom.Size = new System.Drawing.Size(75, 42);
            this.button_zoom.TabIndex = 2;
            this.button_zoom.Text = "Zoom";
            this.button_zoom.UseVisualStyleBackColor = true;
            this.button_zoom.Click += new System.EventHandler(this.button_zoom_Click);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timkiem.Location = new System.Drawing.Point(40, 6);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(75, 30);
            this.button_timkiem.TabIndex = 5;
            this.button_timkiem.Text = "Tìm Kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // button_khoangcach
            // 
            this.button_khoangcach.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_khoangcach.Location = new System.Drawing.Point(501, 0);
            this.button_khoangcach.Name = "button_khoangcach";
            this.button_khoangcach.Size = new System.Drawing.Size(75, 42);
            this.button_khoangcach.TabIndex = 3;
            this.button_khoangcach.Text = "Khoảng Cách";
            this.button_khoangcach.UseVisualStyleBackColor = true;
            this.button_khoangcach.Click += new System.EventHandler(this.button_khoangcach_Click);
            // 
            // button_dientich
            // 
            this.button_dientich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dientich.Location = new System.Drawing.Point(612, 0);
            this.button_dientich.Name = "button_dientich";
            this.button_dientich.Size = new System.Drawing.Size(75, 42);
            this.button_dientich.TabIndex = 4;
            this.button_dientich.Text = "Diện Tích";
            this.button_dientich.UseVisualStyleBackColor = true;
            this.button_dientich.Click += new System.EventHandler(this.button_dientich_Click);
            // 
            // button_dichuyen
            // 
            this.button_dichuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dichuyen.Location = new System.Drawing.Point(290, 0);
            this.button_dichuyen.Name = "button_dichuyen";
            this.button_dichuyen.Size = new System.Drawing.Size(75, 42);
            this.button_dichuyen.TabIndex = 0;
            this.button_dichuyen.Text = "Di Chuyển";
            this.button_dichuyen.UseVisualStyleBackColor = true;
            this.button_dichuyen.Click += new System.EventHandler(this.button_dichuyen_Click);
            // 
            // axMap
            // 
            this.axMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap.Enabled = true;
            this.axMap.Location = new System.Drawing.Point(248, 0);
            this.axMap.Name = "axMap";
            this.axMap.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap.OcxState")));
            this.axMap.Size = new System.Drawing.Size(616, 449);
            this.axMap.TabIndex = 2;
            // 
            // fBanDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.axMap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fBanDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fBanDo_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox_loaimap.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_zoom;
        private System.Windows.Forms.Button button_khoangcach;
        private System.Windows.Forms.Button button_dientich;
        private System.Windows.Forms.Button button_dichuyen;
        private AxMapWinGIS.AxMap axMap;
        private System.Windows.Forms.GroupBox groupBox_loaimap;
        private System.Windows.Forms.Button button_loai2;
        private System.Windows.Forms.Button button_loai1;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_timkiem;
    }
}


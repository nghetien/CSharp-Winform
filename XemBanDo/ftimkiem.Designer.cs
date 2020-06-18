namespace XemBanDo
{
    partial class fTimKiem
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
            this.tabPage_tongquan = new System.Windows.Forms.TabPage();
            this.dataGridView_tkdatnuoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_thoattimkiem = new System.Windows.Forms.Button();
            this.button_tatcadatnuoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_tendatnuoc = new System.Windows.Forms.TextBox();
            this.button_tiemdatnuoc = new System.Windows.Forms.Button();
            this.tabControl_timkiem = new System.Windows.Forms.TabControl();
            this.tabPage_tongquan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tkdatnuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl_timkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_tongquan
            // 
            this.tabPage_tongquan.Controls.Add(this.dataGridView_tkdatnuoc);
            this.tabPage_tongquan.Controls.Add(this.panel1);
            this.tabPage_tongquan.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tongquan.Name = "tabPage_tongquan";
            this.tabPage_tongquan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tongquan.Size = new System.Drawing.Size(856, 465);
            this.tabPage_tongquan.TabIndex = 0;
            this.tabPage_tongquan.Text = "Tổng Quan";
            this.tabPage_tongquan.UseVisualStyleBackColor = true;
            // 
            // dataGridView_tkdatnuoc
            // 
            this.dataGridView_tkdatnuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tkdatnuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tkdatnuoc.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_tkdatnuoc.Name = "dataGridView_tkdatnuoc";
            this.dataGridView_tkdatnuoc.Size = new System.Drawing.Size(850, 400);
            this.dataGridView_tkdatnuoc.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_thoattimkiem);
            this.panel1.Controls.Add(this.button_tatcadatnuoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_tendatnuoc);
            this.panel1.Controls.Add(this.button_tiemdatnuoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 59);
            this.panel1.TabIndex = 2;
            // 
            // button_thoattimkiem
            // 
            this.button_thoattimkiem.Location = new System.Drawing.Point(715, -3);
            this.button_thoattimkiem.Name = "button_thoattimkiem";
            this.button_thoattimkiem.Size = new System.Drawing.Size(119, 65);
            this.button_thoattimkiem.TabIndex = 4;
            this.button_thoattimkiem.Text = "Thoát";
            this.button_thoattimkiem.UseVisualStyleBackColor = true;
            this.button_thoattimkiem.Click += new System.EventHandler(this.button_thoattimkiem_Click);
            // 
            // button_tatcadatnuoc
            // 
            this.button_tatcadatnuoc.Location = new System.Drawing.Point(0, 0);
            this.button_tatcadatnuoc.Name = "button_tatcadatnuoc";
            this.button_tatcadatnuoc.Size = new System.Drawing.Size(119, 66);
            this.button_tatcadatnuoc.TabIndex = 3;
            this.button_tatcadatnuoc.Text = "Tất Cả";
            this.button_tatcadatnuoc.UseVisualStyleBackColor = true;
            this.button_tatcadatnuoc.Click += new System.EventHandler(this.button_tatcadatnuoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Đất Nước:";
            // 
            // textBox_tendatnuoc
            // 
            this.textBox_tendatnuoc.Location = new System.Drawing.Point(258, 19);
            this.textBox_tendatnuoc.Name = "textBox_tendatnuoc";
            this.textBox_tendatnuoc.Size = new System.Drawing.Size(280, 20);
            this.textBox_tendatnuoc.TabIndex = 1;
            // 
            // button_tiemdatnuoc
            // 
            this.button_tiemdatnuoc.Location = new System.Drawing.Point(590, -4);
            this.button_tiemdatnuoc.Name = "button_tiemdatnuoc";
            this.button_tiemdatnuoc.Size = new System.Drawing.Size(119, 66);
            this.button_tiemdatnuoc.TabIndex = 0;
            this.button_tiemdatnuoc.Text = "Tìm Kiếm";
            this.button_tiemdatnuoc.UseVisualStyleBackColor = true;
            this.button_tiemdatnuoc.Click += new System.EventHandler(this.button_tiemdatnuoc_Click);
            // 
            // tabControl_timkiem
            // 
            this.tabControl_timkiem.Controls.Add(this.tabPage_tongquan);
            this.tabControl_timkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_timkiem.Location = new System.Drawing.Point(0, 0);
            this.tabControl_timkiem.Name = "tabControl_timkiem";
            this.tabControl_timkiem.RightToLeftLayout = true;
            this.tabControl_timkiem.SelectedIndex = 0;
            this.tabControl_timkiem.Size = new System.Drawing.Size(864, 491);
            this.tabControl_timkiem.TabIndex = 0;
            // 
            // fTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.tabControl_timkiem);
            this.Name = "fTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "timkiem";
            this.Load += new System.EventHandler(this.fTimKiem_Load);
            this.tabPage_tongquan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tkdatnuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl_timkiem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage_tongquan;
        private System.Windows.Forms.DataGridView dataGridView_tkdatnuoc;
        private System.Windows.Forms.TabControl tabControl_timkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_tatcadatnuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tendatnuoc;
        private System.Windows.Forms.Button button_tiemdatnuoc;
        private System.Windows.Forms.Button button_thoattimkiem;
    }
}
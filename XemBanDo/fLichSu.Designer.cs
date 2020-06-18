namespace XemBanDo
{
    partial class fLichSu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_thoatls = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_lichsumuave = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lichsumuave)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_thoatls);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 48);
            this.panel1.TabIndex = 0;
            // 
            // button_thoatls
            // 
            this.button_thoatls.Location = new System.Drawing.Point(749, 0);
            this.button_thoatls.Name = "button_thoatls";
            this.button_thoatls.Size = new System.Drawing.Size(99, 48);
            this.button_thoatls.TabIndex = 1;
            this.button_thoatls.Text = "Thoát";
            this.button_thoatls.UseVisualStyleBackColor = true;
            this.button_thoatls.Click += new System.EventHandler(this.button_thoatls_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dưới đây là lịch sử đặt vé của bạn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_lichsumuave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 443);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_lichsumuave
            // 
            this.dataGridView_lichsumuave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lichsumuave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_lichsumuave.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_lichsumuave.Name = "dataGridView_lichsumuave";
            this.dataGridView_lichsumuave.Size = new System.Drawing.Size(864, 443);
            this.dataGridView_lichsumuave.TabIndex = 0;
            // 
            // fLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fLichSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fLichSu";
            this.Load += new System.EventHandler(this.fLichSu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lichsumuave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_lichsumuave;
        private System.Windows.Forms.Button button_thoatls;
    }
}
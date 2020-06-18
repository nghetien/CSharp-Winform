namespace XemBanDo
{
    partial class fNapTien
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
            this.label2 = new System.Windows.Forms.Label();
            this.button_napthe = new System.Windows.Forms.Button();
            this.button_thoatnapthe = new System.Windows.Forms.Button();
            this.textBox_mathenap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_soseri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Thẻ:";
            // 
            // button_napthe
            // 
            this.button_napthe.Location = new System.Drawing.Point(108, 139);
            this.button_napthe.Name = "button_napthe";
            this.button_napthe.Size = new System.Drawing.Size(99, 46);
            this.button_napthe.TabIndex = 2;
            this.button_napthe.Text = "Nạp Thẻ";
            this.button_napthe.UseVisualStyleBackColor = true;
            this.button_napthe.Click += new System.EventHandler(this.button_napthe_Click);
            // 
            // button_thoatnapthe
            // 
            this.button_thoatnapthe.Location = new System.Drawing.Point(250, 139);
            this.button_thoatnapthe.Name = "button_thoatnapthe";
            this.button_thoatnapthe.Size = new System.Drawing.Size(101, 46);
            this.button_thoatnapthe.TabIndex = 3;
            this.button_thoatnapthe.Text = "Thoát";
            this.button_thoatnapthe.UseVisualStyleBackColor = true;
            this.button_thoatnapthe.Click += new System.EventHandler(this.button_thoatnapthe_Click);
            // 
            // textBox_mathenap
            // 
            this.textBox_mathenap.Location = new System.Drawing.Point(108, 96);
            this.textBox_mathenap.Name = "textBox_mathenap";
            this.textBox_mathenap.Size = new System.Drawing.Size(243, 20);
            this.textBox_mathenap.TabIndex = 5;
            this.textBox_mathenap.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số Seri:";
            // 
            // textBox_soseri
            // 
            this.textBox_soseri.Location = new System.Drawing.Point(108, 56);
            this.textBox_soseri.Name = "textBox_soseri";
            this.textBox_soseri.Size = new System.Drawing.Size(243, 20);
            this.textBox_soseri.TabIndex = 7;
            // 
            // fNapTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 222);
            this.Controls.Add(this.textBox_soseri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_mathenap);
            this.Controls.Add(this.button_thoatnapthe);
            this.Controls.Add(this.button_napthe);
            this.Controls.Add(this.label2);
            this.Name = "fNapTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fNapTien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_napthe;
        private System.Windows.Forms.Button button_thoatnapthe;
        private System.Windows.Forms.TextBox textBox_mathenap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_soseri;
    }
}
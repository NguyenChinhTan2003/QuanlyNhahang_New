namespace QuanlyNhahang
{
    partial class Giaodien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giaodien));
            this.panel1_Body = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnThucDon = new System.Windows.Forms.Button();
            this.btnQLBA = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3_Body = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
<<<<<<< Updated upstream
=======
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
>>>>>>> Stashed changes
            this.panel1_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3_Body.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_Body
            // 
            this.panel1_Body.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1_Body.Controls.Add(this.btnLogOut);
            this.panel1_Body.Controls.Add(this.btnDoanhThu);
            this.panel1_Body.Controls.Add(this.btnHoaDon);
            this.panel1_Body.Controls.Add(this.btnThucDon);
            this.panel1_Body.Controls.Add(this.btnQLBA);
            this.panel1_Body.Controls.Add(this.btnQLKH);
            this.panel1_Body.Controls.Add(this.btnQLNV);
            this.panel1_Body.Controls.Add(this.pictureBox1);
            this.panel1_Body.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1_Body.Location = new System.Drawing.Point(0, 0);
            this.panel1_Body.Name = "panel1_Body";
            this.panel1_Body.Size = new System.Drawing.Size(242, 623);
            this.panel1_Body.TabIndex = 0;
            this.panel1_Body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Body_Paint);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogOut.Location = new System.Drawing.Point(0, 578);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(242, 45);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoanhThu.Location = new System.Drawing.Point(0, 397);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(242, 45);
            this.btnDoanhThu.TabIndex = 6;
            this.btnDoanhThu.Text = "Doanh Thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHoaDon.Location = new System.Drawing.Point(0, 352);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(242, 45);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "Quản Lí Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThucDon
            // 
            this.btnThucDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThucDon.Location = new System.Drawing.Point(0, 307);
            this.btnThucDon.Name = "btnThucDon";
            this.btnThucDon.Size = new System.Drawing.Size(242, 45);
            this.btnThucDon.TabIndex = 4;
            this.btnThucDon.Text = "Quản Lí Thực Đơn";
            this.btnThucDon.UseVisualStyleBackColor = true;
            this.btnThucDon.Click += new System.EventHandler(this.btnThucDon_Click);
            // 
            // btnQLBA
            // 
            this.btnQLBA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLBA.Location = new System.Drawing.Point(0, 262);
            this.btnQLBA.Name = "btnQLBA";
            this.btnQLBA.Size = new System.Drawing.Size(242, 45);
            this.btnQLBA.TabIndex = 3;
            this.btnQLBA.Text = "Quản Lí Bàn Ăn";
            this.btnQLBA.UseVisualStyleBackColor = true;
            // 
            // btnQLKH
            // 
            this.btnQLKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLKH.Location = new System.Drawing.Point(0, 217);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(242, 45);
            this.btnQLKH.TabIndex = 2;
            this.btnQLKH.Text = "Quản Lí Khách Hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            // 
            // btnQLNV
            // 
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLNV.Location = new System.Drawing.Point(0, 172);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(242, 45);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản Lí Nhân Viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.QLNV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(242, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 172);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(158, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NHÀ HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3_Body
            // 
            this.panel3_Body.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3_Body.Controls.Add(this.statusStrip1);
            this.panel3_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3_Body.Location = new System.Drawing.Point(242, 172);
            this.panel3_Body.Name = "panel3_Body";
            this.panel3_Body.Size = new System.Drawing.Size(872, 451);
            this.panel3_Body.TabIndex = 2;
            this.panel3_Body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(872, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Giaodien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1114, 623);
            this.Controls.Add(this.panel3_Body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giaodien";
            this.Text = "Quản lí nhà hàng";
            this.Load += new System.EventHandler(this.Giaodien_Load);
            this.panel1_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3_Body.ResumeLayout(false);
            this.panel3_Body.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_Body;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3_Body;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnThucDon;
        private System.Windows.Forms.Button btnQLBA;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
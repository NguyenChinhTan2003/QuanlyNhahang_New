using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QuanlyNhahang
{
    public partial class frmQLDT : Form
    {
        public frmQLDT()
        {
            InitializeComponent();
        }

        private void ShowGiaodien() //Viết 1 hàm không trả về giá trị và không đối số thực hiện việc hiển thị form 2

        {
            Giaodien gd = new Giaodien();
            Thread thread = new Thread(new ThreadStart(ShowGiaodien)); // Khởi tạo luồng mới
            thread.Start();
            gd.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn quay lại? ", "THÔNG BÁO ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == rs)
            {

                this.Close();
            }
        }
    }
}

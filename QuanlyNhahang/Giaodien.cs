using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyNhahang
{
    public partial class Giaodien : Form
    {
        

        public Giaodien()
        {
            InitializeComponent();
        }

        private void ShowLogin() //Viết 1 hàm không trả về giá trị và không đối số thực hiện việc hiển thị form 2

        {
            Login lg = new Login();
            lg.ShowDialog();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3_Body.Controls.Add(childForm);
            panel3_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowLogin)); // Khởi tạo luồng mới
            thread.Start();
            this.Close();
        }

        private void btnBA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là  {1} ", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Giaodien_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn quay lại LOG IN ? ", "THÔNG BÁO ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == rs)
            {
                Thread thread = new Thread(new ThreadStart(ShowLogin)); // Khởi tạo luồng mới
                thread.Start();
                this.Close();
            }
        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLNV());
            label1.Text = btnQLNV.Text;
        }

        private void panel1_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLTD());
            label1.Text = btnThucDon.Text;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLDT());
            label1.Text = btnDoanhThu.Text;
        }
    }
}

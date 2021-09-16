using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FormChuyenChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        
        public FormChuyenChiNhanh()
        {
            InitializeComponent();
        }
       

        private void FormChuyenChiNhanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.view_DanhSachPhanManh' table. You can move, or remove it, as needed.
            //this.view_DanhSachPhanManhTableAdapter.Fill(this.qLVT_DATHANGDataSet.view_DanhSachPhanManh);



            /*Lấy dữ liệu từ form đăng nhập đổ vào*/
            tENCNComboBox.DataSource  = Program.bindingSource.DataSource;
            /*sao chep bingding source tu form dang nhap*/
            tENCNComboBox.DisplayMember = "tencn";
            tENCNComboBox.ValueMember = "tenserver";
            //tENCNComboBox.SelectedIndex = Program.brand;

        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /*tạo delegate - một cái biến mà khi được gọi, nó sẽ thực hiện 1 hàm(function) khác
         * Ví dụ: ở class formNhanVien, ta có hàm chuyển chi nhánh, hàm này cần 1 tham số, chính
         * là tên server được chọn ở formChuyenChiNhanh này. Để gọi được hàm chuyển chi nhánh ở formNHANVIEN
         * Chúng ta khai báo 1 delete là branchTransfer để gọi hàm chuyển chi nhánh về form này
         */
        public delegate void MyDelegate(string chiNhanh);
        public MyDelegate branchTransfer;
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if(cmbCHINHANH.Text.Trim().Equals("") )
            {
                MessageBox.Show("Vui lòng chọn chi nhánh","Thông báo", MessageBoxButtons.OK);
                return;
            }
            //Console.WriteLine( cmbCHINHANH.SelectedValue.ToString() );
            branchTransfer(cmbCHINHANH.SelectedValue.ToString() );
            MessageBox.Show("Chi nhánh bạn chọn là : " + cmbCHINHANH.SelectedValue.ToString());
            this.Dispose();
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
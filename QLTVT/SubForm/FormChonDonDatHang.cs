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
    public partial class FormChonDonDatHang : Form
    {
        public FormChonDonDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDonDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormChonDonDatHang_Load(object sender, EventArgs e)
        {
            /*không kiểm tra khóa ngoại nữa*/
            dataSet.EnforceConstraints = false;

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dataSet.DatHang);
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        /*Kiem tra xem don hang co phieu nhap chua. Moi don hang thi
         * chi co duy nhat mot phieu nhap 
         * 
         * Tra ve 0 neu don hang chua co phieu nhap
         * Tra ve 1 neu don hang da co phieu nhap | xay ra loi bat ki
         */
        private int kiemTraDonHangCoPhieuNhap(String maDonHang)
        {


            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_DonHangCoPhieuNhapChua '" +
                    maDonHang + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi Stored Procedure thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return 1;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            //Console.WriteLine(result);
            Program.myReader.Close();

            return result;
        }

        /********************************************************
         * tao phieu nhap thi can tu dong dien cac truong sau
         * 1.Ma Don Dat Hang
         * 2.Ma Nhan Vien
         * 3.Ma Kho
         ********************************************************/
        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsDonDatHang.Current));
            string maNhanVien = drv["MANV"].ToString().Trim();
            string maDonHang = drv["MasoDDH"].ToString().Trim();
            string maKho = drv["MaKho"].ToString().Trim();

            if( Program.userName != maNhanVien)
            {
                MessageBox.Show("Bạn không thể lập phiếu trên đơn đặt hàng do người khác tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int ketQua = kiemTraDonHangCoPhieuNhap(maDonHang);
            
            if( ketQua == 1)
            {
                MessageBox.Show("Đơn hàng này đã có phiếu nhập không thể tạo thêm", "Thông báo", MessageBoxButtons.OK);
                return;
            }    

            Program.maDonDatHangDuocChon = maDonHang;
            Program.maKhoDuocChon = maKho;

            //Console.WriteLine("Don dat hang duoc chon");
            //Console.WriteLine(maDonHang);
            //Console.WriteLine(maKho);

            this.Close();
        }
    }
}

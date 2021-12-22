using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FormChonChiTietDonHang : Form
    {
        public FormChonChiTietDonHang()
        {
            InitializeComponent();
        }

        private void cTDDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsChiTietDonHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormChonChiTietDonHang_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.dataSet.CTDDH);

        }
        /*
         * ta sử dụng maDonDatHangDuocChonChiTiet là vì nếu như ta thêm
         * phiếu nhập cho đơn đặt hàng 1 nhưng chi tiết phiếu nhập ta lại lập
         * bằng chi tiết đơn đặt hàng 2 thì sẽ dẫn tới mâu thuẫn.
         * 
         * đúng thì phải là lập phiếu bằng mã đơn đặt hàng 1 thì chi tiết 
         * phiếu nhập cũng phải chọn chi tiết đơn đặt hàng 1 mới hợp lý
         * 
         * trong formLapPhieu có maDonHangDuocChon là mã đơn hàng của phiếu
         * nhập còn maDonDatHangDuocChonChiTiet là mã đơn hàng khi chọn chi 
         * tiết đơn hàng.
         * 
         * 2 mã này phải giống nhau thì mới cho phép ghi
         */
        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsChiTietDonHang.Current));
            string maDonHang = drv["MasoDDH"].ToString().Trim();
            string maVatTu = drv["MaVT"].ToString().Trim();
            int soLuong = int.Parse( drv["SOLUONG"].ToString().Trim() );
            int donGia = int.Parse( drv["DONGIA"].ToString().Trim());


            /*Kiem tra xem ma don hang cua gcPhieuNhap co trung voi ma don hang duoc chon hay khong ?*/
            Program.maDonDatHangDuocChonChiTiet = maDonHang;
            if( Program.maDonDatHangDuocChon != Program.maDonDatHangDuocChonChiTiet)
            {
                MessageBox.Show("Bạn phải chọn chi tiết đơn hàng có mã đơn hàng là " + Program.maDonDatHangDuocChon, "Thông báo",MessageBoxButtons.OK);
                return;
            }

            /**
             * Viết 1 đoạn code chạy stored procedure kiểm tra xem mã PN10 và mã vật tư W8
             * đã tồn tại hay chưa ???
             */


            Program.maVatTuDuocChon = maVatTu;
            Program.soLuongVatTu = soLuong;
            Program.donGia = donGia;
            this.Close();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

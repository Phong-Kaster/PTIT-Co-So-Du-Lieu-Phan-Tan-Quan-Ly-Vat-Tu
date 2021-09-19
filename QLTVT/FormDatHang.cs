using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormLapPhieu : Form
    {
        /* vị trí của con trỏ trên grid view*/
        int viTri = 0;
        /********************************************
         * đang thêm mới -> true -> đang dùng btnTHEM
         *              -> false -> có thể là btnGHI( chỉnh sửa) hoặc btnXOA
         *              
         * Mục đích: dùng biến này để phân biệt giữa btnTHEM - thêm mới hoàn toàn
         * và việc chỉnh sửa nhân viên( do mình ko dùng thêm btnXOA )
         * Trạng thái true or false sẽ được sử dụng 
         * trong btnGHI - việc này để phục vụ cho btnHOANTAC
         ********************************************/
        bool dangThemMoi = false;

        String maChiNhanh = "";

        /*****************************************************************************
         *Do xử lý 3 phiếu trong một chương trình nên cần có những biến tạm bên dưới
         *để phân biệt xem đang làm việc với loại phiếu 
         *
         * bds: luu tam bingding source dang lam viec
         * groupBox: khu vực nhập dữ liệu
         * undoList: chua cac cau lenh de hoanTac
*****************************************************************************/
        BindingSource bds = null;
        GroupBox groupBox = null; 


        Stack DonDatHangUndoList = new Stack();
        Stack PhieuNhapUndoList = new Stack();
        Stack PhieuXuatUndoList = new Stack();
        public FormLapPhieu()
        {
            InitializeComponent();
        }


        /********************************************************
         * Bật các nút chức năng và dữ liệu theo từng chế độ
         * Step 0: gán tiêu đề đang chọn
         * Step 1: tắt hết đi cho chắc cú
         * Step 2: bật gc và panel theo chế độ được chọn
         ********************************************************/
        private void batCheDo(string cheDo, GridControl gridControl, GroupControl groupControl)
        {
            /*Step 0*/
            btnMENU.Links[0].Caption = cheDo;

            /*Step 1*/
            gcDonDatHang.Visible = false;
            gcPhieuNhap.Visible = false;
            gcPhieuXuat.Visible = false;

            panelDonDatHang.Visible = false;
            panelPhieuNhap.Visible = false;
            panelPhieuXuat.Visible = false;

            /*Step 2*/
            groupControl.Visible = true;
            gridControl.Visible = true;

        }
        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDonDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }



        /**********************************************************
         * Step 0: do có nhiều grid control và group control nên phải đặt chiều cao để cân bằng được 2 cái này
         * 
         * Step 1: đổ dữ liệu vào
         * 
         * Step 2: lấy thông tin từ form đăng nhập
         * 
         * Step 3: tắt hết các nút, chờ chọn chế độ
         **********************************************************/
        private void FormDatHang_Load(object sender, EventArgs e)
        {
            gcDonDatHang.Height = 200;
            panelDonDatHang.Height = 400;

            gcPhieuXuat.Height = 200;
            panelPhieuXuat.Height = 400;

            panelPhieuNhap.Height = 400;

            /*Step 1*/
            /*không kiểm tra khóa ngoại nữa*/
            dataSet.EnforceConstraints = false;

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dataSet.Kho);

            this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietDonDatHangTableAdapter.Fill(this.dataSet.CTDDH);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);

            /*van con ton tai loi chua sua duoc*/
            //maChiNhanh = ((DataRowView)bdsDonDatHang[0])["MACN"].ToString();

            /*Step 2*/
            cmbCHINHANH.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.role == "CONGTY")
            {
                cmbCHINHANH.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnTHOAT.Enabled = true;

                gcDonDatHang.Enabled = true;
                panelDonDatHang.Enabled = false;
            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbCHINHANH.Enabled = false;

                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnTHOAT.Enabled = true;

                gcDonDatHang.Enabled = true;
                panelDonDatHang.Enabled = true;

                this.txtMaDonDatHang.Enabled = false;// panelDonDatHang
            }

            /*Step 4*/
            btnMENU.Links[0].Caption = "Đơn Đặt Hàng";
            bds = bdsDonDatHang;
            groupBox = groupBoxDonDatHang;

        }

        private void cTDDHGridControl_Click(object sender, EventArgs e)
        {

        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            /*Neu combobox khong co so lieu thi ket thuc luon*/
            if (cmbCHINHANH.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbCHINHANH.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbCHINHANH.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                /*Do du lieu tu dataSet vao grid Control*/
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.dataSet.Kho);

                this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.chiTietDonDatHangTableAdapter.Fill(this.dataSet.CTDDH);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dataSet.DatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);
                /*Tu dong lay maChiNhanh hien tai - phuc vu cho phan btnTHEM*/
                /*Cho dong nay chay thi bi loi*/
                //maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString().Trim();
            }
        }


        /*
         * Cập nhật bộ dữ liệu đang làm việc là của loại phiếu nào
         */
        private void btnDonDangHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            batCheDo("Đơn Đặt Hàng", gcDonDatHang, panelDonDatHang);

            if (Program.role == "CONGTY")
            {
                panelDonDatHang.Enabled = false;
            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                panelDonDatHang.Enabled = true;
            }

            bds = bdsDonDatHang;
            groupBox = groupBoxDonDatHang;
        }
        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            batCheDo("Phiếu Nhập", gcDonDatHang, panelPhieuNhap);

            bds = bdsDonDatHang;
        }
        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            batCheDo("Phiếu Xuất", gcPhieuXuat, panelPhieuXuat);

            bds = bdsPhieuXuat;
            groupBox = groupBoxPhieuXuat;
        }
        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcChiTietDonDatHang_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm chi tiết đơn hàng","Line 288",MessageBoxButtons.OK);
        }
    }
}

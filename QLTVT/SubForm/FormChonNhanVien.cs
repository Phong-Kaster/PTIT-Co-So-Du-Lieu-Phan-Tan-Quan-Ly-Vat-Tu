using DevExpress.XtraEditors;
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
    public partial class FormChonNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FormChonNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormChonNhanVien_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);

            cmbCHINHANH.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            if( Program.role == "CONGTY")
            {
                cmbCHINHANH.Enabled = true;
            }   

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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
            }
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsNhanVien.Current));
            string maNhanVien = drv["MANV"].ToString().Trim();

            string ho = drv["HO"].ToString().Trim();
            string ten = drv["TEN"].ToString().Trim();
            string hoTen = ho + " " + ten;

            string ngaySinh = ((DateTime)drv["NGAYSINH"]).ToString("dd-MM-yyyy");
            string diaChi = drv["DIACHI"].ToString().Trim();
            
            Program.maNhanVienDuocChon = maNhanVien;
            Program.hoTen = hoTen;
            //Console.WriteLine(Program.hoTen);
            Program.ngaySinh = ngaySinh;
            Program.diaChi = diaChi;

            this.Close();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
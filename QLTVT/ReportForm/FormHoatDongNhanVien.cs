using DevExpress.XtraReports.UI;
using QLTVT.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.ReportForm
{
    public partial class FormHoatDongNhanVien : Form
    {
        public FormHoatDongNhanVien()
        {
            InitializeComponent();
        }

        private void btnChonNhanVien_Click(object sender, EventArgs e)
        {
            FormChonNhanVien form = new FormChonNhanVien();
            form.ShowDialog();

            txtMaNhanVien.Text = Program.maNhanVienDuocChon;
            txtHoVaTen.Text = Program.hoTen;

            txtNgaySinh.Text = Program.ngaySinh;
            txtDiaChi.Text = Program.diaChi;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text;
            string loaiPhieu = (cmbLoaiPhieu.SelectedItem.ToString() == "NHAP") ? "NHAP" : "XUAT";
            DateTime fromDate = dteTuNgay.DateTime;
            DateTime toDate = dteToiNgay.DateTime;
            /*
            int fromYear = dteTuNgay.DateTime.Year;
            int fromMonth = dteTuNgay.DateTime.Month;
            int toYear = dteToiNgay.DateTime.Year;
            int toMonth = dteToiNgay.DateTime.Month;
            */
            ReportHoatDongNhanVien report = new ReportHoatDongNhanVien(maNhanVien, loaiPhieu, fromDate, toDate);
            /*GAN TEN CHI NHANH CHO BAO CAO*/
            report.txtLoaiPhieu.Text = cmbLoaiPhieu.SelectedItem.ToString().ToUpper();
            report.txtMaNhanVien.Text = Program.maNhanVienDuocChon;
            report.txtHoTen.Text = Program.hoTen;
            report.txtNgaySinh.Text = Program.ngaySinh;
            report.txtDiaChi.Text = Program.diaChi;
            report.txtTuNgay.Text = dteTuNgay.EditValue.ToString();
            report.txtToiNgay.Text = dteToiNgay.EditValue.ToString();

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void FormHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            cmbLoaiPhieu.SelectedIndex = 1;
            dteTuNgay.EditValue = "01-05-2000";
            dteToiNgay.EditValue = DateTime.Today.ToString("dd-MM-yyyy");
        }

        /***********************************************************
         * Step 1: lay cac du lieu can thiet
         * Step 2: gan cac du lieu nay vao bao cao
         * Step 3: xuat ban
         ***********************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhanVien = txtMaNhanVien.Text;
                string loaiPhieu = (cmbLoaiPhieu.SelectedItem.ToString() == "NHAP") ? "NHAP" : "XUAT";

                DateTime fromDate = dteTuNgay.DateTime;
                DateTime toDate = dteToiNgay.DateTime;
                /*
                int fromYear = dteTuNgay.DateTime.Year;
                int fromMonth = dteTuNgay.DateTime.Month;
                int toYear = dteToiNgay.DateTime.Year;
                int toMonth = dteToiNgay.DateTime.Month;
                */
                ReportHoatDongNhanVien report = new ReportHoatDongNhanVien(maNhanVien, loaiPhieu, fromDate, toDate);

                report.txtLoaiPhieu.Text = cmbLoaiPhieu.SelectedItem.ToString().ToUpper();
                report.txtMaNhanVien.Text = Program.maNhanVienDuocChon;
                report.txtHoTen.Text = Program.hoTen;
                report.txtNgaySinh.Text = Program.ngaySinh;
                report.txtDiaChi.Text = Program.diaChi;
                report.txtTuNgay.Text = dteTuNgay.EditValue.ToString();
                report.txtToiNgay.Text = dteToiNgay.EditValue.ToString();

                if (File.Exists(@"D:\ReportHoatDongNhanVien.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportHoatDongNhanVien.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportHoatDongNhanVien.pdf");
                        MessageBox.Show("File ReportHoatDongNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportHoatDongNhanVien.pdf");
                    MessageBox.Show("File ReportHoatDongNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportHoatDongNhanVien.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}

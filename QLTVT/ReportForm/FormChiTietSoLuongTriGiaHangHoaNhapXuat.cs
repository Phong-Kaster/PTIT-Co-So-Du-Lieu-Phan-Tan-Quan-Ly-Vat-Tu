using DevExpress.XtraReports.UI;
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
    public partial class FormChiTietSoLuongTriGiaHangHoaNhapXuat : Form
    {
        private string chiNhanh = "";
        public FormChiTietSoLuongTriGiaHangHoaNhapXuat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vaiTro = Program.role;
            string loaiPhieu = (cmbLoaiPhieu.SelectedItem.ToString() == "NHAP") ? "NHAP" : "XUAT";
            
            DateTime fromDate = dteTuNgay.DateTime;
            DateTime toDate = dteToiNgay.DateTime;
            ReportChiTietSoLuongTriGiaHangHoa report = new ReportChiTietSoLuongTriGiaHangHoa(vaiTro,loaiPhieu,fromDate,toDate);
            /*GAN TEN CHI NHANH CHO BAO CAO*/
            //report.txtLoaiPhieu.Text = cmbLoaiPhieu.SelectedItem.ToString("dd-MM-yyyy").ToUpper();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vaiTro = Program.role;
            string loaiPhieu = (cmbLoaiPhieu.SelectedItem.ToString() == "NHAP") ? "NHAP" : "XUAT";
            int fromYear = dteTuNgay.DateTime.Year;
            int fromMonth = dteTuNgay.DateTime.Month;
            int toYear = dteToiNgay.DateTime.Year;
            int toMonth = dteToiNgay.DateTime.Month;

            try
            {

                DateTime fromDate = dteTuNgay.DateTime;
                DateTime toDate = dteToiNgay.DateTime;
                ReportChiTietSoLuongTriGiaHangHoa report = new ReportChiTietSoLuongTriGiaHangHoa(vaiTro, loaiPhieu, fromDate, toDate);

                if (File.Exists(@"D:\ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf");
                        MessageBox.Show("File ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf");
                    MessageBox.Show("File ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}

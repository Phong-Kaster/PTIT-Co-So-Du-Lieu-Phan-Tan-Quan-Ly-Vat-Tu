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
            report.txtLoaiPhieu.Text = cmbLoaiPhieu.SelectedItem.ToString().ToUpper();
            report.txtTuNgay.Text = fromDate.ToString("dd-MM-yyyy");
            report.txtToiNgay.Text = toDate.ToString("dd-MM-yyyy");
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vaiTro = Program.role;
            string loaiPhieu = (cmbLoaiPhieu.SelectedItem.ToString() == "NHAP") ? "NHAP" : "XUAT";

            try
            {

                DateTime fromDate = dteTuNgay.DateTime;
                DateTime toDate = dteToiNgay.DateTime;



                ReportChiTietSoLuongTriGiaHangHoa report = new ReportChiTietSoLuongTriGiaHangHoa(vaiTro, loaiPhieu, fromDate, toDate);


                /*GAN TEN CHI NHANH CHO BAO CAO*/
                report.txtLoaiPhieu.Text = cmbLoaiPhieu.SelectedItem.ToString().ToUpper();
                report.txtTuNgay.Text = fromDate.ToString("dd-MM-yyyy");
                report.txtToiNgay.Text = toDate.ToString("dd-MM-yyyy");


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

        private void FormChiTietSoLuongTriGiaHangHoaNhapXuat_Load(object sender, EventArgs e)
        {
            this.cmbLoaiPhieu.SelectedIndex = 1;
            this.dteTuNgay.EditValue = "01-05-2021";
            this.dteToiNgay.EditValue = "21-12-2021";
        }
    }
}

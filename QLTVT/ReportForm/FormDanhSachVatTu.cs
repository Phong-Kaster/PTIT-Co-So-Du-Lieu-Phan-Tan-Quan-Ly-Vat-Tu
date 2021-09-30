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
    public partial class FormDanhSachVatTu : Form
    {
        public FormDanhSachVatTu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDanhSachVatTu report = new ReportDanhSachVatTu();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDanhSachVatTu report = new ReportDanhSachVatTu();
            try
            {
                if (File.Exists(@"D:\ReportDanhSachVatTu.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportDanhSachVatTu.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportDanhSachVatTu.pdf");
                        MessageBox.Show("File ReportDSNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportDanhSachVatTu.pdf");
                    MessageBox.Show("File ReportDSNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportDanhSachVatTu.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormDanhSachVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.dataSet.Vattu);

        }
    }
}

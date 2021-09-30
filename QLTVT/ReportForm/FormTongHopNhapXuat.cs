using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.ReportForm
{
    public partial class FormTongHopNhapXuat : Form
    {
        public FormTongHopNhapXuat()
        {
            InitializeComponent();
        }

        private void FormTongHopNhapXuat_Load(object sender, EventArgs e)
        {
            /*Step 2*/
            cmbCHINHANH.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            dteTuNgay.EditValue = "01-05-2000";
            dteToiNgay.EditValue = DateTime.Today.ToString("dd-MM-yyyy");

            if (Program.role == "CONGTY")
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = (DateTime)dteTuNgay.DateTime;
            DateTime toDate = (DateTime)dteToiNgay.DateTime;
            string chiNhanh = cmbCHINHANH.SelectedValue.ToString().Contains("1") ? "Helsinki" : "Lisbon";

            

            ReportTongHopNhapXuat report = new ReportTongHopNhapXuat(fromDate, toDate);
            report.txtTuNgay.Text = dteTuNgay.EditValue.ToString();
            report.txtToiNgay.Text = dteToiNgay.EditValue.ToString();
            report.txtChiNhanh.Text = chiNhanh;

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}

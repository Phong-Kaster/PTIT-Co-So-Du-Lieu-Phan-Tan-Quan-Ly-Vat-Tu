using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTVT.ReportForm
{
    public partial class ReportChiTietSoLuongTriGiaHangHoaNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportChiTietSoLuongTriGiaHangHoaNhapXuat()
        {
            InitializeComponent();
        }
        public ReportChiTietSoLuongTriGiaHangHoaNhapXuat(string vaiTro,string loaiPhieu, int fromYear,int fromMonth, int toYear, int toMonth)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = vaiTro;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = loaiPhieu;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = fromYear;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = fromMonth;
            this.sqlDataSource1.Queries[0].Parameters[4].Value = toYear;
            this.sqlDataSource1.Queries[0].Parameters[5].Value = toMonth;

            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }
    }
}

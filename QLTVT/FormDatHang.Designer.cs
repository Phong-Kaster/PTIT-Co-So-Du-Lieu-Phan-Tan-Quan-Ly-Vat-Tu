
namespace QLTVT
{
    partial class FormLapPhieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mAKHOLabel1;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLapPhieu));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnMENU = new DevExpress.XtraBars.BarSubItem();
            this.btnDonDangHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet = new QLTVT.DataSet();
            this.bdsDonDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLTVT.DataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.bdsChiTietDonHang = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietDonDatHangTableAdapter = new QLTVT.DataSetTableAdapters.CTDDHTableAdapter();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLTVT.DataSetTableAdapters.KhoTableAdapter();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLTVT.DataSetTableAdapters.PhieuNhapTableAdapter();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.gcDonDatHang = new DevExpress.XtraGrid.GridControl();
            this.gvDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.bdsPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.gvPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phieuXuatTableAdapter = new QLTVT.DataSetTableAdapters.PhieuXuatTableAdapter();
            this.panelDonDatHang = new DevExpress.XtraEditors.GroupControl();
            this.gcChiTietDonDatHang = new DevExpress.XtraGrid.GridControl();
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxDonDatHang = new System.Windows.Forms.GroupBox();
            this.txtMaKhoDonDatHang = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtNhaCungCapDonDatHang = new DevExpress.XtraEditors.TextEdit();
            this.dteNgayDonDatHang = new DevExpress.XtraEditors.DateEdit();
            this.txtMaDonDatHang = new DevExpress.XtraEditors.TextEdit();
            this.btnChonKho = new System.Windows.Forms.Button();
            this.panelPhieuXuat = new DevExpress.XtraEditors.GroupControl();
            this.gcChiTietPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gvCTPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxPhieuXuat = new System.Windows.Forms.GroupBox();
            this.txtMaKho_PX = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaPX = new System.Windows.Forms.TextBox();
            this.btnGridKho2 = new System.Windows.Forms.Button();
            this.panelPhieuNhap = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gvPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChiTietPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsThemChiTietDonHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            mAKHOLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mAKHOLabel1 = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDonDatHang)).BeginInit();
            this.panelDonDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            this.groupBoxDonDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoDonDatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCapDonDatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayDonDatHang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayDonDatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonDatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPhieuXuat)).BeginInit();
            this.panelPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).BeginInit();
            this.groupBoxPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPhieuNhap)).BeginInit();
            this.panelPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.cmsThemChiTietDonHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(26, 215);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(53, 17);
            mAKHOLabel.TabIndex = 11;
            mAKHOLabel.Text = "Mã Kho";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(26, 123);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(97, 17);
            nhaCCLabel.TabIndex = 9;
            nhaCCLabel.Text = "Nhà Cung Cấp";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(26, 38);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(117, 17);
            masoDDHLabel.TabIndex = 7;
            masoDDHLabel.Text = "Mã Đơn Đặt Hàng";
            // 
            // mAKHOLabel1
            // 
            mAKHOLabel1.AutoSize = true;
            mAKHOLabel1.Location = new System.Drawing.Point(103, 129);
            mAKHOLabel1.Name = "mAKHOLabel1";
            mAKHOLabel1.Size = new System.Drawing.Size(58, 17);
            mAKHOLabel1.TabIndex = 15;
            mAKHOLabel1.Text = "Mã Kho:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(103, 100);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(57, 17);
            hOTENKHLabel.TabIndex = 14;
            hOTENKHLabel.Text = "Tên KH:";
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(103, 70);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(50, 17);
            mAPXLabel.TabIndex = 13;
            mAPXLabel.Text = "Mã PX:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(26, 79);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 17);
            nGAYLabel.TabIndex = 14;
            nGAYLabel.Text = "Ngày";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(26, 171);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(90, 17);
            mANVLabel.TabIndex = 16;
            mANVLabel.Text = "Mã Nhân Viên";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTHEM,
            this.btnXOA,
            this.btnGHI,
            this.btnHOANTAC,
            this.btnLAMMOI,
            this.btnCHUYENCHINHANH,
            this.btnTHOAT,
            this.btnMENU,
            this.barButtonItem1,
            this.btnDonDangHang,
            this.btnPhieuNhap,
            this.btnPhieuXuat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 12;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHOANTAC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMENU, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "Thêm";
            this.btnTHEM.Id = 0;
            this.btnTHEM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHEM.ImageOptions.SvgImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(80, 0);
            // 
            // btnXOA
            // 
            this.btnXOA.Caption = "Xoá";
            this.btnXOA.Id = 1;
            this.btnXOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXOA.ImageOptions.SvgImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(70, 0);
            // 
            // btnGHI
            // 
            this.btnGHI.Caption = "Ghi";
            this.btnGHI.Id = 2;
            this.btnGHI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGHI.ImageOptions.SvgImage")));
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(70, 0);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.Caption = "Hoàn Tác";
            this.btnHOANTAC.Id = 3;
            this.btnHOANTAC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHOANTAC.ImageOptions.SvgImage")));
            this.btnHOANTAC.Name = "btnHOANTAC";
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Caption = "Làm Mới";
            this.btnLAMMOI.Id = 4;
            this.btnLAMMOI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI.ImageOptions.SvgImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            // 
            // btnMENU
            // 
            this.btnMENU.Caption = "Chọn Phiếu";
            this.btnMENU.Id = 7;
            this.btnMENU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMENU.ImageOptions.SvgImage")));
            this.btnMENU.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDonDangHang),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhieuNhap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhieuXuat)});
            this.btnMENU.Name = "btnMENU";
            // 
            // btnDonDangHang
            // 
            this.btnDonDangHang.Caption = "Đơn Đặt Hàng";
            this.btnDonDangHang.Id = 9;
            this.btnDonDangHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDonDangHang.ImageOptions.SvgImage")));
            this.btnDonDangHang.Name = "btnDonDangHang";
            this.btnDonDangHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonDangHang_ItemClick);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Caption = "Phiếu Nhập";
            this.btnPhieuNhap.Id = 10;
            this.btnPhieuNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhieuNhap.ImageOptions.SvgImage")));
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuNhap_ItemClick);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.Caption = "Phiếu Xuất";
            this.btnPhieuXuat.Id = 11;
            this.btnPhieuXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhieuXuat.ImageOptions.SvgImage")));
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuXuat_ItemClick);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Thoát";
            this.btnTHOAT.Id = 6;
            this.btnTHOAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHOAT.ImageOptions.SvgImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(944, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 652);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(944, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 622);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(944, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 622);
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 5;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbCHINHANH);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(944, 74);
            this.panelControl1.TabIndex = 6;
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.Enabled = false;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(319, 27);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(316, 24);
            this.cmbCHINHANH.TabIndex = 1;
            this.cmbCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDonDatHang
            // 
            this.bdsDonDatHang.DataMember = "DatHang";
            this.bdsDonDatHang.DataSource = this.dataSet;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // bdsChiTietDonHang
            // 
            this.bdsChiTietDonHang.DataMember = "FK_CTDDH_DatHang";
            this.bdsChiTietDonHang.DataSource = this.bdsDonDatHang;
            // 
            // chiTietDonDatHangTableAdapter
            // 
            this.chiTietDonDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.dataSet;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "FK_PhieuNhap_DatHang";
            this.bdsPhieuNhap.DataSource = this.bdsDonDatHang;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl1.Location = new System.Drawing.Point(0, 30);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 622);
            // 
            // gcDonDatHang
            // 
            this.gcDonDatHang.DataSource = this.bdsDonDatHang;
            this.gcDonDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDonDatHang.Location = new System.Drawing.Point(0, 104);
            this.gcDonDatHang.MainView = this.gvDDH;
            this.gcDonDatHang.MenuManager = this.barManager1;
            this.gcDonDatHang.Name = "gcDonDatHang";
            this.gcDonDatHang.Size = new System.Drawing.Size(944, 67);
            this.gcDonDatHang.TabIndex = 28;
            this.gcDonDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDDH});
            // 
            // gvDDH
            // 
            this.gvDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gvDDH.GridControl = this.gcDonDatHang;
            this.gvDDH.Name = "gvDDH";
            this.gvDDH.OptionsBehavior.Editable = false;
            this.gvDDH.OptionsView.ShowGroupPanel = false;
            this.gvDDH.OptionsView.ShowViewCaption = true;
            this.gvDDH.ViewCaption = "Đơn Đặt Hàng";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã Đơn Đăt Hàng";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 23;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 183;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 23;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 183;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà Cung Cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 23;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 190;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Nhân Viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 23;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 163;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 23;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 184;
            // 
            // gcPhieuXuat
            // 
            this.gcPhieuXuat.DataSource = this.bdsPhieuXuat;
            this.gcPhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuXuat.Location = new System.Drawing.Point(0, 171);
            this.gcPhieuXuat.MainView = this.gvPX;
            this.gcPhieuXuat.MenuManager = this.barManager1;
            this.gcPhieuXuat.Name = "gcPhieuXuat";
            this.gcPhieuXuat.Size = new System.Drawing.Size(944, 62);
            this.gcPhieuXuat.TabIndex = 29;
            this.gcPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPX});
            this.gcPhieuXuat.Visible = false;
            // 
            // bdsPhieuXuat
            // 
            this.bdsPhieuXuat.DataMember = "PhieuXuat";
            this.bdsPhieuXuat.DataSource = this.dataSet;
            // 
            // gvPX
            // 
            this.gvPX.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightGreen;
            this.gvPX.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightGreen;
            this.gvPX.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPX.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY1,
            this.colHOTENKH,
            this.colMANV1,
            this.colMAKHO1});
            this.gvPX.GridControl = this.gcPhieuXuat;
            this.gvPX.Name = "gvPX";
            this.gvPX.OptionsBehavior.Editable = false;
            this.gvPX.OptionsView.ShowGroupPanel = false;
            this.gvPX.OptionsView.ShowViewCaption = true;
            this.gvPX.ViewCaption = "Phiếu Xuất";
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã PX";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 23;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 213;
            // 
            // colNGAY1
            // 
            this.colNGAY1.Caption = "Ngày";
            this.colNGAY1.FieldName = "NGAY";
            this.colNGAY1.MinWidth = 23;
            this.colNGAY1.Name = "colNGAY1";
            this.colNGAY1.Visible = true;
            this.colNGAY1.VisibleIndex = 1;
            this.colNGAY1.Width = 223;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ tên khách hàng";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 23;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 297;
            // 
            // colMANV1
            // 
            this.colMANV1.Caption = "Mã NV";
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.MinWidth = 23;
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 3;
            this.colMANV1.Width = 171;
            // 
            // colMAKHO1
            // 
            this.colMAKHO1.Caption = "Mã kho";
            this.colMAKHO1.FieldName = "MAKHO";
            this.colMAKHO1.MinWidth = 23;
            this.colMAKHO1.Name = "colMAKHO1";
            this.colMAKHO1.Visible = true;
            this.colMAKHO1.VisibleIndex = 4;
            this.colMAKHO1.Width = 175;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // panelDonDatHang
            // 
            this.panelDonDatHang.Controls.Add(this.gcChiTietDonDatHang);
            this.panelDonDatHang.Controls.Add(this.groupBoxDonDatHang);
            this.panelDonDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDonDatHang.Location = new System.Drawing.Point(0, 233);
            this.panelDonDatHang.Name = "panelDonDatHang";
            this.panelDonDatHang.Size = new System.Drawing.Size(944, 309);
            this.panelDonDatHang.TabIndex = 35;
            this.panelDonDatHang.Text = "Đặt Hàng";
            // 
            // gcChiTietDonDatHang
            // 
            this.gcChiTietDonDatHang.ContextMenuStrip = this.cmsThemChiTietDonHang;
            this.gcChiTietDonDatHang.DataSource = this.bdsChiTietDonHang;
            this.gcChiTietDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietDonDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Level1";
            this.gcChiTietDonDatHang.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcChiTietDonDatHang.Location = new System.Drawing.Point(466, 28);
            this.gcChiTietDonDatHang.MainView = this.gvCTDDH;
            this.gcChiTietDonDatHang.MenuManager = this.barManager1;
            this.gcChiTietDonDatHang.Name = "gcChiTietDonDatHang";
            this.gcChiTietDonDatHang.Size = new System.Drawing.Size(476, 279);
            this.gcChiTietDonDatHang.TabIndex = 1;
            this.gcChiTietDonDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            this.gcChiTietDonDatHang.Click += new System.EventHandler(this.gcChiTietDonDatHang_Click);
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTDDH.GridControl = this.gcChiTietDonDatHang;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsBehavior.Editable = false;
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.ViewCaption = "Chi Tiết Đơn Đặt Hàng";
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.Caption = "Mã DDH";
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.MinWidth = 23;
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            this.colMasoDDH1.Width = 87;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 23;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 87;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 23;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 87;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.DisplayFormat.FormatString = "VND {0:n2}";
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 23;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 87;
            // 
            // groupBoxDonDatHang
            // 
            this.groupBoxDonDatHang.Controls.Add(this.txtMaKhoDonDatHang);
            this.groupBoxDonDatHang.Controls.Add(mANVLabel);
            this.groupBoxDonDatHang.Controls.Add(this.txtMaNhanVien);
            this.groupBoxDonDatHang.Controls.Add(this.txtNhaCungCapDonDatHang);
            this.groupBoxDonDatHang.Controls.Add(nGAYLabel);
            this.groupBoxDonDatHang.Controls.Add(this.dteNgayDonDatHang);
            this.groupBoxDonDatHang.Controls.Add(this.txtMaDonDatHang);
            this.groupBoxDonDatHang.Controls.Add(this.btnChonKho);
            this.groupBoxDonDatHang.Controls.Add(mAKHOLabel);
            this.groupBoxDonDatHang.Controls.Add(nhaCCLabel);
            this.groupBoxDonDatHang.Controls.Add(masoDDHLabel);
            this.groupBoxDonDatHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxDonDatHang.Location = new System.Drawing.Point(2, 28);
            this.groupBoxDonDatHang.Name = "groupBoxDonDatHang";
            this.groupBoxDonDatHang.Size = new System.Drawing.Size(464, 279);
            this.groupBoxDonDatHang.TabIndex = 0;
            this.groupBoxDonDatHang.TabStop = false;
            this.groupBoxDonDatHang.Text = "Thông Tin";
            // 
            // txtMaKhoDonDatHang
            // 
            this.txtMaKhoDonDatHang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "MAKHO", true));
            this.txtMaKhoDonDatHang.Enabled = false;
            this.txtMaKhoDonDatHang.Location = new System.Drawing.Point(163, 210);
            this.txtMaKhoDonDatHang.MenuManager = this.barManager1;
            this.txtMaKhoDonDatHang.Name = "txtMaKhoDonDatHang";
            this.txtMaKhoDonDatHang.Size = new System.Drawing.Size(125, 22);
            this.txtMaKhoDonDatHang.TabIndex = 18;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "MANV", true));
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(164, 168);
            this.txtMaNhanVien.MenuManager = this.barManager1;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(125, 22);
            this.txtMaNhanVien.TabIndex = 17;
            // 
            // txtNhaCungCapDonDatHang
            // 
            this.txtNhaCungCapDonDatHang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "NhaCC", true));
            this.txtNhaCungCapDonDatHang.Location = new System.Drawing.Point(164, 120);
            this.txtNhaCungCapDonDatHang.MenuManager = this.barManager1;
            this.txtNhaCungCapDonDatHang.Name = "txtNhaCungCapDonDatHang";
            this.txtNhaCungCapDonDatHang.Size = new System.Drawing.Size(125, 22);
            this.txtNhaCungCapDonDatHang.TabIndex = 16;
            // 
            // dteNgayDonDatHang
            // 
            this.dteNgayDonDatHang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "NGAY", true));
            this.dteNgayDonDatHang.EditValue = null;
            this.dteNgayDonDatHang.Enabled = false;
            this.dteNgayDonDatHang.Location = new System.Drawing.Point(164, 76);
            this.dteNgayDonDatHang.MenuManager = this.barManager1;
            this.dteNgayDonDatHang.Name = "dteNgayDonDatHang";
            this.dteNgayDonDatHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayDonDatHang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayDonDatHang.Size = new System.Drawing.Size(166, 22);
            this.dteNgayDonDatHang.TabIndex = 15;
            // 
            // txtMaDonDatHang
            // 
            this.txtMaDonDatHang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "MasoDDH", true));
            this.txtMaDonDatHang.Enabled = false;
            this.txtMaDonDatHang.Location = new System.Drawing.Point(164, 35);
            this.txtMaDonDatHang.MenuManager = this.barManager1;
            this.txtMaDonDatHang.Name = "txtMaDonDatHang";
            this.txtMaDonDatHang.Size = new System.Drawing.Size(125, 22);
            this.txtMaDonDatHang.TabIndex = 14;
            // 
            // btnChonKho
            // 
            this.btnChonKho.Location = new System.Drawing.Point(338, 207);
            this.btnChonKho.Name = "btnChonKho";
            this.btnChonKho.Size = new System.Drawing.Size(89, 34);
            this.btnChonKho.TabIndex = 13;
            this.btnChonKho.Text = "Chọn Kho";
            this.btnChonKho.UseVisualStyleBackColor = true;
            // 
            // panelPhieuXuat
            // 
            this.panelPhieuXuat.Controls.Add(this.gcChiTietPhieuXuat);
            this.panelPhieuXuat.Controls.Add(this.groupBoxPhieuXuat);
            this.panelPhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhieuXuat.Location = new System.Drawing.Point(0, 542);
            this.panelPhieuXuat.Name = "panelPhieuXuat";
            this.panelPhieuXuat.Size = new System.Drawing.Size(944, 69);
            this.panelPhieuXuat.TabIndex = 36;
            this.panelPhieuXuat.Text = "Phiếu Xuất";
            this.panelPhieuXuat.Visible = false;
            // 
            // gcChiTietPhieuXuat
            // 
            this.gcChiTietPhieuXuat.DataSource = this.bdsPhieuXuat;
            this.gcChiTietPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcChiTietPhieuXuat.Location = new System.Drawing.Point(449, 28);
            this.gcChiTietPhieuXuat.MainView = this.gvCTPX;
            this.gcChiTietPhieuXuat.MenuManager = this.barManager1;
            this.gcChiTietPhieuXuat.Name = "gcChiTietPhieuXuat";
            this.gcChiTietPhieuXuat.Size = new System.Drawing.Size(493, 39);
            this.gcChiTietPhieuXuat.TabIndex = 1;
            this.gcChiTietPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPX});
            // 
            // gvCTPX
            // 
            this.gvCTPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT2,
            this.colSOLUONG2,
            this.colDONGIA2});
            this.gvCTPX.GridControl = this.gcChiTietPhieuXuat;
            this.gvCTPX.Name = "gvCTPX";
            this.gvCTPX.OptionsBehavior.Editable = false;
            this.gvCTPX.OptionsView.ShowGroupPanel = false;
            this.gvCTPX.OptionsView.ShowViewCaption = true;
            this.gvCTPX.ViewCaption = "Chi Tiết Phiếu Xuất";
            // 
            // colMAPX1
            // 
            this.colMAPX1.Caption = "Mã PX";
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.MinWidth = 23;
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
            this.colMAPX1.Width = 87;
            // 
            // colMAVT2
            // 
            this.colMAVT2.Caption = "Mã VT";
            this.colMAVT2.FieldName = "MAVT";
            this.colMAVT2.MinWidth = 23;
            this.colMAVT2.Name = "colMAVT2";
            this.colMAVT2.Visible = true;
            this.colMAVT2.VisibleIndex = 1;
            this.colMAVT2.Width = 87;
            // 
            // colSOLUONG2
            // 
            this.colSOLUONG2.Caption = "Số lượng";
            this.colSOLUONG2.FieldName = "SOLUONG";
            this.colSOLUONG2.MinWidth = 23;
            this.colSOLUONG2.Name = "colSOLUONG2";
            this.colSOLUONG2.Visible = true;
            this.colSOLUONG2.VisibleIndex = 2;
            this.colSOLUONG2.Width = 87;
            // 
            // colDONGIA2
            // 
            this.colDONGIA2.Caption = "Đơn giá";
            this.colDONGIA2.DisplayFormat.FormatString = "VND {0:n2}";
            this.colDONGIA2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA2.FieldName = "DONGIA";
            this.colDONGIA2.MinWidth = 23;
            this.colDONGIA2.Name = "colDONGIA2";
            this.colDONGIA2.Visible = true;
            this.colDONGIA2.VisibleIndex = 3;
            this.colDONGIA2.Width = 87;
            // 
            // groupBoxPhieuXuat
            // 
            this.groupBoxPhieuXuat.Controls.Add(mAKHOLabel1);
            this.groupBoxPhieuXuat.Controls.Add(this.txtMaKho_PX);
            this.groupBoxPhieuXuat.Controls.Add(hOTENKHLabel);
            this.groupBoxPhieuXuat.Controls.Add(this.txtTenKH);
            this.groupBoxPhieuXuat.Controls.Add(mAPXLabel);
            this.groupBoxPhieuXuat.Controls.Add(this.txtMaPX);
            this.groupBoxPhieuXuat.Controls.Add(this.btnGridKho2);
            this.groupBoxPhieuXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxPhieuXuat.Location = new System.Drawing.Point(2, 28);
            this.groupBoxPhieuXuat.Name = "groupBoxPhieuXuat";
            this.groupBoxPhieuXuat.Size = new System.Drawing.Size(447, 39);
            this.groupBoxPhieuXuat.TabIndex = 0;
            this.groupBoxPhieuXuat.TabStop = false;
            this.groupBoxPhieuXuat.Text = "Thông Tin";
            // 
            // txtMaKho_PX
            // 
            this.txtMaKho_PX.Location = new System.Drawing.Point(164, 126);
            this.txtMaKho_PX.Name = "txtMaKho_PX";
            this.txtMaKho_PX.ReadOnly = true;
            this.txtMaKho_PX.Size = new System.Drawing.Size(166, 23);
            this.txtMaKho_PX.TabIndex = 16;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(164, 97);
            this.txtTenKH.MaxLength = 100;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(166, 23);
            this.txtTenKH.TabIndex = 15;
            // 
            // txtMaPX
            // 
            this.txtMaPX.Location = new System.Drawing.Point(163, 67);
            this.txtMaPX.MaxLength = 8;
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(167, 23);
            this.txtMaPX.TabIndex = 14;
            // 
            // btnGridKho2
            // 
            this.btnGridKho2.Location = new System.Drawing.Point(338, 127);
            this.btnGridKho2.Name = "btnGridKho2";
            this.btnGridKho2.Size = new System.Drawing.Size(34, 21);
            this.btnGridKho2.TabIndex = 13;
            this.btnGridKho2.Text = "...";
            this.btnGridKho2.UseVisualStyleBackColor = true;
            // 
            // panelPhieuNhap
            // 
            this.panelPhieuNhap.Controls.Add(this.splitContainer1);
            this.panelPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhieuNhap.Location = new System.Drawing.Point(0, 611);
            this.panelPhieuNhap.Name = "panelPhieuNhap";
            this.panelPhieuNhap.Size = new System.Drawing.Size(944, 70);
            this.panelPhieuNhap.TabIndex = 37;
            this.panelPhieuNhap.Text = "Phiếu Nhập";
            this.panelPhieuNhap.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gcPhieuNhap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcChiTietPhieuNhap);
            this.splitContainer1.Size = new System.Drawing.Size(940, 40);
            this.splitContainer1.SplitterDistance = 495;
            this.splitContainer1.TabIndex = 2;
            // 
            // gcPhieuNhap
            // 
            this.gcPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhieuNhap.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.gcPhieuNhap.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcPhieuNhap.EmbeddedNavigator.Appearance.Options.UseBorderColor = true;
            this.gcPhieuNhap.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gcPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.gcPhieuNhap.MainView = this.gvPN;
            this.gcPhieuNhap.MenuManager = this.barManager1;
            this.gcPhieuNhap.Name = "gcPhieuNhap";
            this.gcPhieuNhap.Size = new System.Drawing.Size(495, 40);
            this.gcPhieuNhap.TabIndex = 1;
            this.gcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPN});
            // 
            // gvPN
            // 
            this.gvPN.Appearance.HeaderPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gvPN.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.SeaGreen;
            this.gvPN.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPN.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPN.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPN.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY2,
            this.colMasoDDH2,
            this.colMANV2,
            this.colMAKHO2});
            this.gvPN.GridControl = this.gcPhieuNhap;
            this.gvPN.Name = "gvPN";
            this.gvPN.OptionsView.ShowGroupPanel = false;
            this.gvPN.OptionsView.ShowViewCaption = true;
            this.gvPN.ViewCaption = "Phiếu Nhập Của Đơn Hàng";
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Mã PN";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 23;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 87;
            // 
            // colNGAY2
            // 
            this.colNGAY2.Caption = "Ngày";
            this.colNGAY2.FieldName = "NGAY";
            this.colNGAY2.MinWidth = 23;
            this.colNGAY2.Name = "colNGAY2";
            this.colNGAY2.OptionsColumn.AllowEdit = false;
            this.colNGAY2.Visible = true;
            this.colNGAY2.VisibleIndex = 1;
            this.colNGAY2.Width = 87;
            // 
            // colMasoDDH2
            // 
            this.colMasoDDH2.Caption = "Mã DDH";
            this.colMasoDDH2.FieldName = "MasoDDH";
            this.colMasoDDH2.MinWidth = 23;
            this.colMasoDDH2.Name = "colMasoDDH2";
            this.colMasoDDH2.OptionsColumn.AllowEdit = false;
            this.colMasoDDH2.Visible = true;
            this.colMasoDDH2.VisibleIndex = 2;
            this.colMasoDDH2.Width = 87;
            // 
            // colMANV2
            // 
            this.colMANV2.Caption = "Mã NV";
            this.colMANV2.FieldName = "MANV";
            this.colMANV2.MinWidth = 23;
            this.colMANV2.Name = "colMANV2";
            this.colMANV2.OptionsColumn.AllowEdit = false;
            this.colMANV2.Visible = true;
            this.colMANV2.VisibleIndex = 3;
            this.colMANV2.Width = 87;
            // 
            // colMAKHO2
            // 
            this.colMAKHO2.Caption = "Mã Kho";
            this.colMAKHO2.FieldName = "MAKHO";
            this.colMAKHO2.MinWidth = 23;
            this.colMAKHO2.Name = "colMAKHO2";
            this.colMAKHO2.OptionsColumn.AllowEdit = false;
            this.colMAKHO2.Visible = true;
            this.colMAKHO2.VisibleIndex = 4;
            this.colMAKHO2.Width = 87;
            // 
            // gcChiTietPhieuNhap
            // 
            this.gcChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcChiTietPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.gcChiTietPhieuNhap.MainView = this.gridView5;
            this.gcChiTietPhieuNhap.MenuManager = this.barManager1;
            this.gcChiTietPhieuNhap.Name = "gcChiTietPhieuNhap";
            this.gcChiTietPhieuNhap.Size = new System.Drawing.Size(441, 40);
            this.gcChiTietPhieuNhap.TabIndex = 2;
            this.gcChiTietPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT1,
            this.colSOLUONG1,
            this.colDONGIA1});
            this.gridView5.GridControl = this.gcChiTietPhieuNhap;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.OptionsView.ShowViewCaption = true;
            this.gridView5.ViewCaption = "Chi Tiết Phiếu Nhập";
            // 
            // colMAPN1
            // 
            this.colMAPN1.Caption = "Mã PN";
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 23;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.OptionsColumn.AllowEdit = false;
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            this.colMAPN1.Width = 87;
            // 
            // colMAVT1
            // 
            this.colMAVT1.Caption = "Mã VT";
            this.colMAVT1.FieldName = "MAVT";
            this.colMAVT1.MinWidth = 23;
            this.colMAVT1.Name = "colMAVT1";
            this.colMAVT1.Visible = true;
            this.colMAVT1.VisibleIndex = 1;
            this.colMAVT1.Width = 87;
            // 
            // colSOLUONG1
            // 
            this.colSOLUONG1.Caption = "Số lượng";
            this.colSOLUONG1.FieldName = "SOLUONG";
            this.colSOLUONG1.MinWidth = 23;
            this.colSOLUONG1.Name = "colSOLUONG1";
            this.colSOLUONG1.Visible = true;
            this.colSOLUONG1.VisibleIndex = 2;
            this.colSOLUONG1.Width = 87;
            // 
            // colDONGIA1
            // 
            this.colDONGIA1.Caption = "Đơn giá";
            this.colDONGIA1.DisplayFormat.FormatString = "VND {0:n2}";
            this.colDONGIA1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA1.FieldName = "DONGIA";
            this.colDONGIA1.MinWidth = 23;
            this.colDONGIA1.Name = "colDONGIA1";
            this.colDONGIA1.Visible = true;
            this.colDONGIA1.VisibleIndex = 3;
            this.colDONGIA1.Width = 87;
            // 
            // cmsThemChiTietDonHang
            // 
            this.cmsThemChiTietDonHang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsThemChiTietDonHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsThemChiTietDonHang.Name = "contextMenuStrip1";
            this.cmsThemChiTietDonHang.Size = new System.Drawing.Size(291, 34);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(290, 30);
            this.toolStripMenuItem1.Text = "Thêm Chi Tiết Đơn Hàng";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FormLapPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 672);
            this.Controls.Add(this.panelPhieuNhap);
            this.Controls.Add(this.panelPhieuXuat);
            this.Controls.Add(this.panelDonDatHang);
            this.Controls.Add(this.gcPhieuXuat);
            this.Controls.Add(this.gcDonDatHang);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormLapPhieu";
            this.Text = "Lập Phiếu";
            this.Load += new System.EventHandler(this.FormDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDonDatHang)).EndInit();
            this.panelDonDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            this.groupBoxDonDatHang.ResumeLayout(false);
            this.groupBoxDonDatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoDonDatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCapDonDatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayDonDatHang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayDonDatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonDatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPhieuXuat)).EndInit();
            this.panelPhieuXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).EndInit();
            this.groupBoxPhieuXuat.ResumeLayout(false);
            this.groupBoxPhieuXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPhieuNhap)).EndInit();
            this.panelPhieuNhap.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.cmsThemChiTietDonHang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsDonDatHang;
        private DataSet dataSet;
        private DataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsChiTietDonHang;
        private DataSetTableAdapters.CTDDHTableAdapter chiTietDonDatHangTableAdapter;
        private System.Windows.Forms.BindingSource bdsKho;
        private DataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private DevExpress.XtraBars.BarSubItem btnMENU;
        private DevExpress.XtraBars.BarButtonItem btnDonDangHang;
        private DevExpress.XtraBars.BarButtonItem btnPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnPhieuXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DevExpress.XtraGrid.GridControl gcDonDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraGrid.GridControl gcPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO1;
        private System.Windows.Forms.BindingSource bdsPhieuXuat;
        private DataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DevExpress.XtraEditors.GroupControl panelDonDatHang;
        private DevExpress.XtraGrid.GridControl gcChiTietDonDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.GroupBox groupBoxDonDatHang;
        private System.Windows.Forms.Button btnChonKho;
        private DevExpress.XtraEditors.GroupControl panelPhieuNhap;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY2;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH2;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO2;
        private DevExpress.XtraGrid.GridControl gcChiTietPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA1;
        private DevExpress.XtraEditors.GroupControl panelPhieuXuat;
        private DevExpress.XtraGrid.GridControl gcChiTietPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG2;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA2;
        private System.Windows.Forms.GroupBox groupBoxPhieuXuat;
        public System.Windows.Forms.TextBox txtMaKho_PX;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaPX;
        private System.Windows.Forms.Button btnGridKho2;
        private DevExpress.XtraEditors.TextEdit txtMaKhoDonDatHang;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.TextEdit txtNhaCungCapDonDatHang;
        private DevExpress.XtraEditors.DateEdit dteNgayDonDatHang;
        private DevExpress.XtraEditors.TextEdit txtMaDonDatHang;
        private System.Windows.Forms.ContextMenuStrip cmsThemChiTietDonHang;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
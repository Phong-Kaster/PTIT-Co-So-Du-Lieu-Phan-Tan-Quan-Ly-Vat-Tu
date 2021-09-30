
namespace QLTVT
{
    partial class FormDonDatHang
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonDatHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnMENU = new DevExpress.XtraBars.BarSubItem();
            this.btnCheDoDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheDoChiTietDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemChiTietDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet = new QLTVT.DataSet();
            this.bdsDonDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.donDatHangTableAdapter = new QLTVT.DataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.chiTietDonDatHangTableAdapter = new QLTVT.DataSetTableAdapters.CTDDHTableAdapter();
            this.gcDonDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDDH = new DevExpress.XtraEditors.GroupControl();
            this.gcChiTietDonDatHang = new DevExpress.XtraGrid.GridControl();
            this.bdsChiTietDonDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxDonDatHang = new System.Windows.Forms.GroupBox();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.txtDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.btnChonVatTu = new System.Windows.Forms.Button();
            this.txtMaVatTu = new DevExpress.XtraEditors.TextEdit();
            this.btnChonKhoHang = new System.Windows.Forms.Button();
            this.txtNhaCungCap = new DevExpress.XtraEditors.TextEdit();
            this.dteNGAY = new DevExpress.XtraEditors.DateEdit();
            this.txtMaDonDatHang = new DevExpress.XtraEditors.TextEdit();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLTVT.DataSetTableAdapters.PhieuNhapTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).BeginInit();
            this.gcDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            this.groupBoxDonDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonDatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(31, 32);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(117, 17);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã Đơn Đặt Hàng";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(31, 58);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(31, 90);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(97, 17);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà Cung Cấp";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(31, 117);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(90, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã Nhân Viên";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(31, 148);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(53, 17);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã Kho";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(8, 30);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(70, 17);
            mAVTLabel.TabIndex = 11;
            mAVTLabel.Text = "Mã Vật Tư";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(8, 71);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(68, 17);
            sOLUONGLabel.TabIndex = 14;
            sOLUONGLabel.Text = "Số Lượng";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(9, 111);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(56, 17);
            dONGIALabel.TabIndex = 16;
            dONGIALabel.Text = "Đơn Giá";
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
            this.btnThemChiTietDonDatHang,
            this.btnMENU,
            this.btnCheDoDonDatHang,
            this.btnCheDoChiTietDonDatHang});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMENU, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "Thêm";
            this.btnTHEM.Enabled = false;
            this.btnTHEM.Id = 0;
            this.btnTHEM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHEM.ImageOptions.SvgImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(80, 0);
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Caption = "Xoá";
            this.btnXOA.Enabled = false;
            this.btnXOA.Id = 1;
            this.btnXOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXOA.ImageOptions.SvgImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(70, 0);
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnGHI
            // 
            this.btnGHI.Caption = "Ghi";
            this.btnGHI.Enabled = false;
            this.btnGHI.Id = 2;
            this.btnGHI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGHI.ImageOptions.SvgImage")));
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(70, 0);
            this.btnGHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.Caption = "Hoàn Tác";
            this.btnHOANTAC.Enabled = false;
            this.btnHOANTAC.Id = 3;
            this.btnHOANTAC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHOANTAC.ImageOptions.SvgImage")));
            this.btnHOANTAC.Name = "btnHOANTAC";
            this.btnHOANTAC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHOANTAC_ItemClick);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Caption = "Làm Mới";
            this.btnLAMMOI.Enabled = false;
            this.btnLAMMOI.Id = 4;
            this.btnLAMMOI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI.ImageOptions.SvgImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_ItemClick);
            // 
            // btnMENU
            // 
            this.btnMENU.Caption = "Chọn Chế Độ";
            this.btnMENU.Id = 8;
            this.btnMENU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMENU.ImageOptions.SvgImage")));
            this.btnMENU.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoDonDatHang),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoChiTietDonDatHang)});
            this.btnMENU.Name = "btnMENU";
            // 
            // btnCheDoDonDatHang
            // 
            this.btnCheDoDonDatHang.Caption = "Đơn Đặt Hàng";
            this.btnCheDoDonDatHang.Id = 9;
            this.btnCheDoDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCheDoDonDatHang.ImageOptions.SvgImage")));
            this.btnCheDoDonDatHang.Name = "btnCheDoDonDatHang";
            this.btnCheDoDonDatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoDonDatHang_ItemClick);
            // 
            // btnCheDoChiTietDonDatHang
            // 
            this.btnCheDoChiTietDonDatHang.Caption = "Chi Tiết Đơn Đặt Hàng";
            this.btnCheDoChiTietDonDatHang.Id = 10;
            this.btnCheDoChiTietDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCheDoChiTietDonDatHang.ImageOptions.SvgImage")));
            this.btnCheDoChiTietDonDatHang.Name = "btnCheDoChiTietDonDatHang";
            this.btnCheDoChiTietDonDatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoChiTietDonDatHang_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1007, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 719);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1007, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 689);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1007, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 689);
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 5;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            // 
            // btnThemChiTietDonDatHang
            // 
            this.btnThemChiTietDonDatHang.Caption = "Thêm Chi Tiết Đơn Đặt Hàng";
            this.btnThemChiTietDonDatHang.Id = 7;
            this.btnThemChiTietDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemChiTietDonDatHang.ImageOptions.SvgImage")));
            this.btnThemChiTietDonDatHang.Name = "btnThemChiTietDonDatHang";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbCHINHANH);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1007, 68);
            this.panelControl1.TabIndex = 5;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
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
            // donDatHangTableAdapter
            // 
            this.donDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.chiTietDonDatHangTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.donDatHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // chiTietDonDatHangTableAdapter
            // 
            this.chiTietDonDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // gcDonDatHang
            // 
            this.gcDonDatHang.DataSource = this.bdsDonDatHang;
            this.gcDonDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDonDatHang.Enabled = false;
            this.gcDonDatHang.Location = new System.Drawing.Point(0, 98);
            this.gcDonDatHang.MainView = this.gridView1;
            this.gcDonDatHang.MenuManager = this.barManager1;
            this.gcDonDatHang.Name = "gcDonDatHang";
            this.gcDonDatHang.Size = new System.Drawing.Size(1007, 197);
            this.gcDonDatHang.TabIndex = 6;
            this.gcDonDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcDonDatHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.ViewCaption = "Đơn Đặt Hàng";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã Đơn Đặt Hàng";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.OptionsColumn.AllowEdit = false;
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà Cung Cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 25;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.OptionsColumn.AllowEdit = false;
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Nhân Viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // gcDDH
            // 
            this.gcDDH.Controls.Add(this.panelControl3);
            this.gcDDH.Controls.Add(this.panelControl2);
            this.gcDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDDH.Location = new System.Drawing.Point(0, 295);
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(1007, 424);
            this.gcDDH.TabIndex = 24;
            this.gcDDH.Text = "Thông Tin";
            // 
            // gcChiTietDonDatHang
            // 
            this.gcChiTietDonDatHang.DataSource = this.bdsChiTietDonDatHang;
            this.gcChiTietDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietDonDatHang.Enabled = false;
            this.gcChiTietDonDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcChiTietDonDatHang.Location = new System.Drawing.Point(2, 2);
            this.gcChiTietDonDatHang.MainView = this.gvCTDDH;
            this.gcChiTietDonDatHang.MenuManager = this.barManager1;
            this.gcChiTietDonDatHang.Name = "gcChiTietDonDatHang";
            this.gcChiTietDonDatHang.Size = new System.Drawing.Size(511, 390);
            this.gcChiTietDonDatHang.TabIndex = 1;
            this.gcChiTietDonDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            // 
            // bdsChiTietDonDatHang
            // 
            this.bdsChiTietDonDatHang.DataMember = "FK_CTDDH_DatHang";
            this.bdsChiTietDonDatHang.DataSource = this.bdsDonDatHang;
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
            this.groupBoxDonDatHang.Controls.Add(this.txtMaNhanVien);
            this.groupBoxDonDatHang.Controls.Add(this.txtMaKho);
            this.groupBoxDonDatHang.Controls.Add(this.btnChonKhoHang);
            this.groupBoxDonDatHang.Controls.Add(mAKHOLabel);
            this.groupBoxDonDatHang.Controls.Add(mANVLabel);
            this.groupBoxDonDatHang.Controls.Add(nhaCCLabel);
            this.groupBoxDonDatHang.Controls.Add(this.txtNhaCungCap);
            this.groupBoxDonDatHang.Controls.Add(nGAYLabel);
            this.groupBoxDonDatHang.Controls.Add(this.dteNGAY);
            this.groupBoxDonDatHang.Controls.Add(masoDDHLabel);
            this.groupBoxDonDatHang.Controls.Add(this.txtMaDonDatHang);
            this.groupBoxDonDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDonDatHang.Location = new System.Drawing.Point(2, 2);
            this.groupBoxDonDatHang.Name = "groupBoxDonDatHang";
            this.groupBoxDonDatHang.Size = new System.Drawing.Size(484, 179);
            this.groupBoxDonDatHang.TabIndex = 0;
            this.groupBoxDonDatHang.TabStop = false;
            this.groupBoxDonDatHang.Text = "Đơn Hàng";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "MANV", true));
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(184, 112);
            this.txtMaNhanVien.MenuManager = this.barManager1;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(125, 22);
            this.txtMaNhanVien.TabIndex = 19;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDonDatHang, "MAKHO", true));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Location = new System.Drawing.Point(184, 142);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(125, 23);
            this.txtMaKho.TabIndex = 18;
            // 
            // txtDonGia
            // 
            this.txtDonGia.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(161, 104);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGia.Properties.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.txtDonGia.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDonGia.Size = new System.Drawing.Size(125, 24);
            this.txtDonGia.TabIndex = 17;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(161, 67);
            this.txtSoLuong.MenuManager = this.barManager1;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Properties.DisplayFormat.FormatString = "n0";
            this.txtSoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoLuong.Properties.EditFormat.FormatString = "n0";
            this.txtSoLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoLuong.Properties.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.txtSoLuong.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Size = new System.Drawing.Size(125, 24);
            this.txtSoLuong.TabIndex = 15;
            this.txtSoLuong.EditValueChanged += new System.EventHandler(this.sOLUONGSpinEdit_EditValueChanged);
            // 
            // btnChonVatTu
            // 
            this.btnChonVatTu.Enabled = false;
            this.btnChonVatTu.Location = new System.Drawing.Point(326, 30);
            this.btnChonVatTu.Name = "btnChonVatTu";
            this.btnChonVatTu.Size = new System.Drawing.Size(119, 31);
            this.btnChonVatTu.TabIndex = 13;
            this.btnChonVatTu.Text = "Chọn Vật Tư";
            this.btnChonVatTu.UseVisualStyleBackColor = true;
            this.btnChonVatTu.Click += new System.EventHandler(this.btnChonVatTu_Click);
            // 
            // txtMaVatTu
            // 
            this.txtMaVatTu.Enabled = false;
            this.txtMaVatTu.Location = new System.Drawing.Point(161, 27);
            this.txtMaVatTu.MenuManager = this.barManager1;
            this.txtMaVatTu.Name = "txtMaVatTu";
            this.txtMaVatTu.Size = new System.Drawing.Size(125, 22);
            this.txtMaVatTu.TabIndex = 12;
            // 
            // btnChonKhoHang
            // 
            this.btnChonKhoHang.Enabled = false;
            this.btnChonKhoHang.Location = new System.Drawing.Point(326, 136);
            this.btnChonKhoHang.Name = "btnChonKhoHang";
            this.btnChonKhoHang.Size = new System.Drawing.Size(119, 29);
            this.btnChonKhoHang.TabIndex = 10;
            this.btnChonKhoHang.Text = "Chọn Kho Hàng";
            this.btnChonKhoHang.UseVisualStyleBackColor = true;
            this.btnChonKhoHang.Click += new System.EventHandler(this.btnChonKhoHang_Click);
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "NhaCC", true));
            this.txtNhaCungCap.Enabled = false;
            this.txtNhaCungCap.Location = new System.Drawing.Point(184, 85);
            this.txtNhaCungCap.MenuManager = this.barManager1;
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(125, 22);
            this.txtNhaCungCap.TabIndex = 5;
            // 
            // dteNGAY
            // 
            this.dteNGAY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "NGAY", true));
            this.dteNGAY.EditValue = null;
            this.dteNGAY.Enabled = false;
            this.dteNGAY.Location = new System.Drawing.Point(184, 55);
            this.dteNGAY.MenuManager = this.barManager1;
            this.dteNGAY.Name = "dteNGAY";
            this.dteNGAY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY.Size = new System.Drawing.Size(165, 22);
            this.dteNGAY.TabIndex = 3;
            // 
            // txtMaDonDatHang
            // 
            this.txtMaDonDatHang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "MasoDDH", true));
            this.txtMaDonDatHang.Enabled = false;
            this.txtMaDonDatHang.Location = new System.Drawing.Point(184, 29);
            this.txtMaDonDatHang.MenuManager = this.barManager1;
            this.txtMaDonDatHang.Name = "txtMaDonDatHang";
            this.txtMaDonDatHang.Size = new System.Drawing.Size(125, 22);
            this.txtMaDonDatHang.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaVatTu);
            this.groupBox1.Controls.Add(mAVTLabel);
            this.groupBox1.Controls.Add(dONGIALabel);
            this.groupBox1.Controls.Add(this.btnChonVatTu);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(sOLUONGLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(2, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Đơn Hàng";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupBoxDonDatHang);
            this.panelControl2.Controls.Add(this.groupBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 28);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(488, 394);
            this.panelControl2.TabIndex = 3;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcChiTietDonDatHang);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(490, 28);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(515, 394);
            this.panelControl3.TabIndex = 4;
            // 
            // FormDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 739);
            this.Controls.Add(this.gcDDH);
            this.Controls.Add(this.gcDonDatHang);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormDonDatHang";
            this.Text = "Đơn Đặt Hàng";
            this.Load += new System.EventHandler(this.FormDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).EndInit();
            this.gcDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            this.groupBoxDonDatHang.ResumeLayout(false);
            this.groupBoxDonDatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonDatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
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
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDonDatHang;
        private DataSet dataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.Label label1;
        private DataSetTableAdapters.DatHangTableAdapter donDatHangTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl gcDDH;
        private DevExpress.XtraGrid.GridControl gcChiTietDonDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.GroupBox groupBoxDonDatHang;
        private DevExpress.XtraGrid.GridControl gcDonDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DataSetTableAdapters.CTDDHTableAdapter chiTietDonDatHangTableAdapter;
        private System.Windows.Forms.Button btnChonKhoHang;
        private DevExpress.XtraEditors.TextEdit txtNhaCungCap;
        private DevExpress.XtraEditors.DateEdit dteNGAY;
        private DevExpress.XtraEditors.TextEdit txtMaDonDatHang;
        private DevExpress.XtraBars.BarButtonItem btnThemChiTietDonDatHang;
        private DevExpress.XtraBars.BarButtonItem btnCheDoDonDatHang;
        private DevExpress.XtraBars.BarButtonItem btnCheDoChiTietDonDatHang;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private System.Windows.Forms.Button btnChonVatTu;
        private DevExpress.XtraEditors.TextEdit txtMaVatTu;
        private DevExpress.XtraEditors.SpinEdit txtDonGia;
        public DevExpress.XtraBars.BarSubItem btnMENU;
        public System.Windows.Forms.TextBox txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsChiTietDonDatHang;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
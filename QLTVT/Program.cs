using DevExpress.Skins;
using DevExpress.UserSkins;
using QLTVT.SubForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLTVT
{
    /*
    * Lý do bắt buộc phải viết biến tại đây là chỉ khi ta mở form
    * thì các biến nằm trong form đó mới hình thành, dù biến đó có tầm hoạt 
    * động toàn dự án nhưng khi cái form nào đóng lại thì các biến cũng biến mất
    * Do đó, form khác sẽ không hiểu các biến của form đã đóng nữa. Để phục vụ nhu cầu
    * xuyên suốt thì phải khai báo tại đây
    * 
    * Data Source=DELL: tên server gốc
    * Initial Catalog=QLVT_DATHANG: tên cơ sở dữ liệu
    * Integrated Security=true: đăng nhập với chế độ Window Authentication
    * 
    * public static = biến toàn cục dự án
    */
    static class Program
    {
        /**********************************************
         * conn: biến để kết nối tới cơ sở dữ liệu
         * connstr: connection String , chuỗi kết nối động
         * dataReader: 
         **********************************************/
        public static SqlConnection conn = new SqlConnection();//conn
        public static String connstr = "";//connstr
        public static String connstrPublisher = "Data Source=DELL;Initial Catalog=QLVT_DATHANG;Integrated Security=true";
        public static SqlDataReader myReader;//myReader



        /**********************************************
         * servername: tên server(phân mảnh) sẽ kết nối tới
         * 
         * serverNameLeft: chứa tên phân mảnh còn lại. Ví dụ đăng nhập vào 
         * chi nhánh 1 thì serverNameLeft là chi nhánh 2
         * 
         * username: tên username trong database sẽ kết nối.
         * Ví dụ: LT, TT là username trong mục users của database QLVT_DATHANG
         * 
         * loginName & loginPassword: tài khoản & mật khẩu dùng để 
         * đăng nhập vào server(phân mảnh)
         ***********************************************/
        public static String serverName = "";//servername
        public static String serverNameLeft = "";
        public static String userName = "";//username

        public static String loginName = "";//mlogin
        public static String loginPassword = "";//password




        /**********************************************
         *database: cơ sở dữ liệu mà ta muốn làm việc
         *
         *remoteLogin & currentLogin: Dùng 2 biến này bởi
         *đi từ server hiện tại sang server 2 => remoteLogin
         *đi từ server 2 về lại server hiện tại => currentLogin
         * 
         *Note: currentLogin & currentPassword chứa loginName & loginPassword 
         *khi từ phân mảnh khác về phân mảnh hiện tại
         *
         *Ví dụ: LT là loginName của server 1 thì qua server 2 dùng HTKN.
         *Quay về server 1 thì dùng currentLogin
         ***********************************************/
        public static String database = "QLVT_DATHANG";
        
        public static String remoteLogin = "HTKN";//remotelogin
        public static String remotePassword = "123456";//remotepassword

        public static String currentLogin = "";//mloginDN
        public static String currentPassword = "";//passwordDN




        /**********************************************
         * role: tên nhóm quyền đang đăng nhập: CONGTY - CHINHANH - USER
         * staff: tên nhân viên đang đăng nhập
         * brand: chi nhánh đang đăng nhập
         **********************************************/
        public static String role = "";// mGroup
        public static String staff = "";//mHoten
        public static int brand = 0;//mChiNhanh



        /**********************************************
         * maKhoDuocChon | maVatTuDuocChon biến lưu trữ mã kho được chọn phục vụ 
         * cho btnChonKhoHang trong phần tạo mới đơn đặt hàng
         * 
         * maSoDonDatHangDuocChon luu tru ma don hang duoc chon phuc vu
         * cho btnChonDonDatHang trong phan tao moi phieu nhap
         * soLuongVatTu bien luu tru so luong vat tu duoc chon
         * 
         **********************************************/
        public static string maKhoDuocChon = "";
        public static string maVatTuDuocChon = "";

        public static int soLuongVatTu = 0;
        public static string maDonDatHangDuocChon = "";
        public static string maDonDatHangDuocChonChiTiet = "";
        public static int donGia = 0;


        /*bidSou: BindingSource -> liên kết dữ liệu từ bảng dữ liệu vào chương trình*/
        public static BindingSource bindingSource = new BindingSource();//bds_dspm


        /*các form của toàn dữ án cũng được coi như 1 một biến toàn cục*/
        public static FormDangNhap formDangNhap;
        public static FormChinh formChinh;
        public static FormNhanVien formNhanVien;

        public static FormChuyenChiNhanh formChuyenChiNhanh;
        public static FormVatTu formVatTu;
        public static FormKho formKho;

        public static FormDonDatHang formDonDatHang;
        public static FormChonKhoHang formChonKhoHang;
        public static FormPhieuNhap formPhieuNhap;

        public static FormChonDonDatHang formChonDonDatHang;
        public static FormChonChiTietDonHang formChonChiTietDonHang;
        public static FormPhieuXuat formPhieuXuat;


        /*****************************************************
         * mở kết nối tới server 
         * @return trả về 1 nếu thành công
         *         trả về 0 nếu thất bại
         *****************************************************/
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.serverName + ";Initial Catalog=" +
                       Program.database + ";User ID=" +
                       Program.loginName + ";password=" + Program.loginPassword;
                Program.conn.ConnectionString = Program.connstr;

                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);
                //Console.WriteLine(e.Message);
                return 0;
            }
        }


        /**********************************************
         *  ExecSqlDataReader thực hiện câu lệnh mà dữ liệu trả về chỉ dùng
         *  để xem & không thao tác với nó.
         *
         *  Ví dụ: SELECT * FROM view_DanhSachPhanManh
         **********************************************/
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) 
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        /**********************************************
         * ExecSqlDataTable thực hiện câu lệnh mà dữ liệu trả về có thể
         * xem - thêm - xóa - sửa tùy ý
         * 
         * Ví dụ: SELECT * FROM dbo.NHANVIEN
         **********************************************/
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        /**********************************************
         * Cập nhật trên một stored procedure và không trả về giá trị
         **********************************************/
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;

            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.formChinh = new FormChinh();
            Application.Run(formChinh);
        }
    }
}

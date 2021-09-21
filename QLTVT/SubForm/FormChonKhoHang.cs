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
    public partial class FormChonKhoHang : Form
    {
        public FormChonKhoHang()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormChonKhoHang_Load(object sender, EventArgs e)
        {
            /*không kiểm tra khóa ngoại nữa*/
            dataSet.EnforceConstraints = false;
            this.khoHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoHangTableAdapter.Fill(this.dataSet.Kho);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maKhoHang =  ((DataRowView)bdsKhoHang.Current)["MAKHO"].ToString();

            /*Cach nay phai tuy bien ban moi chay duoc*/
            //Program.formDonDatHang.txtMaKho.Text = maKhoHang;


            Program.maKhoDuocChon = maKhoHang;
            this.Close(); 
        }
    }
}

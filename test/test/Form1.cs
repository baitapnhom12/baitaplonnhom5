using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test
{
    public partial class Form1 : Form
    {
        bool check = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThanhtien_Click(object sender, EventArgs e)
        {
            //kiem tra so luong
            try
            {
                double SoLuong = double.Parse(txtSoLuong.Text);
            }
            catch
            {
                check = false;
                MessageBox.Show("Nhập sai ô số lượng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //kiem tra gia ca
            try
            {
                double Giaca = double.Parse(txtGiaCa.Text);
            }
            catch
            {
                check = false;
                MessageBox.Show("Nhập sai ô giá cả", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (check == true)
            {
                tinhsp.GIACA = double.Parse(txtGiaCa.Text);
                tinhsp.SOLUONG = double.Parse(txtSoLuong.Text);
                
                check = tinhsp.kiemtrathanhtien();              
                if (check == false)
                {
                    MessageBox.Show("Phương thức tính toán không hợp lệ");
                }
                else
                {
                    txtThanhTien.Enabled = true;
                    
                    txtThanhTien.Text = tinhsp.ThanhTien().ToString();
                }
            }
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            txt_inhoadon.Text = "Mã Sản Phẩm : " + txtmasp.Text + Environment.NewLine
                + "Tên Sản Phẩm : " + txttensp.Text + Environment.NewLine
                + "Số Lượng : " + txtSoLuong.Text + Environment.NewLine
                + "Giá Bán : " + txtGiaCa.Text + Environment.NewLine
            + "Thành Tiền : " + txtThanhTien.Text + "VND";
                
        }
        SqlConnection con;
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-1HMQ03V\HUANVH;Initial Catalog=QLCuaHangX;Integrated Security=True");
            con.Open();
            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSelect = "SELECT *FROM tblQuanLyCuaHang";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btn_ThucHien_Click(object sender, EventArgs e)
        {
            if (radioBt_Them.Checked == true)
            {

                {
                    string sqlThem = "INSERT INTO tblQuanLyCuaHang VALUES(@masp,@tensp,@soluong,@giaban)";
                    SqlCommand cmd = new SqlCommand(sqlThem, con);
                    cmd.Parameters.AddWithValue("masp", txtmasp.Text);
                    cmd.Parameters.AddWithValue("tensp", txttensp.Text);
                    cmd.Parameters.AddWithValue("soluong", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("giaban", txtGiaCa.Text);
                    cmd.ExecuteNonQuery();
                    Hienthi();
                }
                MessageBox.Show("Thêm thành công ?");
            }
            if (radioBt_Xoa.Checked == true)
            {
                if (MessageBox.Show("Bạn có muốn xóa ?",
                    "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sqlXoa = "DELETE tblQuanLyCuaHang  WHERE MaSP=@MaSP";
                    SqlCommand cmd = new SqlCommand(sqlXoa, con);
                    cmd.Parameters.AddWithValue("masp", txtmasp.Text);
                    cmd.Parameters.AddWithValue("tensp", txttensp.Text);
                    cmd.Parameters.AddWithValue("soluong", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("giaban", txtGiaCa.Text);
                    cmd.ExecuteNonQuery();
                    Hienthi();
                }
            }
            if (radioBt_Sua.Checked == true)
            {
                {
                    string sqlSua = "UPDATE tblQuanLyCuaHang  SET tensp=@tensp,soluong=@soluong,giaban=@giaban WHERE  masp=@masp";
                    SqlCommand cmd = new SqlCommand(sqlSua, con);
                    cmd.Parameters.AddWithValue("MaSP", txtmasp.Text);
                    cmd.Parameters.AddWithValue("TenSP", txttensp.Text);
                    cmd.Parameters.AddWithValue("soluong", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("giaban", txtGiaCa.Text);
                    cmd.ExecuteNonQuery();
                    Hienthi();
                }
                MessageBox.Show("Sửa thành công ?");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?",
                "Chú Ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_ReSet_Click(object sender, EventArgs e)
        {
            txtmasp.Text = "";
            txttensp.Text = "";
            txtSoLuong.Text = "";
            txtGiaCa.Text = "";
            txtThanhTien.Text = "";
            txt_inhoadon.Text = "";
            txt_timkiem.Text = "";
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "SELECT *FROM tblQuanLyCuaHang  WHERE masp=@masp";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("MaSP", txt_timkiem.Text);
            cmd.Parameters.AddWithValue("TenSP", txttensp.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("SoDienThoai", txtGiaCa.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}

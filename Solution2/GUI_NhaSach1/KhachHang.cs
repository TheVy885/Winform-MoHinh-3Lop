using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_NhaSach;
using BUS_NhaSach;


namespace GUI_NhaSach1
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        BUS_ThongTinSach thongTinSach1 = new BUS_ThongTinSach();
        BUS_DatHang datHang1 = new BUS_DatHang();

        private void KhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = thongTinSach1.getThongTinSach();
            dataGridView2.DataSource = datHang1.getHoaDon();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;

            txt_masach.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_tensach.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_tacgia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString(); // ngay xuat ban
            txt_kichthuoc.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_sotrang.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt_nxb.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txt_gia.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txt_tongsoluong.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int j;
            j = dataGridView2.CurrentRow.Index;

            txt_msdh.Text = dataGridView2.Rows[j].Cells[0].Value.ToString();
            txt_hotenkhachhang.Text = dataGridView2.Rows[j].Cells[1].Value.ToString();
            txt_diachi.Text = dataGridView2.Rows[j].Cells[2].Value.ToString();
            txt_sodienthoai.Text = dataGridView2.Rows[j].Cells[3].Value.ToString(); // ngay xuat ban
            txt_masachdh.Text = dataGridView2.Rows[j].Cells[4].Value.ToString();
            txt_tensachdh.Text = dataGridView2.Rows[j].Cells[5].Value.ToString();
            txt_soluong.Text = dataGridView2.Rows[j].Cells[6].Value.ToString();
            txt_giadh.Text = dataGridView2.Rows[j].Cells[7].Value.ToString();
            txt_thanhtien.Text = dataGridView2.Rows[j].Cells[8].Value.ToString();
            dateTimePicker3.Text = dataGridView2.Rows[j].Cells[9].Value.ToString();
            txt_magiamgia.Text = dataGridView2.Rows[j].Cells[10].Value.ToString();
        }

        void KhoitaoTTSach()
        {
            txt_masach.Text = "";
            txt_tensach.Text = "";
            txt_tacgia.Text = "";
            dateTimePicker1.Text = ""; // ngay xuat ban
            txt_kichthuoc.Text = "";
            txt_sotrang.Text = "";
            txt_nxb.Text = "";
            txt_gia.Text = "";
            txt_tongsoluong.Text = "";
            dateTimePicker2.Text = "";
        }

        void KhoiTaoHD()
        {
            txt_msdh.Text = "";
            txt_hotenkhachhang.Text = "";
            txt_diachi.Text = "";
            txt_sodienthoai.Text = "";
            txt_masachdh.Text = "";
            txt_tensachdh.Text = "";
            txt_soluong.Text = "";
            txt_giadh.Text = "";
            txt_thanhtien.Text = "";
            dateTimePicker3.Text = "";
            txt_magiamgia.Text = "";
        }

        private void btn_capnhatsach_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = thongTinSach1.getThongTinSach();
        }

        private void btn_khoitaosach_Click(object sender, EventArgs e)
        {
            KhoitaoTTSach();
        }

        private void btn_timsach_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0)
            {
                string id = "";
                txt_masach.Text = txt_masach.Text.ToString();
                txt_tensach.Text = txt_tensach.Text.ToString();
                if (txt_masach.Text != "")
                {
                    id = Convert.ToString(txt_masach.Text);
                }
                else if (txt_tensach.Text != "")
                {
                    id = Convert.ToString(txt_tensach.Text);
                }
                DTO_ThongTinSach1 thongTinSach = new DTO_ThongTinSach1(txt_masach.Text, txt_tensach.Text, txt_tacgia.Text, dateTimePicker1.Value, txt_kichthuoc.Text, txt_sotrang.Text, txt_nxb.Text, txt_gia.Text, txt_tongsoluong.Text, dateTimePicker2.Value);
                if (thongTinSach1.timSach(id))
                {
                    MessageBox.Show("Kết quả tìm kiếm ");
                    dataGridView1.DataSource = thongTinSach1.timSach(txt_tensach.Text);

                }
                else
                {
                    MessageBox.Show("Tìm ko thành công");
                }


            }
            else
            {
                MessageBox.Show("Kiểm tra tên cần tìm");
            }
        }

        private void btn_laythongtin_Click(object sender, EventArgs e)
        {
            txt_masachdh.Text = txt_masach.Text;
            txt_tensachdh.Text = txt_tensach.Text;
            txt_giadh.Text = txt_gia.Text;
        }

        private void btn_thanhtien_Click(object sender, EventArgs e)
        {
            int gia = Convert.ToInt32(txt_giadh.Text);
            int soluong = Convert.ToInt32(txt_soluong.Text);
            int thanhtien = gia * soluong;
            txt_thanhtien.Text = Convert.ToString(thanhtien);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            var DR = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Cảnh Báo", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_khoitaohd_Click(object sender, EventArgs e)
        {
            KhoiTaoHD();
        }

        private void btn_capnhathd_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = datHang1.getHoaDon();
        }

        private void btn_apdungkm_Click(object sender, EventArgs e)
        {
            if (txt_giadh.Text != "")
            {
                int giadh = Convert.ToInt32(txt_giadh.Text);
                if (txt_magiamgia.Text == "GiamGia10%" && giadh >= 200000)
                {
                    giadh = giadh - (giadh * 10) / 100;


                }

                if (txt_magiamgia.Text == "GiamGia5%" && giadh < 200000)
                {
                    giadh = giadh - (giadh * 5) / 100;

                }
                txt_giadh.Text = giadh.ToString();
                MessageBox.Show("Khuyến Mãi Chỉ Được Áp Dụng 1 Lần Cho Mỗi Hóa Đơn!\n Nếu Thay Đổi Số Lượng Thì Cần Nhập Lại Giá Ban Đầu Của Sản Phẩm!", "Chú Ý!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần áp dụng Khuyến Mãi!", "Thông Báo");
            }
        }

        private void btn_ctkm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình khuyến mãi !!! \n" + "Khuyến mãi giảm giá đồng loạt các sản phẩm \n " + "Giảm giá 5% khi nhập mã : GiamGia5% cho các sản phẩm dưới 200000 \n" + "Giảm giá 10% khi nhập mã : GiamGia10% cho các sản phẩm trên 200000 \n", "Thông Báo!");
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_timhd_Click(object sender, EventArgs e)
        {

        }

        private void btn_timkhachhang_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_themhd_Click(object sender, EventArgs e)
        {
            if (txt_msdh.Text != "" && txt_hotenkhachhang.Text != "" && txt_diachi.Text != "" && txt_sodienthoai.Text != "" && txt_masachdh.Text != "" && txt_tensachdh.Text != "" && txt_soluong.Text != "" && txt_giadh.Text != "")
            {
                int gia = Convert.ToInt32(txt_giadh.Text);         //thanh tien cho hoa don neu nhan them hoa don ma chua nhan thanh tien
                int soluong = Convert.ToInt32(txt_soluong.Text);
                int thanhtien = gia * soluong;
                txt_thanhtien.Text = Convert.ToString(thanhtien);

                DTO_DatHang datHang = new DTO_DatHang(txt_msdh.Text, txt_hotenkhachhang.Text, txt_diachi.Text, txt_sodienthoai.Text, txt_masachdh.Text, txt_tensachdh.Text, txt_soluong.Text, txt_giadh.Text, txt_thanhtien.Text, dateTimePicker3.Value, txt_magiamgia.Text);
                if (datHang1.themHoaDon(datHang))
                {
                    MessageBox.Show("Thêm thành công!");

                    dataGridView2.DataSource = datHang1.getHoaDon();
                }

                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy kiểm tra lại thông tin");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_NhaSach
{
    public class DTO_DatHang
    {
        private string _MSDH;
        private string _HoTenKhachHang;
        private string _DiaChi;
        private string _SoDienThoai;
        private string _MaSach;
        private string _TenSach;
        private string _SoLuong;
        private string _Gia;
        private string _ThanhTien;
        private DateTime _NgayDatHang;
        private string _MaGiamGia;

        public string MSDH { get; set; }
        public string HoTenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string SoLuong { get; set; }
        public string Gia { get; set; }
        public string ThanhTien { get; set; }
        public DateTime NgayDatHang { get; set; }
        public string MaGiamGia { get; set; }

        public DTO_DatHang()
        {

        }

        public DTO_DatHang(string MSDH,string HoTenKhachHang, string DiaChi, string SoDienThoai,string MaSach,string TenSach,string SoLuong,string Gia,string ThanhTien,DateTime NgayDatHang,string MaGiamGia)
        {
            this.MSDH = MSDH;
            this.HoTenKhachHang = HoTenKhachHang;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
            this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.SoLuong = SoLuong;
            this.Gia = Gia;
            this.ThanhTien = ThanhTien;
            this.NgayDatHang = NgayDatHang;
            this.MaGiamGia = MaGiamGia;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_NhaSach
{
    public class DTO_ThongTinSach1
    {
        private string _MaSach;
        private string _TenSach;
        private string _TacGia;
        private string _NgayXuatBan;
        private string _KichThuoc;
        private string _SoTrang;
        private string _NXB;
        private string _Gia;
        private string _TongSoLuong;
        private string _NgayNhapKho;

        public string MaSach { get; set; }

        public  string TenSach { get; set; }

        public string TacGia { get; set; }
        public DateTime NgayXuatBan { get; set; }
        public string KichThuoc { get; set; }
        public string SoTrang { get; set; }

        public string NXB { get; set; }

        public string Gia { get; set; }

        public string TongSoLuong { get; set; }

        public DateTime NgayNhapKho { get; set; }

        public DTO_ThongTinSach1()
        {

        }
        
        public DTO_ThongTinSach1(string MaSach, string TenSach,string TacGia, DateTime NgayXuatBan,string KichThuoc,string SoTrang, string NXB,string Gia,string TongSoLuong,DateTime NgayNhapKho)
        {
            this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.TacGia = TacGia;
            this.NgayXuatBan = NgayXuatBan;
            this.KichThuoc = KichThuoc;
            this.SoTrang = SoTrang;
            this.NXB = NXB;
            this.Gia = Gia;
            this.TongSoLuong = TongSoLuong;
            this.NgayNhapKho = NgayNhapKho;
            
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_NhaSach;
using DTO_NhaSach;

namespace BUS_NhaSach
{
    public class BUS_DatHang
    {
        DAL_DatHang DAL_DatHang = new DAL_DatHang();

        public DataTable getHoaDon()
        {
            return DAL_DatHang.getHoaDon();
        }

        public bool themHoaDon(DTO_DatHang datHang)
        {
            return DAL_DatHang.themHoaDon(datHang);
        }
        public bool suaHoaDon(DTO_DatHang datHang)
        {
            return DAL_DatHang.suaHoaDon(datHang);
        }
        public bool xoaHoaDon(string MSDH)
        {
            return DAL_DatHang.xoaHoaDon(MSDH);
        }

        public bool timHoaDon(string MSDH)
        {
            return DAL_DatHang.timHoaDon(MSDH);
        }

        public bool timKhachHang(string HoTenKhachHang)
        {
            return DAL_DatHang.timKhachHang(HoTenKhachHang);
        }
    }
}

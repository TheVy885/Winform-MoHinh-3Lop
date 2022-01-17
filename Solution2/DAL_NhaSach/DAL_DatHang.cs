using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_NhaSach;
using DAL_NhaSach;


namespace DAL_NhaSach
{
   public class DAL_DatHang:DBConnect
    {
        public DataTable getHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from HDChiTietDatHang", _con);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }

        

        public bool themHoaDon(DTO_DatHang datHang)
        {
            try
            {
                _con.Open();
                string sql = string.Format("insert into HDChiTietDatHang(MSDH,HoTenKhachHang,DiaChi,SoDienThoai,MaSach,TenSach,SoLuong,Gia,ThanhTien,NgayDatHang,MaGiamGia)Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},{8},'{9}','{10}')", datHang.MSDH,datHang.HoTenKhachHang,datHang.DiaChi,datHang.SoDienThoai,datHang.MaSach,datHang.TenSach,datHang.SoLuong,datHang.Gia,datHang.ThanhTien,datHang.NgayDatHang,datHang.MaGiamGia);
                SqlCommand cmd = new SqlCommand(sql, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _con.Close();
            }

            return true;
        }

        public bool suaHoaDon(DTO_DatHang datHang)
        {
            try
            {
                _con.Open();
                string sql = string.Format("Update HDChiTietDatHang set HoTenKhachHang='{1}',DiaChi='{2}',SoDienThoai='{3}',MaSach='{4}',TenSach='{5}',SoLuong={6},Gia={7},ThanhTien={8},NgayDatHang='{9}',MaGiamGia='{10}' Where MSDH = '{0}'", datHang.MSDH, datHang.HoTenKhachHang, datHang.DiaChi, datHang.SoDienThoai, datHang.MaSach, datHang.TenSach, datHang.SoLuong, datHang.Gia, datHang.ThanhTien, datHang.NgayDatHang, datHang.MaGiamGia);

                SqlCommand cmd = new SqlCommand(sql, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _con.Close();
            }

            return false;

        }

        public bool xoaHoaDon(string MSDH)
        {
            try
            {
                _con.Open();
                string sql = string.Format("DELETE FROM HDChiTietDatHang WHERE MSDH = '{0}'", MSDH);
                SqlCommand cmd = new SqlCommand(sql, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _con.Close();
            }

            return false;

        }

        public bool timHoaDon(string MSHD)
        {
            try
            {
                _con.Open();
                string sql = string.Format("select * from HDChiTietDatHang where MSHD like '%" + MSHD + "%'");
                SqlCommand cmd = new SqlCommand(sql, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _con.Close();
            }

            return false;
        }

        public bool timKhachHang(string HoTenKhachHang)
        {
            try
            {
                _con.Open();
                string sql = string.Format("select * from HDChiTietDatHang where HoTenKhachHang like '%" + HoTenKhachHang + "%'");
                SqlCommand cmd = new SqlCommand(sql, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _con.Close();
            }

            return false;
        }

    }
}

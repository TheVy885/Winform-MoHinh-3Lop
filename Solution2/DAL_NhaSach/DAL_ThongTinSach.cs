using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_NhaSach;



namespace DAL_NhaSach
{
    public class DAL_ThongTinSach:DBConnect
    {
        public DataTable getThongTinSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from ThongTinSach", _con);
            DataTable dtThongTinSach = new DataTable();
            da.Fill(dtThongTinSach);
            return dtThongTinSach;
        }

        

        public bool themSach(DTO_ThongTinSach1 nhasach)
        {
            try
            {
                _con.Open();
                string sql = string.Format("insert into ThongTinSach(MaSach,TenSach,TacGia,NgayXuatBan,KichThuoc,SoTrang,NXB,Gia,TongSoLuong,NgayNhapKho)Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},{8},'{9}')", nhasach.MaSach, nhasach.TenSach, nhasach.TacGia, nhasach.NgayXuatBan, nhasach.KichThuoc, nhasach.SoTrang, nhasach.NXB, nhasach.Gia, nhasach.TongSoLuong, nhasach.NgayNhapKho);
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

        public bool suaSach(DTO_ThongTinSach1 nhasach)
        {
            try
            {
                _con.Open();
                string sql = string.Format("Update ThongTinSach set TenSach='{1}',TacGia='{2}',NgayXuatBan='{3}',KichThuoc='{4}',SoTrang='{5}',NXB='{6}',Gia= {7},TongSoLuong= {8},NgayNhapKho='{9}'" +
                    "WHERE MaSach = '{0}'", nhasach.MaSach, nhasach.TenSach, nhasach.TacGia, nhasach.NgayXuatBan, nhasach.KichThuoc, nhasach.SoTrang, nhasach.NXB, nhasach.Gia, nhasach.TongSoLuong, nhasach.NgayNhapKho);

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
        public bool xoaSach(string MaSach)
        {
            try
            {
                _con.Open();
                string sql = string.Format("DELETE FROM ThongTinSach WHERE MaSach = '{0}'", MaSach);
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

        public bool timSach(string TenSach)
        {
            try
            {
                _con.Open();
                string sql = string.Format(@"select * from ThongTinSach where TENSACH like '%" + TenSach + "%'");
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

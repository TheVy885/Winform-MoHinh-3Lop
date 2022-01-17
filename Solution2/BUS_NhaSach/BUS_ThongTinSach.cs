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
    public class BUS_ThongTinSach
    {
        DAL_ThongTinSach dal_ThongTinSach = new DAL_ThongTinSach();

        public DataTable getThongTinSach()
        {
            return dal_ThongTinSach.getThongTinSach();
        }
        public bool themSach(DTO_ThongTinSach1 nhasach)
        {
            return dal_ThongTinSach.themSach(nhasach);
        }
        public bool suaSach(DTO_ThongTinSach1 nhasach)
        {
            return dal_ThongTinSach.suaSach(nhasach);
        }
        public bool xoaSach(string MaSach)
        {
            return dal_ThongTinSach.xoaSach(MaSach);
        
        
        }

        public bool timSach(string TenSach)
        {
            return dal_ThongTinSach.timSach(TenSach);
        }

    }
}

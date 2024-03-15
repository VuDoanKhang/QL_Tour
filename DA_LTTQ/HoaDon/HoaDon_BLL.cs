using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QLTour
{
    class HoaDon_BLL
    {        
        HoaDon_DAL dalHoaDon;
        public HoaDon_BLL()
        {
            dalHoaDon = new HoaDon_DAL();
        }

        public int GetSoHD()
        {
            return dalHoaDon.GetSoHD();
        }

        public DataTable getAllHoaDon()
        {
            return dalHoaDon.getAllHoaDon();
        }

        public bool InsertHoaDon(tbl_HoaDon hoadon)
        {
            return dalHoaDon.InsertHoaDon(hoadon);
        }
       /* public bool Insert(tbl_HoaDon hoadon)
        {
            return dalHoaDon.InSert(hoadon);
        }*/
        public DataTable ThongKe_DoanhThu_Nam(tbl_HoaDon hoadon)
        {
            return dalHoaDon.ThongKe_DoanhThu_Nam(hoadon);
        }

        public bool DeleteHoaDon(tbl_HoaDon hoadon)
        {
            return dalHoaDon.DeleteHoaDon(hoadon);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL h = new HoaDonDAL();

        public HoaDonBLL()
        {

        }

        public int? GetThanhTien(int ma)
        {
            return h.GetTongTien(ma);
        }

        public void ThemCTHD(int maHD, string maSP, int sl)
        {
            h.ThemCTHD(maHD, maSP, sl);
        }

        public void SuaCTHD(int maHD, string maSP, int sl)
        {
            h.SuaCTHD(maHD, maSP, sl);
        }

        public bool KiemTraKhoaChinh(int maHD, string maSP)
        {
            return h.KiemTraKhoaChinh(maHD, maSP);
        }

        public DataTable GetCTHD(int ma)
        {
            return h.GetCTHD(ma);
        }
    }
}
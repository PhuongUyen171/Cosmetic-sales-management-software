using DAL.dsShopMPTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        HOA_DONTableAdapter h = new HOA_DONTableAdapter();
        CHI_TIET_HOA_DONTableAdapter c = new CHI_TIET_HOA_DONTableAdapter();
        SAN_PHAMTableAdapter s = new SAN_PHAMTableAdapter();
        public HoaDonDAL() { }

        //public void ThemHoaDon(string maKH, string maNV, DateTime thGian, int giamGia)
        //{
        //    h.InsertBill(maKH, maNV, thGian, giamGia);
        //}

        public int? GetTongTien(int ma)
        {
            return Convert.ToInt32(h.GetTongTienTheoMa(ma));
        }

        public void ThemCTHD(int maHD, string maSP,int sl)
        {
            //DataRow dr = s.SearchProduct(maSP).FirstOrDefault();
            //int von = Convert.ToInt32(dr["GiaVon"].ToString());
            //int ban = Convert.ToInt32(dr["GiaBan"].ToString());
            //c.InsertDetailBill(maHD, maSP,von, ban, sl);
            c.InsertCTHD(maHD, maSP, sl);
        }

        public void SuaCTHD(int maHD, string maSP,int sl)
        {
            c.UpdateCTHD(sl, maHD, maSP);
        }

        public bool KiemTraKhoaChinh(int maHD,string maSP)
        {
            return c.KiemTraKhoaChinh(maHD, maSP) != 0;
        }

        public DataTable GetCTHD(int ma)
        {
            //if(c.GetData(ma).Rows.Count!=0)
                return c.GetData(ma);
            //else
                //return null;
        }
    }
}

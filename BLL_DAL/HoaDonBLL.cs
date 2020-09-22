using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class HoaDonBLL
    {
        QLShopDataContext data = new QLShopDataContext();

        public HoaDonBLL() { }

        public int ThemHoaDon(string maKH,string maNV,DateTime thoiGian,int giamGia)
        {
            HOA_DON hd = new HOA_DON();
            hd.MaKH = maKH;
            hd.MaNV = maNV;
            hd.ThoiGian = thoiGian;
            hd.GiamGia = giamGia;
            hd.TongTien = 0;
            data.HOA_DONs.InsertOnSubmit(hd);
            data.SubmitChanges();
            return hd.MaHD;
        }

        public void ThemCTHD(int maHD, int maSP, int sl)
        {
            SanPhamBLL s = new SanPhamBLL();
            CHI_TIET_HOA_DON c = new CHI_TIET_HOA_DON();
            c.MaHD = maHD;
            c.MaSP = maSP;
            c.SoLuong = sl;
            c.GiaBan = s.TimKiemSanPham(maSP).GiaBan;
            c.GiaVon = s.TimKiemSanPham(maSP).GiaVon;
            data.CHI_TIET_HOA_DONs.InsertOnSubmit(c);
            data.SubmitChanges();
        }

        public IQueryable<CHI_TIET_HOA_DON> GetCTHD(int maHD)
        {
            return data.CHI_TIET_HOA_DONs.Where(t => t.MaHD == maHD);
        }

        public void SuaCTHD(int maHD, int maSP, int sl)
        {
            CHI_TIET_HOA_DON c = data.CHI_TIET_HOA_DONs.Where(t => t.MaHD == maHD && t.MaSP == maSP).FirstOrDefault();
            c.SoLuong = sl;
            data.SubmitChanges();
        }

        public void XoaCTHD(int maHD,int maSP)
        {
            CHI_TIET_HOA_DON c = data.CHI_TIET_HOA_DONs.Where(t => t.MaHD == maHD && t.MaSP == maSP).FirstOrDefault();
            data.CHI_TIET_HOA_DONs.DeleteOnSubmit(c);
            data.SubmitChanges();
        }

        public int? GetTongTien(int maHD)
        {
            //var tatca = from n in data.NXBs  select new { n.MaNXB,n.TenNXB,tongCong=n.SACHes.Sum(t=>t.SoLuong)};
            var tc = from t in data.HOA_DONs where t.MaHD==maHD select new {tongCong=t.CHI_TIET_HOA_DONs.Sum(n=>n.GiaBan*n.SoLuong)};
            return Convert.ToInt32(tc.FirstOrDefault().tongCong);
        }

        public bool KiemTraKhoaChinh(int maHD, int maSP)
        {
            CHI_TIET_HOA_DON c = data.CHI_TIET_HOA_DONs.Where(t => t.MaHD == maHD && t.MaSP == maSP).FirstOrDefault();
            return c != null;
        }
        
    }
}

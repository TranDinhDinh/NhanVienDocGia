using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viên
{
    [Serializable] 
    
    internal class Nhân_Viên
    {
        private string m_maNhanVien;
        private string m_hoTen;
        private DateTime m_ngaySinh;
        private string m_gioiTinh;
        private string m_chucVu;
        private DateTime m_ngayBD;
        private double m_luong;
        private string m_soDienThoai;
        private string m_diaChi;
        public Nhân_Viên() {
            m_maNhanVien = "";
            m_hoTen = "";
            m_ngaySinh = DateTime.Now;
            m_gioiTinh = "";
            m_chucVu = "";
            m_ngayBD = DateTime.Now;
            m_luong = 0;
            m_soDienThoai = "";
            m_diaChi = "";
        }
        public Nhân_Viên(string maNhanVien, string hoTen, DateTime ngaySinh, string gioiTinh, string chucVu, DateTime ngayBD, double luong, string soDienThoai, string diaChi)
        {
            m_maNhanVien = maNhanVien;
            m_hoTen = hoTen;
            m_ngaySinh = ngaySinh;
            m_gioiTinh = gioiTinh;
            m_chucVu = chucVu;
            m_ngayBD = ngayBD;
            m_luong = luong;
            m_soDienThoai = soDienThoai;
            m_diaChi = diaChi;
        }
        public string MaNhanVien
        {
            get { return m_maNhanVien;}
            set {  m_maNhanVien = value;}
        }
        public string HoTen
        {
            get { return m_hoTen;}
            set { m_hoTen = value;}
        }
        public DateTime NgaySinh
        {
            get { return m_ngaySinh; }
            set { m_ngaySinh = value; }
        }
        public string GioiTinh
        {
            get { return m_gioiTinh; }
            set { m_gioiTinh = value; }
        }
        public string ChucVu
        {
            get { return m_chucVu; }
            set { m_chucVu = value;}
        }
        public DateTime NgayBD
        {
            get { return m_ngayBD; }
            set { m_ngayBD = value;}
        }
        public double Luong
        {
            get { return m_luong; }
            set { m_luong = value; }
        }
        public string SoDienThoai
        {
            get { return m_soDienThoai; }
            set { m_soDienThoai = value; }
        }
        public string DiaChi
        {
            get { return m_diaChi;}
            set { m_diaChi = value;}
        }
    }
}

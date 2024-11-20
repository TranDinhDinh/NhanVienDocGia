using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viên
{
    [Serializable]
    internal class DocGia
    {
        private string m_maNguoi;
        private string m_hoTen;
        private DateTime m_NgaySinh;
        private string m_soDienThoai;
        private DateTime m_ngayDKi;
        private DateTime m_hanthe;
        private int m_soSachMuonMua;
        private string m_diaChi;
        private string m_gioitinh;

        public string MaNguoi
        {
            get { return m_maNguoi; }
            set { m_maNguoi = value;}
        }
        public string HoTen
        {
            get { return m_hoTen; }
            set { m_hoTen = value; }
        }
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value;}
        }
        public string soDienThoai
        {
            get { return m_soDienThoai; }
            set { m_soDienThoai = value; }
        }
        public DateTime NgayDangKi
        {
            get { return m_ngayDKi; }
            set { m_ngayDKi = value; }
        }
        public DateTime hanThe
        {
            get { return m_hanthe;}
            set { m_hanthe = value;}
        }
        public int soSachMuonMua
        {
            get { return m_soSachMuonMua; }
            set { m_soSachMuonMua = value; }
        }
        public string diaChi
        {
            get { return m_diaChi;}
            set { m_diaChi = value;}
        }
        public string gioiTinh
        {
            get { return m_gioitinh; }
            set { m_gioitinh = value; }
        }

        public DocGia()
        {
            m_maNguoi = "";
            m_hoTen = "";
            m_NgaySinh = DateTime.Now;
            m_soDienThoai = "";
            m_ngayDKi =DateTime.Now;
            m_hanthe = DateTime.Now;
            m_soSachMuonMua = 0;
            m_diaChi = "";
            m_gioitinh = "";

        }
        public DocGia(string maNguoi, string hoTen, DateTime ngaySinh, string soDienThoai, DateTime ngayDKi, DateTime hanthe, int soSachMuonMua, string diaChi, string gioitinh)
        {
            m_maNguoi = maNguoi;
            m_hoTen = hoTen;
            m_NgaySinh = ngaySinh;
            m_soDienThoai = soDienThoai;
            m_ngayDKi = ngayDKi;
            m_hanthe = hanthe;
            m_soSachMuonMua = soSachMuonMua;
            m_diaChi = diaChi;
            m_gioitinh = gioitinh;
        }

        
    }
}

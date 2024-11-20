using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viên
{
    internal class xuLyNV
    {
        private Dictionary<string, Nhân_Viên> dsNV;
        public xuLyNV(){
            dsNV = new Dictionary<string, Nhân_Viên>();
        }
        public List<Nhân_Viên> layDSnhanvien() // lưu nhiều nhân viên
        {
            return dsNV.Values.ToList();
        }
        public void them(Nhân_Viên nv)
        {
            dsNV.Add(nv.MaNhanVien , nv);
        }
        public void xoa(string ma)
        {
            dsNV.Remove(ma);
        }
        public Nhân_Viên tim(string ma)
        {
            try
            {
                return dsNV[ma];
            }
            catch
            {
                return null;
            }
        }
        public void sua(Nhân_Viên nv)
        {
            if(tim(nv.MaNhanVien) != null)
            {
                dsNV[nv.MaNhanVien] = nv;
            }
        }
        public bool ghiFILE(string tenfile)
        {
            using (Stream file = File.Open(tenfile, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, dsNV);
                return true;
            }
        }
        public bool docFILE(string tenfile)
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(tenfile))
            {
                using (FileStream readerFilestream = new FileStream(tenfile, FileMode.Open, System.IO.FileAccess.Read))
                {
                    dsNV = (Dictionary<string, Nhân_Viên>)bf.Deserialize(readerFilestream);
                    return true;
                }
            }
            return false;
        }
    }
}

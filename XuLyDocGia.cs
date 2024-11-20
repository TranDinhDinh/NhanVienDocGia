using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viên.Properties
{
    internal class XuLyDocGia
    {
        private Dictionary<string, DocGia> dsDG;
        public XuLyDocGia()
        {
            dsDG = new Dictionary<string, DocGia>();
        }
        public List<DocGia> layDSDocGia()
        {
            return dsDG.Values.ToList();
        }
        public void them(DocGia dg)
        {
            dsDG.Add(dg.MaNguoi, dg);
        }
        public void xoa(string ma)
        {
            dsDG.Remove(ma);
        }
        public DocGia tim(string ma)
        {
            try
            {
                return dsDG[ma];
            }
            catch { 
            return null;}
        }
        public void sua(DocGia ma)
        {
            if(tim(ma.MaNguoi) !=null)
            {
                dsDG[ma.MaNguoi] = ma;
            }
        }
        public bool ghiFILE(string tenfile)
        {
            using (Stream file = File.Open(tenfile, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, dsDG);
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
                    dsDG = (Dictionary<string, DocGia>)bf.Deserialize(readerFilestream);
                    return true;
                }
            }
            return false;
        }
    }
}

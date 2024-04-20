using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiOnTapHK2
{
    internal class NhanVienTheoGio : iNhanVien
    {
        List<string> dsCongViec = new List<string>();
        string _maSo;
        int _namSinh;
        string _ten;
        int _tienGio;
        public string MaSo { get { return _maSo; } }
        public int NamSinh { get { return _namSinh; } set { if (value < 0) value = 1; _namSinh = value; } }
        public string Ten { get { return _ten; } set { _ten = value; } }
        public int TienGio { get { return _tienGio; } set { if (value < 0) value = 1; _tienGio = value; } }
        
        public NhanVienTheoGio() 
        {

        }

        public NhanVienTheoGio(string ms, string ten, int nams, int tienGio)
        {
            ms = MaSo;
            ten = Ten;
            nams = NamSinh;
            tienGio = TienGio;
        }
        public NhanVienTheoGio(string line)
        {
            string[] dsnvtg = line.Split(';');
            _maSo = dsnvtg[1];
            Ten = dsnvtg[2];
            NamSinh = int.Parse(dsnvtg[3]);
            string[] b = dsnvtg[4].Split(',');
            foreach (var n in b)
            {
                dsCongViec.Add(n);
            }
            TienGio = int.Parse(dsnvtg[5]);
        }
        public override string ToString()
        {
            return string.Format($"|Theo gio |{MaSo.PadLeft(6)} |{Ten.PadRight(15)} |{NamSinh.ToString().PadRight(8)} |{(string.Join(",", dsCongViec)).PadRight(37)} |{TienGio.ToString().PadLeft(10)} |");
        }
    }
}


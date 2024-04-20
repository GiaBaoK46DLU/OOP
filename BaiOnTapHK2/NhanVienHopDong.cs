using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiOnTapHK2
{
    public class NhanVienHopDong : iNhanVien
    {
        public List<string> _dsNguoiThan = new List<string>();
        private float _heSoLuong;
        private string _maSo;
        private int _namSinh;
        private string _ten;
        public float HeSoLuong { get { return _heSoLuong; } set { if (value < 0) value = 1; _heSoLuong = value; } }
        public string MaSo { get { return _maSo; } }
        public int NamSinh { get { return _namSinh; } set { if (value < 0) value = 1; _namSinh = value; } }
        public string Ten { get { return _ten; } set { _ten = value; } }
        public NhanVienHopDong()
        {

        }

        public NhanVienHopDong(string ms, string ten, int nams, float heso)
        {
            ms = this.MaSo;
            ten = this.Ten;
            nams = this.NamSinh;
            heso = HeSoLuong;

        }
        public NhanVienHopDong(string line)
        {
            string[] dsnvhd = line.Split(';');
            _maSo = dsnvhd[1];
            Ten = dsnvhd[2];
            NamSinh = int.Parse(dsnvhd[3]);
            string[] a = (dsnvhd[4]).Split(',');
            foreach (var n in a)
            {
                _dsNguoiThan.Add(n);
            }
            HeSoLuong = float.Parse(dsnvhd[5]);
        }
        public override string ToString()
        {
            return string.Format($"|Hop dong |{MaSo.PadLeft(6)} |{Ten.PadRight(15)} |{NamSinh.ToString().PadRight(8)} |{string.Join(",", _dsNguoiThan).PadRight(38)}|{HeSoLuong.ToString().PadLeft(10)} |");
        }
    }
}

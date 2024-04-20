using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BaiOnTapHK2
{
    delegate int SoSanh(object a, object b);

    internal class DanhSachNhanVien
    {
        List<iNhanVien> dsnhanvien = new List<iNhanVien>();

        public iNhanVien this[int index]
        {
            get { return this.dsnhanvien[index]; }
            set { this.dsnhanvien[index] = value; }
        }

        public DanhSachNhanVien()
        {

        }

        public void Them(iNhanVien tailieu)
        {
            this.dsnhanvien.Add(tailieu);
        }

        public int Count
        {
            get { return this.dsnhanvien.Count; }
        }

        public void NhapTuFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                string[] s = str.Split(';');
                if (s[0] == "HopDong")
                {
                    Them(new NhanVienHopDong(str));
                }
                if (s[0] == "TheoGio")
                {
                    Them(new NhanVienTheoGio(str));
                }
            }
        }
        public string XuatTieuDe()
        {
            string s = "|Nhân viên".PadRight(10) + "| Mã số ".PadLeft(6) + "|Tên".PadRight(17) + "|Năm sinh ".PadRight(9) + "|Người thân/Công việc".PadRight(39) + "|Hệ số lương".PadRight(10) + "|";
            return s;
        }
        public override string ToString()
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('=', 98));
            sb.AppendLine(XuatTieuDe());
            sb.AppendLine(new string('=', 98));
            foreach (var n in this.dsnhanvien)
            {
                sb.AppendLine(n.ToString());
            }
            sb.AppendLine(new string('=', 98));
            return sb.ToString();
        }
        public DanhSachNhanVien NVLonTuoiNhat()
        {
            DanhSachNhanVien kq = new DanhSachNhanVien();
            float min = dsnhanvien.Min(x => x.NamSinh);
            kq.dsnhanvien = dsnhanvien.FindAll(x => x.NamSinh == min);
            return kq;
        }
        public void SapXepDanhSach(SoSanh ss)   
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = i; j < Count; j++)
                {
                    if (ss(this.dsnhanvien[i], this.dsnhanvien[j]) == 1)
                    {
                        iNhanVien a = this.dsnhanvien[i];
                        this.dsnhanvien[i] = this.dsnhanvien[j];
                        this.dsnhanvien[j] = a;
                    }
                }
            }
        }
        public void XoaNV(string t)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Ten == t)
                {
                    this.dsnhanvien.Remove(this[i]);
                }
            }
        }
        public DanhSachNhanVien TimTenNVCoNguoiThanLamCung()
        {
            DanhSachNhanVien kq = new DanhSachNhanVien();
            foreach (var item in dsnhanvien)
            {
                if (item is NhanVienHopDong)
                {
                    foreach (var item1 in ((NhanVienHopDong)item)._dsNguoiThan)
                    {
                        if (dsnhanvien.FindIndex(x => x.Ten == item1) != -1)
                        {
                            kq.Them(item);
                            break;
                        }
                    }
                }
            }
            return kq;
        }
    }
}

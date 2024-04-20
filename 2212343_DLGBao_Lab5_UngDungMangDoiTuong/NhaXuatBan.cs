using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212343_DLGBao_Lab5_UngDungMangDoiTuong
{
    internal class NhaXuatBan
    {
        public string Ten;
        public string DiaChi;
        public string SoDT;

        public NhaXuatBan() 
        {
            SoDT = "0000";
        }
        public NhaXuatBan(string t, string dc, string sdt)
        {
            Ten = t;
            DiaChi = dc;
            SoDT = sdt;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap SDT: ");
            SoDT = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine($"Ten: {Ten}, Dia Chi: {DiaChi}, SoDT: {SoDT}");
        }
        public NhaXuatBan(string nxb)
        {
            string[] s = nxb.Split(',');
            Ten = s[0];
            DiaChi = s[1];
            SoDT = s[2];
        }
    }
}

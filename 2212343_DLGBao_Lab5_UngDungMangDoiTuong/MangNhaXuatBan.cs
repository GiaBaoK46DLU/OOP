using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2212343_DLGBao_Lab5_UngDungMangDoiTuong
{
    internal class MangNhaXuatBan
    {
        List<NhaXuatBan> collection = new List<NhaXuatBan>();

        public void Nhap()
        {
            NhaXuatBan gd = new NhaXuatBan();
            gd.Ten = "Nha xuat ban Giao duc 1";
            gd.DiaChi = "01 Phu Dong Thien Vuong";
            gd.SoDT = "1345";

            NhaXuatBan gd2 = new NhaXuatBan("Nha xuat ban Giao duc 2", "01 Phu Dong Thien Vuong", "1345");
            Them(gd);
            Them(gd2);
        }
        public void Xuat()
        {
            foreach (var item in collection)
            {
                item.Xuat();
            }
        }
        public void Them(NhaXuatBan n)
        {
            collection.Add(n);
        }
        public void NhapTuFile()
        {
            string TenFile = @"D:\C#\2212343_DLGBao_Lab5_UngDungMangDoiTuong\bin\Debug\data.csv.csv";
            StreamReader sr = new StreamReader(TenFile);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                //Console.WriteLine(s);
                NhaXuatBan n = new NhaXuatBan(s);
                collection.Add(n);
            }
        }

        public MangNhaXuatBan TimTatCaNXBCoDiaChiTranPhu()
        {
            MangNhaXuatBan kq = new MangNhaXuatBan();
            foreach (var item in collection)
            {
                if (item.DiaChi.Contains("Tran Phu"))
                {
                    kq.Them(item);
                }
            }
            return kq;
        }
    }
}

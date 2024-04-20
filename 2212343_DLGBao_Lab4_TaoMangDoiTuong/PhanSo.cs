using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212343_DLGBao_Lab3_QuanLyPhanSo
{
    internal class PhanSo
    {
        public int tu;
        public int mau;
        public PhanSo()
        {

        }
        public PhanSo(int t, int m)
        {
            tu = t;
            mau = m;
        }
        public void Nhap()
        {
            Console.Write("Nhap tu ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau ");
            mau = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($" =>  {tu}/{mau} ");
        }
        public PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau + a.mau * b.tu;
            kq.mau = a.mau * b.mau;
            return kq;
        }
        public PhanSo Tru(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau - a.mau * b.tu;
            kq.mau = a.mau * b.mau;
            return kq;
        }
        public PhanSo Nhan(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.tu;
            kq.mau = a.mau * b.mau;
            return kq;
        }
        public PhanSo Chia(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau;
            kq.mau = a.mau * b.tu;
            return kq;
        }
    }
    class MangPhanSo
    {
        List<PhanSo> collection = new List<PhanSo>();

        public void Nhap()
        {
            Console.Write(" Nhap chieu dai mang ");
            int length = int.Parse(Console.ReadLine());

            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                collection.Add(new PhanSo(r.Next(10), r.Next(10)));//Tạo số ngẫu nhiên trong [0,10]
            }
        }

        public void Xuat()
        {
            foreach (var item in collection)
            {
                item.Xuat();
            }
        }
    }
}

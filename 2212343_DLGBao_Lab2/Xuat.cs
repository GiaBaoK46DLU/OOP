using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212343_DLGBao_Lab2
{
    internal class SinhVien
    {
        public string MSSV;
        public string Ten;
        public int Tuoi;
        public string SDT;
        public string DiaChi;
        public SinhVien()
        {

        }
        public SinhVien(string a, string b, int c, string d, string e)
        {
            MSSV = a;
            Ten = b;
            Tuoi = c;
            SDT = d;
            DiaChi = e;
        }
        public void Xuat()
        {
            Console.WriteLine($" Sinh vien {MSSV}, Ten : {Ten}, Tuoi : {Tuoi}, Dia chi : {DiaChi} , SDT : {SDT} ");
        }
    }
}
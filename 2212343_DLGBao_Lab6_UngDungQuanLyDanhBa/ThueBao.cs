using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyDanhBa
{
    public enum GioiTinh
    {
        Nam,
        Nu
    }
    internal class ThueBao
    {
        string diaChi;
        GioiTinh gioiTinh;
        string hoTen;
        DateTime ngaySinh;
        string soDT;
        string soCMND;
        public ThueBao()
        {

        }
        public ThueBao(string diaChi, GioiTinh gioiTinh, string hoTen, DateTime ngaySinh, string soDT, string soCMND)
        {
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.soDT = soDT;
            this.soCMND = soCMND;
        }

        public ThueBao(string tb)
        {
            string[] s = tb.Split(',');
            soCMND = s[0];
            hoTen = s[1];
            ngaySinh = DateTime.ParseExact(s[2], "MM/dd/yyyy", null);
            gioiTinh = (GioiTinh)(s[3] == "Nam" ? 1 : 0);
            soDT = s[4];
            diaChi = s[5];
        }
        public void Xuat()
        {
            Console.WriteLine($"So CMND: {soCMND}| Ho ten: {hoTen}| Ngay sinh: {ngaySinh.ToShortDateString()}| Gioi tinh: {gioiTinh}|SDT: {soDT}| Dia chi: {diaChi}|");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
        }
        public string ThanhPho
        {
            get
            {
                int vt = diaChi.LastIndexOf('-');//gắn vị trí của biến vt bắt đầu từ vị trí của dấu - cuối trong dãy 
                return diaChi.Substring(vt + 1, diaChi.Length - vt - 1);//lấy những kí tự từ sau dấu - đến hết chuỗi
            }
        }
        public string KhachSuDung
        {
            get
            {
                int vt = hoTen.LastIndexOf('-');//gắn vị trí của biến vt bắt đầu từ vị trí của dấu - cuối trong dãy 
                return hoTen.Substring(vt + 1, hoTen.Length - vt - 1);//lấy những kí tự từ sau dấu - đến hết chuỗi
            }
        }
    }
}
